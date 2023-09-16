namespace Lesson01
{
    internal class GenericArray<T>
    {
        private T[] _array = new T[10];
        private int currentIndex = 0;

        public void Add(T value)
        {
            if (currentIndex >= _array.Length)
            {
                T[] newArray = new T[_array.Length * 2];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[currentIndex++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index > _array.Length || index < 0)
            {
                Console.WriteLine("No such index");
                return;
            }

            _array[index] = default;
        }

        public void DisplayAll()
        {
            foreach (T number in _array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
