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
    public partial class CustomerED : Form
    {
        private Customer customer;

        private string customerId,customerName,previous_phone;

        private bool isCustomerEdit;
        public CustomerED()
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_address.KeyPress += EnterKeyPressEventOccure;
            txt_additionalInfo.KeyPress += EnterKeyPressEventOccure;
            txt_phone.KeyPress += EnterKeyPressEventOccure;

            this.Text = "Add Customer";
            this.isCustomerEdit = false;
        }
        public CustomerED(string customer_id)
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_address.KeyPress += EnterKeyPressEventOccure;
            txt_additionalInfo.KeyPress += EnterKeyPressEventOccure;
            txt_phone.KeyPress += EnterKeyPressEventOccure;

            this.isCustomerEdit = true;
            this.customerId = customer_id;

            btn_add.Text = "UPDATE";
            btn_cancel.Text = "DELETE";

            customer = new Customer(customer_id);

            DataTable data = customer.getCustomerById();

            if(data.Rows.Count > 0)
            {
                this.Text = data.Rows[0]["name"].ToString();
                this.customerName = data.Rows[0]["name"].ToString();

                txt_name.Text = data.Rows[0]["name"].ToString();
                txt_email.Text = data.Rows[0]["email"].ToString();
                txt_phone.Text = data.Rows[0]["phone"].ToString();
                previous_phone = data.Rows[0]["phone"].ToString();
                txt_address.Text = data.Rows[0]["address"].ToString();
                txt_additionalInfo.Text = data.Rows[0]["additional_info"].ToString();

            }

        }

        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (this.validateInput())
                {
                    string name = Encrption.trim(txt_name.Text.ToString());
                    string email = Encrption.trim(txt_email.Text.ToString());
                    string address = Encrption.trim(txt_address.Text.ToString());
                    string phone = Encrption.trim(txt_phone.Text.ToString());
                    string additional_info = Encrption.trim(txt_additionalInfo.Text.ToString());

                    if (this.isCustomerEdit == true)
                    {
                        string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        customer = new Customer(int.Parse(this.customerId), name, phone, address, email, additional_info, updated_at);
                        int result = customer.updateCustomer();
                        if (result > 0)
                        {
                            MessageBox.Show("Customer has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.nullInputFied();
                            this.Close();
                        }
                    }
                    else
                    {
                        string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        customer = new Customer(name, phone, address, email, additional_info, created_at, updated_at);
                        int result = customer.addCustomer();
                        if (result > 0)
                        {
                            MessageBox.Show("Customer has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.nullInputFied();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(this.isCustomerEdit == true)
            {
                var confirm = MessageBox.Show(String.Format("Are you sure to delete customer {0} ? If you delete customer {1} all record related to it will be lost", this.customerName,this.customerName),
                    "Confirmation",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    customer = new Customer(this.customerId);
                    int result = customer.deleteCustomer();
                    if (result > 0)
                    {
                        MessageBox.Show("Customer deleted succssfully");
                        this.Close();
                    }
                }
                else if(confirm == DialogResult.No)
                {
                    this.Close();
                }
                else if(confirm == DialogResult.Cancel)
                {
                    // write some code here
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.validateInput())
            {
                string name = Encrption.trim(txt_name.Text.ToString());
                string email = Encrption.trim(txt_email.Text.ToString());
                string address = Encrption.trim(txt_address.Text.ToString());
                string phone = Encrption.trim(txt_phone.Text.ToString());
                string additional_info = Encrption.trim(txt_additionalInfo.Text.ToString());
                if (this.isCustomerEdit == true)
                {
                    string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    customer = new Customer(int.Parse(this.customerId), name, phone, address, email, additional_info, updated_at);
                    int result = customer.updateCustomer();
                    if (result > 0)
                    {
                        MessageBox.Show("Customer has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nullInputFied();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    customer = new Customer(name, phone, address, email, additional_info, created_at, updated_at);
                    int result = customer.addCustomer();
                    if (result > 0)
                    {
                        MessageBox.Show("Customer has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nullInputFied();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private bool validateInput()
        {
            StringBuilder builder = new StringBuilder();
            int isError = 0;

            if (txt_name.Text.ToString().Length > 0)
            {
                if (this.IsDigitsOnly(txt_name.Text.ToString()))
                {
                    isError++;
                    builder.Append("Name must be alphabetic").AppendLine();
                }
                else
                {
                    if (txt_name.Text.ToString().Length > 191)
                    {
                        isError++;
                        builder.Append("Name is too long").AppendLine();
                    }
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter name").AppendLine();
            }

            if (txt_email.Text.ToString().Length > 0)
            {
                if (!Encrption.IsValidEmailAddress(txt_email.Text.ToString()))
                {
                    isError++;
                    builder.Append("Please enter valid email").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter  email").AppendLine();
            }

            Customer customer = new Customer();
            if (this.isCustomerEdit == true)
            {
                if (txt_phone.Text.ToString().Length > 0)
                {
                    if (this.IsDigitsOnly(txt_phone.Text.ToString()))
                    {
                        if (txt_phone.Text.ToString().Length != 11)
                        {
                            isError++;
                            builder.Append("Phone number should be 11 digits").AppendLine();
                        }
                        else
                        {
                            if(!this.previous_phone.Equals(txt_phone.Text.ToString()))
                            {
                                if(customer.checkPhoneAlreadyExist(txt_phone.Text.ToString()))
                                {
                                    isError++;
                                    builder.Append("Phone number already exist").AppendLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Phone must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Please enter phone").AppendLine();
                }
            }
            else
            {
                if (txt_phone.Text.ToString().Length > 0)
                {
                    if (this.IsDigitsOnly(txt_phone.Text.ToString()))
                    {
                        if (txt_phone.Text.ToString().Length != 11)
                        {
                            isError++;
                            builder.Append("Phone number should be 11 digits").AppendLine();
                        }
                        else
                        {
                            if (customer.checkPhoneAlreadyExist(txt_phone.Text.ToString()))
                            {
                                isError++;
                                builder.Append("Phone number already exist").AppendLine();
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Phone must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Please enter phone").AppendLine();
                }
            }



            if (txt_address.Text.Length > 0)
            {
                if(txt_address.Text.Length > 191)
                {
                    isError++;
                    builder.Append("Address is too long").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter address").AppendLine();
            }

            if (isError > 0)
            {
                MessageBox.Show(builder.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
 
        private void nullInputFied()
        {
            txt_name.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_additionalInfo.Clear();
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}
