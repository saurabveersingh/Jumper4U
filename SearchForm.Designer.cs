namespace Jumper4U
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            pictureBox1 = new PictureBox();
            searchPanel = new Panel();
            closeButton = new Button();
            searchResults = new ListBox();
            searchInput = new TextBox();
            searchLabel = new Label();
            searchOptions = new GroupBox();
            searchOption1 = new RadioButton();
            searchOption2 = new RadioButton();
            openButton = new Button();
            enterButton = new Button();
            searchToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchPanel.SuspendLayout();
            searchOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1600, 1200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.BlanchedAlmond;
            searchPanel.Controls.Add(closeButton);
            searchPanel.Controls.Add(searchResults);
            searchPanel.Controls.Add(searchInput);
            searchPanel.Controls.Add(searchLabel);
            searchPanel.Controls.Add(searchOptions);
            searchPanel.Controls.Add(openButton);
            searchPanel.Controls.Add(enterButton);
            searchPanel.Location = new Point(250, 300);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1100, 600);
            searchPanel.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Brown;
            closeButton.FlatAppearance.BorderColor = Color.DarkRed;
            closeButton.FlatAppearance.BorderSize = 5;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            closeButton.ForeColor = Color.FromArgb(255, 255, 192);
            closeButton.Location = new Point(120, 510);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(250, 52);
            closeButton.TabIndex = 4;
            closeButton.Text = "&Close Search";
            searchToolTip.SetToolTip(closeButton, "Go back to Admin Menu");
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // searchResults
            // 
            searchResults.BackColor = Color.Brown;
            searchResults.Font = new Font("Segoe UI", 12F);
            searchResults.ForeColor = Color.FromArgb(255, 255, 192);
            searchResults.FormattingEnabled = true;
            searchResults.HorizontalScrollbar = true;
            searchResults.ItemHeight = 45;
            searchResults.Items.AddRange(new object[] { "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt", "123456.txt" });
            searchResults.Location = new Point(525, 25);
            searchResults.Name = "searchResults";
            searchResults.Size = new Size(550, 454);
            searchResults.TabIndex = 5;
            searchResults.Visible = false;
            // 
            // searchInput
            // 
            searchInput.AccessibleName = "Full Name";
            searchInput.BackColor = Color.White;
            searchInput.Font = new Font("Segoe UI", 12F);
            searchInput.ForeColor = Color.Black;
            searchInput.Location = new Point(50, 310);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(400, 50);
            searchInput.TabIndex = 2;
            searchInput.TextAlign = HorizontalAlignment.Center;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchLabel.ForeColor = Color.DarkRed;
            searchLabel.Location = new Point(80, 250);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(334, 45);
            searchLabel.TabIndex = 8;
            searchLabel.Text = "Transaction Number:";
            // 
            // searchOptions
            // 
            searchOptions.BackColor = Color.Brown;
            searchOptions.Controls.Add(searchOption1);
            searchOptions.Controls.Add(searchOption2);
            searchOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchOptions.ForeColor = Color.FromArgb(255, 255, 192);
            searchOptions.Location = new Point(50, 50);
            searchOptions.Name = "searchOptions";
            searchOptions.Size = new Size(400, 170);
            searchOptions.TabIndex = 7;
            searchOptions.TabStop = false;
            searchOptions.Text = "Search By";
            // 
            // searchOption1
            // 
            searchOption1.AutoSize = true;
            searchOption1.Checked = true;
            searchOption1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchOption1.ForeColor = Color.FromArgb(255, 255, 192);
            searchOption1.Location = new Point(32, 49);
            searchOption1.Name = "searchOption1";
            searchOption1.Size = new Size(337, 49);
            searchOption1.TabIndex = 0;
            searchOption1.TabStop = true;
            searchOption1.Text = "Transaction Number";
            searchOption1.UseVisualStyleBackColor = true;
            searchOption1.CheckedChanged += searchOption1_CheckedChanged;
            // 
            // searchOption2
            // 
            searchOption2.AutoSize = true;
            searchOption2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchOption2.ForeColor = Color.FromArgb(255, 255, 192);
            searchOption2.Location = new Point(32, 99);
            searchOption2.Name = "searchOption2";
            searchOption2.Size = new Size(286, 49);
            searchOption2.TabIndex = 1;
            searchOption2.TabStop = true;
            searchOption2.Text = "Transaction Date";
            searchOption2.UseVisualStyleBackColor = true;
            searchOption2.CheckedChanged += searchOption2_CheckedChanged;
            // 
            // openButton
            // 
            openButton.BackColor = Color.Brown;
            openButton.FlatAppearance.BorderColor = Color.DarkRed;
            openButton.FlatAppearance.BorderSize = 5;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            openButton.ForeColor = Color.FromArgb(255, 255, 192);
            openButton.Location = new Point(680, 510);
            openButton.Name = "openButton";
            openButton.Size = new Size(250, 52);
            openButton.TabIndex = 6;
            openButton.Text = "&Open File";
            searchToolTip.SetToolTip(openButton, "Open selected file");
            openButton.UseVisualStyleBackColor = false;
            openButton.Visible = false;
            openButton.Click += openButton_Click;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.Brown;
            enterButton.FlatAppearance.BorderColor = Color.DarkRed;
            enterButton.FlatAppearance.BorderSize = 5;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            enterButton.ForeColor = Color.FromArgb(255, 255, 192);
            enterButton.Location = new Point(120, 400);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(250, 52);
            enterButton.TabIndex = 3;
            enterButton.Text = "&Enter";
            searchToolTip.SetToolTip(enterButton, "Initiate Search");
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 1199);
            Controls.Add(searchPanel);
            Controls.Add(pictureBox1);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            searchOptions.ResumeLayout(false);
            searchOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel searchPanel;
        private Button openButton;
        private Button enterButton;
        private GroupBox searchOptions;
        private RadioButton searchOption1;
        private RadioButton searchOption2;
        private ListBox searchResults;
        private TextBox searchInput;
        private Label searchLabel;
        private Button closeButton;
        private ToolTip searchToolTip;
    }
}