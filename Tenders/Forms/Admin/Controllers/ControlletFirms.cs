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
    public partial class ControlletFirms : UserControl
    {
        public static bool isAddProcess = true;

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private FirmProcesses firmProcesses = new FirmProcesses();
        private AccountProcesses accountProcesses = new AccountProcesses();
        private ICollection<Models.Firm> firms;

        public ControlletFirms()
        {
            InitializeComponent();

            // Add column names to dataGrideView

            GetAllFirms();
        }

        private void GetAllFirms()
        {
            firms = firmProcesses.GetAll();

            dataGrideV_firms.Columns.Clear();
            foreach (Models.Firm item in firms)
            {
                item.Name = encryptionDecryptionText.Decryption(item.Name);
                item.Account.Username = encryptionDecryptionText.Decryption(item.Account.Username);
                item.Account.Password = encryptionDecryptionText.Decryption(item.Account.Password);
                item.Account.Email = encryptionDecryptionText.Decryption(item.Account.Email);
                item.Account.Phone = encryptionDecryptionText.Decryption(item.Account.Phone);
                item.Location = encryptionDecryptionText.Decryption(item.Location);
            }


            dataGrideV_firms.DataSource =
                firms.Select(x =>
                new
                {
                    x.Name,
                    x.Location,
                    x.Account.Username,
                    x.Account.Password,
                    x.Account.Email,
                    x.Account.Phone,
                    x.Id
                }).ToList();
        }

        private void SearchByItem(string itemSearch)
        {
            firms = firmProcesses.GetAll();

            dataGrideV_firms.Columns.Clear();
            foreach (Models.Firm firm in firms)
            {
                firm.Name = encryptionDecryptionText.Decryption(firm.Name);
                firm.Account.Username = encryptionDecryptionText.Decryption(firm.Account.Username);
                firm.Account.Password = encryptionDecryptionText.Decryption(firm.Account.Password);
                firm.Account.Email = encryptionDecryptionText.Decryption(firm.Account.Email);
                firm.Account.Phone = encryptionDecryptionText.Decryption(firm.Account.Phone);
                firm.Location = encryptionDecryptionText.Decryption(firm.Location);
            }


            dataGrideV_firms.DataSource =
                firms.Select(x =>
                new
                {
                    x.Name,
                    x.Location,
                    x.Account.Username,
                    x.Account.Password,
                    x.Account.Email,
                    x.Account.Phone,
                    x.Id
                }).Where(x =>
                    x.Name.Contains(itemSearch) ||
                    x.Location.Contains(itemSearch) ||
                    x.Username.Contains(itemSearch) ||
                    x.Password.Contains(itemSearch) ||
                    x.Email.Contains(itemSearch) ||
                    x.Phone.Contains(itemSearch) ||
                    x.Id.ToString().Contains(itemSearch)

                    )
                .ToList();
        }

        private void btn_firm_add_Click(object sender, EventArgs e)
        {
            if (isAddProcess) // Add new Firm
            {
                SignUp();
            }
            else //Update exists admin
            {
                UpdateUp();
            }
        }

        private void SignUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    if (IsUsernameNotUsedBefor() == true)
                    {//check that Username not used befor
                        InsertFirmDataToFirmTable(); //sucessfully AddCategory, new user added !!
                        tb_firm_username.Text = "";
                        GetAllFirms();
                        HideAlertErrorMessage();
                    }
                    else //if another one has same Username already
                    {
                        ShowAlertErrorMessage("this Username already used !!");
                        tb_firm_username.Text = "";
                        tb_firm_username.Focus();
                    }
                }
                else
                {
                    ShowAlertErrorMessage("Make sure that Passwords are same");
                }
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }


        private void InsertFirmDataToFirmTable()
        {
            Models.Account accountFirm = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_firm_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_firm_password.Text.Trim()),
                PermissionId = 3,
                Email = encryptionDecryptionText.Encryption(tb_firm_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_firm_phone.Text.Trim()),
            };

            accountProcesses.Add(accountFirm);
            int accountAdminId = accountProcesses.GetId(accountFirm);

            Models.Firm firmInfo = new Models.Firm
            {
                Name = encryptionDecryptionText.Encryption(tb_firm_name.Text.Trim()),
                Location = encryptionDecryptionText.Encryption(tb_firm_location.Text.Trim()),
                AccountId = accountAdminId,
                Account = accountFirm,
            };

            firmProcesses.Add(firmInfo);
        }



        private bool IsAllFieldsFilled()
        {
            if (!tb_firm_username.Text.Equals("") &&
                !tb_firm_name.Text.Equals("") &&
                !tb_firm_password.Text.Equals("") &&
                !tb_firm_confirm_password.Text.Equals("") &&
                !tb_firm_email.Text.Equals("") &&
                !tb_firm_location.Text.Equals("") &&
                !tb_firm_phone.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool IsPasswordAndConfirmPasswordAreSame()
        {
            if (tb_firm_password.Text.Trim() == tb_firm_confirm_password.Text.Trim())
            {
                return true;
            }
            return false;
        }
        private void ShowAlertErrorMessage(string errorMessage)
        {
            alert_signup_admin_error.Visible = true;
            alert_signup_admin_error.Text = errorMessage;
        }
        private void HideAlertErrorMessage()
        {
            alert_signup_admin_error.Visible = false;
        }

        private bool IsUsernameNotUsedBefor()
        {
            string username = tb_firm_username.Text.Trim();
            return firmProcesses.IsUsernameNew(encryptionDecryptionText.Encryption(username));
        }

        private void label_add_new_firm_Click(object sender, EventArgs e)
        {
            label_new_update.Text = "ADD NEW FIRM";
            isAddProcess = true;

            tb_firm_username.Enabled = true;
            tb_firm_username.Text = "";
            tb_firm_password.Text = "";
            tb_firm_confirm_password.Text = "";
            tb_firm_name.Text = "";
            tb_firm_email.Text = "";
            tb_firm_phone.Text = "";
            tb_firm_location.Text = "";

            tb_firm_username.Focus();
        }

        private void UpdateUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    UpdateFirmDataToFirmTable();
                    HideAlertErrorMessage();
                }
                else
                {
                    ShowAlertErrorMessage("Make sure that Passwords are same");
                }
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }
        private void UpdateFirmDataToFirmTable()
        {
            Models.Account accountfirm = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_firm_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_firm_password.Text.Trim()),
                PermissionId = 3,
                Email = encryptionDecryptionText.Encryption(tb_firm_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_firm_phone.Text.Trim()),
            };

            int accountAdminId = accountProcesses.GetIdByUserName(accountfirm.Username);
            accountfirm.Id = accountAdminId;

            Models.Firm firmInfo = new Models.Firm
            {
                Name = encryptionDecryptionText.Encryption(tb_firm_name.Text.Trim()),
                Location = encryptionDecryptionText.Encryption(tb_firm_location.Text.Trim()),
                AccountId = accountAdminId,
                Account = accountfirm,
            };

            firmProcesses.Update(firmInfo);
            GetAllFirms();
        }

        private void DeleteFirmDataToFirmTable()
        {
            int idSelected = Convert.ToInt32(dataGrideV_firms.CurrentRow.Cells[6].Value.ToString());
            firmProcesses.RemoveAt(idSelected);
        }

        private void label_edit_firm_Click(object sender, EventArgs e)
        {
            isAddProcess = false;
            label_new_update.Text = "UPDATE FIRM INFO";
            tb_firm_username.Enabled = false;

            string nameSelected = dataGrideV_firms.CurrentRow.Cells[0].Value.ToString();
            string locationSelected = dataGrideV_firms.CurrentRow.Cells[1].Value.ToString();
            string usernameSelected = dataGrideV_firms.CurrentRow.Cells[2].Value.ToString();
            string passwordSelected = dataGrideV_firms.CurrentRow.Cells[3].Value.ToString();
            string emailSelected = dataGrideV_firms.CurrentRow.Cells[4].Value.ToString();
            string phoneSelected = dataGrideV_firms.CurrentRow.Cells[5].Value.ToString();

            tb_firm_username.Text = usernameSelected;
            tb_firm_password.Text = passwordSelected;
            tb_firm_confirm_password.Text = passwordSelected;
            tb_firm_name.Text = nameSelected;
            tb_firm_email.Text = emailSelected;
            tb_firm_phone.Text = phoneSelected;
            tb_firm_location.Text = locationSelected;

            ControllerAdmin.isAddProcess = false;
        }

        private void label_delete_firm_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are u sure you want delete this firm?", "Delete Firm !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteFirmDataToFirmTable();
                GetAllFirms();
            }
        }

        private void tb_search_firms_TextChanged(object sender, EventArgs e)
        {
            SearchByItem(tb_search_firms.Text);
        }
    }
}
