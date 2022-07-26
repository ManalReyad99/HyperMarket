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

    public class CashierTest
    {
        private Product product=null;
        private Product newproduct = null;
        private Product productbought = null;
        private Product productbought2 = null;
        private ProductNeed productNeed;
        private ProductNeed productNeed2;
        private ProductNeed productNeed3;
        private ProductNeed productNeedNew;
        private Customer customer = null;
        private List<Customer_Bill> bill;
        List<ProductNeed> customerProducts;
        private Cashier cashier = null;
        private Category category = null;
        List<Product> products;

        [SetUp]
        public void setUp()
        {
            if(newproduct==null)
            {
                newproduct = new Product()
                {   ID=9,
                    Name = "Orange",
                    Amount = 200,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)

                };
            }
            productNeedNew.Product = newproduct;
            productNeedNew.AmountNeeded = 2;

            if(productbought2==null)
            {
                productbought2 = new Product()
                {
                    Name = "Orange",
                    Amount = 22,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                };

            }
            if(productbought==null)
            {
                productbought = new Product()
                {
                    Name = "Apple",
                    Amount = 20,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                };
            }
            if(category==null)
            {
                category = new Category("Fruit");
                
            }
            if(cashier == null)
            {
                cashier = new Cashier("Ahmed", "ah", "12345", 8, "0145687", 4000); 
            }
            if (product == null)
            {
                product = new Product()
                {
                    Name = "Orange",
                    Amount = 200,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                };
            }
            products = new List<Product>()
            {
                 { product = new Product()
                {
                    Name = "Orange",
                    Amount = 200,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                } }
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

                },
                { product = new Product()
                {
                    Name = "Orange",
                    Amount = 200,
                    category = "Fruit",
                    PriceForBuy = 25,
                    PriceForSell = 20,
                    ExpireDate = new DateTime(2022, 12, 12)
                } }
            };
            category.Products = products;
            productNeed.Product = product;
            productNeed.AmountNeeded = 20;
            customerProducts = new List<ProductNeed>();
            customerProducts.Add(productNeed);
            bill = new List<Customer_Bill>() { new Customer_Bill() { CashierName = "Ahmed", CreatedTime = DateTime.Now, CustomerName = "Amgd", TotalPrice = 200, CustomerId = 1 } };
            customer = new Customer() { Name = "Amir", Phone = "122211" };
            customer.bills = bill;
            customer.bills[customer.bills.Count - 1].Customer_Product.Add(productNeed);
            productNeed2.Product = productbought;
            productNeed2.AmountNeeded = 5;
            productNeed3.Product = productbought2;
            productNeed3.AmountNeeded = 1;
            Market.market.Categories.Add(category);
            customerProducts.Add(productNeed3);
        }
        [Test]
    public void DeleteProductTest()
        {
           Assert.AreEqual(cashier.DeleteProduct(productNeed2, customer),false);

        }

        [Test]
        public void DeleteProductTestWithNotExistProduct()
        {
            Assert.AreEqual(cashier.DeleteProduct(productNeed3, customer), true);

        }

        [Test]
        public void AddProductTest()
        {
            Assert.AreEqual(cashier.AddProduct(productNeed, customer), true);

        }

        [Test]
        public void AddProductTestWhenProductsAmountIsNotEnough()
        {
            Assert.AreEqual(cashier.AddProduct(productNeed2, customer), false);

        }
        [Test]
        public void EditProductTestWhenProductsAmountIsNotEnough()
        {
            Assert.AreEqual(cashier.EditProduct(productNeedNew, customer), false);

        }
        [Test]
        public void EditProductTesWithEnoughAmount()
        {
            Assert.AreEqual(cashier.EditProduct(productNeedNew, customer), true);

        }

    }
}
