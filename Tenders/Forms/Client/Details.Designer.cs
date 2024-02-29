namespace Tenders.Forms.Client
{
    partial class Details
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
            this.sqlabC_Theme1 = new SQLABC_ModernUI.SQLABC_Theme();
            this.btn_buy = new SQLABC_ModernUI.SQLABC_Button();
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_pc_image = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_btn_details = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label_category_name = new SQLABC_ModernUI.SQLABC_Label();
            this.label_quantity = new SQLABC_ModernUI.SQLABC_Label();
            this.label_price = new SQLABC_ModernUI.SQLABC_Label();
            this.label_product_name = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.tb_quantity_num = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label1 = new SQLABC_ModernUI.SQLABC_Label();
            this.sqlabC_Label2 = new SQLABC_ModernUI.SQLABC_Label();
            this.label_end_price = new SQLABC_ModernUI.SQLABC_Label();
            this.sqlabC_Theme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlabC_Theme1
            // 
            this.sqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sqlabC_Theme1.Controls.Add(this.label_end_price);
            this.sqlabC_Theme1.Controls.Add(this.sqlabC_Label2);
            this.sqlabC_Theme1.Controls.Add(this.sqlabC_Label1);
            this.sqlabC_Theme1.Controls.Add(this.tb_quantity_num);
            this.sqlabC_Theme1.Controls.Add(this.tb_description);
            this.sqlabC_Theme1.Controls.Add(this.label_category_name);
            this.sqlabC_Theme1.Controls.Add(this.label_quantity);
            this.sqlabC_Theme1.Controls.Add(this.label_price);
            this.sqlabC_Theme1.Controls.Add(this.label_product_name);
            this.sqlabC_Theme1.Controls.Add(this.btn_buy);
            this.sqlabC_Theme1.Controls.Add(this.pc_image);
            this.sqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlabC_Theme1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sqlabC_Theme1.Location = new System.Drawing.Point(0, 0);
            this.sqlabC_Theme1.Name = "sqlabC_Theme1";
            this.sqlabC_Theme1.Size = new System.Drawing.Size(369, 658);
            this.sqlabC_Theme1.TabIndex = 0;
            this.sqlabC_Theme1.Text = "PRODUCT DETAILS !!";
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.Transparent;
            this.btn_buy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(21, 602);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Rounded = false;
            this.btn_buy.Size = new System.Drawing.Size(322, 33);
            this.btn_buy.TabIndex = 15;
            this.btn_buy.Text = "BUY NOE";
            this.btn_buy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // pc_image
            // 
            this.pc_image.Image = global::Tenders.Properties.Resources.ic_product;
            this.pc_image.Location = new System.Drawing.Point(21, 57);
            this.pc_image.Name = "pc_image";
            this.pc_image.Size = new System.Drawing.Size(322, 204);
            this.pc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_image.TabIndex = 14;
            this.pc_image.TabStop = false;
            // 
            // bunifuElipse_pc_image
            // 
            this.bunifuElipse_pc_image.ElipseRadius = 10;
            this.bunifuElipse_pc_image.TargetControl = this.pc_image;
            // 
            // bunifuElipse_btn_details
            // 
            this.bunifuElipse_btn_details.ElipseRadius = 10;
            this.bunifuElipse_btn_details.TargetControl = this.btn_buy;
            // 
            // label_category_name
            // 
            this.label_category_name.AutoSize = true;
            this.label_category_name.BackColor = System.Drawing.Color.Transparent;
            this.label_category_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_category_name.Location = new System.Drawing.Point(50, 292);
            this.label_category_name.Name = "label_category_name";
            this.label_category_name.Size = new System.Drawing.Size(66, 20);
            this.label_category_name.TabIndex = 19;
            this.label_category_name.Text = "HOUSES";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.BackColor = System.Drawing.Color.Transparent;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_quantity.Location = new System.Drawing.Point(229, 297);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(77, 17);
            this.label_quantity.TabIndex = 18;
            this.label_quantity.Text = "Quantity: 22";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_price.Location = new System.Drawing.Point(230, 269);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(65, 23);
            this.label_price.TabIndex = 17;
            this.label_price.Text = "22.22$";
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.BackColor = System.Drawing.Color.Transparent;
            this.label_product_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_product_name.Location = new System.Drawing.Point(48, 264);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(117, 28);
            this.label_product_name.TabIndex = 16;
            this.label_product_name.Text = "DOG HOME";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_description.Location = new System.Drawing.Point(21, 333);
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(322, 176);
            this.tb_description.TabIndex = 20;
            this.tb_description.Text = "TEST DESCRIPTION HELLO DESCRIPTIO HELLO !!";
            // 
            // tb_quantity_num
            // 
            this.tb_quantity_num.BackColor = System.Drawing.Color.Transparent;
            this.tb_quantity_num.Location = new System.Drawing.Point(22, 551);
            this.tb_quantity_num.MaxLength = 32767;
            this.tb_quantity_num.Multiline = false;
            this.tb_quantity_num.Name = "tb_quantity_num";
            this.tb_quantity_num.ReadOnly = false;
            this.tb_quantity_num.Size = new System.Drawing.Size(63, 34);
            this.tb_quantity_num.TabIndex = 21;
            this.tb_quantity_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_quantity_num.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_quantity_num.UseSystemPasswordChar = false;
            this.tb_quantity_num.TextChanged += new System.EventHandler(this.tb_quantity_num_TextChanged);
            this.tb_quantity_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_quantity_num_KeyPress_1);
            // 
            // sqlabC_Label1
            // 
            this.sqlabC_Label1.AutoSize = true;
            this.sqlabC_Label1.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sqlabC_Label1.Location = new System.Drawing.Point(18, 528);
            this.sqlabC_Label1.Name = "sqlabC_Label1";
            this.sqlabC_Label1.Size = new System.Drawing.Size(147, 20);
            this.sqlabC_Label1.TabIndex = 22;
            this.sqlabC_Label1.Text = "Customize Quantity";
            // 
            // sqlabC_Label2
            // 
            this.sqlabC_Label2.AutoSize = true;
            this.sqlabC_Label2.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sqlabC_Label2.Location = new System.Drawing.Point(252, 528);
            this.sqlabC_Label2.Name = "sqlabC_Label2";
            this.sqlabC_Label2.Size = new System.Drawing.Size(43, 20);
            this.sqlabC_Label2.TabIndex = 23;
            this.sqlabC_Label2.Text = "Price";
            // 
            // label_end_price
            // 
            this.label_end_price.AutoSize = true;
            this.label_end_price.BackColor = System.Drawing.Color.Transparent;
            this.label_end_price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_end_price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_end_price.Location = new System.Drawing.Point(252, 551);
            this.label_end_price.Name = "label_end_price";
            this.label_end_price.Size = new System.Drawing.Size(17, 20);
            this.label_end_price.TabIndex = 24;
            this.label_end_price.Text = "0";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 658);
            this.Controls.Add(this.sqlabC_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.Text = "Details";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Details_Load);
            this.sqlabC_Theme1.ResumeLayout(false);
            this.sqlabC_Theme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme sqlabC_Theme1;
        private SQLABC_ModernUI.SQLABC_Button btn_buy;
        private System.Windows.Forms.PictureBox pc_image;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_pc_image;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_details;
        private SQLABC_ModernUI.SQLABC_TextBox tb_quantity_num;
        private System.Windows.Forms.RichTextBox tb_description;
        private SQLABC_ModernUI.SQLABC_Label label_category_name;
        private SQLABC_ModernUI.SQLABC_Label label_quantity;
        private SQLABC_ModernUI.SQLABC_Label label_price;
        private SQLABC_ModernUI.SQLABC_Label label_product_name;
        private SQLABC_ModernUI.SQLABC_Label label_end_price;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label2;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label1;
    }
}