using System;
using System.Collections.Generic;
using System.Text;

namespace biso_010204_20_lab1
{
    class Stack
    {
        private List<int> stack = new List<int>();
        public void Push(int value)
        {
            stack.Add(value);
        }
        public int Pop()
        {
            int result = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return result;
        }

        public int Count()
        {
            return stack.Count;
        }

        public int Get(int pos)
        {
            Stack tmp = new Stack();
            for (int i = Count() - 1; i > pos; i--)
                tmp.Push(Pop());
            int result = stack[Count() - 1];
            for (int i = tmp.Count() - 1; i >= 0; i--)
                Push(tmp.Pop());

            return result;
        }

        public void Set(int pos, int value)
        {
            Stack tmp = new Stack();
            for (int i = Count() - 1; i > pos; i--)
                tmp.Push(Pop());
            stack[Count() - 1] = value;
            for (int i = tmp.Count() - 1; i >= 0; i--)
                Push(tmp.Pop());
        }

        public void Print()
        {
            foreach (int i in stack)
                Console.WriteLine(i);
            Console.WriteLine("________");
        }
    }
}
