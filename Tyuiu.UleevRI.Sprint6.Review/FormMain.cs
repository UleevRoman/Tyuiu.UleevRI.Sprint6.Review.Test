using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.Review.Lib;

namespace Tyuiu.UleevRI.Sprint6.Review
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemHelp_URI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
        DataService ds = new DataService();
        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN_URI.Text);
            int m = Convert.ToInt32(textBoxM_URI.Text);
            int n1 = Convert.ToInt32(textBoxN1_URI.Text);
            int n2 = Convert.ToInt32(textBoxN2_URI.Text);
            int k = Convert.ToInt32(textBoxK_URI.Text);
            int l = Convert.ToInt32(textBoxL_URI.Text);
            int R = Convert.ToInt32(textBoxr_URI.Text);
            Random rng = new Random();

            dataGridViewMatrix_URI.RowCount = n;
            dataGridViewMatrix_URI.ColumnCount = m;

            int[,] num = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    num[i, j] = rng.Next(n1, n2);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrix_URI.Columns[j].Width = 30;
                    dataGridViewMatrix_URI.Rows[i].Cells[j].Value = num[i, j];
                }
            }
            int result = ds.CalculateMatrix(num, n1, n2, k, l, R);
            textBoxResult_URI.Text = Convert.ToString(result);
        }
    }
}
