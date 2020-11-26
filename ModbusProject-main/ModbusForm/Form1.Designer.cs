namespace ModbusForm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBox1 = new System.Windows.Forms.TextBox();
            this.addBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonDis = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonPrepBool = new System.Windows.Forms.Button();
            this.buttonPrepInt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addBox3 = new System.Windows.Forms.TextBox();
            this.textBoxBool = new System.Windows.Forms.TextBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.buttonWExecute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.functionBox2 = new System.Windows.Forms.ComboBox();
            this.labelStan = new System.Windows.Forms.Label();
            this.buttonCrt = new System.Windows.Forms.Button();
            this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InteruptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(8, 81);
            this.buttonCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(105, 45);
            this.buttonCon.TabIndex = 0;
            this.buttonCon.Text = "Połącz";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj Ip: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj port:";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(8, 21);
            this.ipBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(106, 20);
            this.ipBox.TabIndex = 3;
            this.ipBox.Text = "127.0.0.1";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(8, 60);
            this.portBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(106, 20);
            this.portBox.TabIndex = 4;
            this.portBox.Text = "502";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 238);
            this.listBox1.TabIndex = 5;
            // 
            // functionBox
            // 
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Location = new System.Drawing.Point(135, 109);
            this.functionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(138, 21);
            this.functionBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funkcja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liczba wartości:";
            // 
            // addBox1
            // 
            this.addBox1.Location = new System.Drawing.Point(135, 21);
            this.addBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBox1.Name = "addBox1";
            this.addBox1.Size = new System.Drawing.Size(49, 20);
            this.addBox1.TabIndex = 12;
            this.addBox1.Text = "0";
            // 
            // addBox2
            // 
            this.addBox2.Location = new System.Drawing.Point(135, 60);
            this.addBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBox2.Name = "addBox2";
            this.addBox2.Size = new System.Drawing.Size(49, 20);
            this.addBox2.TabIndex = 13;
            this.addBox2.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adres początkowy:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(275, 261);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 238);
            this.listBox2.TabIndex = 15;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(135, 132);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(137, 44);
            this.buttonExecute.TabIndex = 16;
            this.buttonExecute.Text = "Wykonaj";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonDis
            // 
            this.buttonDis.Location = new System.Drawing.Point(8, 131);
            this.buttonDis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDis.Name = "buttonDis";
            this.buttonDis.Size = new System.Drawing.Size(105, 45);
            this.buttonDis.TabIndex = 17;
            this.buttonDis.Text = "Rozłącz";
            this.buttonDis.UseVisualStyleBackColor = true;
            this.buttonDis.Click += new System.EventHandler(this.buttonDis_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(546, 261);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 52);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(613, 261);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(53, 52);
            this.buttonClearAll.TabIndex = 19;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonPrepBool
            // 
            this.buttonPrepBool.Location = new System.Drawing.Point(546, 328);
            this.buttonPrepBool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrepBool.Name = "buttonPrepBool";
            this.buttonPrepBool.Size = new System.Drawing.Size(121, 52);
            this.buttonPrepBool.TabIndex = 20;
            this.buttonPrepBool.Text = "Prepare bool";
            this.buttonPrepBool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrepBool.UseVisualStyleBackColor = true;
            this.buttonPrepBool.Click += new System.EventHandler(this.buttonPrepBool_Click);
            // 
            // buttonPrepInt
            // 
            this.buttonPrepInt.Location = new System.Drawing.Point(546, 390);
            this.buttonPrepInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrepInt.Name = "buttonPrepInt";
            this.buttonPrepInt.Size = new System.Drawing.Size(121, 52);
            this.buttonPrepInt.TabIndex = 21;
            this.buttonPrepInt.Text = "Prepare int";
            this.buttonPrepInt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrepInt.UseVisualStyleBackColor = true;
            this.buttonPrepInt.Click += new System.EventHandler(this.buttonPrepInt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adres początkowy:";
            // 
            // addBox3
            // 
            this.addBox3.Location = new System.Drawing.Point(135, 276);
            this.addBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBox3.Name = "addBox3";
            this.addBox3.Size = new System.Drawing.Size(49, 20);
            this.addBox3.TabIndex = 22;
            this.addBox3.Text = "0";
            // 
            // textBoxBool
            // 
            this.textBoxBool.Location = new System.Drawing.Point(671, 328);
            this.textBoxBool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBool.Name = "textBoxBool";
            this.textBoxBool.ReadOnly = true;
            this.textBoxBool.Size = new System.Drawing.Size(68, 20);
            this.textBoxBool.TabIndex = 24;
            this.textBoxBool.Text = "FALSE";
            this.textBoxBool.DoubleClick += new System.EventHandler(this.textBoxBool_Click);
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(671, 390);
            this.textBoxInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(68, 20);
            this.textBoxInt.TabIndex = 25;
            // 
            // buttonWExecute
            // 
            this.buttonWExecute.Location = new System.Drawing.Point(135, 432);
            this.buttonWExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWExecute.Name = "buttonWExecute";
            this.buttonWExecute.Size = new System.Drawing.Size(137, 44);
            this.buttonWExecute.TabIndex = 26;
            this.buttonWExecute.Text = "Wykonaj";
            this.buttonWExecute.UseVisualStyleBackColor = true;
            this.buttonWExecute.Click += new System.EventHandler(this.buttonWExecute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Funkcja";
            // 
            // functionBox2
            // 
            this.functionBox2.FormattingEnabled = true;
            this.functionBox2.Location = new System.Drawing.Point(135, 409);
            this.functionBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionBox2.Name = "functionBox2";
            this.functionBox2.Size = new System.Drawing.Size(138, 21);
            this.functionBox2.TabIndex = 27;
            // 
            // labelStan
            // 
            this.labelStan.AutoSize = true;
            this.labelStan.Location = new System.Drawing.Point(9, 181);
            this.labelStan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStan.Name = "labelStan";
            this.labelStan.Size = new System.Drawing.Size(113, 13);
            this.labelStan.TabIndex = 29;
            this.labelStan.Text = "Stan: Brak połączenia";
            // 
            // buttonCrt
            // 
            this.buttonCrt.Location = new System.Drawing.Point(789, 246);
            this.buttonCrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrt.Name = "buttonCrt";
            this.buttonCrt.Size = new System.Drawing.Size(53, 52);
            this.buttonCrt.TabIndex = 30;
            this.buttonCrt.Text = "Create Chart";
            this.buttonCrt.UseVisualStyleBackColor = true;
            this.buttonCrt.Click += new System.EventHandler(this.buttonCrt_Click);
            // 
            // chartD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartD.Legends.Add(legend1);
            this.chartD.Location = new System.Drawing.Point(531, 6);
            this.chartD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartD.Name = "chartD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "values";
            this.chartD.Series.Add(series1);
            this.chartD.Size = new System.Drawing.Size(311, 237);
            this.chartD.TabIndex = 31;
            this.chartD.Text = "chart1";
            // 
            // InteruptBtn
            // 
            this.InteruptBtn.Location = new System.Drawing.Point(135, 181);
            this.InteruptBtn.Name = "InteruptBtn";
            this.InteruptBtn.Size = new System.Drawing.Size(138, 47);
            this.InteruptBtn.TabIndex = 32;
            this.InteruptBtn.Text = "Interupt thread";
            this.InteruptBtn.UseVisualStyleBackColor = true;
            this.InteruptBtn.Click += new System.EventHandler(this.InteruptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(850, 525);
            this.Controls.Add(this.InteruptBtn);
            this.Controls.Add(this.chartD);
            this.Controls.Add(this.buttonCrt);
            this.Controls.Add(this.labelStan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.functionBox2);
            this.Controls.Add(this.buttonWExecute);
            this.Controls.Add(this.textBoxInt);
            this.Controls.Add(this.textBoxBool);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addBox3);
            this.Controls.Add(this.buttonPrepInt);
            this.Controls.Add(this.buttonPrepBool);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDis);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addBox2);
            this.Controls.Add(this.addBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addBox1;
        private System.Windows.Forms.TextBox addBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonDis;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonPrepBool;
        private System.Windows.Forms.Button buttonPrepInt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addBox3;
        private System.Windows.Forms.TextBox textBoxBool;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Button buttonWExecute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox functionBox2;
        private System.Windows.Forms.Label labelStan;
        private System.Windows.Forms.Button buttonCrt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button InteruptBtn;
    }
}

