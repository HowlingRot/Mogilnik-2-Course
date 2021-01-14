using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResultButton.Enabled = false;
        }

        private static int n = 1;
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
                else if (EnterX.Text == "0")
                {
                    MessageBox.Show("Х не должен быть равен нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x = double.Parse(EnterX.Text);
                    y = double.Parse(EnterY.Text);
                    z = double.Parse(EnterZ.Text);
                    double k = MyFunction(x, y, z);
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

        private void Radio_Button_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                n = 1;
            if (radioButton2.Checked)
                n = 2;
            if (radioButton3.Checked)
                n = 3;
            ResultWindow.Text = "";
        }

        private void Radio_Button_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                n = 1;
            if (radioButton2.Checked)
                n = 2;
            if (radioButton3.Checked)
                n = 3;
            ResultWindow.Text = "";
        }

        private void Radio_Button_3(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                n = 1;
            if (radioButton2.Checked)
                n = 2;
            if (radioButton3.Checked)
                n = 3;
            ResultWindow.Text = "";
        }

        static double MyFunction(double x, double y, double z)
        {
            double Operation1 = 0;
            switch (n)
            {
                case 1:
                    Operation1 = (Math.Exp(x) - Math.Exp(-x)) / 2;
                    break;
                case 2:
                    Operation1 = Math.Pow(x, 2);
                    break;
                case 3:
                    Operation1 = Math.Pow(Math.E, x);
                    break;
            }

            double Operation2 = (y + z) / x;

            double Operation3 = x * y * z;

            double Operation4 = Math.Max(Operation1 - Operation2, Operation3);

            double Operation5 = Math.Min(Operation1 - Operation2, Operation3);

            double u = Operation4 / Operation5;

            return u;
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

        private void EnterY_TextChanged(object sender, EventArgs e)
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
    }
}
