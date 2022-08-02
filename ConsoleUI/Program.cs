using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Brand : {0}",car.Description);
                Console.WriteLine("Model Year : {0}", car.ModelYear);
                Console.WriteLine("Daily Price : {0}",car.DailyPrice);
            }
        }
    }
}