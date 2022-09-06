using System;

namespace dining_room
{
    public class Check // Чек для покупателя (название блюда, стоимость, фамилия, имя и отчество сотрудника, дата и время)
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateAndTimeNow { get; set; }
        

        public Check(string productName, int price, string surname, string name, string patronymic)
        {
            ProductName = productName;
            Price = price;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            DateAndTimeNow = DateTime.Now;
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}