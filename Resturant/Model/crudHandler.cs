using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Model
{
    class crudHandler : DBConnection
    {
        private MySqlConnection con;

        public crudHandler()
        {

            this.con = DBConnection.Connect();
        }

        protected int delete(string tablename, Hashtable whereClause)
        {
            int rowsAffected = 0;
            string querey = "delete from " + tablename + " where ";
            if (whereClause.Count != 0)
            {
                int index = 0;
                foreach (string key in whereClause.Keys)
                {
                    if (whereClause.Count - index == 1)
                    {
                        querey += key + " = " + whereClause[key] + " ";
                    }
                    else
                    {
                        querey += key + " = " + whereClause[key] + " and ";
                    }
                    index++;
                }
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = querey;
                try
                {
                    this.con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.con.Close();
                }
            }
            else
            {
                MessageBox.Show("function parameter missing");
            }
            return rowsAffected;
        }

        protected int insertUpdateDeleteByQuery(string query)
        {
            int rowsAffected = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.con;
            cmd.CommandText = query;
            this.con.Open();
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.con.Close();
            }
            return rowsAffected;
        }

        protected int update(string tablename, Hashtable column, Hashtable whereCondition)
        {
            int rowsAffected = 0;
            int size, index;
            string querey = "update " + tablename + " set ";
            size = column.Count;
            index = 0;

            if (column.Count >= 1 && whereCondition.Count >= 1)
            {

                foreach (string key in column.Keys)
                {
                    if (size - index == 1)
                    {
                        querey += key + " = " + column[key] + " ";
                    }
                    else
                    {
                        querey += key + " = " + column[key] + " , ";
                    }
                    index++;
                }
                size = whereCondition.Count;
                index = 0;
                querey += " where ";
                foreach (string key in whereCondition.Keys)
                {
                    if (size - index == 1)
                    {
                        querey += key + " = " + whereCondition[key] + " ";
                    }
                    else
                    {
                        querey += key + " = " + whereCondition[key] + " and ";
                    }
                }

                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    this.con.Open();
                    cmd.Connection = this.con;
                    cmd.CommandText = querey;
                    rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.con.Close();
                }
            }
            else
            {
                MessageBox.Show("paramter hashtable missing");
            }

            return rowsAffected;
        }

        // simple insert 
        protected int insert(string tablename, List<Tuple<string, string>> Columns)
        {
            int rowsAfftected = 0;
            string querey = "insert into " + tablename + " (";
            if (Columns.Count > 0)
            {
                for (int i = 0; i < Columns.Count; i++)
                {
                    if (Columns.Count - i == 1)
                    {
                        querey += Columns[i].Item1 + " ";
                    }
                    else
                    {
                        querey += Columns[i].Item1 + ", ";
                    }
                }
                querey += ") values ( ";
                for (int i = 0; i < Columns.Count; i++)
                {
                    if (Columns.Count - i == 1)
                    {
                        querey += Columns[i].Item2 + " ";
                    }
                    else
                    {
                        querey += Columns[i].Item2 + ", ";
                    }
                }
                querey += ")";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = querey;
                try
                {
                    this.con.Open();
                    rowsAfftected = cmd.ExecuteNonQuery();
                    return rowsAfftected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.con.Close();
                }
            }
            else
            {
                MessageBox.Show("missing function parameters");
            }
            return rowsAfftected;
        }


        // bulk insert
        protected int insert(string tablename, string[] Columns, Dictionary<int, List<string>> ColumnsValues)
        {
            int rowsAfftected = 0;
            string querey = "insert into " + tablename + "(";
            if (Columns.Length > 0 && ColumnsValues.Count > 0)
            {
                for (int i = 0; i < Columns.Length; i++)
                {
                    if (Columns.Length - i == 1)
                    {
                        querey += Columns[i] + " ";
                    }
                    else
                    {
                        querey += Columns[i] + ", ";
                    }
                }
                querey += ") ";
                int inner, outer;
                outer = 0;
                foreach (int index in ColumnsValues.Keys)
                {
                    if (ColumnsValues.Keys.Count - outer == 1)
                    {
                        querey += "select ";
                        inner = 0;
                        foreach (string item in ColumnsValues[index])
                        {
                            if (ColumnsValues[index].Count - inner == 1)
                            {
                                querey += item + " ";
                            }
                            else
                            {
                                querey += item + ", ";
                            }
                            inner++;
                        }
                    }
                    else
                    {
                        querey += "select ";
                        inner = 0;
                        foreach (string item in ColumnsValues[index])
                        {
                            if (ColumnsValues[index].Count - inner == 1)
                            {
                                querey += item + " ";
                            }
                            else
                            {
                                querey += item + ", ";
                            }
                            inner++;
                        }
                        querey += "union all ";
                    }
                    outer++;
                }

                this.con.Open();
                MySqlTransaction myTrans = this.con.BeginTransaction();
                MySqlCommand myCommand = this.con.CreateCommand();
                myCommand.Transaction = myTrans;

                try
                {
                    myCommand.CommandText = querey;
                    rowsAfftected = myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                }
                catch (Exception e)
                {
                    try
                    {
                        myTrans.Rollback();
                    }
                    catch (MySqlException ex)
                    {
                        if (myTrans.Connection != null)
                        {
                            MessageBox.Show(String.Format("An exception of type {0} was encountered while attempting to roll back the transaction.", ex.GetType()));
                        }
                    }

                    MessageBox.Show(String.Format("An exception of type {0} was encountered while inserting the data.", e.GetType()));
                    MessageBox.Show("Neither record was written to database.");
                }
                finally
                {
                    this.con.Close();
                }
            }
            else
            {
                MessageBox.Show("missing function parameters");
            }
            return rowsAfftected;
        }

        protected DataTable select(string tablename, List<Tuple<string, string>> whereClause = null, string[] selectParams = null)
        {
            string querey = "select ";

            if (tablename != null)
            {

                if (whereClause != null && selectParams != null)
                {
                    for (int i = 0; i < selectParams.Length; i++)
                    {
                        if (selectParams.Length - i == 1)
                        {
                            querey += selectParams[i] + " ";
                        }
                        else
                        {
                            querey += selectParams[i] + ", ";
                        }
                    }
                    querey += "from " + tablename + " where ";
                    for (int i = 0; i < whereClause.Count; i++)
                    {
                        if (whereClause.Count - i == 1)
                        {
                            querey += whereClause[i].Item1 + " = " + whereClause[i].Item2 + " ";
                        }
                        else
                        {
                            querey += whereClause[i].Item1 + " = " + whereClause[i].Item2 + " and ";
                        }
                    }
                }
                else if (selectParams != null && whereClause == null)
                {

                    for (int i = 0; i < selectParams.Length; i++)
                    {
                        if (selectParams.Length - i == 1)
                        {
                            querey += selectParams[i] + " ";
                        }
                        else
                        {
                            querey += selectParams[i] + ", ";
                        }
                    }
                    querey += " from " + tablename;

                }
                else if (selectParams == null && whereClause != null)
                {
                    querey += "* from " + tablename + " where ";
                    for (int i = 0; i < whereClause.Count; i++)
                    {
                        if (whereClause.Count - i == 1)
                        {
                            querey += whereClause[i].Item1 + " = " + whereClause[i].Item2 + " ";
                        }
                        else
                        {
                            querey += whereClause[i].Item1 + " = " + whereClause[i].Item2 + " and ";
                        }
                    }
                }
                else
                {
                    querey += " * from " + tablename;
                }

                MySqlCommand cmd = new MySqlCommand();
                DataTable t1 = new DataTable();
                cmd.Connection = this.con;
                cmd.CommandText = querey;


                try
                {
                    this.con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        t1.Load(dr);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.con.Close();
                }

                return t1;
            }
            else
            {
                return null;
            }
        }

        protected DataTable executeQuerey(string querey)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataTable t1 = new DataTable();
            cmd.Connection = this.con;
            cmd.CommandText = querey;
            try
            {
                this.con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    t1.Load(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.con.Close();
            }
            return t1;
        }

        protected DataSet getDataSet(string query)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.con;
            cmd.CommandText = query;
            try
            {
                this.con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.con.Close();
            }
            return ds;
        }
    }
}
