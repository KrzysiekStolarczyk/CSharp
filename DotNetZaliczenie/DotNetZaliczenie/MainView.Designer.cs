namespace DotNetZaliczenie
{
    partial class MainView
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
            this.tabControlCategory = new System.Windows.Forms.TabControl();
            this.tabPageWarehouseStock = new System.Windows.Forms.TabPage();
            this.userControlWarehouseStock1 = new DotNetZaliczenie.UserControlWarehouseStock();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.userControlProducts1 = new DotNetZaliczenie.UserControlProducts();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.userControlClients1 = new DotNetZaliczenie.UserControlClients();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlOrders1 = new DotNetZaliczenie.UserControlOrders();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControlCategory1 = new DotNetZaliczenie.UserControlCategory();
            this.tabControlCategory.SuspendLayout();
            this.tabPageWarehouseStock.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCategory
            // 
            this.tabControlCategory.Controls.Add(this.tabPageWarehouseStock);
            this.tabControlCategory.Controls.Add(this.tabPageProducts);
            this.tabControlCategory.Controls.Add(this.tabPageClients);
            this.tabControlCategory.Controls.Add(this.tabPage1);
            this.tabControlCategory.Controls.Add(this.tabPageCategory);
            this.tabControlCategory.Location = new System.Drawing.Point(12, 21);
            this.tabControlCategory.Name = "tabControlCategory";
            this.tabControlCategory.SelectedIndex = 0;
            this.tabControlCategory.Size = new System.Drawing.Size(724, 598);
            this.tabControlCategory.TabIndex = 0;
            // 
            // tabPageWarehouseStock
            // 
            this.tabPageWarehouseStock.Controls.Add(this.userControlWarehouseStock1);
            this.tabPageWarehouseStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageWarehouseStock.Name = "tabPageWarehouseStock";
            this.tabPageWarehouseStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWarehouseStock.Size = new System.Drawing.Size(716, 572);
            this.tabPageWarehouseStock.TabIndex = 0;
            this.tabPageWarehouseStock.Text = "Warehouse Stock";
            this.tabPageWarehouseStock.UseVisualStyleBackColor = true;
            // 
            // userControlWarehouseStock1
            // 
            this.userControlWarehouseStock1.Location = new System.Drawing.Point(6, 6);
            this.userControlWarehouseStock1.Name = "userControlWarehouseStock1";
            this.userControlWarehouseStock1.Size = new System.Drawing.Size(583, 398);
            this.userControlWarehouseStock1.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.userControlProducts1);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(716, 572);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // userControlProducts1
            // 
            this.userControlProducts1.Location = new System.Drawing.Point(6, 6);
            this.userControlProducts1.Name = "userControlProducts1";
            this.userControlProducts1.Size = new System.Drawing.Size(704, 560);
            this.userControlProducts1.TabIndex = 0;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.userControlClients1);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(716, 572);
            this.tabPageClients.TabIndex = 2;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // userControlClients1
            // 
            this.userControlClients1.Location = new System.Drawing.Point(6, 6);
            this.userControlClients1.Name = "userControlClients1";
            this.userControlClients1.Size = new System.Drawing.Size(677, 554);
            this.userControlClients1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userControlOrders1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 572);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlOrders1
            // 
            this.userControlOrders1.Location = new System.Drawing.Point(6, 6);
            this.userControlOrders1.Name = "userControlOrders1";
            this.userControlOrders1.Size = new System.Drawing.Size(704, 526);
            this.userControlOrders1.TabIndex = 0;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.userControlCategory1);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(716, 572);
            this.tabPageCategory.TabIndex = 4;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // userControlCategory1
            // 
            this.userControlCategory1.Location = new System.Drawing.Point(6, 6);
            this.userControlCategory1.Name = "userControlCategory1";
            this.userControlCategory1.Size = new System.Drawing.Size(597, 416);
            this.userControlCategory1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 621);
            this.Controls.Add(this.tabControlCategory);
            this.Name = "MainView";
            this.Text = "Panel Główny";
            this.tabControlCategory.ResumeLayout(false);
            this.tabPageWarehouseStock.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCategory;
        private System.Windows.Forms.TabPage tabPageWarehouseStock;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlWarehouseStock userControlWarehouseStock1;
        private UserControlProducts userControlProducts1;
        private System.Windows.Forms.TabPage tabPageClients;
        private UserControlClients userControlClients1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControlOrders userControlOrders1;
        private System.Windows.Forms.TabPage tabPageCategory;
        private UserControlCategory userControlCategory1;
    }
}

