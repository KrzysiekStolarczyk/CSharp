namespace ProjektNaZaliczenie
{
    partial class ManinWindow
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
            this.buttonWarehouseStock = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWarehouseStock
            // 
            this.buttonWarehouseStock.Location = new System.Drawing.Point(12, 55);
            this.buttonWarehouseStock.Name = "buttonWarehouseStock";
            this.buttonWarehouseStock.Size = new System.Drawing.Size(173, 39);
            this.buttonWarehouseStock.TabIndex = 0;
            this.buttonWarehouseStock.Text = "Baza Stoku Magazynowego";
            this.buttonWarehouseStock.UseVisualStyleBackColor = true;
            this.buttonWarehouseStock.Click += new System.EventHandler(this.buttonWarehouseStock_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(12, 100);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(173, 39);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Baza Klientów";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(12, 145);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(173, 39);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Baza Produktów";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(12, 202);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(296, 78);
            this.buttonOrders.TabIndex = 3;
            this.buttonOrders.Text = "Zamówenia";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // ManinWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonWarehouseStock);
            this.Name = "ManinWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWarehouseStock;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonOrders;
    }
}

