
namespace Tyuiu.SamarAA.Sprint7.Project.V14
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.toolTip_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxNom_SAA = new System.Windows.Forms.TextBox();
            this.buttonSearch_SAA = new System.Windows.Forms.Button();
            this.buttonGuid_SAA = new System.Windows.Forms.Button();
            this.buttonSave_SAA = new System.Windows.Forms.Button();
            this.buttonStat_SAA = new System.Windows.Forms.Button();
            this.pictureBoxTop_SAA = new System.Windows.Forms.PictureBox();
            this.pictureBoxBot_SAA = new System.Windows.Forms.PictureBox();
            this.dataGridViewOutPutData_SAA = new System.Windows.Forms.DataGridView();
            this.labelSearch_SAA = new System.Windows.Forms.Label();
            this.saveFileDialog_SAA = new System.Windows.Forms.SaveFileDialog();
            this.buttonDelete_SAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAA.Image")));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(797, 12);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(75, 62);
            this.buttonHelp_SAA.TabIndex = 0;
            this.toolTip_SAA.SetToolTip(this.buttonHelp_SAA, "Сведение о программе");
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            this.buttonHelp_SAA.MouseEnter += new System.EventHandler(this.buttonHelp_SAA_MouseEnter);
            this.buttonHelp_SAA.MouseLeave += new System.EventHandler(this.buttonHelp_SAA_MouseLeave);
            // 
            // toolTip_SAA
            // 
            this.toolTip_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // textBoxNom_SAA
            // 
            this.textBoxNom_SAA.Location = new System.Drawing.Point(409, 66);
            this.textBoxNom_SAA.Name = "textBoxNom_SAA";
            this.textBoxNom_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom_SAA.TabIndex = 1;
            this.toolTip_SAA.SetToolTip(this.textBoxNom_SAA, "Введите номер маршрута");
            this.textBoxNom_SAA.TextChanged += new System.EventHandler(this.textBoxNom_SAA_TextChanged);
            // 
            // buttonSearch_SAA
            // 
            this.buttonSearch_SAA.Location = new System.Drawing.Point(569, 66);
            this.buttonSearch_SAA.Name = "buttonSearch_SAA";
            this.buttonSearch_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch_SAA.TabIndex = 0;
            this.buttonSearch_SAA.Text = "Найти";
            this.toolTip_SAA.SetToolTip(this.buttonSearch_SAA, "Ищет маршрут");
            this.buttonSearch_SAA.UseVisualStyleBackColor = true;
            this.buttonSearch_SAA.Click += new System.EventHandler(this.buttonSearch_SAA_Click);
            // 
            // buttonGuid_SAA
            // 
            this.buttonGuid_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuid_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuid_SAA.Image")));
            this.buttonGuid_SAA.Location = new System.Drawing.Point(716, 12);
            this.buttonGuid_SAA.Name = "buttonGuid_SAA";
            this.buttonGuid_SAA.Size = new System.Drawing.Size(75, 62);
            this.buttonGuid_SAA.TabIndex = 5;
            this.toolTip_SAA.SetToolTip(this.buttonGuid_SAA, "Руководство пользования");
            this.buttonGuid_SAA.UseVisualStyleBackColor = true;
            this.buttonGuid_SAA.Click += new System.EventHandler(this.buttonGuid_SAA_Click);
            this.buttonGuid_SAA.MouseEnter += new System.EventHandler(this.buttonGuid_SAA_MouseEnter);
            this.buttonGuid_SAA.MouseLeave += new System.EventHandler(this.buttonGuid_SAA_MouseLeave);
            // 
            // buttonSave_SAA
            // 
            this.buttonSave_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_SAA.Enabled = false;
            this.buttonSave_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SAA.Image")));
            this.buttonSave_SAA.Location = new System.Drawing.Point(716, 80);
            this.buttonSave_SAA.Name = "buttonSave_SAA";
            this.buttonSave_SAA.Size = new System.Drawing.Size(75, 62);
            this.buttonSave_SAA.TabIndex = 7;
            this.toolTip_SAA.SetToolTip(this.buttonSave_SAA, "Сохранить маршрут");
            this.buttonSave_SAA.UseVisualStyleBackColor = true;
            this.buttonSave_SAA.Click += new System.EventHandler(this.button_Load_SAA_Click);
            this.buttonSave_SAA.MouseEnter += new System.EventHandler(this.button_Load_SAA_MouseEnter);
            this.buttonSave_SAA.MouseLeave += new System.EventHandler(this.button_Load_SAA_MouseLeave);
            // 
            // buttonStat_SAA
            // 
            this.buttonStat_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStat_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonStat_SAA.Image")));
            this.buttonStat_SAA.Location = new System.Drawing.Point(797, 80);
            this.buttonStat_SAA.Name = "buttonStat_SAA";
            this.buttonStat_SAA.Size = new System.Drawing.Size(75, 62);
            this.buttonStat_SAA.TabIndex = 8;
            this.toolTip_SAA.SetToolTip(this.buttonStat_SAA, "Открывает окно статистики");
            this.buttonStat_SAA.UseVisualStyleBackColor = true;
            this.buttonStat_SAA.Click += new System.EventHandler(this.buttonStat_SAA_Click);
            this.buttonStat_SAA.MouseEnter += new System.EventHandler(this.buttonStat_SAA_MouseEnter);
            this.buttonStat_SAA.MouseLeave += new System.EventHandler(this.buttonStat_SAA_MouseLeave);
            // 
            // pictureBoxTop_SAA
            // 
            this.pictureBoxTop_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTop_SAA.Image")));
            this.pictureBoxTop_SAA.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxTop_SAA.Name = "pictureBoxTop_SAA";
            this.pictureBoxTop_SAA.Size = new System.Drawing.Size(328, 171);
            this.pictureBoxTop_SAA.TabIndex = 2;
            this.pictureBoxTop_SAA.TabStop = false;
            // 
            // pictureBoxBot_SAA
            // 
            this.pictureBoxBot_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxBot_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBot_SAA.Image")));
            this.pictureBoxBot_SAA.Location = new System.Drawing.Point(24, 201);
            this.pictureBoxBot_SAA.Name = "pictureBoxBot_SAA";
            this.pictureBoxBot_SAA.Size = new System.Drawing.Size(328, 248);
            this.pictureBoxBot_SAA.TabIndex = 4;
            this.pictureBoxBot_SAA.TabStop = false;
            // 
            // dataGridViewOutPutData_SAA
            // 
            this.dataGridViewOutPutData_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutPutData_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_SAA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_SAA.Location = new System.Drawing.Point(394, 148);
            this.dataGridViewOutPutData_SAA.Name = "dataGridViewOutPutData_SAA";
            this.dataGridViewOutPutData_SAA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_SAA.Size = new System.Drawing.Size(478, 223);
            this.dataGridViewOutPutData_SAA.TabIndex = 6;
            // 
            // labelSearch_SAA
            // 
            this.labelSearch_SAA.AutoSize = true;
            this.labelSearch_SAA.Location = new System.Drawing.Point(406, 37);
            this.labelSearch_SAA.Name = "labelSearch_SAA";
            this.labelSearch_SAA.Size = new System.Drawing.Size(87, 26);
            this.labelSearch_SAA.TabIndex = 9;
            this.labelSearch_SAA.Text = "Введите номер \r\nмаршрута:";
            // 
            // buttonDelete_SAA
            // 
            this.buttonDelete_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_SAA.Image")));
            this.buttonDelete_SAA.Location = new System.Drawing.Point(797, 387);
            this.buttonDelete_SAA.Name = "buttonDelete_SAA";
            this.buttonDelete_SAA.Size = new System.Drawing.Size(75, 62);
            this.buttonDelete_SAA.TabIndex = 10;
            this.toolTip_SAA.SetToolTip(this.buttonDelete_SAA, "Удалить сохраненные\r\nмаршруты");
            this.buttonDelete_SAA.UseVisualStyleBackColor = true;
            this.buttonDelete_SAA.Click += new System.EventHandler(this.buttonDelete_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonDelete_SAA);
            this.Controls.Add(this.labelSearch_SAA);
            this.Controls.Add(this.buttonStat_SAA);
            this.Controls.Add(this.buttonSave_SAA);
            this.Controls.Add(this.dataGridViewOutPutData_SAA);
            this.Controls.Add(this.buttonGuid_SAA);
            this.Controls.Add(this.pictureBoxBot_SAA);
            this.Controls.Add(this.pictureBoxTop_SAA);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.textBoxNom_SAA);
            this.Controls.Add(this.buttonSearch_SAA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Вариант 14 | Самар А. А.";
            this.toolTip_SAA.SetToolTip(this, "Сохранить маршрут");
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.ToolTip toolTip_SAA;
        private System.Windows.Forms.TextBox textBoxNom_SAA;
        private System.Windows.Forms.Button buttonSearch_SAA;
        private System.Windows.Forms.PictureBox pictureBoxTop_SAA;
        private System.Windows.Forms.PictureBox pictureBoxBot_SAA;
        private System.Windows.Forms.Button buttonGuid_SAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_SAA;
        private System.Windows.Forms.Button buttonSave_SAA;
        private System.Windows.Forms.Button buttonStat_SAA;
        private System.Windows.Forms.Label labelSearch_SAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SAA;
        private System.Windows.Forms.Button buttonDelete_SAA;
    }
}

