using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;

        double TotalSalesTax = 0.13;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           
            ConditionTextBox.Text = Property.condition;
            PlatformTextBox.Text = Property.platform;
            manufacturerTextBox.Text = Property.manufacturer;
            ModelTextBox.Text = Property.model;

            PriceTextBox.Text = Property.cost.ToString();

            OrderFormListBox.Items.Add(Property.screensize.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.RAM_size.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.CPU_brand.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.CPU_type.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.CPU_number.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.CPU_speed.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.HDD_size.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.GPU_Type.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.webcam.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(Property.OS.ToString());

            
            
            SalesTaxTextBox.Text = (Convert.ToDouble(PriceTextBox.Text) * TotalSalesTax).ToString();

            TotalTextBox.Text = PriceTextBox.Text + SalesTaxTextBox.Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is sent for print","Print !",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
