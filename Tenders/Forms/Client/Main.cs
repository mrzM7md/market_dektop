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

namespace Tenders.Forms.Client
{
    public partial class Main : Form
    {

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private EncryptionDecryptionImage encryptionDecryptionImage = new EncryptionDecryptionImage();
        private ProductProcesses productProcesses = new ProductProcesses();
        private CategoryProcesses categoryProcesses = new CategoryProcesses();

        public Bitmap productImagePath = global::Tenders.Properties.Resources.ic_product; // default image
        private int ClientId { get; set; }

        public Main(int clientId)
        {

            InitializeComponent();
            ClientId = clientId;

            SetFormName();
            GetAllCategoriesThenPutInComboBox();
        }

        private void SetFormName()
        {
            string clientName = encryptionDecryptionText.Decryption(new ClientProcesses().Find(ClientId).Name);
            theme_client_side.Text = $"Welcome `{clientName}`, Have a great Tenders..";
        }

        private void GetAllProductsInfo()
        {
            fLPanel_cards.Controls.Clear();
            int? categoryId = null;
            if (cb_categories.Text != "All")
            {
                categoryId = cb_categories.SelectedIndex + 1;
            }

            foreach (Models.Product product in productProcesses.GetAllByCategoryId(categoryId).OrderBy(o => o.Price))
            {
                product.Firm.Name = encryptionDecryptionText.Decryption(product.Firm.Name);
                fLPanel_cards.Controls.Add(
                    new DesignCards.CardClientProduct(this, product).ShowCard()
                );
            }
        }

        private void GetAllCategoriesThenPutInComboBox()
        {
            string[] items = categoryProcesses.GetAll().Select(X => X.Name).ToArray();
            cb_categories.Items.AddRange(items);
            cb_categories.Items.Add("All");
            cb_categories.Text = "All";
        }

        private void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllProductsInfo();
        }
    }
}
