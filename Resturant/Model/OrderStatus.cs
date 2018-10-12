using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class OrderStatus : crudHandler
    {

        private string id;
        private string name;


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public DataTable getOrderStatus()
        {
            return this.select("order_status");
        }

        public  string getOrderStatus(string name)
        {
            string query = "select * from order_status where name = '"+name+"'";
            return this.executeQuerey(query).Rows[0]["id"].ToString();
        }


    }
}
