/*
Application Name        : Dollar Computers
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a 
                          wide range of computers and laptops along with hardware components. 
                          Open box laptops and computers are also available.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        public SplashForm previousForm;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            //opening select form when start button is clicked
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            //open product info form when open button is clicked
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
            productInfoForm.loadData();
            this.Hide();
        }

        //exit the application on pressing exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //closing previous form
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
