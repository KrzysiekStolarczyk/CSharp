namespace DotNetZaliczenie
{
    partial class UserControlOrders
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
            this.labelOrders = new System.Windows.Forms.Label();
            this.groupBoxAddOrder = new System.Windows.Forms.GroupBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxQuantityEdit = new System.Windows.Forms.ComboBox();
            this.comboBoxClientedit = new System.Windows.Forms.ComboBox();
            this.comboBoxProductsEdit = new System.Windows.Forms.ComboBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.groupBoxDeleteOrder = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAddOrder.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxDeleteOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrders.Location = new System.Drawing.Point(3, 16);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(224, 20);
            this.labelOrders.TabIndex = 8;
            this.labelOrders.Text = "Zarządzanie zamówieniami";
            // 
            // groupBoxAddOrder
            // 
            this.groupBoxAddOrder.Controls.Add(this.buttonAddOrder);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxQuantity);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxClient);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxProducts);
            this.groupBoxAddOrder.Location = new System.Drawing.Point(7, 326);
            this.groupBoxAddOrder.Name = "groupBoxAddOrder";
            this.groupBoxAddOrder.Size = new System.Drawing.Size(229, 113);
            this.groupBoxAddOrder.TabIndex = 9;
            this.groupBoxAddOrder.TabStop = false;
            this.groupBoxAddOrder.Text = "Dodaj zamówienie";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(146, 33);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 46);
            this.buttonAddOrder.TabIndex = 11;
            this.buttonAddOrder.Text = "Dodaj";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Location = new System.Drawing.Point(19, 74);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuantity.TabIndex = 2;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(19, 47);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 1;
            this.comboBoxClient.SelectedValueChanged += new System.EventHandler(this.GetInfoAboutSelectedClient);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(19, 20);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.GetInfoAboutSelectedProduct);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.buttonEdit);
            this.groupBoxEdit.Controls.Add(this.comboBoxQuantityEdit);
            this.groupBoxEdit.Controls.Add(this.comboBoxClientedit);
            this.groupBoxEdit.Controls.Add(this.comboBoxProductsEdit);
            this.groupBoxEdit.Location = new System.Drawing.Point(242, 326);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(245, 113);
            this.groupBoxEdit.TabIndex = 10;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edytuj zamówienie";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(148, 32);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 46);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxQuantityEdit
            // 
            this.comboBoxQuantityEdit.FormattingEnabled = true;
            this.comboBoxQuantityEdit.Location = new System.Drawing.Point(21, 73);
            this.comboBoxQuantityEdit.Name = "comboBoxQuantityEdit";
            this.comboBoxQuantityEdit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuantityEdit.TabIndex = 14;
            // 
            // comboBoxClientedit
            // 
            this.comboBoxClientedit.FormattingEnabled = true;
            this.comboBoxClientedit.Location = new System.Drawing.Point(21, 46);
            this.comboBoxClientedit.Name = "comboBoxClientedit";
            this.comboBoxClientedit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientedit.TabIndex = 13;
            this.comboBoxClientedit.SelectedIndexChanged += new System.EventHandler(this.GetInfoAboutSelectedClient);
            // 
            // comboBoxProductsEdit
            // 
            this.comboBoxProductsEdit.FormattingEnabled = true;
            this.comboBoxProductsEdit.Location = new System.Drawing.Point(21, 19);
            this.comboBoxProductsEdit.Name = "comboBoxProductsEdit";
            this.comboBoxProductsEdit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductsEdit.TabIndex = 12;
            this.comboBoxProductsEdit.SelectedIndexChanged += new System.EventHandler(this.GetInfoAboutSelectedProduct);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(13, 39);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(707, 281);
            this.dataGridViewOrders.TabIndex = 11;
            this.dataGridViewOrders.TabStop = false;
            // 
            // groupBoxDeleteOrder
            // 
            this.groupBoxDeleteOrder.Controls.Add(this.label1);
            this.groupBoxDeleteOrder.Controls.Add(this.buttonDeleteOrder);
            this.groupBoxDeleteOrder.Location = new System.Drawing.Point(493, 335);
            this.groupBoxDeleteOrder.Name = "groupBoxDeleteOrder";
            this.groupBoxDeleteOrder.Size = new System.Drawing.Size(215, 104);
            this.groupBoxDeleteOrder.TabIndex = 12;
            this.groupBoxDeleteOrder.TabStop = false;
            this.groupBoxDeleteOrder.Text = "Usuń zamówienie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaznacz w tabeli zamówienie do usunięcia";
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(58, 57);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(75, 37);
            this.buttonDeleteOrder.TabIndex = 1;
            this.buttonDeleteOrder.Text = "Usuń";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(347, 445);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(107, 70);
            this.buttonPdf.TabIndex = 0;
            this.buttonPdf.Text = "Generuj PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zaznacz w tabeli zamówienie dla którego chcesz wygenerować PDF";
            // 
            // UserControlOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.groupBoxDeleteOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAddOrder);
            this.Controls.Add(this.labelOrders);
            this.Name = "UserControlOrders";
            this.Size = new System.Drawing.Size(723, 518);
            this.groupBoxAddOrder.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxDeleteOrder.ResumeLayout(false);
            this.groupBoxDeleteOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.GroupBox groupBoxAddOrder;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.GroupBox groupBoxDeleteOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxQuantityEdit;
        private System.Windows.Forms.ComboBox comboBoxClientedit;
        private System.Windows.Forms.ComboBox comboBoxProductsEdit;
        private System.Windows.Forms.Label label2;
    }
}
