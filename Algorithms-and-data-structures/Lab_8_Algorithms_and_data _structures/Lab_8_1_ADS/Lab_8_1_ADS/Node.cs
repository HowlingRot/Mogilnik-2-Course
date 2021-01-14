using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_1_ADS
{
    enum NodePosition
    {
        left,
        right,
        center
    }
    class Node
    {
        public int Value;

        public Node LeftNode;

        public Node RightNode;

        public Node Parent;

		public Node(int data)
		{
			Value = data;
		}

		public void PrintNode(string indent, NodePosition nodePosition, bool end_level, bool empty)
		{
			Console.Write(indent);
			if (end_level)
			{
				Console.Write("\u2514\u2500");
				indent += "  ";
			}
			else
			{
				Console.Write("\u251C\u2500");
				indent += "\u2502 ";
			}

			var stringValue = empty ? "-" : Value.ToString();
			PrintValue(stringValue, nodePosition);

			if (!empty && (LeftNode != null || RightNode != null))
			{
				if (LeftNode != null)
					LeftNode.PrintNode(indent, NodePosition.left, false, false);
				else
					PrintNode(indent, NodePosition.left, false, true);

				if (RightNode != null)
					RightNode.PrintNode(indent, NodePosition.right, true, false);
				else
					PrintNode(indent, NodePosition.right, true, true);
			}


		}
	
		private void PrintValue(string value, NodePosition nodePostion)
		{
			switch (nodePostion)
			{
				case NodePosition.left:
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.Write("L:");
					Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
					Console.WriteLine(value);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case NodePosition.right:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("R:");
					Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
					Console.WriteLine(value);
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case NodePosition.center:
					Console.WriteLine(value);
					break;
				default:
					throw new NotImplementedException();
			}
		}

	}
}
