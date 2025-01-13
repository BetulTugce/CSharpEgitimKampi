using FinancialCRM.Models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCRMDbEntities db = new FinancialCRMDbEntities();

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide(); // Formu arka planda gizliyor yani form kapanmiyor. RAMde yer kapliyor.
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

        private void CategoryList()
        {
            var values = db.Categories.Select(x=> new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CategoryList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var removeValue = db.Categories.Find(int.Parse(txtId.Text));
                db.Categories.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Kategori silindi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var category = db.Categories.Find(int.Parse(txtId.Text));
                category.CategoryName = txtName.Text;
                db.Categories.AddOrUpdate(category);
                db.SaveChanges();
                MessageBox.Show("Kategori güncellendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CategoryList();
            }
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }
    }
}
