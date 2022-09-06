using System;


namespace dining_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pureshka = new Product("Пюрешка", "Картофель, подлива", 100, 45);
            
            Console.WriteLine(pureshka);
            
            
        }
    }
}