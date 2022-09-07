using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dining_room
{
    public class Check : ISNPtoString // Чек для покупателя (название блюда, фамилия, имя и отчество сотрудника, стоимость, дата и время)
    {
        public List<string> ProductNames { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Price { get; set; }
        public DateTime DateAndTimeNow { get; set; }
        
        public Check(List<string> productName, string surname, string name, string patronymic, int [] price)
        {
            ProductNames = productName;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Price = price.Sum();
            DateAndTimeNow = DateTime.Now;
        }
        
        public override string ToString()
        {
            StringBuilder newCheck = new StringBuilder();
            newCheck.Append("Блюда: ");
            foreach (var str in ProductNames)
            {
                newCheck.Append(str + " ");
            }
            newCheck.AppendLine();
            newCheck.AppendLine($"Итоговая стоимость: {Price}");
            newCheck.AppendLine($"ФИО сотрудника: {SNPtoString()}");
            newCheck.AppendLine($"Дата и время: {DateAndTimeNow}");

            return newCheck.ToString();
        }

        public string SNPtoString()
        {
            return $"{Surname} {Name} {Patronymic}";
        }
    }
}