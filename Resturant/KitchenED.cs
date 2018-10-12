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
    public partial class KitchenED : Form
    {
        private Kitchen kitchen;
        private Category category;

        private string kitchenId;

        private List<string> categoriesList;
        private List<string> removeCategoriesList;

        private int numberOfExistingCategories;

        private bool isEditKitchen;

        private bool isFrozen;
        public KitchenED()
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            this.Text = "ADD KITCHEN";
            this.isFrozen = false;
            this.categoriesList = new List<string>();
            this.isEditKitchen = false;


            kitchen = new Kitchen();
            category = new Category();
            DataTable categories = category.getCategory();
            flowLayoutPanel.Controls.Clear();

            #region commments
            /* if you want to display assigned categories
            foreach (DataRow row in categories.Rows)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = row["id"].ToString();
                checkBox.Text = row["name"].ToString();
                checkBox.AutoSize = true;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                flowLayoutPanel.Controls.Add(checkBox);
            }
            */
            #endregion

            DataTable kitchenItems = kitchen.getKitchenItems();
            List<string> kitchenItemCategoryList = new List<string>();
            foreach (DataRow row in kitchenItems.Rows)
            {
                kitchenItemCategoryList.Add(row["category_id"].ToString());
            }
            foreach (DataRow row in categories.Rows)
            {
                if (kitchenItemCategoryList.Contains(row["id"].ToString()))
                {
                    continue;
                }
                else
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = row["id"].ToString();
                    checkBox.Text = row["name"].ToString();
                    checkBox.AutoSize = true;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;

                    flowLayoutPanel.Controls.Add(checkBox);
                }
            }

        }
        public KitchenED(string kitchen_id)
        {
            InitializeComponent();

            txt_name.KeyPress += EnterKeyPressEventOccure;
            this.kitchenId = kitchen_id;
            this.categoriesList = new List<string>();
            this.removeCategoriesList = new List<string>();

            this.isEditKitchen = true;
            btn_add.Text = "Update";
            btn_cancel.Text = "Delete";

            kitchen = new Kitchen(kitchen_id);
            category = new Category();

            DataTable categories = category.getCategory();
            DataTable dataKitchen = kitchen.getKitchenById();
            DataTable kitchenItems = kitchen.getKitchenItems();

            List<string> kitchenItemCategoryList = new List<string>();
            List<string> selectedCat = new List<string>();

            this.Text = dataKitchen.Rows[0]["name"].ToString();
            txt_name.Text = dataKitchen.Rows[0]["name"].ToString();

            foreach (DataRow row in dataKitchen.Rows)
            {
                selectedCat.Add(row["category_id"].ToString() );
            }

            this.numberOfExistingCategories = selectedCat.Count;

            foreach (DataRow row in kitchenItems.Rows)
            {
                kitchenItemCategoryList.Add(row["category_id"].ToString());
            }

            flowLayoutPanel.Controls.Clear();

            foreach(DataRow row in categories.Rows)
            {
                CheckBox checkBox = new CheckBox();
                if (selectedCat.Contains(row["id"].ToString()))
                {
                    checkBox.Name = row["id"].ToString();
                    checkBox.Text = row["name"].ToString();
                    checkBox.AutoSize = true;
                    checkBox.Checked = true;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }
                else if(kitchenItemCategoryList.Contains(row["id"].ToString()))
                {
                    continue;
                }
                else
                {
                    checkBox.Name = row["id"].ToString();
                    checkBox.Text = row["name"].ToString();
                    checkBox.AutoSize = true;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                }

                flowLayoutPanel.Controls.Add(checkBox);
            }
        }
        private void EnterKeyPressEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (this.validateInput())
                {
                    if (this.isEditKitchen == true)
                    {
                        bool flag = true;
                        string message = "";
                        try
                        {
                            if (this.removeCategoriesList.Count > 0 && this.categoriesList.Count > 0)
                            {
                                // delete previous add categories
                                kitchen = new Kitchen();
                                kitchen.deleteExistingKitchenCategories(this.removeCategoriesList);

                                // update kitchen name and add some more categories
                                kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                                kitchen.updateKitchenWithKitchenItems(this.categoriesList);

                                message = "Kitchen updated successfully";
                            }
                            else if (this.removeCategoriesList.Count > 0 && this.removeCategoriesList.Count < this.numberOfExistingCategories && this.categoriesList.Count == 0)
                            {
                                kitchen = new Kitchen();
                                kitchen.deleteExistingKitchenCategories(this.removeCategoriesList);
                                message = "Kitchen updated successfully";
                            }
                            else if (this.removeCategoriesList.Count == 0 && this.categoriesList.Count > 0)
                            {
                                // update kitchen name and add some more categories
                                kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                                kitchen.updateKitchenWithKitchenItems(this.categoriesList);
                                message = "Kitchen updated successfully";
                            }
                            else if (this.removeCategoriesList.Count == 0 && this.categoriesList.Count == 0)
                            {
                                // update kitchen name only
                                kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                                kitchen.updateKitchen();
                                message = "Kitchen updated successfully";
                            }
                            else
                            {
                                var confirmResult = MessageBox.Show("Please select atleast one category",
                    "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (confirmResult == DialogResult.OK)
                                {
                                    message = "Nothing to update";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            flag = false;
                            MessageBox.Show(ex.Message);
                            this.Close();
                        }
                        finally
                        {
                            if (flag)
                            {
                                MessageBox.Show(message);
                                this.Close();
                            }
                        }
                        //MessageBox.Show(String.Format("New {0} {1}\n Remove Existing {2} {3} ", this.categoriesList.Count, String.Join(",", this.categoriesList), this.removeCategoriesList.Count, String.Join(",", this.removeCategoriesList)));
                    }
                    else
                    {
                        if (this.categoriesList.Count > 0)
                        {
                            kitchen = new Kitchen();
                            int result = kitchen.addKitchen(txt_name.Text.ToString());
                            if (result > 0)
                            {
                                string kitchen_id = kitchen.getLastInsertedId();
                                if (kitchen_id != null)
                                {
                                    int count = kitchen.assignCategorytoKitchen(kitchen_id, this.categoriesList);
                                    if (count > 0)
                                    {
                                        MessageBox.Show(String.Format("{0} Record has been inserted", count));
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("System error categories cannot hold");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Kitchen not added in database");
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is some problem while adding kitchen");
                            }
                        }
                        else
                        {
                            var confirmResult = MessageBox.Show("Please select atleast on category", "Kitchen Cannot Added", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            if (confirmResult == DialogResult.OK)
                            {
                                txt_name.Clear();
                            }
                        }
                    }
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.isFrozen)
            {
                return;
            }
            CheckBox cb = (CheckBox)sender;
            kitchen = new Kitchen();

            DataTable data = kitchen.categoryExist(cb.Name);

            this.isFrozen = true;
            if (data.Rows.Count > 0)
            {
                if (cb.Checked.Equals(false))
                {
                    this.removeCategoriesList.Add(cb.Name);
                }
                else
                {

                    this.removeCategoriesList.Remove(cb.Name);
                    
                }

                #region CategoryExist
                /*
                var confirmResult = MessageBox.Show(String.Format("Category {0} already assigned to another kitchen", cb.Text),
    "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (confirmResult == DialogResult.OK)
                {
                    this.isFrozen = true;
                    cb.Enabled = false;
                    cb.Checked = false;
                    this.isFrozen = false;
                }
                */
                #endregion
            }
            else
            {
                if(cb.Checked.Equals(true))
                {
                    this.categoriesList.Add(cb.Name);
                }
                else
                {
                    this.categoriesList.Remove(cb.Name);
                    cb.Checked = false;
                }
            }
            this.isFrozen = false;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(this.validateInput())
            {
                if(this.isEditKitchen == true)
                {
                    bool flag = true;
                    string message = "";
                    try
                    {
                        if (this.removeCategoriesList.Count > 0 && this.categoriesList.Count > 0)
                        {
                            // delete previous add categories
                            kitchen = new Kitchen();
                            kitchen.deleteExistingKitchenCategories(this.removeCategoriesList);

                            // update kitchen name and add some more categories
                            kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                            kitchen.updateKitchenWithKitchenItems(this.categoriesList);

                            message = "Kitchen updated successfully";
                        }
                        else if(this.removeCategoriesList.Count > 0 && this.removeCategoriesList.Count < this.numberOfExistingCategories && this.categoriesList.Count == 0)
                        {
                            kitchen = new Kitchen();
                            kitchen.deleteExistingKitchenCategories(this.removeCategoriesList);
                            message = "Kitchen updated successfully";
                        }
                        else if(this.removeCategoriesList.Count == 0 && this.categoriesList.Count > 0)
                        {
                            // update kitchen name and add some more categories
                            kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                            kitchen.updateKitchenWithKitchenItems(this.categoriesList);
                            message = "Kitchen updated successfully";
                        }
                        else if(this.removeCategoriesList.Count == 0 && this.categoriesList.Count == 0)
                        {
                            // update kitchen name only
                            kitchen = new Kitchen(this.kitchenId, txt_name.Text.ToString());
                            kitchen.updateKitchen();
                            message = "Kitchen updated successfully";
                        }
                        else
                        {
                            var confirmResult = MessageBox.Show("Please select atleast one category",
                "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (confirmResult == DialogResult.OK)
                            {
                                message = "Nothing to update";
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        flag = false;
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                    finally
                    {
                        if(flag)
                        {
                            MessageBox.Show(message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    //MessageBox.Show(String.Format("New {0} {1}\n Remove Existing {2} {3} ", this.categoriesList.Count, String.Join(",", this.categoriesList), this.removeCategoriesList.Count, String.Join(",", this.removeCategoriesList)));
                }
                else
                {
                    if (this.categoriesList.Count > 0)
                    {
                        kitchen = new Kitchen();
                        int result = kitchen.addKitchen(txt_name.Text.ToString());
                        if (result > 0)
                        {
                            string kitchen_id = kitchen.getLastInsertedId();
                            if (kitchen_id != null)
                            {
                                int count = kitchen.assignCategorytoKitchen(kitchen_id, this.categoriesList);
                                if (count > 0)
                                {
                                    MessageBox.Show("Kitchen has inserted successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                               
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("System error categories cannot hold","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kitchen not added in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is some problem while adding kitchen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var confirmResult = MessageBox.Show("Please select atleast on category", "Kitchen Cannot Added", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        if (confirmResult == DialogResult.OK)
                        {
                            txt_name.Clear();
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(this.isEditKitchen == true)
            {
                var confirm = MessageBox.Show("Are you sure to delete kitchen?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    kitchen = new Kitchen(this.kitchenId);
                    int result = kitchen.deleteKitchen();
                    if (result > 0)
                    {
                        MessageBox.Show("Kitchen deleted successfully");
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }


        private bool isNumeric(string value)
        {
            int n;
            return int.TryParse(value, out n);
        }
        public bool validateInput()
        {
            bool valid = true;
            int errorCount = 0;

            if (txt_name.Text.ToString().Length > 0)
            {
                if (this.isNumeric(txt_name.Text.ToString()))
                {
                    MessageBox.Show("Kitchen name must be alphabetical character","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    errorCount++;
                }
                else
                {
                    if (txt_name.Text.ToString().Length > 191)
                    {
                        MessageBox.Show("Kichen name is too long","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        errorCount++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter kitchen name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorCount++;
            }

            if (errorCount.Equals(0))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }


            return valid;
        }


    }
}
