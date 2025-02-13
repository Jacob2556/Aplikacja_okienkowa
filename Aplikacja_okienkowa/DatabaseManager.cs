using Microsoft.Data.Sqlite;

public class DatabaseManager
{

    private readonly string connectionString = "Data Source=orders.db";

    public void CreateTable()
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS orders (
                    id INTEGER NOT NULL PRIMARY KEY,
                    name TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS order_items (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    order_id INTEGER NOT NULL,
                    product_name TEXT NOT NULL,
                    product_price REAL NOT NULL,
                    FOREIGN KEY (order_id) REFERENCES orders(id) ON DELETE CASCADE
                );
            ";
            command.ExecuteNonQuery();
        }
    }

    public void AddOrder(int id, string name)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO orders (id, name)
                VALUES ($id, $name);
            ";
            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$name", name);
            command.ExecuteNonQuery();
        }
    }

    public string FindOrderById(int id)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Check if the table exists
            var checkTableCommand = connection.CreateCommand();
            checkTableCommand.CommandText = @"
            SELECT name FROM sqlite_master WHERE type='table' AND name='orders';
        ";
            var tableExists = checkTableCommand.ExecuteScalar() != null;

            if (!tableExists)
            {
                throw new InvalidOperationException("The table 'orders' does not exist in the database.");
            }

            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT name FROM orders WHERE id = $id;
        ";
            command.Parameters.AddWithValue("$id", id);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
            }
        }
        return null;
    }

    public List<(int, string)> GetAllOrders()
    {
        var orders = new List<(int, string)>();
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT id, name FROM orders ORDER BY id ASC;
            ";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    orders.Add((id, name));
                }
            }
        }
        return orders;
    }

    public void DeleteTable()
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"
                DROP TABLE IF EXISTS orders;
            ";
            command.ExecuteNonQuery();
        }
    }

    public void DeleteOrderById(int id)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM orders WHERE id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }

    public List<(int, string, double)> GetProductsForOrder(int orderId)
    {
        var products = new List<(int, string, double)>();

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT id, product_name, product_price FROM order_items WHERE order_id = $orderId;";
            command.Parameters.AddWithValue("$orderId", orderId);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    double productPrice = reader.GetDouble(2);
                    products.Add((productId, productName, productPrice));
                }
            }
        }

        return products;
    }

    public void AddProductToOrder(int orderId, string productName, double productPrice)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Sprawdzenie, czy zamówienie istnieje
            var checkCommand = connection.CreateCommand();
            checkCommand.CommandText = "SELECT COUNT(*) FROM orders WHERE id = $orderId;";
            checkCommand.Parameters.AddWithValue("$orderId", orderId);

            long orderExists = (long)checkCommand.ExecuteScalar();
            if (orderExists == 0)
            {
                MessageBox.Show($"Order ID {orderId} does not exist. Please create the order first.");
                return;
            }

            // Dodanie produktu do zamówienia
            var command = connection.CreateCommand();
            command.CommandText = @"
        INSERT INTO order_items (order_id, product_name, product_price)
        VALUES ($orderId, $productName, $productPrice);";
            command.Parameters.AddWithValue("$orderId", orderId);
            command.Parameters.AddWithValue("$productName", productName);
            command.Parameters.AddWithValue("$productPrice", productPrice);
            command.ExecuteNonQuery();
        }
    }

    public void DeleteProductFromOrder(int productId)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM order_items WHERE id = $productId;";
            command.Parameters.AddWithValue("$productId", productId);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                Console.WriteLine($"[DEBUG] No product found with ID {productId}");
                MessageBox.Show($"No product found with ID {productId}.");
            }
            else
            {
                Console.WriteLine($"[DEBUG] Product {productId} deleted.");
            }
        }
    }
}
