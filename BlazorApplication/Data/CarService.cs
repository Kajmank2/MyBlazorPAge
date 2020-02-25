using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public class CarService : ICarService
    {
        //private readonly ApplicationDbContext _appDbContext;
       public List<Car> Cars { get; set; }
        public CarService()
        {

            Cars = new List<Car>();
            Cars.Add(new Car(0, "Mercedes", new DateTime(1992,01,02), 120000, "obrazek1", "Benz", EnumKind.Diesel, EnumState.Used, 123902));
            Cars.Add(new Car(1, "Mitshubishi", new DateTime(1992, 01, 02), 130000, "obrazek1", "Fiesta", EnumKind.Diesel, EnumState.Used, 123902));
            Cars.Add(new Car(2, "Opel", new DateTime(1992, 01, 02), 160000, "obrazek1", "Kadet", EnumKind.Diesel, EnumState.Used, 123902));
            
        }
        public List<Car> GetCar()
        {
            return Cars;
        }

        public Car GetCarById(int carId)
        {
            return Cars.Where(auth => auth.Id == carId).FirstOrDefault();
        }
        public Car Update(Car car)
        {
            return car;
        }

        public void Save(Car car)
        {
            Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Cars.Remove(car);
        }
    }
}
