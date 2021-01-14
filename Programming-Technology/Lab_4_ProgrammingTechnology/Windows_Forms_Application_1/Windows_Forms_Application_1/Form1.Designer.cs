namespace Windows_Forms_Application_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Enter_X0 = new System.Windows.Forms.TextBox();
            this.Enter_Xn = new System.Windows.Forms.TextBox();
            this.Enter_dX = new System.Windows.Forms.TextBox();
            this.Enter_b = new System.Windows.Forms.TextBox();
            this.Enter_a = new System.Windows.Forms.TextBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 28);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(517, 349);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Enter_X0
            // 
            this.Enter_X0.Location = new System.Drawing.Point(545, 28);
            this.Enter_X0.Name = "Enter_X0";
            this.Enter_X0.Size = new System.Drawing.Size(220, 20);
            this.Enter_X0.TabIndex = 42;
            this.Enter_X0.TextChanged += new System.EventHandler(this.X0_Changed);
            // 
            // Enter_Xn
            // 
            this.Enter_Xn.Location = new System.Drawing.Point(545, 81);
            this.Enter_Xn.Name = "Enter_Xn";
            this.Enter_Xn.Size = new System.Drawing.Size(219, 20);
            this.Enter_Xn.TabIndex = 43;
            this.Enter_Xn.TextChanged += new System.EventHandler(this.Xn_Changed);
            // 
            // Enter_dX
            // 
            this.Enter_dX.Location = new System.Drawing.Point(545, 137);
            this.Enter_dX.Name = "Enter_dX";
            this.Enter_dX.Size = new System.Drawing.Size(219, 20);
            this.Enter_dX.TabIndex = 44;
            this.Enter_dX.TextChanged += new System.EventHandler(this.dX_Changed);
            // 
            // Enter_b
            // 
            this.Enter_b.Location = new System.Drawing.Point(545, 193);
            this.Enter_b.Name = "Enter_b";
            this.Enter_b.Size = new System.Drawing.Size(219, 20);
            this.Enter_b.TabIndex = 45;
            this.Enter_b.TextChanged += new System.EventHandler(this.b_Changed);
            // 
            // Enter_a
            // 
            this.Enter_a.Location = new System.Drawing.Point(546, 249);
            this.Enter_a.Name = "Enter_a";
            this.Enter_a.Size = new System.Drawing.Size(219, 20);
            this.Enter_a.TabIndex = 46;
            this.Enter_a.TextChanged += new System.EventHandler(this.a_Changed);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Clear.Location = new System.Drawing.Point(661, 327);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(104, 50);
            this.Button_Clear.TabIndex = 48;
            this.Button_Clear.Text = "Очистка";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Button_Result
            // 
            this.Button_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Result.Location = new System.Drawing.Point(546, 327);
            this.Button_Result.Name = "Button_Result";
            this.Button_Result.Size = new System.Drawing.Size(104, 50);
            this.Button_Result.TabIndex = 49;
            this.Button_Result.Text = "Результат";
            this.Button_Result.UseVisualStyleBackColor = true;
            this.Button_Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Введите X0:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Введите Xn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Введите dX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Введите b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Введите a:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Result);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Enter_a);
            this.Controls.Add(this.Enter_b);
            this.Controls.Add(this.Enter_dX);
            this.Controls.Add(this.Enter_Xn);
            this.Controls.Add(this.Enter_X0);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Function graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox Enter_X0;
        private System.Windows.Forms.TextBox Enter_Xn;
        private System.Windows.Forms.TextBox Enter_dX;
        private System.Windows.Forms.TextBox Enter_b;
        private System.Windows.Forms.TextBox Enter_a;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

