using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabukovDV.Sprint6.Review.V11.Lib;

namespace Tyuiu.ShabukovDV.Sprint6.Review.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] arrayValues;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_SDV.ColumnCount = 50;
            dataGridViewOut_SDV.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewOut_SDV.Columns[i].Width = 25;
            }
        }

        private void buttonGeneration_SDV_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxDigitalN_SDV.Text);
                int m = Convert.ToInt32(textBoxDigitalM_SDV.Text);
                int n1 = Convert.ToInt32(textBoxDigitalN1_SDV.Text);
                int n2 = Convert.ToInt32(textBoxDigitalN2_SDV.Text);

                if (n1 < n2)
                {
                    arrayValues = ds.GeneratingMatrix(n, m, n1, n2);
                    dataGridViewOut_SDV.ColumnCount = m;
                    dataGridViewOut_SDV.RowCount = n;

                    for (int i = 0; i < m; i++)
                    {
                        dataGridViewOut_SDV.Columns[i].Width = 25;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewOut_SDV.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonDone_SDV.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }

        private void buttonDone_SDV_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxDigitalC_SDV.Text);
                int k = Convert.ToInt32(textBoxDigitalK_SDV.Text);
                int l = Convert.ToInt32(textBoxDigitalL_SDV.Text);
                int c1 = Convert.ToInt32(textBoxDigitalM_SDV.Text);
                int n = Convert.ToInt32(textBoxDigitalN_SDV.Text);
                int m = Convert.ToInt32(textBoxDigitalM_SDV.Text);

                if (k <= l && c < c1 && c > -1 && k > -1 && l > -1)
                {
                    textBoxResultat_SDV.Text = ds.resultGetMatrix(arrayValues, c, k, l).ToString();
                }
                else
                {
                    MessageBox.Show("Данные введены не корректно");
                }
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно Catch");
            }
        }
    }
}
