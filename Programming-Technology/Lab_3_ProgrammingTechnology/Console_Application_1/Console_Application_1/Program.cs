using System;

namespace Console_Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool e = true;
            while (e)
            {

                String str;

                Console.Write("Введите строку: ");
                Console.Write("\n");
                str = Console.ReadLine();

                if (Proverka(str))
                {
                    if (str.Length % 2 == 0 && str.Length >= 10)
                    {
                        str=str.Replace(" ", "");
                    }
                    String NewStr = "";
                    string[] strs = str.Split('"');
                    
    
                    for (int i=0;i< strs.Length; i+=2)
                    {
                            Console.Write(i);
                            NewStr += strs[i];
                    }
                  
                    Console.WriteLine(NewStr);
                }

                Console.WriteLine("Выйти? y - yes, n - продолжить");
                String exit;
                exit = Console.ReadLine();
                if (exit == "y") break;
            }
        }

        static bool Proverka(string str)
        {
            if (str.Length >= 200)
            {
                Console.WriteLine("Строка больше 200");
                return false;
            }


            return true;
        }
    }
}
