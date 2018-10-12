using Resturant.Model;
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

namespace Resturant
{
    public partial class EmployeeForm : Form
    {
        private Employee employee;

        private string appPath;

        public EmployeeForm()
        {
            InitializeComponent();

            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\EmployeesImages\";
            if (Directory.Exists(this.appPath) == false)
            {
                Directory.CreateDirectory(this.appPath);
            }

            txt_search.KeyPress += SearchPressEnterEventOccure;
            btn_search.KeyPress += SearchPressEnterEventOccure;

            btn_clear.KeyPress += CancelSearchEnterPressEventOccure;

            cb_search.Items.Add("Name");
            cb_search.Items.Add("Role");
            cb_search.Items.Add("Mobile");
            cb_search.Items.Add("Nic");
            cb_search.SelectedIndex = 0;

            btn_clear.Hide();
            txt_search.Focus();
            this.loadEmployee();

        }

        private void CancelSearchEnterPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                txt_search.Focus();
                btn_clear.Hide();
                txt_search.Clear();
                this.loadEmployee();
            }
        }

        private void SearchPressEnterEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Return)
            {
                Employee employee = new Employee();
                if (cb_search.SelectedItem.ToString().Equals("Name"))
                {
                    if (txt_search.Text.ToString().Length > 0)
                    {
                        DataTable data = employee.searchEmployee(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.employeeGridViewFormatting(data);
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
                        this.loadEmployee();
                    }
                }
                else if (cb_search.SelectedItem.ToString().Equals("Role"))
                {
                    if (txt_search.Text.ToString().Length > 0)
                    {
                        DataTable data = employee.searchEmployee(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.employeeGridViewFormatting(data);
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
                        this.loadEmployee();
                    }
                }
                else if (cb_search.SelectedItem.ToString().Equals("Mobile"))
                {
                    if (txt_search.Text.ToString().Length > 0)
                    {
                        DataTable data = employee.searchEmployee(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.employeeGridViewFormatting(data);
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
                        this.loadEmployee();
                    }
                }
                else if (cb_search.SelectedItem.ToString().Equals("Nic"))
                {
                    if (txt_search.Text.ToString().Length > 0)
                    {
                        DataTable data = employee.searchEmployee(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                        if (data.Rows.Count > 0)
                        {
                            btn_clear.Show();
                            this.employeeGridViewFormatting(data);
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
                        this.loadEmployee();
                    }
                }
                else
                {
                    employee = null;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Focus();
            btn_clear.Hide();
            txt_search.Clear();
            this.loadEmployee();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if(txt_search.Text.ToString().Length > 0)
            {
                DataTable data = employee.searchEmployee(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                if (data.Rows.Count > 0)
                {
                    btn_clear.Show();
                    this.employeeGridViewFormatting(data);
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
                this.loadEmployee();
            }
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
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

        private void loadEmployee()
        {
            employee = new Employee();
            DataTable dataTable = employee.getEmployees();
            this.employeeGridViewFormatting(dataTable);
            this.removeUnwantedImage();
        }

        private void removeUnwantedImage()
        {
            DirectoryInfo dir = new DirectoryInfo(this.appPath);
            FileInfo[] Files = dir.GetFiles();

            List<string> imageRemoveList = new List<string>();
            List<string> image = new List<string>();

            employee = new Employee();
            if (employee.getAllImages().Count > 0)
            {
                foreach (string img in employee.getAllImages())
                {
                    foreach (FileInfo file in Files)
                    {
                        if (img.Equals(file.Name))
                        {
                            if (imageRemoveList.Contains(file.Name))
                            {
                                imageRemoveList.Remove(file.Name);
                                image.Add(file.Name);
                            }
                            else
                            {
                                image.Add(file.Name);
                            }

                        }
                        else
                        {
                            if (image.Contains(file.Name))
                            {
                                if (imageRemoveList.Contains(file.Name))
                                {
                                    imageRemoveList.Remove(file.Name);
                                }
                            }
                            else
                            {
                                if (image.Contains(file.Name))
                                {
                                    continue;
                                }
                                else
                                {
                                    imageRemoveList.Add(file.Name);
                                }
                            }
                        }
                    }
                }
            }

            if (imageRemoveList.Count > 0)
            {
                foreach (string img in imageRemoveList)
                {
                    if (image.Contains(img))
                    {
                        continue;
                    }
                    else
                    {
                        string filePath = this.appPath + img;
                        if (File.Exists(filePath))
                        {
                            try
                            {
                                File.Delete(filePath);
                            }
                            catch (Exception ex)
                            {
                                // Handle error here
                            }
                        }
                    }
                }
            }

        }

        public void employeeGridViewFormatting(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                dgv_employee.Rows.Clear();
                dgv_employee.RowTemplate.Height = 100;
                dgv_employee.Columns["profile_image"].Width = 10;

                int sno = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    var index = dgv_employee.Rows.Add();

                    DateTime created_at = DateTime.Parse(row["created_at"].ToString());
                    DateTime updated_at = DateTime.Parse(row["updated_at"].ToString());

                    dgv_employee.Rows[index].Cells["sno"].Value = String.Format(" {0} ",++sno);
                    dgv_employee.Rows[index].Cells["name"].Value = row["name"].ToString();
                    dgv_employee.Rows[index].Cells["father_name"].Value = row["father_name"].ToString();
                    dgv_employee.Rows[index].Cells["address"].Value = row["address"].ToString();
                    dgv_employee.Rows[index].Cells["email"].Value = row["email"].ToString();
                    dgv_employee.Rows[index].Cells["mobile_no"].Value = row["mobile_no"].ToString();
                    dgv_employee.Rows[index].Cells["cnic_no"].Value = row["cnic_no"].ToString();
                    dgv_employee.Rows[index].Cells["userRoleName"].Value = row["user_role_code"].ToString();
                    dgv_employee.Rows[index].Cells["UserStatusName"].Value = row["UserStatusName"].ToString();
                    dgv_employee.Rows[index].Cells["created_at"].Value = created_at.ToString("ddd dd MMM , yyyy");
                    dgv_employee.Rows[index].Cells["updated_at"].Value = updated_at.ToString("ddd dd MMM , yyyy");
                    dgv_employee.Rows[index].Cells["id"].Value = row["id"].ToString();
                    if (!row["profile_image"].ToString().Equals(""))
                    {
                        try
                        {
                            dgv_employee.Rows[index].Cells["profile_image"].Value = new Bitmap(Bitmap.FromFile(Path.Combine(this.appPath, row["profile_image"].ToString())), 75, 75);

                        }
                        catch (Exception ex)
                        {
                            // Handle error here
                        }
                    }
                    else
                    {
                        dgv_employee.Rows[index].Cells["profile_image"].Value = new Bitmap(Properties.Resources.default_avatar, 75, 75);
                    }

                }
                
            }
        }

        private void btn_addEmployees_Click(object sender, EventArgs e)
        {
            using (EmployeeED employeeED = new EmployeeED())
            {
                if(employeeED.ShowDialog() != DialogResult.Cancel)
                {
                    btn_clear.Hide();
                    this.loadEmployee();
                }
            }
        }

        private void dgv_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                try
                {
                    string employee_id = dgv_employee.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    using (EmployeeED employeeED = new EmployeeED(employee_id))
                    {
                        if (employeeED.ShowDialog() != DialogResult.Cancel)
                        {
                            txt_search.Clear();
                            btn_clear.Hide();
                            this.loadEmployee();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }


    }
}
