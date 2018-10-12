namespace Resturant
{
    partial class KitchenReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbn_kitchen = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AutoGenerateColumns = false;
            this.dgv_items.BackgroundColor = System.Drawing.Color.White;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.itemqtyDataGridViewTextBoxColumn,
            this.additionalnotesDataGridViewTextBoxColumn});
            this.dgv_items.DataSource = this.kitchenReceiptBindingSource;
            this.dgv_items.Location = new System.Drawing.Point(12, 12);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.Size = new System.Drawing.Size(776, 344);
            this.dgv_items.TabIndex = 0;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "Token#";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemidDataGridViewTextBoxColumn.Width = 69;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnameDataGridViewTextBoxColumn.Width = 54;
            // 
            // itemqtyDataGridViewTextBoxColumn
            // 
            this.itemqtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.itemqtyDataGridViewTextBoxColumn.Name = "itemqtyDataGridViewTextBoxColumn";
            this.itemqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemqtyDataGridViewTextBoxColumn.Width = 76;
            // 
            // additionalnotesDataGridViewTextBoxColumn
            // 
            this.additionalnotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.additionalnotesDataGridViewTextBoxColumn.DataPropertyName = "additional_notes";
            this.additionalnotesDataGridViewTextBoxColumn.HeaderText = "Additional Notes";
            this.additionalnotesDataGridViewTextBoxColumn.Name = "additionalnotesDataGridViewTextBoxColumn";
            this.additionalnotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitchenReceiptBindingSource
            // 
            this.kitchenReceiptBindingSource.DataSource = typeof(Resturant.Print.KitchenReceipt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Kitchen";
            // 
            // cbn_kitchen
            // 
            this.cbn_kitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbn_kitchen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_kitchen.FormattingEnabled = true;
            this.cbn_kitchen.Location = new System.Drawing.Point(125, 376);
            this.cbn_kitchen.Name = "cbn_kitchen";
            this.cbn_kitchen.Size = new System.Drawing.Size(167, 29);
            this.cbn_kitchen.TabIndex = 2;
            this.cbn_kitchen.SelectedIndexChanged += new System.EventHandler(this.cbn_kitchen_SelectedIndexChanged);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(713, 377);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 50);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KitchenReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.cbn_kitchen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_items);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KitchenReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenReceiptForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbn_kitchen;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource kitchenReceiptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalnotesDataGridViewTextBoxColumn;
    }
}