namespace DotNetZaliczenie
{
    partial class UserControlWarehouseStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUpdateStock = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxValueStock = new System.Windows.Forms.MaskedTextBox();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBoxUpdateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zaznacz wiersz, następnie zmień jego wartość.";
            // 
            // groupBoxUpdateStock
            // 
            this.groupBoxUpdateStock.Controls.Add(this.maskedTextBoxValueStock);
            this.groupBoxUpdateStock.Controls.Add(this.buttonUpdateStock);
            this.groupBoxUpdateStock.Location = new System.Drawing.Point(366, 41);
            this.groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            this.groupBoxUpdateStock.Size = new System.Drawing.Size(200, 100);
            this.groupBoxUpdateStock.TabIndex = 7;
            this.groupBoxUpdateStock.TabStop = false;
            this.groupBoxUpdateStock.Text = "Aktualizuj Stok";
            // 
            // maskedTextBoxValueStock
            // 
            this.maskedTextBoxValueStock.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBoxValueStock.Mask = "00000";
            this.maskedTextBoxValueStock.Name = "maskedTextBoxValueStock";
            this.maskedTextBoxValueStock.PromptChar = ' ';
            this.maskedTextBoxValueStock.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxValueStock.TabIndex = 11;
            this.maskedTextBoxValueStock.ValidatingType = typeof(int);
            this.maskedTextBoxValueStock.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(58, 57);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(75, 37);
            this.buttonUpdateStock.TabIndex = 1;
            this.buttonUpdateStock.Text = "Aktualizuj";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.AllowUserToAddRows = false;
            this.dataGridViewWarehouse.AllowUserToResizeColumns = false;
            this.dataGridViewWarehouse.AllowUserToResizeRows = false;
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(26, 41);
            this.dataGridViewWarehouse.MultiSelect = false;
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(321, 334);
            this.dataGridViewWarehouse.TabIndex = 6;
            this.dataGridViewWarehouse.TabStop = false;
            // 
            // UserControlWarehouseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxUpdateStock);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Name = "UserControlWarehouseStock";
            this.Size = new System.Drawing.Size(820, 602);
            this.groupBoxUpdateStock.ResumeLayout(false);
            this.groupBoxUpdateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueStock;
    }
}
