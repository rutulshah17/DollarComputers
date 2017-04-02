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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public Form previousForm;
        private StreamWriter _writer;
        private StreamReader _reader;

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
            //showing values to the user 
            ProductIdTextBox.Text = UserProduct.productID.ToString();
            ConditionTextBox.Text = UserProduct.condition;
            CostTextBox.Text = UserProduct.cost.ToString();


            List<String> productInfoList = new List<string>();

            //adding value to list
            productInfoList.Add(UserProduct.model);
            productInfoList.Add(UserProduct.OS);
            productInfoList.Add(UserProduct.manufacturer);
            productInfoList.Add(UserProduct.platform);

            int count = 0;
            //will show user remaining values
            foreach (var textBox in ProductInfoGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = productInfoList[count];
                count++;
            }


            List<String> techSpecs = new List<string>();

            //adding techspecs values
            techSpecs.Add(UserProduct.webcam);
            techSpecs.Add(UserProduct.GPU_Type);
            techSpecs.Add(UserProduct.HDD_size);
            techSpecs.Add(UserProduct.CPU_speed);
            techSpecs.Add(UserProduct.CPU_type);
            techSpecs.Add(UserProduct.CPU_number);
            techSpecs.Add(UserProduct.screensize);
            techSpecs.Add(UserProduct.CPU_brand);
            techSpecs.Add(UserProduct.RAM_size);

            int flag = 0;
            foreach (var textBox in TechSpecsGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = techSpecs[flag];
                flag++;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string filename;
            OpenProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            OpenProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenProductFileDialog.FileName = "Product.txt";
            if (OpenProductFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = OpenProductFileDialog.FileName;
                try
                {
                    this._reader = new StreamReader(filename);

                    if (this._reader.Peek() != -1)
                    {
                        ProductIdTextBox.Text = this._reader.ReadLine();
                        ConditionTextBox.Text = this._reader.ReadLine();
                        CostTextBox.Text = this._reader.ReadLine();
                        PlatformTextBox.Text = this._reader.ReadLine();
                        OSTextBox.Text = this._reader.ReadLine();
                        ManufacturerTextBox.Text = this._reader.ReadLine();
                        ModelTextBox.Text = this._reader.ReadLine();
                        MemoryTextBox.Text = this._reader.ReadLine();
                        LCDSizeTextBox.Text = this._reader.ReadLine();
                        HDDTextBox.Text = this._reader.ReadLine();
                        CPUBrandTextBox.Text = this._reader.ReadLine();
                        CPUNumberTextBox.Text = this._reader.ReadLine();
                        GPUTypeTextBox.Text = this._reader.ReadLine();
                        CPUTypeTextBox.Text = this._reader.ReadLine();
                        CPUSpeedTextBox.Text = this._reader.ReadLine();
                        WebCamTextBox.Text = this._reader.ReadLine();
                        UserProduct.productID = short.Parse(ProductIdTextBox.Text);
                        UserProduct.condition = ConditionTextBox.Text;
                        UserProduct.cost = Convert.ToDecimal(CostTextBox.Text);
                        UserProduct.platform = PlatformTextBox.Text;
                        UserProduct.OS = OSTextBox.Text;
                        UserProduct.manufacturer = ManufacturerTextBox.Text;
                        UserProduct.model = ModelTextBox.Text;
                        UserProduct.RAM_size = MemoryTextBox.Text;
                        UserProduct.screensize = LCDSizeTextBox.Text;
                        UserProduct.HDD_size = HDDTextBox.Text;
                        UserProduct.CPU_brand = CPUBrandTextBox.Text;
                        UserProduct.CPU_number = CPUNumberTextBox.Text;
                        UserProduct.GPU_Type = GPUTypeTextBox.Text;
                        UserProduct.CPU_type = CPUTypeTextBox.Text;
                        UserProduct.CPU_speed = CPUSpeedTextBox.Text;
                        UserProduct.webcam = WebCamTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("File Empty - No data to Read", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this._reader.Close();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.ToString());
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error Reading File", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            SaveProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            SaveProductFileDialog.FileName = "Product.txt";
            SaveProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (SaveProductFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = SaveProductFileDialog.FileName;
                try
                {
                    this._writer = new StreamWriter(filename);
                    this._writer.WriteLine(ProductIdTextBox.Text);
                    this._writer.WriteLine(ConditionTextBox.Text);
                    this._writer.WriteLine(CostTextBox.Text);
                    this._writer.WriteLine(PlatformTextBox.Text);
                    this._writer.WriteLine(OSTextBox.Text);
                    this._writer.WriteLine(ManufacturerTextBox.Text);
                    this._writer.WriteLine(ModelTextBox.Text);
                    this._writer.WriteLine(MemoryTextBox.Text);
                    this._writer.WriteLine(LCDSizeTextBox.Text);
                    this._writer.WriteLine(HDDTextBox.Text);
                    this._writer.WriteLine(CPUBrandTextBox.Text);
                    this._writer.WriteLine(CPUNumberTextBox.Text);
                    this._writer.WriteLine(GPUTypeTextBox.Text);
                    this._writer.WriteLine(CPUTypeTextBox.Text);
                    this._writer.WriteLine(CPUSpeedTextBox.Text);
                    this._writer.WriteLine(WebCamTextBox.Text);
                    this._writer.Close();
                    MessageBox.Show("File Written Successfully", "File Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error  Writing File", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Close();
        }
    }
}
