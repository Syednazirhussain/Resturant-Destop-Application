using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Employee : crudHandler
    {
        private string id { get; set; }
        private string name { get; set; }
        private string father_name { get; set; }
        private string address { get; set; }
        private string email { get; set; }
        private string mobile_no { get; set; }
        private string cnic_no { get; set; }
        private string user_role_code { get; set; }
        private string profile_image { get; set; }
        private string user_status_id { get; set; }
        private string created_at { get; set; }
        private string updated_at { get; set; }

        public Employee()
        {
            this.id = null;
            this.name = null;
            this.father_name = null;
            this.address = null;
            this.email = null;
            this.mobile_no = null;
            this.cnic_no = null;
            this.user_role_code = null;
            this.profile_image = null;
            this.user_status_id = null;
            this.created_at = null;
            this.updated_at = null;
        }

        public Employee(string employee_id)
        {
            this.id = employee_id;
        }

        public Employee(string employee_id,string image)
        {
            this.id = employee_id;
            this.profile_image = image;
        }

        public Employee(int id,string name,string father_name,string address,string email,string mobile_no,string cnic_no,string user_role_code,string profile_image,string status,string updated_at)
        {
            this.id = id.ToString();
            this.name = name;
            this.father_name = father_name;
            this.address = address;
            this.email = email;
            this.mobile_no = mobile_no;
            this.cnic_no = cnic_no;
            this.user_role_code = user_role_code;
            this.profile_image = profile_image;
            this.user_status_id = status;
            this.updated_at = updated_at;
        }

        public Employee(string name, string father_name, string address, string email, string mobile_no, string cnic_no, string user_role_code, string profile_image, string status,string created_at, string updated_at)
        {
            this.name = name;
            this.father_name = father_name;
            this.address = address;
            this.email = email;
            this.mobile_no = mobile_no;
            this.cnic_no = cnic_no;
            this.user_role_code = user_role_code;
            this.profile_image = profile_image;
            this.user_status_id = status;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public DataTable getEmployees()
        {
            string querey = "select employees.* , user_roles.id as userRoleId, user_roles.name as userRoleName , user_status.id as userStatusId,user_status.name as UserStatusName from employees inner JOIN user_roles on user_roles.id = employees.user_status_id inner JOIN user_status on user_status.id = employees.user_status_id order by employees.name";
            return this.executeQuerey(querey);
        }

        public bool checkPhoneAlreadyExist(string phone)
        {
            DataTable data = this.executeQuerey("select * from employees where mobile_no = "+phone);
            if(data.Rows.Count > 0 && data.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkNicAlreadyExist(string Nic)
        {
            DataTable data = this.executeQuerey("select * from employees where cnic_no = "+Nic);
            if(data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getEmployeeById()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id", this.id));
            return this.select("employees", whereClause);
        }

        public string getServerNameById(string server_id)
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id",server_id));
            whereClause.Add(Tuple.Create("user_role_code", "'waiter'"));
            return this.select("employees", whereClause, new string[] { "name" }).Rows[0]["name"].ToString();
        }
        public int updateEmployee()
        {
            Hashtable columns = new Hashtable();
            columns.Add("name", "\'" + this.name + "\'");
            columns.Add("father_name", "\'" + this.father_name + "\'");
            columns.Add("address", "\'" + this.address + "\'");
            columns.Add("email", "\'" + this.email + "\'");
            columns.Add("mobile_no", "\'" + this.mobile_no + "\'");
            columns.Add("cnic_no", this.cnic_no);
            columns.Add("user_role_code", "\'" + this.user_role_code + "\'");
            columns.Add("profile_image", "\'" + this.profile_image + "\'");
            columns.Add("user_status_id", "\'" + this.user_status_id + "\'");
            columns.Add("updated_at", "\'" + this.updated_at + "\'");


            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            return this.update("employees",columns,whereClause);
        }
        public List<string> getAllImages()
        {
            DataTable data = this.select("employees", null, new string[] { "profile_image" });
            List<string> images = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                images.Add(row["profile_image"].ToString());
            }
            return images;
        }
        public int deleteEmployee()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            return this.delete("employees",whereClause);
        }
        public DataTable getWaiterEmployees()
        {
            string querey = "select employees.id,employees.name from employees INNER JOIN ";
            querey += "user_roles on employees.user_role_code = user_roles.code ";
            querey += "WHERE employees.user_role_code = 'waiter'";

            return this.executeQuerey(querey);
        }
        public DataTable searchEmployee(string keyword,string type)
        {
            DataTable data = new DataTable();
            if (type.Equals("Name"))
            {
                data = null;
                string querey = "select employees.* , user_roles.id as userRoleId, user_roles.name as userRoleName , user_status.id as userStatusId,user_status.name as UserStatusName from employees inner JOIN user_roles on user_roles.id = employees.user_status_id inner JOIN user_status on user_status.id = employees.user_status_id where employees.name like '%" + keyword + "%' order by employees.id DESC";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Role"))
            {
                data = null;
                string querey = "select employees.* , user_roles.id as userRoleId, user_roles.name as userRoleName , user_status.id as userStatusId,user_status.name as UserStatusName from employees inner JOIN user_roles on user_roles.id = employees.user_status_id inner JOIN user_status on user_status.id = employees.user_status_id where employees.user_role_code like '%" + keyword + "%' order by employees.id DESC";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Mobile"))
            {
                string querey = "select employees.* , user_roles.id as userRoleId, user_roles.name as userRoleName , user_status.id as userStatusId,user_status.name as UserStatusName from employees inner JOIN user_roles on user_roles.id = employees.user_status_id inner JOIN user_status on user_status.id = employees.user_status_id where employees.mobile_no like '" + keyword + "%' order by employees.id DESC";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Nic"))
            {
                data = null;
                string querey = "select employees.* , user_roles.id as userRoleId, user_roles.name as userRoleName , user_status.id as userStatusId,user_status.name as UserStatusName from employees inner JOIN user_roles on user_roles.id = employees.user_status_id inner JOIN user_status on user_status.id = employees.user_status_id where employees.cnic_no like '" + keyword + "%' order by employees.id DESC";
                return this.executeQuerey(querey);
            }
            else
            {
                return data;
            }
        }
        public int addEmployee()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            Columns.Add(Tuple.Create("father_name", "\'" + this.father_name + "\'"));
            Columns.Add(Tuple.Create("address", "\'" + this.address + "\'"));
            Columns.Add(Tuple.Create("email", "\'" + this.email + "\'"));
            Columns.Add(Tuple.Create("mobile_no", "\'" + this.mobile_no + "\'"));
            Columns.Add(Tuple.Create("cnic_no", this.cnic_no));
            Columns.Add(Tuple.Create("user_role_code", "\'" + this.user_role_code + "\'"));
            Columns.Add(Tuple.Create("profile_image", "\'" + this.profile_image + "\'"));
            Columns.Add(Tuple.Create("user_status_id", "\'" + this.user_status_id + "\'"));
            Columns.Add(Tuple.Create("created_at", "\'" + this.created_at + "\'"));
            Columns.Add(Tuple.Create("updated_at", "\'" + this.updated_at + "\'"));

            return this.insert("employees", Columns);
        }
        public int updateItemImage()
        {
            Hashtable columns = new Hashtable();
            columns.Add("profile_image", "\'" + this.profile_image + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("employees", columns, whereClause);
        }
        public string getLastInsertedItemId()
        {
            string querey = "SELECT id FROM employees ORDER BY id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if (data.Rows.Count == 1)
            {
                return data.Rows[0]["id"].ToString();
            }
            else
            {
                return null;
            }
        }

    }
}
