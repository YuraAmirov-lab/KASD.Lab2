using System;
namespace ConsoleApp4
{
    class Programm
    {
        static void Main()
        {
            //Person person0 = new Person("Ivan", 33);
            Student person1 = new Student("Yura", 19, 0195883);
            Teacher person2 = new Teacher("Svetlana", 35, 70000, 10);
            Headdepartament person3 = new Headdepartament("Igor", 45, 100000, 20, "KVT");
            //person0.Display();
            person1.Display();
            person2.Display();
            Console.WriteLine(person2.Nachalo_Raboty());
            Console.WriteLine(person3.Nachalo_Raboty());

        }
    }
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name + " " + Age);
        }
    }
    class Student : Person
    {
        public int Id { get; set; }
        public Student(string Name, int Age, int Id) : base(Name, Age)
        {
            this.Id = Id;
        }
        public override void Display()
        {
            Console.WriteLine(Name + " " + Age + " " + Id);
        }
    }
    class Teacher : Person
    {
        public int zarplata { get; set; }
        public int Staj_Raboty { get; set; }
        public Teacher(string Name, int Age, int zarplata, int Staj_Raboty) : base(Name, Age)
        {
            this.zarplata = zarplata;
            this.Staj_Raboty = Staj_Raboty;
        }
        public int Nachalo_Raboty()
        {
            Console.WriteLine(Staj_Raboty + " " + zarplata);
            return (Age - Staj_Raboty);
        }
        public override void Display()
        {
            Console.WriteLine(Name + " " + Age + " " + zarplata);
        }
    }
    class Headdepartament : Teacher
    {
        public string departament { get; set; }
        public Headdepartament(string Name, int Age, int zarplata, int Staj_Raboty, string departament) : base(Name, Age, zarplata, Staj_Raboty)
        {
            this.departament = departament;
        }
        public int Nachalo_Raboty()
        {
            Console.WriteLine(Staj_Raboty + " " + zarplata);
            return (Age - Staj_Raboty);
        }
        public override void Display()
        {
            Console.WriteLine(Name + " " + Age + " " + zarplata + " " + departament);
        }
    }
}