using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Orders : crudHandler
    {
        private string id;
        private string invoice_no;
        private string order_type_id;
        private string order_type;
        private string table_id;
        private string table_name;
        private string floor;
        private string zone;
        private string server_id;
        private string server_name;
        private string user_id;
        private string order_status_id;
        private string user_name;
        private string tax;
        private string total;
        private string payment_method;
        private string payment_recieved;
        private string amount_returned;
        private string created_at;
        private string updated_at;

        public Orders()
        {
            this.id = "";
            this.invoice_no = "";
            this.order_type_id = "";
            this.order_type = "";
            this.table_id = "";
            this.table_name = "";
            this.floor = "";
            this.zone = "";
            this.server_id = "";
            this.server_name = "";
            this.user_id = "";
            this.user_name = "";
            this.tax = "";
            this.total = "";
            this.payment_method = "";
            this.payment_recieved = "";
            this.amount_returned = "";
            this.created_at = "";
            this.updated_at = "";
        }

        public string Id { get => id; set => id = value; }
        public string Order_type_id { get => order_type_id; set => order_type_id = value; }
        public string Invoice_no { get => invoice_no; set => invoice_no = value; }
        public string Order_type { get => order_type; set => order_type = value; }
        public string Table_id { get => table_id; set => table_id = value; }
        public string Table_name { get => table_name; set => table_name = value; }
        public string Floor { get => floor; set => floor = value; }
        public string Zone { get => zone; set => zone = value; }
        public string Server_id { get => server_id; set => server_id = value; }
        public string Server_name { get => server_name; set => server_name = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Tax { get => tax; set => tax = value; }
        public string Total { get => total; set => total = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }
        public string Payment_recieved { get => payment_recieved; set => payment_recieved = value; }
        public string Amount_returned { get => amount_returned; set => amount_returned = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }
        public string Order_status_id { get => order_status_id; set => order_status_id = value; }

        public DataTable getOrderDetail()
        {
            string querey = "select orders.* , order_items.*,items.apply_discount,items.discount, item_categories.* from orders INNER JOIN order_items ";
            querey += "on orders.id = order_items.order_id ";
            querey += "INNER JOIN items on items.id = order_items.item_id ";
            querey += "INNER JOIN item_categories on item_categories.id = items.category_id ";
            querey += "WHERE orders.id = "+this.id;
            querey += " and order_status_id = 1";

            return this.executeQuerey(querey);
        }

        public bool cancelOrder()
        {
            Hashtable columns = new Hashtable();
            columns.Add("order_status_id","2");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            return Convert.ToBoolean(this.update("orders",columns,whereClause));
        }

        public bool createOrder(bool isDineIn = true)
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_type_id", this.order_type_id));
            columns.Add(Tuple.Create("order_type", "\'" + this.order_type + "\'"));
            if(isDineIn.Equals(true))
            {
                columns.Add(Tuple.Create("table_id", this.table_id));
                columns.Add(Tuple.Create("table_name", "\'" + this.table_name + "\'"));
                columns.Add(Tuple.Create("floor", "\'" + this.floor + "\'"));
                columns.Add(Tuple.Create("zone", "\'" + this.zone + "\'"));
            }
            columns.Add(Tuple.Create("server_id", this.server_id));
            columns.Add(Tuple.Create("order_status_id", this.order_status_id));
            columns.Add(Tuple.Create("server_name", "\'" + this.server_name + "\'"));
            columns.Add(Tuple.Create("user_id", this.user_id));
            columns.Add(Tuple.Create("user_name", "\'" + this.user_name + "\'"));
            columns.Add(Tuple.Create("order_date","\'"+ DateTime.Now.ToString("yyyy-MM-dd") + "\'"));
            return Convert.ToBoolean(this.insert("orders", columns));
        }

        public DataTable getTakeAwayOrders()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("order_type", "'take_away'"));
            return this.select("orders", whereClause);
        }

        public DataTable getDelieveryOrder()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("order_type", "'home_delivery'"));
            return this.select("orders", whereClause);
        }

        public DataTable getOrders()
        {
            string query = "SELECT orders.*,order_items.* FROM orders INNER JOIN order_items WHERE orders.id = order_items.order_id  order BY orders.id DESC";
            return this.executeQuerey(query);
        }

        public DataTable getOrders(string start_date,string end_date)
        {
            string query = "SELECT orders.*,order_items.* FROM orders INNER JOIN order_items WHERE orders.id = order_items.order_id and orders.order_date BETWEEN '"+start_date+"' and '"+end_date+"' order BY orders.id DESC";
            return this.executeQuerey(query);
        }

        public bool completeOrder(bool isPayByCash = true)
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            Hashtable columns = new Hashtable();
            columns.Add("order_status_id", this.order_status_id);
            columns.Add("payment_method", "\'" + this.payment_method + "\'");
            if (isPayByCash)
            {
                columns.Add("amount_received", Convert.ToDouble( this.payment_recieved) );
                columns.Add("amount_returned", Convert.ToDouble( this.amount_returned) );
            }
            
            return Convert.ToBoolean(this.update("orders",columns,whereClause));
        }

        public bool isTableNotFree()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("table_id", this.table_id));
            whereClause.Add(Tuple.Create("amount_received", "0"));
            whereClause.Add(Tuple.Create("order_status_id", "1"));

            DataTable data = this.select("orders", whereClause);
            if(data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string getOrderIdByTable()
        {
            string querey = "SELECT id FROM orders where table_id = "+this.table_id+ " and order_status_id = 1 ORDER BY id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if(data.Rows.Count > 0)
            {
                return data.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        public void holdLastInsertedId()
        {
            string querey = "SELECT id FROM orders ORDER BY id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if (data.Rows.Count == 1)
            {
                this.id =  data.Rows[0]["id"].ToString();
            }
        }




    }
}
