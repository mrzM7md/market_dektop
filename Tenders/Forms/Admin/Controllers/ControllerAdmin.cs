using System;
using System.Windows.Forms;
using Tenders.EncryptionDecryption;
using Tenders.Forms.Admin.DesignCards;
using Tenders.Processes;

namespace Tenders.Forms.Admin.Controllers
{
    public partial class ControllerAdmin : UserControl
    {
        public static bool isAddProcess = true;

        public short MASTERT_ADMIN_PERMISSION = 1;
        public short ADMIN_PERMIISION = 2;

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private AdminProcesses adminProcesses = new AdminProcesses();
        private AccountProcesses accountProcesses = new AccountProcesses();

        public ControllerAdmin()
        {
            InitializeComponent();

            GetAllAdminsInfo();
            if (IsAdminNotMaster())
            {
                RemoveAddCard();
                DenyAddAdminProcees();
            }
        }

  

        private void DenyAddAdminProcees()
        {
            btn_admin_add.Visible = false;
        }

        private void RemoveAddCard()
        {
            fLPanel_cards.Controls.RemoveAt(0);
        }

        internal void AddFirstCard()
        {
            if (IsAdminNotMaster())
            {
                var x = fLPanel_cards.Controls[0];
                fLPanel_cards.Controls.Clear();
                fLPanel_cards.Controls.Add(x);
            }

        }

        private bool IsAdminNotMaster()
        {
            return Auth.Controllers.ControllerSignIn.PREMISSION == ADMIN_PERMIISION;
        }

        private void GetAllAdminsInfo()
        {
            foreach (Models.Admin admin in adminProcesses.GetAll())
            {
                fLPanel_cards.Controls.Add(
                    new CardAdmin(this)
                    {
                        Id = admin.Id,
                        Name = encryptionDecryptionText.Decryption(admin.Name),
                        Username = encryptionDecryptionText.Decryption(admin.Account.Username),
                        Password = encryptionDecryptionText.Decryption(admin.Account.Password),
                        Email = encryptionDecryptionText.Decryption(admin.Account.Email),
                        Phone = encryptionDecryptionText.Decryption(admin.Account.Phone),
                    }.ShowCard()
                );
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
                        InsertAdminDataToAdminTable(); //sucessfully AddCategory, new user added !!
                        tb_admin_username.Text = "";
                        // flowLayoutPanel_admin_signup.Visible = false;
                        AddFirstCard();
                        GetAllAdminsInfo();
                        HideAlertErrorMessage();
                    }
                    else //if another one has same Username already
                    {
                        ShowAlertErrorMessage("this Username already used !!");
                        tb_admin_username.Text = "";
                        tb_admin_username.Focus();
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

        private bool IsAllFieldsFilled()
        {
            if (!tb_admin_username.Text.Equals("") &&
                !tb_admin_name.Text.Equals("") &&
                !tb_admin_password.Text.Equals("") &&
                !tb_admin_confirm_password.Text.Equals("") &&
                !tb_admin_email.Text.Equals("") &&
                !tb_admin_phone.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool IsPasswordAndConfirmPasswordAreSame()
        {
            if (tb_admin_password.Text.Trim() == tb_admin_confirm_password.Text.Trim())
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
            string username = tb_admin_username.Text.Trim();
            return adminProcesses.IsUsernameNew(encryptionDecryptionText.Encryption(username));
        }

        private void UpdateAdminDataToAdminTable()
        {
            Models.Account accountAdmin = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_admin_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_admin_password.Text.Trim()),
                PermissionId = ADMIN_PERMIISION,
                Email = encryptionDecryptionText.Encryption(tb_admin_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_admin_phone.Text.Trim()),
            };

            int accountAdminId = accountProcesses.GetIdByUserName(accountAdmin.Username);
            accountAdmin.Id = accountAdminId;

            Models.Admin adminInfo = new Models.Admin
            {
                Name = encryptionDecryptionText.Encryption(tb_admin_name.Text.Trim()),
                AccountId = accountAdminId,
                Account = accountAdmin,
            };

            adminProcesses.Update(adminInfo);
            AddFirstCard();
            GetAllAdminsInfo();
        }

        private void InsertAdminDataToAdminTable()
        {
            Models.Account accountAdmin = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_admin_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_admin_password.Text.Trim()),
                PermissionId = ADMIN_PERMIISION,
                Email = encryptionDecryptionText.Encryption(tb_admin_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_admin_phone.Text.Trim()),
            };

            accountProcesses.Add(accountAdmin);

            int accountAdminId = accountProcesses.GetId(accountAdmin);

            Models.Admin adminInfo = new Models.Admin
            {
                Name = encryptionDecryptionText.Encryption(tb_admin_name.Text.Trim()),
                AccountId = accountAdminId,
                Account = accountAdmin,
            };

            adminProcesses.Add(adminInfo);
        }

        private void UpdateUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    UpdateAdminDataToAdminTable();
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

        private void pb_add_admin_Click(object sender, EventArgs e)
        {
            label_new_update.Text = "ADD NEW ADMIN";
            isAddProcess = true;

            tb_admin_username.Enabled = true;
            tb_admin_username.Text = "";
            tb_admin_password.Text = "";
            tb_admin_confirm_password.Text = "";
            tb_admin_name.Text = "";
            tb_admin_email.Text = "";
            tb_admin_phone.Text = "";
        }

        private void btn_admin_add_Click(object sender, EventArgs e)
        {
            if (isAddProcess) // Add new Admin
            {
                SignUp();
            }
            else //Update exists admin
            {
                UpdateUp();
            }
        }
    }
}
