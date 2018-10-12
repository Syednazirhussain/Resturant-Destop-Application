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
    public partial class ZoneED : Form
    {

        private bool is_edit;
        private string tablezone_id;
        public ZoneED()
        {
            InitializeComponent();
            txt_zonename.KeyPress += Txt_zonename_KeyPress;
            is_edit = false;
            this.Text = "Add Table Zone";
            try
            {
                Floor floor = new Floor();
                cb_floor.DataSource = floor.getFloor();
                cb_floor.ValueMember = "id";
                cb_floor.DisplayMember = "name";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public ZoneED(string tableZoneId)
        {
            InitializeComponent();

            is_edit = true;
            btn_addZone.Text = "UPDATE";
            btn_cancelZone.Text = "DELETE";

            try
            {
                Floor floor = new Floor();
                cb_floor.DataSource = floor.getFloor();
                cb_floor.ValueMember = "id";
                cb_floor.DisplayMember = "name";

                TableZone tableZone = new TableZone(tableZoneId);
                DataTable data = tableZone.getTableZoneById();
                this.Text = data.Rows[0]["name"].ToString();
                txt_zonename.Text = data.Rows[0]["name"].ToString();
                cb_floor.SelectedValue = data.Rows[0]["floor_id"].ToString();
                tablezone_id = data.Rows[0]["id"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Txt_zonename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string floor_id = cb_floor.SelectedValue.ToString();
                string zone_name = Encrption.trim(txt_zonename.Text.ToString());

                if (zone_name.Length > 0)
                {
                    if (zone_name.Length > 191)
                    {
                        MessageBox.Show("Zone name is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(zone_name, out int result))
                        {
                            MessageBox.Show("Zone name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (is_edit.Equals(true))
                            {
                                TableZone tableZone = new TableZone(tablezone_id, floor_id, zone_name);
                                if (Convert.ToBoolean(tableZone.updateTableZone()).Equals(true))
                                {
                                    MessageBox.Show("Table zone updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                TableZone tableZone = new TableZone(floor_id, zone_name);
                                if (Convert.ToBoolean(tableZone.addTableZone()).Equals(true))
                                {
                                    MessageBox.Show("Table zone created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter zone name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_addZone_Click(object sender, EventArgs e)
        {
            string floor_id = cb_floor.SelectedValue.ToString();
            string zone_name = Encrption.trim( txt_zonename.Text.ToString() );
            if(zone_name.Length > 0)
            {
                if(zone_name.Length > 191)
                {
                    MessageBox.Show("Zone name is too long","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(zone_name, out int result))
                    {
                        MessageBox.Show("Zone name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (is_edit.Equals(true))
                        {
                            TableZone tableZone = new TableZone(tablezone_id, floor_id, zone_name);
                            if (Convert.ToBoolean(tableZone.updateTableZone()).Equals(true))
                            {
                                MessageBox.Show("Table zone updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            TableZone tableZone = new TableZone(floor_id, zone_name);
                            if (Convert.ToBoolean(tableZone.addTableZone()).Equals(true))
                            {
                                MessageBox.Show("Table zone created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter zone name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_cancelZone_Click(object sender, EventArgs e)
        {
            if (is_edit.Equals(true))
            {
                var confirm = MessageBox.Show("Are you sure..","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    TableZone tableZone = new TableZone(tablezone_id);
                    if( Convert.ToBoolean( tableZone.deleteTableZone() ).Equals(true) )
                    {
                        MessageBox.Show("Table zone has been deleted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
