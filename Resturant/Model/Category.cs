using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Category : crudHandler
    {
        public string id;
        public string name;
        public string created_at;

        public Category()
        {
            this.id = null;
            this.name = null;
            this.created_at = null;
        }

        public Category(string category_id)
        {
            this.id = category_id;
        }

        public Category(string name,string created_at)
        {
            this.name = name;
            this.created_at = created_at;
        }

        public Category(string category_id,string name,string created_at)
        {
            this.id = category_id;
            this.name = name;
            this.created_at = created_at;
        }

        public DataTable getCategory()
        {
            return this.select("item_categories");
        }

        public DataTable getCategoryById()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id",this.id));
            return this.select("item_categories",whereClause);
        }

        public int addCategory()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            Columns.Add(Tuple.Create("created_at", "\'" + this.created_at + "\'"));
            return this.insert("item_categories", Columns);
        }

        public int updateCategory()
        {
            Hashtable columns = new Hashtable();
            columns.Add("name", "\'" + this.name + "\'");
            columns.Add("created_at", "\'" + this.created_at + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("item_categories", columns, whereClause);
        }

        public int deleteCategory()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);
            return this.delete("item_categories",whereClause);
        }

        public DataTable searchCategory(string name)
        {
            string querey = "select * from item_categories where name like '%" + name + "%'";
            return this.executeQuerey(querey);
        }


    }
}
