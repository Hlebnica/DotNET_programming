using System;
using System.Collections.Generic;
using System.Text;

namespace dining_room
{
    public abstract class Employees // Информация о работнике (фамилия, имя, отчество, заработная плата)
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Salary { get; set; }
        public abstract string Post { get; set; }
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
        public Cashier(string surname, string name, string patronymic, int salary) 
            : base(surname, name, patronymic, salary) { }
        public override string Post { get; set; } = "Кассир";
        public override void Greetings()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} ({Post}):\nЗдравствуйте, что будете заказывать?");
        }
        public void NotifyOrder<T>(T order) where T : List<string> // Ограничение при обобщении
        {
            StringBuilder newOrder = new StringBuilder();
            foreach (var str in order)
            {
                newOrder.Append(str + " ");
            }
            
            Console.WriteLine($"{Post} {Surname} {Name} {Patronymic} сообщает, что поступил заказ на: {newOrder}");
        }
    }

    class Cook : Employees
    {
        public Cook(string surname, string name, string patronymic, int salary) 
            : base(surname, name, patronymic, salary) { }
        public override string Post { get; set; } = "Повар";
        public override void Greetings()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} ({Post}):\nЗаказ готов *дзынь*");
        }
    }
}