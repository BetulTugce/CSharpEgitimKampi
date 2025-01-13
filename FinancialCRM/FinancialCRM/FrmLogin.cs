using FinancialCRM.Models;
using FinancialCRM.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Bos kontrolu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (FinancialCRMDbEntities db = new FinancialCRMDbEntities())
            {
                // Parola sifrelenerek veritabaninda kullanici kontrol ediliyor..
                string hashedPassword = PasswordHelper.HashPassword(password);
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);

                if (user != null)
                {
                    // Anasayfaya gecis..
                    FrmDashboard dashboard = new FrmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
