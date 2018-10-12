namespace Resturant
{
    partial class ZoneED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoneED));
            this.btn_cancelZone = new System.Windows.Forms.Button();
            this.btn_addZone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_zonename = new System.Windows.Forms.TextBox();
            this.cb_floor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancelZone
            // 
            this.btn_cancelZone.AutoSize = true;
            this.btn_cancelZone.Location = new System.Drawing.Point(364, 234);
            this.btn_cancelZone.Name = "btn_cancelZone";
            this.btn_cancelZone.Size = new System.Drawing.Size(75, 27);
            this.btn_cancelZone.TabIndex = 3;
            this.btn_cancelZone.Text = "CANCEL";
            this.btn_cancelZone.UseVisualStyleBackColor = true;
            this.btn_cancelZone.Click += new System.EventHandler(this.btn_cancelZone_Click);
            // 
            // btn_addZone
            // 
            this.btn_addZone.AutoSize = true;
            this.btn_addZone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addZone.Location = new System.Drawing.Point(455, 234);
            this.btn_addZone.Name = "btn_addZone";
            this.btn_addZone.Size = new System.Drawing.Size(75, 27);
            this.btn_addZone.TabIndex = 2;
            this.btn_addZone.Text = "ADD";
            this.btn_addZone.UseVisualStyleBackColor = true;
            this.btn_addZone.Click += new System.EventHandler(this.btn_addZone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zone Name";
            // 
            // txt_zonename
            // 
            this.txt_zonename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zonename.Location = new System.Drawing.Point(364, 203);
            this.txt_zonename.Name = "txt_zonename";
            this.txt_zonename.Size = new System.Drawing.Size(166, 25);
            this.txt_zonename.TabIndex = 1;
            // 
            // cb_floor
            // 
            this.cb_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_floor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_floor.FormattingEnabled = true;
            this.cb_floor.Location = new System.Drawing.Point(364, 171);
            this.cb_floor.Name = "cb_floor";
            this.cb_floor.Size = new System.Drawing.Size(166, 25);
            this.cb_floor.TabIndex = 0;
            // 
            // ZoneED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btn_cancelZone);
            this.Controls.Add(this.btn_addZone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_zonename);
            this.Controls.Add(this.cb_floor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZoneED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoneED";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelZone;
        private System.Windows.Forms.Button btn_addZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_zonename;
        private System.Windows.Forms.ComboBox cb_floor;
    }
}