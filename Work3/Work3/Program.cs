using System;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WhatNameAge();
            }
        }
        static void WhatNameAge()
        {
            Console.WriteLine("");
            Console.WriteLine("Введите имя: ");
            Children.name = Console.ReadLine();
            Console.WriteLine("Введите кол-во лет: ");
            Children.age = Convert.ToInt32(Console.ReadLine());
            WhichClass wc = new WhichClass();
        }
    }
}
