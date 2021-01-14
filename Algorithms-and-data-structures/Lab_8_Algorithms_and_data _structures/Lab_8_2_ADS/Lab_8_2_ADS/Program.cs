using System;

namespace Lab_8_2_ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree Tree1 = new BinarySearchTree();
            BinarySearchTree Tree2 = new BinarySearchTree();
            Console.WriteLine("Введите количество элементов в деревьях");
            int n = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите элементы первого дерева");
            int z1, z2;
            int f1=0, f2=0;
            for (int i = 0; i < n; i++)
            {
                z1 = (Convert.ToInt32(Console.ReadLine()));
                Tree1.Add(z1);          
                if (i == 0)
                {
                    f1 = z1;
                }
            }
            Console.WriteLine("Введите элементы второго дерева");
            for (int i = 0; i < n; i++)
            {
                z2 = (Convert.ToInt32(Console.ReadLine()));
                Tree2.Add(z2);
                if (i == 0)
                {
                    f2 = z2;
                }
            }
            
            Console.WriteLine("Первое дерево");
            Tree1.PrintTree();
            Console.WriteLine("Второе дерево");
            Tree2.PrintTree();
            
            Console.WriteLine("Правое удаление корней ");
            Tree1.Delete(Tree1.Find(f1).Value,true);
            Tree2.Delete(Tree2.Find(f2).Value,true);
            

            Console.WriteLine("Первое дерево");
            Tree1.PrintTree();
            Console.WriteLine("Второе дерево");
            Tree2.PrintTree();

            if (Mirror(Tree1.Root,Tree2.Root) == true)
            {
                Console.WriteLine("Деревья структурно зеркальны)");
            }
            else
            {
                Console.WriteLine("Деревья структурно не зеркальны(");
            }

            Console.WriteLine("Обходим деревья...");
            Console.WriteLine("Обходим первое дерево");          
            Tree1.TraversePreOrder(Tree1.Root);
            Console.WriteLine();
            Console.WriteLine("Обходим второе дерево");
            Tree2.TraversePreOrder(Tree2.Root);

        }

        static bool Mirror(Node T1, Node T2)
        {
            if (T1 == null && T2 == null)
            {
                return true;
            }
            if ((T1.RightNode !=null && T2.LeftNode == null)|| (T1.RightNode == null && T2.LeftNode != null) || (T1.LeftNode != null && T2.RightNode == null) || (T1.LeftNode == null && T2.RightNode != null))
            {
                return false;
            }
            else if(Mirror(T1.RightNode, T2.LeftNode) ==false) {
                return false;
            }
            else if (Mirror(T1.LeftNode, T2.RightNode) == false)
            {
                return false;
            }
            return true;
        }

    }
}
