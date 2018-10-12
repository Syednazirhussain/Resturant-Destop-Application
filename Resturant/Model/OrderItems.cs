using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class OrderItems : crudHandler
    {
        private string id;
        private string order_id;
        private string item_id;
        private string item_name;
        private string item_qty;
        private string item_price;
        private string item_discount;
        private string total;
        private string additional_notes;
        private string kitchen_id;
        private string kitchen_name;
        private string kitchen_status;
        private string created_at;
        private string updated_at;

        private Orders orders;

        public OrderItems(Orders newOrder)
        {
            this.orders = newOrder;
            this.id = "";
            this.order_id = "";
            this.item_id = "";
            this.item_name = "";
            this.item_qty = "";
            this.item_price = "";
            this.Item_discount = "";
            this.Total = "";
            this.additional_notes = "";
            this.kitchen_id = "";
            this.kitchen_name = "";
            this.kitchen_status = "";
            this.created_at = "";
            this.updated_at = "";
        }

        public OrderItems()
        {
            this.id = "";
            this.order_id = "";
            this.item_id = "";
            this.item_name = "";
            this.item_qty = "";
            this.item_price = "";
            this.Item_discount = "";
            this.Total = "";
            this.additional_notes = "";
            this.kitchen_id = "";
            this.kitchen_name = "";
            this.kitchen_status = "";
            this.created_at = "";
            this.updated_at = "";
        }

        public string Id { get => id; set => id = value; }
        public string Order_id { get => order_id; set => order_id = value; }
        public string Item_id { get => item_id; set => item_id = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Item_qty { get => item_qty; set => item_qty = value; }
        public string Item_price { get => item_price; set => item_price = value; }
        public string Additional_notes { get => additional_notes; set => additional_notes = value; }
        public string Kitchen_id { get => kitchen_id; set => kitchen_id = value; }
        public string Kitchen_name { get => kitchen_name; set => kitchen_name = value; }
        public string Kitchen_status { get => kitchen_status; set => kitchen_status = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }
        public string Item_discount { get => item_discount; set => item_discount = value; }
        public string Total { get => total; set => total = value; }

        public bool insertOrderItem()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_id", this.orders.Id));
            columns.Add(Tuple.Create("item_id", this.item_id));
            columns.Add(Tuple.Create("item_name", "\'" + this.item_name + "\'"));
            columns.Add(Tuple.Create("item_qty", this.item_qty));
            columns.Add(Tuple.Create("item_price", this.item_price));
            columns.Add(Tuple.Create("item_discount", this.item_discount));
            columns.Add(Tuple.Create("total", this.total));
            columns.Add(Tuple.Create("additional_note", "\'" + this.additional_notes + "\'"));
            columns.Add(Tuple.Create("kitchen_id", this.kitchen_id));
            columns.Add(Tuple.Create("kitchen_name", "\'" + this.kitchen_name + "\'"));
            return Convert.ToBoolean(this.insert("order_items",columns));
        }

        public DataTable getLastInsertedOrderItems()
        {
            List<Tuple<string, string>> column = new List<Tuple<string, string>>();
            column.Add(Tuple.Create("order_id",this.orders.Id));
            return this.select("order_items", column);
        }

        public bool updateOrderItem()
        {
            Hashtable columns = new Hashtable();
            columns.Add("item_qty", this.item_qty);
            columns.Add("item_discount", this.Item_discount);
            columns.Add("total", this.total);
            columns.Add("additional_note", "\'" + this.additional_notes + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return Convert.ToBoolean(this.update("order_items",columns,whereClause));
        }

        public DataTable getOrderItems()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("order_id",this.orders.Id));
            columns.Add(Tuple.Create("kitchen_id",this.kitchen_id));

            return this.select("order_items", columns);
        }

        public DataTable kitchenReceipt()
        {
            string query = "SELECT order_items.* , kitchen_order.id FROM `order_items` INNER JOIN ";
            query += "kitchen_order WHERE order_items.kitchen_id = kitchen_order.kitchen_id ";
            query += "and order_items.order_id = kitchen_order.order_id and order_items.order_id = "+this.orders.Id+" ";
            query += "and order_items.kitchen_id = "+this.kitchen_id;

            return this.executeQuerey(query);
        }

        public bool deleteOrderItem()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);
            return Convert.ToBoolean(this.delete("order_items",whereClause));
        }

        public bool checkIfExistKitchen()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("kitchen_id", this.kitchen_id));
            whereClause.Add(Tuple.Create("order_id", this.orders.Id));
            if(this.select("order_items",whereClause).Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
