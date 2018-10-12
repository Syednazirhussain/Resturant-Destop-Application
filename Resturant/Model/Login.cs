using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Model
{
    class Login : crudHandler
    {
        public static int user_id;
        public static string name;
        public static string username;
        public static string email;
        public static string user_role;
        public static string user_status;

        public DataTable Login_action(string username , string password)
        {
            String Password = Encrption.GetHashString(password);
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("username", "\'" + username + "\'"));
            Columns.Add(Tuple.Create("password", "\'" + Password + "\'"));

            DataTable data = this.select("users", Columns, new string[] { "*" });
            if (data.Rows.Count > 0)
            {
                Login.user_id = int.Parse(data.Rows[0]["id"].ToString());
                Login.name = data.Rows[0]["name"].ToString();
                Login.username = data.Rows[0]["username"].ToString();
                Login.email = data.Rows[0]["email"].ToString();
                Login.user_role = data.Rows[0]["user_role_code"].ToString();
                Login.user_status = data.Rows[0]["user_status_id"].ToString();

                return data;
            }
            return data;
        }

    }
}
