using System;
using System.Collections.Generic;
using System.Linq;


namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductSorter<Product> productSorter = new ProductSorter<Product>();
            Dictionary<string, Product> productsList = new Dictionary<string, Product>()
            {
                {"Хлеб", new Product("Хлеб", "Хлеб", 20, 12)},
                {"Блины", new Product("Блины", "Блины", 200, 220)},
                {"Пирог", new Product("Пирог", "Пирог", 300, 550)},
                {"Салат", new Product("Салат", "Салат", 90, 110)},
                {"Пирожок", new Product("Пирожок", "Тесто, картофель", 30, 20)},
                {"Пицца", new Product("Пицца", "Тесто, сыр, помидоры", 250, 500)},
                {"Суп", new Product("Суп", "Картофель, вода, мясо, специи", 150, 80)},
                {"Пюрешка", new Product("Пюрешка", "Картофель, подлива", 100, 50)}
            };
            
            
            List<string> orderListNow = new List<string>(); // Список текущих заказов

            CustomList myList = new CustomList(); // Булдыга для реализации 2 задания
            myList.AppendInList(productsList["Хлеб"]);
            myList.AppendInList(productsList["Салат"]);
            myList.AppendInList(productsList["Пицца"]);
            myList.AppendInList(productsList["Пюрешка"]);

            
            foreach (var products in myList)
            {
                Console.WriteLine(products);
            }

            /*foreach (string product in myList)
            {
                orderListNow.Add(product);
            }*/
            myList.ClearList();

            List<int> pricesNow = new List<int>();
            pricesNow.Add(productsList["Хлеб"].Price);
            pricesNow.Add(productsList["Салат"].Price);
            pricesNow.Add(productsList["Пицца"].Price);
            pricesNow.Add(productsList["Пюрешка"].Price);
            

            Cashier vanya = new Cashier("Иванов", "Иван", "Иванович", 21000);
            vanya.Greetings();
            
            vanya.NotifyOrder(orderListNow);
            
            Check check = new Check(orderListNow, vanya.Surname, vanya.Name, vanya.Patronymic, pricesNow);
            
            Console.WriteLine(check);

            Cook galya = new Cook("Галинченко", "Галя", "Галинченко", 32000);
           
            galya.Greetings();
            
            /*productsList.Sort(productSorter);
            foreach (var food in productsList)
            {
                Console.WriteLine(food);
            }*/
            
        }
    }
}