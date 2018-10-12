using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections;

namespace Resturant.Model
{
    class Users : crudHandler
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string user_role { get; set; }

        public string user_status { get; set; }

        public string created_at { get; set; }

        public Users()
        {
            this.id = 0;
            this.name = null;
            this.username = null;
            this.email = null;
            this.password = null;
            this.user_role = null;
            this.user_status = null;
            this.created_at = null;
        }
        public Users(int userId)
        {
            this.id = userId;
        }
        public Users(int userId, string name,string username,string email, string password,string userROle,string userStatus,string createdAt)
        {
            this.id = userId;
            this.name = name;
            this.username = username;
            this.email = email;
            this.password = password;
            this.user_role = userROle;
            this.user_status = userStatus;
            this.created_at = createdAt;
        }

        public  bool is_LoginIdAlreadyExist(string username)
        {
            DataTable data = this.executeQuerey("select * from users where username = '" + username+"'");
            if(data.Rows.Count > 0 && data.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getUserById()
        {
            string user_id = this.id.ToString();

            List<Tuple<string, string>> WhereClause = new List<Tuple<string, string>>();
            WhereClause.Add(Tuple.Create("id",user_id));
            return this.select("users", WhereClause);
        }

        public DataTable verifyPassword(string password)
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("id", Login.user_id.ToString()));
            Columns.Add(Tuple.Create("password", "\'" + Encrption.GetHashString(password) + "\'"));
            return this.select("users", Columns);
        }
        public DataTable getUsers()
        {
            return this.executeQuerey("SELECT * FROM users ORDER by name");
        }

        public DataTable searchUser(string column_name,string keyword)
        {
            string querey = "select * from users where "+column_name+" like '%"+ keyword + "%'";
            return this.executeQuerey(querey);
        }

        public DataTable getUserRole()
        {
            return this.select("user_roles");
        }

        public DataTable getUserStatus()
        {
            return this.select("user_status");
        }

        public int addUser()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            Columns.Add(Tuple.Create("username", "\'" + this.username + "\'"));
            Columns.Add(Tuple.Create("email", "\'" + this.email + "\'"));
            Columns.Add(Tuple.Create("password", "\'" + Encrption.GetHashString(this.password) + "\'"));
            Columns.Add(Tuple.Create("user_role_code", "\'" + this.user_role + "\'" ));
            Columns.Add(Tuple.Create("user_status_id", this.user_status.ToString() ));
            Columns.Add(Tuple.Create("created_at", "\'" + this.created_at + "\'"));
            return this.insert("users",Columns);
        }

        public int updateUser()
        {
            Hashtable Columns = new Hashtable();
            Columns.Add("name", "\'" + this.name + "\'");
            Columns.Add("username", "\'" + this.username + "\'");
            Columns.Add("email", "\'" + this.email + "\'");
            Columns.Add("user_role_code", "\'" + this.user_role + "\'");
            Columns.Add("user_status_id",this.user_status);
            Columns.Add("password", "\'" + Encrption.GetHashString(this.password) + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            return this.update("users", Columns, whereClause);
        }

        public int deleteUser()
        {
            Hashtable WhereClause = new Hashtable();
            WhereClause.Add("id",this.id);
            return this.delete("users", WhereClause);
        }

    }
}
