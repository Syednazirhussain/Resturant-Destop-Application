namespace Resturant
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.user_type = new System.Windows.Forms.Label();
            this.txt_clock = new System.Windows.Forms.Label();
            this.tabTable = new System.Windows.Forms.TabControl();
            this.tabFloor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_floor = new System.Windows.Forms.DataGridView();
            this.fsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAddFloor = new System.Windows.Forms.Panel();
            this.btn_addFloor = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtf_search = new System.Windows.Forms.TextBox();
            this.tabZone = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddZone = new System.Windows.Forms.Panel();
            this.btn_addZone = new System.Windows.Forms.Button();
            this.panelZoneSearch = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbz_search = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtz_search = new System.Windows.Forms.TextBox();
            this.dgv_zone = new System.Windows.Forms.DataGridView();
            this.tab_table = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvt_table = new System.Windows.Forms.DataGridView();
            this.panelAddTable = new System.Windows.Forms.Panel();
            this.btn_addTable = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.main_menu = new System.Windows.Forms.Button();
            this.panelTSearch = new System.Windows.Forms.Panel();
            this.btnt_clear = new System.Windows.Forms.Button();
            this.btnt_search = new System.Windows.Forms.Button();
            this.cbt_search = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtt_search = new System.Windows.Forms.TextBox();
            this.zsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablezone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablezone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tfloor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttable_zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tfloor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tabFloor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_floor)).BeginInit();
            this.panelAddFloor.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tabZone.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelAddZone.SuspendLayout();
            this.panelZoneSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zone)).BeginInit();
            this.tab_table.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvt_table)).BeginInit();
            this.panelAddTable.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelTSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabTable, 0, 1);
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
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(421, 417);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(410, 41);
            this.panelBottomRight.TabIndex = 6;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.user_type);
            this.panelTopRight.Controls.Add(this.txt_clock);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(421, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(410, 63);
            this.panelTopRight.TabIndex = 5;
            // 
            // user_type
            // 
            this.user_type.AutoSize = true;
            this.user_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_type.Location = new System.Drawing.Point(145, 35);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(13, 17);
            this.user_type.TabIndex = 14;
            this.user_type.Text = "*";
            // 
            // txt_clock
            // 
            this.txt_clock.AutoSize = true;
            this.txt_clock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clock.Location = new System.Drawing.Point(144, 4);
            this.txt_clock.Name = "txt_clock";
            this.txt_clock.Size = new System.Drawing.Size(17, 21);
            this.txt_clock.TabIndex = 10;
            this.txt_clock.Text = "*";
            // 
            // tabTable
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabTable, 2);
            this.tabTable.Controls.Add(this.tabFloor);
            this.tabTable.Controls.Add(this.tabZone);
            this.tabTable.Controls.Add(this.tab_table);
            this.tabTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTable.ItemSize = new System.Drawing.Size(100, 30);
            this.tabTable.Location = new System.Drawing.Point(3, 72);
            this.tabTable.Name = "tabTable";
            this.tabTable.SelectedIndex = 0;
            this.tabTable.Size = new System.Drawing.Size(828, 339);
            this.tabTable.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabTable.TabIndex = 1;
            // 
            // tabFloor
            // 
            this.tabFloor.Controls.Add(this.tableLayoutPanel2);
            this.tabFloor.Location = new System.Drawing.Point(4, 34);
            this.tabFloor.Name = "tabFloor";
            this.tabFloor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFloor.Size = new System.Drawing.Size(820, 301);
            this.tabFloor.TabIndex = 0;
            this.tabFloor.Text = "Floors";
            this.tabFloor.UseVisualStyleBackColor = true;
            this.tabFloor.Enter += new System.EventHandler(this.tabFloor_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_floor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelAddFloor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelSearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgv_floor
            // 
            this.dgv_floor.AllowUserToAddRows = false;
            this.dgv_floor.AllowUserToDeleteRows = false;
            this.dgv_floor.AllowUserToResizeColumns = false;
            this.dgv_floor.AllowUserToResizeRows = false;
            this.dgv_floor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_floor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_floor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fsno,
            this.id,
            this.name});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_floor, 2);
            this.dgv_floor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_floor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_floor.Location = new System.Drawing.Point(3, 76);
            this.dgv_floor.Name = "dgv_floor";
            this.dgv_floor.ReadOnly = true;
            this.dgv_floor.RowHeadersVisible = false;
            this.dgv_floor.Size = new System.Drawing.Size(808, 216);
            this.dgv_floor.TabIndex = 3;
            this.dgv_floor.TabStop = false;
            this.dgv_floor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_floor_CellClick);
            // 
            // fsno
            // 
            this.fsno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fsno.HeaderText = "#";
            this.fsno.Name = "fsno";
            this.fsno.ReadOnly = true;
            this.fsno.Width = 41;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Floor Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // panelAddFloor
            // 
            this.panelAddFloor.Controls.Add(this.btn_addFloor);
            this.panelAddFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddFloor.Location = new System.Drawing.Point(3, 3);
            this.panelAddFloor.Name = "panelAddFloor";
            this.panelAddFloor.Size = new System.Drawing.Size(401, 67);
            this.panelAddFloor.TabIndex = 14;
            // 
            // btn_addFloor
            // 
            this.btn_addFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addFloor.AutoSize = true;
            this.btn_addFloor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFloor.Location = new System.Drawing.Point(0, 27);
            this.btn_addFloor.Name = "btn_addFloor";
            this.btn_addFloor.Size = new System.Drawing.Size(75, 27);
            this.btn_addFloor.TabIndex = 2;
            this.btn_addFloor.Text = "ADD";
            this.btn_addFloor.UseVisualStyleBackColor = true;
            this.btn_addFloor.Click += new System.EventHandler(this.btn_addFloor_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.txtf_search);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(410, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(401, 67);
            this.panelSearch.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtf_search
            // 
            this.txtf_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtf_search.Location = new System.Drawing.Point(256, 29);
            this.txtf_search.Name = "txtf_search";
            this.txtf_search.Size = new System.Drawing.Size(145, 25);
            this.txtf_search.TabIndex = 0;
            this.txtf_search.TextChanged += new System.EventHandler(this.txtf_search_TextChanged);
            // 
            // tabZone
            // 
            this.tabZone.Controls.Add(this.tableLayoutPanel3);
            this.tabZone.Location = new System.Drawing.Point(4, 34);
            this.tabZone.Name = "tabZone";
            this.tabZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabZone.Size = new System.Drawing.Size(820, 301);
            this.tabZone.TabIndex = 1;
            this.tabZone.Text = "Zones";
            this.tabZone.UseVisualStyleBackColor = true;
            this.tabZone.Enter += new System.EventHandler(this.tabZone_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelAddZone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelZoneSearch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgv_zone, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // panelAddZone
            // 
            this.panelAddZone.Controls.Add(this.btn_addZone);
            this.panelAddZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddZone.Location = new System.Drawing.Point(3, 3);
            this.panelAddZone.Name = "panelAddZone";
            this.panelAddZone.Size = new System.Drawing.Size(401, 67);
            this.panelAddZone.TabIndex = 10;
            // 
            // btn_addZone
            // 
            this.btn_addZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addZone.AutoSize = true;
            this.btn_addZone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addZone.Location = new System.Drawing.Point(0, 25);
            this.btn_addZone.Name = "btn_addZone";
            this.btn_addZone.Size = new System.Drawing.Size(75, 27);
            this.btn_addZone.TabIndex = 2;
            this.btn_addZone.Text = "ADD";
            this.btn_addZone.UseVisualStyleBackColor = true;
            this.btn_addZone.Click += new System.EventHandler(this.btn_addZone_Click);
            // 
            // panelZoneSearch
            // 
            this.panelZoneSearch.Controls.Add(this.btn_clear);
            this.panelZoneSearch.Controls.Add(this.btn_search);
            this.panelZoneSearch.Controls.Add(this.cbz_search);
            this.panelZoneSearch.Controls.Add(this.label2);
            this.panelZoneSearch.Controls.Add(this.txtz_search);
            this.panelZoneSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZoneSearch.Location = new System.Drawing.Point(410, 3);
            this.panelZoneSearch.Name = "panelZoneSearch";
            this.panelZoneSearch.Size = new System.Drawing.Size(401, 67);
            this.panelZoneSearch.TabIndex = 11;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackgroundImage = global::Resturant.Properties.Resources.icons8_delete_50;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(48, 27);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(32, 25);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = true;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(358, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 27);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "GO";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbz_search
            // 
            this.cbz_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbz_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbz_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbz_search.FormattingEnabled = true;
            this.cbz_search.Location = new System.Drawing.Point(252, 27);
            this.cbz_search.Name = "cbz_search";
            this.cbz_search.Size = new System.Drawing.Size(99, 25);
            this.cbz_search.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // txtz_search
            // 
            this.txtz_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtz_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtz_search.Location = new System.Drawing.Point(139, 27);
            this.txtz_search.Name = "txtz_search";
            this.txtz_search.Size = new System.Drawing.Size(107, 25);
            this.txtz_search.TabIndex = 3;
            // 
            // dgv_zone
            // 
            this.dgv_zone.AllowUserToAddRows = false;
            this.dgv_zone.AllowUserToDeleteRows = false;
            this.dgv_zone.AllowUserToResizeColumns = false;
            this.dgv_zone.AllowUserToResizeRows = false;
            this.dgv_zone.BackgroundColor = System.Drawing.Color.White;
            this.dgv_zone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_zone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zsno,
            this.floor_id,
            this.floor_name,
            this.tablezone_id,
            this.tablezone_name});
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_zone, 2);
            this.dgv_zone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_zone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_zone.Location = new System.Drawing.Point(3, 76);
            this.dgv_zone.Name = "dgv_zone";
            this.dgv_zone.ReadOnly = true;
            this.dgv_zone.RowHeadersVisible = false;
            this.dgv_zone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_zone.Size = new System.Drawing.Size(808, 216);
            this.dgv_zone.TabIndex = 3;
            this.dgv_zone.TabStop = false;
            this.dgv_zone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zone_CellClick);
            // 
            // tab_table
            // 
            this.tab_table.Controls.Add(this.tableLayoutPanel4);
            this.tab_table.Location = new System.Drawing.Point(4, 34);
            this.tab_table.Name = "tab_table";
            this.tab_table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_table.Size = new System.Drawing.Size(820, 301);
            this.tab_table.TabIndex = 2;
            this.tab_table.Text = "Tables";
            this.tab_table.UseVisualStyleBackColor = true;
            this.tab_table.Enter += new System.EventHandler(this.tab_table_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvt_table, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panelAddTable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panelTSearch, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // dgvt_table
            // 
            this.dgvt_table.AllowUserToAddRows = false;
            this.dgvt_table.AllowUserToDeleteRows = false;
            this.dgvt_table.AllowUserToResizeColumns = false;
            this.dgvt_table.AllowUserToResizeRows = false;
            this.dgvt_table.BackgroundColor = System.Drawing.Color.White;
            this.dgvt_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvt_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsno,
            this.table_id,
            this.tfloor_name,
            this.ttable_zone,
            this.table_name,
            this.tfloor_id,
            this.zone_id,
            this.num_seats});
            this.tableLayoutPanel4.SetColumnSpan(this.dgvt_table, 2);
            this.dgvt_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvt_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvt_table.Location = new System.Drawing.Point(3, 76);
            this.dgvt_table.Name = "dgvt_table";
            this.dgvt_table.ReadOnly = true;
            this.dgvt_table.RowHeadersVisible = false;
            this.dgvt_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvt_table.Size = new System.Drawing.Size(808, 216);
            this.dgvt_table.TabIndex = 3;
            this.dgvt_table.TabStop = false;
            this.dgvt_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvt_table_CellClick);
            // 
            // panelAddTable
            // 
            this.panelAddTable.Controls.Add(this.btn_addTable);
            this.panelAddTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddTable.Location = new System.Drawing.Point(3, 3);
            this.panelAddTable.Name = "panelAddTable";
            this.panelAddTable.Size = new System.Drawing.Size(401, 67);
            this.panelAddTable.TabIndex = 13;
            // 
            // btn_addTable
            // 
            this.btn_addTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addTable.AutoSize = true;
            this.btn_addTable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTable.Location = new System.Drawing.Point(0, 28);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(75, 27);
            this.btn_addTable.TabIndex = 2;
            this.btn_addTable.Text = "ADD";
            this.btn_addTable.UseVisualStyleBackColor = true;
            this.btn_addTable.Click += new System.EventHandler(this.btn_addTable_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.main_menu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(411, 63);
            this.panelTopLeft.TabIndex = 7;
            // 
            // main_menu
            // 
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu.ForeColor = System.Drawing.Color.Blue;
            this.main_menu.Location = new System.Drawing.Point(10, 24);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(112, 28);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "Main Menu";
            this.main_menu.UseVisualStyleBackColor = true;
            this.main_menu.Click += new System.EventHandler(this.main_menu_Click);
            // 
            // panelTSearch
            // 
            this.panelTSearch.Controls.Add(this.btnt_clear);
            this.panelTSearch.Controls.Add(this.btnt_search);
            this.panelTSearch.Controls.Add(this.cbt_search);
            this.panelTSearch.Controls.Add(this.label3);
            this.panelTSearch.Controls.Add(this.txtt_search);
            this.panelTSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTSearch.Location = new System.Drawing.Point(410, 3);
            this.panelTSearch.Name = "panelTSearch";
            this.panelTSearch.Size = new System.Drawing.Size(401, 67);
            this.panelTSearch.TabIndex = 14;
            // 
            // btnt_clear
            // 
            this.btnt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnt_clear.BackgroundImage = global::Resturant.Properties.Resources.icons8_delete_50;
            this.btnt_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnt_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnt_clear.Location = new System.Drawing.Point(47, 28);
            this.btnt_clear.Name = "btnt_clear";
            this.btnt_clear.Size = new System.Drawing.Size(32, 25);
            this.btnt_clear.TabIndex = 6;
            this.btnt_clear.UseVisualStyleBackColor = true;
            this.btnt_clear.Click += new System.EventHandler(this.btnt_clear_Click);
            // 
            // btnt_search
            // 
            this.btnt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnt_search.AutoSize = true;
            this.btnt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnt_search.Location = new System.Drawing.Point(358, 28);
            this.btnt_search.Name = "btnt_search";
            this.btnt_search.Size = new System.Drawing.Size(43, 27);
            this.btnt_search.TabIndex = 5;
            this.btnt_search.Text = "GO";
            this.btnt_search.UseVisualStyleBackColor = true;
            this.btnt_search.Click += new System.EventHandler(this.btnt_search_Click);
            // 
            // cbt_search
            // 
            this.cbt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbt_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbt_search.FormattingEnabled = true;
            this.cbt_search.Location = new System.Drawing.Point(253, 28);
            this.cbt_search.Name = "cbt_search";
            this.cbt_search.Size = new System.Drawing.Size(99, 25);
            this.cbt_search.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // txtt_search
            // 
            this.txtt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtt_search.Location = new System.Drawing.Point(138, 28);
            this.txtt_search.Name = "txtt_search";
            this.txtt_search.Size = new System.Drawing.Size(107, 25);
            this.txtt_search.TabIndex = 3;
            // 
            // zsno
            // 
            this.zsno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.zsno.HeaderText = "#";
            this.zsno.Name = "zsno";
            this.zsno.ReadOnly = true;
            this.zsno.Width = 41;
            // 
            // floor_id
            // 
            this.floor_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floor_id.HeaderText = "Floor Id";
            this.floor_id.Name = "floor_id";
            this.floor_id.ReadOnly = true;
            this.floor_id.Visible = false;
            this.floor_id.Width = 78;
            // 
            // floor_name
            // 
            this.floor_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floor_name.HeaderText = "Floor Name";
            this.floor_name.Name = "floor_name";
            this.floor_name.ReadOnly = true;
            this.floor_name.Width = 102;
            // 
            // tablezone_id
            // 
            this.tablezone_id.HeaderText = "Table Zone ID";
            this.tablezone_id.Name = "tablezone_id";
            this.tablezone_id.ReadOnly = true;
            this.tablezone_id.Visible = false;
            // 
            // tablezone_name
            // 
            this.tablezone_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tablezone_name.HeaderText = "Zone Name";
            this.tablezone_name.Name = "tablezone_name";
            this.tablezone_name.ReadOnly = true;
            this.tablezone_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tsno
            // 
            this.tsno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tsno.HeaderText = "#";
            this.tsno.Name = "tsno";
            this.tsno.ReadOnly = true;
            this.tsno.Width = 41;
            // 
            // table_id
            // 
            this.table_id.HeaderText = "Table ID";
            this.table_id.Name = "table_id";
            this.table_id.ReadOnly = true;
            this.table_id.Visible = false;
            // 
            // tfloor_name
            // 
            this.tfloor_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tfloor_name.HeaderText = "Floor";
            this.tfloor_name.Name = "tfloor_name";
            this.tfloor_name.ReadOnly = true;
            this.tfloor_name.Width = 63;
            // 
            // ttable_zone
            // 
            this.ttable_zone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ttable_zone.HeaderText = "Zone";
            this.ttable_zone.Name = "ttable_zone";
            this.ttable_zone.ReadOnly = true;
            this.ttable_zone.Width = 62;
            // 
            // table_name
            // 
            this.table_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.table_name.HeaderText = "Table";
            this.table_name.Name = "table_name";
            this.table_name.ReadOnly = true;
            this.table_name.Width = 64;
            // 
            // tfloor_id
            // 
            this.tfloor_id.HeaderText = "Floor ID";
            this.tfloor_id.Name = "tfloor_id";
            this.tfloor_id.ReadOnly = true;
            this.tfloor_id.Visible = false;
            // 
            // zone_id
            // 
            this.zone_id.HeaderText = "Zone ID";
            this.zone_id.Name = "zone_id";
            this.zone_id.ReadOnly = true;
            this.zone_id.Visible = false;
            // 
            // num_seats
            // 
            this.num_seats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_seats.HeaderText = "Number Of Seats";
            this.num_seats.Name = "num_seats";
            this.num_seats.ReadOnly = true;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.tabTable.ResumeLayout(false);
            this.tabFloor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_floor)).EndInit();
            this.panelAddFloor.ResumeLayout(false);
            this.panelAddFloor.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabZone.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelAddZone.ResumeLayout(false);
            this.panelAddZone.PerformLayout();
            this.panelZoneSearch.ResumeLayout(false);
            this.panelZoneSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zone)).EndInit();
            this.tab_table.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvt_table)).EndInit();
            this.panelAddTable.ResumeLayout(false);
            this.panelAddTable.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.panelTSearch.ResumeLayout(false);
            this.panelTSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabTable;
        private System.Windows.Forms.TabPage tabFloor;
        private System.Windows.Forms.Label txt_clock;
        private System.Windows.Forms.Label user_type;
        private System.Windows.Forms.Button main_menu;
        private System.Windows.Forms.TabPage tabZone;
        private System.Windows.Forms.TabPage tab_table;
        private System.Windows.Forms.DataGridView dgvt_table;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_floor;
        private System.Windows.Forms.Button btn_addFloor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelAddZone;
        private System.Windows.Forms.Panel panelZoneSearch;
        private System.Windows.Forms.Button btn_addZone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panelAddTable;
        private System.Windows.Forms.Button btn_addTable;
        private System.Windows.Forms.Panel panelAddFloor;
        private System.Windows.Forms.DataGridView dgv_zone;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtf_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtz_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbz_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panelTSearch;
        private System.Windows.Forms.Button btnt_clear;
        private System.Windows.Forms.Button btnt_search;
        private System.Windows.Forms.ComboBox cbt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablezone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablezone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tfloor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttable_zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tfloor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn zone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_seats;
    }
}