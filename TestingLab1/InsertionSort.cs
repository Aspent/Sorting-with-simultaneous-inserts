namespace TestingLab1
{
    class InsertionSort
    {
        public void Sort(int[] sequence)
        {
            for (var i = 1; i < sequence.Length; i++)
            {
                var elem = sequence[i];
                var j = i;
                while ((j > 0) && (elem < sequence[j-1]))
                {
                    sequence[j] = sequence[j-1];
                    j--;
                }
                sequence[j] = elem;
            }
        }

        public void SortRange(int[] sequence, int startIndex, int count)
        {
            for (var i = startIndex + 1; i < startIndex + count; i++)
            {
                var elem = sequence[i];
                var j = i;
                while ((j > startIndex) && (elem < sequence[j - 1]))
                {
                    sequence[j] = sequence[j - 1];
                    j--;
                }
                sequence[j] = elem;
            }
        }
    }
}
