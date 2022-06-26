using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject.Models;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car GetCarByID(int id);
        void AddNew(Car car);
        void Update(Car car);
        void Delete(int carID);
    }
}
