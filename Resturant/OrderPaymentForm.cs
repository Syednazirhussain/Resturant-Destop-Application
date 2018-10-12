using Resturant.Model;
using Resturant.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace Resturant
{
    public partial class OrderPaymentForm : Form
    {

        private PaymentMethod paymentMethod;

        private OrderStatus orderStatus;

        private Orders orders;

        string total, discount,order_type,order_id;

        bool isPayByCash;

        private double payment_received, cash_back;
        
        DataTable orderDetail;
        public OrderPaymentForm(string _total,string _discount,DataTable order_detail)
        {
            InitializeComponent();
            total = _total;
            discount = _discount;
            orderDetail = order_detail;

            this.paymentMethod = new PaymentMethod();
            listboxPM.DataSource = this.paymentMethod.getPaymentMethod();
            listboxPM.ValueMember = "code";
            listboxPM.DisplayMember = "name";
            listboxPM.SelectedIndex = 0;
           
            txt_amt.Focus();

            if (order_detail.Rows.Count > 0)
            {
                this.order_id = order_detail.Rows[0]["id"].ToString();
                this.order_type = order_detail.Rows[0]["order_type"].ToString();

                Employee emp = new Employee();
                string server_name = emp.getServerNameById(order_detail.Rows[0]["server_id"].ToString());

                listViewDesc.Items.Add( new ListViewItem(new string[] { "System User", order_detail.Rows[0]["user_name"].ToString() }) );
                listViewDesc.Items.Add( new ListViewItem(new string[] { "Server", server_name }) );
                if (order_detail.Rows[0]["order_type"].ToString().Equals("dine_in"))
                {
                    listViewDesc.Items.Add(new ListViewItem(new string[] { "Order Type", order_detail.Rows[0]["order_type"].ToString() }));
                    listViewDesc.Items.Add(new ListViewItem(new string[] { "Floor", order_detail.Rows[0]["floor"].ToString() }));
                    listViewDesc.Items.Add(new ListViewItem(new string[] { "Zone", order_detail.Rows[0]["zone"].ToString() }));
                    listViewDesc.Items.Add(new ListViewItem(new string[] { "Table", order_detail.Rows[0]["table_name"].ToString() }));
                }
            }
        }
        private void OrderPaymentForm_Load(object sender, EventArgs e)
        {
            txt_amt.Focus();
            btn_print.Enabled = false;

            lbl_amtRecieved.Text = "";
            lbl_cashBack.Text = "";

            lbl_total.Text = String.Format("Total Amount {0}", Convert.ToString(this.total));
            if (listboxPM.SelectedValue.ToString().Equals("cash"))
            {
                this.paymentByCash(true);
            }
            else
            {
                this.paymentByCash(false);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string amount = txt_amt.Text.ToString();
            if(amount.Length > 0)
            {
                if (double.TryParse(amount, out double number))
                {
                    this.payment_received = number;
                    if (number > Convert.ToDouble(this.total))
                    {
                        txt_amt.Clear();
                        lbl_amtRecieved.Text = String.Format("Amount Received {0}", Convert.ToString(number));
                        this.cash_back = number - Convert.ToDouble(this.total);
                        lbl_cashBack.Text = String.Format("Cash Back {0}", Convert.ToString(this.cash_back));
                        this.CompleteOrder("cash");
                        btn_add.Enabled = false;
                        txt_amt.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Please recieved full payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_amtRecieved.Text = "";
                        lbl_cashBack.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Amount must be numeric","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lbl_amtRecieved.Text = "";
                    lbl_cashBack.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter recieved amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CompleteOrder(string payment_method)
        {
            btn_print.Enabled = true;

            OrderStatus status = new OrderStatus();
            PaymentMethod payment = new PaymentMethod();

            this.orders = new Orders();
            this.orders.Id = this.order_id;
            this.orders.Order_status_id = status.getOrderStatus("completed");
            this.orders.Payment_method = payment.getPaymentMethod(payment_method);
            if(payment_method.Equals("debit_card"))
            {
                this.orders.Payment_recieved = this.total;
            }
            else
            {
                this.orders.Payment_recieved = Convert.ToString(this.payment_received);
            }
            this.orders.Amount_returned = Convert.ToString(this.cash_back);
            this.orders.completeOrder();

            status = null;
            payment = null;

            MessageBox.Show("Order completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void chk_card_CheckedChanged(object sender, EventArgs e)
        {
            if(this.isPayByCash.Equals(false))
            {
                if(chk_card.Checked)
                {
                    this.CompleteOrder("debit_card");
                    chk_card.Enabled = false;

                }
                else
                {
                    btn_print.Enabled = false;
                }
            }
        }

        private void listboxPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_amt.Clear();
            lbl_cashBack.Text = "";
            lbl_amtRecieved.Text = "";

            btn_print.Enabled = false;

            if (listboxPM.SelectedValue.ToString().Equals("cash"))
            {
                this.isPayByCash = true;
                this.paymentByCash(true);
            }
            else
            {
                this.isPayByCash = false;
                this.paymentByCash(false);
            }
        }

        public string ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if(orderDetail.Rows.Count > 0)
            {
                List<OrderReceipt> list = new List<OrderReceipt>();

                int sum_qty = 0;

                foreach (DataRow row in orderDetail.Rows)
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

                Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
                Image image = new Bitmap(barcode.Draw(orderDetail.Rows[0]["id"].ToString(), 100));
                
                string barCodeImage = this.ImageToBase64(image, System.Drawing.Imaging.ImageFormat.Jpeg );


                //this.orders = new Orders();
                //this.orderStatus = new OrderStatus();
                //string order_status_id = this.orderStatus.getOrderStatus("completed");

                //if (this.isPayByCash)
                //{
                //    this.orders.Id = orderDetail.Rows[0]["id"].ToString();
                //    this.orders.Order_status_id = order_status_id;
                //    this.orders.Payment_method = "cash";
                //    this.orders.Payment_recieved = Convert.ToString(this.payment_received);
                //    this.orders.Amount_returned = Convert.ToString(this.cash_back);
                //    this.orders.completeOrder();
                //}
                //else
                //{
                //    this.orders.Id = orderDetail.Rows[0]["id"].ToString();
                //    this.orders.Order_status_id = order_status_id;
                //    this.orders.Payment_method = "debit_card";
                //    this.orders.completeOrder(false);
                //}


                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add("total", this.total);
                item.Add("discount", this.discount);
                item.Add("payment_received", Convert.ToString(this.payment_received) );
                item.Add("cash_back", Convert.ToString(this.cash_back) );
                item.Add("order_type", this.order_type);
                item.Add("order_id", orderDetail.Rows[0]["id"].ToString() );
                item.Add("barcode_image", barCodeImage);
                item.Add("sum_qty", Convert.ToString(sum_qty));

                using (OrderPaymentPrint orderPrePayment = new OrderPaymentPrint(list, item))
                {
                    if (orderPrePayment.ShowDialog() != DialogResult.OK)
                    {
                        // do some thing 
                    }
                }

            }
        }

        private void paymentByCash(bool isPayByCash = true)
        {
            if (isPayByCash)
            {
                lbl_amtRecieved.Visible = true;
                lbl_cashBack.Visible = true;

                label1.Show();
                txt_amt.Show();
                btn_add.Show();

                chk_card.Hide();
            }
            else
            {
                lbl_amtRecieved.Visible = false;
                lbl_cashBack.Visible = false;

                label1.Hide();
                txt_amt.Hide();
                btn_add.Hide();
                chk_card.Show();
            }
        }


        //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|'.'",ValidateNames=true,Multiselect=true })
        //{
        //    if(ofd.ShowDialog() != DialogResult.OK)
        //    {
        //        foreach(string f in ofd.FileNames)
        //        {
        //            FileInfo finfo = new FileInfo(f);
        //            ListViewItem listViewItem = new ListViewItem(finfo.Name);
        //            listViewItem.SubItems.Add(finfo.FullName);
        //            listViewDesc.Items.Add(listViewItem);
        //        }
        //    }
        //}
    }
}
