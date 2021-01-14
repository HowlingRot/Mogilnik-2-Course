using System;
using System.Windows.Forms;

namespace Windows_Forms_Application_1
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            Change_Button.Enabled = false;
            Delete_Button.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 NewElementWindow = new Form2();
            NewElementWindow.Text = "Добавление элемента";
            if (NewElementWindow.ShowDialog() == DialogResult.OK)
            {           
                Element NewElement  = new Element(NewElementWindow.DishName.Text.Trim(), double.Parse(NewElementWindow.DishWeight.Text),int.Parse(NewElementWindow.DishCostPrice.Text), int.Parse(NewElementWindow.DishPrice.Text));
                Entries.Items.Add(NewElement);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Form2 OldElementWindow = new Form2();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            Entries.Items.RemoveAt(Entries.SelectedIndex);
        }

        private void Entries_Selected_Value_Changed(object sender, EventArgs e)
        {
            Change_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
            Delete_Button.Enabled = Entries.Items.Count != 0 && Entries.SelectedItem != null;
        }
    }
}
