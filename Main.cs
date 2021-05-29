using System;
namespace c__data_structures
{
    public class Main
    {
        public Main()
        {
            StackMap<int, string> map = new StackMap<int, string>();

            map.Push(1, "one");
            map.Push(2, "two");
            map.Push(3, "three");
            map.Push(4, "four");
            map.Push(5, "five");
            Console.WriteLine(map.Peek());


            while (!map.IsEmpty())
            {
                Console.WriteLine(map.Pop());
                Console.WriteLine(map.Count());
            }

        }
    }
}
