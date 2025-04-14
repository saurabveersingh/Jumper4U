namespace Jumper4U
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        // Close Search form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When Seach by Transaction Number is Selected
        private void searchOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (searchOption1.Checked)
            {
                searchLabel.Text = "Transaction Number:";
            }
        }

        // When Search by Transaction Date is Selected
        private void searchOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (searchOption2.Checked)
            {
                searchLabel.Text = "Transaction Date:";
            }
        }

        // Search files using input string.
        private void enterButton_Click(object sender, EventArgs e)
        {
            string query = searchInput.Text;
            if (searchOption1.Checked && query.Length == 6)
            {
                if (File.Exists($"{query}.txt")) DisplayFile($"{query}.txt");
                else AdminForm.DisplayError("Transaction Number does not exist.");
            }
            else if (searchOption2.Checked && query.Length == 10)
            {
                // Display all matches in a listbox. User can select a file name and click open.
                searchResults.Visible = true;
                searchResults.Items.Clear();

                // Use relative path to iterate over all .txt files in bin
                string defaultPath = AppDomain.CurrentDomain.BaseDirectory;
                foreach (string filePath in Directory.EnumerateFiles(defaultPath, "*.txt"))
                {
                    try
                    {
                        StreamReader FileReader = new StreamReader(filePath);
                        string transactionId = FileReader.ReadLine();

                        //if date is equal to query string then add filename to results.
                        if (FileReader.ReadLine() == query) searchResults.Items.Add($"{transactionId}.txt");
                        FileReader.Close();
                    }
                    catch (Exception ex)
                    {
                        AdminForm.DisplayError($"Unexpected Error while reading files");
                    }
                }
                if (searchResults.Items.Count > 0) openButton.Visible = true;
                else searchResults.Items.Add($"No transactions for this date.");
            }
            else
            {
                AdminForm.DisplayError("Invalid Search");
            }
        }

        // Display File if a file is selected on search results listbox.
        private void openButton_Click(object sender, EventArgs e)
        {
            if (searchResults.SelectedIndex == -1) AdminForm.DisplayError("Please Select a File in Selection Box");

            DisplayFile(searchResults.SelectedItem.ToString());

            openButton.Visible = false;
        }

        // Read and show the contents of provide filename
        private void DisplayFile(string fileName)
        {
            //Prepare Search Results box
            searchResults.Visible = true;
            searchResults.Items.Clear();

            try
            {
                // Display File Contents
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    searchResults.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                AdminForm.DisplayError($"Unexpected Error while reading {fileName}");
            }

            //Hide open button
            openButton.Visible = false;
        }
    }
}
