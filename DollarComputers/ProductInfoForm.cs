/*
Application Name        : Dollar Computers
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a 
                          wide range of computers and laptops along with hardware components. 
                          Open box laptops and computers are also available.
*/
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

        //creating an instance of the product database
        ProductContext productDB = new ProductContext();

        public SelectForm PreviousForm;
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        //nect button will take us to order form
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }

        
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //quering database on loading product form
            var selectedProduct = (from product in productDB.products
                                       where product.productID == Property.productID
                                       select product).FirstOrDefault();

            //showing values to the user 
            ProductIdTextBox.Text = selectedProduct.productID.ToString();
            ConditionTextBox.Text = selectedProduct.condition;
            CostTextBox.Text = "$"+selectedProduct.cost.ToString();


            List<String> productInfoList = new List<string>();

            //adding value to list
            productInfoList.Add(selectedProduct.model);
            productInfoList.Add(selectedProduct.OS);
            productInfoList.Add(selectedProduct.manufacturer);
            productInfoList.Add(selectedProduct.platform);

            int count = 0; 
            //will show user remaining values
            foreach(var textBox in ProductInfoGroupBox.Controls.OfType<TextBox>()) {
                textBox.Text = productInfoList[count];
                count++;
            }


            List<String> techSpecs = new List<string>();

            //adding techspecs values
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


            //storing all the values of the selected product in property class so that we can access it on next page
            Property.productID = selectedProduct.productID;
            Property.condition = selectedProduct.condition;
            Property.cost = selectedProduct.cost;
            Property.platform = selectedProduct.platform;
            Property.manufacturer = selectedProduct.manufacturer;
            Property.OS = selectedProduct.OS;
            Property.model = selectedProduct.model;
            Property.RAM_size = selectedProduct.RAM_size;
            Property.CPU_brand = selectedProduct.CPU_brand;
            Property.CPU_type = selectedProduct.CPU_type;
            Property.screensize = selectedProduct.screensize;
            Property.CPU_number = selectedProduct.CPU_number;
            Property.CPU_speed = selectedProduct.CPU_speed;
            Property.HDD_size = selectedProduct.HDD_size;
            Property.GPU_Type = selectedProduct.GPU_Type;
            Property.webcam = selectedProduct.webcam;


        }
    }
}
