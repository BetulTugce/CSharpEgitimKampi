using FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCRM
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCRMDbEntities db = new FinancialCRMDbEntities();
        int count = 0;

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide(); // Formu arka planda gizliyor yani form kapanmiyor. RAMde yer kapliyor.
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            this.Hide();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            // En son gelen havalenin tutari..
            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBPAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            #region Chart1
            //bankData icerisine bankalarin isim ve bakiyesi ekleniyor..
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            // Chartin ismi..
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var item in bankData) 
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
            #endregion

            #region Chart2
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var electricityBill = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = electricityBill.ToString() + " ₺";
            }
            else if (count % 4 == 2)
            {
                var gasBill = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = gasBill.ToString() + " ₺";
            }
            else if (count % 4 == 3)
            {
                var waterBill = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = waterBill.ToString() + " ₺";
            }
            else if (count % 4 == 0)
            {
                var internetBill = db.Bills.Where(x => x.BillTitle == "Internet Faturası").Select(x => x.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet Faturası";
                lblBillAmount.Text = internetBill.ToString() + " ₺";
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
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
