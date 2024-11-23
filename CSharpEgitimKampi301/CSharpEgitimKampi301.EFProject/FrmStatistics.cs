using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        CSharpEgitimKampi301EfDbEntities db = new CSharpEgitimKampi301EfDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayisi
            lblLocationCount.Text = db.Locations.Count().ToString();
            #endregion

            #region Toplam Kapasite Sayisi
            lblSumCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();
            #endregion

            #region Ortalama Kapasite Sayisi
            lblAvgCapacity.Text = String.Format("{0:0.##}", db.Locations.Average(x => x.Capacity));
            #endregion

            #region Rehber Sayisi
            lblGuideCount.Text = db.Guides.Count().ToString();
            #endregion

            #region Ortalama Tur Fiyati
            lblAvgPrice.Text = String.Format("{0:0.00}", db.Locations.Average(i => i.Price)) + " ₺";
            #endregion

            #region En Yeni Lokasyon (En son eklenen lokasyon)
            int lastLocationId = db.Locations.Max(i => i.LocationId);
            lblNewLocation.Text = db.Locations.Where(i => i.LocationId == lastLocationId).Select(i => string.Concat(i.City, "/", i.Country)).FirstOrDefault();
            #endregion

            #region Kapadokya Tur Kapasitesi
            lblCappadociaCapacity.Text = db.Locations.Where(i => i.City == "Kapadokya").Select(i => i.Capacity).FirstOrDefault().ToString();
            #endregion

            #region Turkiye icin Ortalama Tur Kapasitesi
            lblAvgTurkeyCapacity.Text = db.Locations.Where(i => i.Country == "Türkiye").Average(i => i.Capacity).ToString();
            #endregion

            #region Roma Gezi Rehberi
            //var guideId = db.Locations.Where(x => x.City == "Roma").Select(i=>i.GuideId).FirstOrDefault();
            //lblRomeGuideName.Text =db.Guides.Where(i=>i.GuideId == guideId).Select(i=>i.Name + " " + i.Surname).FirstOrDefault();

            lblRomeGuideName.Text = db.Locations.Where(i => i.City == "Roma").Select(i => string.Concat(i.Guide.Name, " ", i.Guide.Surname)).FirstOrDefault();
            #endregion

            #region Max Kapasiteli Tur
            byte maxCapacity = (byte)db.Locations.Max(i => i.Capacity);
            lblMaxCapacityTour.Text = db.Locations.Where(i => i.Capacity == maxCapacity).Select(i => String.Concat(i.City, " (", i.Capacity, ")")).FirstOrDefault();
            #endregion

            #region En Pahali Tur
            decimal mostExpensivePrice = (decimal)db.Locations.Max(i => i.Price);
            lblMostExpTour.Text = db.Locations.Where(i => i.Price == mostExpensivePrice).Select(i => i.City).FirstOrDefault();
            #endregion

            #region Aysegul Cinar'in Tur Sayisi
            //var guideIdByName = db.Guides.Where(x => x.Name == "Ayşegül" && x.Surname == "Çınar").Select(x => x.GuideId).FirstOrDefault();
            //lblAysegulCinarTourCount.Text=db.Locations.Where(x => x.GuideId == guideIdByName).Count().ToString();

            lblAysegulCinarTourCount.Text = db.Locations.Where(i => i.Guide.Name == "Ayşegül" && i.Guide.Surname == "Çınar").Count().ToString();
            #endregion
        }
    }
}
