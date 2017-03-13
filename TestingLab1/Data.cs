using System;

namespace TestingLab1
{
    public class Data : IComparable<Data>
    {
        private readonly int _index;
        private readonly int _value;

        public Data(int index, int value)
        {
            _index = index;
            _value = value;
        }

        public int Index
        {
            get { return _index; }
        }

        public int Value
        {
            get { return _value; }
        }

        public int CompareTo(Data other)
        {
            return Index == other.Index ? Value.CompareTo(other.Value) : _index.CompareTo(other.Index);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Data))
            {
                return false;
            }
            var data = ((Data) obj);
            return data.Index == Index && data.Value == Value;
        }
    }
}
