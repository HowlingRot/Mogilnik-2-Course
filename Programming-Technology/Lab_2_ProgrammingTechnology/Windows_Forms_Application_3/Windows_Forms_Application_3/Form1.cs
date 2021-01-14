using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Input();
            Button_Clear.Enabled = false;
            Button_Replace.Enabled = false;
        }

        private void Input()
        {
            dataGridView.ColumnCount = 10;
            dataGridView.RowCount = 10;
            for (int i = 0; i < 10; i++)
                dataGridView.Columns[i].Width = 47;
        }

        private void ClearInput()
        {
            dataGridView.Rows.Clear();
            dataGridViewPlus.Rows.Clear();
            Input();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            ClearInput();
            Random rand = new Random();
            Button_Replace.Enabled = true;
            Button_Clear.Enabled = true;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    dataGridView.Rows[i].Cells[j].Value = rand.Next(-100, 100);
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            dataGridViewPlus.ColumnCount = 1;
            dataGridViewPlus.RowCount = 10;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if ((int)dataGridView.Rows[i].Cells[j].Value > 0)
                        count++;
                dataGridViewPlus.Rows[i].Cells[0].Value = count;
                count = 0;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearInput();
            Button_Replace.Enabled = false;
            Button_Clear.Enabled = false;
        }
    }
}
