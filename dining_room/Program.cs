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

            List<string> checkNow = new List<string>
            {
                pureshka.ProductName,
                supchik.ProductName,
                pizza.ProductName,
                pirojock.ProductName
            };
            
            int[] pricesNow = { pureshka.Price, supchik.Price, pizza.Price, pirojock.Price };

            Check check = new Check(checkNow, "Петров", "Петр", "Петрович", pricesNow);
            
            Console.WriteLine(check);

            Cashier vanya = new Cashier("Иванов", "Иван", "Иванович", 21000);
            vanya.Greetings();

            Cook galya = new Cook("Галинченко", "Галя", "Галинченко", 32000);
            galya.Greetings();

            vanya.NotifyOrder(checkNow);
        }
    }
}