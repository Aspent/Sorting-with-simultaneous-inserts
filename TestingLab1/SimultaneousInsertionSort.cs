namespace TestingLab1
{
    class SimultaneousInsertionSort
    {
        public void SortGroups(int[] sequence, int count)
        {
            var groupsCount = sequence.Length / count;
            var rest = sequence.Length % count;
            var insSort = new InsertionSort();
            for (var i = 0; i < groupsCount; i++)
            {
                insSort.SortRange(sequence, i * count, count);
            }
            insSort.SortRange(sequence, groupsCount * count, rest);
        }

        public void MoveRightSeveralElements(int[] sequence, int index, int count, int shift)
        {
            for (var i = count-1; i >= 0; i--)
            {
                sequence[index + shift + i] = sequence[index + i];
            }
        }

        public void Place(int[] sequence, int[] elems, int index, int count)
        {
            for (var i = 0; i < count; i++)
            {
                sequence[index + i] = elems[i];
            }
        }

        public void InsertGroup(int[] sequence, int startIndex, int count)    
        {
            var elemsCount = count;
            var j = startIndex;
            var elems = new int[elemsCount];
            for (var k = 0; k < elemsCount; k++)
            {
                elems[k] = sequence[startIndex + k];
            }

            while ((j > 0) && (elemsCount > 0))
            {
                var lastElem = elems[elemsCount - 1];
                var shiftsCount = 0;
                while ((j > 0) && (sequence[j - 1] > lastElem))
                {
                    j--;
                    shiftsCount++;
                }
                MoveRightSeveralElements(sequence, j, shiftsCount, elemsCount);
                Place(sequence, elems, j, elemsCount);
                elemsCount--;
            }
        }

        public void Sort(int[] sequence, int count)
        {
            var groupsCount = sequence.Length/count;
            var rest = sequence.Length%count;
            SortGroups(sequence, count);

            for (var i = 1; i < groupsCount; i++)
            {
                var index = i*count;
                InsertGroup(sequence, index, count);
            }
            InsertGroup(sequence, sequence.Length-rest, rest);
        }
    }
}
