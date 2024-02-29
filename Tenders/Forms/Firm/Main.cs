using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenders.EncryptionDecryption;
using Tenders.Processes;

namespace Tenders.Forms.Firm
{
    public partial class Main : Form
    {
        public static bool isAddProcess = true;

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private EncryptionDecryptionImage encryptionDecryptionImage = new EncryptionDecryptionImage();
        private ProductProcesses productProcesses = new ProductProcesses();
        private CategoryProcesses categoryProcesses = new CategoryProcesses();

        public Bitmap productImagePath = global::Tenders.Properties.Resources.ic_product; // default image
        private OpenFileDialog ofd = new OpenFileDialog();

        private int FirmId { get; set; }
       

        public Main(int firmId)
        {
            InitializeComponent();

            FirmId = firmId;
            SetFormName();
            GetAllProductsInfo();
            GetAllCategoriesThenPutInComboBox();
        }

        private void SetFormName()
        {
            string firmName = encryptionDecryptionText.Decryption(new FirmProcesses().Find(FirmId).Name);
            theme_firm_dide.Text = $"Welcome `{firmName}` Companey !!";
        }

        private void GetAllCategoriesThenPutInComboBox()
        {
            string[] items = categoryProcesses.GetAll().Select(X => X.Name).ToArray();
            cb_category.Items.AddRange(items);
        }

        private void GetAllProductsInfo()
        {
            foreach (Models.Product product in productProcesses.GetAllByFirmId(FirmId))
            {
                product.Firm.Name = encryptionDecryptionText.Decryption(product.Firm.Name);
                fLPanel_cards.Controls.Add(
                    new DesignCards.CardProduct(product, this).ShowCard()
                ); ;
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                productImagePath = new Bitmap(ofd.FileName);  // new image
                pc_image.Image = (Image)productImagePath;
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            InitialFieldsForAdding();
        }

        private void InitialFieldsForAdding()
        {
            label_new_update.Text = "ADD NEW PRODYCT";
            isAddProcess = true;
            tb_name.Text = "";
            tb_description.Text = "";
            tb_price.Text = "";
            tb_quantity.Text = "";
            cb_category.Text = "";
        }

        private void btn_add_update_Click(object sender, EventArgs e)
        {
            if (isAddProcess) // Add new
            {
                AddNewProduct();
            }
            else //Update exists
            {
                UpdateProduct();
            }
        }

        private void UpdateProduct()
        {
            if (IsAllFieldsFilled() == true)
            {
                UpdateProductDataToProductsTable();
                ClearCardsButFirst();
                GetAllProductsInfo();
                HideAlertErrorMessage();
                InitialFieldsForAdding();
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }

        private void UpdateProductDataToProductsTable()
        {
            Models.Product newProduct = new Models.Product
            {
                Id = int.Parse(tb_id.Text.ToString()),
                Name = tb_name.Text,
                Description = tb_description.Text,
                Price = float.Parse(tb_price.Text),
                FirmId = FirmId,
                CategoryId = cb_category.SelectedIndex + 1,
                Image = encryptionDecryptionImage.Encryption(productImagePath),
                Quantity = int.Parse(tb_quantity.Text.Trim()),
            };

            productProcesses.Update(newProduct);
        }

        private void AddNewProduct()
        {
            if (IsAllFieldsFilled() == true)
            {
                {
                    AddProductDataToProductsTable();
                    tb_name.Text = "";
                    
                    ClearCardsButFirst();
                    GetAllProductsInfo();
                    HideAlertErrorMessage();
                }

            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }

        private void ShowAlertErrorMessage(string erroeMessage)
        {
            alert_error.Visible = true;
            alert_error.Text = erroeMessage;
        }

        private void ClearCardsButFirst()
        {
            var x = fLPanel_cards.Controls[0];
            fLPanel_cards.Controls.Clear();
            fLPanel_cards.Controls.Add(x);
        }

        private void HideAlertErrorMessage()
        {
            alert_error.Visible = false;
        }

        private bool IsAllFieldsFilled()
        {
            if (!tb_name.Text.Equals("") &&
                !tb_description.Text.Equals("") &&
                !tb_price.Text.Equals("") &&
                !tb_quantity.Text.Equals("") &&
                !cb_category.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        

        private void AddProductDataToProductsTable()
        {
            Models.Product newProduct = new Models.Product
            {
                Name = tb_name.Text,
                Description = tb_description.Text,
                Price = float.Parse(tb_price.Text),
                FirmId = FirmId,
                CategoryId = cb_category.SelectedIndex + 1,
                Image = encryptionDecryptionImage.Encryption(productImagePath),
                Quantity = int.Parse(tb_quantity.Text.Trim()), 
            };

            productProcesses.Add(newProduct);
            
        }
    }
}
