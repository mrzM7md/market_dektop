namespace Tenders.Forms.Firm
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.sqlabC_Theme1 = new SQLABC_ModernUI.SQLABC_Theme();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label_category_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_delete = new SQLABC_ModernUI.SQLABC_Button();
            this.label_quantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_firm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_price = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.label_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_btn_test = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_pc_image = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_edit = new SQLABC_ModernUI.SQLABC_Button();
            this.bunifuElipse_btn_edit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sqlabC_Theme1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlabC_Theme1
            // 
            this.sqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sqlabC_Theme1.Controls.Add(this.flowLayoutPanel1);
            this.sqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlabC_Theme1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sqlabC_Theme1.Location = new System.Drawing.Point(0, 0);
            this.sqlabC_Theme1.Name = "sqlabC_Theme1";
            this.sqlabC_Theme1.Size = new System.Drawing.Size(1079, 596);
            this.sqlabC_Theme1.TabIndex = 0;
            this.sqlabC_Theme1.Text = "sqlabC_Theme1";
            // 
            // fLPanel_cards
            // 
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards1);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.flowLayoutPanel1.Name = "fLPanel_cards";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1073, 538);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // maiin_card
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btn_edit);
            this.bunifuCards1.Controls.Add(this.label_category_name);
            this.bunifuCards1.Controls.Add(this.btn_delete);
            this.bunifuCards1.Controls.Add(this.label_quantity);
            this.bunifuCards1.Controls.Add(this.label_firm);
            this.bunifuCards1.Controls.Add(this.label_price);
            this.bunifuCards1.Controls.Add(this.tb_description);
            this.bunifuCards1.Controls.Add(this.label_title);
            this.bunifuCards1.Controls.Add(this.pc_image);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.bunifuCards1.Name = "maiin_card";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(760, 207);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label_category_name
            // 
            this.label_category_name.AutoSize = true;
            this.label_category_name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category_name.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_category_name.Location = new System.Drawing.Point(656, 31);
            this.label_category_name.Name = "label_category_name";
            this.label_category_name.Size = new System.Drawing.Size(45, 22);
            this.label_category_name.TabIndex = 8;
            this.label_category_name.Text = "C 22";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.Red;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_delete.Location = new System.Drawing.Point(17, 163);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Rounded = false;
            this.btn_delete.Size = new System.Drawing.Size(68, 32);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(555, 31);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(47, 19);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = "Q: 22";
            // 
            // label_firm
            // 
            this.label_firm.AutoSize = true;
            this.label_firm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firm.Location = new System.Drawing.Point(417, 31);
            this.label_firm.Name = "label_firm";
            this.label_firm.Size = new System.Drawing.Size(80, 19);
            this.label_firm.TabIndex = 5;
            this.label_firm.Text = "Facebook";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(307, 31);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(58, 19);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "22.55$";
            // 
            // tb_description
            // 
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(162, 56);
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(572, 139);
            this.tb_description.TabIndex = 3;
            this.tb_description.Text = resources.GetString("tb_description.Text");
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(158, 31);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(112, 22);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "HOME PAGE";
            // 
            // pc_image
            // 
            this.pc_image.Image = global::Tenders.Properties.Resources.ic_product;
            this.pc_image.Location = new System.Drawing.Point(17, 22);
            this.pc_image.Name = "pc_image";
            this.pc_image.Size = new System.Drawing.Size(135, 135);
            this.pc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_image.TabIndex = 1;
            this.pc_image.TabStop = false;
            // 
            // bunifuElipse_btn_test
            // 
            this.bunifuElipse_btn_test.ElipseRadius = 10;
            this.bunifuElipse_btn_test.TargetControl = this.btn_delete;
            // 
            // bunifuElipse_pc_image
            // 
            this.bunifuElipse_pc_image.ElipseRadius = 10;
            this.bunifuElipse_pc_image.TargetControl = this.pc_image;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_edit.Location = new System.Drawing.Point(88, 163);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Rounded = false;
            this.btn_edit.Size = new System.Drawing.Size(68, 32);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // bunifuElipse_btn_edit
            // 
            this.bunifuElipse_btn_edit.ElipseRadius = 10;
            this.bunifuElipse_btn_edit.TargetControl = this.btn_edit;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.sqlabC_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.Text = "Test";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.sqlabC_Theme1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme sqlabC_Theme1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_test;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_pc_image;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private SQLABC_ModernUI.SQLABC_Button btn_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel label_quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel label_firm;
        private Bunifu.Framework.UI.BunifuCustomLabel label_price;
        private System.Windows.Forms.RichTextBox tb_description;
        private Bunifu.Framework.UI.BunifuCustomLabel label_title;
        private System.Windows.Forms.PictureBox pc_image;
        private Bunifu.Framework.UI.BunifuCustomLabel label_category_name;
        private SQLABC_ModernUI.SQLABC_Button btn_edit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_edit;
    }
}