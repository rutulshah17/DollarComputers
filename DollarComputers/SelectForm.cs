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
        public StartForm previousForm;

        ProductContext productDB = new ProductContext();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.PreviousForm = this;
            productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_comp1004_w2017DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._comp1004_w2017DataSet.products);

            try
            {
                var productList = (from products in productDB.products
                               select products).ToList();

                SelectFormDataGridView.DataSource = productList;
            }
            catch(Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        private void SelectFormDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = SelectFormDataGridView.CurrentRow.Index;
            short currentId = (short)SelectFormDataGridView.Rows[rowindex].Cells[0].Value;
            
            try
            {
                var SelectedProduct = (from product in productDB.products
                                       where product.productID == currentId
                                       select product).FirstOrDefault();

                YourSelectionTextBox.Text = SelectedProduct.model + " " + SelectedProduct.manufacturer + " Priced at : " + "$" + SelectedProduct.cost;
            
                Property.productId = SelectedProduct.productID;
            }
            catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                }
            }
    }
}
