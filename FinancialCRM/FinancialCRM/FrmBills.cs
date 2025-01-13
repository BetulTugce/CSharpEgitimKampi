using FinancialCRM.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        FinancialCRMDbEntities db = new FinancialCRMDbEntities();

        private void FrmBills_Load(object sender, EventArgs e)
        {
            BillList();
        }

        private void BillList()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            BillList();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.BillTitle = txtBillTitle.Text;
            bill.BillAmount = decimal.Parse(txtBillAmount.Text);
            bill.BillPeriod = txtBillPeriod.Text;
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Ödeme eklendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BillList();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            var removeValue = db.Bills.Find(int.Parse(txtBillId.Text));
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BillList();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            var bill = db.Bills.Find(int.Parse(txtBillId.Text));
            bill.BillTitle = txtBillTitle.Text;
            bill.BillAmount = decimal.Parse(txtBillAmount.Text);
            bill.BillPeriod = txtBillPeriod.Text;
            db.Bills.AddOrUpdate(bill);
            db.SaveChanges();
            MessageBox.Show("Ödeme güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BillList();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide(); // Formu arka planda gizliyor yani form kapanmiyor. RAMde yer kapliyor.
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
    }
}
