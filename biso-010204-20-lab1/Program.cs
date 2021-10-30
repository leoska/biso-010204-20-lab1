using System;

namespace biso_010204_20_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Стэк на массиве с пузырьковой сортировкой
            // Стэк пишем в отдельном классе
            //Console.WriteLine("Hello World!");
            Stack stack = new Stack();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                stack.Push(rnd.Next(1, 100));
            stack.Print();




        }
    }
}
