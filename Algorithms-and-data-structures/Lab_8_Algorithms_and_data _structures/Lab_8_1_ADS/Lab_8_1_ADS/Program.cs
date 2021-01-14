using System;

namespace Lab_8_1_ADS
{
    class Program
    {
        static void Main(string[] args)
        {
			BinarySearchTree Tree = new BinarySearchTree();
			Random random = new Random();
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Создаём случайное дерево...");
			for (int i = 0; i <15 ; i++)
			{
				Tree.Add(random.Next(-50, 150));	
			}
            bool check = false;
            Tree.PrintTree();        
            do
            {
                Console.WriteLine("Выберите действие с деревом:\n1 - добавить элемент\n2 - найти элемент по значению\n3 - удалить элемент\n4 - определить высоту\n5 - определить глубину\n6 - определить уровень\n7 - прямой обход дерева\n8 - обратный обход дерева\n9 - симметричный обход дерева\n10 - построить дерево\n11 - выход ");
            string p = Console.ReadLine();           
                switch (p)
                {
                case "1":
                    Console.WriteLine("Какой элемент добавить?");
                        Tree.Add(Convert.ToInt32(Console.ReadLine()));
                        check = false;
                    break;
                case "2":
                    Console.WriteLine("Какой элемент найти?");
                        Node node = Tree.Find(Convert.ToInt32(Console.ReadLine()));
                        if (node != null)
                        {
                            Console.WriteLine("Элемент существует");
                        }
                        else
                        {
                            Console.WriteLine("Элемент не существует");
                        }
                        check = false;
                    break;
                case "3":
                   Console.WriteLine("Какой элемент удалить?");
                        Console.WriteLine("правое(1) или левое(2) удаление?");
                        string s = Console.ReadLine();
                        if (s == "1")
                        {
                            Tree.Delete(Convert.ToInt32(Console.ReadLine()),true);
                        }
                        else if(s == "2")
                        {
                            Tree.Delete(Convert.ToInt32(Console.ReadLine()),false);
                        }                  
                        check = false;
                    break;
                case "4":
                        Console.WriteLine("У какого элемента найти высоту?");
                        Console.WriteLine(Tree.GetHeight(Convert.ToInt32(Console.ReadLine())));
                        check = false;
                    break;
                case "5":
                        Console.WriteLine("У какого элемента найти глубину?");
                        Console.WriteLine(Tree.GetDepth(Convert.ToInt32(Console.ReadLine())));
                        check = false;
                    break;
                case "6":
                        Console.WriteLine("У какого элемента найти уровень?");
                        Console.WriteLine(Tree.GetLevel(Convert.ToInt32(Console.ReadLine())));
                        check = false;
                    break;
                case "7":
                        Console.WriteLine("С какого элемента провести обход?");
                        Node F = Tree.Find(Convert.ToInt32(Console.ReadLine()));
                        Tree.TraversePreOrder(F);
                    check = false;
                    break;
                case "8":
                        Console.WriteLine("С какого элемента провести обход?");
                        Node FF = Tree.Find(Convert.ToInt32(Console.ReadLine()));
                        Tree.TraversePostOrder(FF);
                        check = false;
                    break;
                case "9":
                        Console.WriteLine("С какого элемента провести обход?");
                        Node FFF = Tree.Find(Convert.ToInt32(Console.ReadLine()));
                        Tree.TraverseInOrder(FFF);
                        check = false;
                    break;
                case "10":
                        Tree.PrintTree();
                    check = false;
                    break;
                    case "11":
                        check = true;
                        break;
                    default:
                    Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                    break;
                }
            }
            while (check == false);
        }
    }
}
