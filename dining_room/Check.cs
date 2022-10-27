using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dining_room
{
    public class Check : ISnPtoString<string> // Чек для покупателя (название блюда, фамилия, имя и отчество сотрудника, стоимость, дата и время)
    {
        private readonly Logger _logger = new Logger();
        public List<string> ProductNames { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Price { get; set; }
        public DateTime DateAndTimeNow { get; set; }
        
        public Check(List<string> productName, string surname, string name, string patronymic, List<int> price)
        {
            ProductNames = productName;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Price = price.Sum();
            DateAndTimeNow = DateTime.Now;
            _logger.Notify += LoggerMethods.LogInFile;
            _logger.Notify += LoggerMethods.LogInConsole;
            StringBuilder newCheck = new StringBuilder();
            newCheck.AppendLine("\n----------------------------");
            newCheck.Append("Блюда: ");
            foreach (var str in ProductNames)
            {
                newCheck.Append(str + " ");
            }
            newCheck.AppendLine();
            newCheck.AppendLine($"Итоговая стоимость: {Price}");
            newCheck.AppendLine($"ФИО сотрудника: {SnPtoString()}");
            newCheck.AppendLine($"Дата и время: {DateAndTimeNow}");
            newCheck.AppendLine("----------------------------");
            
            _logger.OnNotify("Создан новый чек с данными:" +
                                    $"{newCheck}"
                                    );
            _logger.Notify -= LoggerMethods.LogInFile;
            _logger.Notify -= LoggerMethods.LogInConsole;
        }
        
        public override string ToString()
        {
            StringBuilder newCheck = new StringBuilder();
            newCheck.AppendLine("\n----------------------------");
            newCheck.Append("Блюда: ");
            foreach (var str in ProductNames)
            {
                newCheck.Append(str + " ");
            }
            newCheck.AppendLine();
            newCheck.AppendLine($"Итоговая стоимость: {Price}");
            newCheck.AppendLine($"ФИО сотрудника: {SnPtoString()}");
            newCheck.AppendLine($"Дата и время: {DateAndTimeNow}");
            newCheck.AppendLine("----------------------------");
            return newCheck.ToString();
        }

        public string SnPtoString()
        {
            return $"{Surname} {Name} {Patronymic}";
        }
    }
}