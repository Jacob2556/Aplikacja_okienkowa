namespace Aplikacja_okienkowa
{
    public partial class Form1 : Form
    {
        private DatabaseManager db = new DatabaseManager();

        public Form1()
        {
            InitializeComponent();
            db.CreateTable();
        }

        private void ListOfOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            Form2 addOrderForm = new Form2(); // Otwórz Form2
            addOrderForm.ShowDialog(); // Poczekaj na zamkni?cie Form2
            GetOrders_Click(sender, e); // Od?wie? ListView po dodaniu zamówienia
        }

        private void GetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = db.GetAllOrders();
                ListOfOrders.Items.Clear();
                foreach (var order in orders)
                {
                    var item = new ListViewItem(order.Item1.ToString());
                    item.SubItems.Add(order.Item2);
                    ListOfOrders.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            if (ListOfOrders.SelectedItems.Count > 0)
            {
                int orderId = int.Parse(ListOfOrders.SelectedItems[0].Text);
                db.DeleteOrderById(orderId);
                ListOfOrders.Items.Remove(ListOfOrders.SelectedItems[0]);
                MessageBox.Show("Order deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {
            if (ListOfOrders.SelectedItems.Count > 0)
            {
                int orderId = int.Parse(ListOfOrders.SelectedItems[0].Text);
                string orderName = ListOfOrders.SelectedItems[0].SubItems[1].Text;
                Form3 orderDetails = new Form3(orderId, orderName);
                orderDetails.Show();
            }
            else
            {
                MessageBox.Show("Please select an order to view details.");
            }
        }
    }
}
