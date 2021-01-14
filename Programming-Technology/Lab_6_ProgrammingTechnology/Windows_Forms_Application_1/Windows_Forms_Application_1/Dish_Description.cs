using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Windows_Forms_Application_1
{
    public partial class Dish_Description : Form
    {
        public TextBox DishName;
        public TextBox DishWeight;
        public TextBox DishCostPrice;
        public TextBox DishPrice;

        public Dish_Description()
        {
            InitializeComponent();
            DishName = Enter_Name;
            DishWeight = Enter_Weight;
            DishCostPrice = Enter_Cost_Price;
            DishPrice = Enter_Price;
            Cancel_Button.Enabled = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Name_Changed(object sender, EventArgs e)
        {
            if (Enter_Name.Text.Length != 0 && Enter_Weight.Text.Length != 0 && Enter_Cost_Price.Text.Length != 0 && Enter_Price.Text.Length != 0
             && Convert.ToDouble(Enter_Weight.Text) >= 0.1 && Convert.ToDouble(Enter_Weight.Text) <= 3.0
              && Convert.ToInt32(Enter_Cost_Price.Text) >= 1 && Convert.ToInt32(Enter_Cost_Price.Text) <= 5000
               && Convert.ToInt32(Enter_Price.Text) >= 1 && Convert.ToInt32(Enter_Price.Text) <= 10000
                && Convert.ToInt32(Enter_Price.Text) > Convert.ToInt32(Enter_Cost_Price.Text)
                && String.IsNullOrWhiteSpace(Enter_Name.Text) != true)
            {
                OK_Button.Enabled = true;
            }
            else
            {
                OK_Button.Enabled = false;
            }
        }

        private void Weight_Changed(object sender, EventArgs e)
        {
            if (Enter_Name.Text.Length != 0 && Enter_Weight.Text.Length != 0 && Enter_Cost_Price.Text.Length != 0 && Enter_Price.Text.Length != 0
                && Convert.ToDouble(Enter_Weight.Text) >= 0.1 && Convert.ToDouble(Enter_Weight.Text) <= 3.0
                 && Convert.ToInt32(Enter_Cost_Price.Text) >= 1 && Convert.ToInt32(Enter_Cost_Price.Text) <= 5000
                  && Convert.ToInt32(Enter_Price.Text) >= 1 && Convert.ToInt32(Enter_Price.Text) <= 10000
                   && Convert.ToInt32(Enter_Price.Text) > Convert.ToInt32(Enter_Cost_Price.Text)
                    && String.IsNullOrWhiteSpace(Enter_Name.Text) != true)
            {
                OK_Button.Enabled = true;
            }
            else
            {
                OK_Button.Enabled = false;
            }
        }

        private void Cost_Price_Changed(object sender, EventArgs e)
        {
            if (Enter_Name.Text.Length != 0 && Enter_Weight.Text.Length != 0 && Enter_Cost_Price.Text.Length != 0 && Enter_Price.Text.Length != 0
               && Convert.ToDouble(Enter_Weight.Text) >= 0.1 && Convert.ToDouble(Enter_Weight.Text) <= 3.0
                && Convert.ToInt32(Enter_Cost_Price.Text) >= 1 && Convert.ToInt32(Enter_Cost_Price.Text) <= 5000
                 && Convert.ToInt32(Enter_Price.Text) >= 1 && Convert.ToInt32(Enter_Price.Text) <= 10000
                  && Convert.ToInt32(Enter_Price.Text) > Convert.ToInt32(Enter_Cost_Price.Text)
                   && String.IsNullOrWhiteSpace(Enter_Name.Text) != true)
            {
                OK_Button.Enabled = true;
            }
            else
            {
                OK_Button.Enabled = false;
            }
        }

        private void Price_Changed(object sender, EventArgs e)
        {
            if (Enter_Name.Text.Length != 0 && Enter_Weight.Text.Length != 0 && Enter_Cost_Price.Text.Length != 0 && Enter_Price.Text.Length != 0
                && Convert.ToDouble(Enter_Weight.Text) >= 0.1 && Convert.ToDouble(Enter_Weight.Text) <= 3.0
                && Convert.ToInt32(Enter_Cost_Price.Text) >= 1 && Convert.ToInt32(Enter_Cost_Price.Text) <= 5000
                 && Convert.ToInt32(Enter_Price.Text) >= 1 && Convert.ToInt32(Enter_Price.Text) <= 10000
                 && Convert.ToInt32(Enter_Price.Text) > Convert.ToInt32(Enter_Cost_Price.Text)
                  && String.IsNullOrWhiteSpace(Enter_Name.Text) != true)
            {
                OK_Button.Enabled = true;
            }
            else
            {
                OK_Button.Enabled = false;
            }
        }

        private void Weight_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Cost_Price_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Price_Press(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
