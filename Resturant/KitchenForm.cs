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
    public partial class KitchenForm : Form
    {
        private Kitchen kitchen;

        #region General
        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        #endregion
        public KitchenForm()
        {
            InitializeComponent();
            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();

            txt_search.KeyPress += EnterKeyPressEventOccure;

            btn_clear.Hide();
            this.loadKitchen();
        }

        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Return))
            {
                if (txt_search.Text.ToString().Length > 0)
                {
                    btn_clear.Show();
                    this.loadKitchen(txt_search.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Please enter keyword to search", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadKitchen(string search = null)
        {
            kitchen = new Kitchen();
            List<Tuple<string, string, string>> kitchenList = new List<Tuple<string, string, string>>();
            if (search != null && Encrption.trim(search).Length > 0)
            {

                kitchenList  = kitchen.getKitchens(kitchen.searchKitchen(search));
            }
            else
            {
                kitchenList = kitchen.getKitchens();
            }
            dgv_kitchen.Rows.Clear();
            int sno = 0;
            foreach (var tuple in kitchenList)
            {
                dgv_kitchen.Rows.Add(new object[] { ++sno , tuple.Item1, tuple.Item2, tuple.Item3 });
            }
        }

        private void dgv_kitchen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex > -1)
                {
                    string kitchen_id = dgv_kitchen.CurrentRow.Cells["id"].Value.ToString();

                    using (KitchenED item = new KitchenED(kitchen_id))
                    {
                        if (item.ShowDialog() != DialogResult.Cancel)
                        {
                            txt_search.Clear();
                            btn_clear.Hide();
                            this.loadKitchen();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btn_addKitchen_Click(object sender, EventArgs e)
        {
            using (KitchenED item = new KitchenED())
            {
                if (item.ShowDialog() != DialogResult.Cancel)
                {
                    txt_search.Clear();
                    btn_clear.Hide();
                    this.loadKitchen();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            btn_clear.Hide();
            this.loadKitchen();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.ToString().Length > 0)
            {
                btn_clear.Show();
                this.loadKitchen(txt_search.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please enter keyword to search","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}
