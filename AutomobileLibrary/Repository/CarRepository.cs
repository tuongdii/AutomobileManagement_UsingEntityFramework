using AutomobileLibrary.BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void AddNew(Car car) => CarDAO.Instance.AddNew(car);

        public void Delete(int carID) => CarDAO.Instance.Remove(carID);

        public IEnumerable<Car> GetAll() => CarDAO.Instance.GetCars();

        public Car GetCarByID(int id) => CarDAO.Instance.GetCarByID(id);

        public void Update(Car car) => CarDAO.Instance.Update(car);
    }
}
