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
    public partial class FloorED : Form
    {
        private bool is_edit;
        private string floor_id;
        public FloorED()
        {
            InitializeComponent();
            is_edit = false;

            txt_floor.KeyPress += Txt_floor_KeyPress;

        }
        public FloorED(string floorId)
        {
            InitializeComponent();
            txt_floor.KeyPress += Txt_floor_KeyPress;
            is_edit = true;
            btn_add.Text = "UPDATE";
            btn_cancel.Text = "DELETE";
            Floor floor = new Floor(floorId);
            DataTable data = floor.getFloorById();
            if (data.Rows.Count == 1)
            {
                floor_id = data.Rows[0]["id"].ToString();
                txt_floor.Text = data.Rows[0]["name"].ToString();
                this.Text = data.Rows[0]["name"].ToString();
            }
        }

        private void Txt_floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string floor_name = Encrption.trim(txt_floor.Text.ToString());
                if (floor_name.Length > 0)
                {
                    if (floor_name.Length > 191)
                    {
                        MessageBox.Show("Floor name is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(floor_name, out int result))
                        {
                            MessageBox.Show("Floor name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (is_edit.Equals(true))
                            {
                                Floor floor = new Floor(floor_id, floor_name);
                                if (Convert.ToBoolean(floor.updateFloor()).Equals(true))
                                {
                                    MessageBox.Show("Floor has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                Floor floor = new Floor(floor_id, floor_name);
                                if (Convert.ToBoolean(floor.addFloor(floor_name)).Equals(true))
                                {
                                    MessageBox.Show("Floor has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter floor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string floor_name = Encrption.trim(txt_floor.Text.ToString());
            if(floor_name.Length > 0)
            {
                if(floor_name.Length > 191)
                {
                    MessageBox.Show("Floor name is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(floor_name, out int result))
                    {
                        MessageBox.Show("Floor name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (is_edit.Equals(true))
                        {
                            Floor floor = new Floor(floor_id, floor_name);
                            if (Convert.ToBoolean(floor.updateFloor()).Equals(true))
                            {
                                MessageBox.Show("Floor has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            Floor floor = new Floor(floor_id, floor_name);
                            if (Convert.ToBoolean(floor.addFloor(floor_name)).Equals(true))
                            {
                                MessageBox.Show("Floor has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter floor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (is_edit.Equals(true))
            {
                var comfirm = MessageBox.Show("Are you sure..","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(comfirm == DialogResult.Yes)
                {
                    Floor floor = new Floor(floor_id);
                    if( Convert.ToBoolean(floor.deleteFloor()).Equals(true) )
                    {
                        MessageBox.Show("Floor has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
