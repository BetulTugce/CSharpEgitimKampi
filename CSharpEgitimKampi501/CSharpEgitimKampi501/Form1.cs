using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=BETUL;initial Catalog=CSharpEgitimKampi501Db;integrated security=true;");

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Toplam kitap sayisi
            string queryTotalCount = "Select count(*) from TblProduct";
            lblTotalProductCount.Text = (await connection.QueryFirstOrDefaultAsync<int>(queryTotalCount)).ToString();
            #endregion

            #region En Pahali Kitap
            string queryExpPrice = "select ProductName from TblProduct where ProductPrice = (select max(ProductPrice) from TblProduct)";
            lblExpProduct.Text = await connection.QueryFirstOrDefaultAsync<string>(queryExpPrice);
            #endregion

            #region Kac Farkli Kategori Var?
            string queryCategoryCount = "Select count(distinct(ProductCategory)) from TblProduct";
            lblCategoryCount.Text = (await connection.QueryFirstOrDefaultAsync<int>(queryCategoryCount)).ToString();
            #endregion
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * from TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct(ProductName, ProductStock, ProductPrice, ProductCategory) values (@name, @stock, @price, @category)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", txtName.Text);
            parameters.Add("@stock", int.Parse(txtStock.Text));
            parameters.Add("@price", decimal.Parse(txtPrice.Text));
            parameters.Add("@category", txtCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap başarıyla eklendi.");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from TblProduct where ProductId = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", txtId.Text);
            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Kitap başarıyla silindi.");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update TblProduct set ProductName=@name, ProductPrice=@price, ProductStock=@stock, ProductCategory=@category where ProductId=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@name", txtName.Text);
            parameters.Add("@stock", int.Parse(txtStock.Text));
            parameters.Add("@price", decimal.Parse(txtPrice.Text));
            parameters.Add("@category", txtCategory.Text);
            parameters.Add("@id", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
