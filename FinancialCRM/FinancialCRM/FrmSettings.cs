using FinancialCRM.Models;
using FinancialCRM.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string oldPassword = txtOldPassword.Text.Trim(); // Eski parola
            string newPassword = txtNewPassword.Text.Trim(); // Yeni parola

            // Validasyon (bos kontrolu)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FinancialCRMDbEntities db = new FinancialCRMDbEntities())
            {
                // Eski parolayi hashleyip kontrolden geciriyorum..
                string hashedOldPassword = PasswordHelper.HashPassword(oldPassword);
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedOldPassword);

                if (user == null)
                {
                    MessageBox.Show("Eski parola hatalı veya kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni parolayi hashliyorum..
                string hashedNewPassword = PasswordHelper.HashPassword(newPassword);

                // Parolayi guncelliyorum..
                user.Password = hashedNewPassword;

                // Veritabanina kaydediyorum..
                db.SaveChanges();
                MessageBox.Show("Parola başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Textboxlari temizliyorum..
                txtOldPassword.Text = "";
                txtNewPassword.Text = "";
            }
        }
    }
}
