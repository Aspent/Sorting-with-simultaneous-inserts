using System;

namespace TestingLab1
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public void Sort(T[] sequence)
        {
            for (var i = 1; i < sequence.Length; i++)
            {
                var elem = sequence[i];
                var j = i;
                while ((j > 0) && (elem.CompareTo(sequence[j - 1]) == -1))
                {
                    sequence[j] = sequence[j-1];
                    j--;
                }
                sequence[j] = elem;
            }
        }

        public void SortRange(T[] sequence, int startIndex, int count)
        {
            for (var i = startIndex + 1; i < startIndex + count; i++)
            {
                var elem = sequence[i];
                var j = i;
                while ((j > startIndex) && (elem.CompareTo(sequence[j - 1]) == - 1))
                {
                    sequence[j] = sequence[j - 1];
                    j--;
                }
                sequence[j] = elem;
            }
        }
    }
}
