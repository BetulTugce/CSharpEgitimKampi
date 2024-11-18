using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CSharpEgitimKampi301EfDbEntities db = new CSharpEgitimKampi301EfDbEntities();

        private void btnGetByGuideId_Click(object sender, EventArgs e)
        {
            var guides = db.Guides.Where(x => x.GuideId.ToString().Contains(txtId.Text)).ToList();
            dataGridView1.DataSource = guides;
        }

        private void btnGetAllGuides_Click(object sender, EventArgs e)
        {
            var guides = db.Guides.ToList();
            dataGridView1.DataSource = guides;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            // textboxlardaki degerleri Guide sınıfından turetilen nesne orneginin ilgili propertylerine atar.
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.Guides.Add(guide); // Olusturulan guide veritabanina eklenir.
            db.SaveChanges(); // Degisikleri veritabanina kaydeder.
            MessageBox.Show("Rehber başarıyla eklendi.");

            btnGetAllGuides_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var guide = db.Guides.Find(int.Parse(txtId.Text));
            db.Guides.Remove(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");

            btnGetAllGuides_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var guide = db.Guides.Find(int.Parse(txtId.Text));
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            btnGetAllGuides_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGetAllGuides_Click(sender, e);
        }
    }
}
