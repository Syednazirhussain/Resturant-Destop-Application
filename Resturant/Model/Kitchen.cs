using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Kitchen : crudHandler
    {
        private string id { get; set; }

        private string name { get; set; }

        private DataTable dataKitchen;

        public Kitchen()
        {
            this.id = "";
            this.name = "";
            this.dataKitchen = this.LoadKitchens();
        }

        public Kitchen(string kitchen_id)
        {
            this.id = kitchen_id;
        }

        public Kitchen(string kitchen_id,string kitchen_name)
        {
            this.id = kitchen_id;
            this.name = kitchen_name;
        }

        public DataTable LoadKitchens()
        {
            string querey = "select kitchens.* , item_categories.id as category_id,item_categories.name as category_name, kitchen_items.id as kitchen_items_id from kitchen_items inner join kitchens on kitchens.id = kitchen_items.kitchen_id inner join item_categories on item_categories.id = kitchen_items.category_id order by kitchens.id DESC";
            return this.executeQuerey(querey);
        }

        public DataTable searchKitchen(string keyword)
        {
            string query = "select kitchens.* , item_categories.id as category_id,item_categories.name as category_name, kitchen_items.id as kitchen_items_id from kitchen_items";
            query += " inner join kitchens on kitchens.id = kitchen_items.kitchen_id inner join item_categories on item_categories.id = kitchen_items.category_id";
            query += " WHERE kitchens.name LIKE '%"+keyword+"%' order by kitchens.id DESC";
            return this.executeQuerey(query);
        }


        public DataTable getKitchenById()
        {
            string querey = "select kitchens.* , item_categories.id as category_id,item_categories.name as category_name, kitchen_items.id as kitchen_items_id from kitchen_items inner join kitchens on kitchens.id = kitchen_items.kitchen_id inner join item_categories on item_categories.id = kitchen_items.category_id where kitchens.id = "+this.id;
            return this.executeQuerey(querey);
        }
        public DataTable getKitchenItems()
        {
            return this.select("kitchen_items");
        }
        public DataTable categoryExist(string category_id)
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("category_id", category_id));

            return this.select("kitchen_items", Columns, new string[] { "category_id" });
        }
        public string getLastInsertedId()
        {
            string querey = "SELECT id from kitchens order by id DESC LIMIT 1";
            DataTable data = this.executeQuerey(querey);
            if(data.Rows.Count > 0)
            {
                string kitchen_id = data.Rows[0]["id"].ToString();
                return kitchen_id;
            }
            else
            {
                return null;
            }
        }

        public DataTable getKitchensByPrimaryKeys(DataTable data)
        {
            string in_clause = "";
            int index = 0;
            foreach(DataRow row in data.Rows)
            {
                if(data.Rows.Count - index == 1)
                {
                    in_clause += row["kitchen_id"].ToString();
                }
                else
                {
                    in_clause += row["kitchen_id"].ToString() + ",";
                }
                index++;
            }
            string query = "select * from kitchens where id IN("+in_clause+")";
            return this.executeQuerey(query);

        }

        public int assignCategorytoKitchen(string kitchen_id,List<string> category)
        {
            int result = 0;
            if(category.Count > 0)
            {
                Dictionary<int, List<string>> columnsValues = new Dictionary<int, List<string>>();

                int index = 0;
                foreach(string item in category)
                {
                    columnsValues.Add(index, new List<string>() { kitchen_id,item });
                    index++;
                }
                result =  this.insert("kitchen_items", new string[] { "kitchen_id", "category_id" }, columnsValues);
            }
            return result;
        }

        public int deleteExistingKitchenCategories(List<string> categories_id)
        {
            string querey = "DELETE FROM kitchen_items WHERE (category_id) IN (" + String.Join(",",categories_id)+")";
            return this.insertUpdateDeleteByQuery(querey);
        }

        public int deleteKitchen()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);
            return this.delete("kitchens",whereClause);
        }

        public int updateKitchenWithKitchenItems(List<string> categories)
        {
            foreach (string items in categories)
            {
                this.insertUpdateDeleteByQuery("insert into kitchen_items (kitchen_id,category_id) values ("+this.id+","+items+")");
            }

            Hashtable Columns = new Hashtable();
            Columns.Add("name", "\'" + this.name + "\'");

            Hashtable WhereClause = new Hashtable();
            WhereClause.Add("id", this.id);

            return this.update("kitchens", Columns, WhereClause);
            
        }

        public int updateKitchen()
        {
            Hashtable Columns = new Hashtable();
            Columns.Add("name", "\'" + this.name + "\'");

            Hashtable WhereClause = new Hashtable();
            WhereClause.Add("id", this.id);

            return this.update("kitchens", Columns, WhereClause);
        }

        public int addKitchen(string name)
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + name + "\'"));
            return this.insert("kitchens", Columns);
        }
        
        public List<Tuple<string, string, string>> getKitchens(DataTable data = null)
        {
            List<Tuple<string, string, string>> kitchen = new List<Tuple<string, string, string>>();

            if(data != null)
            {
                if (data.Rows.Count > 0)
                {
                    List<string> cat = new List<string>();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            cat.Add(data.Rows[i]["category_name"].ToString());
                        }
                        else
                        {
                            if (data.Rows[i - 1]["id"].ToString().Equals(data.Rows[i]["id"].ToString()))
                            {
                                if (data.Rows.Count - i == 1)
                                {
                                    cat.Add(data.Rows[i]["category_name"].ToString());
                                    kitchen.Add(Tuple.Create(data.Rows[i - 1]["id"].ToString(), data.Rows[i - 1]["name"].ToString(), string.Join<string>(" | ", cat)));
                                    cat.Clear();
                                }
                                else
                                {
                                    cat.Add(data.Rows[i]["category_name"].ToString());
                                }
                            }
                            else
                            {
                                kitchen.Add(Tuple.Create(data.Rows[i - 1]["id"].ToString(), data.Rows[i - 1]["name"].ToString(), string.Join<string>(" | ", cat)));
                                cat.Clear();
                                if (data.Rows.Count - i == 1)
                                {
                                    cat.Add(data.Rows[i]["category_name"].ToString());
                                    kitchen.Add(Tuple.Create(data.Rows[i]["id"].ToString(), data.Rows[i]["name"].ToString(), string.Join<string>(" | ", cat)));
                                    cat.Clear();
                                }
                                else
                                {
                                    cat.Add(data.Rows[i]["category_name"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (this.dataKitchen.Rows.Count > 0)
                {
                    List<string> cat = new List<string>();

                    for (int i = 0; i < this.dataKitchen.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            cat.Add(this.dataKitchen.Rows[i]["category_name"].ToString());
                        }
                        else
                        {
                            if (this.dataKitchen.Rows[i - 1]["id"].ToString().Equals(this.dataKitchen.Rows[i]["id"].ToString()))
                            {
                                if (this.dataKitchen.Rows.Count - i == 1)
                                {
                                    cat.Add(this.dataKitchen.Rows[i]["category_name"].ToString());
                                    kitchen.Add(Tuple.Create(this.dataKitchen.Rows[i - 1]["id"].ToString(), this.dataKitchen.Rows[i - 1]["name"].ToString(), string.Join<string>(" | ", cat)));
                                    cat.Clear();
                                }
                                else
                                {
                                    cat.Add(this.dataKitchen.Rows[i]["category_name"].ToString());
                                }
                            }
                            else
                            {
                                kitchen.Add(Tuple.Create(this.dataKitchen.Rows[i - 1]["id"].ToString(), this.dataKitchen.Rows[i - 1]["name"].ToString(), string.Join<string>(" | ", cat)));
                                cat.Clear();
                                if (this.dataKitchen.Rows.Count - i == 1)
                                {
                                    cat.Add(this.dataKitchen.Rows[i]["category_name"].ToString());
                                    kitchen.Add(Tuple.Create(this.dataKitchen.Rows[i]["id"].ToString(), this.dataKitchen.Rows[i]["name"].ToString(), string.Join<string>(" | ", cat)));
                                    cat.Clear();
                                }
                                else
                                {
                                    cat.Add(this.dataKitchen.Rows[i]["category_name"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            return kitchen;
        }




    }
}
