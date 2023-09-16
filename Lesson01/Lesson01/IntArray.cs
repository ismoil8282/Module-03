namespace Lesson01
{
    internal class IntArray
    {
        private int[] _array = new int[10];
        private int currentIndex = 0;

        public void Add(int number)
        {
            if (currentIndex >= _array.Length)
            {
                int[] newArray = new int[_array.Length * 2];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[currentIndex++] = number;
        }

        public void Remove(int number)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == number)
                {
                    _array[i] = 0;
                    break;
                }
            }
        }

        public void DisplayAll()
        {
            foreach (int number in _array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
