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
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterY = new System.Windows.Forms.TextBox();
            this.EnterZ = new System.Windows.Forms.TextBox();
            this.EnterX = new System.Windows.Forms.TextBox();
            this.ResultWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(197, 268);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 50);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Очистка";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultButton.Location = new System.Drawing.Point(21, 268);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(104, 50);
            this.ResultButton.TabIndex = 1;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.Result_Click);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(18, 25);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(62, 13);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "Введите X:";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(18, 73);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(62, 13);
            this.LabelY.TabIndex = 3;
            this.LabelY.Text = "Введите Y:";
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Location = new System.Drawing.Point(18, 124);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(62, 13);
            this.LabelZ.TabIndex = 4;
            this.LabelZ.Text = "Введите Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EnterY
            // 
            this.EnterY.Location = new System.Drawing.Point(21, 89);
            this.EnterY.Name = "EnterY";
            this.EnterY.Size = new System.Drawing.Size(280, 20);
            this.EnterY.TabIndex = 6;
            this.EnterY.TextChanged += new System.EventHandler(this.EnterY_TextChanged);
            this.EnterY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterY_Press);
            // 
            // EnterZ
            // 
            this.EnterZ.Location = new System.Drawing.Point(21, 140);
            this.EnterZ.Name = "EnterZ";
            this.EnterZ.Size = new System.Drawing.Size(280, 20);
            this.EnterZ.TabIndex = 7;
            this.EnterZ.TextChanged += new System.EventHandler(this.EnterZ_TextChanged);
            this.EnterZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterZ_Press);
            // 
            // EnterX
            // 
            this.EnterX.Location = new System.Drawing.Point(21, 41);
            this.EnterX.Name = "EnterX";
            this.EnterX.Size = new System.Drawing.Size(280, 20);
            this.EnterX.TabIndex = 8;
            this.EnterX.TextChanged += new System.EventHandler(this.EnterX_TextChanged);
            this.EnterX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterX_Press);
            // 
            // ResultWindow
            // 
            this.ResultWindow.BackColor = System.Drawing.SystemColors.Window;
            this.ResultWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultWindow.Location = new System.Drawing.Point(21, 207);
            this.ResultWindow.Name = "ResultWindow";
            this.ResultWindow.Size = new System.Drawing.Size(280, 28);
            this.ResultWindow.TabIndex = 12;
            this.ResultWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ответ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(324, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultWindow);
            this.Controls.Add(this.EnterX);
            this.Controls.Add(this.EnterZ);
            this.Controls.Add(this.EnterY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.ClearButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Function№1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EnterY;
        private System.Windows.Forms.TextBox EnterZ;
        private System.Windows.Forms.TextBox EnterX;
        private System.Windows.Forms.Label ResultWindow;
        private System.Windows.Forms.Label label1;
    }
}

