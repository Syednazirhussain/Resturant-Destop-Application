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
    public partial class AccountForm : Form
    {
        private Users users;

        private bool verifiedUser;

        private string role;
        public AccountForm()
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_username.KeyPress += EnterKeyPressEventOccure;
            txt_password.KeyPress += EnterKeyPressEventOccure;
            txt_cpassword.KeyPress += EnterKeyPressEventOccure;

            this.Text = Login.name;
            this.verifiedUser = false;
            users = new Users();
            confirmPasswordlbl.Visible = false;
            txt_cpassword.Visible = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            user_type.Text = "User Type : " + Login.user_role.ToUpper();
            txt_name.Text = Login.name;
            txt_username.Text = Login.username;
            txt_email.Text = Login.email;
        }

        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (this.validateUser())
                {
                    if (this.verifiedUser == true)
                    {
                        if (txt_cpassword.Text.ToString().Length > 0)
                        {
                            if (txt_password.Text.ToString().Length < 6 || txt_password.Text.ToString().Length > 20)
                            {
                                string name = Encrption.trim(txt_name.Text.ToString());
                                string username = Encrption.trim(txt_username.Text.ToString());
                                string email = Encrption.trim(txt_email.Text.ToString());
                                string user_role = Login.user_role;
                                string user_status = Login.user_status;
                                string password = txt_cpassword.Text.ToString();
                                string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                users = new Users(Login.user_id, name, username, email, password, user_role, user_status, created_at);
                                if (users.updateUser() > 0)
                                {
                                    MessageBox.Show("Account has been updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    confirmPasswordlbl.Visible = false;
                                    txt_cpassword.Visible = false;
                                    txt_password.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password must be in between 6 to 20 characters","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter new password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (this.validateUser())
            {
                if (this.verifiedUser == true)
                {
                    if (txt_cpassword.Text.ToString().Length > 0)
                    {
                        if (txt_password.Text.ToString().Length < 6 || txt_password.Text.ToString().Length > 20)
                        {
                            string name = Encrption.trim(txt_name.Text.ToString());
                            string username = Encrption.trim(txt_username.Text.ToString());
                            string email = Encrption.trim(txt_email.Text.ToString());
                            string user_role = Login.user_role;
                            string user_status = Login.user_status;
                            string password = txt_cpassword.Text.ToString();
                            string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            users = new Users(Login.user_id, name, username, email, password, user_role, user_status, created_at);
                            if (users.updateUser() > 0)
                            {
                                MessageBox.Show("Account has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                confirmPasswordlbl.Visible = false;
                                txt_cpassword.Visible = false;
                                txt_password.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be in between 6 to 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void nullInputField()
        {
            txt_name.Clear();
            txt_username.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_cpassword.Clear();
        }
        private bool validateUser()
        {
            int isError = 0;

            StringBuilder builder = new StringBuilder();

            if (txt_email.Text.ToString().Length > 0)
            {
                if ( !Encrption.IsValidEmailAddress(txt_email.Text.ToString()) )
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



            if (txt_name.Text.ToString().Length > 0)
            {
                if (Encrption.Is_Alphabetic(txt_name.Text.ToString()) )
                {
                    if(txt_name.Text.ToString().Length > 191)
                    {
                        isError++;
                        builder.Append("Name is too long").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Name must be alphabetic").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter name").AppendLine();
            }

            if (txt_username.Text.ToString().Length > 0)
            {
                if (txt_username.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Username is too long").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter username").AppendLine();
            }

            if (txt_password.Text.ToString().Length > 0)
            {
                if (txt_password.Text.ToString().Length < 6 || txt_password.Text.ToString().Length > 20)
                {
                    isError++;
                    builder.Append("Password must be in between 6 to 20 characters").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter password").AppendLine();
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

        private void txt_password_Leave(object sender, EventArgs e)
        {
            string password = txt_password.Text.ToString();
            DataTable data = users.verifyPassword(password);
            if (data.Rows.Count > 0)
            {
                if(txt_password.Text.Length > 0)
                {
                    this.verifiedUser = true;
                    confirmPasswordlbl.Visible = true;
                    txt_cpassword.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please enter password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                this.verifiedUser = false;
                confirmPasswordlbl.Visible = false;
                txt_cpassword.Visible = false;
            }
        }
    }
}
