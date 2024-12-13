using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using System;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {

        //ProductManager productManager = new ProductManager(new EfProductDal());

        private readonly IProductService _productService;

        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());

            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _productService.TDelete(_productService.TGetById(id));
            MessageBox.Show("Silme işlemi tamamlandı!");
        }
    }
}
