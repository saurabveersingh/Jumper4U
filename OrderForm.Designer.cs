namespace Jumper4U
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            backgroundImage = new PictureBox();
            styleList = new ListBox();
            sizeList = new ListBox();
            selectionPanel = new Panel();
            clearButton = new Button();
            addButton = new Button();
            quantityLabel = new Label();
            effectLabel = new Label();
            sizeLabel = new Label();
            priceLabel = new Label();
            styleLabel = new Label();
            quantityTextBox = new TextBox();
            logoImage = new PictureBox();
            cartPanel = new Panel();
            totalLabel = new Label();
            removeButton = new Button();
            orderButton = new Button();
            cartLabel = new Label();
            cartList = new ListBox();
            orderToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)backgroundImage).BeginInit();
            selectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            cartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundImage
            // 
            backgroundImage.Image = (Image)resources.GetObject("backgroundImage.Image");
            backgroundImage.Location = new Point(0, 0);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(480, 1200);
            backgroundImage.TabIndex = 0;
            backgroundImage.TabStop = false;
            // 
            // styleList
            // 
            styleList.BackColor = Color.DarkSlateGray;
            styleList.ForeColor = Color.White;
            styleList.FormattingEnabled = true;
            styleList.Items.AddRange(new object[] { "White Panda\t\t$50", "Black Bear\t\t$60", "Grey Rhino\t\t$40", "Red Dragon\t\t$55", "Blue Bird\t\t\t$45", "Yellow Bee\t\t$30", "Green Frog\t\t$38", "Orange Snail\t\t$35", "Brown Mouse\t\t$58", "Pink Rabbit\t\t$65" });
            styleList.Location = new Point(25, 43);
            styleList.Name = "styleList";
            styleList.Size = new Size(400, 356);
            styleList.TabIndex = 0;
            // 
            // sizeList
            // 
            sizeList.BackColor = Color.DarkSlateGray;
            sizeList.ForeColor = Color.White;
            sizeList.FormattingEnabled = true;
            sizeList.Items.AddRange(new object[] { "XS\t\t\t-20%", "S\t\t\t-10%", "M\t\t\t0%", "L\t\t\t10%", "XL\t\t\t20%" });
            sizeList.Location = new Point(25, 441);
            sizeList.Name = "sizeList";
            sizeList.Size = new Size(400, 196);
            sizeList.TabIndex = 1;
            // 
            // selectionPanel
            // 
            selectionPanel.BackColor = Color.BlanchedAlmond;
            selectionPanel.Controls.Add(clearButton);
            selectionPanel.Controls.Add(addButton);
            selectionPanel.Controls.Add(quantityLabel);
            selectionPanel.Controls.Add(effectLabel);
            selectionPanel.Controls.Add(sizeLabel);
            selectionPanel.Controls.Add(priceLabel);
            selectionPanel.Controls.Add(styleLabel);
            selectionPanel.Controls.Add(quantityTextBox);
            selectionPanel.Controls.Add(sizeList);
            selectionPanel.Controls.Add(styleList);
            selectionPanel.Location = new Point(15, 15);
            selectionPanel.Name = "selectionPanel";
            selectionPanel.Size = new Size(450, 807);
            selectionPanel.TabIndex = 15;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Brown;
            clearButton.FlatAppearance.BorderColor = Color.DarkRed;
            clearButton.FlatAppearance.BorderSize = 5;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(255, 255, 192);
            clearButton.Location = new Point(25, 731);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 52);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            orderToolTip.SetToolTip(clearButton, "Clear inputs");
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Brown;
            addButton.FlatAppearance.BorderColor = Color.DarkRed;
            addButton.FlatAppearance.BorderSize = 5;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            addButton.ForeColor = Color.FromArgb(255, 255, 192);
            addButton.Location = new Point(200, 731);
            addButton.Name = "addButton";
            addButton.Size = new Size(225, 52);
            addButton.TabIndex = 3;
            addButton.Text = "&Add to Cart";
            orderToolTip.SetToolTip(addButton, "Add selections to cart list");
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.ForeColor = Color.DarkRed;
            quantityLabel.Location = new Point(160, 637);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(133, 37);
            quantityLabel.TabIndex = 12;
            quantityLabel.Text = "Quantity";
            // 
            // effectLabel
            // 
            effectLabel.AutoSize = true;
            effectLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            effectLabel.ForeColor = Color.DarkRed;
            effectLabel.Location = new Point(325, 404);
            effectLabel.Name = "effectLabel";
            effectLabel.Size = new Size(95, 37);
            effectLabel.TabIndex = 11;
            effectLabel.Text = "Effect";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sizeLabel.ForeColor = Color.DarkRed;
            sizeLabel.Location = new Point(25, 404);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(69, 37);
            sizeLabel.TabIndex = 10;
            sizeLabel.Text = "Size";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = Color.DarkRed;
            priceLabel.Location = new Point(325, 6);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(83, 37);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price";
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            styleLabel.ForeColor = Color.DarkRed;
            styleLabel.Location = new Point(25, 6);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new Size(82, 37);
            styleLabel.TabIndex = 8;
            styleLabel.Text = "Style";
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = Color.DarkSlateGray;
            quantityTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityTextBox.ForeColor = Color.White;
            quantityTextBox.Location = new Point(125, 674);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(200, 39);
            quantityTextBox.TabIndex = 2;
            quantityTextBox.Text = "0";
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // logoImage
            // 
            logoImage.BackColor = Color.BlanchedAlmond;
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(15, 835);
            logoImage.Name = "logoImage";
            logoImage.Padding = new Padding(50, 0, 0, 0);
            logoImage.Size = new Size(450, 350);
            logoImage.TabIndex = 4;
            logoImage.TabStop = false;
            // 
            // cartPanel
            // 
            cartPanel.BackColor = Color.BlanchedAlmond;
            cartPanel.Controls.Add(totalLabel);
            cartPanel.Controls.Add(removeButton);
            cartPanel.Controls.Add(orderButton);
            cartPanel.Controls.Add(cartLabel);
            cartPanel.Controls.Add(cartList);
            cartPanel.Location = new Point(15, 835);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(450, 350);
            cartPanel.TabIndex = 16;
            cartPanel.Visible = false;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.DarkRed;
            totalLabel.Location = new Point(165, 237);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(134, 37);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "Total: $0";
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Brown;
            removeButton.FlatAppearance.BorderColor = Color.DarkRed;
            removeButton.FlatAppearance.BorderSize = 5;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            removeButton.ForeColor = Color.FromArgb(255, 255, 192);
            removeButton.Location = new Point(25, 281);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(225, 52);
            removeButton.TabIndex = 7;
            removeButton.Text = "&Remove Item";
            orderToolTip.SetToolTip(removeButton, "Remove selection from cart list");
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.Brown;
            orderButton.FlatAppearance.BorderColor = Color.DarkRed;
            orderButton.FlatAppearance.BorderSize = 5;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            orderButton.ForeColor = Color.FromArgb(255, 255, 192);
            orderButton.Location = new Point(275, 281);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(150, 52);
            orderButton.TabIndex = 6;
            orderButton.Text = "&Order";
            orderToolTip.SetToolTip(orderButton, "Place Order");
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLabel.ForeColor = Color.DarkRed;
            cartLabel.Location = new Point(25, 1);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(154, 37);
            cartLabel.TabIndex = 13;
            cartLabel.Text = "Cart Items";
            // 
            // cartList
            // 
            cartList.BackColor = Color.DarkSlateGray;
            cartList.ForeColor = Color.White;
            cartList.FormattingEnabled = true;
            cartList.Location = new Point(25, 38);
            cartList.Name = "cartList";
            cartList.Size = new Size(400, 196);
            cartList.TabIndex = 5;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 1199);
            Controls.Add(selectionPanel);
            Controls.Add(cartPanel);
            Controls.Add(logoImage);
            Controls.Add(backgroundImage);
            Name = "OrderForm";
            Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)backgroundImage).EndInit();
            selectionPanel.ResumeLayout(false);
            selectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            cartPanel.ResumeLayout(false);
            cartPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backgroundImage;
        private ListBox styleList;
        private ListBox sizeList;
        private Panel selectionPanel;
        private Label styleLabel;
        private TextBox quantityTextBox;
        private Label effectLabel;
        private Label sizeLabel;
        private Label priceLabel;
        private Label quantityLabel;
        private Button addButton;
        private PictureBox logoImage;
        private Panel cartPanel;
        private Label cartLabel;
        private ListBox cartList;
        private Button removeButton;
        private Button orderButton;
        private Button clearButton;
        private Label totalLabel;
        private ToolTip orderToolTip;
    }
}
