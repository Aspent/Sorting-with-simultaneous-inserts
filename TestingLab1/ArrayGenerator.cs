using System;

namespace TestingLab1
{
    public class ArrayGenerator
    {
        public int[] Generate(int count)
        {
            var array = new int[count];
            var rand = new Random();
            for (var i = 0; i < count; i++)
            {
                array[i] = rand.Next(400000);
            }

            return array;
        }
    }
}
