using System;

namespace dining_room
{
    abstract class Employees // Информация о работнике (фамилия, имя, отчество, заработная плата)
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Salary { get; set; }

        public Employees(string surname, string name, string patronymic, int salary)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Salary = salary;
        }

        public abstract void Greetings();
    }
    
    class Cashier : Employees
    {
        private const string Post = "Кассир";
        public Cashier(string surname, string name, string patronymic, int salary) 
            : base(surname, name, patronymic, salary)
        {
        }

        public override void Greetings()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} ({Post}):\nЗдравствуйте, что будете заказывать?");
        }
    }

    class Cook : Employees
    {
        private const string Post = "Повар";
        public Cook(string surname, string name, string patronymic, int salary) : base(surname, name, patronymic, salary)
        {
        }
        public override void Greetings()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} ({Post}):\nЗаказ готов *дзынь*");
        }
    }
}