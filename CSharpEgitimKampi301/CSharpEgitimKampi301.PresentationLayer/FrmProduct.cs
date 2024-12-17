using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {

        //ProductManager productManager = new ProductManager(new EfProductDal());

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = categories;
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

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = new List<Product> { value };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Price = decimal.Parse(txtPrice.Text);
            product.Stock = int.Parse(txtStock.Text);
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedProduct = _productService.TGetById(int.Parse(txtId.Text));
            updatedProduct.Name = txtName.Text;
            updatedProduct.Description = txtDescription.Text;
            updatedProduct.Price = decimal.Parse(txtPrice.Text);
            updatedProduct.Stock = int.Parse(txtStock.Text);
            updatedProduct.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TUpdate(updatedProduct);
        }
    }
}
