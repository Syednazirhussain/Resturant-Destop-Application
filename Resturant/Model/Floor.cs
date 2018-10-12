using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Floor : crudHandler
    {

        private string id,name;

        public Floor()
        {
            this.id = null;
        }

        public Floor(string floor_id)
        {
            this.id = floor_id;
        }

        public Floor(string floor_id,string floor_name)
        {
            this.id = floor_id;
            this.name = floor_name;
        }

        public DataTable getFloorById()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("id",this.id));

            return this.select("floors",columns);
        }

        public DataTable getFloor()
        {
            return this.select("floors");
        }


        public DataTable searchFloor(string floor_name)
        {
            return this.executeQuerey("select * from floors where name like '%"+floor_name+"%'");
        }



        public int addFloor(string floor_name)
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + floor_name + "\'"));
            return this.insert("floors", Columns);
        }



        public int deleteFloor()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);
            return this.delete("floors", whereClause);
        }

        public int updateFloor()
        {

            Hashtable columns = new Hashtable();
            columns.Add("name", "\'" + this.name + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("floors", columns, whereClause);
        }




    }
}
