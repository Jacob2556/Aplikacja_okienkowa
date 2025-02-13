namespace Aplikacja_okienkowa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddOrder = new Button();
            DeleteOrder = new Button();
            GetOrders = new Button();
            OrderDetails = new Button();
            ListOfOrders = new ListView();
            OrderID = new ColumnHeader();
            OrderName = new ColumnHeader();
            SuspendLayout();
            // 
            // AddOrder
            // 
            AddOrder.AccessibleName = "AddOrder";
            AddOrder.Location = new Point(432, 81);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(106, 23);
            AddOrder.TabIndex = 0;
            AddOrder.Text = "Add Order";
            AddOrder.UseVisualStyleBackColor = true;
            AddOrder.Click += AddOrder_Click;
            // 
            // DeleteOrder
            // 
            DeleteOrder.AccessibleName = "DeleteOrder";
            DeleteOrder.Location = new Point(432, 124);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(106, 23);
            DeleteOrder.TabIndex = 1;
            DeleteOrder.Text = "Delete Order";
            DeleteOrder.UseVisualStyleBackColor = true;
            DeleteOrder.Click += DeleteOrder_Click;
            // 
            // GetOrders
            // 
            GetOrders.AccessibleName = "GetOrders";
            GetOrders.Location = new Point(432, 169);
            GetOrders.Name = "GetOrders";
            GetOrders.Size = new Size(106, 23);
            GetOrders.TabIndex = 2;
            GetOrders.Text = "Get Orders";
            GetOrders.UseVisualStyleBackColor = true;
            GetOrders.Click += GetOrders_Click;
            // 
            // OrderDetails
            // 
            OrderDetails.AccessibleName = "OrderDetails";
            OrderDetails.Location = new Point(432, 214);
            OrderDetails.Name = "OrderDetails";
            OrderDetails.Size = new Size(106, 23);
            OrderDetails.TabIndex = 3;
            OrderDetails.Text = "Order Details";
            OrderDetails.UseVisualStyleBackColor = true;
            OrderDetails.Click += OrderDetails_Click;
            // 
            // ListOfOrders
            // 
            ListOfOrders.AccessibleName = "ListOfOrders";
            ListOfOrders.Columns.AddRange(new ColumnHeader[] { OrderID, OrderName });
            ListOfOrders.FullRowSelect = true;
            ListOfOrders.GridLines = true;
            ListOfOrders.Location = new Point(147, 81);
            ListOfOrders.Name = "ListOfOrders";
            ListOfOrders.Size = new Size(245, 156);
            ListOfOrders.TabIndex = 4;
            ListOfOrders.UseCompatibleStateImageBehavior = false;
            ListOfOrders.View = View.Details;
            ListOfOrders.SelectedIndexChanged += ListOfOrders_SelectedIndexChanged;
            // 
            // OrderID
            // 
            OrderID.Text = "Order ID";
            OrderID.Width = 120;
            // 
            // OrderName
            // 
            OrderName.Text = "Order Name";
            OrderName.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListOfOrders);
            Controls.Add(OrderDetails);
            Controls.Add(GetOrders);
            Controls.Add(DeleteOrder);
            Controls.Add(AddOrder);
            Name = "Form1";
            Text = "Order Box";
            ResumeLayout(false);
        }

        #endregion

        private Button AddOrder;
        private Button DeleteOrder;
        private Button GetOrders;
        private Button OrderDetails;
        private ListView ListOfOrders;
        private ColumnHeader OrderID;
        private ColumnHeader OrderName;
    }
}
