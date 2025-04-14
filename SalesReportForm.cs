namespace Jumper4U
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // Setup Grid Display
            int rows = AdminForm.sales.GetLength(0) + 1;
            int cols = AdminForm.sales.GetLength(1) + 1;

            SalesData.RowCount = rows;
            SalesData.ColumnCount = cols;

            // Color blank label
            SalesData.Rows[0].Cells[0].Style.BackColor = Color.Black;

            //Label Grid Rows
            for (int i = 1; i < rows; i++)
            {
                SalesData.Rows[i].Cells[0].Value = AdminForm.JUMPER_STYLES[i - 1];
                SalesData.Rows[i].Cells[0].Style.BackColor = Color.Black;
                SalesData.Rows[i].Cells[0].Style.ForeColor = Color.White;
            }

            //Label Grid Columns
            for (int i = 1; i < cols; i++)
            {
                SalesData.Rows[0].Cells[i].Value = AdminForm.JUMPER_SIZES[i - 1];
                SalesData.Rows[0].Cells[i].Style.BackColor = Color.Black;
                SalesData.Rows[0].Cells[i].Style.ForeColor = Color.White;
            }

            // Populate Grid
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    int sold = AdminForm.sales[i - 1, j - 1];
                    SalesData.Rows[i].Cells[j].Value = $"{sold} (${sold * AdminForm.JUMPER_PRICE[i - 1, j - 1]})";

                    //Color cells based on values
                    if (sold == 0)
                    {
                        SalesData.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (sold < AdminForm.STOCK_THRESHOLD)
                    {
                        SalesData.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                    else
                    {
                        SalesData.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                    SalesData.Rows[i].Cells[j].Style.ForeColor = Color.White;
                }
            }

            //Clear default Selection
            SalesData.ClearSelection();

            //Update Total Sales
            totalSalesLabel.Text = $"Total Sales: ${AdminForm.salesTotal}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Get timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //Add timestamp to filename
            string fileName = $"Sales_Report_{timestamp}.txt";
            //Use my documents path for user convenience.
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            try
            {
                StreamWriter writer = new StreamWriter(filePath);

                // List to No Sale category jumpers
                List<String> category1 = new List<String>();
                // List to record Low Sale category jumpers
                List<String> category2 = new List<String>();
                // List to record High Sale category jumpers
                List<String> category3 = new List<String>();

                // Print date on top of the report
                writer.WriteLine($"Sales Report Generated on: {DateTime.Now.ToShortDateString()}\n");

                // record in grid and categorize
                for (int i = 0; i <= AdminForm.sales.GetLength(0); i++)
                {
                    for (int j = 0; j <= AdminForm.sales.GetLength(1); j++)
                    {
                        if (i == 0 && j == 0) writer.Write("\t\t");
                        else if (i == 0) writer.Write(AdminForm.JUMPER_SIZES[j - 1] + "\t\t");
                        else if (j == 0) writer.Write(AdminForm.JUMPER_STYLES[i - 1] + "\t");
                        else
                        {
                            int itemSale = AdminForm.sales[i - 1, j - 1];

                            writer.Write(itemSale + $"(${itemSale * AdminForm.JUMPER_PRICE[i - 1, j - 1]})\t\t");

                            if (itemSale == 0) category1.Add($"{AdminForm.JUMPER_STYLES[i - 1]} ({AdminForm.JUMPER_SIZES[j - 1]})");
                            else if (itemSale < AdminForm.STOCK_THRESHOLD) category2.Add($"{AdminForm.JUMPER_STYLES[i - 1]} ({AdminForm.JUMPER_SIZES[j - 1]})");
                            else category3.Add($"{AdminForm.JUMPER_STYLES[i - 1]} ({AdminForm.JUMPER_SIZES[j - 1]})");
                        }
                    }
                    writer.WriteLine();
                }

                //print categories
                writer.WriteLine("\nNo Sale:");
                foreach (string item in category1)
                {
                    writer.WriteLine(item);
                }

                writer.WriteLine("\nLow Sale:");
                foreach (string item in category2)
                {
                    writer.WriteLine(item);
                }

                writer.WriteLine("\nHigh Sale:");
                foreach (string item in category3)
                {
                    writer.WriteLine(item);
                }

                writer.Close();

                // Display Success Message and the location of file
                AdminForm.DisplaySuccess($"Sales report saved successfully! You may view it in {filePath}");
            }
            catch (Exception ex)
            {
                AdminForm.DisplayError($"An unexpected error occurred while saving Sales Report: {ex.Message}");
            }

            closeButton_Click(sender, e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
