# Jumper4U

A C# Windows Forms application designed to manage jumper inventory and sales operations. It provides a user-friendly interface for administrators to handle stock, process orders, generate sales reports, and search transaction records.

## Features

- **Inventory Management**: Automatically loads stock data from a file or initializes with random values if the file is absent. Allows manual stock adjustments.
- **Order Processing**: Facilitates new order placements, updates stock and sales records, and generates transaction files.
- **Sales Reporting**: Generates detailed sales reports with categorization based on sales volume.
- **Transaction Search**: Enables searching for transactions by number or date, displaying results in a user-friendly format.
- **User Notifications**: Provides error, success, and confirmation messages to guide user actions.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/saurabveersingh/Jumper4U.git
   ```
2. Open the solution in Visual Studio.
3. Build and run the project.

## Usage

- Launch the application to access the Admin Panel.
- Use the buttons to manage stock, place orders, view sales reports, and search transactions.
- **Stock Reports** and **Sales Reports** are saved in the user's "My Documents" folder with filenames formatted as `Stock_Report_yyyyMMdd_HHmmss.txt` and `Sales_Report_yyyyMMdd_HHmmss.txt`, respectively.
- Follow on-screen instructions and notifications for a seamless experience.
