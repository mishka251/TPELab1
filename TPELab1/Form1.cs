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
            nuX1L.Add(nuX1);
            nuX2L.Add(nuX2);
        }

        List<NumericUpDown> nuX1L = new List<NumericUpDown>();
        List<NumericUpDown> nuX2L = new List<NumericUpDown>();

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
            //Random r = new Random();
            //DataTable dt = new DataTable();
            //int[] degs2 = new int[31];
            //degs2[0] = 1;
            //for (int i = 1; i < 31; i++)
            //    degs2[i] = degs2[i - 1] * 2;

            //dt.Columns.Add("№");
            //for (int i = 0; i < n; i++)
            //    dt.Columns.Add("X" + (i + 1));
            //dt.Columns.Add("X" + (i1) + " x X" + (i2));
            //dt.Columns.Add("y");
            //List<int> used = new List<int>();
            //for (int i = 0; i < degs2[n - p]; i++)
            //{
            //    int num = 0;
            //    do
            //    {
            //        num = r.Next(0, degs2[n]);
            //    } while (used.Contains(num));
            //    used.Add(num);

            //    object[] row = new object[n + 3];
            //    row[0] = i + 1;
            //    for (int j = 0; j < n; j++)
            //    {
            //        row[j + 1] = ((num) & degs2[n - j - 1]) == 0 ? -1 : 1;
            //    }
            //    row[n + 1] = (int)row[i1] * (int)row[i2];
            //    row[n + 2] = "y";
            //    dt.Rows.Add(row);
            //}
            dataGridView2.Columns.Clear();

            DataTable dt = calcualteFull(n - p);
            dt.Columns.RemoveAt(dt.Columns.Count - 1);

            for (int j = 0; j < p; j++)
            {

                int j1 = (int)nuX1L[j].Value;
                int j2 = (int)nuX2L[j].Value;

                dt.Columns.Add("col" + j);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][n - p + j + 1] = int.Parse(dt.Rows[i][j1].ToString()) * int.Parse(dt.Rows[i][j2].ToString());
                }
            }

            dt.Columns.Add("y");
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i][n + 1] = "y";

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

            for (int j = 0; j < p; j++)
            {
                int j1 = (int)nuX1L[j].Value;
                int j2 = (int)nuX2L[j].Value;
                dataGridView2.Columns[n - p + j + 1].HeaderText = dataGridView2.Columns[j1].HeaderText + " x" + dataGridView2.Columns[j2].HeaderText;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateNotFull();
        }

        private void nuN_ValueChanged(object sender, EventArgs e)
        {
            if (nuP.Value+2 >= nuN.Value)
                nuP.Value = nuN.Value-2;
            nuP.Maximum = nuN.Value-2;

          /*  if (nuX1.Value >= nuN.Value)
                nuX1.Value = nuN.Value;
            nuX1.Maximum = nuN.Value;

            if (nuX2.Value >= nuN.Value)
                nuX2.Value = nuN.Value;
            nuX2.Maximum = nuN.Value;
            */

            for (int i = 0; i < nuX1L.Count; i++)
            {
                if (nuX1L[i].Value >= nuN.Value-nuP.Value)
                    nuX1L[i].Value = nuN.Value-nuP.Value;
                nuX1L[i].Maximum = nuN.Value-nuP.Value;

                if (nuX2L[i].Value >= nuN.Value-nuP.Value)
                    nuX2L[i].Value = nuN.Value-nuP.Value;
                nuX2L[i].Maximum = nuN.Value-nuP.Value;
            }

           // CalculateNotFull();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // CalculateFull();
        }


        NumericUpDown Clone(NumericUpDown src)
        {
            NumericUpDown res = new NumericUpDown();
            res.Width = src.Width;
            res.Height = src.Height;
            res.Top = src.Top;
            res.Left = src.Left + src.Width + 20;

            res.Maximum = src.Maximum;
            res.Minimum = src.Minimum;
            res.Value = 1;
            tabPage2.Controls.Add(res);

            return res;
        }

        private void nuP_ValueChanged(object sender, EventArgs e)
        {


            if (nuP.Value > nuX1L.Count)
            {
                if (nuP.Value == 1)
                {
                    nuX1.Visible = true;
                    nuX2.Visible = true;
                }
                else
                {
                    NumericUpDown nu1 = Clone(nuX1L[nuX1L.Count - 1]);
                    NumericUpDown nu2 = Clone(nuX2L[nuX2L.Count - 1]);
                    nu1.ValueChanged += nuX1_ValueChanged;
                   nu2.ValueChanged += nuX2_ValueChanged;
                    nuX1L.Add(nu1);
                    nuX2L.Add(nu2);

                   // nu1.ChangeUICues += nuX1_ValueChanged;
                   // nu2.ChangeUICues += nuX2_ValueChanged;
                }
            }
            else
            {
                if (nuP.Value == 0)
                {
                    nuX1.Visible = false;
                    nuX2.Visible = false;
                }
                else
                {
                    tabPage2.Controls.Remove(nuX1L[nuX1L.Count - 1]);
                    tabPage2.Controls.Remove(nuX2L[nuX2L.Count - 1]);

                    nuX1L.RemoveAt(nuX1L.Count - 1);
                    nuX2L.RemoveAt(nuX2L.Count - 1);
                }
            }

            for (int i = 0; i < nuX1L.Count; i++)
            {
                nuX1L[i].Maximum = nuN.Value-nuP.Value;
                nuX2L[i].Maximum = nuN.Value-nuP.Value;
            }

           // CalculateNotFull();
        }

        void calculateP(int n, int p)
        {
            for (int j = 0; j < p; j++)
            {
                int j1 = (int)nuX1L[j].Value;
                int j2 = (int)nuX2L[j].Value;

                dataGridView2.Columns[n - p + j + 1].HeaderText = dataGridView2.Columns[j1].HeaderText + " x"+ dataGridView2.Columns[j2].HeaderText;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2[n - p + j + 1, i].Value = int.Parse(dataGridView2[j1, i].Value.ToString()) * int.Parse(dataGridView2[j2, i].Value.ToString());
                }
            }

        }
        private void nuX1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)nuN.Value;
            int p = (int)nuP.Value;
           // calculateP(n, p);
        }

        private void nuX2_ValueChanged(object sender, EventArgs e)
        {

            int n = (int)nuN.Value;
            int p = (int)nuP.Value;
           // calculateP(n, p);

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
