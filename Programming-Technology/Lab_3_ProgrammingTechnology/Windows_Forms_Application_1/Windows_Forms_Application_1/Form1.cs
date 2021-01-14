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
            Button_Result.Enabled = false;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (Enter_Text.TextLength >= 200)
            {
                MessageBox.Show("Длина строки превышает 200 символов.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Button_Result.Enabled = false;
            }

            else
            {

                String str = Enter_Text.Text;
                if (str.Length % 2 == 0 && str.Length >= 10)
                {
                    str = str.Replace(" ", "");
                }
                String NewStr = "";
                string[] strs = str.Split('"');


                for (int i = 0; i < strs.Length; i += 2)
                {
                    Console.Write(i);
                    NewStr += strs[i];
                }

                Result_Text.Text = NewStr;
            }
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            Result_Text.Text = "";
            Enter_Text.Text = "";
            Button_Result.Enabled = false;
        }

        private void Enter_Text_Changed(object sender, EventArgs e)
        {
            if (Enter_Text.Text != "")
            {
                Button_Result.Enabled = true;
            }
            if (Enter_Text.Text == "")
            {
                Button_Result.Enabled = false;
            }
        }
    }
}
