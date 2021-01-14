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
            this.ListBox_Array = new System.Windows.Forms.ListBox();
            this.ListBox_Formula = new System.Windows.Forms.ListBox();
            this.ListBox_Change = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Array_Number = new System.Windows.Forms.TextBox();
            this.Button_Create_Array = new System.Windows.Forms.Button();
            this.Button_Array_Function = new System.Windows.Forms.Button();
            this.Button_Array_Sort = new System.Windows.Forms.Button();
            this.Button_Array_Change = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Yi = new System.Windows.Forms.TextBox();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_Array
            // 
            this.ListBox_Array.FormattingEnabled = true;
            this.ListBox_Array.Location = new System.Drawing.Point(12, 27);
            this.ListBox_Array.Name = "ListBox_Array";
            this.ListBox_Array.Size = new System.Drawing.Size(191, 264);
            this.ListBox_Array.TabIndex = 1;
            // 
            // ListBox_Formula
            // 
            this.ListBox_Formula.FormattingEnabled = true;
            this.ListBox_Formula.Location = new System.Drawing.Point(240, 27);
            this.ListBox_Formula.Name = "ListBox_Formula";
            this.ListBox_Formula.Size = new System.Drawing.Size(191, 264);
            this.ListBox_Formula.TabIndex = 2;
            // 
            // ListBox_Change
            // 
            this.ListBox_Change.FormattingEnabled = true;
            this.ListBox_Change.Location = new System.Drawing.Point(465, 27);
            this.ListBox_Change.Name = "ListBox_Change";
            this.ListBox_Change.Size = new System.Drawing.Size(191, 225);
            this.ListBox_Change.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начальный массив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вычисление по общей формуле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вычисление по  формуле с варианта:";
            // 
            // Array_Number
            // 
            this.Array_Number.Location = new System.Drawing.Point(12, 309);
            this.Array_Number.Name = "Array_Number";
            this.Array_Number.Size = new System.Drawing.Size(644, 20);
            this.Array_Number.TabIndex = 11;
            this.Array_Number.TextChanged += new System.EventHandler(this.Array_Number_Changed);
            // 
            // Button_Create_Array
            // 
            this.Button_Create_Array.Location = new System.Drawing.Point(12, 335);
            this.Button_Create_Array.Name = "Button_Create_Array";
            this.Button_Create_Array.Size = new System.Drawing.Size(77, 47);
            this.Button_Create_Array.TabIndex = 12;
            this.Button_Create_Array.Text = "Заполнить массив";
            this.Button_Create_Array.UseVisualStyleBackColor = true;
            this.Button_Create_Array.Click += new System.EventHandler(this.Array_Create_Click);
            // 
            // Button_Array_Function
            // 
            this.Button_Array_Function.Location = new System.Drawing.Point(183, 335);
            this.Button_Array_Function.Name = "Button_Array_Function";
            this.Button_Array_Function.Size = new System.Drawing.Size(77, 47);
            this.Button_Array_Function.TabIndex = 13;
            this.Button_Array_Function.Text = "Вычислить";
            this.Button_Array_Function.UseVisualStyleBackColor = true;
            this.Button_Array_Function.Click += new System.EventHandler(this.Array_Function_Click);
            // 
            // Button_Array_Sort
            // 
            this.Button_Array_Sort.Location = new System.Drawing.Point(301, 335);
            this.Button_Array_Sort.Name = "Button_Array_Sort";
            this.Button_Array_Sort.Size = new System.Drawing.Size(77, 47);
            this.Button_Array_Sort.TabIndex = 14;
            this.Button_Array_Sort.Text = "Сортировка";
            this.Button_Array_Sort.UseVisualStyleBackColor = true;
            this.Button_Array_Sort.Click += new System.EventHandler(this.Array_Sort_Click);
            // 
            // Button_Array_Change
            // 
            this.Button_Array_Change.Location = new System.Drawing.Point(414, 335);
            this.Button_Array_Change.Name = "Button_Array_Change";
            this.Button_Array_Change.Size = new System.Drawing.Size(77, 47);
            this.Button_Array_Change.TabIndex = 15;
            this.Button_Array_Change.Text = "Изменения";
            this.Button_Array_Change.UseVisualStyleBackColor = true;
            this.Button_Array_Change.Click += new System.EventHandler(this.Array_Change_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(579, 335);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(77, 47);
            this.Button_Clear.TabIndex = 16;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество элементов в массиве:";
            // 
            // Yi
            // 
            this.Yi.Location = new System.Drawing.Point(465, 271);
            this.Yi.Name = "Yi";
            this.Yi.Size = new System.Drawing.Size(69, 20);
            this.Yi.TabIndex = 18;
            // 
            // Y0
            // 
            this.Y0.Location = new System.Drawing.Point(579, 271);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(69, 20);
            this.Y0.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Y0:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.Yi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Array_Change);
            this.Controls.Add(this.Button_Array_Sort);
            this.Controls.Add(this.Button_Array_Function);
            this.Controls.Add(this.Button_Create_Array);
            this.Controls.Add(this.Array_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox_Change);
            this.Controls.Add(this.ListBox_Formula);
            this.Controls.Add(this.ListBox_Array);
            this.Name = "Form1";
            this.Text = "Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Array;
        private System.Windows.Forms.ListBox ListBox_Formula;
        private System.Windows.Forms.ListBox ListBox_Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Array_Number;
        private System.Windows.Forms.Button Button_Create_Array;
        private System.Windows.Forms.Button Button_Array_Function;
        private System.Windows.Forms.Button Button_Array_Sort;
        private System.Windows.Forms.Button Button_Array_Change;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Yi;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

