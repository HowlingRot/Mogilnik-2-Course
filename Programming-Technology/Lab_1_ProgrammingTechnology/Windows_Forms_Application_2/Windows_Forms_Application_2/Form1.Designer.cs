namespace Windows_Forms_Application_2
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
            this.EnterX = new System.Windows.Forms.TextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.EnterY = new System.Windows.Forms.TextBox();
            this.LabelY = new System.Windows.Forms.Label();
            this.EnterZ = new System.Windows.Forms.TextBox();
            this.LabelZ = new System.Windows.Forms.Label();
            this.ResultWindow = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // EnterX
            // 
            this.EnterX.Location = new System.Drawing.Point(12, 42);
            this.EnterX.Name = "EnterX";
            this.EnterX.Size = new System.Drawing.Size(280, 20);
            this.EnterX.TabIndex = 9;
            this.EnterX.TextChanged += new System.EventHandler(this.EnterX_TextChanged);
            this.EnterX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterX_Press);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(12, 26);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(62, 13);
            this.LabelX.TabIndex = 10;
            this.LabelX.Text = "Введите X:";
            // 
            // EnterY
            // 
            this.EnterY.Location = new System.Drawing.Point(12, 97);
            this.EnterY.Name = "EnterY";
            this.EnterY.Size = new System.Drawing.Size(280, 20);
            this.EnterY.TabIndex = 11;
            this.EnterY.TextChanged += new System.EventHandler(this.EnterY_TextChanged);
            this.EnterY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterY_Press);
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(12, 81);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(62, 13);
            this.LabelY.TabIndex = 12;
            this.LabelY.Text = "Введите Y:";
            // 
            // EnterZ
            // 
            this.EnterZ.Location = new System.Drawing.Point(12, 150);
            this.EnterZ.Name = "EnterZ";
            this.EnterZ.Size = new System.Drawing.Size(280, 20);
            this.EnterZ.TabIndex = 13;
            this.EnterZ.TextChanged += new System.EventHandler(this.EnterZ_TextChanged);
            this.EnterZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterZ_Press);
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Location = new System.Drawing.Point(12, 134);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(62, 13);
            this.LabelZ.TabIndex = 14;
            this.LabelZ.Text = "Введите Z:";
            // 
            // ResultWindow
            // 
            this.ResultWindow.BackColor = System.Drawing.SystemColors.Window;
            this.ResultWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultWindow.Location = new System.Drawing.Point(12, 322);
            this.ResultWindow.Name = "ResultWindow";
            this.ResultWindow.Size = new System.Drawing.Size(280, 28);
            this.ResultWindow.TabIndex = 15;
            this.ResultWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(188, 379);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 50);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистка";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultButton.Location = new System.Drawing.Point(15, 379);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(104, 50);
            this.ResultButton.TabIndex = 17;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ответ:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.Text = "e^x";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.Radio_Button_2);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "x^2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Radio_Button_3);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 192);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sh x";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Radio_Button_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultWindow);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.EnterZ);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.EnterY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.EnterX);
            this.Name = "Form1";
            this.Text = "Function№2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterX;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox EnterY;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.TextBox EnterZ;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label ResultWindow;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

