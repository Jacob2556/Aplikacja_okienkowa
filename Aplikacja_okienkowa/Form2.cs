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
    public partial class Form2 : Form
    {
        private List<(string, double)> tempProducts = new List<(string, double)>(); // Tymczasowa lista produktów
        private DatabaseManager db = new DatabaseManager();

        public Form2()
        {
            InitializeComponent();
        }

        private void F2OrderIDText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Zablokuj wpisywanie niepoprawnych znaków
            }
        }

        private void DeleteFromOrder_Click1(object sender, EventArgs e)
        {
            if (F2Products.SelectedItems.Count > 0)
            {
                int index = F2Products.SelectedIndices[0]; // Pobranie indeksu zaznaczonego produktu
                tempProducts.RemoveAt(index); // Usunięcie z tymczasowej listy
                UpdateProductListView(); // Odświeżenie ListView
                MessageBox.Show("Product removed!");
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void AddToOrder_Click(object sender, EventArgs e)
        {
            string productName = F2ProductText.Text;
            string productPriceStr = F2PriceText.Text;

            if (!string.IsNullOrWhiteSpace(productName) && double.TryParse(productPriceStr, out double productPrice))
            {
                tempProducts.Add((productName, productPrice)); // Dodaj produkt do listy tymczasowej
                UpdateProductListView(); // Odśwież ListView
                F2ProductText.Clear(); // Wyczyść pola po dodaniu produktu
                F2PriceText.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid product name and price.");
            }
        }

        private void UpdateProductListView()
        {
            F2Products.Items.Clear();

            foreach (var product in tempProducts)
            {
                var item = new ListViewItem(product.Item1); // Nazwa produktu
                item.SubItems.Add(product.Item2.ToString("F2")); // Cena produktu
                F2Products.Items.Add(item);
            }
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy użytkownik podał poprawne ID
            if (int.TryParse(F2OrderIDText.Text, out int orderId) && !string.IsNullOrWhiteSpace(F2OrderNameText.Text))
            {
                DatabaseManager db = new DatabaseManager();

                // Sprawdź, czy ID zamówienia już istnieje
                string existingOrder = db.FindOrderById(orderId);
                if (existingOrder != null)
                {
                    MessageBox.Show("Order ID already exists. Please enter a unique ID.");
                    return;
                }

                // Dodaj zamówienie do bazy
                db.AddOrder(orderId, F2OrderNameText.Text);

                // Dodaj produkty do bazy
                foreach (var product in tempProducts)
                {
                    db.AddProductToOrder(orderId, product.Item1, product.Item2);
                }

                MessageBox.Show("Order and products added successfully!");
                this.Close(); // Zamknij okno
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID and a non-empty Order Name.");
            }
        }
    }
}
