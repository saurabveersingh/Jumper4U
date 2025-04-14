namespace Jumper4U
{
    public partial class AdminForm : Form
    {
        // Jumper Data
        public static readonly string[] JUMPER_STYLES = { "White Panda", "Black Bear", "Grey Rhino", "Red Dragon",
            "Blue Bird", "Yellow Bee", "Green Frog", "Orange Snail", "Brown Mouse", "Pink Rabbit" };

        public static readonly string[] JUMPER_SIZES = { "XS", "S", "M", "L", "XL" };

        public static readonly decimal[,] JUMPER_PRICE = { {40m, 45m, 50m, 55m, 60m },
                                            { 48m, 54m, 60m, 66m, 72m },
                                            { 32m, 36m, 40m, 44m, 48m },
                                            { 44m, 49.5m, 55m, 60.5m, 66m },
                                            { 36m, 40.5m, 45m, 49.5m, 54m },
                                            { 24m, 27m, 30m, 33m, 36m },
                                            { 30.4m, 34.2m, 38m, 41.8m, 45.6m },
                                            { 28m, 31.5m, 35m, 38.5m, 42m },
                                            { 46.4m, 52.2m, 58m, 63.8m, 69.6m },
                                            { 52m, 58.5m, 65m, 71.5m, 78m }};

        public const int STOCK_THRESHOLD = 10;

        //File Paths
        const string STOCK_FILE_PATH = "stock.txt";

        //Field Variables
        public static int[,] stock { get; private set; } = { { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },};

        public static int[,] sales { get; private set; } = { { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },
                                                             { 0, 0, 0, 0, 0 },};

        public static decimal salesTotal { get; private set; } = 0m;
        public static bool lowStock { get; private set; } = false;

        bool closing = false;

        public AdminForm()
        {
            InitializeComponent();
        }

        //Fetch opening stock on form load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                // If stock file exists, save data in local variable
                if (File.Exists(STOCK_FILE_PATH))
                {
                    string[] lines = File.ReadAllLines(STOCK_FILE_PATH);

                    for (int i = 0; i < stock.GetLength(0); i++)
                    {
                        string[] values = lines[i].Split(',');
                        for (int j = 0; j < stock.GetLength(1); j++)
                        {
                            stock[i, j] = int.Parse(values[j]);
                        }
                    }
                }
                else //If the stock file doesn't exist, create a new file and populate it with random values between 10 to 50.
                {
                    Random rand = new Random();
                    StreamWriter writer = new StreamWriter(STOCK_FILE_PATH);

                    for (int i = 0; i < stock.GetLength(0); i++)
                    {
                        for (int j = 0; j < stock.GetLength(1); j++)
                        {
                            int curr = rand.Next(STOCK_THRESHOLD, STOCK_THRESHOLD * 5);
                            stock[i, j] = curr;

                            writer.Write(stock[i, j]);
                            if (j < stock.GetLength(1) - 1) writer.Write(",");
                        }
                        writer.WriteLine();
                    }

                    writer.Close();
                }
                DisplayStock("opening");
            }
            catch (Exception ex)
            {
                DisplayError($"An error occurred while loading stock data or creating stock file: {ex.Message}");
            }
        }

        // Admin Panel Event Listeners

        //Allows user to place a new order
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            if (lowStock) DisplayStock("threshold");
        }

        //Allows user to Search Orders
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        //Dispay Sales Report in a new form
        private void salesReportButton_Click(object sender, EventArgs e)
        {
            SalesReportForm salesReportForm = new SalesReportForm();
            salesReportForm.ShowDialog();
        }

        // Display stock report
        private void stockReportButton_Click(object sender, EventArgs e)
        {
            DisplayStock("report");
        }

        // Allows user to edit stock manually.
        private void manageStockButton_Click(object sender, EventArgs e)
        {
            DisplayStock("manage");
        }

        // Exits the Form App
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Form Close Event Handler

        //Interupts form close to show closing Stock
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
            {
                e.Cancel = true;
                closing = true;
                DisplayStock("closing");
                UpdateStockFile();
            }
        }

        // Stock Report Event handlers

        // Saves Stock Report as a text file.
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Get timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //Add timestamp to filename
            string fileName = $"Stock_Report_{timestamp}.txt";
            //Use my documents path for user convenience.
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            try
            {
                StreamWriter writer = new StreamWriter(filePath);

                // List to record out of stock category jumpers
                List<String> category1 = new List<String>();
                // List to record low stock category jumpers
                List<String> category2 = new List<String>();
                // List to record sufficient stock category jumpers
                List<String> category3 = new List<String>();

                // Print date on top of the report
                writer.WriteLine($"Stock Report Generated on: {DateTime.Now.ToShortDateString()}\n");

                // record in grid and categorize
                for (int i = 0; i <= stock.GetLength(0); i++)
                {
                    for (int j = 0; j <= stock.GetLength(1); j++)
                    {
                        if (i == 0 && j == 0) writer.Write("\t\t");
                        else if (i == 0) writer.Write(JUMPER_SIZES[j - 1] + "\t\t");
                        else if (j == 0) writer.Write(JUMPER_STYLES[i - 1] + "\t");
                        else
                        {
                            int itemStock = stock[i - 1, j - 1];
                            writer.Write(itemStock + "\t\t");

                            if (itemStock == 0) category1.Add($"{JUMPER_STYLES[i - 1]} ({JUMPER_SIZES[j - 1]})");
                            else if (itemStock < 10) category2.Add($"{JUMPER_STYLES[i - 1]} ({JUMPER_SIZES[j - 1]})");
                            else category3.Add($"{JUMPER_STYLES[i - 1]} ({JUMPER_SIZES[j - 1]})");
                        }
                    }
                    writer.WriteLine();
                }

                //print categories
                writer.WriteLine("\nOut of Stock:");
                foreach (string item in category1)
                {
                    writer.WriteLine(item);
                }

                writer.WriteLine("\nLow Stock:");
                foreach (string item in category2)
                {
                    writer.WriteLine(item);
                }

                writer.WriteLine("\nSufficient Stock:");
                foreach (string item in category3)
                {
                    writer.WriteLine(item);
                }

                //Close file writer
                writer.Close();

                // Display Success Message and the location of file
                DisplaySuccess($"Stock report saved successfully! You may view it in {filePath}");
            }
            catch (Exception ex)
            {
                DisplayError($"An unexpected error occurred while saving Stock Report: {ex.Message}");
            }

            //Close Stock Report
            stockReportPanel.Visible = false;
        }

        //Hide Stock Report
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (closing) exitButton_Click(sender, e);
            stockReportPanel.Visible = false;
        }

        // Stock edit event listeners

        // Updates colorcoding for stock report grid
        private void stockData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            // Ignore grid labels
            if (row == 0 || col == 0) return;

            // Validate input
            var updatedCell = stockData.Rows[row].Cells[col];
            string stringvalue = updatedCell.Value?.ToString();
            int intValue = 0;

            try
            {
                intValue = int.Parse(stringvalue);
            }
            catch (Exception ex)
            {
                DisplayError("Please enter a valid number");
                updatedCell.Value = stock[row, col];
                return;
            }

            //Color cells based on values
            if (intValue == 0)
            {
                updatedCell.Style.BackColor = Color.Red;
            }
            else if (intValue < STOCK_THRESHOLD)
            {
                updatedCell.Style.BackColor = Color.Orange;
            }
            else
            {
                updatedCell.Style.BackColor = Color.Green;
            }
            updatedCell.Style.ForeColor = Color.White;
        }

        //Save Stock Edits
        private void confirmButton_Click(object sender, EventArgs e)
        {
            int rows = stock.GetLength(0);
            int cols = stock.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        var cellValue = stockData.Rows[i + 1].Cells[j + 1].Value?.ToString();
                        stock[i, j] = int.Parse(cellValue);
                    }
                    catch (Exception ex)
                    {
                        DisplayError($"An error occurred while updating stock: {ex.Message}");
                        return;
                    }
                }
            }

            DisplaySuccess("Stock updated Successfully");

            //Close Stock Report
            stockReportPanel.Visible = false;
        }

        //Cancel Stock Edit
        private void cancelButton_Click(object sender, EventArgs e)
        {
            stockReportPanel.Visible = false;
        }

        // Stock Report helper functions

        // Common Method for various types of stock Reports.
        private void DisplayStock(string type)
        {
            //Update Stock Label
            if (type == "opening") stockReportLabel.Text = "Opening Stock";
            else if (type == "closing") stockReportLabel.Text = "Closing Stock";
            else if (type == "threshold") stockReportLabel.Text = "Threshold Breached!";
            else if (type == "report") stockReportLabel.Text = "Stock Report";
            else if (type == "manage") stockReportLabel.Text = "Manage Stock";

            // Setup Grid Display
            int rows = stock.GetLength(0) + 1;
            int cols = stock.GetLength(1) + 1;

            stockData.RowCount = rows;
            stockData.ColumnCount = cols;

            // Blank Cornor
            stockData.Rows[0].Cells[0].Style.BackColor = Color.Black;
            stockData.Rows[0].Cells[0].ReadOnly = true;

            //Label Grid Rows
            for (int i = 1; i < rows; i++)
            {
                stockData.Rows[i].Cells[0].Value = JUMPER_STYLES[i - 1];
                stockData.Rows[i].Cells[0].Style.BackColor = Color.Black;
                stockData.Rows[i].Cells[0].Style.ForeColor = Color.White;
                stockData.Rows[i].Cells[0].ReadOnly = true;
            }

            //Label Grid Columns
            for (int i = 1; i < cols; i++)
            {
                stockData.Rows[0].Cells[i].Value = JUMPER_SIZES[i - 1];
                stockData.Rows[0].Cells[i].Style.BackColor = Color.Black;
                stockData.Rows[0].Cells[i].Style.ForeColor = Color.White;
                stockData.Rows[0].Cells[i].ReadOnly = true;
            }

            // Populate Grid
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    int currStock = stock[i - 1, j - 1];
                    stockData.Rows[i].Cells[j].Value = currStock;

                    //If type is manage, make cells editable
                    stockData.Rows[i].Cells[j].ReadOnly = type != "manage";
                }
            }

            //Clear default Selection
            stockData.ClearSelection();

            //Show manage buttons if type is manage.
            managePanel.Visible = type == "manage";

            //Show Stock Panel
            stockReportPanel.Visible = true;
        }

        //Update Stock File
        private void UpdateStockFile()
        {
            StreamWriter writer = new StreamWriter(STOCK_FILE_PATH);

            for (int i = 0; i < stock.GetLength(0); i++)
            {
                for (int j = 0; j < stock.GetLength(1); j++)
                {
                    writer.Write(stock[i, j]);
                    if (j < stock.GetLength(1) - 1) writer.Write(",");
                }
                writer.WriteLine();
            }

            writer.Close();
        }

        // New Order Helper Functions

        // Update sales and stock on new order.
        public static void PlaceOrder(List<int[]> cart, decimal cartTotal)
        {
            foreach (int[] item in cart)
            {
                sales[item[0], item[1]] += item[2];
                int updatedStock = stock[item[0], item[1]] - item[2];
                stock[item[0], item[1]] = updatedStock;
                if (updatedStock < STOCK_THRESHOLD) lowStock = true;
            }
            salesTotal += cartTotal;
        }

        // Utility Functions

        //Displays Error Box
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Displays Success Box
        public static void DisplaySuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Display Confirmation Box
        public static bool GetUserConfirmation(string message)
        {
            string res = MessageBox.Show(message, "Do you wish to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            return res == "Yes";
        }

        //Used to log items in cart, order confirmation and transaction file.
        public static string ItemAsString(int styleIndex, int sizeIndex, int quantity)
        {
            decimal itemValue = JUMPER_PRICE[styleIndex, sizeIndex] * quantity;

            return $"{JUMPER_STYLES[styleIndex]} ({JUMPER_SIZES[sizeIndex]}) x{quantity} -> ${itemValue}";
        }
    }
}
