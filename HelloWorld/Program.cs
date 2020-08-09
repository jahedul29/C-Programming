using System;

namespace HelloWorld
{
    using System.Dynamic;

    class Program
    {
        static void Main(string[] args)
        {
            string lang = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            double point = Convert.ToDouble(Console.ReadLine());
            bool flag = Convert.ToBoolean(Console.ReadLine());
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(lang);
            Console.WriteLine(num);
            Console.WriteLine(point);
            Console.WriteLine(flag);
            Console.WriteLine(ch);
            Console.ReadLine();
        }
    }
}
