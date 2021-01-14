using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Windows_Forms_Application_1
{
    public partial class Form_Menu : Form
    {

        SaveFileDialog Save_File = new SaveFileDialog();
        OpenFileDialog Download_File = new OpenFileDialog();

        public Form_Menu()
        {
            InitializeComponent();
            Delete_Button.Enabled = false;
            Save_Button.Enabled = false;
            Calculation_Button.Enabled = false;
            Change_Button.Enabled = false;

            Change_Button_Menu.Enabled = false;
            Delete_Button_Menu.Enabled = false;
            Save_Button_Menu.Enabled = false;
            Calculation_Button_Menu.Enabled = false;

            Change_Strip__Button.Enabled = false;
            Delete_Strip__Button.Enabled = false;
            Save_Strip__Button.Enabled = false;
            Calculation_Strip__Button.Enabled = false;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Dish_Description NewElementWindow = new Dish_Description();
            NewElementWindow.Text = "Добавление элемента";
            if (NewElementWindow.ShowDialog() == DialogResult.OK)
            {
                Element NewElement = new Element(NewElementWindow.DishName.Text.Trim(), double.Parse(NewElementWindow.DishWeight.Text), int.Parse(NewElementWindow.DishCostPrice.Text), int.Parse(NewElementWindow.DishPrice.Text));
                Entries.Items.Add(NewElement);
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Dish_Description OldElementWindow = new Dish_Description();
            OldElementWindow.Text = "Изменение элемента";
            Element OldElement = Entries.SelectedItem as Element;

            OldElementWindow.DishName.Text = OldElement.Name;
            OldElementWindow.DishWeight.Text = OldElement.Weight.ToString();
            OldElementWindow.DishCostPrice.Text = OldElement.Cost_Price.ToString();
            OldElementWindow.DishPrice.Text = OldElement.Price.ToString();

            if (OldElementWindow.ShowDialog() == DialogResult.OK)
            {
                OldElement.Name = OldElementWindow.DishName.Text;
                OldElement.Weight = double.Parse(OldElementWindow.DishWeight.Text);
                OldElement.Cost_Price = int.Parse(OldElementWindow.DishCostPrice.Text);
                OldElement.Price = int.Parse(OldElementWindow.DishPrice.Text);
                Entries.Items[Entries.SelectedIndex] = OldElement;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Entries.Items.RemoveAt(Entries.SelectedIndex);
        }

        private void Download_Button_Click(object sender, EventArgs e)
        {
            Download_File.FileName = "";
            if (Download_File.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(File.Open(Download_File.FileName, FileMode.Open)))
                {
                    string check = sr.ReadLine();                  
                    Entries.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        Entries.Items.Add(new Element(sr.ReadLine()));
                    }
                    
                }
            }
          
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Save_File.FileName = "DataFile";         
            if (Save_File.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(File.Open(Save_File.FileName, FileMode.Create)))
                {                 
                    foreach (var unit in Entries.Items)
                    {
                        Element dude = unit as Element;
                        sw.WriteLine(dude.FileFormat());
                    }
                }                                          
            }         
        }

        private void Calculation_Button_Click(object sender, EventArgs e)
        {
            Max_Price.Text = "";
            Element Max_Profit=new Element("",0,0,0);
            double profit1 = 0;
            double profit2 = 0;
            Element[] Mass = new Element[Entries.Items.Count];
            if (Mass.Length == 1)
            {
                Mass[0] = Entries.Items[0] as Element;
                Max_Price.Text = $"{Mass[0].Name} {Mass[0].Weight} {Mass[0].Price - Mass[0].Cost_Price}";
            }
            else if (Mass.Length>1)
            {
                for (int i = 0; i < Mass.Length - 1; i++)
                {
                    Mass[i] = Entries.Items[i] as Element;
                    Mass[i + 1] = Entries.Items[i + 1] as Element;
                    profit1 = Mass[i].Price - Mass[i].Cost_Price;
                    profit2 = Mass[i + 1].Price - Mass[i + 1].Cost_Price;
                    if (profit1 < profit2)
                    {
                        Max_Profit.Name = Mass[i + 1].Name;
                        Max_Profit.Weight = Mass[i + 1].Weight;
                    }
                }
                Max_Price.Text = $"{Max_Profit.Name} {Max_Profit.Weight} {profit1}";
            }
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Change_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Delete_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
        }

        private void Entries_Change(object sender, EventArgs e)
        {           
            Delete_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Change_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;          
            Save_Button.Enabled = Entries.Items.Count != 0;
            Calculation_Button.Enabled = Entries.Items.Count != 0;

            Change_Button_Menu.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Delete_Button_Menu.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Save_Button_Menu.Enabled = Entries.Items.Count != 0;
            Calculation_Button_Menu.Enabled = Entries.Items.Count != 0;


            Change_Strip__Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Delete_Strip__Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Save_Strip__Button.Enabled = Entries.Items.Count != 0;
            Calculation_Strip__Button.Enabled = Entries.Items.Count != 0;

            if (Change_Button.Enabled)
            {
                Element selected = Entries.SelectedItem as Element;
                Strip_Name.Text = selected.Name;
                Strip_Weight.Text = selected.Weight.ToString();
                Strip_Cost_Price.Text = selected.Cost_Price.ToString();
                Strip_Price.Text = selected.Price.ToString();
            }
            else
            {
                Strip_Name.Text = "...";
                Strip_Weight.Text = "...";
                Strip_Cost_Price.Text = "...";
                Strip_Price.Text = "...";
            }
        }

        private void Add_Button_Menu_Click(object sender, EventArgs e)
        {
            Add_Button_Click(sender, e);
        }

        private void Change_Button_Menu_Click(object sender, EventArgs e)
        {
            Change_Button_Click(sender, e);
        }

        private void Delete_Button_Menu_Click(object sender, EventArgs e)
        {
            Delete_Button_Click(sender, e);
        }

        private void Download_Button_Menu_Click(object sender, EventArgs e)
        {
            Download_Button_Click(sender, e);
        }

        private void Save_Button_Menu_Click(object sender, EventArgs e)
        {
            Save_Button_Click(sender, e);
        }

        private void Calculation_Button_Menu_Click(object sender, EventArgs e)
        {
            Calculation_Button_Click(sender, e);
        }

        private void Menu_Click_Add(object sender, EventArgs e)
        {
            Add_Button_Click(sender, e);
        }

        private void Menu_Click_Change(object sender, EventArgs e)
        {
            Change_Button_Click(sender, e);
        }

        private void Menu_Click_Delete(object sender, EventArgs e)
        {
            Delete_Button_Click(sender, e);
        }

        private void Menu_Click_Save(object sender, EventArgs e)
        {
            Save_Button_Click(sender, e);
        }

        private void Menu_Click_Download(object sender, EventArgs e)
        {
            Download_Button_Click(sender, e);
        }

        private void Button_Click_Calculation(object sender, EventArgs e)
        {
            Calculation_Button_Click(sender, e);
        }
    }
}
