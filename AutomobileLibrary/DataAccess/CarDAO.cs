using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomobileLibrary.DataAccess
{
    public class CarDAO
    {
        public static CarDAO instance;
        public static readonly object instanceLock = new object();
        private CarDAO() { }
        private MyStockContext myStock = new MyStockContext();
        public static CarDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarDAO();
                }
                return instance;
            }
        }

        public IEnumerable<Car> GetCars()
        {
            using (myStock = new MyStockContext())
            {
                return myStock.Cars.ToList<Car>();
            }
        }

        public Car GetCarByID(int CarID)
        {
            using(myStock = new MyStockContext())
            {
                return myStock.Cars.SingleOrDefault<Car>(car => car.CarId == CarID);
            }
        }

        public void AddNew(Car car)
        {
            using (myStock = new MyStockContext())
            {
                try
                {
                    myStock.Cars.Add(car);
                    myStock.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Update (Car car)
        {
            using (myStock = new MyStockContext())
            {
                try
                {
                    myStock.Cars.Update(car);
                    myStock.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void Remove (int CarID)
        {
            using (myStock = new MyStockContext())
            {
                try
                {
                    Car car = myStock.Cars.SingleOrDefault<Car>(car => car.CarId == CarID);
                    myStock.Cars.Remove(car);
                    myStock.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
