namespace Lesson01
{
    internal class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public HashSet<string> PhoneNumbers { get; set; }

        public void AddNumber(string phoneNumber)
        {
            PhoneNumbers.Add("+42");
            PhoneNumbers.Add("+42");
        }
    }
}
