namespace Resturant
{
    partial class OrderED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderED));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.cb_server = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.tableLayoutPanelOrders = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchen_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelItems = new System.Windows.Forms.TableLayoutPanel();
            this.FLP_items = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_searchItem = new System.Windows.Forms.Panel();
            this.txt_itemSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCartTotal = new System.Windows.Forms.Panel();
            this.lbl_dtable = new System.Windows.Forms.Label();
            this.lbl_table = new System.Windows.Forms.Label();
            this.lbl_dzone = new System.Windows.Forms.Label();
            this.lbl_zone = new System.Windows.Forms.Label();
            this.lbl_dfloor = new System.Windows.Forms.Label();
            this.lbl_floor = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCatButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.btn_bookOrder = new System.Windows.Forms.Button();
            this.btn_kitchenReceipt = new System.Windows.Forms.Button();
            this.btn_finalReceipt = new System.Windows.Forms.Button();
            this.btn_prepayment = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_orderType = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.tableLayoutPanelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.tableLayoutPanelItems.SuspendLayout();
            this.panel_searchItem.SuspendLayout();
            this.panelCartTotal.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelOrder, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelTopLeft, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(884, 461);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.cb_server);
            this.panelTopRight.Controls.Add(this.label6);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(445, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(436, 45);
            this.panelTopRight.TabIndex = 2;
            // 
            // cb_server
            // 
            this.cb_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_server.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_server.FormattingEnabled = true;
            this.cb_server.Location = new System.Drawing.Point(267, 6);
            this.cb_server.Name = "cb_server";
            this.cb_server.Size = new System.Drawing.Size(155, 29);
            this.cb_server.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Server";
            // 
            // panelOrder
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.panelOrder, 2);
            this.panelOrder.Controls.Add(this.tableLayoutPanelOrders);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(3, 54);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(878, 404);
            this.panelOrder.TabIndex = 0;
            // 
            // tableLayoutPanelOrders
            // 
            this.tableLayoutPanelOrders.ColumnCount = 3;
            this.tableLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelOrders.Controls.Add(this.dgv_cart, 0, 0);
            this.tableLayoutPanelOrders.Controls.Add(this.tableLayoutPanelItems, 2, 0);
            this.tableLayoutPanelOrders.Controls.Add(this.panelCartTotal, 0, 1);
            this.tableLayoutPanelOrders.Controls.Add(this.panelCatButtons, 1, 0);
            this.tableLayoutPanelOrders.Controls.Add(this.tableLayoutPanelButtons, 2, 1);
            this.tableLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOrders.Name = "tableLayoutPanelOrders";
            this.tableLayoutPanelOrders.RowCount = 2;
            this.tableLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelOrders.Size = new System.Drawing.Size(878, 404);
            this.tableLayoutPanelOrders.TabIndex = 1;
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToDeleteRows = false;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cancel,
            this.item_id,
            this.id,
            this.items,
            this.category_id,
            this.category_name,
            this.kitchen_id,
            this.kitchen_name,
            this.discount,
            this.qty,
            this.rates,
            this.total,
            this.apply_discount,
            this.notes});
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.Location = new System.Drawing.Point(3, 3);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.Size = new System.Drawing.Size(433, 276);
            this.dgv_cart.TabIndex = 2;
            this.dgv_cart.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_cart_CellBeginEdit);
            this.dgv_cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cart_CellClick);
            this.dgv_cart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cart_CellEndEdit);
            // 
            // cancel
            // 
            this.cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cancel.HeaderText = "";
            this.cancel.Image = global::Resturant.Properties.Resources.icons8_delete_50;
            this.cancel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.cancel.Name = "cancel";
            this.cancel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cancel.Width = 5;
            // 
            // item_id
            // 
            this.item_id.HeaderText = "ItemId";
            this.item_id.Name = "item_id";
            this.item_id.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // items
            // 
            this.items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.items.HeaderText = "Items";
            this.items.Name = "items";
            this.items.ReadOnly = true;
            this.items.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.items.Width = 73;
            // 
            // category_id
            // 
            this.category_id.HeaderText = "Category ID";
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category_id.Visible = false;
            // 
            // category_name
            // 
            this.category_name.HeaderText = "Category Name";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Visible = false;
            // 
            // kitchen_id
            // 
            this.kitchen_id.HeaderText = "Kitchen ID";
            this.kitchen_id.Name = "kitchen_id";
            this.kitchen_id.ReadOnly = true;
            this.kitchen_id.Visible = false;
            // 
            // kitchen_name
            // 
            this.kitchen_name.HeaderText = "Kitchen Name";
            this.kitchen_name.Name = "kitchen_name";
            this.kitchen_name.ReadOnly = true;
            this.kitchen_name.Visible = false;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.Visible = false;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qty.Width = 95;
            // 
            // rates
            // 
            this.rates.HeaderText = "Rates";
            this.rates.Name = "rates";
            this.rates.ReadOnly = true;
            this.rates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total.Width = 67;
            // 
            // apply_discount
            // 
            this.apply_discount.HeaderText = "Apply_Discount";
            this.apply_discount.Name = "apply_discount";
            this.apply_discount.Visible = false;
            // 
            // notes
            // 
            this.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanelItems
            // 
            this.tableLayoutPanelItems.ColumnCount = 1;
            this.tableLayoutPanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItems.Controls.Add(this.FLP_items, 0, 1);
            this.tableLayoutPanelItems.Controls.Add(this.panel_searchItem, 0, 0);
            this.tableLayoutPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelItems.Location = new System.Drawing.Point(573, 3);
            this.tableLayoutPanelItems.Name = "tableLayoutPanelItems";
            this.tableLayoutPanelItems.RowCount = 2;
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelItems.Size = new System.Drawing.Size(302, 276);
            this.tableLayoutPanelItems.TabIndex = 4;
            // 
            // FLP_items
            // 
            this.FLP_items.AutoScroll = true;
            this.FLP_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_items.Location = new System.Drawing.Point(3, 58);
            this.FLP_items.Name = "FLP_items";
            this.FLP_items.Size = new System.Drawing.Size(296, 215);
            this.FLP_items.TabIndex = 0;
            // 
            // panel_searchItem
            // 
            this.panel_searchItem.Controls.Add(this.txt_itemSearch);
            this.panel_searchItem.Controls.Add(this.label1);
            this.panel_searchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_searchItem.Location = new System.Drawing.Point(3, 3);
            this.panel_searchItem.Name = "panel_searchItem";
            this.panel_searchItem.Size = new System.Drawing.Size(296, 49);
            this.panel_searchItem.TabIndex = 1;
            // 
            // txt_itemSearch
            // 
            this.txt_itemSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemSearch.Location = new System.Drawing.Point(133, 7);
            this.txt_itemSearch.Name = "txt_itemSearch";
            this.txt_itemSearch.Size = new System.Drawing.Size(155, 29);
            this.txt_itemSearch.TabIndex = 1;
            this.txt_itemSearch.TextChanged += new System.EventHandler(this.txt_itemSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // panelCartTotal
            // 
            this.panelCartTotal.Controls.Add(this.lbl_dtable);
            this.panelCartTotal.Controls.Add(this.lbl_table);
            this.panelCartTotal.Controls.Add(this.lbl_dzone);
            this.panelCartTotal.Controls.Add(this.lbl_zone);
            this.panelCartTotal.Controls.Add(this.lbl_dfloor);
            this.panelCartTotal.Controls.Add(this.lbl_floor);
            this.panelCartTotal.Controls.Add(this.lbl_total);
            this.panelCartTotal.Controls.Add(this.lbl_discount);
            this.panelCartTotal.Controls.Add(this.label8);
            this.panelCartTotal.Controls.Add(this.label7);
            this.panelCartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCartTotal.Location = new System.Drawing.Point(3, 285);
            this.panelCartTotal.Name = "panelCartTotal";
            this.panelCartTotal.Size = new System.Drawing.Size(433, 116);
            this.panelCartTotal.TabIndex = 5;
            // 
            // lbl_dtable
            // 
            this.lbl_dtable.AutoSize = true;
            this.lbl_dtable.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtable.Location = new System.Drawing.Point(6, 78);
            this.lbl_dtable.Name = "lbl_dtable";
            this.lbl_dtable.Size = new System.Drawing.Size(56, 25);
            this.lbl_dtable.TabIndex = 11;
            this.lbl_dtable.Text = "Table";
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_table.Location = new System.Drawing.Point(81, 78);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(61, 25);
            this.lbl_table.TabIndex = 10;
            this.lbl_table.Text = "label5";
            // 
            // lbl_dzone
            // 
            this.lbl_dzone.AutoSize = true;
            this.lbl_dzone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dzone.Location = new System.Drawing.Point(6, 42);
            this.lbl_dzone.Name = "lbl_dzone";
            this.lbl_dzone.Size = new System.Drawing.Size(55, 25);
            this.lbl_dzone.TabIndex = 9;
            this.lbl_dzone.Text = "Zone";
            // 
            // lbl_zone
            // 
            this.lbl_zone.AutoSize = true;
            this.lbl_zone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zone.Location = new System.Drawing.Point(81, 42);
            this.lbl_zone.Name = "lbl_zone";
            this.lbl_zone.Size = new System.Drawing.Size(61, 25);
            this.lbl_zone.TabIndex = 8;
            this.lbl_zone.Text = "label4";
            // 
            // lbl_dfloor
            // 
            this.lbl_dfloor.AutoSize = true;
            this.lbl_dfloor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dfloor.Location = new System.Drawing.Point(6, 7);
            this.lbl_dfloor.Name = "lbl_dfloor";
            this.lbl_dfloor.Size = new System.Drawing.Size(56, 25);
            this.lbl_dfloor.TabIndex = 7;
            this.lbl_dfloor.Text = "Floor";
            // 
            // lbl_floor
            // 
            this.lbl_floor.AutoSize = true;
            this.lbl_floor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_floor.Location = new System.Drawing.Point(81, 7);
            this.lbl_floor.Name = "lbl_floor";
            this.lbl_floor.Size = new System.Drawing.Size(61, 25);
            this.lbl_floor.TabIndex = 6;
            this.lbl_floor.Text = "label3";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(349, 42);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 25);
            this.lbl_total.TabIndex = 5;
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(349, 7);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(0, 25);
            this.lbl_discount.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Discount";
            // 
            // panelCatButtons
            // 
            this.panelCatButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCatButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatButtons.Location = new System.Drawing.Point(442, 3);
            this.panelCatButtons.Name = "panelCatButtons";
            this.panelCatButtons.Size = new System.Drawing.Size(125, 276);
            this.panelCatButtons.TabIndex = 7;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.btn_cancelOrder, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btn_bookOrder, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btn_kitchenReceipt, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btn_finalReceipt, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btn_prepayment, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(573, 285);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(302, 116);
            this.tableLayoutPanelButtons.TabIndex = 9;
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cancelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelOrder.ForeColor = System.Drawing.Color.White;
            this.btn_cancelOrder.Location = new System.Drawing.Point(154, 3);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(145, 32);
            this.btn_cancelOrder.TabIndex = 5;
            this.btn_cancelOrder.Text = "Cancel Order";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // btn_bookOrder
            // 
            this.btn_bookOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_bookOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_bookOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_bookOrder.ForeColor = System.Drawing.Color.White;
            this.btn_bookOrder.Location = new System.Drawing.Point(3, 3);
            this.btn_bookOrder.Name = "btn_bookOrder";
            this.btn_bookOrder.Size = new System.Drawing.Size(145, 32);
            this.btn_bookOrder.TabIndex = 0;
            this.btn_bookOrder.Text = "Book Order";
            this.btn_bookOrder.UseVisualStyleBackColor = false;
            this.btn_bookOrder.Click += new System.EventHandler(this.btn_bookOrder_Click);
            // 
            // btn_kitchenReceipt
            // 
            this.btn_kitchenReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_kitchenReceipt.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_kitchenReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kitchenReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_kitchenReceipt.Location = new System.Drawing.Point(3, 41);
            this.btn_kitchenReceipt.Name = "btn_kitchenReceipt";
            this.btn_kitchenReceipt.Size = new System.Drawing.Size(145, 32);
            this.btn_kitchenReceipt.TabIndex = 2;
            this.btn_kitchenReceipt.Text = "Kitchen Receipt";
            this.btn_kitchenReceipt.UseVisualStyleBackColor = false;
            this.btn_kitchenReceipt.Click += new System.EventHandler(this.btn_kitchenReceipt_Click);
            // 
            // btn_finalReceipt
            // 
            this.btn_finalReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_finalReceipt.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_finalReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_finalReceipt.ForeColor = System.Drawing.Color.White;
            this.btn_finalReceipt.Location = new System.Drawing.Point(154, 41);
            this.btn_finalReceipt.Name = "btn_finalReceipt";
            this.btn_finalReceipt.Size = new System.Drawing.Size(145, 32);
            this.btn_finalReceipt.TabIndex = 3;
            this.btn_finalReceipt.Text = "Final Receipt";
            this.btn_finalReceipt.UseVisualStyleBackColor = false;
            this.btn_finalReceipt.Click += new System.EventHandler(this.btn_finalReceipt_Click);
            // 
            // btn_prepayment
            // 
            this.btn_prepayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prepayment.BackColor = System.Drawing.Color.Violet;
            this.btn_prepayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_prepayment.ForeColor = System.Drawing.Color.White;
            this.btn_prepayment.Location = new System.Drawing.Point(3, 79);
            this.btn_prepayment.Name = "btn_prepayment";
            this.btn_prepayment.Size = new System.Drawing.Size(145, 34);
            this.btn_prepayment.TabIndex = 1;
            this.btn_prepayment.Text = "Pre Payment Receipt";
            this.btn_prepayment.UseVisualStyleBackColor = false;
            this.btn_prepayment.Click += new System.EventHandler(this.btn_prepayment_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.label2);
            this.panelTopLeft.Controls.Add(this.lbl_orderType);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(436, 45);
            this.panelTopLeft.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Type ";
            // 
            // lbl_orderType
            // 
            this.lbl_orderType.AutoSize = true;
            this.lbl_orderType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderType.Location = new System.Drawing.Point(134, 10);
            this.lbl_orderType.Name = "lbl_orderType";
            this.lbl_orderType.Size = new System.Drawing.Size(61, 25);
            this.lbl_orderType.TabIndex = 0;
            this.lbl_orderType.Text = "label2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Resturant.Properties.Resources.trash;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.tableLayoutPanelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.tableLayoutPanelItems.ResumeLayout(false);
            this.panel_searchItem.ResumeLayout(false);
            this.panel_searchItem.PerformLayout();
            this.panelCartTotal.ResumeLayout(false);
            this.panelCartTotal.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrders;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItems;
        private System.Windows.Forms.FlowLayoutPanel FLP_items;
        private System.Windows.Forms.Panel panel_searchItem;
        private System.Windows.Forms.TextBox txt_itemSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Label lbl_orderType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelCartTotal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_dtable;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Label lbl_dzone;
        private System.Windows.Forms.Label lbl_zone;
        private System.Windows.Forms.Label lbl_dfloor;
        private System.Windows.Forms.Label lbl_floor;
        private System.Windows.Forms.Panel panelCatButtons;
        private System.Windows.Forms.ComboBox cb_server;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_finalReceipt;
        private System.Windows.Forms.Button btn_kitchenReceipt;
        private System.Windows.Forms.Button btn_prepayment;
        private System.Windows.Forms.Button btn_bookOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.DataGridViewImageColumn cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchen_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchen_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rates;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn apply_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}