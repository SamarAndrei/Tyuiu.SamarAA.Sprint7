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
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\Schedule1.csv"; // путь

        private void buttonStatOk_SAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStat_Load(object sender, EventArgs e)
        {
            this.chartStat_SAA.ChartAreas[0].AxisX.Title = "Вид транспорта";
            this.chartStat_SAA.ChartAreas[0].AxisY.Title = "Количество";
            int[] stat = ds.GetStat(path);
            string[] vid = new string[] { "автобус", "микроавтобус" };
            for(int i = 0; i < vid.Length; i++)
            {
                chartStat_SAA.Series[0].Points.AddXY(vid[i], stat[i]);
            }

            textBoxStatMin_SAA.Text = Convert.ToString(ds.GetStatMin(path));
            textBoxStatAvg_SAA.Text = Convert.ToString(ds.GetStatAvg(path));
            textBoxStatMax_SAA.Text = Convert.ToString(ds.GetStatMax(path));
        }

        private void chartStat_SAA_Click(object sender, EventArgs e)
        {

        }
    }
}
