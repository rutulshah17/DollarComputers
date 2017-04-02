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

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            //showing values of the user from the Property class
            ConditionTextBox.Text = UserProduct.condition;
            PlatformTextBox.Text = UserProduct.platform;
            if (UserProduct.platform == "Desktop PC")
            {
                LaptopDesktopPictureBox.Image = Properties.Resources.desktop;
            }
            else
            {
                LaptopDesktopPictureBox.Image = Properties.Resources.laptop;
            }
            manufacturerTextBox.Text = UserProduct.manufacturer;
            ModelTextBox.Text = UserProduct.model;

            PriceTextBox.Text = UserProduct.cost.ToString();

            OrderFormListBox.Items.Add(UserProduct.screensize.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.RAM_size.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.CPU_brand.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.CPU_type.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.CPU_number.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.CPU_speed.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.HDD_size.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.GPU_Type.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.webcam.ToString());
            OrderFormListBox.Items.Add("\n");
            OrderFormListBox.Items.Add(UserProduct.OS.ToString());



            SalesTaxTextBox.Text = (Convert.ToDouble(PriceTextBox.Text) * 0.13).ToString();

            TotalTextBox.Text = (Convert.ToDouble(PriceTextBox.Text) * 1.13).ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show about box on click
            AboutBox aboutForm = new AboutBox();
            aboutForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show print message on click
            MessageBox.Show("Your order is sent for print", "Print !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing Dollar Computers", " ", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
