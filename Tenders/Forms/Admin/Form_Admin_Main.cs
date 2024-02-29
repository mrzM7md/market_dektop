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
using Tenders.Forms.Admin.DesignCards;
using Tenders.Models;
using Tenders.Processes;

namespace Tenders.Forms.Admin
{
    /// <summary>
    /// This is for AdminRoom section
    /// </summary>
    public partial class Form_Admin_Main : Form
    {
        public static bool isAddProcess = true;

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private AdminProcesses adminProcesses = new AdminProcesses();
        private AccountProcesses accountProcesses = new AccountProcesses();
        
        public Form_Admin_Main()
        {
            InitializeComponent();

            GetAllAdminsInfo();
            
         }

        internal void ClearCardsButFirst()
        {
            var x = fLPanel_cards.Controls[0];
            fLPanel_cards.Controls.Clear();
            fLPanel_cards.Controls.Add(x);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }




        private void SignUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    if (IsUsernameNotUsedBefor() == true)
                    {//check that Username not used befor
                        InsertAdminDataToAdminTable(); //sucessfully SignUp, new user added !!
                        tb_admin_username.Text = "";
                        // flowLayoutPanel_admin_signup.Visible = false;
                        ClearCardsButFirst();
                        GetAllAdminsInfo();
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
                !tb_admin_email.Text.Equals("")&&
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
                PermissionId = 2,
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
            ClearCardsButFirst();
            GetAllAdminsInfo();
        }
        

        private void InsertAdminDataToAdminTable()
        {
            Models.Account accountAdmin = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_admin_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_admin_password.Text.Trim()),
                PermissionId = 2,
                Email = encryptionDecryptionText.Encryption(tb_admin_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_admin_phone.Text.Trim()),
            };
            
            accountProcesses.Add(accountAdmin);
            int accountAdminId = accountProcesses.GetId(accountAdmin);

            Models.Admin adminInfo = new Models.Admin {
                Name = encryptionDecryptionText.Encryption(tb_admin_name.Text.Trim()),
                AccountId = accountAdminId,
                Account = accountAdmin,
            };

            adminProcesses.Add(adminInfo);
        }

        private void btn_admin_add_Click(object sender, EventArgs e)
        {
            if (isAddProcess) // Add new AdminRoom
            {
                SignUp();
            }
            else //Update exists admin
            {
                UpdateUp();
            }

        }

        private void UpdateUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    UpdateAdminDataToAdminTable();
                }
                else {
                    ShowAlertErrorMessage("Make sure that Passwords are same");
                }
            }
        }

        private void sqlabC_Label1_Click(object sender, EventArgs e)
        {

        }

        private void pb_add_admin_Click(object sender, EventArgs e)
        {
            isAddProcess = true;
            flowLayoutPanel_admin_signup.Visible = true;

            tb_admin_username.Enabled = true;
            tb_admin_username.Text = "";
            tb_admin_password.Text = "";
            tb_admin_confirm_password.Text = "";
            tb_admin_name.Text = "";
            tb_admin_email.Text = "";
            tb_admin_phone.Text = "";
        }






























        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fLPanel_cards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sqlabC_Label2_Click(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label9_Click(object sender, EventArgs e)
        {

        }

        private void sqlabC_Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
