namespace Lesson01
{
    internal class PersonArray
    {
        private Person[] _array = new Person[10];
        private int currentIndex = 0;

        public void Add(Person number)
        {
            if (currentIndex >= _array.Length)
            {
                Person[] newArray = new Person[_array.Length * 2];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }

            _array[currentIndex++] = number;
        }

        public void Remove(Person number)
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
            foreach (Person number in _array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
