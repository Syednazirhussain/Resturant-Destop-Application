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
        public KitchenForm()
        {
            InitializeComponent();
        }

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

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();
        }

        private void tab_kitchen_Enter(object sender, EventArgs e)
        {
            this.loadKitchen();
        }

        private void loadKitchen()
        {
            kitchen = new Kitchen();

            List<Tuple<string, string, string>> kitchenList = kitchen.getKitchens();

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
                if (item.ShowDialog() != DialogResult.OK)
                {
                    this.loadKitchen();
                }
            }
        }


    }
}
