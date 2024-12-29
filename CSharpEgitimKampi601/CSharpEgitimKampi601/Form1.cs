using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        CustomerOperations customerOperations = new CustomerOperations();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                CustomerBalance = decimal.Parse(txtBalance.Text),
                CustomerCity = txtCity.Text,
                CustomerShoppingCount = int.Parse(txtShoppingCount.Text),
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("İşlem başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetCustomers();
            dataGridView1.DataSource = customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("İşlem başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateCustomer = new Customer()
            {
                CustomerId = txtId.Text,
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                CustomerCity = txtCity.Text,
                CustomerBalance = decimal.Parse(txtBalance.Text),
                CustomerShoppingCount = int.Parse(txtShoppingCount.Text),
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("İşlem başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            Customer customer = customerOperations.GetCustomerById(txtId.Text);
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}
