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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labelOrders = new System.Windows.Forms.Label();
            this.groupBoxAddOrder = new System.Windows.Forms.GroupBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxAddOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(641, 265);
            this.dataGridViewOrders.TabIndex = 0;
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
            this.groupBoxAddOrder.Controls.Add(this.comboBoxQuantity);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxClient);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxProducts);
            this.groupBoxAddOrder.Location = new System.Drawing.Point(7, 326);
            this.groupBoxAddOrder.Name = "groupBoxAddOrder";
            this.groupBoxAddOrder.Size = new System.Drawing.Size(245, 133);
            this.groupBoxAddOrder.TabIndex = 9;
            this.groupBoxAddOrder.TabStop = false;
            this.groupBoxAddOrder.Text = "Dodaj zamówienie";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(19, 47);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(19, 20);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.GetInfoAboutSelectedproduct);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Location = new System.Drawing.Point(313, 326);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(245, 133);
            this.groupBoxEdit.TabIndex = 10;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edytuj zamówienie";
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Location = new System.Drawing.Point(19, 74);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuantity.TabIndex = 2;
            // 
            // UserControlOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAddOrder);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "UserControlOrders";
            this.Size = new System.Drawing.Size(723, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxAddOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.GroupBox groupBoxAddOrder;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
    }
}
