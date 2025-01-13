using FinancialCRM.Models;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCRMDbEntities db = new FinancialCRMDbEntities();

        private void SpendingList()
        {
            var values = db.Spendings.Select(s => new
            {
                Id = s.SpendingId,
                Başlık = s.SpendingTitle,
                Tutar = s.SpendingAmount,
                Tarih = s.SpendingDate,
                Kategori = s.Category.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            // Harcamalarin listesi..
            SpendingList();

            // ComboBox için kategoriler..
            var categories = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = categories;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SpendingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Spending spending = new Spending();
            spending.SpendingTitle = txtTitle.Text;
            spending.SpendingDate = DateTime.Parse(dtpSpendingDate.Value.ToString("yyyy-MM-dd"));
            //spending.SpendingDate = DateTime.Parse(txtDate.Text);
            spending.SpendingAmount = decimal.Parse(txtAmount.Text);
            spending.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Harcama eklendi.", "Giderler/Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var spending = db.Spendings.Find(int.Parse(txtId.Text));
                spending.SpendingTitle = txtTitle.Text;
                spending.SpendingDate = DateTime.Parse(dtpSpendingDate.Value.ToString("yyyy-MM-dd"));
                //spending.SpendingDate = DateTime.Parse(txtDate.Text);
                spending.SpendingAmount = decimal.Parse(txtAmount.Text);
                spending.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
                db.Spendings.AddOrUpdate(spending);
                db.SaveChanges();
                MessageBox.Show("Harcama güncellendi.", "Giderler/Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SpendingList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var removeValue = db.Spendings.Find(int.Parse(txtId.Text));
                db.Spendings.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Harcama silindi.", "Giderler/Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SpendingList();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
