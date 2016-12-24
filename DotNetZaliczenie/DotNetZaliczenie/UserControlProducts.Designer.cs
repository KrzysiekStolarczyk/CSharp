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
            this.label7 = new System.Windows.Forms.Label();
            this.MTBProducerEdit = new System.Windows.Forms.MaskedTextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.MTBProducerNew = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MTBProductPriceNew = new System.Windows.Forms.MaskedTextBox();
            this.MTBProductNameNew = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxCategoryNew = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCategoryEdit = new System.Windows.Forms.ComboBox();
            this.groupBoxfilterName = new System.Windows.Forms.GroupBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFirltrCat = new System.Windows.Forms.Button();
            this.buttonfiltrName = new System.Windows.Forms.Button();
            this.groupBoxEditProduct.SuspendLayout();
            this.groupBoxDeleteProduct.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxfilterName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditProduct
            // 
            this.groupBoxEditProduct.Controls.Add(this.label9);
            this.groupBoxEditProduct.Controls.Add(this.comboBoxCategoryEdit);
            this.groupBoxEditProduct.Controls.Add(this.label7);
            this.groupBoxEditProduct.Controls.Add(this.MTBProducerEdit);
            this.groupBoxEditProduct.Controls.Add(this.label4);
            this.groupBoxEditProduct.Controls.Add(this.MTBProductPriceEdit);
            this.groupBoxEditProduct.Controls.Add(this.label5);
            this.groupBoxEditProduct.Controls.Add(this.MTBProductNameEdit);
            this.groupBoxEditProduct.Controls.Add(this.buttonEditProduct);
            this.groupBoxEditProduct.Location = new System.Drawing.Point(522, 332);
            this.groupBoxEditProduct.Name = "groupBoxEditProduct";
            this.groupBoxEditProduct.Size = new System.Drawing.Size(200, 162);
            this.groupBoxEditProduct.TabIndex = 9;
            this.groupBoxEditProduct.TabStop = false;
            this.groupBoxEditProduct.Text = "Edytuj informacje o produkcie";
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
            this.buttonEditProduct.Location = new System.Drawing.Point(54, 119);
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
            this.groupBoxDeleteProduct.Location = new System.Drawing.Point(522, 226);
            this.groupBoxDeleteProduct.Name = "groupBoxDeleteProduct";
            this.groupBoxDeleteProduct.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDeleteProduct.TabIndex = 8;
            this.groupBoxDeleteProduct.TabStop = false;
            this.groupBoxDeleteProduct.Text = "Usuń produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
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
            this.labelinfoProducts.Size = new System.Drawing.Size(202, 20);
            this.labelinfoProducts.TabIndex = 7;
            this.labelinfoProducts.Text = "Zarządzanie produkatmi";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.label8);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxCategoryNew);
            this.groupBoxAddProduct.Controls.Add(this.label6);
            this.groupBoxAddProduct.Controls.Add(this.MTBProducerNew);
            this.groupBoxAddProduct.Controls.Add(this.label3);
            this.groupBoxAddProduct.Controls.Add(this.label2);
            this.groupBoxAddProduct.Controls.Add(this.MTBProductPriceNew);
            this.groupBoxAddProduct.Controls.Add(this.MTBProductNameNew);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddNewProduct);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(522, 50);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(200, 170);
            this.groupBoxAddProduct.TabIndex = 6;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Dodaj nowy produkt";
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
            this.buttonAddNewProduct.Location = new System.Drawing.Point(54, 127);
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
            this.dataGridViewProducts.Size = new System.Drawing.Size(497, 369);
            this.dataGridViewProducts.TabIndex = 5;
            this.dataGridViewProducts.TabStop = false;
            // 
            // comboBoxCategoryNew
            // 
            this.comboBoxCategoryNew.FormattingEnabled = true;
            this.comboBoxCategoryNew.Location = new System.Drawing.Point(6, 102);
            this.comboBoxCategoryNew.Name = "comboBoxCategoryNew";
            this.comboBoxCategoryNew.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCategoryNew.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kategoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kategoria";
            // 
            // comboBoxCategoryEdit
            // 
            this.comboBoxCategoryEdit.FormattingEnabled = true;
            this.comboBoxCategoryEdit.Location = new System.Drawing.Point(6, 97);
            this.comboBoxCategoryEdit.Name = "comboBoxCategoryEdit";
            this.comboBoxCategoryEdit.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCategoryEdit.TabIndex = 20;
            // 
            // groupBoxfilterName
            // 
            this.groupBoxfilterName.Controls.Add(this.buttonfiltrName);
            this.groupBoxfilterName.Controls.Add(this.comboBoxName);
            this.groupBoxfilterName.Location = new System.Drawing.Point(16, 433);
            this.groupBoxfilterName.Name = "groupBoxfilterName";
            this.groupBoxfilterName.Size = new System.Drawing.Size(249, 61);
            this.groupBoxfilterName.TabIndex = 10;
            this.groupBoxfilterName.TabStop = false;
            this.groupBoxfilterName.Text = "Filtrowania po nazwie";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(6, 18);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 19);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFirltrCat);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(288, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrowania po kategorii";
            // 
            // buttonFirltrCat
            // 
            this.buttonFirltrCat.Location = new System.Drawing.Point(134, 18);
            this.buttonFirltrCat.Name = "buttonFirltrCat";
            this.buttonFirltrCat.Size = new System.Drawing.Size(75, 23);
            this.buttonFirltrCat.TabIndex = 2;
            this.buttonFirltrCat.Text = "Filtruj";
            this.buttonFirltrCat.UseVisualStyleBackColor = true;
            this.buttonFirltrCat.Click += new System.EventHandler(this.buttonFirltrCat_Click);
            // 
            // buttonfiltrName
            // 
            this.buttonfiltrName.Location = new System.Drawing.Point(133, 18);
            this.buttonfiltrName.Name = "buttonfiltrName";
            this.buttonfiltrName.Size = new System.Drawing.Size(75, 23);
            this.buttonfiltrName.TabIndex = 3;
            this.buttonfiltrName.Text = "Filtruj";
            this.buttonfiltrName.UseVisualStyleBackColor = true;
            this.buttonfiltrName.Click += new System.EventHandler(this.buttonfiltrName_Click);
            // 
            // UserControlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxfilterName);
            this.Controls.Add(this.groupBoxEditProduct);
            this.Controls.Add(this.groupBoxDeleteProduct);
            this.Controls.Add(this.labelinfoProducts);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "UserControlProducts";
            this.Size = new System.Drawing.Size(725, 521);
            this.groupBoxEditProduct.ResumeLayout(false);
            this.groupBoxEditProduct.PerformLayout();
            this.groupBoxDeleteProduct.ResumeLayout(false);
            this.groupBoxDeleteProduct.PerformLayout();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxfilterName.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCategoryEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCategoryNew;
        private System.Windows.Forms.GroupBox groupBoxfilterName;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonfiltrName;
        private System.Windows.Forms.Button buttonFirltrCat;
    }
}
