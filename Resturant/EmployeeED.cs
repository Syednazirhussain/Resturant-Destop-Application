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
    public partial class EmployeeED : Form
    {
        private Employee employee;

        private Users users;

        private string employeeId,employeeName,mobile_no,cnic_no;

        private string appPath,filePath,fileExt,previousImage;

        private bool isEditEmployee,removeImage;
        public EmployeeED()
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_address.KeyPress += EnterKeyPressEventOccure;
            txt_fathername.KeyPress += EnterKeyPressEventOccure;
            txt_mobile.KeyPress += EnterKeyPressEventOccure;
            txt_nic.KeyPress += EnterKeyPressEventOccure;
            

            this.isEditEmployee = false;
            this.removeImage = false;
            this.fileExt = "";
            this.filePath = "";

            users = new Users();

            DataTable dataUserRole = users.getUserRole();
            cb_role.DataSource = dataUserRole;
            cb_role.ValueMember = "code";
            cb_role.DisplayMember = "name";
            cb_role.SelectedIndex = 0;

            DataTable data = users.getUserStatus();
            foreach (DataRow row in data.Rows)
            {
                row["name"] = Encrption.UppercaseFirst(row["name"].ToString());
            }
            cb_status.DataSource = data;
            cb_status.ValueMember = "id";
            cb_status.DisplayMember = "name";
            cb_status.SelectedIndex = 0;

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\EmployeesImages\";

        }
        public EmployeeED(string employee_id)
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            txt_email.KeyPress += EnterKeyPressEventOccure;
            txt_address.KeyPress += EnterKeyPressEventOccure;
            txt_fathername.KeyPress += EnterKeyPressEventOccure;
            txt_mobile.KeyPress += EnterKeyPressEventOccure;
            txt_nic.KeyPress += EnterKeyPressEventOccure;

            this.isEditEmployee = true;
            this.removeImage = false;
            this.employeeId = employee_id;
            this.fileExt = "";
            this.filePath = "";

            btn_add.Text = "UPDATE";
            btn_cancel.Text = "DELETE";

            users = new Users();

            DataTable dataUserRole = users.getUserRole();

            cb_role.DataSource = dataUserRole;
            cb_role.ValueMember = "code";
            cb_role.DisplayMember = "name";
            cb_role.SelectedIndex = 0;


            DataTable data = users.getUserStatus();
            foreach (DataRow row in data.Rows)
            {
                row["name"] = Encrption.UppercaseFirst(row["name"].ToString());
            }

            cb_status.DataSource = data;
            cb_status.ValueMember = "id";
            cb_status.DisplayMember = "name";
            cb_status.SelectedIndex = 0;

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\EmployeesImages\";

            employee = new Employee(employee_id);
            DataTable dataTable = employee.getEmployeeById();

            if(dataTable.Rows.Count > 0)
            {
                this.employeeName = dataTable.Rows[0]["name"].ToString();
                txt_name.Text = dataTable.Rows[0]["name"].ToString();
                txt_fathername.Text = dataTable.Rows[0]["father_name"].ToString();
                txt_address.Text = dataTable.Rows[0]["address"].ToString();
                txt_email.Text = dataTable.Rows[0]["email"].ToString();
                txt_mobile.Text = dataTable.Rows[0]["mobile_no"].ToString();
                this.mobile_no = dataTable.Rows[0]["mobile_no"].ToString();
                txt_nic.Text = dataTable.Rows[0]["cnic_no"].ToString();
                this.cnic_no = dataTable.Rows[0]["cnic_no"].ToString();
                cb_role.SelectedValue = dataTable.Rows[0]["user_role_code"].ToString();
                cb_status.SelectedValue = dataTable.Rows[0]["user_status_id"].ToString();
                this.previousImage = dataTable.Rows[0]["profile_image"].ToString();
                if(!dataTable.Rows[0]["profile_image"].ToString().Equals(""))
                {
                    image.Image = Bitmap.FromFile(Path.Combine(this.appPath, dataTable.Rows[0]["profile_image"].ToString()));
                }
            }
            else
            {
                MessageBox.Show(String.Format("Employee contain id : {0} were not found",employee_id),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (this.validateInput())
                {
                    string name = Encrption.trim(txt_name.Text.ToString());
                    string father_name = Encrption.trim(txt_fathername.Text.ToString());
                    string email = Encrption.trim(txt_email.Text.ToString());
                    string mobile = Encrption.trim(txt_mobile.Text.ToString());
                    string nic = Encrption.trim(txt_nic.Text.ToString());
                    string address = Encrption.trim(txt_address.Text.ToString());
                    string user_role = cb_role.SelectedValue.ToString();
                    string user_status = cb_status.SelectedValue.ToString();
                    string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    if (this.isEditEmployee == true)
                    {
                        if (this.filePath.Equals("") && this.fileExt.Equals(""))
                        {
                            if (this.removeImage == true)
                            {
                                employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, "", user_status, updated_at);

                            }
                            else
                            {
                                employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, this.previousImage, user_status, updated_at);

                            }
                            if (employee.updateEmployee() > 0)
                            {
                                MessageBox.Show("Record has been updated");
                                this.Close();
                            }
                        }
                        else
                        {
                            string file = Guid.NewGuid() + "_" + this.employeeId + this.fileExt;
                            this.appPath = this.appPath + file;
                            File.Copy(this.filePath, this.appPath);
                            employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, file, user_status, updated_at);
                            if (employee.updateEmployee() > 0)
                            {
                                MessageBox.Show("Record has been updated");
                                this.Close();
                            }

                        }
                    }
                    else
                    {
                        employee = new Employee(name, father_name, address, email, mobile, nic, user_role, "", user_status, created_at, updated_at);
                        int result = employee.addEmployee();
                        if (result > 0)
                        {
                            if (this.filePath.Equals("") && this.fileExt.Equals(""))
                            {
                                MessageBox.Show(String.Format("{0} Record has been inserted.", result));
                                this.nullInputFied();
                                this.Close();
                            }
                            else
                            {
                                string employeeId = employee.getLastInsertedItemId();
                                string file = Guid.NewGuid() + "_" + employeeId + this.fileExt;
                                this.appPath = this.appPath + file;
                                File.Copy(this.filePath, this.appPath);

                                employee = null;
                                employee = new Employee(employeeId, file);
                                int check = employee.updateItemImage();
                                if (check > 0)
                                {
                                    MessageBox.Show("Record has been inserted");
                                    this.nullInputFied();
                                    this.Close();
                                }
                            }
                        }

                    }
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(this.validateInput())
            {
                string name = Encrption.trim(txt_name.Text.ToString());
                string father_name = Encrption.trim(txt_fathername.Text.ToString());
                string email = Encrption.trim(txt_email.Text.ToString());
                string mobile = Encrption.trim(txt_mobile.Text.ToString());
                string nic = Encrption.trim(txt_nic.Text.ToString());
                string address = Encrption.trim(txt_address.Text.ToString());
                string user_role = cb_role.SelectedValue.ToString();
                string user_status = cb_status.SelectedValue.ToString();
                string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                if (this.isEditEmployee == true)
                {
                    if (this.filePath.Equals("") && this.fileExt.Equals(""))
                    {
                        if(this.removeImage == true)
                        {
                            employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, "" , user_status, updated_at);

                        }
                        else
                        {
                            employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, this.previousImage, user_status, updated_at);

                        }
                        if (employee.updateEmployee() > 0)
                        {
                            MessageBox.Show("Employee has updated successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        string file = Guid.NewGuid() + "_" + this.employeeId + this.fileExt;
                        this.appPath = this.appPath + file;
                        File.Copy(this.filePath, this.appPath);
                        employee = new Employee(int.Parse(this.employeeId), name, father_name, address, email, mobile, nic, user_role, file, user_status, updated_at);
                        if(employee.updateEmployee() > 0)
                        {
                            MessageBox.Show("Employee has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        
                    }
                }
                else
                {
                    employee = new Employee(name, father_name, address, email, mobile, nic, user_role, "", user_status, created_at, updated_at);
                    int result = employee.addEmployee();
                    if(result > 0)
                    {
                        if (this.filePath.Equals("") && this.fileExt.Equals(""))
                        {
                            MessageBox.Show("Employee has inserted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.nullInputFied();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            string employeeId = employee.getLastInsertedItemId();
                            string file = Guid.NewGuid() + "_" + employeeId + this.fileExt;
                            this.appPath = this.appPath + file;
                            File.Copy(this.filePath, this.appPath);

                            employee = null;
                            employee = new Employee(employeeId, file);
                            int check = employee.updateItemImage();
                            if (check > 0)
                            {
                                MessageBox.Show("Employee has inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.nullInputFied();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }

                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(this.isEditEmployee == true)
            {
                var confirm = MessageBox.Show(String.Format("Are you sure to delete employee {0}. if you delete employee {1} all record related to it will also be lost",this.employeeName,this.employeeName),
                    "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(confirm  == DialogResult.Yes)
                {
                    employee = new Employee(this.employeeId);
                    int result = employee.deleteEmployee();
                    if(result > 0)
                    {
                        MessageBox.Show("Employee has been deleted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            else
            {
                this.Close();
            }
        }
        private void btn_changeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select an Image";
            opFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";


            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Directory.Exists(this.appPath) == false)
                    {
                        Directory.CreateDirectory(this.appPath);
                    }
                    //string iName = opFile.SafeFileName;   
                    this.filePath = opFile.FileName;
                    this.fileExt = Path.GetExtension(opFile.FileName);
                    image.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
        private bool validateInput()
        {
            StringBuilder builder = new StringBuilder();
            int isError = 0;

            if (txt_name.Text.ToString().Length > 0)
            {
                if(!Encrption.Is_Alphabetic(txt_name.Text.ToString()))
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

            if (txt_fathername.Text.ToString().Length > 0)
            {
                if (!Encrption.Is_Alphabetic(txt_fathername.Text.ToString()))
                {
                    isError++;
                    builder.Append("Father name must be alphabetic").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter father name").AppendLine();
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
                builder.Append("Please enter email").AppendLine();
            }

            Employee employee = new Employee();
            if (this.isEditEmployee == true)
            {
                // Mobile
                if (txt_mobile.Text.ToString().Length > 0)
                {
                    if (double.TryParse(txt_mobile.Text.ToString(), out double result))
                    {
                        if (txt_mobile.Text.ToString().Length != 11)
                        {
                            isError++;
                            builder.Append("mobile lenght should be 11 digits").AppendLine();
                        }
                        else
                        {
                            if(!this.mobile_no.Equals(txt_mobile.Text.ToString()))
                            {
                                if(employee.checkPhoneAlreadyExist(txt_mobile.Text.ToString()))
                                {
                                    isError++;
                                    builder.Append("Mobile number already exists").AppendLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Mobile number must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("please enter mobile number").AppendLine();
                }

                // Nic 
                if (txt_nic.Text.ToString().Length > 0)
                {
                    if (double.TryParse(txt_nic.Text.ToString(), out double result))
                    {
                        if (txt_nic.Text.ToString().Length != 13)
                        {
                            isError++;
                            builder.Append("Nic lenght should be 13 digits").AppendLine();
                        }
                        else
                        {
                            if(!this.cnic_no.Equals(txt_nic.Text.ToString()))
                            {
                                if(employee.checkNicAlreadyExist(txt_nic.Text.ToString()))
                                {
                                    isError++;
                                    builder.Append("Nic number already exist").AppendLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Nic number must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Please enter nic number").AppendLine();
                }

            }
            else
            {
                // Mobile
                if (txt_mobile.Text.ToString().Length > 0)
                {
                    if (double.TryParse(txt_mobile.Text.ToString(), out double result))
                    {
                        if (txt_mobile.Text.ToString().Length != 11)
                        {
                            isError++;
                            builder.Append("mobile lenght should be 11 digits").AppendLine();
                        }
                        else
                        {
                            if(employee.checkPhoneAlreadyExist(txt_mobile.Text.ToString()))
                            {
                                isError++;
                                builder.Append("Mobile number already exists").AppendLine();
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Mobile number must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("please enter mobile number").AppendLine();
                }

                // Nic
                if (txt_nic.Text.ToString().Length > 0)
                {
                    if (double.TryParse(txt_nic.Text.ToString(), out double result))
                    {
                        if (txt_nic.Text.ToString().Length != 13)
                        {
                            isError++;
                            builder.Append("Nic lenght should be 13 digits").AppendLine();
                        }
                        else
                        {
                            if (employee.checkNicAlreadyExist(txt_nic.Text.ToString()))
                            {
                                isError++;
                                builder.Append("Nic number already exist").AppendLine();
                            }
                        }
                    }
                    else
                    {
                        isError++;
                        builder.Append("Nic number must be numeric").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Please enter nic number").AppendLine();
                }
            }

            if (txt_address.Text.Length > 0)
            {
                if(txt_address.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Address is too long").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("please enter address").AppendLine();
            }

            if (isError > 0)
            {
                MessageBox.Show(builder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btn_removeImg_Click(object sender, EventArgs e)
        {
            this.removeImage = true;
            image.Image = new Bitmap( Properties.Resources.default_avatar );
        }
        private void nullInputFied()
        {
            txt_name.Clear();
            txt_email.Clear();
            txt_fathername.Clear();
            txt_address.Clear();
            txt_mobile.Clear();
            txt_nic.Clear();
        }


    }
}
