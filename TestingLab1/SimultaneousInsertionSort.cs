using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingLab1
{
    public class SimultaneousInsertionSort<T> where T : IComparable<T>
    {
        private int _count;

        public SimultaneousInsertionSort(int count)
        {
            _count = count;
        }

        public int Count
        {
            get { return _count; }
        }

        private void SortGroups(T[] sequence, int count)
        {
            var groupsCount = sequence.Length / count;
            var rest = sequence.Length % count;
            var insSort = new InsertionSort<T>();
            for (var i = 0; i < groupsCount; i++)
            {
                insSort.SortRange(sequence, i * count, count);
            }
            insSort.SortRange(sequence, groupsCount * count, rest);
        }

        private void MoveRightSeveralElements(T[] sequence, int index, int count, int shift)
        {
            for (var i = count-1; i >= 0; i--)
            {
                sequence[index + shift + i] = sequence[index + i];
            }
        }

        private void Place(T[] sequence, T[] elems, int index, int count)
        {
            for (var i = 0; i < count; i++)
            {
                sequence[index + i] = elems[i];
            }
        }

        private void InsertGroup(T[] sequence, int startIndex, int count)    
        {
            var elemsCount = count;
            var j = startIndex;
            var elems = new T[elemsCount];
            for (var k = 0; k < elemsCount; k++)
            {
                elems[k] = sequence[startIndex + k];
            }

            while ((j > 0) && (elemsCount > 0))
            {
                var lastElem = elems[elemsCount - 1];
                var shiftsCount = 0;
                while ((j > 0) && (lastElem.CompareTo(sequence[j-1]) == -1)) 
                {
                    j--;
                    shiftsCount++;
                }
                MoveRightSeveralElements(sequence, j, shiftsCount, elemsCount);
                Place(sequence, elems, j, elemsCount);
                elemsCount--;
            }
        }

        public IEnumerable<T> Sort(IEnumerable<T> sequence)
        {
            var seq = sequence.ToArray();

            var groupsCount = seq.Length / _count;
            var rest = seq.Length % _count;
            SortGroups(seq, _count);

            for (var i = 1; i < groupsCount; i++)
            {
                var index = i * _count;
                InsertGroup(seq, index, _count);
            }
            InsertGroup(seq, seq.Length - rest, rest);

            return seq;
        }
    }
}
