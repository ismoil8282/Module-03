namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference types, ref & out

            Person person = new Person() { Id = 1, Name = "Tom" };
            ///Person type dagi person nomli ozgarivchi yangi obyekt yaratyapti 
            ///yani Steak da va Heap da joy ochilib steak da yangi adresi, ozgaruvchi nomi va Heapdagi adressni qiymat sifati berib qoyapti
            Person person1 = person;
            ///Person type dagi person1 nomli ozgarivchini person ga tenglashtirib qoyildi
            ///Steakda yangi joy ochib yangi addres ozgaruvchi nomi va Heap dagi person qarab turgan qiymatga person1 ni qiymatini tenglashti
            
            Console.WriteLine(person.Name);
            Console.WriteLine(person1.Name);
            ///person ozgaruvchisi dagi Name Xususiyatni Ekranga chiqaradi 
            ///person1 ozgaruvchi dagi Name Xususiyatni Ekranga chiqaradi 
            person1.Name = "Alice";
            ///person1 ozgaruvchisi dagi Name xususiyatiga yangi qiymat berilvotti 
            ///yani person1 ga Heap da yangi joy ajratilib steakdagi qiymati Heapdagi yangi joyni adressiga tenglashtirib qoyildi

            DisplayInfo(ref person);
            /// ref kalit sozi ishlatgan xolda person ozgaruvchisini displayInfo metodiga qiymati kopiyasa emas ozini berdi


           

            int a = 1;
            /// a nomli yangi value type ozgaruvchi ochildi va 1 ga tenglandi 
            /// Steakda yangi joy ochilib adressi ozgaruvchi nomi va qiymati berildi 
            int b = 2;
            /// b nomli yangi value type ozgaruvchi ochildi va 2 ga tenglandi 
            /// Steakda yangi joy ochilib adressi ozgaruvchi nomi va qiymati berildi 
            int result;
            ///Steakda yangi adress va nomi yaratildi qiymati default berildi 

            int.TryParse(Console.ReadLine(), out result);
            ///ozgaruvchi raqamlikka tekshirilvotti agar Conlose.Readline orqali kiritilgan raqam bolsa out kalit sozi orqali resultga teglashtirib qoyiladi
            ///aks xolda error beradi

            Swap(ref a, ref b);
            ///ref kalit sozi orqali  metod ga ozgaruvchini kopiyasi emas originalini bervoryapti

            Console.WriteLine(a);
            Console.WriteLine(b);
            ///a bilan b ozgaruvchilarini ekranga chiqaryappti
            
            Console.WriteLine(result);
            /// resul ozgaruvchisini ekranga chiqazvotti 
            AddTen(out result);
            /// out kalit sozi orqali resultni ozini metodga bervoryapti 
            Console.WriteLine(result);
            /// result ozgaruvchini ekranga chiqazvotti

            #endregion

            Person personForStruct = new Person()
            {
                Id = 50,
                Name = "Struct person"
            };
            ///Person toifadagi personForStruct ozgaruvchi da yangi obyekt yaratilvotii
            ///yani Heapda joy yaratiladi steakda gi qiymatga heapdagi adress beriladi 
           
            PersonStruct personStruct = new PersonStruct()
            {
                Person = personForStruct,
                Id = 1,
                Name = "John"
            };
            ///Personsreuct toifadagi personStruct ozgaruvchida yangi obyekt yaratilib Heapda yangi joy yaratilinadi
            ///steakdagi qiymatiga heapdagi adress beriladi 
            

            PersonStruct personStruct1 = personStruct
            ///PersonStruct toifada yangi personStruct1 ozgaruvchisi ozchiladi va personStruct ozgaruvchisiga tenglanib Heapdagi bitta adressga qaratildi

            Console.WriteLine(personStruct.Name);
            Console.WriteLine(personStruct1.Name);
            ///personStruct obyektini Name xususiyati ekranga chiqaradi
            ///personStruct1 obyektini Name xususiyati ekranga chiqaradi
            personStruct.Name = "Tom";
            

            Console.WriteLine(personStruct.Name);
            Console.WriteLine(personStruct1.Name);

            UpdateStruct(personStruct);

            Console.WriteLine(personStruct.Id);
            Console.WriteLine(personStruct1.Id);

            int number = 10;
            MultiplyByTen(number);
            Console.WriteLine(number);

            personForStruct.Name = "John";

            Console.WriteLine(personStruct.Person.Name);
            Console.WriteLine(personStruct1.Person.Name);

            personStruct.Person = new Person()
            {
                Id = 40,
                Name = "Robert"
            };
            personStruct.Id = 500;

            Console.WriteLine(personStruct.Person.Name);
            Console.WriteLine(personStruct1.Person.Name);

            Person personTest = new Person()
            {
                Id = 1,
                Name = "Test"
            };
            Person personTest1 = personTest;

            personTest = new Person()
            {
                Id = 4,
                Name = "Changed"
            };

             personTest.Name = "Changed";

            Console.WriteLine(personTest.Name);
            Console.WriteLine(personTest1.Name);

            personTest.PersonStruct = new PersonStruct()
            {
                Id = 1,
                Name = "Structo for Test"
            };

            Console.WriteLine(personTest.PersonStruct.Name);

            PersonStruct newStruct = personTest.PersonStruct;

            newStruct.Name = "Robert";

            Console.WriteLine(personTest.PersonStruct.Name);
            Console.WriteLine(newStruct.Name);
        }

        public static void DisplayInfo(ref Person person)
        {
            int a = 5;
            person = new Person() { Id = 4, Name = "Bob" };

            Console.WriteLine(person.Name);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void AddTen(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        public static void UpdateStruct(PersonStruct person)
        {
            person.Id = 9;
            Console.WriteLine(person.Id);
        }

        public static void MultiplyByTen(int a)
        {
            a *= 10;
            Console.WriteLine(a);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PersonStruct PersonStruct { get; set; }
    }

    struct PersonStruct
    {
        public Person Person { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}