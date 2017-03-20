using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public StartForm previousForm;
        ProductContext productDB = new ProductContext();

        public SelectForm PreviousForm;
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            var selectedProduct = (from product in productDB.products
                                       where product.productID == Property.productId
                                       select product).FirstOrDefault();

            ProductIdTextBox.Text = selectedProduct.productID.ToString();
            ConditionTextBox.Text = selectedProduct.condition;
            CostTextBox.Text = "$"+selectedProduct.cost.ToString();

            List<String> productInfoList = new List<string>();

            productInfoList.Add(selectedProduct.model);
            productInfoList.Add(selectedProduct.OS);
            productInfoList.Add(selectedProduct.manufacturer);
            productInfoList.Add(selectedProduct.platform);

            int count = 0; 
            foreach(var textBox in ProductInfoGroupBox.Controls.OfType<TextBox>()) {
                textBox.Text = productInfoList[count];
                count++;
            }


            List<String> techSpecs = new List<string>();

            techSpecs.Add(selectedProduct.webcam);
            techSpecs.Add(selectedProduct.GPU_Type);
            techSpecs.Add(selectedProduct.HDD_size);
            techSpecs.Add(selectedProduct.CPU_speed);
            techSpecs.Add(selectedProduct.CPU_type);
            techSpecs.Add(selectedProduct.CPU_number);
            techSpecs.Add(selectedProduct.screensize);
            techSpecs.Add(selectedProduct.CPU_brand);
            techSpecs.Add(selectedProduct.RAM_size);

            int flag = 0;
            foreach (var textBox in TechSpecsGroupBox.Controls.OfType<TextBox>()) {
                textBox.Text = techSpecs[flag];
                flag++;
            }


        }
    }
}
