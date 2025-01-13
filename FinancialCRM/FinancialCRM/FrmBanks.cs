using FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCRMDbEntities db = new FinancialCRMDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // Banka Bakiyeleri..
            decimal? ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(x => x.BankBalance).FirstOrDefault();
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            lblVakifBankBalance.Text = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(x => x.BankBalance).FirstOrDefault().ToString() + " ₺";

            lblIsBankBalance.Text = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(x => x.BankBalance).FirstOrDefault().ToString() + " ₺";

            // Banka Hareketleri - Son 5 Hareket
            var bankProcess1 = db.BankProcesses.OrderByDescending(x=>x.ProcessDate).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount.ToString() + " ₺ " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Skip(1).Take(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount.ToString() + " ₺ " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Skip(2).Take(1).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount.ToString() + " ₺ " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Skip(3).Take(1).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount.ToString() + " ₺ " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Skip(4).Take(1).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount.ToString() + " ₺ " + bankProcess5.ProcessDate;
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }
    }
}
