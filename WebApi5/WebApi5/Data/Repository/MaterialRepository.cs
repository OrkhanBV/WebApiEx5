/*using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi5.Data;
using WebApi5.Data.Interfaces;
using WebApi5.Data.Models;

namespace WebApi5.Data.Repository
{
    public class MaterialRepository : IAllMaterial {

        private readonly AppDBContent appDBContent;

        public MaterialRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        
        // Выведем все материалы с посмощью Linq метода ToList
        public IEnumerable<Material> getAllMaterials => appDBContent.Material.ToList();

        /*public IEnumerable<Material> getAppMaterials(string categoryTypeApp)
        {
            return ;//возвращаем список нужной категории
        }#1#
        
        /*public IEnumerable<Material> getPresentMaterials(string categoryTypePresent)
        {
            return ;//возвращаем список нужной категории
        }#1#
        
        /*public IEnumerable<Material> getOtherMaterials(string categoryTypePresent)
        {
            return ;//возвращаем список нужной категории
        }#1#
        
    }
}*/
/*{
    public abstract class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}*/