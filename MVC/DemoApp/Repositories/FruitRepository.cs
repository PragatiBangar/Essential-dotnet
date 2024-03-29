using Core.Models;
using Core.Repositories.Interfaces;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        public List<Fruit> GetAllSold()
        {
            List<Fruit> Fruits = new List<Fruit>()
            {
                new Fruit()
                {
                    Id = 26757,
                    MovieName = "Grapes",
                    SalePrice = 8.99M,
                    StudioCutPercentage = 0.75M,
                    Quantity = 419
                },
                new Fruit()
                {
                    Id = 26757,
                    MovieName = "Banana",
                    SalePrice = 7.99M,
                    StudioCutPercentage = 0.9M,
                    Quantity = 112
                },
                new Fruit()
                {
                    Id = 26757,
                    MovieName = "Watermelon",
                    SalePrice = 8.49M,
                    StudioCutPercentage = 0.67M,
                    Quantity = 51
                },
                new Fruit()
                {
                    Id = 26757,
                    MovieName = "Apple",
                    SalePrice = 8.50M,
                    StudioCutPercentage = 0.72M,
                    Quantity = 214
                }
            };
            return Fruits;
        }
    }
}