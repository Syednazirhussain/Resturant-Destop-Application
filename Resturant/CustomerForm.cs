using Resturant.Model;
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
    public partial class CustomerForm : Form
    {
        private Customer customer;
        public CustomerForm()
        {
            InitializeComponent();

            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();

            cb_search.Items.Add("Name");
            cb_search.Items.Add("Phone");
            cb_search.SelectedIndex = 0;

            txt_search.KeyPress += SearchEnterPressEventOccure;
            btn_clear.KeyPress += ClearSearchEnterPressEventOccure;

            btn_clear.Hide();
            txt_search.Focus();
            this.loadCustomer();
        }

        private void ClearSearchEnterPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                txt_search.Focus();
                btn_clear.Hide();
                txt_search.Clear();
                this.loadCustomer();
            }
        }

        private void SearchEnterPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                Customer customer;
                if (txt_search.Text.ToString().Length > 0)
                {
                    customer = new Customer();
                    DataTable dataTable = customer.searchCustomer(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                    if (dataTable.Rows.Count > 0)
                    {
                        btn_clear.Show();
                        this.customerGridViewFormatting(dataTable);
                    }
                    else
                    {
                        MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    customer = null;
                    MessageBox.Show(String.Format("Please enter keyword to search by {0}", cb_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_search.Focus();
                    this.loadCustomer();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Focus();
            btn_clear.Hide();
            txt_search.Clear();
            this.loadCustomer();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if(txt_search.Text.ToString().Length > 0)
            {
                DataTable dataTable = customer.searchCustomer(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                if (dataTable.Rows.Count > 0)
                {
                    btn_clear.Show();
                    this.customerGridViewFormatting(dataTable);
                }
                else
                {
                    MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(String.Format("Please enter keyword to search by {0}", cb_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_search.Focus();
                this.loadCustomer();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void loadCustomer()
        {
            customer = new Customer();
            DataTable dataTable = customer.getCustomer();
            this.customerGridViewFormatting(dataTable);
        }

        private void customerGridViewFormatting(DataTable dataTable)
        {
            if(dgv_customer.RowCount > 0)
            {
                dgv_customer.Rows.Clear();
            }

            if(dataTable.Rows.Count > 0)
            {
                int sno = 0;
                foreach(DataRow row in dataTable.Rows)
                {
                    int index = dgv_customer.Rows.Add();

                    DateTime created_at = DateTime.Parse(row["created_at"].ToString());
                    DateTime updated_at = DateTime.Parse(row["updated_at"].ToString());

                    dgv_customer.Rows[index].Cells["sno"].Value = String.Format(" {0} ",++sno);
                    dgv_customer.Rows[index].Cells["id"].Value = row["id"].ToString(); 
                    dgv_customer.Rows[index].Cells["name"].Value = row["name"].ToString(); 
                    dgv_customer.Rows[index].Cells["phone"].Value = row["phone"].ToString(); 
                    dgv_customer.Rows[index].Cells["address"].Value = row["address"].ToString(); 
                    dgv_customer.Rows[index].Cells["email"].Value = row["email"].ToString(); 
                    dgv_customer.Rows[index].Cells["additional_info"].Value = row["additional_info"].ToString(); 
                    dgv_customer.Rows[index].Cells["created_at"].Value = created_at.ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                    dgv_customer.Rows[index].Cells["updated_at"].Value = updated_at.ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                }

                //dgv_customer.Columns["updated_at"].Resizable = DataGridViewTriState.False;
                //dgv_customer.Columns["updated_at"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string customer_id = dgv_customer.Rows[e.RowIndex].Cells["id"].Value.ToString();
                using (CustomerED customerED = new CustomerED(customer_id))
                {
                    if (customerED.ShowDialog() != DialogResult.Cancel)
                    {
                        txt_search.Clear();
                        txt_search.Focus();
                        btn_clear.Hide();
                        this.loadCustomer();
                    }
                }
            }
        }


        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            using (CustomerED customerED = new CustomerED())
            {
                if(customerED.ShowDialog() != DialogResult.Cancel)
                {
                    txt_search.Clear();
                    txt_search.Focus();
                    btn_clear.Hide();
                    this.loadCustomer();
                }
            }
        }

    }
}
