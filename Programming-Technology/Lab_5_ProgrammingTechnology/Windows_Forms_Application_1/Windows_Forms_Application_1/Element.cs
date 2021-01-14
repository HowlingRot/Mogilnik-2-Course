using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Application_1
{
    class Element
    {
		public string Name;
		public double Weight;
		public int Cost_Price;
		public int Price; 

		public Element(string name, double weight, int cost_price, int price)
		{
			Name = name;
			Weight = weight;
			Cost_Price = cost_price;
			Price = price;
		}

		override public string ToString()
		{
			return Name;
			
		}

	}
}
