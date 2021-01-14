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
            Result_Button.Enabled = false;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double x0 = 0;
            double xn = 0;
            double dx = 0;
            double b = 0;
            double a = 0;

            try
            {
                if (Enter_X0.Text == "" || Enter_Xn.Text == "" || Enter_dx.Text == "" || Enter_b.Text == "" || Enter_a.Text == "")
                {
                    MessageBox.Show("Введите все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x0 = double.Parse(Enter_X0.Text);
                    xn = double.Parse(Enter_Xn.Text);
                    dx = double.Parse(Enter_dx.Text);
                    b = double.Parse(Enter_b.Text);
                    a = double.Parse(Enter_a.Text);
                    if (CheckInterval(x0, xn, dx) == true)
                    {
                        while (x0 <= xn)
                        {

                            double Operation1 = Math.Pow(x0, 3) + Math.Pow(b, 3);
                            double Operation2 = Math.Pow(Operation1, 7 / 6);
                            double Operation3 = a * Operation2;
                            Text_Box_Result.Text += x0.ToString() + "\t" + Operation3.ToString() + Environment.NewLine;
                            x0 = x0 + dx;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректный ввод, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Enter_X0.Text = "";
            Enter_Xn.Text = "";
            Enter_dx.Text = "";
            Enter_b.Text = "";
            Enter_a.Text = "";
            Text_Box_Result.Text = "";
        }

        static bool CheckInterval(double x0, double xn, double dx)
        {
            if (x0 <= xn && dx > 0)
                return true;
            if (x0 >= xn && dx < 0)
                return true;
            return false;
        }

        private void EnterX0_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterXn_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterdX_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterB_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterA_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        private void EnterX0_TextChanged(object sender, EventArgs e)
        {
            if (Enter_X0.Text.Length != 0 && Enter_Xn.Text.Length != 0 && Enter_dx.Text.Length != 0 && Enter_b.Text.Length != 0 && Enter_a.Text.Length != 0)
            {
                Result_Button.Enabled = true;
            }
            else
            {
                Result_Button.Enabled = false;
            }
        }

        private void EnterXn_TextChanged(object sender, EventArgs e)
        {
            if (Enter_X0.Text.Length != 0 && Enter_Xn.Text.Length != 0 && Enter_dx.Text.Length != 0 && Enter_b.Text.Length != 0 && Enter_a.Text.Length != 0)
            {
                Result_Button.Enabled = true;
            }
            else
            {
                Result_Button.Enabled = false;
            }
        }

        private void EnterDX_TextChanged(object sender, EventArgs e)
        {
            if (Enter_X0.Text.Length != 0 && Enter_Xn.Text.Length != 0 && Enter_dx.Text.Length != 0 && Enter_b.Text.Length != 0 && Enter_a.Text.Length != 0)
            {
                Result_Button.Enabled = true;
            }
            else
            {
                Result_Button.Enabled = false;
            }
        }

        private void EnterB_TextChanged(object sender, EventArgs e)
        {
            if (Enter_X0.Text.Length != 0 && Enter_Xn.Text.Length != 0 && Enter_dx.Text.Length != 0 && Enter_b.Text.Length != 0 && Enter_a.Text.Length != 0)
            {
                Result_Button.Enabled = true;
            }
            else
            {
                Result_Button.Enabled = false;
            }
        }

        private void EnterA_TextChanged(object sender, EventArgs e)
        {
            if (Enter_X0.Text.Length != 0 && Enter_Xn.Text.Length != 0 && Enter_dx.Text.Length != 0 && Enter_b.Text.Length != 0 && Enter_a.Text.Length != 0)
            {
                Result_Button.Enabled = true;
            }
            else
            {
                Result_Button.Enabled = false;
            }
        }
    }
}
