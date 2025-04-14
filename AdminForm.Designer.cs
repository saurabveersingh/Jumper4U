namespace Jumper4U
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            adminBackground = new PictureBox();
            cartPanel = new Panel();
            salesReportButton = new Button();
            searchButton = new Button();
            exitButton = new Button();
            manageStockButton = new Button();
            stockReportButton = new Button();
            logoImage = new PictureBox();
            newOrderButton = new Button();
            stockReportPanel = new Panel();
            managePanel = new Panel();
            confirmButton = new Button();
            cancelButton = new Button();
            stockReportLabel = new Label();
            closeButton = new Button();
            saveButton = new Button();
            color1 = new Label();
            color3 = new Label();
            color2 = new Label();
            color2Label = new Label();
            color3Label = new Label();
            color1Label = new Label();
            stockData = new DataGridView();
            adminToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)adminBackground).BeginInit();
            cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            stockReportPanel.SuspendLayout();
            managePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockData).BeginInit();
            SuspendLayout();
            // 
            // adminBackground
            // 
            adminBackground.Image = (Image)resources.GetObject("adminBackground.Image");
            adminBackground.Location = new Point(0, 0);
            adminBackground.Name = "adminBackground";
            adminBackground.Size = new Size(1600, 1200);
            adminBackground.TabIndex = 0;
            adminBackground.TabStop = false;
            // 
            // cartPanel
            // 
            cartPanel.BackColor = Color.BlanchedAlmond;
            cartPanel.Controls.Add(salesReportButton);
            cartPanel.Controls.Add(searchButton);
            cartPanel.Controls.Add(exitButton);
            cartPanel.Controls.Add(manageStockButton);
            cartPanel.Controls.Add(stockReportButton);
            cartPanel.Controls.Add(logoImage);
            cartPanel.Controls.Add(newOrderButton);
            cartPanel.Location = new Point(450, 350);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(700, 500);
            cartPanel.TabIndex = 6;
            // 
            // salesReportButton
            // 
            salesReportButton.BackColor = Color.Brown;
            salesReportButton.FlatAppearance.BorderColor = Color.DarkRed;
            salesReportButton.FlatAppearance.BorderSize = 5;
            salesReportButton.FlatStyle = FlatStyle.Flat;
            salesReportButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            salesReportButton.ForeColor = Color.FromArgb(255, 255, 192);
            salesReportButton.Location = new Point(400, 190);
            salesReportButton.Name = "salesReportButton";
            salesReportButton.Size = new Size(250, 52);
            salesReportButton.TabIndex = 2;
            salesReportButton.Text = "S&ales Report";
            adminToolTip.SetToolTip(salesReportButton, "Generate Sales Report");
            salesReportButton.UseVisualStyleBackColor = false;
            salesReportButton.Click += salesReportButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Brown;
            searchButton.FlatAppearance.BorderColor = Color.DarkRed;
            searchButton.FlatAppearance.BorderSize = 5;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            searchButton.ForeColor = Color.FromArgb(255, 255, 192);
            searchButton.Location = new Point(400, 115);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(250, 52);
            searchButton.TabIndex = 1;
            searchButton.Text = "Sea&rch";
            adminToolTip.SetToolTip(searchButton, "Search in order history");
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Brown;
            exitButton.FlatAppearance.BorderColor = Color.DarkRed;
            exitButton.FlatAppearance.BorderSize = 5;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            exitButton.ForeColor = Color.FromArgb(255, 255, 192);
            exitButton.Location = new Point(400, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(250, 52);
            exitButton.TabIndex = 5;
            exitButton.Text = "E&xit";
            adminToolTip.SetToolTip(exitButton, "Exit application");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // manageStockButton
            // 
            manageStockButton.BackColor = Color.Brown;
            manageStockButton.FlatAppearance.BorderColor = Color.DarkRed;
            manageStockButton.FlatAppearance.BorderSize = 5;
            manageStockButton.FlatStyle = FlatStyle.Flat;
            manageStockButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            manageStockButton.ForeColor = Color.FromArgb(255, 255, 192);
            manageStockButton.Location = new Point(400, 340);
            manageStockButton.Name = "manageStockButton";
            manageStockButton.Size = new Size(250, 52);
            manageStockButton.TabIndex = 4;
            manageStockButton.Text = "&Manage Stock";
            adminToolTip.SetToolTip(manageStockButton, "Edit Stock Values");
            manageStockButton.UseVisualStyleBackColor = false;
            manageStockButton.Click += manageStockButton_Click;
            // 
            // stockReportButton
            // 
            stockReportButton.BackColor = Color.Brown;
            stockReportButton.FlatAppearance.BorderColor = Color.DarkRed;
            stockReportButton.FlatAppearance.BorderSize = 5;
            stockReportButton.FlatStyle = FlatStyle.Flat;
            stockReportButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            stockReportButton.ForeColor = Color.FromArgb(255, 255, 192);
            stockReportButton.Location = new Point(400, 265);
            stockReportButton.Name = "stockReportButton";
            stockReportButton.Size = new Size(250, 52);
            stockReportButton.TabIndex = 3;
            stockReportButton.Text = "S&tock Report";
            adminToolTip.SetToolTip(stockReportButton, "Generate Stock Report");
            stockReportButton.UseVisualStyleBackColor = false;
            stockReportButton.Click += stockReportButton_Click;
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(0, 75);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(350, 350);
            logoImage.TabIndex = 13;
            logoImage.TabStop = false;
            // 
            // newOrderButton
            // 
            newOrderButton.BackColor = Color.Brown;
            newOrderButton.FlatAppearance.BorderColor = Color.DarkRed;
            newOrderButton.FlatAppearance.BorderSize = 5;
            newOrderButton.FlatStyle = FlatStyle.Flat;
            newOrderButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            newOrderButton.ForeColor = Color.FromArgb(255, 255, 192);
            newOrderButton.Location = new Point(400, 40);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new Size(250, 52);
            newOrderButton.TabIndex = 0;
            newOrderButton.Text = "New &Order";
            adminToolTip.SetToolTip(newOrderButton, "Place a new order");
            newOrderButton.UseVisualStyleBackColor = false;
            newOrderButton.Click += newOrderButton_Click;
            // 
            // stockReportPanel
            // 
            stockReportPanel.BackColor = Color.BlanchedAlmond;
            stockReportPanel.Controls.Add(managePanel);
            stockReportPanel.Controls.Add(stockReportLabel);
            stockReportPanel.Controls.Add(closeButton);
            stockReportPanel.Controls.Add(saveButton);
            stockReportPanel.Controls.Add(color1);
            stockReportPanel.Controls.Add(color3);
            stockReportPanel.Controls.Add(color2);
            stockReportPanel.Controls.Add(color2Label);
            stockReportPanel.Controls.Add(color3Label);
            stockReportPanel.Controls.Add(color1Label);
            stockReportPanel.Controls.Add(stockData);
            stockReportPanel.Location = new Point(100, 200);
            stockReportPanel.Name = "stockReportPanel";
            stockReportPanel.Size = new Size(1400, 800);
            stockReportPanel.TabIndex = 20;
            // 
            // managePanel
            // 
            managePanel.Controls.Add(confirmButton);
            managePanel.Controls.Add(cancelButton);
            managePanel.Location = new Point(0, 650);
            managePanel.Name = "managePanel";
            managePanel.Size = new Size(1400, 150);
            managePanel.TabIndex = 19;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Brown;
            confirmButton.FlatAppearance.BorderColor = Color.DarkRed;
            confirmButton.FlatAppearance.BorderSize = 5;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            confirmButton.ForeColor = Color.FromArgb(255, 255, 192);
            confirmButton.Location = new Point(725, 50);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(200, 52);
            confirmButton.TabIndex = 10;
            confirmButton.Text = "Con&firm";
            adminToolTip.SetToolTip(confirmButton, "Confirm Stock Changes");
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Brown;
            cancelButton.FlatAppearance.BorderColor = Color.DarkRed;
            cancelButton.FlatAppearance.BorderSize = 5;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            cancelButton.ForeColor = Color.FromArgb(255, 255, 192);
            cancelButton.Location = new Point(475, 50);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 52);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "&Cancel";
            adminToolTip.SetToolTip(cancelButton, "Go back to Admin Options");
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // stockReportLabel
            // 
            stockReportLabel.AutoSize = true;
            stockReportLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            stockReportLabel.ForeColor = Color.DarkRed;
            stockReportLabel.Location = new Point(600, 20);
            stockReportLabel.Name = "stockReportLabel";
            stockReportLabel.Size = new Size(249, 45);
            stockReportLabel.TabIndex = 12;
            stockReportLabel.Text = "Opening Stock";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Brown;
            closeButton.FlatAppearance.BorderColor = Color.DarkRed;
            closeButton.FlatAppearance.BorderSize = 5;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            closeButton.ForeColor = Color.FromArgb(255, 255, 192);
            closeButton.Location = new Point(775, 681);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(225, 52);
            closeButton.TabIndex = 9;
            closeButton.Text = "&Close";
            adminToolTip.SetToolTip(closeButton, "Go back to admin Options");
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
            saveButton.Location = new Point(450, 681);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(275, 52);
            saveButton.TabIndex = 8;
            saveButton.Text = "&Save as Text File";
            adminToolTip.SetToolTip(saveButton, "Get output in Documents Folder");
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // color1
            // 
            color1.AutoSize = true;
            color1.BackColor = Color.Red;
            color1.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color1.ForeColor = Color.DarkRed;
            color1.Location = new Point(350, 600);
            color1.Name = "color1";
            color1.Size = new Size(49, 37);
            color1.TabIndex = 13;
            color1.Text = "    ";
            // 
            // color3
            // 
            color3.AutoSize = true;
            color3.BackColor = Color.Green;
            color3.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color3.ForeColor = Color.DarkRed;
            color3.Location = new Point(800, 600);
            color3.Name = "color3";
            color3.Size = new Size(49, 37);
            color3.TabIndex = 17;
            color3.Text = "    ";
            // 
            // color2
            // 
            color2.AutoSize = true;
            color2.BackColor = Color.Orange;
            color2.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color2.ForeColor = Color.DarkRed;
            color2.Location = new Point(591, 600);
            color2.Name = "color2";
            color2.Size = new Size(49, 37);
            color2.TabIndex = 15;
            color2.Text = "    ";
            // 
            // color2Label
            // 
            color2Label.AutoSize = true;
            color2Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color2Label.ForeColor = Color.DarkRed;
            color2Label.Location = new Point(640, 600);
            color2Label.Name = "color2Label";
            color2Label.Size = new Size(152, 37);
            color2Label.TabIndex = 16;
            color2Label.Text = "Low Stock";
            // 
            // color3Label
            // 
            color3Label.AutoSize = true;
            color3Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color3Label.ForeColor = Color.DarkRed;
            color3Label.Location = new Point(850, 600);
            color3Label.Name = "color3Label";
            color3Label.Size = new Size(225, 37);
            color3Label.TabIndex = 18;
            color3Label.Text = "Sufficient Stock";
            // 
            // color1Label
            // 
            color1Label.AutoSize = true;
            color1Label.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            color1Label.ForeColor = Color.DarkRed;
            color1Label.Location = new Point(400, 600);
            color1Label.Name = "color1Label";
            color1Label.Size = new Size(183, 37);
            color1Label.TabIndex = 14;
            color1Label.Text = "Out of Stock";
            // 
            // stockData
            // 
            stockData.AllowUserToAddRows = false;
            stockData.AllowUserToDeleteRows = false;
            stockData.AllowUserToResizeColumns = false;
            stockData.AllowUserToResizeRows = false;
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockData.Location = new Point(48, 79);
            stockData.MultiSelect = false;
            stockData.Name = "stockData";
            stockData.RowHeadersWidth = 82;
            stockData.Size = new Size(1300, 500);
            stockData.TabIndex = 7;
            stockData.CellValueChanged += stockData_CellValueChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 1199);
            Controls.Add(stockReportPanel);
            Controls.Add(cartPanel);
            Controls.Add(adminBackground);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)adminBackground).EndInit();
            cartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            stockReportPanel.ResumeLayout(false);
            stockReportPanel.PerformLayout();
            managePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox adminBackground;
        private Panel cartPanel;
        private Button newOrderButton;
        private Button manageStockButton;
        private Button stockReportButton;
        private PictureBox logoImage;
        private Button searchButton;
        private Button exitButton;
        private Button salesReportButton;
        private Panel stockReportPanel;
        private Button closeButton;
        private Button saveButton;
        private Label color1;
        private Label color3;
        private Label color2;
        private Label color2Label;
        private Label color3Label;
        private Label color1Label;
        private DataGridView stockData;
        private Label stockReportLabel;
        private Panel managePanel;
        private Button confirmButton;
        private Button cancelButton;
        private ToolTip adminToolTip;
    }
}