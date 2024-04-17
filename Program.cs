namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {


            myList<string> seherler = new myList<string>();
            Console.WriteLine(seherler.count);
            seherler.Add("Baku");
        }

        class myList<T>
        {
            T[] _array;
            T[] _tempArray;
            public myList()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }

            private int _count;

            public int count
            {
                get { return _count; }
            }
        }
    }
}

