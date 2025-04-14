namespace Jumper4U
{
    public partial class OrderForm : Form
    {
        //Field Variables
        List<int[]> cart = new List<int[]>();
        decimal cartTotal = 0m;

        public OrderForm()
        {
            InitializeComponent();
        }

        // Clears inputs within Selection Panel
        private void clearButton_Click(object sender, EventArgs e)
        {
            styleList.ClearSelected();
            sizeList.ClearSelected();
            quantityTextBox.Text = "0";
        }

        // Adds items to cart.
        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            int styleIndex = styleList.SelectedIndex;
            int sizeIndex = sizeList.SelectedIndex;
            int quantity = 0;

            try
            {
                quantity = int.Parse(quantityTextBox.Text);
            }
            catch (Exception ex)
            {
                AdminForm.DisplayError($"Please provide a valid quantity");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
                return;
            }

            if (styleIndex == -1)
            {
                AdminForm.DisplayError($"Please select a jumper style");
                return;
            }
            else if (sizeIndex == -1)
            {
                AdminForm.DisplayError($"Please select a jumper size");
                return;
            }
            else if (quantity < 1)
            {
                AdminForm.DisplayError($"Please provide a valid quantity");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
                return;
            }

            //Check stock
            int itemStock = AdminForm.stock[styleIndex, sizeIndex];
            if (itemStock < quantity)
            {
                string message = itemStock == 0 ? "This item is Out of Stock"
                    : $"Only {itemStock} units of this item are in stock.";
                AdminForm.DisplayError(message);
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
                return;
            }

            //Add item to cart list
            cart.Add([styleIndex, sizeIndex, quantity]);

            //Add item to cart listbox
            cartList.Items.Add(AdminForm.ItemAsString(styleIndex, sizeIndex, quantity));

            //Update cart total
            cartTotal += AdminForm.JUMPER_PRICE[styleIndex, sizeIndex] * quantity;
            totalLabel.Text = $"Total = ${cartTotal}";

            //Make Cart Visible
            cartPanel.Visible = true;

            //Clear Selections
            clearButton_Click(sender, e);
        }

        //Remove Items from Cart
        private void removeButton_Click(object sender, EventArgs e)
        {
            //Validate cart item selection
            int cartIndex = cartList.SelectedIndex;

            if (cartList.SelectedIndex == -1)
            {
                AdminForm.DisplayError("Please Select the item that you wish to remove from cart");
            }

            //Update cart total
            cartTotal -= AdminForm.JUMPER_PRICE[cart[cartIndex][0], cart[cartIndex][1]] * cart[cartIndex][2];
            totalLabel.Text = $"Total = ${cartTotal}";

            //Remove item from cart list
            cart.RemoveAt(cartIndex);

            //Remove item from cart listbox
            cartList.Items.RemoveAt(cartIndex);

            //Hide Listbox if cart is empty.
            if (!cart.Any()) cartPanel.Visible = false;
        }

        // Confirms Order
        private void orderButton_Click(object sender, EventArgs e)
        {
            //Generate a random 6 digit transaction Number
            Random random = new Random();
            int currentTransactionNumber = random.Next(100000, 1000000);

            //Get current Date
            string currentDate = DateTime.Now.ToShortDateString();

            // Asks user for confirmation
            string message = $"Do you wish to confirm this order?\nTransaction ID: {currentTransactionNumber}\n";
            string orderDetails = "";

            foreach (int[] item in cart)
            {
                orderDetails += $"{AdminForm.ItemAsString(item[0], item[1], item[2])}\n";
            }

            orderDetails += $"Total: ${cartTotal}";

            if (!AdminForm.GetUserConfirmation(message + orderDetails)) return; // return if user selects "No"

            //Create Transaction File.
            try
            {
                StreamWriter outputFile = File.CreateText($"{currentTransactionNumber}.txt");
                outputFile.WriteLine(currentTransactionNumber);
                outputFile.WriteLine(currentDate);
                outputFile.WriteLine(orderDetails);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                AdminForm.DisplayError("There was an unexpected error while creating the order file");
            }

            //Update Admin form data
            AdminForm.PlaceOrder(cart, cartTotal);

            // Notify User of order success.
            AdminForm.DisplaySuccess("Order Placed Successfully");

            //Close order form
            this.Close();
        }
    }
}

