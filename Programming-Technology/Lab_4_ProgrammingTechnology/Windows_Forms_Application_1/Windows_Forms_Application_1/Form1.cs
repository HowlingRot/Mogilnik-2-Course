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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool Proverka(string str, string pole)
        {

            int count = 0;
            if (str[0] == ',' || str[str.Length - 1] == ',')
            {
                MessageBox.Show("Ошибка при вводе запятых в " + pole, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    count++;
                }
            }

            if (count > 1)
            {
                MessageBox.Show("Слишком много запятых в одном поле в " + pole, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-')
                {
                    count++;
                }
            }

            if (count > 1)
            {
                MessageBox.Show("Вы ввели лишний минус в " + pole, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        bool Proverka2(double xo, double xn, double dx)
        {

            if (xn > xo && dx > 0) return true;
            return false;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string str_x0, str_xn, str_dx, str_a, str_b;
            if (Enter_X0.TextLength == 0 || Enter_Xn.TextLength == 0 || Enter_dX.TextLength == 0 || Enter_b.TextLength == 0 || Enter_a.TextLength == 0)
            {
                MessageBox.Show("Введите значения в пустые поля", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Button_Result.Enabled = false;
                return;
            }
            else
            {
                str_x0 = Enter_X0.Text;
                str_xn = Enter_Xn.Text;
                str_dx = Enter_dX.Text;
                str_a = Enter_b.Text;
                str_b = Enter_a.Text;

                if (Proverka(str_x0, "Xo"))
                {
                    if (Proverka(str_xn, "Xn"))
                    {
                        if (Proverka(str_dx, "dX"))
                        {
                            if (Proverka(str_a, "a"))
                            {
                                if (Proverka(str_b, "b"))
                                {
                             
                                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                                    chart1.Series[0].LegendText = "f(x)";
                                    if (double.Parse(Enter_X0.Text) >= double.Parse(Enter_Xn.Text))
                                    {
                                        MessageBox.Show("Ошибка x0 >= xN!");
                                        Enter_X0.Text = "";
                                        Enter_Xn.Text = "";
                                    }
                                    else
                                    {
                                        double x0 = double.Parse(Enter_X0.Text);

                                        double xn = double.Parse(Enter_Xn.Text);

                                        double dx = double.Parse(Enter_dX.Text);

                                        double a = double.Parse(Enter_b.Text);

                                        double b = double.Parse(Enter_a.Text);

                                        int size = Convert.ToInt32((xn - x0) / dx) + 1;

                                        double[] arrY = new double[size];
                                        double[] arrX = new double[size];

                                        int i = 0;
                                        for (double x = x0; x <= xn; x += dx, i++)
                                        {
                                            arrX[i] = x;
                                            double Operation1 = Math.Pow(x0, 3) + Math.Pow(b, 3);
                                            double Operation2 = Math.Pow(Operation1, 1.66666);
                                            double Operation3 = a * Operation2;
                                            arrY[i] = Operation3;
                                        }

                                        chart1.ChartAreas[0].AxisX.Minimum = x0;
                                        chart1.ChartAreas[0].AxisX.Maximum = xn;
                                        chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
                                        chart1.Series[0].Points.DataBindXY(arrX, arrY);
                                    }
                                }
                                else Button_Result.Enabled = false;
                            }
                            else Button_Result.Enabled = false;
                        }
                        else Button_Result.Enabled = false;
                    }
                    else Button_Result.Enabled = false;
                }
                else Button_Result.Enabled = false;



            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Enter_X0.Text = "";
            Enter_Xn.Text = "";
            Enter_dX.Text = "";
            Enter_b.Text = "";
            Enter_a.Text = "";
            Button_Result.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void X0_Changed(object sender, EventArgs e)
        {
            if (Enter_X0.TextLength > 0) Button_Result.Enabled = true;
            else Button_Result.Enabled = false;
        }

        private void Xn_Changed(object sender, EventArgs e)
        {
            if (Enter_Xn.TextLength > 0) Button_Result.Enabled = true;
            else Button_Result.Enabled = false;
        }

        private void dX_Changed(object sender, EventArgs e)
        {
            if (Enter_dX.TextLength > 0) Button_Result.Enabled = true;
            else Button_Result.Enabled = false;
        }

        private void b_Changed(object sender, EventArgs e)
        {
            if (Enter_b.TextLength > 0) Button_Result.Enabled = true;
            else Button_Result.Enabled = false;
        }

        private void a_Changed(object sender, EventArgs e)
        {
            if (Enter_a.TextLength > 0) Button_Result.Enabled = true;
            else Button_Result.Enabled = false;
        }
    }
}
