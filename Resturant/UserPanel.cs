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
    public partial class UserPanel : Form
    {
        Users users;
        public UserPanel()
        {
            InitializeComponent();
            this.Text = "Users";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            this.users = new Users();

            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();


            txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            cbn_search.Items.Add("Name");
            cbn_search.Items.Add("Login Id");
            cbn_search.Items.Add("Role");
            cbn_search.SelectedIndex = 0;

            btn_clear.Hide();

            txt_search.Focus();
            this.LoadUser(this.users.getUsers());
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string select_to_search = cbn_search.SelectedItem.ToString();
                if (txt_search.Text.ToString().Length > 0)
                {
                    if (select_to_search.Equals("Name"))
                    {
                        DataTable data = this.users.searchUser("name", txt_search.Text.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.LoadUser(this.users.searchUser("name", txt_search.Text.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (select_to_search.Equals("Login Id"))
                    {
                        DataTable data = this.users.searchUser("username", txt_search.Text.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.LoadUser(this.users.searchUser("username", txt_search.Text.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (select_to_search.Equals("Role"))
                    {
                        DataTable data = this.users.searchUser("user_role_code", txt_search.Text.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.LoadUser(this.users.searchUser("user_role_code", txt_search.Text.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter keyword to search by " + select_to_search,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_search.Focus();
                    this.LoadUser(this.users.getUsers());
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string select_to_search = cbn_search.SelectedItem.ToString();
            if (txt_search.Text.ToString().Length > 0)
            {
                if (select_to_search.Equals("Name"))
                {
                    DataTable data = this.users.searchUser("name", txt_search.Text.ToString());
                    if (data.Rows.Count > 0)
                    {
                        btn_clear.Show();
                        this.LoadUser(this.users.searchUser("name", txt_search.Text.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (select_to_search.Equals("Login Id"))
                {
                    DataTable data = this.users.searchUser("username", txt_search.Text.ToString());
                    if (data.Rows.Count > 0)
                    {
                        btn_clear.Show();
                        this.LoadUser(this.users.searchUser("username", txt_search.Text.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (select_to_search.Equals("Role"))
                {
                    DataTable data = this.users.searchUser("user_role_code", txt_search.Text.ToString());
                    if (data.Rows.Count > 0)
                    {
                        btn_clear.Show();
                        this.LoadUser(this.users.searchUser("user_role_code", txt_search.Text.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter keyword to search by " + select_to_search, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_search.Focus();
                this.LoadUser(this.users.getUsers());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Focus();
            btn_clear.Hide();
            txt_search.Clear();
            this.LoadUser(this.users.getUsers());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (UserED userED = new UserED())
            {
                if (userED.ShowDialog() != DialogResult.Cancel)
                {
                    txt_search.Focus();
                    btn_clear.Hide();
                    txt_search.Clear();
                    this.LoadUser(this.users.getUsers());
                }
                
            }
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_role = Login.user_role;
            
            if (e.RowIndex > -1)
            {
                if (user_role.Equals("admin"))
                {
                    int user_id = int.Parse(dgv_users.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    using (UserED userED = new UserED(user_id))
                    {
                        if (userED.ShowDialog() != DialogResult.Cancel )
                        {
                            txt_search.Focus();
                            btn_clear.Hide();
                            txt_search.Clear();
                            this.LoadUser(this.users.getUsers());
                        }
                    }
                }
            }
        }
        
        private void LoadUser(DataTable dataTable)
        {
            if(dataTable.Rows.Count > 0)
            {
                dgv_users.Rows.Clear();
                int sno = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    int index = dgv_users.Rows.Add();
                    dgv_users.Rows[index].Cells["sno"].Value = String.Format(" {0} ",++sno);
                    dgv_users.Rows[index].Cells["id"].Value = row["id"].ToString();
                    dgv_users.Rows[index].Cells["name"].Value = row["name"].ToString();
                    dgv_users.Rows[index].Cells["email"].Value = row["email"].ToString();
                    dgv_users.Rows[index].Cells["username"].Value = row["username"].ToString();
                    dgv_users.Rows[index].Cells["role"].Value = row["user_role_code"].ToString();
                    if (row["user_status_id"].ToString().Equals("1"))
                    {
                        dgv_users.Rows[index].Cells["status"].Value = "Active";
                    }
                    else if (row["user_status_id"].ToString().Equals("2"))
                    {
                        dgv_users.Rows[index].Cells["status"].Value = "In-Active";
                    }
                    else if (row["user_status_id"].ToString().Equals("3"))
                    {
                        dgv_users.Rows[index].Cells["status"].Value = "Suspended";
                    }
                    else
                    {
                        dgv_users.Rows[index].Cells["status"].Value = "Terminated";
                    }
                    dgv_users.Rows[index].Cells["created_at"].Value = DateTime.Parse(row["created_at"].ToString()).ToString("ddd dd MMM , yyyy");
                }
            }
        }

        private void main_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }
        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }


    }
}
