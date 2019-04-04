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

        DataTable calcualteNotFull(int n, int p, int i1, int i2)
        {
            Random r = new Random();
            DataTable dt = new DataTable();
            int[] degs2 = new int[31];
            degs2[0] = 1;
            for (int i = 1; i < 31; i++)
                degs2[i] = degs2[i - 1] * 2;

            dt.Columns.Add("№");
            for (int i = 0; i < n; i++)
                dt.Columns.Add("X" + (i + 1));
            dt.Columns.Add("X" + (i1) + " x X" + (i2));
            dt.Columns.Add("y");
            List<int> used = new List<int>();
            for (int i = 0; i < degs2[n - p]; i++)
            {
                int num = 0;
                do
                {
                    num = r.Next(0, degs2[n]);
                } while (used.Contains(num));
                used.Add(num);

                object[] row = new object[n + 3];
                row[0] = i + 1;
                for (int j = 0; j < n; j++)
                {
                    row[j + 1] = ((num) & degs2[n - j - 1]) == 0 ? -1 : 1;
                }
                row[n + 1] = (int)row[i1] * (int)row[i2];
                row[n + 2] = "y";
                dt.Rows.Add(row);
            }
            return dt;
        }

        void CalculateFull()
        {
            int n = (int)numericUpDown1.Value;
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
            int n = (int)nuN.Value;
            int p = (int)nuP.Value;
            int x1 = (int)nuX1.Value;
            int x2 = (int)nuX2.Value;
            DataTable dt = calcualteNotFull(n, p, x1, x2);
            dataGridView2.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateNotFull();
        }

        private void nuN_ValueChanged(object sender, EventArgs e)
        {
            if (nuP.Value >= nuN.Value)
                nuP.Value = nuN.Value;
            nuP.Maximum = nuN.Value;

            if (nuX1.Value >= nuN.Value)
                nuX1.Value = nuN.Value;
            nuX1.Maximum = nuN.Value;

            if (nuX2.Value >= nuN.Value)
                nuX2.Value = nuN.Value;
            nuX2.Maximum = nuN.Value;

            CalculateNotFull();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculateFull();
        }

        private void nuP_ValueChanged(object sender, EventArgs e)
        {
            CalculateNotFull();
        }

        private void nuX1_ValueChanged(object sender, EventArgs e)
        {
            CalculateNotFull();
        }

        private void nuX2_ValueChanged(object sender, EventArgs e)
        {
            CalculateNotFull();
        }
    }
}
