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
    public class SupplierTeast
    {
        private Supplier supplier=null;
        private Category category=null;
        private List<Product> products;

        [SetUp]
        public void SetUp()
        {
            if(supplier==null)
            {
                supplier=new Supplier("Ahmed","01283172293","Fruit");
                Market.market.Suppliers.Add(supplier);
               
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
           
         
            if (category==null)
            {
                category=new Category() { Name="Fruit",Products = products};
                Market.market.Categories.Add(category);
            }
            supplier.category=category;
            Market.market.Categories.Add(category);

        }

        [Test]
        public void RemoveProductTest()
        {
            var result = supplier.RemoveProduct("Fruit", "Apple",20);
            Assert.AreEqual(true, result);

        }

        [Test]
        public void RemoveProductTestunexisted()
        {
            var result = supplier.RemoveProduct("Fruit", "Banana", 30);
            Assert.AreEqual(false, result);

        }

        [Test]
        public void AddingproductTest()
        {
            supplier.Addingproduct("Fruit", "Banana", 22);

            Assert.That(supplier.category.Products.Contains(supplier.category.Products.Find(p => p.Name == "Banana")), Is.True);

        }
        [Test]
        public void AddingproductTestIfExistInCategory()
        {
            supplier.Addingproduct("Fruit", "Banana", 22);

Assert.That(supplier.category.Products.Contains(Market.market.Categories.Find(c=>c.Name=="Fruit").Products.Find(p => p.Name == "Banana")), Is.True);

        }
        [Test]
        public void CheckPropertyNameIsExistTest()
        {
            Assert.That(supplier, Has.Property("Name"));
        }
       

        [Test]
        public void CheckPropertyIDIsExistTest()
        {
            Assert.That(supplier, Has.Property("ID"));
        }
        [Test]
        public void CheckPropertyPhoneNumberIsExistTest()
        {
            Assert.That(supplier, Has.Property("PhoneNumber"));
        }
        [Test]
        public void CheckPropertycategoryIsNullTest()
        {
            Assert.That(supplier.category, Is.Not.Null);
        }
        [Test]
        public void CheckPropertybillsIsNullTest()
        {
            Assert.That(supplier.bills, Is.Not.Null);
        }
        [Test]
        public void CheckPropertyIDIsNullTest()
        {
            Assert.That(supplier.ID, Is.Not.Null);
        }
        [Test]
        public void CheckPropertyNameIsNullTest()
        {
            Assert.That(supplier.Name, Is.Not.Null);
        }
        [Test]
        public void CheckPropertyPhoneNumberIsNullTest()
        {
            Assert.That(supplier.PhoneNumber, Is.Not.Null);
        }
        [Test]
        public void CheckPropertyCnameIsNullTest()
        {
            Assert.That(supplier.Cname, Is.Not.Null);
        }


    }
}
