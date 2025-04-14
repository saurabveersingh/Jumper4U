namespace Jumper4U
{
    partial class SalesReportForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            salesReportBackground = new PictureBox();
            salesReportPanel = new Panel();
            totalSalesLabel = new Label();
            closeButton = new Button();
            saveButton = new Button();
            color1 = new Label();
            color3 = new Label();
            color2 = new Label();
            color2Label = new Label();
            color3Label = new Label();
            color1Label = new Label();
            SalesData = new DataGridView();
            salesReportoolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)salesReportBackground).BeginInit();
            salesReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesData).BeginInit();
            SuspendLayout();
            // 
            // salesReportBackground
            // 
            salesReportBackground.Image = (Image)resources.GetObject("salesReportBackground.Image");
            salesReportBackground.Location = new Point(-1, -1);
            salesReportBackground.Name = "salesReportBackground";
            salesReportBackground.Size = new Size(1600, 1200);
            salesReportBackground.TabIndex = 1;
            salesReportBackground.TabStop = false;
            // 
            // salesReportPanel
            // 
            salesReportPanel.BackColor = Color.BlanchedAlmond;
            salesReportPanel.Controls.Add(totalSalesLabel);
            salesReportPanel.Controls.Add(closeButton);
            salesReportPanel.Controls.Add(saveButton);
            salesReportPanel.Controls.Add(color1);
            salesReportPanel.Controls.Add(color3);
            salesReportPanel.Controls.Add(color2);
            salesReportPanel.Controls.Add(color2Label);
            salesReportPanel.Controls.Add(color3Label);
            salesReportPanel.Controls.Add(color1Label);
            salesReportPanel.Controls.Add(SalesData);
            salesReportPanel.Location = new Point(100, 200);
            salesReportPanel.Name = "salesReportPanel";
            salesReportPanel.Size = new Size(1400, 800);
            salesReportPanel.TabIndex = 10;
            // 
            // totalSalesLabel
            // 
            totalSalesLabel.AutoSize = true;
            totalSalesLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            totalSalesLabel.ForeColor = Color.DarkRed;
            totalSalesLabel.Location = new Point(600, 575);
            totalSalesLabel.Name = "totalSalesLabel";
            totalSalesLabel.Size = new Size(246, 45);
            totalSalesLabel.TabIndex = 3;
            totalSalesLabel.Text = "Total Sales: $0";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Brown;
            closeButton.FlatAppearance.BorderColor = Color.DarkRed;
            closeButton.FlatAppearance.BorderSize = 5;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            closeButton.ForeColor = Color.FromArgb(255, 255, 192);
            closeButton.Location = new Point(775, 700);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(225, 52);
            closeButton.TabIndex = 1;
            closeButton.Text = "&Close";
            salesReportoolTip.SetToolTip(closeButton, "Go back to Admin Menu");
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Brown;
            saveButton.FlatAppearance.BorderColor = Color.DarkRed;
            saveButton.FlatAppearance.BorderSize = 5;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            saveButton.ForeColor = Color.FromArgb(255, 255, 192);
            saveButton.Location = new Point(450, 700);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(275, 52);
            saveButton.TabIndex = 0;
            saveButton.Text = "&Save as Text File";
            salesReportoolTip.SetToolTip(saveButton, "Get output in Documents Folder");
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // color1
            // 
            color1.AutoSize = true;
            color1.BackColor = Color.Red;
            color1.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color1.ForeColor = Color.DarkRed;
            color1.Location = new Point(425, 635);
            color1.Name = "color1";
            color1.Size = new Size(49, 37);
            color1.TabIndex = 4;
            color1.Text = "    ";
            // 
            // color3
            // 
            color3.AutoSize = true;
            color3.BackColor = Color.Green;
            color3.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color3.ForeColor = Color.DarkRed;
            color3.Location = new Point(825, 635);
            color3.Name = "color3";
            color3.Size = new Size(49, 37);
            color3.TabIndex = 8;
            color3.Text = "    ";
            // 
            // color2
            // 
            color2.AutoSize = true;
            color2.BackColor = Color.Orange;
            color2.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color2.ForeColor = Color.DarkRed;
            color2.Location = new Point(620, 635);
            color2.Name = "color2";
            color2.Size = new Size(49, 37);
            color2.TabIndex = 6;
            color2.Text = "    ";
            // 
            // color2Label
            // 
            color2Label.AutoSize = true;
            color2Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color2Label.ForeColor = Color.DarkRed;
            color2Label.Location = new Point(670, 635);
            color2Label.Name = "color2Label";
            color2Label.Size = new Size(133, 37);
            color2Label.TabIndex = 7;
            color2Label.Text = "Low Sale";
            // 
            // color3Label
            // 
            color3Label.AutoSize = true;
            color3Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color3Label.ForeColor = Color.DarkRed;
            color3Label.Location = new Point(875, 635);
            color3Label.Name = "color3Label";
            color3Label.Size = new Size(142, 37);
            color3Label.TabIndex = 9;
            color3Label.Text = "High Sale";
            // 
            // color1Label
            // 
            color1Label.AutoSize = true;
            color1Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color1Label.ForeColor = Color.DarkRed;
            color1Label.Location = new Point(475, 635);
            color1Label.Name = "color1Label";
            color1Label.Size = new Size(117, 37);
            color1Label.TabIndex = 5;
            color1Label.Text = "No Sale";
            // 
            // SalesData
            // 
            SalesData.AllowUserToAddRows = false;
            SalesData.AllowUserToDeleteRows = false;
            SalesData.AllowUserToResizeColumns = false;
            SalesData.AllowUserToResizeRows = false;
            SalesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesData.Location = new Point(50, 50);
            SalesData.MultiSelect = false;
            SalesData.Name = "SalesData";
            SalesData.ReadOnly = true;
            SalesData.RowHeadersWidth = 82;
            SalesData.Size = new Size(1300, 500);
            SalesData.TabIndex = 2;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 1199);
            Controls.Add(salesReportPanel);
            Controls.Add(salesReportBackground);
            Name = "SalesReportForm";
            Text = "Current Session Sales Report";
            Load += SalesReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)salesReportBackground).EndInit();
            salesReportPanel.ResumeLayout(false);
            salesReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox salesReportBackground;
        private Panel salesReportPanel;
        private DataGridView SalesData;
        private Label color1;
        private Label color3;
        private Label color2;
        private Label color2Label;
        private Label color3Label;
        private Label color1Label;
        private Button closeButton;
        private Button saveButton;
        private Label totalSalesLabel;
        private ToolTip salesReportoolTip;
    }
}