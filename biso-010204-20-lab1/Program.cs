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

            for (int i = stack.Count() - 1; i > 0; --i) {
                bool flag = false;

                for (int j = 0; j < i; j++)
                {
                    if (stack.Get(j) > stack.Get(j + 1))
                    {
                        int tmp = stack.Get(j);
                        stack.Set(j, stack.Get(j + 1));
                        stack.Set(j + 1, tmp);
                        flag = true;

                    }
                }
                if (!flag)
                    break;
            }
            stack.Print();

        }

    }
}
