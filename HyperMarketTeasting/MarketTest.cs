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
    public class MarketTest
    {
        private Cashier cashier = null;
        private Customer customer = null;
        private Category category = null;
        private List<Product> products;
        private List<Product> Expiredproducts;
        private List<Product> Existingproducts;

        [SetUp]
        public void SetUp()
        {
            Existingproducts = new List<Product>();
            Expiredproducts = new List<Product>();
            if (cashier == null)
            {
                cashier = new Cashier()
                {
                    Name = "Amr",
                    Phone = "01234567891",
                    Salary = 3000,
                    WorkingHours = 8,
                    Username = "amr",
                    Password = "123456"
                };
                Market.market.Cashiers.Add(cashier);
            }

            if (customer == null)
            {
                customer = new Customer() { Name = "Farah", Phone = "1111111" };
                Market.market.Customers.Add(customer);
            }

            products = new List<Product>()
            {
                new Product()
                {
                    Name="Apple",
                    Amount =30,
                    PriceForBuy=25,
                    PriceForSell=20,
                    category="Fruits",
                    IsExist=true,
                    ExpireDate=new DateTime(2022,12,12)

                },
                new Product()
                {
                    Name = "Orange",
                    Amount = 20,
                    PriceForBuy = 10,
                    PriceForSell = 5,
                    category = "Fruits",
                    IsExist = true,
                    ExpireDate = new DateTime(2022,12,12)

                } ,
             new Product()
                {
                    Name = "Mango",
                    Amount = 50,
                    PriceForBuy = 30,
                    PriceForSell = 25,
                    category = "Fruits",
                    IsExist = true,
                    ExpireDate = new DateTime(2022,4,4)

                }};


            if (category == null)
            {
                category = new Category() { Name = "Fruit", Products = products };
                Market.market.Categories.Add(category);
            }
            Market.market.Categories.Add(category);
            foreach (Category cate in Market.market.Categories)
            {
                foreach (Product item in cate.Products)
                {
                    if (item.ExpireDate < DateTime.Now)
                        Expiredproducts.Add(item);
                }
            }
            foreach (Category cate in Market.market.Categories)
            {
                foreach (Product item in cate.Products)
                {
                    Existingproducts.Add(item);
                }
            }
        

    }
        
        [Test]
        public void ReportOfExpireProductsTest()
        {
            Assert.AreEqual(Market.market.ReportOfExpireProducts(), Expiredproducts);
        }
        [Test]
        public void ReportOExistingProductsTest()
        {
            Assert.AreEqual(Market.market.ReportOExistingProducts(), Existingproducts);
        }


            [Test]
        public void GetCasherTest()
        {
            var result = Market.market.GetCasher("amr");
            Assert.That(result,Is.EqualTo(cashier));
        }


        //[Test]
        //public void GetCasherTestWithInvalidUserName()
        //{
        //    Cashier cashierReturned = new Cashier() { ID = 3, Name = "Ahmed",Password="12345",Phone= "0145687",Salary=4000,
        //    Username="ah",WorkingHours=8};

        //    Cashier result = Market.market.GetCasher("manal");
        //    Assert.That(result,Is.EqualTo(cashierReturned));
        //}

        [Test]
        public void GetCustomerTest()
        {
            var result = Market.market.GetCustomer("Farah");
            Assert.That(result, Is.EqualTo(Market.market.Customers.Find(n => n.Name == "Farah")));
        }
        [Test]
        public void GetCustomerTestForUnExistCustmor()
        {
            var result = Market.market.GetCustomer("Amir");
            Assert.That(result, Is.EqualTo(null));
        }
        [Test]
        public void CheckmarketProperty()
        {
            Assert.That(Market.market, Is.Not.Null);
        }

        [Test]
        public void CheckIfMarketHasPropertyBudget()
        {
            Assert.That(Market.market, Has.Property("Budget"));
        }

        [Test]
        public void CheckIfMarketHasPropertyName()
        {
            Assert.That(Market.market, Has.Property("Name"));
        }
        [Test]
        public void CheckIfMarketHasPropertyCategoriesISNotNull()
        {
            Assert.That(Market.market.Categories,Is.Not.Null);
        }
        [Test]
        public void CheckIfMarketHasPropertyCustomersISNotNull()
        {
            Assert.That(Market.market.Customers, Is.Not.Null);
        }
        [Test]
        public void CheckIfMarketHasPropertySuppliersISNotNull()
        {
            Assert.That(Market.market.Suppliers, Is.Not.Null);
        }
        [Test]
        public void CheckIfMarketHasPropertyNameISNotNull()
        {
            Assert.That(Market.market.Name, Is.Not.Null);
        }
        [Test]
        public void CheckIfMarketHasPropertyCashiersISNotNull()
        {
            Assert.That(Market.market.Cashiers, Is.Not.Null);
        }
    }
}
