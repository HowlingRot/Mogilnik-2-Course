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
            Button_Create_Array.Enabled = false;
            Button_Array_Function.Enabled = false;
            Button_Array_Sort.Enabled = false;
            Button_Array_Change.Enabled = false;
            Button_Clear.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Array_Create_Click(object sender, EventArgs e)
        {
            ListBox_Array.Items.Clear();
            ListBox_Formula.Items.Clear();
            ListBox_Change.Items.Clear();
            Button_Array_Sort.Enabled = false;
            Button_Array_Change.Enabled = false;
            try
            {
                int n = int.Parse(Array_Number.Text);
                int[] ArrayX = new int[n];
                if (n == 0)
                {
                    Button_Array_Function.Enabled = false;
                    MessageBox.Show("Массив не может быть длинной 0 элементов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Random rand = new Random();

                    for (int i = 0; i < n; i++)
                    {
                        ArrayX[i] = rand.Next(-20, 20);
                        ListBox_Array.Items.Add(ArrayX[i]);
                    }
                    changeSign();
                    Button_Array_Function.Enabled = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeSign()
        {
            int n = ListBox_Array.Items.Count;
            int[] ArrayX = new int[n];

            for (int i = 0; i < n; i++)
            {
                ArrayX[i] = Convert.ToInt32(ListBox_Array.Items[i]);
            }

            bool check = true;

            Random rand = new Random();

            while (check)
            {
                for (int i = 0; i < n; i++)
                {
                    int plus = 0;
                    int minus = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (ArrayX[j] > 0)
                        {
                            plus++;
                        }
                        else if (ArrayX[j] < 0)
                        {
                            minus++;
                        }
                    }
                    if (Math.Abs(plus - minus) > 1)
                    {
                        int element = rand.Next(-1, 1);
                        if (element == 0)
                        {
                            element = 1;
                        }

                        ArrayX[i] = ArrayX[i] * element;
                    }
                    else if (Math.Abs(plus - minus) <= 1)
                    {
                        check = false;
                    }

                }
                ListBox_Array.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    ListBox_Array.Items.Add(ArrayX[i]);
                }
            }

        }

        private void Array_Function_Click(object sender, EventArgs e)
        {
            ListBox_Formula.Items.Clear();
            int n = int.Parse(Array_Number.Text);
            int[] ArrayX = new int[n];

            double a = 0.8;
            double b = 6.74;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                ArrayX[i] = Convert.ToInt32(ListBox_Array.Items[i]);
            }

            for (int i = 0; i < n; i++)
            {              
                double Operation1 = Math.Pow(ArrayX[i], 3) + Math.Pow(b, 3);
                double Operation2 = Math.Pow(Operation1, 1.6666);
                double Operation3 = a * Operation2;
                k = (int)(Operation3);
                ListBox_Formula.Items.Add(k);
            }
            Button_Array_Sort.Enabled = true;
            Button_Array_Change.Enabled = true;
        }
        
        int count_of_sort = 0;
        private void Array_Sort_Click(object sender, EventArgs e)
        {
            count_of_sort++;
            int num = ListBox_Formula.Items.Count;
            int[] arrY = new int[num];
            for (int i = 0; i < num; i++)
            {
                arrY[i] = Convert.ToInt32(ListBox_Formula.Items[i]);
            }

            if (count_of_sort % 2 == 1)
            {
                Array.Sort(arrY);
                ListBox_Formula.Items.Clear();
            }
            else if (count_of_sort % 2 == 0)
            {
                Array.Reverse(arrY);
                ListBox_Formula.Items.Clear();
            }
            ListBox_Formula.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                ListBox_Formula.Items.Add(arrY[i]);
            }

            
        }

        private void Array_Change_Click(object sender, EventArgs e)
        {
            ListBox_Change.Items.Clear();
            double a = Convert.ToDouble(Yi.Text);
            double b = Convert.ToDouble(Y0.Text);
            int num = ListBox_Formula.Items.Count;
            double[] arrY = new double[num];
            double R = 0;
            for (int i = 0; i < num; i++)
            {
                arrY[i] = Convert.ToInt32(ListBox_Formula.Items[i]);
                if(arrY[i]>=a&& arrY[i]<=b)
                    R += arrY[i];
            }
            if (R == 0)
            {
                ListBox_Change.Items.Add(0);
            }
            else
            {
                R = Math.Pow(R, 1 / num);
                ListBox_Change.Items.Add(R);
            }
           
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Yi.Text = "";
            Y0.Text = "";
            Array_Number.Text = "";
            ListBox_Array.Items.Clear();
            ListBox_Formula.Items.Clear();
            ListBox_Change.Items.Clear();
        }

        private void Array_Number_Changed(object sender, EventArgs e)
        {
          
            if (Array_Number.Text.Length != 0)
            {
                Button_Create_Array.Enabled = true;
                Button_Clear.Enabled = true;
            }
            else
            {
                Button_Create_Array.Enabled = false;
                Button_Array_Function.Enabled = false;
                Button_Array_Sort.Enabled = false;
                Button_Array_Change.Enabled = false;
                Button_Clear.Enabled = false;
            }
        }
    }
}
