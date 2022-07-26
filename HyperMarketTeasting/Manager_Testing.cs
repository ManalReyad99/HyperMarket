//using NUnit.Framework;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HyperMarket.Testing
//{
//    [TestFixture]
//    public class Manager_Testing
//    {

//        private Cashier cashier = null;
//        private Supplier supplier = null;
//        private Category category = null;
//        private List<Product> products;
//        private ProductNeed productNeed;
//        [SetUp]
//        public void SetingUp()
//        {
//            if (cashier == null)
//            {
//                cashier = new Cashier()
//                {
//                    Name = "Ahmed",
//                    Phone = "01226655614",
//                    Salary = 5000,
//                    WorkingHours = 12,
//                    Username = "ahmed20",
//                    Password = "ahmed2022"
//                };
//                Market.market.Cashiers.Add(cashier);
//            }
//            else
//            {
//                //////////cashier = Market.market.Cashiers[0];
//            }
//            if (supplier == null)
//            {
//                supplier = new Supplier("Kareem", "01226655614", "Fruits");
//                Market.market.Suppliers.Add(supplier);
//            }
//            else
//            {
//                supplier = Market.market.Suppliers[0];
//            }
//            products = new List<Product>()
//            {
//                new Product()
//                {
//                    Name="Mango",
//                    Amount =20,
//                    PriceForBuy=20,
//                    PriceForSell=15,
//                    category="Fruits",
//                    IsExist=true,
//                    ExpireDate=new DateTime(2023,4,25)

//                },
//                new Product()
//                {
//                    Name = "Banana",
//                    Amount = 40,
//                    PriceForBuy = 25,
//                    PriceForSell = 20,
//                    category = "Fruits",
//                    IsExist = true,
//                    ExpireDate = new DateTime(2023, 4, 25)

//                },
//                new Product()
//                {
//                    Name="Struberry",
//                    Amount =90,
//                    PriceForBuy=30,
//                    PriceForSell=25,
//                    category="Fruits",
//                    IsExist=true,
//                    ExpireDate=new DateTime(2023,4,25)

//                }

//            };
//            productNeed = new ProductNeed()
//            {
//                Product = products[0],
//                AmountNeeded = 15
//            };
//            if (category == null)
//            {
//                category = new Category()
//                {
//                    Name = "Fruits",
//                    Products = products
//                };
//                Market.market.Categories.Add(category);
//            }
//            else
//            {
//                category = Market.market.Categories[0];
//            }



//        }

//        [Test]
//        public void AddSupplierTest()
//        {
//            Manager.manager.AddSupplier(supplier);

//            Assert.That(Market.market.Suppliers.Contains(supplier), Is.True);
//        }

//        [Test]
//        public void AddCashierTest()
//        {
//            Manager.manager.AddCashier(cashier);
//            Assert.That(Market.market.Cashiers.Contains(cashier), Is.True);
//        }

//        [Test]
//        public void AddCategoryTest()
//        {
//            Manager.manager.AddCategory(category);
//            Assert.That(Market.market.Categories.Contains(category), Is.True);
//        }
//        [Test]
//        public void CreateSupplierBillTest()
//        {
//            Manager.manager.CreateBill(supplier);
//            Assert.That(supplier.bills.Count, Is.GreaterThan(0));
//        }

//        [Test]
//        public void AddProductToSupplierBillTest()
//        {
//            Manager.manager.CreateBill(supplier);
//            Manager.manager.AddSupplierProduct(supplier, productNeed);
//            Assert.AreEqual(
//               supplier.bills[supplier.bills.Count - 1].Supplier_Product[0]
//                , productNeed);
//        }


//        [Test]
//        public void PayBillForSupplierTest()
//        {
//            Manager.manager.CreateBill(supplier);
//            Manager.manager.AddSupplierProduct(supplier, productNeed);
//            Manager.manager.pay(supplier);
//            Assert.That(productNeed.Product.Amount, Is.EqualTo(35));

//        }

//        [Test]
//        public void PayBillForSupplierBudgetTest()
//        {
//            Manager.manager.CreateBill(supplier);
//            Manager.manager.AddSupplierProduct(supplier, productNeed);
//            Manager.manager.pay(supplier);
//            Assert.That(Market.market.Budget, Is.EqualTo(1500000 -
//                productNeed.AmountNeeded * productNeed.Product.PriceForSell));
//        }

//        [Test]
//        public void RemoveProductToSupplierBillTest()
//        {
//            Manager.manager.CreateBill(supplier);
//            Manager.manager.AddSupplierProduct(supplier, productNeed);
//            Manager.manager.RemoveSupplierProduct(supplier, productNeed);
//            Assert.That(
//               supplier.bills[supplier.bills.Count - 1].Supplier_Product
//               .Contains(productNeed), Is.False);
//        }

//        [Test]
//        [TestCase(60, true)]
//        [TestCase(70, true)]
//        [TestCase(4500000, false)]
//        public void CheckBadgetCoveredTest(double ProductPrice,
//            bool ExpectedOutput)
//        {
//            bool ActualOutput = Manager.manager.CheckBudgedCovered(ProductPrice);
//            Assert.That(ActualOutput, Is.EqualTo(ExpectedOutput));

//        }
//        [Test]
//        public void CashierISExistTest()
//        {
//            Assert.IsTrue(Manager.manager.CashierIsExist(cashier));
//        }
//        [Test]
//        public void CashierISNotTest()
//        {
//            Assert.IsFalse(Manager.manager.CashierIsExist(new Cashier()
//            {
//                Name = "Mazen"
//            }));
//        }
//        [Test]
//        public void SupplierIsExistTest()
//        {
//            Assert.IsTrue(Manager.manager.SupplierIsExist(supplier));
//        }
//        [Test]
//        public void SupplierIsNotExistTest()
//        {
//            Assert.IsFalse(Manager.manager.SupplierIsExist(new
//                Supplier("Hatem", "010000000000", "Clothes")));
//        }
//        [Test]
//        public void CategoryIsExistTest()
//        {
//            Assert.IsTrue(Manager.manager.CategoryIsExist(category));
//        }
//        [Test]
//        public void CategoryIsNotExistTest()
//        {
//            Assert.IsFalse(Manager.manager.CategoryIsExist(new Category()
//            {
//                Name = "Clothes"
//            }));
//        }

//        [Test]
//        public void DeleteSupplierTest()
//        {
//            Manager.manager.DeleteSupplier(supplier);
//            Assert.That(Market.market.Suppliers.Contains(supplier), Is.False);
//        }
//        [Test]
//        public void DeleteCashierTest()
//        {
//            Manager.manager.DeleteCashier(cashier);
//            Assert.That(Market.market.Cashiers.Contains(cashier), Is.False);
//        }
//        [Test]
//        public void DeleteCategoryTest()
//        {
//            Manager.manager.DeleteCategory(category);
//            Assert.That(Market.market.Categories.Contains(category), Is.False);
//        }


//        [Test]
//        [TestCaseSource(typeof(AddProductTestData))]
//        public void AddProductToSupplierBillTestSource(ProductNeed productinput)
//        {
//            Manager.manager.CreateBill(supplier);
//            Manager.manager.AddSupplierProduct(supplier, productinput);
//            Assert.AreEqual(
//               supplier.bills[supplier.bills.Count - 1].Supplier_Product[
//                   supplier.bills[supplier.bills.Count - 1].
//                   Supplier_Product.Count - 1]
//                   , productinput);
//        }

//        public class AddProductTestData : IEnumerable
//        {
//            public IEnumerator GetEnumerator()
//            {
//                StreamReader TestCaseData = new StreamReader("D:/Professional Web Development and BI/Unit testing/Project/Final_HyperMarketProjrct/HyperMarket.Testing/AddProductToSupplierBill.json");
//                string json = TestCaseData.ReadToEnd();

//                List<AddProductToSupplierBillTestData> Items =
//                    Newtonsoft.Json.JsonConvert.DeserializeObject<List<AddProductToSupplierBillTestData>>(json);

//                foreach (var item in Items)
//                {
//                    ProductNeed productInput = new ProductNeed()
//                    {
//                        Product = new Product()
//                        {
//                            Name = item.Name,
//                            PriceForBuy = item.PriceForBuy,
//                            PriceForSell = item.PriceForSell,
//                            category = item.category,
//                            Amount = item.Amount

//                        },
//                        AmountNeeded = item.AmountNeeded
//                    };
//                    yield return new TestCaseData(productInput);
//                }
//            }

//        }

//    }
//}
