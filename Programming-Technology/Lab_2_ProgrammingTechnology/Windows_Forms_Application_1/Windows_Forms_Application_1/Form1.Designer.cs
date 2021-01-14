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
            this.Enter_Xn = new System.Windows.Forms.TextBox();
            this.Enter_X0 = new System.Windows.Forms.TextBox();
            this.Enter_dx = new System.Windows.Forms.TextBox();
            this.Enter_b = new System.Windows.Forms.TextBox();
            this.Enter_a = new System.Windows.Forms.TextBox();
            this.Text_Box_Result = new System.Windows.Forms.TextBox();
            this.Result_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.X0 = new System.Windows.Forms.Label();
            this.Xn = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_Xn
            // 
            this.Enter_Xn.Location = new System.Drawing.Point(27, 84);
            this.Enter_Xn.Name = "Enter_Xn";
            this.Enter_Xn.Size = new System.Drawing.Size(227, 20);
            this.Enter_Xn.TabIndex = 13;
            this.Enter_Xn.TextChanged += new System.EventHandler(this.EnterXn_TextChanged);
            this.Enter_Xn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterXn_Press);
            // 
            // Enter_X0
            // 
            this.Enter_X0.Location = new System.Drawing.Point(27, 31);
            this.Enter_X0.Name = "Enter_X0";
            this.Enter_X0.Size = new System.Drawing.Size(227, 20);
            this.Enter_X0.TabIndex = 14;
            this.Enter_X0.TextChanged += new System.EventHandler(this.EnterX0_TextChanged);
            this.Enter_X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterX0_Press);
            // 
            // Enter_dx
            // 
            this.Enter_dx.Location = new System.Drawing.Point(27, 140);
            this.Enter_dx.Name = "Enter_dx";
            this.Enter_dx.Size = new System.Drawing.Size(227, 20);
            this.Enter_dx.TabIndex = 15;
            this.Enter_dx.TextChanged += new System.EventHandler(this.EnterDX_TextChanged);
            this.Enter_dx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterdX_Press);
            // 
            // Enter_b
            // 
            this.Enter_b.Location = new System.Drawing.Point(27, 196);
            this.Enter_b.Name = "Enter_b";
            this.Enter_b.Size = new System.Drawing.Size(227, 20);
            this.Enter_b.TabIndex = 16;
            this.Enter_b.TextChanged += new System.EventHandler(this.EnterB_TextChanged);
            this.Enter_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterB_Press);
            // 
            // Enter_a
            // 
            this.Enter_a.Location = new System.Drawing.Point(27, 253);
            this.Enter_a.Name = "Enter_a";
            this.Enter_a.Size = new System.Drawing.Size(227, 20);
            this.Enter_a.TabIndex = 17;
            this.Enter_a.TextChanged += new System.EventHandler(this.EnterA_TextChanged);
            this.Enter_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterA_Press);
            // 
            // Text_Box_Result
            // 
            this.Text_Box_Result.Location = new System.Drawing.Point(27, 331);
            this.Text_Box_Result.Multiline = true;
            this.Text_Box_Result.Name = "Text_Box_Result";
            this.Text_Box_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Box_Result.Size = new System.Drawing.Size(227, 134);
            this.Text_Box_Result.TabIndex = 21;
            // 
            // Result_Button
            // 
            this.Result_Button.Location = new System.Drawing.Point(27, 496);
            this.Result_Button.Name = "Result_Button";
            this.Result_Button.Size = new System.Drawing.Size(75, 40);
            this.Result_Button.TabIndex = 22;
            this.Result_Button.Text = "Результат";
            this.Result_Button.UseVisualStyleBackColor = true;
            this.Result_Button.Click += new System.EventHandler(this.Result_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(179, 496);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 40);
            this.Clear_Button.TabIndex = 23;
            this.Clear_Button.Text = "Очистка";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Click);
            // 
            // X0
            // 
            this.X0.AutoSize = true;
            this.X0.Location = new System.Drawing.Point(24, 15);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(68, 13);
            this.X0.TabIndex = 24;
            this.X0.Text = "Введите X0:";
            // 
            // Xn
            // 
            this.Xn.AutoSize = true;
            this.Xn.Location = new System.Drawing.Point(24, 68);
            this.Xn.Name = "Xn";
            this.Xn.Size = new System.Drawing.Size(68, 13);
            this.Xn.TabIndex = 25;
            this.Xn.Text = "Введите Xn:";
            // 
            // dx
            // 
            this.dx.AutoSize = true;
            this.dx.Location = new System.Drawing.Point(24, 124);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(66, 13);
            this.dx.TabIndex = 26;
            this.dx.Text = "Введите dx:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(24, 180);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(61, 13);
            this.b.TabIndex = 27;
            this.b.Text = "Введите b:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(24, 237);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(61, 13);
            this.a.TabIndex = 28;
            this.a.Text = "Введите a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ответ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.Xn);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Result_Button);
            this.Controls.Add(this.Text_Box_Result);
            this.Controls.Add(this.Enter_a);
            this.Controls.Add(this.Enter_b);
            this.Controls.Add(this.Enter_dx);
            this.Controls.Add(this.Enter_X0);
            this.Controls.Add(this.Enter_Xn);
            this.Name = "Form1";
            this.Text = "Function";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enter_Xn;
        private System.Windows.Forms.TextBox Enter_X0;
        private System.Windows.Forms.TextBox Enter_dx;
        private System.Windows.Forms.TextBox Enter_b;
        private System.Windows.Forms.TextBox Enter_a;
        private System.Windows.Forms.TextBox Text_Box_Result;
        private System.Windows.Forms.Button Result_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label X0;
        private System.Windows.Forms.Label Xn;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label1;
    }
}

