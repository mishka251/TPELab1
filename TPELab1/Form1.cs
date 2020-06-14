using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TPELab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataTable calcualteFull(int n)
        {
            DataTable dt = new DataTable();
            int[] degs2 = new int[31];
            degs2[0] = 1;
            for (int i = 1; i < 31; i++)
                degs2[i] = degs2[i - 1] * 2;

            dt.Columns.Add("№");
            for (int i = 0; i < n; i++)
                dt.Columns.Add("X" + (i + 1));
            dt.Columns.Add("y");

            for (int i = 0; i < degs2[n]; i++)
            {
                object[] row = new object[n + 2];
                row[0] = i + 1;
                for (int j = 0; j < n; j++)
                {
                    row[j + 1] = ((i) & degs2[n - j - 1]) == 0 ? -1 : 1;
                }

                row[n + 1] = "y";
                dt.Rows.Add(row);
            }

            return dt;
        }

        DataTable calcualteNotFull(int n, int p)
        {
            dataGridView2.Columns.Clear();

            DataTable dt = calcualteFull(n);
            dt.Columns.RemoveAt(dt.Columns.Count - 1);

            int cnt = 0;

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    cnt++;
                    string name = dt.Columns[i].ColumnName + " x " + dt.Columns[j].ColumnName;
                    dt.Columns.Add(name);
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        dt.Rows[k][n + cnt] =
                            int.Parse(dt.Rows[k][i].ToString()) * int.Parse(dt.Rows[k][j].ToString());
                    }

                    if (cnt == p)
                    {
                        break;
                    }
                }

                if (cnt == p)
                {
                    break;
                }
            }

            dt.Columns.Add("y");
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i][n + p + 1] = "y";

            return dt;
        }

        void CalculateFull()
        {
            int n = (int) numericUpDown1.Value;
            DataTable dt = calcualteFull(n);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFull();
        }

        void CalculateNotFull()
        {
            dataGridView2.Columns.Clear();
            int n = (int) nuN.Value;
            int p = (int) nuP.Value;
            DataTable dt = calcualteNotFull(n - p, p);
            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateNotFull();
        }

        private void nuN_ValueChanged(object sender, EventArgs e)
        {
            int n = (int) (nuN.Value);

            int n_p = (int) Math.Ceiling(0.5 * (-1 + Math.Sqrt(1 + 8 * n)));

            int p_max = -1;

            p_max = n - n_p;
            p_max = Math.Max(0, p_max);
            if (nuP.Value > p_max)
                nuP.Value = p_max;
            nuP.Maximum = p_max;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // CalculateFull();
        }

        private void nuP_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateFull();
            CalculateNotFull();
        }

        private void numericUpDown1_ValueChanged(object sender, UICuesEventArgs e)
        {
        }
    }
}