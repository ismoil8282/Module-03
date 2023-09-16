namespace Lesson01
{
    internal class StringArray
    {
        private string[] _array = new string[10];
        private int currentIndex = 0;

        public void Add(string number)
        {
            if (currentIndex >= _array.Length)
            {
                string[] newArray = new string[_array.Length * 2];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[currentIndex++] = number;
        }

        public void Remove(string number)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == number)
                {
                    _array[i] = null;
                    break;
                }
            }
        }

        public void DisplayAll()
        {
            foreach (string number in _array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
