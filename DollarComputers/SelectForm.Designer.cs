namespace DollarComputers
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFormDataGridView = new System.Windows.Forms.DataGridView();
            this.DollarComputerHardwareListLabel = new System.Windows.Forms.Label();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFGColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCDSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUBrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPUTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebCamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormDataGridView
            // 
            this.SelectFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.CostColumn,
            this.MFGColumn,
            this.ModelColumn,
            this.MemoryColumn,
            this.LCDSizeColumn,
            this.CPUBrandColumn,
            this.CPUTypeColumn,
            this.CPUNumberColumn,
            this.CPUSpeedColumn,
            this.ConditionColumn,
            this.OSColumn,
            this.PlatformColumn,
            this.HDDColumn,
            this.GPUTypeColumn,
            this.WebCamColumn});
            this.SelectFormDataGridView.Location = new System.Drawing.Point(12, 32);
            this.SelectFormDataGridView.Name = "SelectFormDataGridView";
            this.SelectFormDataGridView.Size = new System.Drawing.Size(737, 295);
            this.SelectFormDataGridView.TabIndex = 0;
            // 
            // DollarComputerHardwareListLabel
            // 
            this.DollarComputerHardwareListLabel.AutoSize = true;
            this.DollarComputerHardwareListLabel.BackColor = System.Drawing.Color.White;
            this.DollarComputerHardwareListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarComputerHardwareListLabel.Location = new System.Drawing.Point(12, 13);
            this.DollarComputerHardwareListLabel.Name = "DollarComputerHardwareListLabel";
            this.DollarComputerHardwareListLabel.Size = new System.Drawing.Size(219, 16);
            this.DollarComputerHardwareListLabel.TabIndex = 1;
            this.DollarComputerHardwareListLabel.Text = "Dollar Computer Hardware List";
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // CostColumn
            // 
            this.CostColumn.HeaderText = "Cost";
            this.CostColumn.Name = "CostColumn";
            // 
            // MFGColumn
            // 
            this.MFGColumn.HeaderText = "MFG";
            this.MFGColumn.Name = "MFGColumn";
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            // 
            // MemoryColumn
            // 
            this.MemoryColumn.HeaderText = "Memory";
            this.MemoryColumn.Name = "MemoryColumn";
            // 
            // LCDSizeColumn
            // 
            this.LCDSizeColumn.HeaderText = "LCD Size";
            this.LCDSizeColumn.Name = "LCDSizeColumn";
            // 
            // CPUBrandColumn
            // 
            this.CPUBrandColumn.HeaderText = "CPU Brand";
            this.CPUBrandColumn.Name = "CPUBrandColumn";
            // 
            // CPUTypeColumn
            // 
            this.CPUTypeColumn.HeaderText = "CPU Type";
            this.CPUTypeColumn.Name = "CPUTypeColumn";
            // 
            // CPUNumberColumn
            // 
            this.CPUNumberColumn.HeaderText = "CPU #";
            this.CPUNumberColumn.Name = "CPUNumberColumn";
            // 
            // CPUSpeedColumn
            // 
            this.CPUSpeedColumn.HeaderText = "CPU Speed";
            this.CPUSpeedColumn.Name = "CPUSpeedColumn";
            // 
            // ConditionColumn
            // 
            this.ConditionColumn.HeaderText = "Condition";
            this.ConditionColumn.Name = "ConditionColumn";
            // 
            // OSColumn
            // 
            this.OSColumn.HeaderText = "OS";
            this.OSColumn.Name = "OSColumn";
            // 
            // PlatformColumn
            // 
            this.PlatformColumn.HeaderText = "Platform";
            this.PlatformColumn.Name = "PlatformColumn";
            // 
            // HDDColumn
            // 
            this.HDDColumn.HeaderText = "HDD";
            this.HDDColumn.Name = "HDDColumn";
            // 
            // GPUTypeColumn
            // 
            this.GPUTypeColumn.HeaderText = "GPU Type";
            this.GPUTypeColumn.Name = "GPUTypeColumn";
            // 
            // WebCamColumn
            // 
            this.WebCamColumn.HeaderText = "WebCam";
            this.WebCamColumn.Name = "WebCamColumn";
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(15, 351);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(109, 16);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionTextBox.Location = new System.Drawing.Point(130, 348);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.ReadOnly = true;
            this.YourSelectionTextBox.Size = new System.Drawing.Size(277, 22);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(559, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(674, 346);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 387);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.DollarComputerHardwareListLabel);
            this.Controls.Add(this.SelectFormDataGridView);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectFormDataGridView;
        private System.Windows.Forms.Label DollarComputerHardwareListLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFGColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCDSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUBrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPUTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebCamColumn;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}