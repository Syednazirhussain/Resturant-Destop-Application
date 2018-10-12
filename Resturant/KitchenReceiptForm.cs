using Resturant.Model;
using Resturant.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class KitchenReceiptForm : Form
    {
        private KitchenOrder kitchenOrder;

        private Orders orders;

        private OrderItems orderItems;

        private List<KitchenReceipt> list;

        private Kitchen kitchen;

        private Dictionary<string, string> param;
        public KitchenReceiptForm(string order_id)
        {
            InitializeComponent();

            this.orders = new Orders();
            this.orders.Id = order_id;

            DataTable orderData =  this.orders.getOrderDetail();

            Employee emp = new Employee();
            string server_name = emp.getServerNameById(orderData.Rows[0]["server_id"].ToString());

            this.param = new Dictionary<string, string>();
            param.Add("table_id", orderData.Rows[0]["table_id"].ToString());
            param.Add("table_name", orderData.Rows[0]["table_name"].ToString());
            param.Add("floor", orderData.Rows[0]["floor"].ToString());
            param.Add("zone", orderData.Rows[0]["zone"].ToString());
            param.Add("server_id", orderData.Rows[0]["server_id"].ToString());
            param.Add("server_name", server_name);
            param.Add("user_name", orderData.Rows[0]["user_name"].ToString());
            param.Add("order_type", orderData.Rows[0]["order_type"].ToString().ToUpper());
            

            this.kitchenOrder = new KitchenOrder(this.orders);
            DataTable kitchenOrdersData = this.kitchenOrder.getKitchenOrder();

            this.kitchen = new Kitchen();
            cbn_kitchen.DataSource = this.kitchen.getKitchensByPrimaryKeys(kitchenOrdersData);
            cbn_kitchen.ValueMember = "id";
            cbn_kitchen.DisplayMember = "name";
            cbn_kitchen.SelectedIndex = 0;

            this.orderItems = new OrderItems(this.orders);
            this.orderItems.Kitchen_id = cbn_kitchen.SelectedValue.ToString();

            DataTable data = this.orderItems.kitchenReceipt();

            this.list = new List<KitchenReceipt>();

            foreach (DataRow row in data.Rows)
            {
                this.list.Add(
                        new KitchenReceipt() {
                            item_id = row["id1"].ToString() ,
                            item_name = row["item_name"].ToString() ,
                            item_qty = row["item_qty"].ToString(),
                            additional_notes = row["additional_note"].ToString()
                        }
                    );
            }

            dgv_items.DataSource = list;

        }

        private void cbn_kitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (int.TryParse(cbn_kitchen.SelectedValue.ToString(), out int number))
            {
                this.orderItems = new OrderItems(this.orders);
                this.orderItems.Kitchen_id = Convert.ToString(number);

                DataTable data = this.orderItems.kitchenReceipt();

                this.list = new List<KitchenReceipt>();

                foreach (DataRow row in data.Rows)
                {
                    list.Add(
                            new KitchenReceipt()
                            {
                                item_id = row["id1"].ToString(),
                                item_name = row["item_name"].ToString(),
                                item_qty = row["item_qty"].ToString(),
                                additional_notes = row["additional_note"].ToString()
                            }
                        );
                }

                dgv_items.DataSource = list;

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            using (KitchenReceiptPrint kitchenReceiptPrint = new KitchenReceiptPrint(this.list,this.param))
            {
                if (kitchenReceiptPrint.ShowDialog() != DialogResult.OK)
                {
                    // do some thing 
                }
            }
        }
    }
}
