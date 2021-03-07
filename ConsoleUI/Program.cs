using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("BrandId = " + car.BrandId);
                Console.WriteLine("ColorId = " + car.ColorId);
                Console.WriteLine("Daily Price = " + car.DailyPrice);
                Console.WriteLine("Model Year = " + car.ModelYear);
                Console.WriteLine("Description = " + car.Description);
                Console.WriteLine("******************");
            }
        }
    }
}
