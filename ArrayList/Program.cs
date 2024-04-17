using System.Collections.Generic;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList(); 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            

            list.GetElements();
        }      
    }
    class IntArrayList
    {
        int[] _arr;
        int capacity;

        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public int this[int indexof]
        {
            get
            {
                foreach(int i in _arr)
                {
                    if(i == indexof)
                    {
                        return i;
                    }                   
                    else if (i > capacity)
                    {
                        return 0;
                    }
                }
                return _arr.Length - 1;
            }
        }
        public void Remove()
        {
            foreach (int i in _arr)
            {
                if (i == _arr[i])
                {
                    _arr[i] = 0;
                }
            }
        }
       


    }
}
