using System;

namespace TestingLab1
{
    class Program
    {
        static void Main()
        {
            var sort = new SimultaneousInsertionSort();
            var seq = new ArrayGenerator().Generate(20);
            int[] seq1 = new int[20];
            Array.Copy(seq, seq1, seq.Length);
            foreach (var elem in seq)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();

            sort.Sort(seq, 3);

            foreach (var elem in seq)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
            Array.Sort(seq1);
            foreach (var elem in seq1)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
