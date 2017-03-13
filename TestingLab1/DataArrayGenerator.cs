using System;

namespace TestingLab1
{
    public class DataArrayGenerator
    {
        public Data[] Generate(int count)
        {
            var result = new Data[count];
            var rand = new Random();
            for (var i = 0; i < count; i++)
            {
                var index = rand.Next(40);
                var value = rand.Next(40);
                result[i] = new Data(index, value);
            }
            return result;
        }
    }
}
