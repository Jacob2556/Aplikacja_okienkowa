namespace Aplikacja_okienkowa
{
    partial class Form3
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
            BackToOrders = new Button();
            listView1 = new ListView();
            F3ProductName = new ColumnHeader();
            F3ProductPrice = new ColumnHeader();
            DeleteFromOrder = new Button();
            AddToOrder = new Button();
            OrderID = new Label();
            OrderName = new Label();
            F3ProductID = new ColumnHeader();
            SuspendLayout();
            // 
            // BackToOrders
            // 
            BackToOrders.AccessibleName = "BackToOrders";
            BackToOrders.Location = new Point(353, 415);
            BackToOrders.Name = "BackToOrders";
            BackToOrders.Size = new Size(121, 23);
            BackToOrders.TabIndex = 0;
            BackToOrders.Text = "Back To Orders";
            BackToOrders.UseVisualStyleBackColor = true;
            BackToOrders.Click += BackToOrders_Click;
            // 
            // listView1
            // 
            listView1.AccessibleName = "F3OrderDetails";
            listView1.Columns.AddRange(new ColumnHeader[] { F3ProductID, F3ProductName, F3ProductPrice });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(50, 94);
            listView1.Name = "listView1";
            listView1.Size = new Size(368, 257);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // F3ProductName
            // 
            F3ProductName.Text = "Product Name";
            F3ProductName.Width = 120;
            // 
            // F3ProductPrice
            // 
            F3ProductPrice.Text = "Product Price";
            F3ProductPrice.Width = 120;
            // 
            // DeleteFromOrder
            // 
            DeleteFromOrder.AccessibleName = "DeleteFromOrder";
            DeleteFromOrder.Location = new Point(567, 127);
            DeleteFromOrder.Name = "DeleteFromOrder";
            DeleteFromOrder.Size = new Size(155, 23);
            DeleteFromOrder.TabIndex = 2;
            DeleteFromOrder.Text = "Delete From Order";
            DeleteFromOrder.UseVisualStyleBackColor = true;
            DeleteFromOrder.Click += DeleteFromOrder_Click;
            // 
            // AddToOrder
            // 
            AddToOrder.AccessibleName = "AddToOrder";
            AddToOrder.Location = new Point(567, 180);
            AddToOrder.Name = "AddToOrder";
            AddToOrder.Size = new Size(155, 23);
            AddToOrder.TabIndex = 3;
            AddToOrder.Text = "Add To Order";
            AddToOrder.UseVisualStyleBackColor = true;
            AddToOrder.Click += AddToOrder_Click;
            // 
            // OrderID
            // 
            OrderID.AccessibleName = "OrderID";
            OrderID.AutoSize = true;
            OrderID.Location = new Point(50, 48);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(54, 15);
            OrderID.TabIndex = 4;
            OrderID.Text = "Order ID:";
            // 
            // OrderName
            // 
            OrderName.AccessibleName = "OrderName";
            OrderName.AutoSize = true;
            OrderName.Location = new Point(228, 49);
            OrderName.Name = "OrderName";
            OrderName.Size = new Size(75, 15);
            OrderName.TabIndex = 5;
            OrderName.Text = "Order Name:";
            // 
            // F3ProductID
            // 
            F3ProductID.Text = "Product ID";
            F3ProductID.Width = 100;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrderName);
            Controls.Add(OrderID);
            Controls.Add(AddToOrder);
            Controls.Add(DeleteFromOrder);
            Controls.Add(listView1);
            Controls.Add(BackToOrders);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToOrders;
        private ListView listView1;
        private Button DeleteFromOrder;
        private Button AddToOrder;
        private ColumnHeader F3ProductName;
        private ColumnHeader F3ProductPrice;
        private Label OrderID;
        private Label OrderName;
        private ColumnHeader F3ProductID;
    }
}