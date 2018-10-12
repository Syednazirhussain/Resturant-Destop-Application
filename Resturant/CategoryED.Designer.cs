namespace Resturant
{
    partial class CategoryED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryED));
            this.btnc_cancel = new System.Windows.Forms.Button();
            this.btnc_add = new System.Windows.Forms.Button();
            this.txtc_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnc_cancel
            // 
            this.btnc_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnc_cancel.AutoSize = true;
            this.btnc_cancel.Location = new System.Drawing.Point(343, 219);
            this.btnc_cancel.Name = "btnc_cancel";
            this.btnc_cancel.Size = new System.Drawing.Size(75, 27);
            this.btnc_cancel.TabIndex = 22;
            this.btnc_cancel.Text = "CANCEL";
            this.btnc_cancel.UseVisualStyleBackColor = true;
            this.btnc_cancel.Click += new System.EventHandler(this.btnc_cancel_Click);
            // 
            // btnc_add
            // 
            this.btnc_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnc_add.AutoSize = true;
            this.btnc_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_add.Location = new System.Drawing.Point(433, 218);
            this.btnc_add.Name = "btnc_add";
            this.btnc_add.Size = new System.Drawing.Size(75, 27);
            this.btnc_add.TabIndex = 21;
            this.btnc_add.Text = "ADD";
            this.btnc_add.UseVisualStyleBackColor = true;
            this.btnc_add.Click += new System.EventHandler(this.btnc_add_Click);
            // 
            // txtc_name
            // 
            this.txtc_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtc_name.Location = new System.Drawing.Point(343, 187);
            this.txtc_name.Name = "txtc_name";
            this.txtc_name.Size = new System.Drawing.Size(165, 25);
            this.txtc_name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category";
            // 
            // CategoryED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnc_cancel);
            this.Controls.Add(this.btnc_add);
            this.Controls.Add(this.txtc_name);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CategoryED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryED";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnc_cancel;
        private System.Windows.Forms.Button btnc_add;
        private System.Windows.Forms.TextBox txtc_name;
        private System.Windows.Forms.Label label2;
    }
}