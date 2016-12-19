namespace ProjektNaZaliczenie
{
    partial class WarehouseStock
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
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBoxUpdateStock = new System.Windows.Forms.GroupBox();
            this.textBoxValueStock = new System.Windows.Forms.TextBox();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.groupBoxUpdateStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.AllowUserToAddRows = false;
            this.dataGridViewWarehouse.AllowUserToResizeColumns = false;
            this.dataGridViewWarehouse.AllowUserToResizeRows = false;
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(21, 50);
            this.dataGridViewWarehouse.MultiSelect = false;
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(321, 334);
            this.dataGridViewWarehouse.TabIndex = 0;
            this.dataGridViewWarehouse.TabStop = false;
            // 
            // groupBoxUpdateStock
            // 
            this.groupBoxUpdateStock.Controls.Add(this.buttonUpdateStock);
            this.groupBoxUpdateStock.Controls.Add(this.textBoxValueStock);
            this.groupBoxUpdateStock.Location = new System.Drawing.Point(366, 50);
            this.groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            this.groupBoxUpdateStock.Size = new System.Drawing.Size(200, 100);
            this.groupBoxUpdateStock.TabIndex = 1;
            this.groupBoxUpdateStock.TabStop = false;
            this.groupBoxUpdateStock.Text = "Aktualizuj Stok";
            // 
            // textBoxValueStock
            // 
            this.textBoxValueStock.Location = new System.Drawing.Point(6, 19);
            this.textBoxValueStock.Name = "textBoxValueStock";
            this.textBoxValueStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueStock.TabIndex = 0;
            this.textBoxValueStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValueStock_KeyPress);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaznacz wiersz, następnie zmień jego wartość.";
            // 
            // WarehouseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxUpdateStock);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Name = "WarehouseStock";
            this.Text = "WarehouseStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.groupBoxUpdateStock.ResumeLayout(false);
            this.groupBoxUpdateStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.TextBox textBoxValueStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.Label label1;
    }
}