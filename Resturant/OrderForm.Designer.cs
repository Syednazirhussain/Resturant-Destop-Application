namespace Resturant
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.main_menu = new System.Windows.Forms.Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.tabControlOrder = new System.Windows.Forms.TabControl();
            this.tab_dinen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelDineIn = new System.Windows.Forms.TableLayoutPanel();
            this.panelFloor = new System.Windows.Forms.Panel();
            this.cb_zone = new System.Windows.Forms.ComboBox();
            this.cb_floor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FLP_tables = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_takeAway = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flp_takeAway = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addTakeAwayOrder = new System.Windows.Forms.Button();
            this.tab_delievery = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_addDelieveryOrder = new System.Windows.Forms.Button();
            this.flp_delievery = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.tabControlOrder.SuspendLayout();
            this.tab_dinen.SuspendLayout();
            this.tableLayoutPanelDineIn.SuspendLayout();
            this.panelFloor.SuspendLayout();
            this.tab_takeAway.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_delievery.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlOrder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTopLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomRight.Location = new System.Drawing.Point(420, 417);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(411, 41);
            this.panelBottomRight.TabIndex = 3;
            // 
            // main_menu
            // 
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu.ForeColor = System.Drawing.Color.Blue;
            this.main_menu.Location = new System.Drawing.Point(7, 27);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(112, 28);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "Main Menu";
            this.main_menu.UseVisualStyleBackColor = true;
            this.main_menu.Click += new System.EventHandler(this.main_menu_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.lbl_userType);
            this.panelTopRight.Controls.Add(this.lbl_clock);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(420, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(411, 63);
            this.panelTopRight.TabIndex = 2;
            // 
            // lbl_userType
            // 
            this.lbl_userType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(153, 38);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(0, 17);
            this.lbl_userType.TabIndex = 3;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(153, 6);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 21);
            this.lbl_clock.TabIndex = 2;
            // 
            // tabControlOrder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControlOrder, 2);
            this.tabControlOrder.Controls.Add(this.tab_dinen);
            this.tabControlOrder.Controls.Add(this.tab_takeAway);
            this.tabControlOrder.Controls.Add(this.tab_delievery);
            this.tabControlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOrder.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControlOrder.Location = new System.Drawing.Point(3, 72);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(828, 339);
            this.tabControlOrder.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlOrder.TabIndex = 1;
            // 
            // tab_dinen
            // 
            this.tab_dinen.Controls.Add(this.tableLayoutPanelDineIn);
            this.tab_dinen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_dinen.Location = new System.Drawing.Point(4, 34);
            this.tab_dinen.Name = "tab_dinen";
            this.tab_dinen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dinen.Size = new System.Drawing.Size(820, 301);
            this.tab_dinen.TabIndex = 0;
            this.tab_dinen.Text = "Dine In";
            this.tab_dinen.UseVisualStyleBackColor = true;
            this.tab_dinen.Enter += new System.EventHandler(this.tab_dinen_Enter);
            // 
            // tableLayoutPanelDineIn
            // 
            this.tableLayoutPanelDineIn.ColumnCount = 2;
            this.tableLayoutPanelDineIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDineIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelDineIn.Controls.Add(this.panelFloor, 1, 0);
            this.tableLayoutPanelDineIn.Controls.Add(this.FLP_tables, 0, 1);
            this.tableLayoutPanelDineIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDineIn.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDineIn.Name = "tableLayoutPanelDineIn";
            this.tableLayoutPanelDineIn.RowCount = 2;
            this.tableLayoutPanelDineIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDineIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelDineIn.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanelDineIn.TabIndex = 0;
            // 
            // panelFloor
            // 
            this.panelFloor.Controls.Add(this.cb_zone);
            this.panelFloor.Controls.Add(this.cb_floor);
            this.panelFloor.Controls.Add(this.label2);
            this.panelFloor.Controls.Add(this.label1);
            this.panelFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFloor.Location = new System.Drawing.Point(247, 3);
            this.panelFloor.Name = "panelFloor";
            this.panelFloor.Size = new System.Drawing.Size(564, 67);
            this.panelFloor.TabIndex = 0;
            // 
            // cb_zone
            // 
            this.cb_zone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_zone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_zone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_zone.FormattingEnabled = true;
            this.cb_zone.Location = new System.Drawing.Point(369, 20);
            this.cb_zone.Name = "cb_zone";
            this.cb_zone.Size = new System.Drawing.Size(180, 25);
            this.cb_zone.TabIndex = 3;
            this.cb_zone.SelectedIndexChanged += new System.EventHandler(this.cb_zone_SelectedIndexChanged);
            // 
            // cb_floor
            // 
            this.cb_floor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_floor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_floor.FormattingEnabled = true;
            this.cb_floor.Location = new System.Drawing.Point(96, 20);
            this.cb_floor.Name = "cb_floor";
            this.cb_floor.Size = new System.Drawing.Size(180, 25);
            this.cb_floor.TabIndex = 2;
            this.cb_floor.SelectedIndexChanged += new System.EventHandler(this.cb_floor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Zone";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Floor";
            // 
            // FLP_tables
            // 
            this.FLP_tables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanelDineIn.SetColumnSpan(this.FLP_tables, 2);
            this.FLP_tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_tables.Location = new System.Drawing.Point(3, 76);
            this.FLP_tables.Name = "FLP_tables";
            this.FLP_tables.Size = new System.Drawing.Size(808, 216);
            this.FLP_tables.TabIndex = 1;
            // 
            // tab_takeAway
            // 
            this.tab_takeAway.Controls.Add(this.tableLayoutPanel2);
            this.tab_takeAway.Location = new System.Drawing.Point(4, 34);
            this.tab_takeAway.Name = "tab_takeAway";
            this.tab_takeAway.Padding = new System.Windows.Forms.Padding(3);
            this.tab_takeAway.Size = new System.Drawing.Size(820, 301);
            this.tab_takeAway.TabIndex = 1;
            this.tab_takeAway.Text = "Take Away";
            this.tab_takeAway.UseVisualStyleBackColor = true;
            this.tab_takeAway.Enter += new System.EventHandler(this.tab_takeAway_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flp_takeAway, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flp_takeAway
            // 
            this.flp_takeAway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_takeAway.Location = new System.Drawing.Point(3, 62);
            this.flp_takeAway.Name = "flp_takeAway";
            this.flp_takeAway.Size = new System.Drawing.Size(808, 230);
            this.flp_takeAway.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addTakeAwayOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 53);
            this.panel1.TabIndex = 1;
            // 
            // btn_addTakeAwayOrder
            // 
            this.btn_addTakeAwayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addTakeAwayOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTakeAwayOrder.Location = new System.Drawing.Point(683, 7);
            this.btn_addTakeAwayOrder.Name = "btn_addTakeAwayOrder";
            this.btn_addTakeAwayOrder.Size = new System.Drawing.Size(107, 37);
            this.btn_addTakeAwayOrder.TabIndex = 0;
            this.btn_addTakeAwayOrder.Text = "Add New";
            this.btn_addTakeAwayOrder.UseVisualStyleBackColor = true;
            this.btn_addTakeAwayOrder.Click += new System.EventHandler(this.btn_addTakeAwayOrder_Click);
            // 
            // tab_delievery
            // 
            this.tab_delievery.Controls.Add(this.tableLayoutPanel3);
            this.tab_delievery.Location = new System.Drawing.Point(4, 34);
            this.tab_delievery.Name = "tab_delievery";
            this.tab_delievery.Padding = new System.Windows.Forms.Padding(3);
            this.tab_delievery.Size = new System.Drawing.Size(820, 301);
            this.tab_delievery.TabIndex = 2;
            this.tab_delievery.Text = "Delivery";
            this.tab_delievery.UseVisualStyleBackColor = true;
            this.tab_delievery.Enter += new System.EventHandler(this.tab_delievery_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flp_delievery, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_addDelieveryOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 53);
            this.panel3.TabIndex = 1;
            // 
            // btn_addDelieveryOrder
            // 
            this.btn_addDelieveryOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addDelieveryOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDelieveryOrder.Location = new System.Drawing.Point(681, 8);
            this.btn_addDelieveryOrder.Name = "btn_addDelieveryOrder";
            this.btn_addDelieveryOrder.Size = new System.Drawing.Size(107, 37);
            this.btn_addDelieveryOrder.TabIndex = 1;
            this.btn_addDelieveryOrder.Text = "Add New";
            this.btn_addDelieveryOrder.UseVisualStyleBackColor = true;
            this.btn_addDelieveryOrder.Click += new System.EventHandler(this.btn_addDelieveryOrder_Click);
            // 
            // flp_delievery
            // 
            this.flp_delievery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_delievery.Location = new System.Drawing.Point(3, 62);
            this.flp_delievery.Name = "flp_delievery";
            this.flp_delievery.Size = new System.Drawing.Size(808, 230);
            this.flp_delievery.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Resturant.Properties.Resources.icons8_delete_50;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.main_menu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(411, 63);
            this.panelTopLeft.TabIndex = 5;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.tabControlOrder.ResumeLayout(false);
            this.tab_dinen.ResumeLayout(false);
            this.tableLayoutPanelDineIn.ResumeLayout(false);
            this.panelFloor.ResumeLayout(false);
            this.panelFloor.PerformLayout();
            this.tab_takeAway.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab_delievery.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Button main_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControlOrder;
        private System.Windows.Forms.TabPage tab_takeAway;
        private System.Windows.Forms.TabPage tab_delievery;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabPage tab_dinen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDineIn;
        private System.Windows.Forms.Panel panelFloor;
        private System.Windows.Forms.ComboBox cb_zone;
        private System.Windows.Forms.ComboBox cb_floor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLP_tables;
        private System.Windows.Forms.FlowLayoutPanel flp_takeAway;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addTakeAwayOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flp_delievery;
        private System.Windows.Forms.Button btn_addDelieveryOrder;
        private System.Windows.Forms.Panel panelTopLeft;
    }
}