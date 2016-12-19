namespace ProjektNaZaliczenie
{
    partial class Clients
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.groupBoxAddClients = new System.Windows.Forms.GroupBox();
            this.textBoxFirstNameClientNew = new System.Windows.Forms.TextBox();
            this.buttonAddNewClients = new System.Windows.Forms.Button();
            this.textBoxLastNameClientNew = new System.Windows.Forms.TextBox();
            this.labelinfoClients = new System.Windows.Forms.Label();
            this.groupBoxDeleteProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteClients = new System.Windows.Forms.Button();
            this.textBoxAddressClientNew = new System.Windows.Forms.TextBox();
            this.textBoxCityClientNew = new System.Windows.Forms.TextBox();
            this.textBoxPostalCodeClientNew = new System.Windows.Forms.TextBox();
            this.textBoxCountryClientNew = new System.Windows.Forms.TextBox();
            this.textBoxHomePhoneClientNew = new System.Windows.Forms.TextBox();
            this.groupBoxEditClients = new System.Windows.Forms.GroupBox();
            this.textBoxHomePhoneClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxCountryClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxPostalCodeClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxCityClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxAddressClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameClientEdit = new System.Windows.Forms.TextBox();
            this.buttonEditClients = new System.Windows.Forms.Button();
            this.textBoxLastNameClientEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBoxAddClients.SuspendLayout();
            this.groupBoxDeleteProduct.SuspendLayout();
            this.groupBoxEditClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToResizeColumns = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(21, 50);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(613, 227);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.TabStop = false;
            // 
            // groupBoxAddClients
            // 
            this.groupBoxAddClients.Controls.Add(this.textBoxHomePhoneClientNew);
            this.groupBoxAddClients.Controls.Add(this.textBoxCountryClientNew);
            this.groupBoxAddClients.Controls.Add(this.textBoxPostalCodeClientNew);
            this.groupBoxAddClients.Controls.Add(this.textBoxCityClientNew);
            this.groupBoxAddClients.Controls.Add(this.textBoxAddressClientNew);
            this.groupBoxAddClients.Controls.Add(this.textBoxFirstNameClientNew);
            this.groupBoxAddClients.Controls.Add(this.buttonAddNewClients);
            this.groupBoxAddClients.Controls.Add(this.textBoxLastNameClientNew);
            this.groupBoxAddClients.Location = new System.Drawing.Point(22, 283);
            this.groupBoxAddClients.Name = "groupBoxAddClients";
            this.groupBoxAddClients.Size = new System.Drawing.Size(200, 249);
            this.groupBoxAddClients.TabIndex = 1;
            this.groupBoxAddClients.TabStop = false;
            this.groupBoxAddClients.Text = "Dodaj nowego klienta";
            // 
            // textBoxFirstNameClientNew
            // 
            this.textBoxFirstNameClientNew.Location = new System.Drawing.Point(6, 49);
            this.textBoxFirstNameClientNew.Name = "textBoxFirstNameClientNew";
            this.textBoxFirstNameClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxFirstNameClientNew.TabIndex = 3;
            this.textBoxFirstNameClientNew.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxFirstNameClientNew.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // buttonAddNewClients
            // 
            this.buttonAddNewClients.Location = new System.Drawing.Point(58, 206);
            this.buttonAddNewClients.Name = "buttonAddNewClients";
            this.buttonAddNewClients.Size = new System.Drawing.Size(75, 37);
            this.buttonAddNewClients.TabIndex = 1;
            this.buttonAddNewClients.Text = "Dodaj";
            this.buttonAddNewClients.UseVisualStyleBackColor = true;
            this.buttonAddNewClients.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // textBoxLastNameClientNew
            // 
            this.textBoxLastNameClientNew.Location = new System.Drawing.Point(6, 19);
            this.textBoxLastNameClientNew.Name = "textBoxLastNameClientNew";
            this.textBoxLastNameClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxLastNameClientNew.TabIndex = 0;
            this.textBoxLastNameClientNew.Tag = "Test";
            this.textBoxLastNameClientNew.Click += new System.EventHandler(this.textBoxClick);
            this.textBoxLastNameClientNew.Leave += new System.EventHandler(this.textBoxDefaultValues);
            // 
            // labelinfoClients
            // 
            this.labelinfoClients.AutoSize = true;
            this.labelinfoClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelinfoClients.Location = new System.Drawing.Point(18, 9);
            this.labelinfoClients.Name = "labelinfoClients";
            this.labelinfoClients.Size = new System.Drawing.Size(189, 20);
            this.labelinfoClients.TabIndex = 2;
            this.labelinfoClients.Text = "Zarządzanie klientami.";
            // 
            // groupBoxDeleteProduct
            // 
            this.groupBoxDeleteProduct.Controls.Add(this.label1);
            this.groupBoxDeleteProduct.Controls.Add(this.buttonDeleteClients);
            this.groupBoxDeleteProduct.Location = new System.Drawing.Point(475, 292);
            this.groupBoxDeleteProduct.Name = "groupBoxDeleteProduct";
            this.groupBoxDeleteProduct.Size = new System.Drawing.Size(192, 100);
            this.groupBoxDeleteProduct.TabIndex = 3;
            this.groupBoxDeleteProduct.TabStop = false;
            this.groupBoxDeleteProduct.Text = "Usuń klienta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaznacz w tabeli klienta do usunięcia";
            // 
            // buttonDeleteClients
            // 
            this.buttonDeleteClients.Location = new System.Drawing.Point(58, 57);
            this.buttonDeleteClients.Name = "buttonDeleteClients";
            this.buttonDeleteClients.Size = new System.Drawing.Size(75, 37);
            this.buttonDeleteClients.TabIndex = 1;
            this.buttonDeleteClients.Text = "Usuń";
            this.buttonDeleteClients.UseVisualStyleBackColor = true;
            this.buttonDeleteClients.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // textBoxAddressClientNew
            // 
            this.textBoxAddressClientNew.Location = new System.Drawing.Point(6, 75);
            this.textBoxAddressClientNew.Name = "textBoxAddressClientNew";
            this.textBoxAddressClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxAddressClientNew.TabIndex = 4;
            // 
            // textBoxCityClientNew
            // 
            this.textBoxCityClientNew.Location = new System.Drawing.Point(6, 101);
            this.textBoxCityClientNew.Name = "textBoxCityClientNew";
            this.textBoxCityClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxCityClientNew.TabIndex = 5;
            // 
            // textBoxPostalCodeClientNew
            // 
            this.textBoxPostalCodeClientNew.Location = new System.Drawing.Point(6, 127);
            this.textBoxPostalCodeClientNew.Name = "textBoxPostalCodeClientNew";
            this.textBoxPostalCodeClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxPostalCodeClientNew.TabIndex = 6;
            // 
            // textBoxCountryClientNew
            // 
            this.textBoxCountryClientNew.Location = new System.Drawing.Point(6, 153);
            this.textBoxCountryClientNew.Name = "textBoxCountryClientNew";
            this.textBoxCountryClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxCountryClientNew.TabIndex = 7;
            // 
            // textBoxHomePhoneClientNew
            // 
            this.textBoxHomePhoneClientNew.Location = new System.Drawing.Point(6, 179);
            this.textBoxHomePhoneClientNew.Name = "textBoxHomePhoneClientNew";
            this.textBoxHomePhoneClientNew.Size = new System.Drawing.Size(188, 20);
            this.textBoxHomePhoneClientNew.TabIndex = 8;
            // 
            // groupBoxEditClients
            // 
            this.groupBoxEditClients.Controls.Add(this.textBoxHomePhoneClientEdit);
            this.groupBoxEditClients.Controls.Add(this.textBoxCountryClientEdit);
            this.groupBoxEditClients.Controls.Add(this.textBoxPostalCodeClientEdit);
            this.groupBoxEditClients.Controls.Add(this.textBoxCityClientEdit);
            this.groupBoxEditClients.Controls.Add(this.textBoxAddressClientEdit);
            this.groupBoxEditClients.Controls.Add(this.textBoxFirstNameClientEdit);
            this.groupBoxEditClients.Controls.Add(this.buttonEditClients);
            this.groupBoxEditClients.Controls.Add(this.textBoxLastNameClientEdit);
            this.groupBoxEditClients.Location = new System.Drawing.Point(240, 283);
            this.groupBoxEditClients.Name = "groupBoxEditClients";
            this.groupBoxEditClients.Size = new System.Drawing.Size(229, 249);
            this.groupBoxEditClients.TabIndex = 5;
            this.groupBoxEditClients.TabStop = false;
            this.groupBoxEditClients.Text = "Edycja klienta";
            // 
            // textBoxHomePhoneClientEdit
            // 
            this.textBoxHomePhoneClientEdit.Location = new System.Drawing.Point(6, 179);
            this.textBoxHomePhoneClientEdit.Name = "textBoxHomePhoneClientEdit";
            this.textBoxHomePhoneClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxHomePhoneClientEdit.TabIndex = 8;
            // 
            // textBoxCountryClientEdit
            // 
            this.textBoxCountryClientEdit.Location = new System.Drawing.Point(6, 153);
            this.textBoxCountryClientEdit.Name = "textBoxCountryClientEdit";
            this.textBoxCountryClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxCountryClientEdit.TabIndex = 7;
            // 
            // textBoxPostalCodeClientEdit
            // 
            this.textBoxPostalCodeClientEdit.Location = new System.Drawing.Point(6, 127);
            this.textBoxPostalCodeClientEdit.Name = "textBoxPostalCodeClientEdit";
            this.textBoxPostalCodeClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxPostalCodeClientEdit.TabIndex = 6;
            // 
            // textBoxCityClientEdit
            // 
            this.textBoxCityClientEdit.Location = new System.Drawing.Point(6, 101);
            this.textBoxCityClientEdit.Name = "textBoxCityClientEdit";
            this.textBoxCityClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxCityClientEdit.TabIndex = 5;
            // 
            // textBoxAddressClientEdit
            // 
            this.textBoxAddressClientEdit.Location = new System.Drawing.Point(6, 75);
            this.textBoxAddressClientEdit.Name = "textBoxAddressClientEdit";
            this.textBoxAddressClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxAddressClientEdit.TabIndex = 4;
            // 
            // textBoxFirstNameClientEdit
            // 
            this.textBoxFirstNameClientEdit.Location = new System.Drawing.Point(6, 49);
            this.textBoxFirstNameClientEdit.Name = "textBoxFirstNameClientEdit";
            this.textBoxFirstNameClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxFirstNameClientEdit.TabIndex = 3;
            // 
            // buttonEditClients
            // 
            this.buttonEditClients.Location = new System.Drawing.Point(58, 206);
            this.buttonEditClients.Name = "buttonEditClients";
            this.buttonEditClients.Size = new System.Drawing.Size(75, 37);
            this.buttonEditClients.TabIndex = 1;
            this.buttonEditClients.Text = "Dodaj";
            this.buttonEditClients.UseVisualStyleBackColor = true;
            // 
            // textBoxLastNameClientEdit
            // 
            this.textBoxLastNameClientEdit.Location = new System.Drawing.Point(6, 19);
            this.textBoxLastNameClientEdit.Name = "textBoxLastNameClientEdit";
            this.textBoxLastNameClientEdit.Size = new System.Drawing.Size(188, 20);
            this.textBoxLastNameClientEdit.TabIndex = 0;
            this.textBoxLastNameClientEdit.Tag = "Test";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 540);
            this.Controls.Add(this.groupBoxEditClients);
            this.Controls.Add(this.groupBoxDeleteProduct);
            this.Controls.Add(this.labelinfoClients);
            this.Controls.Add(this.groupBoxAddClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "Clients";
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBoxAddClients.ResumeLayout(false);
            this.groupBoxAddClients.PerformLayout();
            this.groupBoxDeleteProduct.ResumeLayout(false);
            this.groupBoxDeleteProduct.PerformLayout();
            this.groupBoxEditClients.ResumeLayout(false);
            this.groupBoxEditClients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.GroupBox groupBoxAddClients;
        private System.Windows.Forms.TextBox textBoxLastNameClientNew;
        private System.Windows.Forms.Button buttonAddNewClients;
        private System.Windows.Forms.Label labelinfoClients;
        private System.Windows.Forms.TextBox textBoxFirstNameClientNew;
        private System.Windows.Forms.GroupBox groupBoxDeleteProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteClients;
        private System.Windows.Forms.TextBox textBoxHomePhoneClientNew;
        private System.Windows.Forms.TextBox textBoxCountryClientNew;
        private System.Windows.Forms.TextBox textBoxPostalCodeClientNew;
        private System.Windows.Forms.TextBox textBoxCityClientNew;
        private System.Windows.Forms.TextBox textBoxAddressClientNew;
        private System.Windows.Forms.GroupBox groupBoxEditClients;
        private System.Windows.Forms.TextBox textBoxHomePhoneClientEdit;
        private System.Windows.Forms.TextBox textBoxCountryClientEdit;
        private System.Windows.Forms.TextBox textBoxPostalCodeClientEdit;
        private System.Windows.Forms.TextBox textBoxCityClientEdit;
        private System.Windows.Forms.TextBox textBoxAddressClientEdit;
        private System.Windows.Forms.TextBox textBoxFirstNameClientEdit;
        private System.Windows.Forms.Button buttonEditClients;
        private System.Windows.Forms.TextBox textBoxLastNameClientEdit;
    }
}