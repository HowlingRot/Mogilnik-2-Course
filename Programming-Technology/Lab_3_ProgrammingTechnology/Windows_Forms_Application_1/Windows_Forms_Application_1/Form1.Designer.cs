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
            this.Enter_Text = new System.Windows.Forms.TextBox();
            this.Result_Text = new System.Windows.Forms.TextBox();
            this.Button_Result = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_Text
            // 
            this.Enter_Text.Location = new System.Drawing.Point(12, 36);
            this.Enter_Text.Name = "Enter_Text";
            this.Enter_Text.Size = new System.Drawing.Size(402, 20);
            this.Enter_Text.TabIndex = 1;
            this.Enter_Text.TextChanged += new System.EventHandler(this.Enter_Text_Changed);
            // 
            // Result_Text
            // 
            this.Result_Text.Location = new System.Drawing.Point(12, 107);
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.ReadOnly = true;
            this.Result_Text.Size = new System.Drawing.Size(402, 20);
            this.Result_Text.TabIndex = 25;
            // 
            // Button_Result
            // 
            this.Button_Result.Location = new System.Drawing.Point(12, 157);
            this.Button_Result.Name = "Button_Result";
            this.Button_Result.Size = new System.Drawing.Size(132, 47);
            this.Button_Result.TabIndex = 26;
            this.Button_Result.Text = "Результат";
            this.Button_Result.UseVisualStyleBackColor = true;
            this.Button_Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(282, 157);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(132, 47);
            this.Button_Clear.TabIndex = 27;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите строку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Результат вычислений:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Result);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.Enter_Text);
            this.Name = "Form1";
            this.Text = "Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enter_Text;
        private System.Windows.Forms.TextBox Result_Text;
        private System.Windows.Forms.Button Button_Result;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

