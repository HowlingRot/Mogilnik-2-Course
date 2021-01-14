using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResultButton.Enabled = false;                  
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            try
            {
                if (EnterX.Text == "" || EnterY.Text == "" || EnterZ.Text == "")
                {
                    MessageBox.Show("Введите все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x = double.Parse(EnterX.Text);
                    y = double.Parse(EnterY.Text);
                    z = double.Parse(EnterZ.Text);

                    double Operation1 = Math.Sin(x) + Math.Pow(y, 2) + Math.Pow(Math.E, Math.Sin(z));
                    double Operation2 = Math.Log(Math.Pow(z, 2), Math.E) - Math.Sin((Math.PI * Math.Pow(x, 2)) / 4);
                    double Operation3 = Math.Pow(Operation1, 2) + Math.Pow(Operation2, 3);
                    double Operation4 = Math.Pow(Operation3, 0.3333333333333);
                    double k = Math.Round(Operation4, 4);
                    ResultWindow.Text = k.ToString();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            EnterX.Text = "";
            EnterY.Text = "";
            EnterZ.Text = "";
            ResultWindow.Text = "";
        }

        private void EnterX_TextChanged(object sender, EventArgs e)
        {
            if (EnterX.Text.Length != 0 && EnterY.Text.Length != 0 && EnterZ.Text.Length != 0)
            {
                ResultButton.Enabled = true;
            }
            else
            {
                ResultButton.Enabled = false;
            }
        }

        private void EnterX_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterY_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterZ_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterY_TextChanged(object sender, EventArgs e)
        {
            if (EnterX.Text.Length != 0&& EnterY.Text.Length != 0&& EnterZ.Text.Length != 0)
            {
                ResultButton.Enabled = true;
            }
            else
            {
                ResultButton.Enabled = false;
            }
        }

        private void EnterZ_TextChanged(object sender, EventArgs e)
        {
            if (EnterX.Text.Length != 0 && EnterY.Text.Length != 0 && EnterZ.Text.Length != 0)
            {
                ResultButton.Enabled = true;
            }
            else
            {
                ResultButton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
