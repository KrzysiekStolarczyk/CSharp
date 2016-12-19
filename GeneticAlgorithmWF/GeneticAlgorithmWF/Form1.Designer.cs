namespace GeneticAlgorithmWF
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSelekcja = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonKrzyzowanie = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKrz = new System.Windows.Forms.TextBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxMut = new System.Windows.Forms.CheckBox();
            this.checkBoxKrz = new System.Windows.Forms.CheckBox();
            this.textBoxMut = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.chartAxis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAxis)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelekcja
            // 
            this.buttonSelekcja.Location = new System.Drawing.Point(26, 256);
            this.buttonSelekcja.Name = "buttonSelekcja";
            this.buttonSelekcja.Size = new System.Drawing.Size(75, 42);
            this.buttonSelekcja.TabIndex = 0;
            this.buttonSelekcja.Text = "Selekcja";
            this.buttonSelekcja.UseVisualStyleBackColor = true;
            this.buttonSelekcja.Click += new System.EventHandler(this.buttonSelekcja_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 304);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 540);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(627, 127);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "{P}";
            series1.LabelToolTip = "#VALX";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 215);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // buttonKrzyzowanie
            // 
            this.buttonKrzyzowanie.Location = new System.Drawing.Point(336, 256);
            this.buttonKrzyzowanie.Name = "buttonKrzyzowanie";
            this.buttonKrzyzowanie.Size = new System.Drawing.Size(75, 42);
            this.buttonKrzyzowanie.TabIndex = 3;
            this.buttonKrzyzowanie.Text = "Krzyzowanie";
            this.buttonKrzyzowanie.UseVisualStyleBackColor = true;
            this.buttonKrzyzowanie.Click += new System.EventHandler(this.buttonKrzyzowanie_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(580, 216);
            this.dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prawdopodobieństwo krzyżowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prawdopodobieństwo mutacji";
            // 
            // textBoxKrz
            // 
            this.textBoxKrz.Location = new System.Drawing.Point(6, 32);
            this.textBoxKrz.Name = "textBoxKrz";
            this.textBoxKrz.Size = new System.Drawing.Size(60, 20);
            this.textBoxKrz.TabIndex = 8;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.checkBoxMut);
            this.groupBoxConfig.Controls.Add(this.checkBoxKrz);
            this.groupBoxConfig.Controls.Add(this.textBoxMut);
            this.groupBoxConfig.Controls.Add(this.textBoxKrz);
            this.groupBoxConfig.Controls.Add(this.label2);
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Location = new System.Drawing.Point(627, 21);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(300, 100);
            this.groupBoxConfig.TabIndex = 9;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Parametry";
            // 
            // checkBoxMut
            // 
            this.checkBoxMut.AutoSize = true;
            this.checkBoxMut.Checked = true;
            this.checkBoxMut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMut.Location = new System.Drawing.Point(123, 77);
            this.checkBoxMut.Name = "checkBoxMut";
            this.checkBoxMut.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMut.TabIndex = 11;
            this.checkBoxMut.Text = "ustaw 0.15";
            this.checkBoxMut.UseVisualStyleBackColor = true;
            // 
            // checkBoxKrz
            // 
            this.checkBoxKrz.AutoSize = true;
            this.checkBoxKrz.Checked = true;
            this.checkBoxKrz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKrz.Location = new System.Drawing.Point(123, 35);
            this.checkBoxKrz.Name = "checkBoxKrz";
            this.checkBoxKrz.Size = new System.Drawing.Size(78, 17);
            this.checkBoxKrz.TabIndex = 10;
            this.checkBoxKrz.Text = "ustaw 0.75";
            this.checkBoxKrz.UseVisualStyleBackColor = true;
            // 
            // textBoxMut
            // 
            this.textBoxMut.Location = new System.Drawing.Point(6, 74);
            this.textBoxMut.Name = "textBoxMut";
            this.textBoxMut.Size = new System.Drawing.Size(60, 20);
            this.textBoxMut.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(452, 216);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pokaż Dane ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartAxis
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAxis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAxis.Legends.Add(legend2);
            this.chartAxis.Location = new System.Drawing.Point(386, 588);
            this.chartAxis.Name = "chartAxis";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.LabelBorderColor = System.Drawing.Color.Red;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAxis.Series.Add(series2);
            this.chartAxis.Size = new System.Drawing.Size(452, 256);
            this.chartAxis.TabIndex = 13;
            this.chartAxis.Text = "chart3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 856);
            this.Controls.Add(this.chartAxis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonKrzyzowanie);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSelekcja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAxis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelekcja;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonKrzyzowanie;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKrz;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.CheckBox checkBoxMut;
        private System.Windows.Forms.CheckBox checkBoxKrz;
        private System.Windows.Forms.TextBox textBoxMut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAxis;
    }
}

