using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_1_ADS
{
    enum NodePosition
    {
        child,
        sibling,
        head
    }
    class Node
    {
        public int key;
        public int degree;
        public Node parent;
        public Node child;
        public Node sibling;

        public Node()
        {
            parent = null;
            child = null;
            sibling = null;
        }

        public Node(int Key)
        {
            key = Key;
        }

        private void PrintValue(string value, NodePosition nodePosition)
        {
            switch (nodePosition)
            {
                case NodePosition.child:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Ch:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(value);
                    break;
                case NodePosition.sibling:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Sib:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(value);
                    break;
                case NodePosition.head:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("H:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(value);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public string Print(string indent, NodePosition nodePosition, bool end_level, bool empty)
        {
            if (parent == null)
                nodePosition = NodePosition.head;
            Console.Write(indent);

            if (end_level)
            {
                Console.Write("└─");
                indent += " ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            var stringValue = empty ? "-" : key.ToString();
            PrintValue(stringValue, nodePosition);

            if (!empty && (child != null || sibling != null))
            {

                if (child != null)
                {
                    if (sibling == null && parent == null)
                        indent += " ";

                    if (child.sibling != null)
                        indent = child.Print(indent, NodePosition.child, false, false);
                    else indent = child.Print(indent, NodePosition.child, true, false);
                }

                if (sibling != null)
                {

                    if (parent == null)
                        indent = "";

                    if (sibling.sibling != null)
                        indent = sibling.Print(indent, NodePosition.sibling, false, false);
                    else indent = sibling.Print(indent, NodePosition.sibling, true, false);
                }
            }
            else
            {
                indent = indent.TrimEnd(new Char[] { ' ' });
                indent = indent.TrimEnd(new Char[] { '|' });
            }
            return indent;
        }

    }
}
