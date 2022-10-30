#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объект класса для сериализации/десериализации JSON
            Json<Dictionary<string, Product>> productDictionaryJson = new Json<Dictionary<string, Product>>();
            
            // Словарь с меню
            Dictionary<string, Product> productsList = productDictionaryJson.DeserializeDictionary(Config.JSON_PATH);
            
            Console.WriteLine("Введите 1, чтобы добавить товар в меню");
            string? addProduct = Console.ReadLine();
            if (addProduct == "1")
            {
                Console.WriteLine("Введите название продукта");
                string? productName = Console.ReadLine();
                
                Console.WriteLine("Введите ингредиенты");
                string? productIngredients = Console.ReadLine();
                    
                Console.WriteLine("Введите вес товара");
                int productWeight = Convert.ToInt32(Console.ReadLine());
                if (productWeight < 0)
                {
                    throw new ProductException(Config.ERROR_TXT);
                }
                    
                Console.WriteLine("Введите цену товара");
                int productPrice = Convert.ToInt32(Console.ReadLine());
                if (productPrice < 0)
                {
                    throw new ProductException(Config.ERROR_TXT);
                }

                try
                {
                    productsList.Add(productName ?? throw new InvalidOperationException(), 
                        new Product(productName, productIngredients, productWeight, productPrice));
                    // Сохранение меню в JSON
                    productDictionaryJson.SerializeDictionary(productsList, Config.JSON_PATH);
                }
                catch 
                {
                    Console.WriteLine("Такой товар уже есть в меню");
                }
            }
            
            Cashier vanya = new Cashier("Иванов", "Иван", "Иванович", 21000); 
            vanya.Greetings(); // Приветствие работника
            
            List<string> orderListNow = new List<string>(); // Список текущих заказов
            List<int> pricesNow = new List<int>(); // Цены текущих заказов 
            
            // Задание 2 + Задание 4 - показ логирования
            CustomList<Product> myCustomList = new CustomList<Product>(); // Формирование текущего заказа покупателя
            myCustomList.Add(productsList["Хлеб"]);
            myCustomList.Add(productsList["Салат"]);
            myCustomList.Add(productsList["Пицца"]);
            myCustomList.Add(productsList["Пюрешка"]);
            
            foreach (var product in myCustomList)
            {
                orderListNow.Add(product.ProductName);
                pricesNow.Add(product.Price);
            }
            
            vanya.NotifyOrder(orderListNow); // Кассир сообщает о новом заказе
            
            // Создание чека с заказом (Задание 4 - показ логирования)
            Check check = new Check(orderListNow, vanya.Surname, vanya.Name, vanya.Patronymic, pricesNow); 
            Console.WriteLine(check);

            // Задание 3 
            /*
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
            myCustomList.Retrieve(printNameAndWeight); */
            
        }
    }
}