using Resturant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class UserED : Form
    {
        private Users users;

        private bool verifiedUser;

        private string role,login_id;

        private int selectedUserId;

        private bool is_edit;
        public UserED()
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_username.KeyPress += EnterKeyPressEventOccure;
            txt_password.KeyPress += EnterKeyPressEventOccure;
            txt_newPassword.KeyPress += EnterKeyPressEventOccure;

            this.Text = "Add User";

            users = new Users();

            cb_userRole.DataSource = users.getUserRole();
            cb_userRole.ValueMember = "code";
            cb_userRole.DisplayMember = "name";
            cb_userRole.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable data = users.getUserStatus();
            foreach(DataRow row in data.Rows)
            {
                row["name"] = Encrption.UppercaseFirst(row["name"].ToString());
            }

            cb_userStatus.DataSource = data;
            cb_userStatus.ValueMember = "id";
            cb_userStatus.DisplayMember = "name";
            cb_userStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            passwordlbl.Text = "Password";
            confirmPasswordlbl.Hide();
            txt_newPassword.Hide();

            btn_update.Text = "ADD";
            btn_delete.Text = "CANCEL";

            is_edit = false;
        }
        public UserED(int user_id)
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_username.KeyPress += EnterKeyPressEventOccure;
            txt_password.KeyPress += EnterKeyPressEventOccure;
            txt_newPassword.KeyPress += EnterKeyPressEventOccure;

            //this.Text = name.ToUpper();

            this.verifiedUser = false;
            this.role = Login.user_role;

            this.selectedUserId = user_id;

            users = new Users(user_id);

            DataTable currentUser = users.getUserById();
            cb_userRole.DataSource = users.getUserRole();
            cb_userRole.ValueMember = "code";
            cb_userRole.DisplayMember = "name";
            cb_userRole.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable data = users.getUserStatus();
            foreach (DataRow row in data.Rows)
            {
                row["name"] = Encrption.UppercaseFirst(row["name"].ToString());
            }
            cb_userStatus.DataSource = data;
            cb_userStatus.ValueMember = "id";
            cb_userStatus.DisplayMember = "name";
            cb_userStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            passwordlbl.Visible = false;
            txt_password.Visible = false;
            confirmPasswordlbl.Visible = false;
            txt_newPassword.Visible = false;
            btn_delete.Enabled = false;

            is_edit = true;

            if (currentUser.Rows.Count > 0)
            {
                this.Text = currentUser.Rows[0]["name"].ToString();

                txt_name.Text = currentUser.Rows[0]["name"].ToString();
                txt_username.Text = currentUser.Rows[0]["username"].ToString();
                login_id = currentUser.Rows[0]["username"].ToString();
                txt_email.Text = currentUser.Rows[0]["email"].ToString();
                cb_userRole.SelectedValue = currentUser.Rows[0]["user_role_code"].ToString();
                cb_userStatus.SelectedValue = currentUser.Rows[0]["user_status_id"].ToString();


                if (role.Equals("admin"))
                {
                    passwordlbl.Visible = true;
                    txt_password.Visible = true;

                    if (this.selectedUserId.Equals(Login.user_id))
                    {
                        passwordlbl.Text = "Old Password";
                        btn_delete.Enabled = false;
                    }
                    else
                    {
                        passwordlbl.Text = "Password";
                        btn_delete.Enabled = true;
                    }
                }
            }
        }

        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (is_edit.Equals(true))
                {
                    if (role.Equals("admin"))
                    {
                        if (this.validateUser())
                        {
                            if (this.selectedUserId.Equals(Login.user_id))
                            {
                                if (this.verifiedUser == true)
                                {
                                    if (txt_newPassword.Text.ToString().Length > 0)
                                    {
                                        if (txt_newPassword.Text.ToString().Length >= 6 && txt_newPassword.Text.ToString().Length <= 20)
                                        {
                                            // Admin update operation
                                            string name = Encrption.trim(txt_name.Text.ToString());
                                            string username = Encrption.trim(txt_username.Text.ToString());
                                            string email = Encrption.trim(txt_email.Text.ToString());
                                            string user_role = cb_userRole.SelectedValue.ToString();
                                            string user_status = cb_userStatus.SelectedValue.ToString();
                                            string password = Encrption.trim(txt_newPassword.Text.ToString());
                                            string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                            users = new Users(Login.user_id, name, username, email, password, user_role, user_status, created_at);
                                            if (users.updateUser() > 0)
                                            {
                                                MessageBox.Show("User has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.DialogResult = DialogResult.OK;
                                                this.Close();
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Password must be in between 6 to 20 character");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter new password");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter password to verify");
                                }
                            }
                            else
                            {
                                if (login_id == txt_username.Text.ToString())
                                {
                                    // Other update operation
                                    string name = Encrption.trim(txt_name.Text.ToString());
                                    string username = Encrption.trim(txt_username.Text.ToString());
                                    string email = Encrption.trim(txt_email.Text.ToString());
                                    string user_role = cb_userRole.SelectedValue.ToString();
                                    string user_status = cb_userStatus.SelectedValue.ToString();
                                    string password = Encrption.trim(txt_password.Text.ToString());
                                    string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                    users = new Users(this.selectedUserId, name, username, email, password, user_role, user_status, created_at);
                                    if (users.updateUser() > 0)
                                    {
                                        MessageBox.Show("User has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    users = new Users();
                                    if (users.is_LoginIdAlreadyExist(txt_username.Text.ToString()))
                                    {
                                        MessageBox.Show("Login id already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        // Other update operation
                                        string name = Encrption.trim(txt_name.Text.ToString());
                                        string username = Encrption.trim(txt_username.Text.ToString());
                                        string email = Encrption.trim(txt_email.Text.ToString());
                                        string user_role = cb_userRole.SelectedValue.ToString();
                                        string user_status = cb_userStatus.SelectedValue.ToString();
                                        string password = Encrption.trim(txt_password.Text.ToString());
                                        string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                        users = new Users(this.selectedUserId, name, username, email, password, user_role, user_status, created_at);
                                        if (users.updateUser() > 0)
                                        {
                                            MessageBox.Show("User has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    if (this.validateUser().Equals(true))
                    {
                        users = new Users();
                        if (users.is_LoginIdAlreadyExist(txt_username.Text.ToString()))
                        {
                            MessageBox.Show("The Login Id is already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string name = Encrption.trim(txt_name.Text.ToString());
                            string username = Encrption.trim(txt_username.Text.ToString());
                            string email = Encrption.trim(txt_email.Text.ToString());
                            string user_role = cb_userRole.SelectedValue.ToString();
                            string status = cb_userStatus.SelectedValue.ToString();
                            string password = Encrption.trim(txt_password.Text.ToString());
                            string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            users = null;
                            users = new Users(0, name, username, email, password, user_role, status, created_at);
                            int result = users.addUser();
                            if (result > 0)
                            {
                                MessageBox.Show("The user has created successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.nullInputField();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                this.nullInputField();
                            }
                        }
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(is_edit.Equals(true))
            {
                if (role.Equals("admin"))
                {
                    var confirmResult = MessageBox.Show("Are you sure..", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        users = new Users(this.selectedUserId);
                        int result = users.deleteUser();
                        if (result > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(is_edit.Equals(true))
            {
                if (role.Equals("admin"))
                {
                    if (this.validateUser())
                    {
                        if (this.selectedUserId.Equals(Login.user_id))
                        {
                            if (this.verifiedUser == true)
                            {
                                if (txt_newPassword.Text.ToString().Length > 0)
                                {
                                    if (txt_newPassword.Text.ToString().Length >= 6 && txt_newPassword.Text.ToString().Length <= 20)
                                    {
                                        // Admin update operation
                                        string name = Encrption.trim(txt_name.Text.ToString());
                                        string username = Encrption.trim(txt_username.Text.ToString());
                                        string email = Encrption.trim(txt_email.Text.ToString());
                                        string user_role = cb_userRole.SelectedValue.ToString();
                                        string user_status = cb_userStatus.SelectedValue.ToString();
                                        string password = Encrption.trim(txt_newPassword.Text.ToString());
                                        string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                        users = new Users(Login.user_id, name, username, email, password, user_role, user_status, created_at);
                                        if (users.updateUser() > 0)
                                        {
                                            MessageBox.Show("User has updated successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Password must be in between 6 to 20 character");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter new password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter password to verify");
                            }
                        }
                        else
                        {
                            if(login_id == txt_username.Text.ToString())
                            {
                                // Other update operation
                                string name = Encrption.trim(txt_name.Text.ToString());
                                string username = Encrption.trim(txt_username.Text.ToString());
                                string email = Encrption.trim(txt_email.Text.ToString());
                                string user_role = cb_userRole.SelectedValue.ToString();
                                string user_status = cb_userStatus.SelectedValue.ToString();
                                string password = Encrption.trim(txt_password.Text.ToString());
                                string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                users = new Users(this.selectedUserId, name, username, email, password, user_role, user_status, created_at);
                                if (users.updateUser() > 0)
                                {
                                    MessageBox.Show("User has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                users = new Users();
                                if(users.is_LoginIdAlreadyExist(txt_username.Text.ToString()))
                                {
                                    MessageBox.Show("Login id already taken","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Other update operation
                                    string name = Encrption.trim(txt_name.Text.ToString());
                                    string username = Encrption.trim(txt_username.Text.ToString());
                                    string email = Encrption.trim(txt_email.Text.ToString());
                                    string user_role = cb_userRole.SelectedValue.ToString();
                                    string user_status = cb_userStatus.SelectedValue.ToString();
                                    string password = Encrption.trim(txt_password.Text.ToString());
                                    string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                    users = new Users(this.selectedUserId, name, username, email, password, user_role, user_status, created_at);
                                    if (users.updateUser() > 0)
                                    {
                                        MessageBox.Show("User has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                if (this.validateUser().Equals(true))
                {
                    users = new Users();
                    if(users.is_LoginIdAlreadyExist(txt_username.Text.ToString()))
                    {
                        MessageBox.Show("The Login Id is already in use", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        string name = Encrption.trim(txt_name.Text.ToString());
                        string username = Encrption.trim(txt_username.Text.ToString());
                        string email = Encrption.trim(txt_email.Text.ToString());
                        string user_role = cb_userRole.SelectedValue.ToString();
                        string status = cb_userStatus.SelectedValue.ToString();
                        string password = Encrption.trim(txt_password.Text.ToString());
                        string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        users = null;
                        users = new Users(0, name, username, email, password, user_role, status, created_at);
                        int result = users.addUser();
                        if (result > 0)
                        {
                            MessageBox.Show("The user has created successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.nullInputField();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.nullInputField();
                        }
                    }
                }
            }
        }
        private bool validateUser()
        {
            int isError = 0;
            StringBuilder builder = new StringBuilder();

            if (txt_name.Text.ToString().Length > 0)
            {
                if (txt_name.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Name is too long").AppendLine();
                }
                else
                {
                    if(!Regex.IsMatch( txt_name.Text , @"^[A-Za-z ]+$"))
                    {
                        isError++;
                        builder.Append("Name contain only character").AppendLine();
                    }

                    //if(Regex.IsMatch(txt_name.Text, "^[0-9]+$"))
                    //{
                    //    isError++;
                    //    builder.Append("Name cannot contain digits").AppendLine();
                    //}
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter name").AppendLine();
            }

            if (txt_email.Text.ToString().Length > 0)
            {
                if (Encrption.IsValidEmailAddress(txt_email.Text.ToString()))
                {
                    if (txt_email.Text.ToString().Length > 191)
                    {
                        isError++;
                        builder.Append("Email is too long").AppendLine();
                    }
                }
                else
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

            if (txt_username.Text.ToString().Length > 0)
            {
                if (txt_username.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("login id is too long").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter login id").AppendLine();
            }

            if(!is_edit.Equals(true))
            {
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
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (is_edit.Equals(true))
            {
                if (this.role.Equals("admin"))
                {
                    if (this.selectedUserId.Equals(Login.user_id))
                    {
                        string password = txt_password.Text.ToString();
                        DataTable data = users.verifyPassword(password);
                        if (data.Rows.Count > 0)
                        {
                            this.verifiedUser = true;
                            confirmPasswordlbl.Visible = true;
                            txt_newPassword.Visible = true;
                        }
                    }
                }
            }
        }
        private void nullInputField()
        {
            txt_name.Clear();
            txt_username.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_newPassword.Clear();
        }
        
    }
}
