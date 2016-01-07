using LabViews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabViews.Models
{
    public class DataManager
    {
        static List<Car> cars = new List<Car>();

        public static void AddCar(CreateCarViewModel model)
        {
            var car = new Car();
            car.Brand = model.Brand;
            car.Doors = model.Doors;
            car.TopSpeed = model.TopSpeed;
            cars.Add(car);
        }

        public static void ListCars(ListCarViewModel model)
        {
            foreach (var car in cars)
            {
                model.Brand = car.Brand;
                if (car.TopSpeed > 250)
                {
                    model.ShowAsFast = true;
                }
                else if (car.TopSpeed <= 250)
                {
                    model.ShowAsFast = false;
                }
            }
        }
    }
}
