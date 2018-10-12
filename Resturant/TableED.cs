using Resturant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class TableED : Form
    {
        private bool is_edit;

        private string table_id;

        public TableED()
        {
            InitializeComponent();

            txt_tablename.KeyPress += Txt_tablename_KeyPress;
            txt_numOfSeat.KeyPress += Txt_numOfSeat_KeyPress;
            this.is_edit = false;
            try
            {
                Floor floor = new Floor();
                if(floor.getFloor().Rows.Count > 0)
                {
                    cb_floor.ValueMember = "id";
                    cb_floor.DisplayMember = "name";
                    cb_floor.DataSource = floor.getFloor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public TableED(string table_id)
        {
            InitializeComponent();
            txt_tablename.KeyPress += Txt_tablename_KeyPress;
            txt_numOfSeat.KeyPress += Txt_numOfSeat_KeyPress;
            this.is_edit = true;
            btn_addTable.Text = "UPDATE";
            btn_cancelTable.Text = "DELETE";

            try
            {
                TableZone tableZone = new TableZone();
                cb_floor.DataSource = tableZone.getTableZone();
                cb_floor.ValueMember = "f_id";
                cb_floor.DisplayMember = "f_name";


                cb_zone.DataSource = tableZone.getTableZone();
                cb_zone.ValueMember = "t_id";
                cb_zone.DisplayMember = "t_name";

                Tables tables = new Tables(table_id);
                DataTable data = tables.getTableById();
                this.table_id = data.Rows[0]["id"].ToString();
                this.Text = data.Rows[0]["name"].ToString();
                txt_tablename.Text = data.Rows[0]["name"].ToString();
                txt_numOfSeat.Text = data.Rows[0]["num_seats"].ToString();
                cb_floor.SelectedValue = data.Rows[0]["floor_id"].ToString();
                cb_zone.SelectedValue = data.Rows[0]["zone_id"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cb_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (int.TryParse(cb.SelectedValue.ToString(), out int number))
            {
                TableZone tableZone = new TableZone();
                cb_zone.DataSource = tableZone.getZoneByFloorId(number.ToString());
                cb_zone.ValueMember = "id";
                cb_zone.DisplayMember = "name";
            }
        }


        private void Txt_numOfSeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (validateInput())
                {
                    string floorId = cb_floor.SelectedValue.ToString();
                    string tableZoneId = cb_zone.SelectedValue.ToString();
                    string tableName = Encrption.trim(txt_tablename.Text.ToString());
                    string numOfSeat = Encrption.trim(txt_numOfSeat.Text.ToString());

                    if (this.is_edit.Equals(true))
                    {
                        Tables tables = new Tables(this.table_id, floorId, tableZoneId, tableName, numOfSeat);
                        if (Convert.ToBoolean(tables.updateTable()).Equals(true))
                        {
                            MessageBox.Show("Table has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        Tables tables = new Tables(floorId, tableZoneId, tableName, numOfSeat);
                        if (Convert.ToBoolean(tables.addTable()).Equals(true))
                        {
                            MessageBox.Show("Table has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Txt_tablename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (validateInput())
                {
                    string floorId = cb_floor.SelectedValue.ToString();
                    string tableZoneId = cb_zone.SelectedValue.ToString();
                    string tableName = Encrption.trim(txt_tablename.Text.ToString());
                    string numOfSeat = Encrption.trim(txt_numOfSeat.Text.ToString());

                    if (this.is_edit.Equals(true))
                    {
                        Tables tables = new Tables(this.table_id, floorId, tableZoneId, tableName, numOfSeat);
                        if (Convert.ToBoolean(tables.updateTable()).Equals(true))
                        {
                            MessageBox.Show("Table has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        Tables tables = new Tables(floorId, tableZoneId, tableName, numOfSeat);
                        if (Convert.ToBoolean(tables.addTable()).Equals(true))
                        {
                            MessageBox.Show("Table has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }


        private bool validateInput()
        {
            int isError = 0;
            StringBuilder builder = new StringBuilder();

            if (txt_tablename.Text.ToString().Length > 0)
            {
                if(txt_tablename.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Table name is too long").AppendLine();
                }
                else
                {
                    if (int.TryParse(txt_tablename.Text.ToString(), out int result))
                    {
                        isError++;
                        builder.Append("Table name must be alphabetic").AppendLine();
                    }
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter table name").AppendLine();
            }

            if (txt_numOfSeat.Text.ToString().Length > 0)
            {
                if (int.TryParse(txt_numOfSeat.Text.ToString(), out int result))
                {
                    if(result > 100)
                    {
                        isError++;
                        builder.Append("Number of seats cannot be greater than 100").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Number of seats must be numeric").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter number of seats").AppendLine();
            }

            if (isError > 0)
            {
                MessageBox.Show(builder.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_addTable_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                string floorId = cb_floor.SelectedValue.ToString();
                string tableZoneId = cb_zone.SelectedValue.ToString();
                string tableName = Encrption.trim(txt_tablename.Text.ToString());
                string numOfSeat = Encrption.trim(txt_numOfSeat.Text.ToString());

                if (this.is_edit.Equals(true))
                {
                    Tables tables = new Tables(this.table_id, floorId, tableZoneId, tableName, numOfSeat);
                    if (Convert.ToBoolean(tables.updateTable()).Equals(true))
                    {
                        MessageBox.Show("Table has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    Tables tables = new Tables(floorId, tableZoneId, tableName, numOfSeat);
                    if (Convert.ToBoolean(tables.addTable()).Equals(true))
                    {
                        MessageBox.Show("Table has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void btn_cancelTable_Click(object sender, EventArgs e)
        {
            if (this.is_edit.Equals(true))
            {
                var confirm = MessageBox.Show("Are you sure..","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    Tables tables = new Tables(this.table_id);
                    if (Convert.ToBoolean(tables.deleteTable()).Equals(true))
                    {
                        MessageBox.Show("Table has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }


    }
}
