using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SamarAA.Sprint7.Project.V14.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\Schedule1.csv"; // поменять путь при его изменении 

        private void textBoxNom_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.dataGridViewOutPutData_SAA.RowCount = 2;
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSearch_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = Convert.ToString(textBoxNom_SAA.Text);
                string[] road = ds.GetPaths(path, nom);

                this.dataGridViewOutPutData_SAA.ColumnCount = road.Length;

                this.dataGridViewOutPutData_SAA.Rows[0].Cells[0].Value = "Номер";
                this.dataGridViewOutPutData_SAA.Rows[0].Cells[1].Value = "Вид т.с.";
                this.dataGridViewOutPutData_SAA.Rows[0].Cells[2].Value = "Остановки:";

                for (int i = 0; i < road.Length; i++)
                {
                    this.dataGridViewOutPutData_SAA.Rows[1].Cells[i].Value = road[i];
                }

                
                buttonSave_SAA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введен неверный маршрут или его не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonGuid_SAA_Click(object sender, EventArgs e)
        {
            FormGuid formGuid = new FormGuid();
            formGuid.ShowDialog();
        }

        private void button_Load_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_SAA.BackColor = Color.LightGray;
        }

        private void button_Load_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_SAA.BackColor = Color.White;
        }

        private void buttonStat_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonStat_SAA.BackColor = Color.LightGray;
        }

        private void buttonStat_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonStat_SAA.BackColor = Color.White;
        }

        private void buttonGuid_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonGuid_SAA.BackColor = Color.LightGray;
        }

        private void buttonGuid_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonGuid_SAA.BackColor = Color.White;
        }

        private void buttonHelp_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_SAA.BackColor = Color.LightGray;
        }

        private void buttonHelp_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_SAA.BackColor = Color.White;
        }

        private void buttonStat_SAA_Click(object sender, EventArgs e)
        {
            FormStat formStat = new FormStat();
            formStat.ShowDialog();
        }

        static string savePath;

        private void button_Load_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_SAA.FileName = "Сохраненные маршруты.csv";
            saveFileDialog_SAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SAA.ShowDialog();

            savePath = saveFileDialog_SAA.FileName;

            int columns = dataGridViewOutPutData_SAA.ColumnCount;

            string str = "";

            for (int i = 0; i < columns; i++)
            {
                
                if (i != columns - 1)
                {
                    str = str + dataGridViewOutPutData_SAA.Rows[1].Cells[i].Value + ";";

                }
                else
                {
                    str = str + dataGridViewOutPutData_SAA.Rows[1].Cells[i].Value;
                    File.AppendAllText(savePath, str + Environment.NewLine);
                }
                
            
            }
        }

        private void buttonDelete_SAA_Click(object sender, EventArgs e)
        {
            //FileInfo fileInfo = new FileInfo(@"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint7\Tyuiu.SamarAA.Sprint7.Project.V14\bin\Debug\Сохраненные маршруты.csv");
            FileInfo fileInfo = new FileInfo(savePath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(savePath);
                //File.Delete(@"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint7\Tyuiu.SamarAA.Sprint7.Project.V14\bin\Debug\Сохраненные маршруты.csv");
            }
            else
            {
                MessageBox.Show("Файл уже удален", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
