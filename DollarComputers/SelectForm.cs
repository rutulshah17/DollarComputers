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
    public partial class SelectForm : Form
    {
        public Form previousForm;

        ProductContext productDB = new ProductContext();
        public SelectForm()
        {
            InitializeComponent();
        }

        //next button will take us to display product info page 
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_comp1004_w2017DataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this._comp1004_w2017DataSet.products);

            try
            {
                //serching for the list of products in database
                var productList = (from products in productDB.products
                                   select products).ToList();

                //storing the list in datasource
                SelectFormDataGridView.DataSource = productList;
            }
            catch (Exception exception)
            {
                //showing error if any
                Debug.WriteLine(exception.Message);
            }
        }

        private void SelectFormDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //getting current index of the selected row
            int rowindex = SelectFormDataGridView.CurrentRow.Index;
            Debug.WriteLine(rowindex);

            //getting id of the selected cell
            short currentId = (short)SelectFormDataGridView.Rows[rowindex].Cells[0].Value;
            SelectFormDataGridView.Rows[rowindex].Selected = true;
            try
            {
                //getting the desired product from the database
                var SelectedProduct = (from product in productDB.products
                                       where product.productID == currentId
                                       select product).FirstOrDefault();

                //showing it to user
                YourSelectionTextBox.Text = SelectedProduct.model + " " + SelectedProduct.manufacturer + " Priced at : " + "$" + SelectedProduct.cost;
                UserProduct.productID = SelectedProduct.productID;
                UserProduct.condition = SelectedProduct.condition;
                UserProduct.cost = SelectedProduct.cost;
                UserProduct.platform = SelectedProduct.platform;
                UserProduct.OS = SelectedProduct.OS;
                UserProduct.manufacturer = SelectedProduct.manufacturer;
                UserProduct.model = SelectedProduct.model;
                UserProduct.RAM_size = SelectedProduct.RAM_size;
                UserProduct.screensize = SelectedProduct.screensize;
                UserProduct.HDD_size = SelectedProduct.HDD_size;
                UserProduct.CPU_brand = SelectedProduct.CPU_brand;
                UserProduct.CPU_number = SelectedProduct.CPU_number;
                UserProduct.GPU_Type = SelectedProduct.GPU_Type;
                UserProduct.CPU_type = SelectedProduct.CPU_type;
                UserProduct.CPU_speed = SelectedProduct.CPU_speed;
                UserProduct.webcam = SelectedProduct.webcam;
                NextButton.Enabled = true;
            }
            catch (Exception exception)
            {
                //throw exception if any
                Debug.WriteLine(exception.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
