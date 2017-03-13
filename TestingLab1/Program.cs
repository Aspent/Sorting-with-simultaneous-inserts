using System;

namespace TestingLab1
{
    class Program
    {
        static void Main()
        {
            var sort = new SimultaneousInsertionSort<Data>(4);
            var count = 10;
            var seq = new DataArrayGenerator().Generate(count);

            foreach (var t in seq)
            {
                Console.Write("({0} {1}) ", t.Index, t.Value);
            }
            Console.WriteLine();
            var result = sort.Sort(seq);
            foreach (var t in result)
            {
                Console.Write("({0} {1}) ", t.Index, t.Value);
            }
            Console.WriteLine();
            Array.Sort(seq);
            foreach (var t in seq)
            {
                Console.Write("({0} {1}) ", t.Index, t.Value);
            }



            Console.WriteLine();



            Console.Read();
        }
    }
}
