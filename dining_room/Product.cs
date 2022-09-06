using System;

namespace dining_room
{
    public class Product // Информация о продукте (название, ингридиенты, вес, цена)
    {
        public string ProductName { get; set; }
        public string Ingredients { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public Product(string productName, string ingredients, int weight, int price)
        {
            ProductName = productName;
            Ingredients = ingredients;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"Название продукта: {ProductName}, Ингридиенты: {Ingredients}, Вес: {Weight}, Цена: {Price}";
        }
        
    }
}