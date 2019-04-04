namespace TPELab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Расчёт = new System.Windows.Forms.Button();
            this.nuN = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nuP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nuX1 = new System.Windows.Forms.NumericUpDown();
            this.nuX2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Полнофакторный";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nuX2);
            this.tabPage2.Controls.Add(this.nuX1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nuP);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Расчёт);
            this.tabPage2.Controls.Add(this.nuN);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дробнофакторный";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n";
            // 
            // Расчёт
            // 
            this.Расчёт.Location = new System.Drawing.Point(657, 26);
            this.Расчёт.Name = "Расчёт";
            this.Расчёт.Size = new System.Drawing.Size(75, 23);
            this.Расчёт.TabIndex = 6;
            this.Расчёт.Text = "Расчёт";
            this.Расчёт.UseVisualStyleBackColor = true;
            this.Расчёт.Visible = false;
            this.Расчёт.Click += new System.EventHandler(this.button2_Click);
            // 
            // nuN
            // 
            this.nuN.Location = new System.Drawing.Point(67, 34);
            this.nuN.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nuN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.Name = "nuN";
            this.nuN.Size = new System.Drawing.Size(120, 20);
            this.nuN.TabIndex = 5;
            this.nuN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.ValueChanged += new System.EventHandler(this.nuN_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 186);
            this.dataGridView2.TabIndex = 4;
            // 
            // nuP
            // 
            this.nuP.Location = new System.Drawing.Point(291, 34);
            this.nuP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuP.Name = "nuP";
            this.nuP.Size = new System.Drawing.Size(120, 20);
            this.nuP.TabIndex = 8;
            this.nuP.ValueChanged += new System.EventHandler(this.nuP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "p=";
            // 
            // nuX1
            // 
            this.nuX1.Location = new System.Drawing.Point(502, 36);
            this.nuX1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX1.Name = "nuX1";
            this.nuX1.Size = new System.Drawing.Size(120, 20);
            this.nuX1.TabIndex = 10;
            this.nuX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX1.ValueChanged += new System.EventHandler(this.nuX1_ValueChanged);
            // 
            // nuX2
            // 
            this.nuX2.Location = new System.Drawing.Point(502, 77);
            this.nuX2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX2.Name = "nuX2";
            this.nuX2.Size = new System.Drawing.Size(120, 20);
            this.nuX2.TabIndex = 11;
            this.nuX2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX2.ValueChanged += new System.EventHandler(this.nuX2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "X2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 368);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuX2;
        private System.Windows.Forms.NumericUpDown nuX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Расчёт;
        private System.Windows.Forms.NumericUpDown nuN;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

