using Resturant.Model;
using Resturant.Print;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class OrderED : Form
    {
        private string appPath,categoryId;

        private Items item;

        private Employee employee;

        private Orders orders;

        private OrderItems orderItems;

        private KitchenOrder kitchenOrder;

        private OrderKitchenItems orderKitchenItems;

        private DataTable dataItems;

        private Dictionary<string,List<double>> cart_items;

        private double qtyChanged;

        private Hashtable orderDependencies;

        MessageSnatcher _snatcher;

        private bool isEditOrders;

        private string orderId;

        public OrderED(Hashtable order)
        {
            InitializeComponent();

            this.isEditOrders = false;
            this.orderDependencies = order;
            this.cart_items = new Dictionary<string, List<double>>();
            this.employee = new Employee();

            DataTable employeesData = this.employee.getWaiterEmployees();

            if (employeesData.Rows.Count > 0)
            {
                cb_server.DataSource = employeesData;
                cb_server.ValueMember = "id";
                cb_server.DisplayMember = "name";
                cb_server.SelectedIndex = 0;
            }


            btn_prepayment.Enabled = false;

            lbl_orderType.Text = order["orderTypeName"].ToString();

            if(!order["orderTypeName"].ToString().Equals("dine_in"))
            {
                lbl_dfloor.Text = "";
                lbl_dzone.Text = "";
                lbl_dtable.Text = "";
            }

            if(order.Contains("table_name"))
            {
                lbl_table.Text = order["table_name"].ToString();
            }
            else
            {
                lbl_table.Text = "";
            }

            if(order.ContainsKey("floor_name"))
            {
                lbl_floor.Text = order["floor_name"].ToString();
            }
            else
            {
                lbl_floor.Text = "";
            }

            if(order.ContainsKey("zone_name"))
            {
                lbl_zone.Text = order["zone_name"].ToString();
            }
            else
            {
                lbl_zone.Text = "";
            }

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ItemsImages\";

            item = new Items();
            DataTable dataItem = item.getItemsWithCategoriesCount();

            panelCatButtons.Controls.Clear();
            bool setFirstCategoryItems = true;
            foreach (DataRow row in dataItem.Rows)
            {
                Button button = new Button();
                button.Name = row["category_id"].ToString();
                button.Text = row["name"].ToString() + "   (" + row["count"].ToString() + ")";
                button.Visible = true;
                button.Height = 50;
                button.Dock = DockStyle.Top;
                button.Click += Button_Click;
                if (setFirstCategoryItems)
                {
                    this.categoryId = row["category_id"].ToString();
                    this.loadItem(this.categoryId);
                    setFirstCategoryItems = false;
                }
                panelCatButtons.Controls.Add(button);
            }

        }

        public OrderED(string order_id)
        {
            InitializeComponent();

            btn_bookOrder.Text = "Edit Order";

            this.isEditOrders = true;
            this.cart_items = new Dictionary<string, List<double>>();
            this.orders = new Orders();
            this.orders.Id = order_id;
            this.orderId = order_id;
            
            DataTable orderDetails = this.orders.getOrderDetail();

            if(orderDetails.Rows.Count > 0)
            {
                if (!orderDetails.Rows[0]["order_type"].ToString().Equals("dine_in"))
                {
                    lbl_dfloor.Text = "";
                    lbl_dzone.Text = "";
                    lbl_dtable.Text = "";
                }

                this.dgv_cart.Rows.Clear();

                try
                {
                    foreach (DataRow row in orderDetails.Rows)
                    {
                        int index = dgv_cart.Rows.Add();

                        dgv_cart.Rows[index].Cells["id"].Value = row["id1"].ToString();
                        dgv_cart.Rows[index].Cells["item_id"].Value = row["item_id"].ToString();
                        dgv_cart.Rows[index].Cells["items"].Value = row["item_name"].ToString();
                        dgv_cart.Rows[index].Cells["category_id"].Value = row["id2"].ToString();
                        dgv_cart.Rows[index].Cells["category_name"].Value = row["name"].ToString();
                        dgv_cart.Rows[index].Cells["kitchen_id"].Value = row["kitchen_id"].ToString();
                        dgv_cart.Rows[index].Cells["kitchen_name"].Value = row["kitchen_name"].ToString();
                        dgv_cart.Rows[index].Cells["apply_discount"].Value = row["apply_discount"].ToString();
                        dgv_cart.Rows[index].Cells["discount"].Value = row["discount"].ToString();
                        dgv_cart.Rows[index].Cells["qty"].Value = row["item_qty"].ToString();
                        dgv_cart.Rows[index].Cells["rates"].Value = row["item_price"].ToString();
                        dgv_cart.Rows[index].Cells["total"].Value = row["total1"].ToString();
                        if (row["additional_note"].ToString().Equals("null"))
                        {
                            dgv_cart.Rows[index].Cells["notes"].Value = "";
                        }
                        else
                        {
                            dgv_cart.Rows[index].Cells["notes"].Value = row["additional_note"].ToString();
                        }

                        this.cart_items.Add(row["item_id"].ToString(), new List<double>() { Convert.ToDouble(row["item_discount"].ToString()), Convert.ToDouble(row["total1"].ToString()) });
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                lbl_discount.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
                lbl_total.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[1]));

                this.employee = new Employee();
                DataTable employeesData = this.employee.getWaiterEmployees();

                if (employeesData.Rows.Count > 0)
                {
                    cb_server.DataSource = employeesData;
                    cb_server.ValueMember = "id";
                    cb_server.DisplayMember = "name";
                    cb_server.SelectedValue = orderDetails.Rows[0]["server_id"].ToString();
                }

                lbl_orderType.Text = orderDetails.Rows[0]["order_type"].ToString();
                lbl_table.Text = orderDetails.Rows[0]["table_name"].ToString();
                lbl_floor.Text = orderDetails.Rows[0]["floor"].ToString();
                lbl_zone.Text = orderDetails.Rows[0]["zone"].ToString();
            }

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ItemsImages\";

            item = new Items();
            DataTable dataItem = item.getItemsWithCategoriesCount();

            panelCatButtons.Controls.Clear();
            bool setFirstCategoryItems = true;
            foreach (DataRow row in dataItem.Rows)
            {
                Button button = new Button();
                button.Name = row["category_id"].ToString();
                button.Text = row["name"].ToString() + "   (" + row["count"].ToString() + ")";
                button.Visible = true;
                button.Height = 50;
                button.Dock = DockStyle.Top;
                button.Click += Button_Click;
                if (setFirstCategoryItems)
                {
                    this.categoryId = row["category_id"].ToString();
                    this.loadItem(this.categoryId);
                    setFirstCategoryItems = false;
                }
                panelCatButtons.Controls.Add(button);
            }

        }

        private void btn_prepayment_Click(object sender, EventArgs e)
        {
            string discount = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
            string total = Convert.ToString(this.cart_items.Sum(x => x.Value[1]));

            DataTable orderDetails = this.orders.getOrderDetail();

            int sum_qty = 0;

            if (orderDetails.Rows.Count > 0)
            {
                List<OrderReceipt> list = new List<OrderReceipt>();

                foreach (DataRow row in orderDetails.Rows)
                {
                    sum_qty += Convert.ToInt16(row["item_qty"].ToString());
                    list.Add(new OrderReceipt()
                        {
                            item_id = row["item_id"].ToString(),
                            item_name = row["item_name"].ToString(),
                            item_discount = row["item_discount"].ToString(),
                            item_total = row["total1"].ToString(),
                            item_qty = row["item_qty"].ToString(),
                            price = row["item_price"].ToString()
                        }
                    );
                }

                Employee emp = new Employee();
                string server_name = emp.getServerNameById(orderDetails.Rows[0]["server_id"].ToString());

                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add("total", total);
                item.Add("discount", discount);
                item.Add("table_id", orderDetails.Rows[0]["table_id"].ToString());
                item.Add("table_name", orderDetails.Rows[0]["table_name"].ToString());
                item.Add("floor", orderDetails.Rows[0]["floor"].ToString());
                item.Add("zone", orderDetails.Rows[0]["zone"].ToString());
                item.Add("server_id", orderDetails.Rows[0]["server_id"].ToString());
                item.Add("server_name", server_name);
                item.Add("sum_qty", Convert.ToString(sum_qty));
                item.Add("user_name", orderDetails.Rows[0]["user_name"].ToString());
                item.Add("order_type", orderDetails.Rows[0]["order_type"].ToString().ToUpper());

                using (OrderPrePaymentPrint orderPrePayment = new OrderPrePaymentPrint(list,item))
                {
                    if (orderPrePayment.ShowDialog() != DialogResult.OK)
                    {
                        // do some thing 
                    }
                }
            }
        }

        private void btn_finalReceipt_Click(object sender, EventArgs e)
        {
            string discount = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
            string total = Convert.ToString(this.cart_items.Sum(x => x.Value[1]));

            DataTable orderDetails = this.orders.getOrderDetail();

            if (orderDetails.Rows.Count > 0)
            {
                using (OrderPaymentForm ordePayment = new OrderPaymentForm(total,discount,orderDetails))
                {
                    if (ordePayment.ShowDialog() != DialogResult.OK)
                    {
                        // do some thing 
                    }
                }
            }

        }

        private void btn_kitchenReceipt_Click(object sender, EventArgs e)
        {
            using (KitchenReceiptForm okr = new KitchenReceiptForm(this.orderId))
            {
                if (okr.ShowDialog() != DialogResult.OK)
                {
                    // do some thing 
                }
            }
        }

        private void btn_bookOrder_Click(object sender, EventArgs e)
        {
            if (this.isEditOrders.Equals(true))
            {
                this.orders = new Orders();
                this.orders.Id = this.orderId;

                if (this.dgv_cart.RowCount > 0)
                {
                    DataTable table = this.orders.getOrderDetail();
                    if(table.Rows.Count > 0)
                    {
                        try
                        {
                            List<string> deleted = new List<string>();
                            List<string> added = new List<string>();
                            // update or delete previous added items
                            foreach (DataGridViewRow gv_row in dgv_cart.Rows)
                            {
                                foreach(DataRow row in table.Rows)
                                {
                                    if (this.cart_items.ContainsKey(row["item_id"].ToString()))
                                    {
                                        if (Convert.ToInt16(gv_row.Cells["item_id"].Value.ToString()).Equals(Convert.ToInt16(row["item_id"].ToString())))
                                        {
                                            #region Update

                                            if (!Convert.ToDouble(gv_row.Cells["qty"].Value.ToString()).Equals(Convert.ToDouble(row["item_qty"].ToString())))
                                            {
                                                this.orderItems = new OrderItems();
                                                this.orderItems.Id = gv_row.Cells["id"].Value.ToString();
                                                this.orderItems.Item_qty = gv_row.Cells["qty"].Value.ToString();
                                                this.orderItems.Item_discount = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(0).ToString();
                                                this.orderItems.Total = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(1).ToString();

                                                if (gv_row.Cells["notes"].Value == null)
                                                {
                                                    this.orderItems.Additional_notes = "";
                                                }
                                                else
                                                {
                                                    this.orderItems.Additional_notes = gv_row.Cells["notes"].Value.ToString();
                                                }

                                                if (this.orderItems.updateOrderItem())
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    throw new Exception("There is some problem while updating record");
                                                }
                                            }

                                            if (gv_row.Cells["notes"].Value == null)
                                            {
                                                this.orderItems = new OrderItems();
                                                this.orderItems.Id = gv_row.Cells["id"].Value.ToString();
                                                this.orderItems.Item_qty = gv_row.Cells["qty"].Value.ToString();
                                                this.orderItems.Item_discount = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(0).ToString();
                                                this.orderItems.Total = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(1).ToString();
                                                this.orderItems.Additional_notes = "";

                                                if (this.orderItems.updateOrderItem())
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    throw new Exception("There is some problem while updating record");
                                                }
                                            }
                                            else
                                            {
                                                if (gv_row.Cells["notes"].Value.ToString().Equals(row["additional_note"].ToString()))
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    this.orderItems = new OrderItems();
                                                    this.orderItems.Id = gv_row.Cells["id"].Value.ToString();
                                                    this.orderItems.Item_qty = gv_row.Cells["qty"].Value.ToString();
                                                    this.orderItems.Item_discount = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(0).ToString();
                                                    this.orderItems.Total = this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(1).ToString();
                                                    this.orderItems.Additional_notes = gv_row.Cells["notes"].Value.ToString();

                                                    if (this.orderItems.updateOrderItem())
                                                    {
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        throw new Exception("There is some problem while updating record");
                                                    }
                                                }

                                            }

                                            #endregion
                                        }
                                        else
                                        {
                                            //if( table.Select().ToList().Exists( x => x.Field<string>("item_id").Equals(gv_row.Cells["item_id"].Value.ToString()) ))
                                            if(table.AsEnumerable().Any(x => x["item_id"].ToString() == gv_row.Cells["item_id"].Value.ToString()))
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                #region Add

                                                if(added.Contains(gv_row.Cells["item_id"].Value.ToString()))
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    this.orderItems = new OrderItems(this.orders);
                                                    this.orderItems.Item_id = gv_row.Cells["item_id"].Value.ToString();
                                                    this.orderItems.Item_name = gv_row.Cells["items"].Value.ToString();
                                                    this.orderItems.Item_discount = Convert.ToString(this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(0));
                                                    this.orderItems.Total = Convert.ToString(this.cart_items[gv_row.Cells["item_id"].Value.ToString()].ElementAt(1));
                                                    this.orderItems.Item_qty = gv_row.Cells["qty"].Value.ToString();
                                                    this.orderItems.Item_price = gv_row.Cells["rates"].Value.ToString();
                                                    if (gv_row.Cells["notes"].Value == null)
                                                    {
                                                        this.orderItems.Additional_notes = "";
                                                    }
                                                    else
                                                    {
                                                        this.orderItems.Additional_notes = gv_row.Cells["notes"].Value.ToString();
                                                    }
                                                    this.orderItems.Kitchen_name = gv_row.Cells["kitchen_name"].Value.ToString();
                                                    this.orderItems.Kitchen_id = gv_row.Cells["kitchen_id"].Value.ToString();
                                                    if (this.orderItems.insertOrderItem())
                                                    {
                                                        added.Add(gv_row.Cells["item_id"].Value.ToString());
                                                        this.kitchenOrder = new KitchenOrder(this.orders);
                                                        this.kitchenOrder.Kitchen_id = gv_row.Cells["kitchen_id"].Value.ToString();
                                                        if (this.kitchenOrder.checkKitchenExistWithOrder())
                                                        {
                                                            this.orderKitchenItems = new OrderKitchenItems(this.orders);
                                                            this.orderKitchenItems.Kitchen_id = gv_row.Cells["kitchen_id"].Value.ToString();
                                                            this.orderKitchenItems.Item_id = gv_row.Cells["item_id"].Value.ToString();
                                                            this.orderKitchenItems.Token = this.kitchenOrder.getId();
                                                            if (this.orderKitchenItems.insertOrderKitchenItem())
                                                            {
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                throw new Exception("Kitchen order item not updated");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (this.kitchenOrder.insertKitchenOrder())
                                                            {
                                                                this.kitchenOrder.holdLastInsertedId();
                                                                this.orderKitchenItems = new OrderKitchenItems(this.orders);
                                                                this.orderKitchenItems.Kitchen_id = gv_row.Cells["kitchen_id"].Value.ToString();
                                                                this.orderKitchenItems.Item_id = gv_row.Cells["item_id"].Value.ToString();
                                                                this.orderKitchenItems.Token = this.kitchenOrder.Id;
                                                                if (this.orderKitchenItems.insertOrderKitchenItem())
                                                                {
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    throw new Exception("Kitchen order item not updated");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                throw new Exception("Kitchen order not updated");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        throw new Exception("Order item not updated");
                                                    }
                                                }

                                                #endregion
                                            }
                                        }
                                    }
                                    else
                                    {
                                        #region Delete

                                        if(deleted.Contains(row["item_id"].ToString()))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            this.orderItems = new OrderItems(this.orders);
                                            this.orderItems.Id = row["id1"].ToString();
                                            if ( this.orderItems.deleteOrderItem() )
                                            {
                                                this.orderItems.Kitchen_id = row["kitchen_id"].ToString();
                                                if(this.orderItems.checkIfExistKitchen())
                                                {
                                                    this.orderKitchenItems = new OrderKitchenItems(this.orders);
                                                    this.orderKitchenItems.Kitchen_id = row["kitchen_id"].ToString();
                                                    if (this.orderKitchenItems.deleteOrderKitchenItem())
                                                    {
                                                        deleted.Add(row["item_id"].ToString());
                                                        continue;
                                                    }
                                                }
                                                else
                                                {
                                                    this.kitchenOrder = new KitchenOrder(this.orders);
                                                    this.kitchenOrder.Kitchen_id = row["kitchen_id"].ToString();
                                                    if (this.kitchenOrder.deleteKitchenOrder())
                                                    {
                                                        this.orderKitchenItems = new OrderKitchenItems(this.orders);
                                                        this.orderKitchenItems.Kitchen_id = row["kitchen_id"].ToString();
                                                        if(this.orderKitchenItems.deleteOrderKitchenItem())
                                                        {
                                                            deleted.Add(row["item_id"].ToString());
                                                            continue;
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        #endregion
                                    }
                                }
                            }
                            // When successfully updated order
                            MessageBox.Show("Order edit successfully");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            this.orders = null;
                        }
                    }
                    else
                    {
                        // When successfully updated order
                        MessageBox.Show("Nothing to update");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("please add atleast one item","Notice",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    this.Close();
                }
            }
            else
            {
                if (dgv_cart.RowCount > 0)
                {
                    bool isDineIn;
                    this.orders = new Orders();
                    this.orders.Order_type_id = this.orderDependencies["orderTypeID"].ToString();
                    this.orders.Order_type = this.orderDependencies["orderTypeName"].ToString();
                    if (this.orderDependencies["orderTypeName"].ToString().Equals("dine_in"))
                    {
                        isDineIn = true;
                        this.orders.Table_id = this.orderDependencies["table_id"].ToString();
                        this.orders.Table_name = this.orderDependencies["table_name"].ToString();
                        this.orders.Floor = this.orderDependencies["floor_name"].ToString();
                        this.orders.Zone = this.orderDependencies["zone_name"].ToString();
                    }
                    else
                    {
                        isDineIn = false;
                    }
                    this.orders.Order_status_id = "1";
                    this.orders.Server_id = cb_server.SelectedValue.ToString();
                    this.orders.Server_name = cb_server.SelectedText.ToString();
                    this.orders.User_id = Convert.ToString(Login.user_id);
                    this.orders.User_name = Login.name;
                    if (this.orders.createOrder(isDineIn))
                    {
                        this.orders.holdLastInsertedId();
                        this.orderItems = new OrderItems(this.orders);
                        foreach (DataGridViewRow row in dgv_cart.Rows)
                        {
                            this.orderItems.Item_id = row.Cells["item_id"].Value.ToString();
                            this.orderItems.Item_name = row.Cells["items"].Value.ToString();
                            this.orderItems.Item_discount = Convert.ToString(this.cart_items[row.Cells["item_id"].Value.ToString()].ElementAt(0));
                            this.orderItems.Total = Convert.ToString(this.cart_items[row.Cells["item_id"].Value.ToString()].ElementAt(1));
                            this.orderItems.Item_qty = row.Cells["qty"].Value.ToString();
                            this.orderItems.Item_price = row.Cells["rates"].Value.ToString();
                            if ( row.Cells["notes"].Value == null)
                            {
                                this.orderItems.Additional_notes = "";
                            }
                            else
                            {
                                this.orderItems.Additional_notes = row.Cells["notes"].Value.ToString();
                            }
                            this.orderItems.Kitchen_id = row.Cells["kitchen_id"].Value.ToString();
                            this.orderItems.Kitchen_name = row.Cells["kitchen_name"].Value.ToString();
                            if(this.orderItems.insertOrderItem())
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        DataTable newOrderItems = this.orderItems.getLastInsertedOrderItems();
                        List<string> kitchenIdList = new List<string>();
                        if(newOrderItems.Rows.Count > 0)
                        {
                            this.kitchenOrder = new KitchenOrder(this.orders);
                            this.orderKitchenItems = new OrderKitchenItems(this.orders);

                            foreach (DataRow row in newOrderItems.Rows)
                            {
                                if(kitchenIdList.Count > 0)
                                {
                                    if( kitchenIdList.Contains( row["kitchen_id"].ToString() ) )
                                    {
                                        this.kitchenOrder.holdLastInsertedId();
                                        this.orderKitchenItems.Kitchen_id = row["kitchen_id"].ToString();
                                        this.orderKitchenItems.Item_id = row["item_id"].ToString();
                                        this.orderKitchenItems.Token = this.kitchenOrder.getId();
                                        if (this.orderKitchenItems.insertOrderKitchenItem())
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            throw new Exception("There is some problem while inserting records");
                                        }
                                    }
                                    else
                                    {
                                        this.kitchenOrder.Kitchen_id = row["kitchen_id"].ToString();
                                        kitchenIdList.Add(this.kitchenOrder.Kitchen_id);
                                        if (!this.kitchenOrder.checkKitchenExistWithOrder())
                                        {
                                            if (this.kitchenOrder.insertKitchenOrder())
                                            {
                                                this.kitchenOrder.holdLastInsertedId();
                                                this.orderKitchenItems.Kitchen_id = row["kitchen_id"].ToString();
                                                this.orderKitchenItems.Item_id = row["item_id"].ToString();
                                                this.orderKitchenItems.Token = this.kitchenOrder.Id;
                                                if (this.orderKitchenItems.insertOrderKitchenItem())
                                                {
                                                    continue;
                                                }
                                                else
                                                {
                                                    throw new Exception("There is some problem while inserting records");
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("There is some problem while inserting records");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    this.kitchenOrder.Kitchen_id = row["kitchen_id"].ToString();
                                    kitchenIdList.Add(this.kitchenOrder.Kitchen_id);
                                    if (!this.kitchenOrder.checkKitchenExistWithOrder())
                                    {
                                        if(this.kitchenOrder.insertKitchenOrder())
                                        {
                                            this.kitchenOrder.holdLastInsertedId();
                                            this.orderKitchenItems.Kitchen_id = row["kitchen_id"].ToString();
                                            this.orderKitchenItems.Item_id = row["item_id"].ToString();
                                            this.orderKitchenItems.Token = this.kitchenOrder.Id;
                                            if (this.orderKitchenItems.insertOrderKitchenItem())
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                throw new Exception("There is some problem while inserting records");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("There is some problem while inserting records");
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Order created successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select atleast one item", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_itemSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txt_itemSearch.Text.ToString();
            if(name.Length > 0)
            {
                item = new Items();
                this.dataItems = new DataTable();
                this.dataItems.Clear();
                this.dataItems = item.searchItem(name,"Name");
                FLP_items.Controls.Clear();
                foreach (DataRow row in this.dataItems.Rows)
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = Bitmap.FromFile(Path.Combine(this.appPath, row["item_image"].ToString()));
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Anchor = AnchorStyles.None;
                    picture.Size = new Size(120, 60);

                    Label label = new Label();
                    label.Text = row["name"].ToString();
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Bottom;

                    Panel panel = new Panel();
                    panel.Size = new Size(140, 100);
                    panel.BackColor = Color.Pink;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.Name = row["id"].ToString();
                    _snatcher = new MessageSnatcher(panel);
                    _snatcher.LeftMouseClickOccured += _snatcher_LeftMouseClickOccured;

                    panel.Controls.Add(picture);
                    panel.Controls.Add(label);
                    picture.Location = new Point((picture.Parent.ClientSize.Width / 2) - (picture.Width / 2), (picture.Parent.ClientSize.Height / 2) - (picture.Height / 2));

                    FLP_items.Controls.Add(panel);
                }
            }
            else
            {
                this.loadItem(this.categoryId);
            }
        }

        private void loadItem(string category_id)
        {
            if(category_id != null && category_id != "")
            {
                item = new Items();
                this.dataItems = new DataTable();
                this.dataItems.Clear();
                this.dataItems = item.getItemsByCategoryId(category_id);

                FLP_items.Controls.Clear();
                foreach (DataRow row in this.dataItems.Rows)
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = Bitmap.FromFile(Path.Combine(this.appPath, row["item_image"].ToString()));
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Anchor = AnchorStyles.None;
                    picture.Size = new Size(120, 60);

                    Label label = new Label();
                    label.Text = row["name"].ToString();
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Bottom;

                    Panel panel = new Panel();
                    panel.Size = new Size(140, 100);
                    panel.BackColor = Color.Pink;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.Name = row["id"].ToString();
                    _snatcher = new MessageSnatcher(panel);
                    _snatcher.LeftMouseClickOccured += _snatcher_LeftMouseClickOccured;

                    panel.Controls.Add(picture);
                    panel.Controls.Add(label);
                    picture.Location = new Point((picture.Parent.ClientSize.Width / 2) - (picture.Width / 2), (picture.Parent.ClientSize.Height / 2) - (picture.Height / 2));

                    FLP_items.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("There is not enough category to display","Acknowledgment",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.loadItem(btn.Name);
        }

        private void dgv_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string item_id = dgv_cart.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                this.cart_items.Remove(item_id);
                dgv_cart.Rows.RemoveAt(e.RowIndex);
            }

            lbl_discount.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
            lbl_total.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[1]));
        }

        private void dgv_cart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                this.qtyChanged = Convert.ToDouble(dgv_cart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void dgv_cart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (double.TryParse(dgv_cart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out double number))
                {
                    if (number > 0)
                    {
                        double amount = 0;
                        double total = 0;
                        double grandtotal = 0;

                        string item_id = dgv_cart.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
                        double sale_price = Convert.ToDouble(dgv_cart.Rows[e.RowIndex].Cells["rates"].Value.ToString());
                        bool apply_discount = Convert.ToBoolean(dgv_cart.Rows[e.RowIndex].Cells["apply_discount"].Value.ToString());
                        double discount = Convert.ToDouble(dgv_cart.Rows[e.RowIndex].Cells["discount"].Value.ToString());

                        if (apply_discount.Equals(true))
                        {
                            if (discount > 0)
                            {
                                amount = sale_price * (discount / 100);
                                grandtotal = number * sale_price;
                                total = number * (sale_price - amount);
                                amount = grandtotal - total;
                                this.cart_items[item_id] = new List<double>() { amount, total };
                                dgv_cart.Rows[e.RowIndex].Cells["qty"].Value = number;
                                dgv_cart.Rows[e.RowIndex].Cells["total"].Value = total;

                            }
                            else
                            {
                                total = sale_price * number;
                                this.cart_items[item_id] = new List<double>() { amount, total };
                                dgv_cart.Rows[e.RowIndex].Cells["qty"].Value = number;
                                dgv_cart.Rows[e.RowIndex].Cells["total"].Value = total;
                            }
                        }
                        else
                        {
                            total = sale_price * number;
                            this.cart_items[item_id] = new List<double>() { amount, total };
                            dgv_cart.Rows[e.RowIndex].Cells["qty"].Value = number;
                            dgv_cart.Rows[e.RowIndex].Cells["total"].Value = total;
                        }
                    }
                    else
                    {
                        var alert = MessageBox.Show("quantity must be greater then or equal to 1", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        if (alert == DialogResult.OK)
                        {
                            dgv_cart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.qtyChanged;
                        }
                    }
                }
                else
                {
                    var error = MessageBox.Show("quantity must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (error == DialogResult.OK)
                    {
                        dgv_cart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.qtyChanged;
                    }
                }
            }
 
            lbl_discount.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
            lbl_total.Text = Convert.ToString( this.cart_items.Sum(x => x.Value[1]) );
        }

        private void _snatcher_LeftMouseClickOccured(object sender, EventArgs e)
        {
            MessageSnatcher message = (MessageSnatcher)sender;

            double sale_price = 0;
            double qty = 0;
            double amount = 0;
            double total = 0;

            var result = this.dataItems.Select("").FirstOrDefault(x => x["id"].ToString().Equals(message.id));
            if (result != null)
            {
                if (dgv_cart.Rows.Count > 0)
                {
                    if (this.cart_items.ContainsKey(message.id))
                    {
                        #region MultiTimeItemAdd

                        int position = (from r in dgv_cart.Rows.Cast<DataGridViewRow>()
                                        where r.Cells["item_id"].Value.ToString().Equals(message.id)
                                        select r.Index).First();

                        sale_price = Convert.ToDouble(dgv_cart.Rows[position].Cells["rates"].Value.ToString());
                        bool apply_discount = Convert.ToBoolean(dgv_cart.Rows[position].Cells["apply_discount"].Value.ToString());
                        double discount = Convert.ToDouble(dgv_cart.Rows[position].Cells["discount"].Value.ToString());
                        qty = Convert.ToDouble(dgv_cart.Rows[position].Cells["qty"].Value.ToString());

                        if (apply_discount.Equals(true))
                        {
                            if (discount > 0)
                            {
                                amount = sale_price * (discount / 100);
                                qty++;
                                total = qty * (sale_price - amount);
                                amount += this.cart_items[message.id].ElementAt(0);
                                this.cart_items[message.id] = new List<double>() { amount, total };
                                dgv_cart.Rows[position].Cells["qty"].Value = qty;
                                dgv_cart.Rows[position].Cells["total"].Value = total;

                            }
                            else
                            {
                                qty++;
                                total = sale_price * qty;
                                this.cart_items[message.id] = new List<double>() { amount, total };
                                dgv_cart.Rows[position].Cells["qty"].Value = qty;
                                dgv_cart.Rows[position].Cells["total"].Value = total;
                            }
                        }
                        else
                        {
                            qty++;
                            total = sale_price * qty;
                            this.cart_items[message.id] = new List<double>() { amount, total };
                            dgv_cart.Rows[position].Cells["qty"].Value = qty;
                            dgv_cart.Rows[position].Cells["total"].Value = total;
                        }
                        #endregion
                    }
                    else
                    {
                        #region FirstTimeItemAdd

                        int index = dgv_cart.Rows.Add();
                        dgv_cart.Rows[index].Cells["item_id"].Value = result["id"].ToString();
                        dgv_cart.Rows[index].Cells["items"].Value = result["name"].ToString();
                        dgv_cart.Rows[index].Cells["category_id"].Value = result["category_id"].ToString();
                        dgv_cart.Rows[index].Cells["category_name"].Value = result["name2"].ToString();
                        dgv_cart.Rows[index].Cells["kitchen_id"].Value = result["id1"].ToString();
                        dgv_cart.Rows[index].Cells["kitchen_name"].Value = result["name1"].ToString();
                        dgv_cart.Rows[index].Cells["qty"].Value = 1;
                        dgv_cart.Rows[index].Cells["discount"].Value = result["discount"].ToString();
                        dgv_cart.Rows[index].Cells["apply_discount"].Value = result["apply_discount"].ToString();
                        sale_price = Convert.ToDouble(result["sale_price"].ToString());
                        bool apply_discount = Convert.ToBoolean(result["apply_discount"].ToString());
                        double discount = Convert.ToDouble(result["discount"].ToString());
                        if (apply_discount.Equals(true))
                        {
                            if (discount > 0)
                            {
                                amount = sale_price * (discount / 100);
                                total = sale_price - amount;
                                this.cart_items.Add(message.id, new List<double>() { amount, total });
                                dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                                dgv_cart.Rows[index].Cells["total"].Value = total;
                            }
                            else
                            {
                                this.cart_items.Add(message.id, new List<double>() { amount, sale_price });
                                dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                                dgv_cart.Rows[index].Cells["total"].Value = sale_price;
                            }
                        }
                        else
                        {
                            this.cart_items.Add(message.id, new List<double>() { amount, sale_price });
                            dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                            dgv_cart.Rows[index].Cells["total"].Value = sale_price;
                        }
                        #endregion
                    }
                }
                else
                {
                    #region FirstItemAdd

                    int index = dgv_cart.Rows.Add();
                    dgv_cart.Rows[index].Cells["item_id"].Value = result["id"].ToString();
                    dgv_cart.Rows[index].Cells["items"].Value = result["name"].ToString();
                    dgv_cart.Rows[index].Cells["category_id"].Value = result["category_id"].ToString();
                    dgv_cart.Rows[index].Cells["category_name"].Value = result["name2"].ToString();
                    dgv_cart.Rows[index].Cells["kitchen_id"].Value = result["id1"].ToString();
                    dgv_cart.Rows[index].Cells["kitchen_name"].Value = result["name1"].ToString();
                    dgv_cart.Rows[index].Cells["qty"].Value = 1;
                    dgv_cart.Rows[index].Cells["discount"].Value = result["discount"].ToString();
                    dgv_cart.Rows[index].Cells["apply_discount"].Value = result["apply_discount"].ToString();
                    sale_price = Convert.ToDouble(result["sale_price"].ToString());
                    bool apply_discount = Convert.ToBoolean(result["apply_discount"].ToString());
                    double discount = Convert.ToDouble(result["discount"].ToString());
                    if (apply_discount.Equals(true))
                    {
                        if (discount > 0)
                        {
                            amount = sale_price * (discount / 100);
                            total = sale_price - amount;
                            this.cart_items.Add(message.id, new List<double>() { amount , total });
                            dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                            dgv_cart.Rows[index].Cells["total"].Value = total;
                        }
                        else
                        {
                            this.cart_items.Add(message.id, new List<double>() { amount, sale_price });
                            dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                            dgv_cart.Rows[index].Cells["total"].Value = sale_price;
                        }
                    }
                    else
                    {
                        this.cart_items.Add(message.id,new List<double>() { amount,sale_price });
                        dgv_cart.Rows[index].Cells["rates"].Value = sale_price;
                        dgv_cart.Rows[index].Cells["total"].Value = sale_price;
                    }

                    #endregion
                }

            }

            lbl_discount.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[0]));
            lbl_total.Text = Convert.ToString(this.cart_items.Sum(x => x.Value[1]));

        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            if(this.isEditOrders)
            {
                var confirm = MessageBox.Show("Are you sure you want to cancel that order","Verify",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(confirm == DialogResult.Yes)
                {
                    this.orders = new Orders();
                    this.orders.Id = this.orderId;
                    if(this.orders.cancelOrder())
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }



        internal class MessageSnatcher : NativeWindow
        {
            public event EventHandler LeftMouseClickOccured = delegate { };

            private const int WM_LBUTTONDOWN = 0x201;
            private const int WM_PARENTNOTIFY = 0x210;

            public string id;

            private readonly Control _control;

            public MessageSnatcher(Control control)
            {
                this.id = control.Name;
                if (control.Handle != IntPtr.Zero)
                    AssignHandle(control.Handle);
                else
                    control.HandleCreated += OnHandleCreated;

                control.HandleDestroyed += OnHandleDestroyed;
                _control = control;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_PARENTNOTIFY)
                {
                    if (m.WParam.ToInt64() == WM_LBUTTONDOWN)
                        LeftMouseClickOccured(this, EventArgs.Empty);
                }

                base.WndProc(ref m);
            }

            private void OnHandleCreated(object sender, EventArgs e)
            {
                AssignHandle(_control.Handle);
            }

            private void OnHandleDestroyed(object sender, EventArgs e)
            {
                ReleaseHandle();
            }
        }

    }
}
