namespace Tenders.Forms.Client
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
            this.sqlabC_Theme1 = new SQLABC_ModernUI.SQLABC_Theme();
            this.main_card = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuElipse_pc_image = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.label_product_name = new SQLABC_ModernUI.SQLABC_Label();
            this.label_price = new SQLABC_ModernUI.SQLABC_Label();
            this.label_firm_name = new SQLABC_ModernUI.SQLABC_Label();
            this.label_quantity = new SQLABC_ModernUI.SQLABC_Label();
            this.label_category_name = new SQLABC_ModernUI.SQLABC_Label();
            this.btn_details = new SQLABC_ModernUI.SQLABC_Button();
            this.bunifuElipse_btn_details = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sqlabC_Theme1.SuspendLayout();
            this.main_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlabC_Theme1
            // 
            this.sqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sqlabC_Theme1.Controls.Add(this.main_card);
            this.sqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlabC_Theme1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Theme1.Location = new System.Drawing.Point(0, 0);
            this.sqlabC_Theme1.Name = "sqlabC_Theme1";
            this.sqlabC_Theme1.Size = new System.Drawing.Size(800, 450);
            this.sqlabC_Theme1.TabIndex = 0;
            this.sqlabC_Theme1.Text = "sqlabC_Theme1";
            // 
            // main_card
            // 
            this.main_card.BackColor = System.Drawing.Color.White;
            this.main_card.BorderRadius = 5;
            this.main_card.BottomSahddow = true;
            this.main_card.color = System.Drawing.Color.Tomato;
            this.main_card.Controls.Add(this.btn_details);
            this.main_card.Controls.Add(this.label_category_name);
            this.main_card.Controls.Add(this.label_quantity);
            this.main_card.Controls.Add(this.label_firm_name);
            this.main_card.Controls.Add(this.label_price);
            this.main_card.Controls.Add(this.label_product_name);
            this.main_card.Controls.Add(this.pc_image);
            this.main_card.LeftSahddow = false;
            this.main_card.Location = new System.Drawing.Point(12, 51);
            this.main_card.Margin = new System.Windows.Forms.Padding(10);
            this.main_card.Name = "main_card";
            this.main_card.RightSahddow = true;
            this.main_card.ShadowDepth = 20;
            this.main_card.Size = new System.Drawing.Size(171, 330);
            this.main_card.TabIndex = 0;
            // 
            // bunifuElipse_pc_image
            // 
            this.bunifuElipse_pc_image.ElipseRadius = 10;
            this.bunifuElipse_pc_image.TargetControl = this.pc_image;
            // 
            // pc_image
            // 
            this.pc_image.Image = global::Tenders.Properties.Resources.ic_product;
            this.pc_image.Location = new System.Drawing.Point(9, 36);
            this.pc_image.Name = "pc_image";
            this.pc_image.Size = new System.Drawing.Size(152, 130);
            this.pc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_image.TabIndex = 2;
            this.pc_image.TabStop = false;
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.BackColor = System.Drawing.Color.Transparent;
            this.label_product_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product_name.ForeColor = System.Drawing.Color.Black;
            this.label_product_name.Location = new System.Drawing.Point(15, 169);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(117, 28);
            this.label_product_name.TabIndex = 7;
            this.label_product_name.Text = "DOG HOME";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.IndianRed;
            this.label_price.Location = new System.Drawing.Point(17, 224);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(65, 23);
            this.label_price.TabIndex = 8;
            this.label_price.Text = "22.22$";
            // 
            // label_firm_name
            // 
            this.label_firm_name.AutoSize = true;
            this.label_firm_name.BackColor = System.Drawing.Color.Transparent;
            this.label_firm_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firm_name.ForeColor = System.Drawing.Color.Blue;
            this.label_firm_name.Location = new System.Drawing.Point(3, 5);
            this.label_firm_name.Name = "label_firm_name";
            this.label_firm_name.Size = new System.Drawing.Size(104, 23);
            this.label_firm_name.TabIndex = 10;
            this.label_firm_name.Text = "By Facebook";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.BackColor = System.Drawing.Color.Transparent;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.Color.Black;
            this.label_quantity.Location = new System.Drawing.Point(17, 247);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(77, 17);
            this.label_quantity.TabIndex = 11;
            this.label_quantity.Text = "Quantity: 22";
            // 
            // label_category_name
            // 
            this.label_category_name.AutoSize = true;
            this.label_category_name.BackColor = System.Drawing.Color.Transparent;
            this.label_category_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category_name.ForeColor = System.Drawing.Color.Black;
            this.label_category_name.Location = new System.Drawing.Point(16, 195);
            this.label_category_name.Name = "label_category_name";
            this.label_category_name.Size = new System.Drawing.Size(66, 20);
            this.label_category_name.TabIndex = 12;
            this.label_category_name.Text = "HOUSES";
            // 
            // btn_details
            // 
            this.btn_details.BackColor = System.Drawing.Color.Transparent;
            this.btn_details.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_details.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.Location = new System.Drawing.Point(9, 282);
            this.btn_details.Name = "btn_details";
            this.btn_details.Rounded = false;
            this.btn_details.Size = new System.Drawing.Size(128, 33);
            this.btn_details.TabIndex = 13;
            this.btn_details.Text = "Details";
            this.btn_details.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // bunifuElipse_btn_details
            // 
            this.bunifuElipse_btn_details.ElipseRadius = 10;
            this.bunifuElipse_btn_details.TargetControl = this.btn_details;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqlabC_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.Text = "Test";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.sqlabC_Theme1.ResumeLayout(false);
            this.main_card.ResumeLayout(false);
            this.main_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme sqlabC_Theme1;
        private Bunifu.Framework.UI.BunifuCards main_card;
        private System.Windows.Forms.PictureBox pc_image;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_pc_image;
        private SQLABC_ModernUI.SQLABC_Label label_price;
        private SQLABC_ModernUI.SQLABC_Label label_product_name;
        private SQLABC_ModernUI.SQLABC_Label label_quantity;
        private SQLABC_ModernUI.SQLABC_Label label_firm_name;
        private SQLABC_ModernUI.SQLABC_Button btn_details;
        private SQLABC_ModernUI.SQLABC_Label label_category_name;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_details;
    }
}