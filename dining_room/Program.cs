using System;
using System.Collections.Generic;
using System.Linq;


namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSorter<Product> productSorter = new ProductSorter<Product>();
            List<Product> productsList = new List<Product>()
            {
                new("Хлеб", "Хлеб", 20, 12),
                new("Блины", "Блины", 200, 220),
                new("Пирог", "Пирог", 300, 550),
                new("Салат", "Салат", 90, 110),
                new ("Пирожок", "Тесто, картофель", 30, 20),
                new ("Пицца", "Тесто, сыр, помидоры", 250, 500),
                new ("Суп", "Картофель, вода, мясо, специи", 150, 80),
                new ("Пюрешка", "Картофель, подлива", 100, 50)
            };

            List<string> orderListNow = new List<string>
            {
                productsList[0].ProductName,
                productsList[1].ProductName,
                productsList[2].ProductName,
                productsList[3].ProductName
            };
            
            int[] pricesNow = { productsList[0].Price, productsList[1].Price,
                                productsList[2].Price, productsList[3].Price };
            //int[] pricesNow = { pureshka.Price, supchik.Price, pizza.Price, pirojock.Price };

           

            Cashier vanya = new Cashier("Иванов", "Иван", "Иванович", 21000);
            vanya.Greetings();
            
            vanya.NotifyOrder(orderListNow);
            
            Check check = new Check(orderListNow, vanya.Surname, vanya.Name, vanya.Patronymic, pricesNow);
            
            Console.WriteLine(check);

            Cook galya = new Cook("Галинченко", "Галя", "Галинченко", 32000);
            galya.Greetings();

            Cook marina = (Cook) galya.Clone();
            marina.Surname = "Мариновна";
            marina.Name = "Марина";
            
            marina.Greetings();
            
            productsList.Sort(productSorter);
            foreach (var food in productsList)
            {
                Console.WriteLine(food);
            }
            
        }
    }
}