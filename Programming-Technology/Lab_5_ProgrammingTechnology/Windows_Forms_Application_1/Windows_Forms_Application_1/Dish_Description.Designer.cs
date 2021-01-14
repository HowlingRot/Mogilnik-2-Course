namespace Windows_Forms_Application_1
{
    partial class Form2
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
            this.Enter_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter_Weight = new System.Windows.Forms.TextBox();
            this.Enter_Cost_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_Name
            // 
            this.Enter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Name.Location = new System.Drawing.Point(120, 15);
            this.Enter_Name.Name = "Enter_Name";
            this.Enter_Name.Size = new System.Drawing.Size(330, 21);
            this.Enter_Name.TabIndex = 6;
            this.Enter_Name.TextChanged += new System.EventHandler(this.Name_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вес:";
            // 
            // Enter_Weight
            // 
            this.Enter_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Weight.Location = new System.Drawing.Point(120, 47);
            this.Enter_Weight.Name = "Enter_Weight";
            this.Enter_Weight.Size = new System.Drawing.Size(330, 21);
            this.Enter_Weight.TabIndex = 9;
            this.Enter_Weight.TextChanged += new System.EventHandler(this.Weight_Changed);
            this.Enter_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_Press);
            // 
            // Enter_Cost_Price
            // 
            this.Enter_Cost_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Cost_Price.Location = new System.Drawing.Point(120, 84);
            this.Enter_Cost_Price.Name = "Enter_Cost_Price";
            this.Enter_Cost_Price.Size = new System.Drawing.Size(330, 21);
            this.Enter_Cost_Price.TabIndex = 10;
            this.Enter_Cost_Price.TextChanged += new System.EventHandler(this.Cost_Price_Changed);
            this.Enter_Cost_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_Price_Press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Себестоимость:";
            // 
            // Enter_Price
            // 
            this.Enter_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Price.Location = new System.Drawing.Point(120, 118);
            this.Enter_Price.Name = "Enter_Price";
            this.Enter_Price.Size = new System.Drawing.Size(330, 21);
            this.Enter_Price.TabIndex = 12;
            this.Enter_Price.TextChanged += new System.EventHandler(this.Price_Changed);
            this.Enter_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_Press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Enabled = false;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_Button.Location = new System.Drawing.Point(299, 156);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(151, 40);
            this.Cancel_Button.TabIndex = 14;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Enabled = false;
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_Button.Location = new System.Drawing.Point(120, 156);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(146, 40);
            this.OK_Button.TabIndex = 15;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 208);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Enter_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Enter_Cost_Price);
            this.Controls.Add(this.Enter_Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_Name);
            this.Name = "Form2";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enter_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Enter_Weight;
        private System.Windows.Forms.TextBox Enter_Cost_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Enter_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}