using HyperMarket;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarketTeasting
{
    [TestFixture]

    public class CategoryTest
    {
        private Category category = null;
        private List<Product> products;
        
        [SetUp]
        public void setUp()
        {
            category = new Category();
            products = new List<Product>()
            {
                   new Product()
                {
                    Name = "Orange",
                    Amount = 200,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                } 
                ,

                new Product()
                {
                     Name = "Banana",
                    Amount = 30,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)

                },
                new Product()
                {
                     Name = "Apple",
                    Amount = 30,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)

                }
            };
            category.Products = products;

        }
        [Test]
        public void GetProduct()
        {
            Assert.AreEqual(category.GetProduct("Orange"),products[0]);
        }
        [Test]
        public void GetProductWithNotExistProduct()
        {
            Assert.AreEqual(category.GetProduct("Mango"), null);
        }
    }
}
