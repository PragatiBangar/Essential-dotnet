using Core.Models;
using Core.Repositories.Interfaces;

namespace Core.Repositories
{
    public class FlowerRepository : IFlowerRepository
    {
        public List<Flower> GetAll()
        {
            List<Flower> items = new List<Flower>()
            {
                new Flower()
                {
                    ID =14,
                    Name = "Summer Breeze Flower Box",
                    SalePrice = 4.99M,
                    UnitPrice = 1.69M,
                    Quantity = 43
                },
                new Flower()
                {
                    ID = 3,
                    Name = "Yellow Mello Sunshine Bouquet ",
                    SalePrice = 4.89M,
                    UnitPrice = 1.13M,
                    Quantity = 319
                },
                new Flower()
                {
                    ID =14,
                    Name = "Sunshine Floral Ecstasy",
                    SalePrice = 5.69M,
                    UnitPrice = 0.47M,
                    Quantity = 252
                },
                new Flower()
                {
                    ID =14,
                    Name = "Red Rose Beautiful Bunch",
                    SalePrice = 4.1M,
                    UnitPrice = 1.80M,
                    Quantity = 450
                },
                new Flower()
                {
                    ID =14,
                    Name = "Dreamy Hues",
                    SalePrice = 5.59M,
                    UnitPrice = 1.12M,
                    Quantity = 217
                }
            };
            return items;
        }
    
    public Flower GetById(int id)
    {
       List<Flower> allFlowers = GetAll();
       var found = allFlowers.Find(x => x.ID == id);
       Flower theFlower = found as Flower;
       return theFlower;
    }
     
    public List<Flower> GetAllSold()
    {
        List<Flower> items = new List<Flower>()
        {
            new Flower()
                {
                    ID =14,
                    Name = "Summer Breeze Flower Box",
                    SalePrice = 4.99M,
                    UnitPrice = 1.69M,
                    Quantity = 43
                },
                new Flower()
                {
                    ID = 3,
                    Name = "Yellow Mello Sunshine Bouquet ",
                    SalePrice = 4.89M,
                    UnitPrice = 1.13M,
                    Quantity = 319
                },
                new Flower()
                {
                    ID =14,
                    Name = "Sunshine Floral Ecstasy",
                    SalePrice = 5.69M,
                    UnitPrice = 0.47M,
                    Quantity = 252
                },
                new Flower()
                {
                    ID =14,
                    Name = "Red Rose Beautiful Bunch",
                    SalePrice = 4.1M,
                    UnitPrice = 1.80M,
                    Quantity = 450
                },
                new Flower()
                {
                    ID =14,
                    Name = "Dreamy Hues",
                    SalePrice = 5.59M,
                    UnitPrice = 1.12M,
                    Quantity = 217
                }
            };
            return items; 
        }
    }
}