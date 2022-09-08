using System;
using System.Collections.Generic;
using System.Linq;


namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pureshka = new Product("Пюрешка", "Картофель, подлива", 100, 50);
            Product supchik = new Product("Суп", "Картофель, вода, мясо, специи", 150, 80);
            Product pizza = new Product("Пицца", "Тесто, сыр, помидоры", 250, 500);
            Product pirojock = new Product("Пирожок", "Тесто, картофель", 30, 20);
            
            /*Console.WriteLine(pureshka);
            
            Console.WriteLine(pureshka.ProductName);*/

            List<Product> productsList = new List<Product>()
            {
                new("Хлеб", "Хлеб", 20, 12),
                new("Блины", "Блины", 200, 220),
                new("Пирог", "Пирог", 300, 550),
                new("Салат", "Салат", 90, 110)
            };

            List<string> orderListNow = new List<string>
            {
                pureshka.ProductName,
                supchik.ProductName,
                pizza.ProductName,
                pirojock.ProductName
            };
            
            int[] pricesNow = { pureshka.Price, supchik.Price, pizza.Price, pirojock.Price };

           

            Cashier vanya = new Cashier("Иванов", "Иван", "Иванович", 21000);
            vanya.Greetings();

            /*Cashier petya = (Cashier) vanya.Clone();
            petya.Name = "Петр";
            
            Console.WriteLine(petya);*/
            
            vanya.NotifyOrder(orderListNow);
            
            Check check = new Check(orderListNow, vanya.Surname, vanya.Name, vanya.Patronymic, pricesNow);
            
            Console.WriteLine(check);

            Cook galya = new Cook("Галинченко", "Галя", "Галинченко", 32000);
            galya.Greetings();

            Cook marina = (Cook) galya.Clone();
            marina.Surname = "Мариновна";
            marina.Name = "Марина";
            
            marina.Greetings();
            
            foreach (var food in productsList)
            {
                Console.WriteLine(food);
            }
            
            productsList.Sort();
            foreach (var food in productsList)
            {
                Console.WriteLine(food);
            }
        }
    }
}