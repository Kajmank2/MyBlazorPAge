using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public interface ICarService
    {
        List<Car> GetCar();
        Car GetCarById(int carId);
        Car Update(Car car);
        void Save(Car car);
        void Delete(Car car);
    }
}
