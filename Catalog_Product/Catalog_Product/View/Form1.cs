using Catalog_Product.Model.Entity;
using Catalog_Product.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Catalog_Product.View
{
    public partial class Form1 : Form
    {
        private readonly ProductRestApiRepository repository;

        public Form1()
        {
            InitializeComponent();
            repository = new ProductRestApiRepository();
            InitializeComboBoxOptions();
        }

        private void InitializeComboBoxOptions()
        {
            comboBoxSearchOptions.Items.Add("All");
            comboBoxSearchOptions.Items.Add("Product Id");
            comboBoxSearchOptions.Items.Add("Product Name");
            comboBoxSearchOptions.Items.Add("Category");

            comboBoxSearchOptions.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBoxSearchOptions.SelectedItem.ToString();
            string searchTerm = textBoxSearch.Text.Trim();

            switch (selectedOption)
            {
                case "All":
                    DisplaySearchResults(repository.ReadAll());
                    break;

                case "Product Id":
                    if (int.TryParse(searchTerm, out int productId))
                    {
                        DisplaySearchResults(repository.ReadByProductId(productId));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Product Id. Please enter a valid number.");
                    }
                    break;

                case "Product Name":
                    DisplaySearchResults(repository.ReadByProductName(searchTerm));
                    break;

                case "Category":
                    DisplaySearchResults(repository.ReadByCategory(searchTerm));
                    break;
            }
        }

        private void DisplaySearchResults(List<Product> searchResults)
        {
            dataGridViewResults.Rows.Clear();

            if (searchResults != null && searchResults.Count > 0)
            {
                foreach (var product in searchResults)  
                {
                    dataGridViewResults.Rows.Add(product.ProductId, product.ProductName, product.Category);
                }
            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }
    }
}
