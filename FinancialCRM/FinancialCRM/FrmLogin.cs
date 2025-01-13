using FinancialCRM.Models;
using FinancialCRM.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace FinancialCRM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public string GetAdminPassword()
        {
            return ConfigurationManager.AppSettings["AdminPassword"];
        }

        public string GetAdminUsername()
        {
            return ConfigurationManager.AppSettings["AdminUsername"];
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string username = GetAdminUsername();
            // Uygulama ilk ayaga kalktiginda veritabanından kullanicinin silinme ihtimaline karsilik ilk olarak kullanici var mi yok mu kontrol ediyorum. Sonrasında kullanici bulunamadıysa ekliyorum..
            FinancialCRMDbEntities db = new FinancialCRMDbEntities();
            var user = db.Users.Where(u => u.Username == username).FirstOrDefault();
            if (user == null)
            {
                User newUser = new User();
                // Username ve password bilgilerini guvenlik icin App.config dosyasından cekiyorum..
                newUser.Username = GetAdminUsername();
                string adminPassword = GetAdminPassword();
                newUser.Password = PasswordHelper.HashPassword(adminPassword);
                db.Users.Add(newUser);
                db.SaveChanges();
            }
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
