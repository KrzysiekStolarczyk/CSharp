namespace DotNetZaliczenie
{
    partial class UserControlProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEditProduct = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTBProductPriceEdit = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MTBProductNameEdit = new System.Windows.Forms.MaskedTextBox();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.groupBoxDeleteProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.labelinfoProducts = new System.Windows.Forms.Label();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MTBProductPriceNew = new System.Windows.Forms.MaskedTextBox();
            this.MTBProductNameNew = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.MTBProducerEdit = new System.Windows.Forms.MaskedTextBox();
            this.MTBProducerNew = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxEditProduct.SuspendLayout();
            this.groupBoxDeleteProduct.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEditProduct
            // 
            this.groupBoxEditProduct.Controls.Add(this.label7);
            this.groupBoxEditProduct.Controls.Add(this.MTBProducerEdit);
            this.groupBoxEditProduct.Controls.Add(this.label4);
            this.groupBoxEditProduct.Controls.Add(this.MTBProductPriceEdit);
            this.groupBoxEditProduct.Controls.Add(this.label5);
            this.groupBoxEditProduct.Controls.Add(this.MTBProductNameEdit);
            this.groupBoxEditProduct.Controls.Add(this.buttonEditProduct);
            this.groupBoxEditProduct.Location = new System.Drawing.Point(440, 294);
            this.groupBoxEditProduct.Name = "groupBoxEditProduct";
            this.groupBoxEditProduct.Size = new System.Drawing.Size(200, 140);
            this.groupBoxEditProduct.TabIndex = 9;
            this.groupBoxEditProduct.TabStop = false;
            this.groupBoxEditProduct.Text = "Edytuj informacje o produkcie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cena";
            // 
            // MTBProductPriceEdit
            // 
            this.MTBProductPriceEdit.Location = new System.Drawing.Point(6, 45);
            this.MTBProductPriceEdit.Mask = "999.99 ";
            this.MTBProductPriceEdit.Name = "MTBProductPriceEdit";
            this.MTBProductPriceEdit.PromptChar = ' ';
            this.MTBProductPriceEdit.Size = new System.Drawing.Size(116, 20);
            this.MTBProductPriceEdit.TabIndex = 14;
            this.MTBProductPriceEdit.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nazwa";
            // 
            // MTBProductNameEdit
            // 
            this.MTBProductNameEdit.Location = new System.Drawing.Point(6, 19);
            this.MTBProductNameEdit.Mask = "?????????????????????";
            this.MTBProductNameEdit.Name = "MTBProductNameEdit";
            this.MTBProductNameEdit.PromptChar = ' ';
            this.MTBProductNameEdit.Size = new System.Drawing.Size(116, 20);
            this.MTBProductNameEdit.TabIndex = 14;
            this.MTBProductNameEdit.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(58, 97);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(75, 37);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.Text = "Edytuj";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // groupBoxDeleteProduct
            // 
            this.groupBoxDeleteProduct.Controls.Add(this.label1);
            this.groupBoxDeleteProduct.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxDeleteProduct.Location = new System.Drawing.Point(444, 194);
            this.groupBoxDeleteProduct.Name = "groupBoxDeleteProduct";
            this.groupBoxDeleteProduct.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDeleteProduct.TabIndex = 8;
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
            // labelinfoProducts
            // 
            this.labelinfoProducts.AutoSize = true;
            this.labelinfoProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelinfoProducts.Location = new System.Drawing.Point(12, 9);
            this.labelinfoProducts.Name = "labelinfoProducts";
            this.labelinfoProducts.Size = new System.Drawing.Size(199, 20);
            this.labelinfoProducts.TabIndex = 7;
            this.labelinfoProducts.Text = "Zarządzanie artykulami.";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.label6);
            this.groupBoxAddProduct.Controls.Add(this.MTBProducerNew);
            this.groupBoxAddProduct.Controls.Add(this.label3);
            this.groupBoxAddProduct.Controls.Add(this.label2);
            this.groupBoxAddProduct.Controls.Add(this.MTBProductPriceNew);
            this.groupBoxAddProduct.Controls.Add(this.MTBProductNameNew);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddNewProduct);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(444, 50);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(200, 143);
            this.groupBoxAddProduct.TabIndex = 6;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Dodaj nowy produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nazwa";
            // 
            // MTBProductPriceNew
            // 
            this.MTBProductPriceNew.Location = new System.Drawing.Point(6, 49);
            this.MTBProductPriceNew.Mask = "999.99 ";
            this.MTBProductPriceNew.Name = "MTBProductPriceNew";
            this.MTBProductPriceNew.PromptChar = ' ';
            this.MTBProductPriceNew.Size = new System.Drawing.Size(116, 20);
            this.MTBProductPriceNew.TabIndex = 13;
            this.MTBProductPriceNew.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // MTBProductNameNew
            // 
            this.MTBProductNameNew.Location = new System.Drawing.Point(6, 19);
            this.MTBProductNameNew.Mask = "?????????????????????";
            this.MTBProductNameNew.Name = "MTBProductNameNew";
            this.MTBProductNameNew.PromptChar = ' ';
            this.MTBProductNameNew.Size = new System.Drawing.Size(116, 20);
            this.MTBProductNameNew.TabIndex = 12;
            this.MTBProductNameNew.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(54, 101);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(75, 37);
            this.buttonAddNewProduct.TabIndex = 1;
            this.buttonAddNewProduct.Text = "Dodaj";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(15, 50);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(423, 384);
            this.dataGridViewProducts.TabIndex = 5;
            this.dataGridViewProducts.TabStop = false;
            // 
            // MTBProducerEdit
            // 
            this.MTBProducerEdit.Location = new System.Drawing.Point(6, 71);
            this.MTBProducerEdit.Mask = "?????????????";
            this.MTBProducerEdit.Name = "MTBProducerEdit";
            this.MTBProducerEdit.PromptChar = ' ';
            this.MTBProducerEdit.Size = new System.Drawing.Size(116, 20);
            this.MTBProducerEdit.TabIndex = 18;
            this.MTBProducerEdit.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // MTBProducerNew
            // 
            this.MTBProducerNew.Location = new System.Drawing.Point(6, 75);
            this.MTBProducerNew.Mask = "????????????????";
            this.MTBProducerNew.Name = "MTBProducerNew";
            this.MTBProducerNew.PromptChar = ' ';
            this.MTBProducerNew.Size = new System.Drawing.Size(116, 20);
            this.MTBProducerNew.TabIndex = 16;
            this.MTBProducerNew.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Producent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Producent";
            // 
            // UserControlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEditProduct);
            this.Controls.Add(this.groupBoxDeleteProduct);
            this.Controls.Add(this.labelinfoProducts);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "UserControlProducts";
            this.Size = new System.Drawing.Size(653, 445);
            this.groupBoxEditProduct.ResumeLayout(false);
            this.groupBoxEditProduct.PerformLayout();
            this.groupBoxDeleteProduct.ResumeLayout(false);
            this.groupBoxDeleteProduct.PerformLayout();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.GroupBox groupBoxDeleteProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Label labelinfoProducts;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.MaskedTextBox MTBProductNameNew;
        private System.Windows.Forms.MaskedTextBox MTBProductNameEdit;
        private System.Windows.Forms.MaskedTextBox MTBProductPriceNew;
        private System.Windows.Forms.MaskedTextBox MTBProductPriceEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MTBProducerEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MTBProducerNew;
    }
}
