namespace Windows_Forms_Application_1
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.Entries = new System.Windows.Forms.ListBox();
            this.Max_Price = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Calculation_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Download_Button = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Strip_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.Strip_Cost_Price = new System.Windows.Forms.ToolStripStatusLabel();
            this.Strip_Weight = new System.Windows.Forms.ToolStripStatusLabel();
            this.Strip_Price = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.Change_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.Delete_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.Download_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.Save_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.Calculation_Button_Menu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Strip__Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Strip__Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Strip__Button = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculation_Strip__Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entries
            // 
            this.Entries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Entries.FormattingEnabled = true;
            this.Entries.ItemHeight = 15;
            this.Entries.Location = new System.Drawing.Point(12, 79);
            this.Entries.Name = "Entries";
            this.Entries.Size = new System.Drawing.Size(338, 334);
            this.Entries.TabIndex = 4;
            this.Entries.SelectedValueChanged += new System.EventHandler(this.Entries_Change);
            // 
            // Max_Price
            // 
            this.Max_Price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Max_Price.Location = new System.Drawing.Point(12, 439);
            this.Max_Price.Multiline = true;
            this.Max_Price.Name = "Max_Price";
            this.Max_Price.ReadOnly = true;
            this.Max_Price.Size = new System.Drawing.Size(338, 24);
            this.Max_Price.TabIndex = 5;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(356, 79);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(95, 36);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Button.Location = new System.Drawing.Point(356, 121);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(95, 36);
            this.Change_Button.TabIndex = 7;
            this.Change_Button.Text = "Изменить";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Button.Location = new System.Drawing.Point(356, 163);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(95, 36);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Удаление";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Calculation_Button
            // 
            this.Calculation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculation_Button.Location = new System.Drawing.Point(356, 377);
            this.Calculation_Button.Name = "Calculation_Button";
            this.Calculation_Button.Size = new System.Drawing.Size(95, 36);
            this.Calculation_Button.TabIndex = 9;
            this.Calculation_Button.Text = "Расчёт";
            this.Calculation_Button.UseVisualStyleBackColor = true;
            this.Calculation_Button.Click += new System.EventHandler(this.Calculation_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Button.Location = new System.Drawing.Point(356, 293);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(95, 36);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Download_Button
            // 
            this.Download_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_Button.Location = new System.Drawing.Point(356, 335);
            this.Download_Button.Name = "Download_Button";
            this.Download_Button.Size = new System.Drawing.Size(95, 36);
            this.Download_Button.TabIndex = 11;
            this.Download_Button.Text = "Загрузить";
            this.Download_Button.UseVisualStyleBackColor = true;
            this.Download_Button.Click += new System.EventHandler(this.Download_Button_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(456, 25);
            this.Menu.TabIndex = 12;
            this.Menu.Text = "toolStrip1";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Button_Menu,
            this.Change_Button_Menu,
            this.Delete_Button_Menu,
            this.toolStripSeparator1,
            this.Download_Button_Menu,
            this.Save_Button_Menu,
            this.Calculation_Button_Menu});
            this.ToolBar.Location = new System.Drawing.Point(0, 25);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(456, 25);
            this.ToolBar.TabIndex = 13;
            this.ToolBar.Text = "toolStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_Name,
            this.Strip_Weight,
            this.Strip_Cost_Price,
            this.Strip_Price});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Strip_Name
            // 
            this.Strip_Name.Name = "Strip_Name";
            this.Strip_Name.Size = new System.Drawing.Size(110, 17);
            this.Strip_Name.Spring = true;
            this.Strip_Name.Text = "...";
            this.Strip_Name.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Strip_Cost_Price
            // 
            this.Strip_Cost_Price.Name = "Strip_Cost_Price";
            this.Strip_Cost_Price.Size = new System.Drawing.Size(110, 17);
            this.Strip_Cost_Price.Spring = true;
            this.Strip_Cost_Price.Text = "...";
            // 
            // Strip_Weight
            // 
            this.Strip_Weight.Name = "Strip_Weight";
            this.Strip_Weight.Size = new System.Drawing.Size(110, 17);
            this.Strip_Weight.Spring = true;
            this.Strip_Weight.Text = "...";
            // 
            // Strip_Price
            // 
            this.Strip_Price.Name = "Strip_Price";
            this.Strip_Price.Size = new System.Drawing.Size(110, 17);
            this.Strip_Price.Spring = true;
            this.Strip_Price.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Наше меню:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Самое прибыльное блюдо:";
            // 
            // Add_Button_Menu
            // 
            this.Add_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Add_Button_Menu.Image")));
            this.Add_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_Button_Menu.Name = "Add_Button_Menu";
            this.Add_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Add_Button_Menu.Text = "toolStripButton1";
            this.Add_Button_Menu.Click += new System.EventHandler(this.Add_Button_Menu_Click);
            // 
            // Change_Button_Menu
            // 
            this.Change_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Change_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Change_Button_Menu.Image")));
            this.Change_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change_Button_Menu.Name = "Change_Button_Menu";
            this.Change_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Change_Button_Menu.Text = "toolStripButton2";
            this.Change_Button_Menu.Click += new System.EventHandler(this.Change_Button_Menu_Click);
            // 
            // Delete_Button_Menu
            // 
            this.Delete_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Button_Menu.Image")));
            this.Delete_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Button_Menu.Name = "Delete_Button_Menu";
            this.Delete_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Delete_Button_Menu.Text = "toolStripButton3";
            this.Delete_Button_Menu.Click += new System.EventHandler(this.Delete_Button_Menu_Click);
            // 
            // Download_Button_Menu
            // 
            this.Download_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Download_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Download_Button_Menu.Image")));
            this.Download_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Download_Button_Menu.Name = "Download_Button_Menu";
            this.Download_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Download_Button_Menu.Text = "toolStripButton4";
            this.Download_Button_Menu.Click += new System.EventHandler(this.Download_Button_Menu_Click);
            // 
            // Save_Button_Menu
            // 
            this.Save_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Save_Button_Menu.Image")));
            this.Save_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_Button_Menu.Name = "Save_Button_Menu";
            this.Save_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Save_Button_Menu.Text = "toolStripButton5";
            this.Save_Button_Menu.Click += new System.EventHandler(this.Save_Button_Menu_Click);
            // 
            // Calculation_Button_Menu
            // 
            this.Calculation_Button_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calculation_Button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Calculation_Button_Menu.Image")));
            this.Calculation_Button_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calculation_Button_Menu.Name = "Calculation_Button_Menu";
            this.Calculation_Button_Menu.Size = new System.Drawing.Size(23, 22);
            this.Calculation_Button_Menu.Text = "toolStripButton1";
            this.Calculation_Button_Menu.Click += new System.EventHandler(this.Calculation_Button_Menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.Change_Strip__Button,
            this.Delete_Strip__Button,
            this.Save_Strip__Button,
            this.загрузитьToolStripMenuItem,
            this.Calculation_Strip__Button});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripSplitButton1.Text = "Меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click_Add);
            // 
            // Change_Strip__Button
            // 
            this.Change_Strip__Button.Name = "Change_Strip__Button";
            this.Change_Strip__Button.Size = new System.Drawing.Size(180, 22);
            this.Change_Strip__Button.Text = "Изменить";
            this.Change_Strip__Button.Click += new System.EventHandler(this.Menu_Click_Change);
            // 
            // Delete_Strip__Button
            // 
            this.Delete_Strip__Button.Name = "Delete_Strip__Button";
            this.Delete_Strip__Button.Size = new System.Drawing.Size(180, 22);
            this.Delete_Strip__Button.Text = "Удалить";
            this.Delete_Strip__Button.Click += new System.EventHandler(this.Menu_Click_Delete);
            // 
            // Save_Strip__Button
            // 
            this.Save_Strip__Button.Name = "Save_Strip__Button";
            this.Save_Strip__Button.Size = new System.Drawing.Size(180, 22);
            this.Save_Strip__Button.Text = "Сохранить";
            this.Save_Strip__Button.Click += new System.EventHandler(this.Menu_Click_Save);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.Menu_Click_Download);
            // 
            // Calculation_Strip__Button
            // 
            this.Calculation_Strip__Button.Name = "Calculation_Strip__Button";
            this.Calculation_Strip__Button.Size = new System.Drawing.Size(180, 22);
            this.Calculation_Strip__Button.Text = "Расчёт";
            this.Calculation_Strip__Button.Click += new System.EventHandler(this.Button_Click_Calculation);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Download_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Calculation_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Max_Price);
            this.Controls.Add(this.Entries);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Entries;
        private System.Windows.Forms.TextBox Max_Price;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Calculation_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Download_Button;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Strip_Name;
        private System.Windows.Forms.ToolStripStatusLabel Strip_Cost_Price;
        private System.Windows.Forms.ToolStripStatusLabel Strip_Weight;
        private System.Windows.Forms.ToolStripStatusLabel Strip_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton Add_Button_Menu;
        private System.Windows.Forms.ToolStripButton Change_Button_Menu;
        private System.Windows.Forms.ToolStripButton Delete_Button_Menu;
        private System.Windows.Forms.ToolStripButton Download_Button_Menu;
        private System.Windows.Forms.ToolStripButton Save_Button_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Calculation_Button_Menu;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Change_Strip__Button;
        private System.Windows.Forms.ToolStripMenuItem Delete_Strip__Button;
        private System.Windows.Forms.ToolStripMenuItem Save_Strip__Button;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Calculation_Strip__Button;
    }
}