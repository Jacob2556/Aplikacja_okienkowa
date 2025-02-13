namespace Aplikacja_okienkowa
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            F2OrderIDText = new TextBox();
            F2OrderID = new Label();
            F2OrderName = new Label();
            F2Product = new Label();
            F2Price = new Label();
            F2OrderNameText = new TextBox();
            F2ProductText = new TextBox();
            F2PriceText = new TextBox();
            F2Products = new ListView();
            ProductName = new ColumnHeader();
            ProductPrice = new ColumnHeader();
            AddToOrder = new Button();
            DeleteFromOrder = new Button();
            SaveOrder = new Button();
            SuspendLayout();
            // 
            // F2OrderIDText
            // 
            F2OrderIDText.AccessibleName = "F2OrderIDText";
            F2OrderIDText.Location = new Point(165, 43);
            F2OrderIDText.Name = "F2OrderIDText";
            F2OrderIDText.Size = new Size(100, 23);
            F2OrderIDText.TabIndex = 0;
            F2OrderIDText.KeyPress += F2OrderIDText_KeyPress;
            // 
            // F2OrderID
            // 
            F2OrderID.AccessibleName = "F2OrderID";
            F2OrderID.AutoSize = true;
            F2OrderID.Location = new Point(55, 43);
            F2OrderID.Name = "F2OrderID";
            F2OrderID.Size = new Size(51, 15);
            F2OrderID.TabIndex = 1;
            F2OrderID.Text = "Order ID";
            // 
            // F2OrderName
            // 
            F2OrderName.AccessibleName = "F2OrderName";
            F2OrderName.AutoSize = true;
            F2OrderName.Location = new Point(55, 83);
            F2OrderName.Name = "F2OrderName";
            F2OrderName.Size = new Size(72, 15);
            F2OrderName.TabIndex = 2;
            F2OrderName.Text = "Order Name";
            // 
            // F2Product
            // 
            F2Product.AccessibleName = "F2Product";
            F2Product.AutoSize = true;
            F2Product.Location = new Point(55, 121);
            F2Product.Name = "F2Product";
            F2Product.Size = new Size(49, 15);
            F2Product.TabIndex = 3;
            F2Product.Text = "Product";
            // 
            // F2Price
            // 
            F2Price.AccessibleName = "F2Price";
            F2Price.AutoSize = true;
            F2Price.Location = new Point(55, 163);
            F2Price.Name = "F2Price";
            F2Price.Size = new Size(33, 15);
            F2Price.TabIndex = 4;
            F2Price.Text = "Price";
            // 
            // F2OrderNameText
            // 
            F2OrderNameText.AccessibleName = "F2OrderNameText";
            F2OrderNameText.Location = new Point(166, 83);
            F2OrderNameText.Name = "F2OrderNameText";
            F2OrderNameText.Size = new Size(100, 23);
            F2OrderNameText.TabIndex = 5;
            // 
            // F2ProductText
            // 
            F2ProductText.AccessibleName = "F2ProductText";
            F2ProductText.Location = new Point(166, 121);
            F2ProductText.Name = "F2ProductText";
            F2ProductText.Size = new Size(100, 23);
            F2ProductText.TabIndex = 6;
            // 
            // F2PriceText
            // 
            F2PriceText.AccessibleName = "F2PriceText";
            F2PriceText.Location = new Point(165, 163);
            F2PriceText.Name = "F2PriceText";
            F2PriceText.Size = new Size(100, 23);
            F2PriceText.TabIndex = 7;
            // 
            // F2Products
            // 
            F2Products.AccessibleName = "F2Products";
            F2Products.Columns.AddRange(new ColumnHeader[] { ProductName, ProductPrice });
            F2Products.FullRowSelect = true;
            F2Products.GridLines = true;
            F2Products.Location = new Point(55, 221);
            F2Products.Name = "F2Products";
            F2Products.Size = new Size(246, 143);
            F2Products.TabIndex = 8;
            F2Products.UseCompatibleStateImageBehavior = false;
            F2Products.View = View.Details;
            // 
            // ProductName
            // 
            ProductName.Text = "Product Name";
            ProductName.Width = 120;
            // 
            // ProductPrice
            // 
            ProductPrice.Text = "Product Price";
            ProductPrice.Width = 120;
            // 
            // AddToOrder
            // 
            AddToOrder.AccessibleName = "AddToOrder";
            AddToOrder.Location = new Point(334, 221);
            AddToOrder.Name = "AddToOrder";
            AddToOrder.Size = new Size(122, 23);
            AddToOrder.TabIndex = 9;
            AddToOrder.Text = "Add To Order";
            AddToOrder.UseVisualStyleBackColor = true;
            AddToOrder.Click += AddToOrder_Click;
            // 
            // DeleteFromOrder
            // 
            DeleteFromOrder.AccessibleName = "DeleteFromOrder";
            DeleteFromOrder.Location = new Point(334, 279);
            DeleteFromOrder.Name = "DeleteFromOrder";
            DeleteFromOrder.Size = new Size(122, 23);
            DeleteFromOrder.TabIndex = 10;
            DeleteFromOrder.Text = "Delete From Order";
            DeleteFromOrder.UseVisualStyleBackColor = true;
            DeleteFromOrder.Click += DeleteFromOrder_Click1;
            // 
            // SaveOrder
            // 
            SaveOrder.AccessibleName = "SaveOrder";
            SaveOrder.Location = new Point(334, 341);
            SaveOrder.Name = "SaveOrder";
            SaveOrder.Size = new Size(122, 23);
            SaveOrder.TabIndex = 11;
            SaveOrder.Text = "Save Order";
            SaveOrder.UseVisualStyleBackColor = true;
            SaveOrder.Click += SaveOrder_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 411);
            Controls.Add(SaveOrder);
            Controls.Add(DeleteFromOrder);
            Controls.Add(AddToOrder);
            Controls.Add(F2Products);
            Controls.Add(F2PriceText);
            Controls.Add(F2ProductText);
            Controls.Add(F2OrderNameText);
            Controls.Add(F2Price);
            Controls.Add(F2Product);
            Controls.Add(F2OrderName);
            Controls.Add(F2OrderID);
            Controls.Add(F2OrderIDText);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void DeleteFromOrder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox F2OrderIDText;
        private Label F2OrderID;
        private Label F2OrderName;
        private Label F2Product;
        private Label F2Price;
        private TextBox F2OrderNameText;
        private TextBox F2ProductText;
        private TextBox F2PriceText;
        private ListView F2Products;
        private ColumnHeader ProductName;
        private ColumnHeader ProductPrice;
        private Button AddToOrder;
        private Button DeleteFromOrder;
        private Button SaveOrder;
    }
}