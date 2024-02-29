using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenders.Models;
using Tenders.Processes;

namespace Tenders.Forms.Firm.DesignCards
{
    internal class CardProduct
    {


        private System.ComponentModel.IContainer components = null;
        private Category category;


        public CardProduct(Models.Product product, Main context)
        {
            this.product = product;
            this.context = context;
            category = new CategoryProcesses().Find(product.CategoryId);
        }

        public BunifuCards ShowCard()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            
            this.maiin_card = new Bunifu.Framework.UI.BunifuCards();
            this.label_category = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_delete = new SQLABC_ModernUI.SQLABC_Button();
            this.label_quantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_firm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_price = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.label_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_btn_test = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_pc_image = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_edit = new SQLABC_ModernUI.SQLABC_Button();
            this.bunifuElipse_btn_edit = new Bunifu.Framework.UI.BunifuElipse(this.components);
        
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            context.SuspendLayout();


            //
            // maiin_card
            // 
            this.maiin_card.BackColor = System.Drawing.Color.White;
            this.maiin_card.BorderRadius = 15;
            this.maiin_card.BottomSahddow = true;
            this.maiin_card.color = System.Drawing.Color.Tomato;
            
            this.maiin_card.Controls.Add(this.label_category);
            this.maiin_card.Controls.Add(this.btn_delete);
            this.maiin_card.Controls.Add(this.label);
            this.maiin_card.Controls.Add(this.btn_edit);
            this.maiin_card.Controls.Add(this.label_quantity);
            this.maiin_card.Controls.Add(this.label_firm);
            this.maiin_card.Controls.Add(this.label_price);
            this.maiin_card.Controls.Add(this.tb_description);
            this.maiin_card.Controls.Add(this.label_title);
            this.maiin_card.Controls.Add(this.pc_image);
            
            this.maiin_card.LeftSahddow = false;
            this.maiin_card.Location = new System.Drawing.Point(3, 3);
            this.maiin_card.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.maiin_card.Name = "maiin_card";
            this.maiin_card.RightSahddow = false;
            this.maiin_card.ShadowDepth = 20;
            this.maiin_card.Size = new System.Drawing.Size(650, 200);
            this.maiin_card.TabIndex = 0;
            
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_cklick);
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_click);
            this.btn_edit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));


            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(480, 31);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(47, 19);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = $"Q: {product.Quantity}";

            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_category.Location = new System.Drawing.Point(560, 31);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(45, 22);
            this.label_category.TabIndex = 8;
            this.label_category.Text = $"C: {category.Name}";

            // 
            // label_firm
            // 
            this.label_firm.AutoSize = true;
            this.label_firm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firm.Location = new System.Drawing.Point(390, 31);
            this.label_firm.Name = "label_firm";
            this.label_firm.Size = new System.Drawing.Size(80, 19);
            this.label_firm.TabIndex = 5;
            this.label_firm.Text = product.Firm.Name;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(280, 31);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(58, 19);
            this.label_price.TabIndex = 4;
            this.label_price.Text = $"{product.Price}$";
            // 
            // tb_description
            // 
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(162, 56);
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(480, 129);
            this.tb_description.TabIndex = 3;
            this.tb_description.Text = product.Description;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(158, 31);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(112, 22);
            this.label_title.TabIndex = 2;
            this.label_title.Text = product.Name;

            // 
            // 
            // pc_image
            // 
            this.pc_image.Image = new EncryptionDecryption.EncryptionDecryptionImage().Decryption(product.Image);
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
            // bunifuElipse_btn_edit
            // 
            this.bunifuElipse_btn_edit.ElipseRadius = 10;
            this.bunifuElipse_btn_edit.TargetControl = this.btn_edit;

            return maiin_card;
        }

        private void btn_delete_cklick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are u sure you want delete this product?", "Delete a pproduct !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new ProductProcesses().RemoveAt(product.Id);

                context.fLPanel_cards.Controls.Remove(
                    maiin_card
                ); ; ;
            }
        }

        private void btn_edit_click(object sender, EventArgs e)
        {
            context.productImagePath = (Bitmap) new EncryptionDecryption.EncryptionDecryptionImage().Decryption(product.Image);
            
            context.label_new_update.Text = "UPDATE ADMIN INFO";
            context.tb_name.Text = product.Name;
            context.tb_description.Text = product.Description;
            context.tb_price.Text = product.Price.ToString();
            context.tb_quantity.Text = product.Quantity.ToString();
            context.cb_category.Text = category.Name;
            context.tb_id.Text = product.Id.ToString();
            context.pc_image.Image = context.productImagePath;
            Main.isAddProcess = false;
        }


        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_test;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_pc_image;
        private Bunifu.Framework.UI.BunifuCards maiin_card; // will return this
        private SQLABC_ModernUI.SQLABC_Button btn_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel label_quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel label_firm;
        private Bunifu.Framework.UI.BunifuCustomLabel label_price;
        private System.Windows.Forms.RichTextBox tb_description;
        private Bunifu.Framework.UI.BunifuCustomLabel label_title;
        private System.Windows.Forms.PictureBox pc_image;
        private Bunifu.Framework.UI.BunifuCustomLabel label_category;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private SQLABC_ModernUI.SQLABC_Button btn_edit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_btn_edit;
        private readonly Product product;
        private readonly Main context;
    }
}
