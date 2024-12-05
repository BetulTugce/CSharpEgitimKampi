using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());

            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            dataGridView1.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtName.Text;
            category.Status = rdbActive.Checked;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _categoryService.TDelete(_categoryService.TGetById(id));
            MessageBox.Show("Silme işlemi tamamlandı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedCategory = _categoryService.TGetById(int.Parse(txtId.Text));
            updatedCategory.Name = txtName.Text;
            updatedCategory.Status = rdbActive.Checked;
            _categoryService.TUpdate(updatedCategory);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { category };
        }
    }
}
