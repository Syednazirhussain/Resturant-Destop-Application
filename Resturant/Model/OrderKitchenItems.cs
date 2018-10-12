using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class OrderKitchenItems : crudHandler
    {
        private string id;
        private string order_id;
        private string kitchen_id;
        private string item_id;
        private string token;
        private string created_at;
        private string updated_at;
        private Orders orders;

        public OrderKitchenItems(Orders newOrder)
        {
            this.orders = newOrder;
            this.id = "";
            this.order_id = "";
            this.kitchen_id = "";
            this.item_id = "";
            this.token = "";
            this.created_at = "";
            this.updated_at = "";
        }

        public OrderKitchenItems(string id, string order_id, string kitchen_id, string item_id, string token, string created_at, string updated_at)
        {
            this.id = id;
            this.order_id = order_id;
            this.kitchen_id = kitchen_id;
            this.item_id = item_id;
            this.token = token;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public string Id { get => id; set => id = value; }
        public string Order_id { get => order_id; set => order_id = value; }
        public string Kitchen_id { get => kitchen_id; set => kitchen_id = value; }
        public string Item_id { get => item_id; set => item_id = value; }
        public string Token { get => token; set => token = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }

        public bool insertOrderKitchenItem()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_id", this.orders.Id));
            columns.Add(Tuple.Create("kitchen_id", this.kitchen_id));
            columns.Add(Tuple.Create("item_id", this.item_id));
            columns.Add(Tuple.Create("token", this.token));

            return Convert.ToBoolean(this.insert("order_kitchen_items", columns));

        }

        public bool deleteOrderKitchenItem()
        {
            Hashtable whereCondition = new Hashtable();
            whereCondition.Add("order_id", this.orders.Id);
            whereCondition.Add("kitchen_id", this.kitchen_id);

            return Convert.ToBoolean(this.delete("order_kitchen_items", whereCondition));
        }

    }
}
