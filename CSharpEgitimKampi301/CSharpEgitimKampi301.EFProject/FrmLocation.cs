using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        CSharpEgitimKampi301EfDbEntities db = new CSharpEgitimKampi301EfDbEntities();

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var locations = db.Locations.ToList();
            dataGridView1.DataSource = locations;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guides = db.Guides.Select(i => new
            {
                FullName = i.Name + " " + i.Surname,
                i.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = guides;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgisi başarıyla kaydedildi.");

            btnGetAll_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var location = db.Locations.Find(int.Parse(txtId.Text));
            db.Locations.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgisi başarıyla silindi.");

            btnGetAll_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var location = db.Locations.Find(int.Parse(txtId.Text));
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgisi başarıyla güncellendi.");

            btnGetAll_Click(sender, e);
        }
    }
}
