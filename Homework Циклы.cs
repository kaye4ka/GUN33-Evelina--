using System;
        
class Program
    {
        static void Main()
        {
            //Fibonachy
            int n = 10;
            int a = 0;
            int b = 1;
        
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < n; i++)
            {
                    int c = a + b;
                    Console.WriteLine(c);
                    a = b;
                    b = c;
            }
        }
    }

class Program
{
    static void Main()
    {
        for (int i = 2; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}


class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(i * j + "\t");
            }
            Console.WriteLine();
        }
    }
}


class Program
{
    static void Main()
    {
        string password = "qwerty";
        string input;
        do
        {
            Console.WriteLine("Введите пароль: ");
            input = Console.ReadLine();

            if (input != password)
            {
                Console.WriteLine("Неверный пароль, попробуйте еще раз. ");
            }
        } while (input != password);
        Console.WriteLine("Пароль верный. Доступ разрешен.");
    }
}

    