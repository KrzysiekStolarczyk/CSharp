namespace ProjektNaZaliczenie
{
    partial class Products
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.textBoxPriceProductNew = new System.Windows.Forms.TextBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.textBoxNameProductNew = new System.Windows.Forms.TextBox();
            this.labelinfoProducts = new System.Windows.Forms.Label();
            this.groupBoxDeleteProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.groupBoxEditProduct = new System.Windows.Forms.GroupBox();
            this.textBoxPriceProductEdit = new System.Windows.Forms.TextBox();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.textBoxNameProductEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxAddProduct.SuspendLayout();
            this.groupBoxDeleteProduct.SuspendLayout();
            this.groupBoxEditProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(21, 50);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(321, 334);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.TabStop = false;
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.textBoxPriceProductNew);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddNewProduct);
            this.groupBoxAddProduct.Controls.Add(this.textBoxNameProductNew);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(366, 50);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(200, 118);
            this.groupBoxAddProduct.TabIndex = 1;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Dodaj nowy produkt";
            // 
            // textBoxPriceProductNew
            // 
            this.textBoxPriceProductNew.Location = new System.Drawing.Point(6, 49);
            this.textBoxPriceProductNew.Name = "textBoxPriceProductNew";
            this.textBoxPriceProductNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxPriceProductNew.TabIndex = 3;
            this.textBoxPriceProductNew.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxPriceProductNew.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(58, 75);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(75, 37);
            this.buttonAddNewProduct.TabIndex = 1;
            this.buttonAddNewProduct.Text = "Dodaj";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // textBoxNameProductNew
            // 
            this.textBoxNameProductNew.Location = new System.Drawing.Point(6, 19);
            this.textBoxNameProductNew.Name = "textBoxNameProductNew";
            this.textBoxNameProductNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxNameProductNew.TabIndex = 0;
            this.textBoxNameProductNew.Tag = "Test";
            this.textBoxNameProductNew.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxNameProductNew.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // labelinfoProducts
            // 
            this.labelinfoProducts.AutoSize = true;
            this.labelinfoProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelinfoProducts.Location = new System.Drawing.Point(18, 9);
            this.labelinfoProducts.Name = "labelinfoProducts";
            this.labelinfoProducts.Size = new System.Drawing.Size(199, 20);
            this.labelinfoProducts.TabIndex = 2;
            this.labelinfoProducts.Text = "Zarządzanie artykulami.";
            // 
            // groupBoxDeleteProduct
            // 
            this.groupBoxDeleteProduct.Controls.Add(this.label1);
            this.groupBoxDeleteProduct.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxDeleteProduct.Location = new System.Drawing.Point(366, 174);
            this.groupBoxDeleteProduct.Name = "groupBoxDeleteProduct";
            this.groupBoxDeleteProduct.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDeleteProduct.TabIndex = 3;
            this.groupBoxDeleteProduct.TabStop = false;
            this.groupBoxDeleteProduct.Text = "Usuń produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaznacz w tabeli produkt do usunięcia";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(58, 57);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 37);
            this.buttonDeleteProduct.TabIndex = 1;
            this.buttonDeleteProduct.Text = "Usuń";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // groupBoxEditProduct
            // 
            this.groupBoxEditProduct.Controls.Add(this.textBoxPriceProductEdit);
            this.groupBoxEditProduct.Controls.Add(this.buttonEditProduct);
            this.groupBoxEditProduct.Controls.Add(this.textBoxNameProductEdit);
            this.groupBoxEditProduct.Location = new System.Drawing.Point(366, 298);
            this.groupBoxEditProduct.Name = "groupBoxEditProduct";
            this.groupBoxEditProduct.Size = new System.Drawing.Size(200, 134);
            this.groupBoxEditProduct.TabIndex = 4;
            this.groupBoxEditProduct.TabStop = false;
            this.groupBoxEditProduct.Text = "Edytuj informacje o produkcie";
            // 
            // textBoxPriceProductEdit
            // 
            this.textBoxPriceProductEdit.Location = new System.Drawing.Point(6, 45);
            this.textBoxPriceProductEdit.Name = "textBoxPriceProductEdit";
            this.textBoxPriceProductEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxPriceProductEdit.TabIndex = 2;
            this.textBoxPriceProductEdit.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxPriceProductEdit.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(58, 81);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(75, 37);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.Text = "Edytuj";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // textBoxNameProductEdit
            // 
            this.textBoxNameProductEdit.Location = new System.Drawing.Point(6, 19);
            this.textBoxNameProductEdit.Name = "textBoxNameProductEdit";
            this.textBoxNameProductEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxNameProductEdit.TabIndex = 0;
            this.textBoxNameProductEdit.Tag = "";
            this.textBoxNameProductEdit.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxNameProductEdit.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 464);
            this.Controls.Add(this.groupBoxEditProduct);
            this.Controls.Add(this.groupBoxDeleteProduct);
            this.Controls.Add(this.labelinfoProducts);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            this.groupBoxDeleteProduct.ResumeLayout(false);
            this.groupBoxDeleteProduct.PerformLayout();
            this.groupBoxEditProduct.ResumeLayout(false);
            this.groupBoxEditProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.TextBox textBoxNameProductNew;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Label labelinfoProducts;
        private System.Windows.Forms.TextBox textBoxPriceProductNew;
        private System.Windows.Forms.GroupBox groupBoxDeleteProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.GroupBox groupBoxEditProduct;
        private System.Windows.Forms.TextBox textBoxPriceProductEdit;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.TextBox textBoxNameProductEdit;
    }
}