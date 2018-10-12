using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class KitchenOrder : crudHandler
    {
        private string id;
        private string order_id;
        private string kitchen_id;
        private string created_at;
        private string updated_at;

        private Orders orders;

        public KitchenOrder(Orders newOrder)
        {
            this.orders = newOrder;
            this.Id = "";
            this.Order_id = "";
            this.Kitchen_id = "";
            this.Created_at = "";
            this.Updated_at = "";
        }



        public KitchenOrder(string id, string order_id, string kitchen_id, string created_at, string updated_at)
        {
            this.Id = id;
            this.Order_id = order_id;
            this.Kitchen_id = kitchen_id;
            this.Created_at = created_at;
            this.Updated_at = updated_at;
        }

        public string Id { get => id; set => id = value; }
        public string Order_id { get => order_id; set => order_id = value; }
        public string Kitchen_id { get => kitchen_id; set => kitchen_id = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }

        public bool insertKitchenOrder()
        {
            List<Tuple<string, string>> column = new List<Tuple<string, string>>();
            column.Add(Tuple.Create("order_id", this.orders.Id));
            column.Add(Tuple.Create("kitchen_id", this.kitchen_id));
            return Convert.ToBoolean(this.insert("kitchen_order", column));
        }

        public DataTable getKitchenOrder()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("order_id", this.orders.Id));
            return this.select("kitchen_order", whereClause);
        }

        public bool deleteKitchenOrder()
        {
            Hashtable whereCondition = new Hashtable();
            whereCondition.Add("order_id",this.orders.Id);
            whereCondition.Add("kitchen_id",this.kitchen_id);

            return Convert.ToBoolean( this.delete("kitchen_order", whereCondition) );
        }

        public bool checkKitchenExistWithOrder()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_id",this.orders.Id));
            columns.Add(Tuple.Create("kitchen_id", this.kitchen_id ));
            if( this.select("kitchen_order",columns).Rows.Count == 1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getId()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_id", this.orders.Id));
            columns.Add(Tuple.Create("kitchen_id", this.kitchen_id));
            DataTable data = this.select("kitchen_order",columns,new string[] { "*" });
            if(data.Rows.Count == 1)
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
            string querey = "SELECT id FROM kitchen_order ORDER BY id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if (data.Rows.Count == 1)
            {
                this.id = data.Rows[0]["id"].ToString();
            }
        }

    }
}
