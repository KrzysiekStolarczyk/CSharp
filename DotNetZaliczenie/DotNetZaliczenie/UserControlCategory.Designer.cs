namespace DotNetZaliczenie
{
    partial class UserControlCategory
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
            this.groupBoxAddCat = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxAddCat = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddNewCat = new System.Windows.Forms.Button();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteCa = new System.Windows.Forms.Button();
            this.groupBoxDeleteCat = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDeleteCat = new System.Windows.Forms.MaskedTextBox();
            this.buttonEditCat = new System.Windows.Forms.Button();
            this.groupBoxAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxDeleteCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zarządzanie kategoriami.";
            // 
            // groupBoxAddCat
            // 
            this.groupBoxAddCat.Controls.Add(this.maskedTextBoxAddCat);
            this.groupBoxAddCat.Controls.Add(this.buttonAddNewCat);
            this.groupBoxAddCat.Location = new System.Drawing.Point(277, 41);
            this.groupBoxAddCat.Name = "groupBoxAddCat";
            this.groupBoxAddCat.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAddCat.TabIndex = 7;
            this.groupBoxAddCat.TabStop = false;
            this.groupBoxAddCat.Text = "Dodaj nową kategorię";
            // 
            // maskedTextBoxAddCat
            // 
            this.maskedTextBoxAddCat.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBoxAddCat.Mask = "AAAAAAAAAA";
            this.maskedTextBoxAddCat.Name = "maskedTextBoxAddCat";
            this.maskedTextBoxAddCat.PromptChar = ' ';
            this.maskedTextBoxAddCat.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxAddCat.TabIndex = 11;
            this.maskedTextBoxAddCat.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // buttonAddNewCat
            // 
            this.buttonAddNewCat.Location = new System.Drawing.Point(58, 57);
            this.buttonAddNewCat.Name = "buttonAddNewCat";
            this.buttonAddNewCat.Size = new System.Drawing.Size(75, 37);
            this.buttonAddNewCat.TabIndex = 1;
            this.buttonAddNewCat.Text = "Dodaj";
            this.buttonAddNewCat.UseVisualStyleBackColor = true;
            this.buttonAddNewCat.Click += new System.EventHandler(this.buttonAddNewCat_Click);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToAddRows = false;
            this.dataGridViewCat.AllowUserToResizeColumns = false;
            this.dataGridViewCat.AllowUserToResizeRows = false;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(26, 41);
            this.dataGridViewCat.MultiSelect = false;
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCat.Size = new System.Drawing.Size(221, 197);
            this.dataGridViewCat.TabIndex = 6;
            this.dataGridViewCat.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteCa);
            this.groupBox1.Location = new System.Drawing.Point(277, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuń kategorię";
            // 
            // buttonDeleteCa
            // 
            this.buttonDeleteCa.Location = new System.Drawing.Point(58, 19);
            this.buttonDeleteCa.Name = "buttonDeleteCa";
            this.buttonDeleteCa.Size = new System.Drawing.Size(75, 37);
            this.buttonDeleteCa.TabIndex = 1;
            this.buttonDeleteCa.Text = "Usuń";
            this.buttonDeleteCa.UseVisualStyleBackColor = true;
            this.buttonDeleteCa.Click += new System.EventHandler(this.buttonDeleteCa_Click);
            // 
            // groupBoxDeleteCat
            // 
            this.groupBoxDeleteCat.Controls.Add(this.maskedTextBoxDeleteCat);
            this.groupBoxDeleteCat.Controls.Add(this.buttonEditCat);
            this.groupBoxDeleteCat.Location = new System.Drawing.Point(277, 244);
            this.groupBoxDeleteCat.Name = "groupBoxDeleteCat";
            this.groupBoxDeleteCat.Size = new System.Drawing.Size(194, 100);
            this.groupBoxDeleteCat.TabIndex = 12;
            this.groupBoxDeleteCat.TabStop = false;
            this.groupBoxDeleteCat.Text = "Edytuj kategorię";
            // 
            // maskedTextBoxDeleteCat
            // 
            this.maskedTextBoxDeleteCat.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBoxDeleteCat.Mask = "AAAAAAAAAA";
            this.maskedTextBoxDeleteCat.Name = "maskedTextBoxDeleteCat";
            this.maskedTextBoxDeleteCat.PromptChar = ' ';
            this.maskedTextBoxDeleteCat.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxDeleteCat.TabIndex = 12;
            this.maskedTextBoxDeleteCat.Click += new System.EventHandler(this.textBoxValueStockValid);
            // 
            // buttonEditCat
            // 
            this.buttonEditCat.Location = new System.Drawing.Point(58, 57);
            this.buttonEditCat.Name = "buttonEditCat";
            this.buttonEditCat.Size = new System.Drawing.Size(75, 37);
            this.buttonEditCat.TabIndex = 1;
            this.buttonEditCat.Text = "Edytuj";
            this.buttonEditCat.UseVisualStyleBackColor = true;
            this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDeleteCat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxAddCat);
            this.Controls.Add(this.dataGridViewCat);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(480, 387);
            this.groupBoxAddCat.ResumeLayout(false);
            this.groupBoxAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDeleteCat.ResumeLayout(false);
            this.groupBoxDeleteCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAddCat;
        private System.Windows.Forms.Button buttonAddNewCat;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAddCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteCa;
        private System.Windows.Forms.GroupBox groupBoxDeleteCat;
        private System.Windows.Forms.Button buttonEditCat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDeleteCat;
    }
}
