using Resturant.Model;
using System;
using System.Collections;
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
    public partial class LoginForm : Form
    {
        Login login;
        public LoginForm()
        {
            InitializeComponent();
            login = new Login();
            txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private bool validateInput()
        {
            int IsError = 0;
            StringBuilder builder = new StringBuilder();
            if (txt_username.Text.ToString().Length == 0 && txt_password.Text.ToString().Length == 0)
            {
                builder.Append("Please enter username and password").AppendLine();
                IsError++;
            }
            else
            {
                if (txt_username.Text.ToString().Length == 0)
                {
                    builder.Append("Please enter username").AppendLine();
                    IsError++;
                }
                if (txt_password.Text.ToString().Length == 0)
                {
                    builder.Append("Please enter password").AppendLine();
                    IsError++;
                }
            }

            if(IsError > 0)
            {
                MessageBox.Show(builder.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string username = Encrption.trim(txt_username.Text.ToString());
                string password = Encrption.trim(txt_password.Text.ToString());
                if(validateInput())
                {
                    DataTable data = login.Login_action(username, password);
                    if (data.Rows.Count > 0)
                    {
                        if (Login.user_status.Equals("1"))
                        {
                            MainPanel mainPanel = new MainPanel();
                            mainPanel.Owner = this;
                            this.Hide();
                            mainPanel.Show();
                        }
                        else if (Login.user_status.Equals("2"))
                        {
                            MessageBox.Show("Your account has been de-active");
                        }
                        else if (Login.user_status.Equals("3"))
                        {
                            MessageBox.Show("Your account has been suspended");
                        }
                        else
                        {
                            MessageBox.Show("Your account has been terminated");
                        }
                        this.emptyInputField();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login id or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.emptyInputField();
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = Encrption.trim(txt_username.Text.ToString());
            string password = Encrption.trim(txt_password.Text.ToString());
            if(validateInput())
            {
                DataTable data = login.Login_action(username, password);
                if (data.Rows.Count > 0)
                {
                    if (Login.user_status.Equals("1"))
                    {
                        MainPanel mainPanel = new MainPanel();
                        mainPanel.Owner = this;
                        this.Hide();
                        mainPanel.Show();
                    }
                    else if (Login.user_status.Equals("2"))
                    {
                        MessageBox.Show("Your account has been de-active");
                    }
                    else if (Login.user_status.Equals("3"))
                    {
                        MessageBox.Show("Your account has been suspended");
                    }
                    else
                    {
                        MessageBox.Show("Your account has been terminated");
                    }
                    this.emptyInputField();
                }
                else
                {
                    MessageBox.Show("Invalid login id or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.emptyInputField();
                }
            }
        }


        private void emptyInputField()
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

    }
}
