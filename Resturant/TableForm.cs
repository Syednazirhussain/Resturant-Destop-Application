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
    public partial class TableForm : Form
    {
        private Floor floor;
        private TableZone tableZone;
        private Tables tables;
        public TableForm()
        {
            InitializeComponent();

            txtz_search.KeyPress += ZoneSearchEnterEventOccure;
            txtt_search.KeyPress += TableSearchEnterEventOccure;

            floor = new Floor();
            tableZone = new TableZone();
            tables = new Tables();

        }

        #region General
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txt_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            user_type.Text = "User Type : " + Login.user_role.ToUpper();
        }
        #endregion

        #region Floor
        private void refreshFloor(DataTable data)
        {
            dgv_floor.Rows.Clear();

            int sno = 0;
            foreach (DataRow row in data.Rows)
            {
                int index = dgv_floor.Rows.Add();

                dgv_floor.Rows[index].Cells["fsno"].Value = String.Format("  {0} ", ++sno);
                dgv_floor.Rows[index].Cells["id"].Value = row["id"].ToString();
                dgv_floor.Rows[index].Cells["name"].Value = row["name"].ToString();
            }
        }
        private void tabFloor_Enter(object sender, EventArgs e)
        {
            refreshFloor(floor.getFloor());
        }

        private void txtf_search_TextChanged(object sender, EventArgs e)
        {
            if (txtf_search.Text.ToString().Length > 0)
            {
                refreshFloor(floor.searchFloor(Encrption.trim(txtf_search.Text.ToString())));
            }
            else
            {
                refreshFloor(floor.getFloor());
            }
        }

        private void btn_addFloor_Click(object sender, EventArgs e)
        {
            using (FloorED floorED = new FloorED())
            {
                if (floorED.ShowDialog() != DialogResult.OK)
                {
                    refreshFloor(floor.getFloor());
                }
            }
        }
        private void dgv_floor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRow = dgv_floor.Rows[index];
                string floorId = selectedRow.Cells["id"].Value.ToString();
                using (FloorED floorED = new FloorED(floorId))
                {
                    if (floorED.ShowDialog() != DialogResult.OK)
                    {
                        refreshFloor(floor.getFloor());
                    }
                }
            }

        }
        #endregion

        #region Zone
        private void refreshZone(DataTable data)
        {
            dgv_zone.Rows.Clear();
            int sno = 0;
            foreach (DataRow row in data.Rows)
            {
                int index = dgv_zone.Rows.Add();
                dgv_zone.Rows[index].Cells["zsno"].Value = String.Format(" {0} ",++sno);
                dgv_zone.Rows[index].Cells["floor_id"].Value = row["f_id"].ToString();
                dgv_zone.Rows[index].Cells["floor_name"].Value = row["f_name"].ToString();
                dgv_zone.Rows[index].Cells["tablezone_id"].Value = row["t_id"].ToString();
                dgv_zone.Rows[index].Cells["tablezone_name"].Value = row["t_name"].ToString();
            }
        }
        private void tabZone_Enter(object sender, EventArgs e)
        {
            cbz_search.Items.Clear();
            cbz_search.Items.Add("Floor");
            cbz_search.Items.Add("Zone");
            cbz_search.SelectedIndex = 0;

            btn_clear.Hide();
            txtz_search.Clear();
            txtz_search.Focus();
            refreshZone(tableZone.getTableZone());
        }
        private void ZoneSearchEnterEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                if (txtz_search.Text.ToString().Length > 0)
                {
                    btn_clear.Show();
                    refreshZone(tableZone.searchZone(Encrption.trim(txtz_search.Text.ToString()), cbz_search.SelectedItem.ToString()));
                }
                else
                {
                    MessageBox.Show(String.Format("Please enter keyword to search by {0}", cbz_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_clear.Hide();
                    txtz_search.Clear();
                    txtz_search.Focus();
                    refreshZone(tableZone.getTableZone());
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_clear.Hide();
            txtz_search.Clear();
            txtz_search.Focus();
            refreshZone(tableZone.getTableZone());
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txtz_search.Text.ToString().Length > 0)
            {
                btn_clear.Show();
                refreshZone(tableZone.searchZone( Encrption.trim(txtz_search.Text.ToString()), cbz_search.SelectedItem.ToString() ));
            }
            else
            {
                MessageBox.Show(String.Format("Please enter keyword to search by {0}",cbz_search.SelectedItem.ToString()),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btn_clear.Hide();
                txtz_search.Clear();
                txtz_search.Focus();
                refreshZone(tableZone.getTableZone());
            }
        }
        private void btn_addZone_Click(object sender, EventArgs e)
        {
            try
            {
                using (ZoneED zoneED = new ZoneED())
                {
                    if (zoneED.ShowDialog() != DialogResult.Cancel)
                    {
                        btn_clear.Hide();
                        txtz_search.Clear();
                        txtz_search.Focus();
                        refreshZone(tableZone.getTableZone());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void dgv_zone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRow = dgv_zone.Rows[index];
                string tableZoneId = selectedRow.Cells["tablezone_id"].Value.ToString();
                using (ZoneED zoneED = new ZoneED(tableZoneId))
                {
                    if (zoneED.ShowDialog() != DialogResult.Cancel)
                    {
                        btn_clear.Hide();
                        txtz_search.Clear();
                        txtz_search.Focus();
                        refreshZone(tableZone.getTableZone());
                    }
                }
            }
        }

        #endregion

        #region Table
        private void tab_table_Enter(object sender, EventArgs e)
        {
            cbt_search.Items.Clear();
            cbt_search.Items.Add("Table");
            cbt_search.Items.Add("Seat");
            cbt_search.Items.Add("Zone");
            cbt_search.Items.Add("Floor");
            cbt_search.SelectedIndex = 0;

            btnt_clear.Hide();
            txtt_search.Clear();
            txtt_search.Focus();
            refreshTable(tables.getTables());
        }
        private void refreshTable(DataTable data)
        {
            dgvt_table.Rows.Clear();
            int sno = 0;
            foreach (DataRow row in data.Rows)
            {
                int index = dgvt_table.Rows.Add();
                dgvt_table.Rows[index].Cells["tsno"].Value = String.Format(" {0} ",++sno);
                dgvt_table.Rows[index].Cells["table_id"].Value = row["id"].ToString();
                dgvt_table.Rows[index].Cells["tfloor_id"].Value = row["f_id"].ToString();
                dgvt_table.Rows[index].Cells["tfloor_name"].Value = row["floorname"].ToString();
                dgvt_table.Rows[index].Cells["ttable_zone"].Value = row["tablezone"].ToString();
                dgvt_table.Rows[index].Cells["zone_id"].Value = row["tz_id"].ToString();
                dgvt_table.Rows[index].Cells["table_name"].Value = row["name"].ToString();
                dgvt_table.Rows[index].Cells["num_seats"].Value = row["num_seats"].ToString();
            }
        }

        private void btnt_clear_Click(object sender, EventArgs e)
        {
            btnt_clear.Hide();
            txtt_search.Clear();
            txtt_search.Focus();
            refreshTable(tables.getTables());
        }

        private void TableSearchEnterEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                if (txtt_search.Text.ToString().Length > 0)
                {
                    DataTable data = tables.searchTable(Encrption.trim(txtt_search.Text.ToString()), cbt_search.SelectedItem.ToString());
                    if (data.Rows.Count > 0)
                    {
                        btnt_clear.Show();
                        refreshTable(data);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("No record(s) found", cbt_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnt_clear.Hide();
                        txtt_search.Clear();
                        txtt_search.Focus();
                        refreshTable(tables.getTables());
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Please enter keyword to search by {0}", cbt_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnt_clear.Hide();
                    txtt_search.Clear();
                    txtt_search.Focus();
                    refreshTable(tables.getTables());
                }
            }
        }
        private void btnt_search_Click(object sender, EventArgs e)
        {
            if(txtt_search.Text.ToString().Length > 0)
            {
                DataTable data = tables.searchTable(Encrption.trim(txtt_search.Text.ToString()), cbt_search.SelectedItem.ToString());
                if(data.Rows.Count > 0)
                {
                    btnt_clear.Show();
                    refreshTable(data);
                }
                else
                {
                    MessageBox.Show(String.Format("No record(s) found", cbt_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnt_clear.Hide();
                    txtt_search.Clear();
                    txtt_search.Focus();
                    refreshTable(tables.getTables());
                }
            }
            else
            {
                MessageBox.Show(String.Format("Please enter keyword to search by {0}",cbt_search.SelectedItem.ToString()),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnt_clear.Hide();
                txtt_search.Clear();
                txtt_search.Focus();
                refreshTable(tables.getTables());
            }
        }

        private void btn_addTable_Click(object sender, EventArgs e)
        {
            using (TableED tableED = new TableED())
            {
                if (tableED.ShowDialog() != DialogResult.Cancel)
                {
                    btnt_clear.Hide();
                    txtt_search.Clear();
                    txtt_search.Focus();
                    refreshTable(tables.getTables());
                }
            }
        }
        private void dgvt_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRow = dgvt_table.Rows[index];
                string table_id = selectedRow.Cells["table_id"].Value.ToString();

                using (TableED tableED = new TableED(table_id))
                {
                    if (tableED.ShowDialog() != DialogResult.Cancel)
                    {
                        btnt_clear.Hide();
                        txtt_search.Clear();
                        txtt_search.Focus();
                        refreshTable(tables.getTables());
                    }
                }
            }
        }

        #endregion

    }
}
