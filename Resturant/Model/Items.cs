using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Items : crudHandler
    {
        private string id { get; set; }
        private string category_id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private string sale_price { get; set; }
        private string purchase_price { get; set; }
        private string discount { get; set; }
        private string apply_dicount { get; set; }
        private string apply_tax { get; set; }
        private string is_kitchen_item { get; set; }
        private string item_image { get; set; }
        private string created_at { get; set; }
        private string updated_at { get; set; }

        public Items()
        {
            this.id = null;
            this.category_id = null;
            this.name = null;
            this.description = null;
            this.sale_price = null;
            this.purchase_price = null;
            this.discount = null;
            this.apply_dicount = null;
            this.apply_tax = null;
            this.is_kitchen_item = null;
            this.item_image = null;
            this.created_at = null;
            this.updated_at = null; 
        }

        public Items(string categoryId,string Name,string desc,string salePrice,string purchasePrice,string Discount,string applyDis,string applyTax,string kitchenItem,string image,string created_at,string updated_at)
        {
            this.category_id = categoryId;
            this.name = Name;
            this.description = desc;
            this.sale_price = salePrice;
            this.purchase_price = purchasePrice;
            this.discount = Discount;
            this.apply_dicount = applyDis;
            this.apply_tax = applyTax;
            this.is_kitchen_item = kitchenItem;
            this.item_image = image;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public Items(string itemId,string categoryId, string Name, string desc, string salePrice, string purchasePrice, string Discount, string applyDis, string applyTax, string kitchenItem, string image, string created_at, string updated_at)
        {
            this.id = itemId;
            this.category_id = categoryId;
            this.name = Name;
            this.description = desc;
            this.sale_price = salePrice;
            this.purchase_price = purchasePrice;
            this.discount = Discount;
            this.apply_dicount = applyDis;
            this.apply_tax = applyTax;
            this.is_kitchen_item = kitchenItem;
            this.item_image = image;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }


        public Items(string item_id)
        {
            this.id = item_id;
        }

        public Items(string item_id,string imagePath)
        {
            this.id = item_id;
            this.item_image = imagePath;
        }


        public DataTable getItems()
        {
            string querey = "select items.* ,  item_categories.name as category_name from items  inner join item_categories on items.category_id = item_categories.id order by items.id DESC";
            return this.executeQuerey(querey);
        }

        public DataTable searchItem(string keyword,string type)
        {
            if(type.Equals("Name"))
            {
                string querey = "SELECT items.* , kitchens.* , item_categories.* from item_categories ";
                querey += "INNER JOIN items on ";
                querey += "item_categories.id = items.category_id ";
                querey += "INNER JOIN kitchen_items on ";
                querey += "item_categories.id = kitchen_items.category_id ";
                querey += "LEFT JOIN kitchens ON ";
                querey += "kitchen_items.kitchen_id = kitchens.id ";
                querey += "where items.name LIKE '%" + name + "%'";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Category"))
            {
                string querey = "SELECT items.* , kitchens.* , item_categories.* from item_categories ";
                querey += "INNER JOIN items on ";
                querey += "item_categories.id = items.category_id ";
                querey += "INNER JOIN kitchen_items on ";
                querey += "item_categories.id = kitchen_items.category_id ";
                querey += "LEFT JOIN kitchens ON ";
                querey += "kitchen_items.kitchen_id = kitchens.id ";
                querey += "where items.name LIKE '%" + name + "%'";
                return this.executeQuerey(querey);
            }
            else
            {
                return new DataTable();
            }
        }

        public DataTable getItemsByCategoryId(string category_id)
        {
            string querey = "SELECT items.* , kitchens.* , item_categories.* from item_categories ";
            querey += "INNER JOIN items on ";
            querey += "item_categories.id = items.category_id ";
            querey += "INNER JOIN kitchen_items on ";
            querey += "item_categories.id = kitchen_items.category_id ";
            querey += "LEFT JOIN kitchens ON ";
            querey += "kitchen_items.kitchen_id = kitchens.id ";
            querey += "where items.category_id = "+category_id;
            return this.executeQuerey(querey);
        }



        public DataTable getItemById()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id", this.id));
            return this.select("items", whereClause);
        }


        public int addItem()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("category_id", this.category_id));
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            Columns.Add(Tuple.Create("description", "\'" + this.description + "\'"));
            Columns.Add(Tuple.Create("sale_price", this.sale_price ));
            Columns.Add(Tuple.Create("purchase_price", this.purchase_price));
            Columns.Add(Tuple.Create("discount", this.discount ));
            Columns.Add(Tuple.Create("apply_discount", this.apply_dicount ));
            Columns.Add(Tuple.Create("apply_tax", this.apply_tax));
            Columns.Add(Tuple.Create("is_kitchen_item", this.is_kitchen_item));
            Columns.Add(Tuple.Create("item_image", "\'" + this.item_image + "\'"));
            Columns.Add(Tuple.Create("created_at", "\'" + this.created_at + "\'"));
            Columns.Add(Tuple.Create("updated_at", "\'" + this.updated_at + "\'"));

            return this.insert("items",Columns);
        }

        public int updateItem()
        {
            Hashtable Columns = new Hashtable();
            Columns.Add("category_id", this.category_id);
            Columns.Add("name", "\'" + this.name + "\'");
            Columns.Add("description", "\'" + this.description + "\'");
            Columns.Add("sale_price", this.sale_price);
            Columns.Add("purchase_price", this.purchase_price);
            Columns.Add("discount", this.discount);
            Columns.Add("apply_discount", this.apply_dicount);
            Columns.Add("apply_tax", this.apply_tax);
            Columns.Add("is_kitchen_item", this.is_kitchen_item);
            Columns.Add("item_image", "\'" + this.item_image + "\'");
            Columns.Add("created_at", "\'" + this.created_at + "\'");
            Columns.Add("updated_at", "\'" + this.updated_at + "\'");

            Hashtable WhereClause = new Hashtable();
            WhereClause.Add("id",this.id);

            return this.update("items", Columns, WhereClause);
        }

        public int updateItemImage()
        {
            Hashtable columns = new Hashtable();
            columns.Add("item_image", "\'" + this.item_image + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("items", columns, whereClause);
        }

        public int deleteItem()
        {
            Hashtable WhereClause = new Hashtable();
            WhereClause.Add("id",this.id);
            return this.delete("items", WhereClause);
        }


        public List<string> getAllItemImages()
        {
            DataTable data = this.select("items", null, new string[] { "item_image" });
            List<string> images = new List<string>();
            foreach(DataRow row in data.Rows)
            {
                images.Add(row["item_image"].ToString());
            }
            return images;
        }

        public string getLastInsertedItemId()
        {
            string querey = "SELECT id FROM items ORDER BY id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if(data.Rows.Count == 1)
            {
                return data.Rows[0]["id"].ToString();
            }
            else
            {
                return null;
            }
        }



        public DataTable getItemsWithCategoriesCount()
        {
            string querey = "SELECT items.category_id,c.name , COUNT(*) as count FROM items INNER join item_categories as c on items.category_id = c.id GROUP BY category_id";
            return this.executeQuerey(querey);
        }



    }
}
