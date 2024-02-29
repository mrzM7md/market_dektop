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

namespace Tenders.Forms.Admin.Controllers
{
    public partial class ControllerCategories : UserControl
    {
        public static bool isAddProcess = true;

        private ICollection<Models.Category> categories;
        private CategoryProcesses categoryProcesses = new CategoryProcesses();

        public ControllerCategories()
        {
            InitializeComponent();
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            categories = categoryProcesses.GetAll();

            dataGrideV_category.Columns.Clear();
            foreach (Models.Category item in categories)
            {
                item.Name = item.Name;
            }


            dataGrideV_category.DataSource =
                categories.Select(x =>
                new
                {
                    x.Name,
                    x.Id
                }).ToList();
        }


        private void SearchByItem(string itemSearch)
        {
            categories = categoryProcesses.GetAll();

            dataGrideV_category.Columns.Clear();
            foreach (Models.Category category in categories)
            {
                category.Name = category.Name;
            }


            dataGrideV_category.DataSource =
                categories.Select(x =>
                new
                {
                    x.Name,
                    x.Id
                }).Where(x =>
                    x.Name.Contains(itemSearch) ||
                    x.Id.ToString().Contains(itemSearch)

                    )
                .ToList();
        }


        private void sqlabC_Label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_category_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_category_confirm_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label5_Click(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label8_Click(object sender, EventArgs e)
        {

        }

        private void tb_firm_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_firm_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_firm_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_category_add_Click(object sender, EventArgs e)
        {
            if (isAddProcess) // Add new CategoryName
            {
                AddCategory();
            }
            else //Update exists CategoryName
            {
                UpdateCategory();
            }
        }

        private void UpdateCategory()
        {
            if (IsAllFieldsFilled() == true)
            {
                UpdateFirmDataToFirmTable();
                HideAlertErrorMessage();
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }

        private void UpdateFirmDataToFirmTable()
        {
            int idSelected = Convert.ToInt32(dataGrideV_category.CurrentRow.Cells[1].Value.ToString());
            string nameSelected = tb_category_name.Text;

            Models.Category categoryInfo = new Models.Category
            {
                Id = idSelected,
                Name = nameSelected
            };
            categoryProcesses.Update(categoryInfo);
            GetAllCategories();
            isAddProcess = true;
            label_new_update.Text = "ADD NEW CATEGORY";
            tb_category_name.Text = "";
        }

        private void AddCategory()
        {
            if (IsAllFieldsFilled() == true)
            {
                InsertCategoryDataToCategoryTable(); //sucessfully AddCategory, new user added !!
                tb_category_name.Text = "";
                GetAllCategories();
                HideAlertErrorMessage();
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }

        private void InsertCategoryDataToCategoryTable()
        {
            Models.Category category = new Models.Category
            {
                Name = tb_category_name.Text.Trim(),
            };

            categoryProcesses.Add(category);
        }

        private bool IsAllFieldsFilled()
        {
            if (!tb_category_name.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void ShowAlertErrorMessage(string errorMessage)
        {
            alert_signup_category_error.Visible = true;
            alert_signup_category_error.Text = errorMessage;
        }
        private void HideAlertErrorMessage()
        {
            alert_signup_category_error.Visible = false;
        }

        private void tb_search_category_TextChanged(object sender, EventArgs e)
        {
            SearchByItem(tb_search_category.Text);
        }

        private void label_delete_category_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are u sure you want delete this category?", "Delete CategoryName !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteFirmDataToFirmTable();
                GetAllCategories();
            }
        }

        private void DeleteFirmDataToFirmTable()
        {
            int idSelected = Convert.ToInt32(dataGrideV_category.CurrentRow.Cells[1].Value.ToString());
            categoryProcesses.RemoveAt(idSelected);
        }

        private void label_edit_category_Click(object sender, EventArgs e)
        {
            isAddProcess = false;
            label_new_update.Text = "UPDATE FIRM INFO";

            string nameSelected = dataGrideV_category.CurrentRow.Cells[0].Value.ToString();
            tb_category_name.Text = nameSelected;
        }

        private void label_add_new_category_Click(object sender, EventArgs e)
        {

            isAddProcess = true;
            label_new_update.Text = "ADD NEW CATEGORY";


            tb_category_name.Text = "";

            tb_category_name.Focus();
        }
    }
}
