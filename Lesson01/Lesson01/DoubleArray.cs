namespace Lesson01
{
    internal class DoubleArray
    {
        private double[] _array = new double[10];
        private int currentIndex = 0;

        public void Add(double number)
        {
            if (currentIndex >= _array.Length)
            {
                double[] newArray = new double[_array.Length * 2];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[currentIndex++] = number;
        }

        public void Remove(double number)
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
            foreach (double number in _array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
