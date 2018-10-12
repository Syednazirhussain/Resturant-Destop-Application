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
    public partial class MainPanel : Form
    {
        private string user_role;
        public MainPanel()
        {
            InitializeComponent();
            this.user_role = Login.user_role;
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void MainPanel_Load(object sender, EventArgs e)
        {
            btn_orders.Focus();
            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();

            if (!this.user_role.Equals("admin"))
            {
                btn_user.Text = "Account";
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Owner = this;
            this.Hide();
            loginForm.Show();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            tableForm.Owner = this;
            this.Hide();
            tableForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if(this.user_role.Equals("admin"))
            {
                UserPanel userPanel = new UserPanel();
                userPanel.Owner = this;
                this.Hide();
                userPanel.Show();
            }
            else
            {
                AccountForm account = new AccountForm();
                account.Owner = this;
                this.Hide();
                account.Show();
            }


        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Owner = this;
            this.Hide();
            itemsForm.Show();
        }

        private void btn_kitchen_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.Owner = this;
            this.Hide();
            kitchenForm.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Owner = this;
            this.Hide();
            customerForm.Show();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Owner = this;
            this.Hide();
            employeeForm.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Owner = this;
            this.Hide();
            orderForm.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Owner = this;
            this.Hide();
            reportForm.Show();
        }
    }
}
