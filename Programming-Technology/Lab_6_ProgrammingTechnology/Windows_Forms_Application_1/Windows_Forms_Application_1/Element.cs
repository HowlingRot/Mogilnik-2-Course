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

		public string FileFormat() => string.Format("{0} {1} {2} {3}", Name, Weight, Cost_Price, Price);

		public Element(string data) 
		{
			string[] splits = data.Split(' ');
			Name = splits[0];
			Weight = double.Parse(splits[1]);
			Cost_Price = int.Parse(splits[2]);
			Price = int.Parse(splits[3]);
		}

	}
}
