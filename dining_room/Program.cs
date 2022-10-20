#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsList = new Dictionary<string, Product>()
            {
                {"Хлеб", new Product("Хлеб", "Хлеб", 20, 12)},
                {"Блины", new Product("Блины", "Блины", 200, 220)},
                {"Пирог", new Product("Пирог", "Пирог", 300, 549)},
                {"Салат", new Product("Салат", "Салат", 90, 110)},
                {"Пирожок", new Product("Пирожок", "Тесто, картофель", 30, 20)},
                {"Пицца", new Product("Пицца", "Тесто, сыр, помидоры", 250, 500)},
                {"Суп", new Product("Суп", "Картофель, вода, мясо, специи", 150, 80)},
                {"Пюрешка", new Product("Пюрешка", "Картофель, подлива", 100, 50)}
            };
            
            /*
            List<string> orderListNow = new List<string>(); // Список текущих заказов
            List<int> pricesNow = new List<int>(); // Цены текущих заказов 
            */
            
            // Задание 2
            CustomList<Product> myCustomList = new CustomList<Product>();
            myCustomList.Add(productsList["Хлеб"]);
            myCustomList.Add(productsList["Пирог"]);
            myCustomList.Add(productsList["Пицца"]);
            myCustomList.Add(productsList["Пюрешка"]);
            foreach (var item in myCustomList)
            {
                Console.WriteLine(item);
            }

            // Задание 3
            Func<Product, Product, bool> priceFunc = (x, y) => x.Price.CompareTo(y.Price) == 1;
            Func<Product, Product, bool> weightFunc = (x, y) => x.Weight.CompareTo(y.Weight) == 1;
            Action<Product> printNameAndPrice = x => Console.WriteLine($"Название = {x.ProductName}, " +
                                                                         $"Цена = {x.Price}");
            Action<Product> printNameAndWeight = x => Console.WriteLine($"Название = {x.ProductName}, " +
                                                                          $"Вес = {x.Weight}");
            
            Console.WriteLine("\nСортировка по цене");
            myCustomList.SortByField(priceFunc);
            myCustomList.Retrieve(printNameAndPrice);
            
            Console.WriteLine("\nСортировка по весу");
            myCustomList.SortByField(weightFunc);
            myCustomList.Retrieve(printNameAndWeight);
            
            
            
            
            /*
            
            foreach (var products in myList)
            {
                Console.WriteLine(products);
            }
                       
            myList.ClearList();*/

            /*
            pricesNow.Add(productsList["Хлеб"].Price);
            pricesNow.Add(productsList["Салат"].Price);
            pricesNow.Add(productsList["Пицца"].Price);
            pricesNow.Add(productsList["Пюрешка"].Price);
            

            Employees vanya = new Cashier("Иванов", "Иван", "Иванович", 21000);
            vanya.Greetings();
            
            vanya.NotifyOrder(orderListNow);
            
            Check check = new Check(orderListNow, vanya.Surname, vanya.Name, vanya.Patronymic, pricesNow);
            
            Console.WriteLine(check);

            Cook galya = new Cook("Галинченко", "Галя", "Галинченко", 32000);
           
            galya.Greetings();
            */


        }
    }
}