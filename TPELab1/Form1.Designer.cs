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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.nuP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Расчёт = new System.Windows.Forms.Button();
            this.nuN = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nuX2 = new System.Windows.Forms.NumericUpDown();
            this.nuX1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 420);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Полнофакторный";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
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
            this.tabPage2.Size = new System.Drawing.Size(768, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дробнофакторный";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.nuP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuP.ValueChanged += new System.EventHandler(this.nuP_ValueChanged);
            this.nuP.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.numericUpDown1_ValueChanged);
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
            2,
            0,
            0,
            0});
            this.nuN.ValueChanged += new System.EventHandler(this.nuN_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 186);
            this.dataGridView2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "X2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "X1";
            // 
            // nuX2
            // 
            this.nuX2.Location = new System.Drawing.Point(38, 356);
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
            this.nuX2.Size = new System.Drawing.Size(41, 20);
            this.nuX2.TabIndex = 15;
            this.nuX2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX2.ValueChanged += new System.EventHandler(this.nuX2_ValueChanged);
            // 
            // nuX1
            // 
            this.nuX1.Location = new System.Drawing.Point(36, 315);
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
            this.nuX1.Size = new System.Drawing.Size(41, 20);
            this.nuX1.TabIndex = 14;
            this.nuX1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuX1.ValueChanged += new System.EventHandler(this.nuX1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 428);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Теория планирования экспериментов ЛР1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Расчёт;
        private System.Windows.Forms.NumericUpDown nuN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuX2;
        private System.Windows.Forms.NumericUpDown nuX1;
    }
}

