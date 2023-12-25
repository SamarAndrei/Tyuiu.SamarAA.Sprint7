
namespace Tyuiu.SamarAA.Sprint7.Project.V14
{
    partial class FormStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStat));
            this.chartStat_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStatOk_SAA = new System.Windows.Forms.Button();
            this.labelStat_SAA = new System.Windows.Forms.Label();
            this.textBoxStatMin_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStatAvg_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStatMax_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxStat_SAA = new System.Windows.Forms.GroupBox();
            this.labelStatMin_SAA = new System.Windows.Forms.Label();
            this.labelStatAvg_SAA = new System.Windows.Forms.Label();
            this.labelStatMax_SAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat_SAA)).BeginInit();
            this.groupBoxStat_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStat_SAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStat_SAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStat_SAA.Legends.Add(legend1);
            this.chartStat_SAA.Location = new System.Drawing.Point(58, 64);
            this.chartStat_SAA.Name = "chartStat_SAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStat_SAA.Series.Add(series1);
            this.chartStat_SAA.Size = new System.Drawing.Size(476, 300);
            this.chartStat_SAA.TabIndex = 0;
            this.chartStat_SAA.Text = "chart1";
            this.chartStat_SAA.Click += new System.EventHandler(this.chartStat_SAA_Click);
            // 
            // buttonStatOk_SAA
            // 
            this.buttonStatOk_SAA.Location = new System.Drawing.Point(697, 376);
            this.buttonStatOk_SAA.Name = "buttonStatOk_SAA";
            this.buttonStatOk_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonStatOk_SAA.TabIndex = 1;
            this.buttonStatOk_SAA.Text = "OK";
            this.buttonStatOk_SAA.UseVisualStyleBackColor = true;
            this.buttonStatOk_SAA.Click += new System.EventHandler(this.buttonStatOk_SAA_Click);
            // 
            // labelStat_SAA
            // 
            this.labelStat_SAA.AutoSize = true;
            this.labelStat_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStat_SAA.Location = new System.Drawing.Point(241, 9);
            this.labelStat_SAA.Name = "labelStat_SAA";
            this.labelStat_SAA.Size = new System.Drawing.Size(320, 16);
            this.labelStat_SAA.TabIndex = 2;
            this.labelStat_SAA.Text = "Количество автобусов и микроавтобусов\r\n";
            // 
            // textBoxStatMin_SAA
            // 
            this.textBoxStatMin_SAA.Location = new System.Drawing.Point(21, 45);
            this.textBoxStatMin_SAA.Name = "textBoxStatMin_SAA";
            this.textBoxStatMin_SAA.ReadOnly = true;
            this.textBoxStatMin_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatMin_SAA.TabIndex = 3;
            // 
            // textBoxStatAvg_SAA
            // 
            this.textBoxStatAvg_SAA.Location = new System.Drawing.Point(21, 97);
            this.textBoxStatAvg_SAA.Name = "textBoxStatAvg_SAA";
            this.textBoxStatAvg_SAA.ReadOnly = true;
            this.textBoxStatAvg_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatAvg_SAA.TabIndex = 4;
            // 
            // textBoxStatMax_SAA
            // 
            this.textBoxStatMax_SAA.Location = new System.Drawing.Point(21, 149);
            this.textBoxStatMax_SAA.Name = "textBoxStatMax_SAA";
            this.textBoxStatMax_SAA.ReadOnly = true;
            this.textBoxStatMax_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatMax_SAA.TabIndex = 5;
            // 
            // groupBoxStat_SAA
            // 
            this.groupBoxStat_SAA.Controls.Add(this.labelStatMax_SAA);
            this.groupBoxStat_SAA.Controls.Add(this.labelStatAvg_SAA);
            this.groupBoxStat_SAA.Controls.Add(this.labelStatMin_SAA);
            this.groupBoxStat_SAA.Controls.Add(this.textBoxStatMax_SAA);
            this.groupBoxStat_SAA.Controls.Add(this.textBoxStatMin_SAA);
            this.groupBoxStat_SAA.Controls.Add(this.textBoxStatAvg_SAA);
            this.groupBoxStat_SAA.Location = new System.Drawing.Point(572, 64);
            this.groupBoxStat_SAA.Name = "groupBoxStat_SAA";
            this.groupBoxStat_SAA.Size = new System.Drawing.Size(200, 300);
            this.groupBoxStat_SAA.TabIndex = 6;
            this.groupBoxStat_SAA.TabStop = false;
            // 
            // labelStatMin_SAA
            // 
            this.labelStatMin_SAA.AutoSize = true;
            this.labelStatMin_SAA.Location = new System.Drawing.Point(18, 16);
            this.labelStatMin_SAA.Name = "labelStatMin_SAA";
            this.labelStatMin_SAA.Size = new System.Drawing.Size(113, 26);
            this.labelStatMin_SAA.TabIndex = 6;
            this.labelStatMin_SAA.Text = "Минимальное число \r\nостановок:";
            // 
            // labelStatAvg_SAA
            // 
            this.labelStatAvg_SAA.AutoSize = true;
            this.labelStatAvg_SAA.Location = new System.Drawing.Point(18, 68);
            this.labelStatAvg_SAA.Name = "labelStatAvg_SAA";
            this.labelStatAvg_SAA.Size = new System.Drawing.Size(85, 26);
            this.labelStatAvg_SAA.TabIndex = 7;
            this.labelStatAvg_SAA.Text = "Среднее число \r\nотсановок:";
            // 
            // labelStatMax_SAA
            // 
            this.labelStatMax_SAA.AutoSize = true;
            this.labelStatMax_SAA.Location = new System.Drawing.Point(18, 120);
            this.labelStatMax_SAA.Name = "labelStatMax_SAA";
            this.labelStatMax_SAA.Size = new System.Drawing.Size(116, 26);
            this.labelStatMax_SAA.TabIndex = 8;
            this.labelStatMax_SAA.Text = "Максимальное число\r\nостановок:\r\n";
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.groupBoxStat_SAA);
            this.Controls.Add(this.labelStat_SAA);
            this.Controls.Add(this.buttonStatOk_SAA);
            this.Controls.Add(this.chartStat_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStat_SAA)).EndInit();
            this.groupBoxStat_SAA.ResumeLayout(false);
            this.groupBoxStat_SAA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat_SAA;
        private System.Windows.Forms.Button buttonStatOk_SAA;
        private System.Windows.Forms.Label labelStat_SAA;
        private System.Windows.Forms.TextBox textBoxStatMin_SAA;
        private System.Windows.Forms.TextBox textBoxStatAvg_SAA;
        private System.Windows.Forms.TextBox textBoxStatMax_SAA;
        private System.Windows.Forms.GroupBox groupBoxStat_SAA;
        private System.Windows.Forms.Label labelStatMax_SAA;
        private System.Windows.Forms.Label labelStatAvg_SAA;
        private System.Windows.Forms.Label labelStatMin_SAA;
    }
}