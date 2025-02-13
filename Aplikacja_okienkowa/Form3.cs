using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_okienkowa
{
    public partial class Form3 : Form
    {
        private int orderId;
        private DatabaseManager db = new DatabaseManager();

        public Form3(int orderId, string orderName)
        {
            InitializeComponent();
            this.orderId = orderId;
            OrderID.Text = $"Order ID: {orderId}";
            OrderName.Text = $"Order Name: {orderName}";
            LoadOrderProducts();
        }

        private void LoadOrderProducts()
        {
            var products = db.GetProductsForOrder(orderId);
            listView1.Items.Clear();

            if (products.Count == 0)
            {
                MessageBox.Show("No products found for this order.");
            }

            foreach (var product in products)
            {
                var item = new ListViewItem(product.Item1.ToString()); // ID produktu
                item.SubItems.Add(product.Item2); // Nazwa produktu
                item.SubItems.Add(product.Item3.ToString("F2")); // Cena produktu

                listView1.Items.Add(item);
            }
        }
        private void AddToOrder_Click(object sender, EventArgs e)
        {
            string productName = Microsoft.VisualBasic.Interaction.InputBox("Enter product name:", "Add Product", "");
            string productPriceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter product price:", "Add Product", "");

            if (!string.IsNullOrWhiteSpace(productName) && double.TryParse(productPriceStr, out double productPrice))
            {
                db.AddProductToOrder(orderId, productName, productPrice);
                MessageBox.Show("Product added!");

                LoadOrderProducts(); // Odśwież ListView po dodaniu produktu
            }
            else
            {
                MessageBox.Show("Please enter a valid product name and price.");
            }
        }
        private void DeleteFromOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                if (int.TryParse(selectedItem.Text, out int productId)) // Pobiera ID produktu z pierwszej kolumny
                {
                    //Console.WriteLine($"[DEBUG] Attempting to delete product ID: {productId}");
                    db.DeleteProductFromOrder(productId);
                    MessageBox.Show($"Product {productId} deleted!");

                    LoadOrderProducts(); // Odśwież ListView
                }
                else
                {
                    MessageBox.Show("Error: Invalid product ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }
        private void BackToOrders_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
