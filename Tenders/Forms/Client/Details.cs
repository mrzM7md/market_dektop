using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenders.Forms.Client
{
    public partial class Details : Form
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            pc_image.Image = new EncryptionDecryption.EncryptionDecryptionImage().Decryption(Image);
            label_category_name.Text = Name;
            label_category_name.Text = CategoryName;
            label_price.Text = Price.ToString();
            label_quantity.Text = Quantity.ToString();
            tb_description.Text = Description;
        }

        private void tb_quantity_num_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // only accept int values
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_quantity_num_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label_end_price.Text = $"{(int.Parse(tb_quantity_num.Text) * Price)}";
            }
            catch (Exception ex)
            {
                ErrorDialogs.Error error = new ErrorDialogs.Error();
                error.Title = "Error Occurse";
                error.Description = ex.Message;
            }
        }
    }
}
