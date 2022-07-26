using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMarket
{
    public struct ProductForDispaly
    {
        public string Name;
        public int price;
    }
    public partial class AdminForm : Form
    {

        int SelectedSupplierRow = -1;//does't select any cell -1
        int SelectedCashierRow = -1;//does't select any cell -1
        Validation validation = new Validation();
        List<GunaAdvenceButton> buttons = new List<GunaAdvenceButton>();
        List<ProductForDispaly> Pd = new List<ProductForDispaly>();
        public AdminForm()
        {
            InitializeComponent();
            buttons.Add(CashierButton);
            buttons.Add(CategoryButton);
            buttons.Add(BillButton);
            buttons.Add(SupplierButton);
            buttons.Add(ReportButton);

        }
        public event Action closeSplashForm;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void OnClickBtn(object GAButton)
        {
            GunaAdvenceButton btn = GAButton as GunaAdvenceButton;
            btn.BaseColor = Color.FromArgb(190, 227, 219);
            btn.BorderColor = Color.White;
            btn.ForeColor = Color.White;
            btn.LineColor = Color.White;

            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] != btn)
                {
                    buttons[i].BaseColor = Color.FromArgb(137, 176, 174);
                    buttons[i].BorderColor = Color.Black;
                    buttons[i].ForeColor = Color.Black;
                    buttons[i].LineColor = Color.Black;
                }
            }
        }
        private void CashierButton_Click(object sender, EventArgs e)
        {
            // Buttons

            OnClickBtn(CashierButton);

            // Panels
            CashierPanel.Show();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Hide();

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {

            // Buttons

            OnClickBtn(CategoryButton);

            //Panels
            CashierPanel.Hide();
            CategoryPanel.Show();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Hide();
        }

        private void BillButton_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            foreach (Supplier supplier in Market.market.Suppliers)
            {
                list.Add(supplier.Name);
            }
            BillSupplierNameComBox.DataSource = null;
            BillSupplierNameComBox.DataSource = list;
            // Buttons

            OnClickBtn(BillButton);

            //Panels
            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Show();
            ReportPanel.Hide();
            SupplierPanel.Hide();
            State(true,false);


        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            // Buttons

            OnClickBtn(SupplierButton);

            //Panels
            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            // Buttons

            OnClickBtn(ReportButton);



            //Panels

            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Show();
            SupplierPanel.Hide();

            ReportStartDateTimePicer.Enabled = false;
            ReportEndDateTimePicker.Enabled = false;
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            if (SupplierDataGrid.DataSource != null && SelectedSupplierRow >= 0)
            {
                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier su = null;
                foreach (Supplier item in Market.market.Suppliers)
                {
                    if (item.ID.ToString() == Selected_SupplierID)
                    {
                        su = item;
                    }
                }

                if (su != null && SupplierProductNameTextBox.Text != "" && validation.IsValidPrice(SupplierProductPriceSellTxtBox.Text.ToString()))
                {
                    su.Addingproduct(su.Cname, SupplierProductNameTextBox.Text, double.Parse(SupplierProductPriceSellTxtBox.Text));
                    SuppliersProductDataGrid.DataSource = null;
                    SuppliersProductDataGrid.DataSource = su.category.Products;
                    SupplierProductNameTextBox.Text = "";
                    SupplierProductPriceSellTxtBox.Text = "";


                    DataTable tb = new DataTable();
                    tb.Columns.Add("Product Name", typeof(string));
                    tb.Columns.Add("Product Price", typeof(int));
                    foreach (Product item in su.category.Products)
                    {
                        tb.Rows.Add(new object[] { item.Name, item.PriceForSell });
                    }

                    SuppliersProductDataGrid.DataSource = tb;
                }
                else
                {
                    MessageBox.Show("please enter valid data");
                }
            }
            else
            {
                MessageBox.Show("Invalid Operation !");
            }
            //SuppliersProductDataGrid.Columns.AddRange();

        }


        private void CashierAddButton_Click(object sender, EventArgs e)
        {
            List<string> msg = new List<string>();
            if (!validation.IsValidPhone(CashierPhoneNumber.Text))
            {
                msg.Add("Phone");
            }
            if (!validation.IsValidUserName(CashierUsrNameTxtBox.Text))
            {
                msg.Add("Username");
            }
            if (!validation.IsValidSalary(CashierSalaryTxtBox.Text))
            {
                msg.Add("Salary");
            }
            if (!validation.IsName(CashierNameTxtBox.Text))
            {
                msg.Add("Name");
            }
            if (CashierPwdTxtBox.Text == "")
            {
                msg.Add("Password");
            }
            if (msg.Count == 0)
            {
                Cashier cashier = new Cashier(CashierNameTxtBox.Text, CashierUsrNameTxtBox.Text, CashierPwdTxtBox.Text, (int)CahshierWorkingHourNumeric.Value, CashierPhoneNumber.Text, float.Parse(CashierSalaryTxtBox.Text));
                CashierIdTxtBox.Text = cashier.ID.ToString();
                Market.market.Cashiers.Add(cashier);
                CashierDataGridView.DataSource = null;
                CashierDataGridView.DataSource = Market.market.Cashiers;
            }
            else
            {
                AlertError(msg);
            }
            empty();
        }
        private void empty()
        {
            CashierIdTxtBox.Text = "";
            CashierSalaryTxtBox.Text = "";
            CashierPhoneNumber.Text = "";
            CashierNameTxtBox.Text = "";
            CashierPwdTxtBox.Text = "";
            CashierUsrNameTxtBox.Text = "";
        }
        private void AlertError(List<string> Msg)
        {
            string msg = "";
            for (int i = 0; i < Msg.Count; i++)
            {
                if (i < Msg.Count - 2)
                    msg += Msg[i] + " , ";
                else if (i < Msg.Count - 1)
                    msg += Msg[i] + " and ";
                else
                    msg += Msg[i];
            }
            if (Msg.Count == 1)
                MessageBox.Show("There is a problem with " + Msg[0] + " input", "Warning Message");
            else
                MessageBox.Show("There is a problem with " + msg + " inputs", "Warning Message");

        }

        private void SupplierAddSupBtn_Click(object sender, EventArgs e)
        {
            Category category = Market.market.Categories.Find(x => x.Name == SupplierCategoryTxtBox.Text);
            if (validation.IsName(SupplierNameTxtBox.Text) && SupplierCategoryTxtBox.Text != "" &&
                validation.IsValidPhone(SupplierPhoneTxtBox.Text) && SupplierIDTxtBox.Text == "" && category != null)
            {
                Supplier supplier = new Supplier(SupplierNameTxtBox.Text, SupplierPhoneTxtBox.Text, SupplierCategoryTxtBox.Text);
                supplier.category = new Category(category.Name, category.ID);//creating new category to have a list of product wit the same Id of an existing category in 
                //market categories list
                SupplierIDTxtBox.Text = supplier.ID.ToString();
                Market.market.Suppliers.Add(supplier);
                SupplierDataGrid.DataSource = null;
                SupplierDataGrid.DataSource = Market.market.Suppliers;
                SelectedSupplierRow = 0;

            }
            else
            {
                MessageBox.Show(" please enter valid data");
            }
            SupplierNameTxtBox.Text = "";
            SupplierPhoneTxtBox.Text = "";
            SupplierCategoryTxtBox.Text = "";
            SupplierIDTxtBox.Text = "";
        }

        private void MinimixeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SupplierDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedSupplierRow = e.RowIndex;


            if (SupplierDataGrid.DataSource != null  && SelectedSupplierRow>=0)
            {
                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier su = Market.market.Suppliers.Find(x => x.ID.ToString() == Selected_SupplierID);

                SupplierNameTxtBox.Text = su.Name;
                SupplierPhoneTxtBox.Text = su.PhoneNumber;
                SupplierCategoryTxtBox.Text = su.Cname;
                SupplierIDTxtBox.Text = su.ID.ToString();
                DataTable tb = new DataTable();
                tb.Columns.Add("Product Name", typeof(string));
                tb.Columns.Add("Product Price", typeof(int));
                if (su.category.Products != null)
                    foreach (Product item in su.category.Products)
                    {
                        tb.Rows.Add(new object[] { item.Name, item.PriceForSell });
                    }

                SuppliersProductDataGrid.DataSource = tb;

            }

        }

        private void CategoryAddBtn_Click(object sender, EventArgs e)
        {
            if (CategorNameTxtBox.Text != "")
            {
                string catName = CategorNameTxtBox.Text;
                CategorNameTxtBox.Text = "";
                bool flagCatExist = false;
                foreach (Category category in Market.market.Categories)
                {
                    if (category.Name == catName)
                    {
                        flagCatExist = true;
                    }
                }

                if (!flagCatExist)
                {
                    Category category = new Category(catName);
                    Manager.manager.AddCategory(category);
                }
                CategoryGridView.DataSource = null;
                CategoryGridView.DataSource = Market.market.Categories;
            }
            else
            {
                MessageBox.Show("not valid data");
            }
        }

        private void BillCreateBtn_Click(object sender, EventArgs e)
        {
            if (BillSupplierNameComBox.Text != "" && BillCategoryNameTxtBox.Text != "")
            {
                Supplier supplier1 = null;
                List<string> list = new List<string>();
                foreach (Supplier supplier in Market.market.Suppliers)
                    if (BillSupplierIdTxtBox.Text == supplier.ID.ToString())
                    {
                        supplier1 = supplier;
                        break;
                    }
                foreach (Product product in supplier1.category.Products)
                {
                    list.Add(product.Name);
                }

                Manager.manager.CreateBill(supplier1);
                BilliDTxtBox.Text = supplier1.bills[supplier1.bills.Count - 1].BillId.ToString();
                BillProductNameComBox.DataSource = null;
                BillProductNameComBox.DataSource = list;
                State(false, true);

            }
            else
            {
                MessageBox.Show("Please, Enter the Data of the supplier to create a bill for him !!");

            }

        }

        private void BillSupplierNameComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Supplier supplier in Market.market.Suppliers)
                if (BillSupplierNameComBox.GetItemText(BillSupplierNameComBox.SelectedItem) == supplier.Name)
                {
                    BillSupplierIdTxtBox.Text = supplier.ID.ToString();
                    BillCategoryNameTxtBox.Text = supplier.Cname;
                }
        }

        private void BillProductNameComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = Market.market.Categories.Find(x => x.Name == BillCategoryNameTxtBox.Text);
            if (category != null)
            {
                foreach (Product product in category.Products)
                    if (BillProductNameComBox.Text == product.Name)
                    {
                        BillPriceOfSellTxtBox.Text = product.PriceForSell.ToString();
                    }
            }
        }

        private void BillAddProductBtn_Click(object sender, EventArgs e)
        {
            double priceBuy;
            bool sucess = double.TryParse((BillPriceForBuyTxtBox.Text), out priceBuy);
            if (validation.IsValidPrice(BillPriceForBuyTxtBox.Text) && priceBuy > double.Parse(BillPriceOfSellTxtBox.Text))
            {
                Supplier supplier1 = Market.market.Suppliers.Find(x => x.ID.ToString() == BillSupplierIdTxtBox.Text);
                Supplier_Bill SB = supplier1.bills[supplier1.bills.Count - 1];
                ProductNeed product = new ProductNeed();
                bool ProductExist = false;
                foreach (ProductNeed item in SB.Supplier_Product)
                {
                    if (item.Product.Name == BillProductNameComBox.Text)
                    {
                        ProductExist = true;
                        product = item;
                    }
                }
                if (ProductExist)
                {
                    if(product.Product.PriceForBuy == priceBuy)
                    {
                        product.AmountNeeded = (int)(BillSupplierAmountNumeric.Value);
                        product.Product.PriceForBuy = int.Parse(BillPriceForBuyTxtBox.Text);
                        product.Product.ExpireDate = BillExpiredDateDateTimePicker.Value;

                        Manager.manager.AddSupplierProduct(supplier1, product);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Product Name", typeof(string));
                        dt.Columns.Add("Ammount", typeof(int));
                        dt.Columns.Add("Price for Sell", typeof(int));
                        dt.Columns.Add("Price fof Buy", typeof(string));
                        dt.Columns.Add("Expired Date", typeof(DateTime));

                        int lastBillIndex = supplier1.bills.Count - 1;
                        // check of this product exist in supplier bill then add new amount
                        foreach (ProductNeed item in supplier1.bills[lastBillIndex].Supplier_Product)
                        {
                            dt.Rows.Add(new object[] { item.Product.Name, item.AmountNeeded, item.Product.PriceForSell, item.Product.PriceForBuy, item.Product.ExpireDate });
                        }
                        BillDataGridViews.DataSource = null;
                        BillDataGridViews.DataSource = dt;
                        BillTotalPricTxtBox.Text = supplier1.bills[lastBillIndex].TotalPrice.ToString();
                    }
                    else
                    {
                        MessageBox.Show("you enter invalid Price Buy Price must be same price");
                    }
                }
                else
                {
                   Category cat = Market.market.Categories.Find(x=>x.Name==BillCategoryNameTxtBox.Text);
                    Product pro = cat.Products.Find(x => x.Name == BillProductNameComBox.Text);
                    product.AmountNeeded = (int)(BillSupplierAmountNumeric.Value);
                    product.Product = new Product(pro.ID,priceBuy, double.Parse(BillPriceOfSellTxtBox.Text),(int)BillSupplierAmountNumeric.Value,pro.Name,BillExpiredDateDateTimePicker.Value,cat.Name);
                    Manager.manager.AddSupplierProduct(supplier1, product);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Product Name", typeof(string));
                    dt.Columns.Add("Ammount", typeof(int));
                    dt.Columns.Add("Price for Sell", typeof(int));
                    dt.Columns.Add("Price fof Buy", typeof(string));
                    dt.Columns.Add("Expired Date", typeof(DateTime));

                    int lastBillIndex = supplier1.bills.Count - 1;
                    // check of this product exist in supplier bill then add new amount
                    foreach (ProductNeed item in supplier1.bills[lastBillIndex].Supplier_Product)
                    {
                        dt.Rows.Add(new object[] { item.Product.Name, item.AmountNeeded, item.Product.PriceForSell, item.Product.PriceForBuy, item.Product.ExpireDate });
                    }
                    BillDataGridViews.DataSource = null;
                    BillDataGridViews.DataSource = dt;
                    BillTotalPricTxtBox.Text = supplier1.bills[lastBillIndex].TotalPrice.ToString();
                }
            }
            else
            {
                MessageBox.Show("you enter invalid Price Buy Price must be more than sell price to make profit");
            }

       
        }

        private void BillPayBtn_Click(object sender, EventArgs e)
        {
            Supplier sup = null;
            foreach (Supplier item in Market.market.Suppliers)
            {
                if (item.ID.ToString() == BillSupplierIdTxtBox.Text)
                {
                    sup = item;
                }
            }
            int lastBillIndex = sup.bills.Count - 1;
            Manager.manager.pay(sup);
            MessageBox.Show($"THE Current Budget equal {Market.market.Budget}\nThe Total Price equals {sup.bills[lastBillIndex].TotalPrice}");
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            State(true, false);
        }

       
        private void CashierDeleteButton_Click(object sender, EventArgs e)
        {
            if (CashierDataGridView.DataSource != null && SelectedCashierRow >= 0)
            {
                string Selected_CashierID = CashierDataGridView.Rows[SelectedCashierRow].Cells["ID"].Value.ToString();
                Cashier cas = Market.market.Cashiers.Find(x => x.ID.ToString() == Selected_CashierID);

                Manager.manager.DeleteCashier(cas);
                CashierDataGridView.DataSource = null;
                CashierDataGridView.DataSource = Market.market.Cashiers;
               
                //Manager.manager.DeleteCashier();
            }
            else
            {
                MessageBox.Show("Not Valid Operation !!!");
            }
            SelectedCashierRow = -1;
        }
        private void State(bool firstPart, bool SecondPart)
        {



            // Create Bill Part
            BillSupplierNameComBox.Enabled = firstPart;
            BillSupplierIdTxtBox.Enabled = firstPart;
            BillCategoryNameTxtBox.Enabled = firstPart;
            BillCreateBtn.Enabled = firstPart;

            // Adding Product to Bill
            BillProductNameComBox.Enabled = SecondPart;
            BillSupplierAmountNumeric.Enabled = SecondPart;
            BillAddProductBtn.Enabled = SecondPart;
            BillPriceOfSellTxtBox.Enabled = SecondPart;
            BillPriceForBuyTxtBox.Enabled = SecondPart;
            BiilEditProductBtn.Enabled = SecondPart;
            BillExpiredDateDateTimePicker.Enabled = SecondPart;
            BilliDTxtBox.Enabled = SecondPart;
            BillDeleteProductBtn.Enabled = SecondPart;
            BillTotalPricTxtBox.Enabled = SecondPart;
            BillPayBtn.Enabled = SecondPart;
            BillDataGridViews.Enabled = SecondPart;



        }



        private void SupplierEditSupBtn_Click(object sender, EventArgs e)
        {
            if (SupplierDataGrid.DataSource != null && SelectedSupplierRow >= 0)//make sure list has category and thier is a selected row
            {

                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier supplier1 = Market.market.Suppliers.Find(x => x.ID.ToString() == Selected_SupplierID);
                Category category = Market.market.Categories.Find(x => x.Name == SupplierCategoryTxtBox.Text);
                if (supplier1.Cname != SupplierCategoryTxtBox.Text)
                {
                    //if this category is exist in our category list or not
                    if (category != null)
                    {
                        if (validation.IsName(SupplierNameTxtBox.Text) && validation.IsValidPhone(SupplierPhoneTxtBox.Text))
                        {
                            //remove every product in our category list
                            for (int i = 0; i < supplier1.category.Products.Count; i++)
                            {
                                string categoryName = supplier1.category.Products[i].category;
                                string productName = supplier1.category.Products[i].Name;
                                double priceSellProduct = supplier1.category.Products[i].PriceForSell;
                                supplier1.RemoveProduct(categoryName, productName, priceSellProduct);
                            }
                            Category category1 = new Category(SupplierCategoryTxtBox.Text, category.ID);
                            supplier1.Name = SupplierNameTxtBox.Text;
                            supplier1.PhoneNumber = SupplierPhoneTxtBox.Text;
                            supplier1.category = category1;
                        }
                        else
                        {
                            MessageBox.Show("you entered an invalid Data");
                        }

                    }
                    else
                    {
                        MessageBox.Show("you entered an invalid category name try again");

                    }
                }

                else
                {
                    supplier1.Name = SupplierNameTxtBox.Text;
                    supplier1.PhoneNumber = SupplierPhoneTxtBox.Text;

                }
                SupplierNameTxtBox.Text = "";
                SupplierPhoneTxtBox.Text = "";
                SupplierCategoryTxtBox.Text = "";
                SupplierIDTxtBox.Text = "";
                SupplierDataGrid.DataSource = null;
                SupplierDataGrid.DataSource = Market.market.Suppliers;
            }
        }

        private void SupplierDeleteSupBtn_Click(object sender, EventArgs e)
        {
            int Id = 0;
            bool supplierIsexist = false;
            supplierIsexist = int.TryParse((SupplierIDTxtBox.Text), out Id);
            Supplier supplier = Market.market.Suppliers.Find(x => x.ID == Id);
            if (supplierIsexist)
            {
                Manager.manager.DeleteSupplier(supplier);
                SupplierDataGrid.DataSource = null;
                SupplierDataGrid.DataSource = Market.market.Suppliers;
                SuppliersProductDataGrid.DataSource = null;
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            SupplierNameTxtBox.Text = "";
            SupplierPhoneTxtBox.Text = "";
            SupplierCategoryTxtBox.Text = "";
            SupplierIDTxtBox.Text = "";
        }

        private void SupplierDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int selectSuppProductList = -1;
        private void SupplierEditProductBtn_Click(object sender, EventArgs e)
        {
            if (SelectedSupplierRow >=0 && selectSuppProductList >= 0 && SuppliersProductDataGrid.DataSource != null && SuppliersProductDataGrid.DataSource!=null)
            {
                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier supplier1 = Market.market.Suppliers.Find(x => x.ID.ToString() == Selected_SupplierID);
                Category category = Market.market.Categories.Find(x => x.Name == supplier1.Cname);
                Product product = category.Products.Find(x => x.Name == SuppliersProductDataGrid.Rows[selectSuppProductList].Cells[0].Value.ToString());
                double price;
                bool sucess = double.TryParse(SupplierProductPriceSellTxtBox.Text, out price);
                if (sucess && validation.IsValidPrice(SupplierProductPriceSellTxtBox.Text))
                {
                    product.PriceForSell = price;
                    product.Name = SupplierProductNameTextBox.Text;//validate name
                    Product pc = category.Products.Find(x => x.Name == product.Name);
                    pc.PriceForSell = price;
                    pc = supplier1.category.Products.Find(x => x.Name == product.Name);
                    pc.PriceForSell = price;

                    DataTable tb = new DataTable();
                    tb.Columns.Add("Product Name", typeof(string));
                    tb.Columns.Add("Product Price", typeof(int));
                    foreach (Product item in supplier1.category.Products)
                    {
                        tb.Rows.Add(new object[] { item.Name, item.PriceForSell });
                    }

                    SuppliersProductDataGrid.DataSource = tb;
                }
                else
                {
                    MessageBox.Show("please enter valid price");
                    SupplierProductNameTextBox.Text = "";
                    SupplierProductPriceSellTxtBox.Text = "";
                    return;
                }

            }
          
            selectSuppProductList = -1;


        }

        private void SuppliersProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectSuppProductList = e.RowIndex;

            if (e.RowIndex >= 0 && SuppliersProductDataGrid.DataSource != null)
            {
                string proName = SuppliersProductDataGrid.Rows[selectSuppProductList].Cells[0].Value.ToString();
                Product product = null;
                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier supplier = Market.market.Suppliers.Find(x => x.ID.ToString() == Selected_SupplierID);
                product = supplier.category.Products.Find(x => x.Name == proName);
                SupplierProductNameTextBox.Text = product.Name;
                SupplierProductPriceSellTxtBox.Text = product.PriceForSell.ToString();//validate name
            }

        }

        private void SupplierDeleteProductBtn_Click(object sender, EventArgs e)
        {
            if ( SelectedSupplierRow>=0 && selectSuppProductList >= 0 && SuppliersProductDataGrid.DataSource != null && SuppliersProductDataGrid.DataSource!=null)
            {
                string Selected_SupplierID = SupplierDataGrid.Rows[SelectedSupplierRow].Cells[1].Value.ToString();
                Supplier supplier1 = Market.market.Suppliers.Find(x => x.ID.ToString() == Selected_SupplierID);
                Product product = supplier1.category.Products.Find(x => x.Name == SuppliersProductDataGrid.Rows[selectSuppProductList].Cells[0].Value.ToString());
                bool sucess = supplier1.RemoveProduct(supplier1.Cname, product.Name, product.PriceForSell);
                DataTable tb = new DataTable();
                tb.Columns.Add("Product Name", typeof(string));
                tb.Columns.Add("Product Price", typeof(int));
                foreach (Product item in supplier1.category.Products)
                {
                    tb.Rows.Add(new object[] { item.Name, item.PriceForSell });
                }

                SuppliersProductDataGrid.DataSource = tb;
                if (!sucess)
                {
                    MessageBox.Show("not found");
                }
            }
            else
            {
                MessageBox.Show("couldn't delete empty Item");
            }
          
            selectSuppProductList = -1;

        }
        int selecttedCategorRow = -1;
        private void CategoryEditBtn_Click(object sender, EventArgs e)
        {
            if (CategoryGridView.DataSource != null && selecttedCategorRow >= 0)
            {
                Category cat = Market.market.Categories.Find(x => x.Name == CategoryGridView.Rows[selecttedCategorRow].Cells[0].Value.ToString());
                Category search = Market.market.Categories.Find(x => x.Name == CategorNameTxtBox.Text);
                if (search != null)
                {
                    MessageBox.Show("this category is already in");
                }
                else if(validation.IsValidUserName(CategorNameTxtBox.Text))
                {
                    cat.Name = CategorNameTxtBox.Text;
                    foreach (Supplier supplier in Market.market.Suppliers)
                    {
                        supplier.category.Name = CategorNameTxtBox.Text;
                        foreach (Product product in supplier.category.Products)
                        {
                            product.category = CategorNameTxtBox.Text;
                        }
                    }
                    CategoryGridView.DataSource = null;
                    CategoryGridView.DataSource = Market.market.Categories;
                }


            }
        }

        private void CategoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecttedCategorRow = e.RowIndex;
            if (CategoryGridView.DataSource != null)
            {
                CategorNameTxtBox.Text = CategoryGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            else
            {
                MessageBox.Show("category list is Empty");
            }
        }

        private void CategoryDeleteBtn_Click(object sender, EventArgs e)
        {
            if (CategoryGridView.DataSource != null && selecttedCategorRow >= 0)
            {
                Category cat = Market.market.Categories.Find(x => x.Name == CategoryGridView.Rows[selecttedCategorRow].Cells[0].Value.ToString());

                Supplier supplier = Market.market.Suppliers.Find(x => x.Cname == cat.Name);
                Market.market.Suppliers.Remove(supplier);
                Market.market.Categories.Remove(cat);
                CategorNameTxtBox.Text = "";
                CategoryGridView.DataSource = null;
                CategoryGridView.DataSource = Market.market.Categories;

            }
        }
        private DataTable SalesReport()
        {
            List<Supplier_Bill> ToView = new List<Supplier_Bill>();
            foreach (var item in Market.market.Suppliers)
            {
                foreach (var item1 in item.bills)
                {
                    if (item1.CreatedTime >= ReportStartDateTimePicer.Value && item1.CreatedTime <= ReportEndDateTimePicker.Value)
                    {
                        ToView.Add(item1);
                    }
                }
            }
            // List<ProductNeed> PV = new List<ProductNeed>();
            DataTable tb = new DataTable();
            tb.Columns.Add("Product Name", typeof(string));
            tb.Columns.Add("Amount", typeof(string));
            tb.Columns.Add("Price For Sell", typeof(string));
            tb.Columns.Add("Price For Buy", typeof(string));
            tb.Columns.Add("Expired Date", typeof(string));
            tb.Columns.Add("Category", typeof(string));
            foreach (var item in ToView)
            {
                foreach (var item1 in item.Supplier_Product)
                {
                    //PV.Add(item1);
                    tb.Rows.Add(item1.Product.Name, item1.AmountNeeded, item1.Product.PriceForSell, item1.Product.PriceForBuy, item1.Product.ExpireDate.ToString("dd/MM/yyyy"), item1.Product.category);
                }
            }

            return tb;

        }

        private DataTable PurchasesReport()
        {
            List<Customer_Bill> ToView = new List<Customer_Bill>();
            foreach (var item in Market.market.Customers)
            {
                foreach (var item1 in item.bills)
                {
                    if (item1.CreatedTime >= ReportStartDateTimePicer.Value && item1.CreatedTime <= ReportEndDateTimePicker.Value)
                    {
                        ToView.Add(item1);
                    }
                }
            }
            DataTable tb = new DataTable();
            tb.Columns.Add("Product Name", typeof(string));
            tb.Columns.Add("Amount", typeof(string));
            tb.Columns.Add("Price For Buy", typeof(string));
            tb.Columns.Add("Expired Date", typeof(string));
            tb.Columns.Add("Category", typeof(string));
            foreach (var item in ToView)
            {
                foreach (var item1 in item.Customer_Product)
                {

                    tb.Rows.Add(item1.Product.Name, item1.AmountNeeded, item1.Product.PriceForBuy, item1.Product.ExpireDate.ToString("dd/MM/yyyy"), item1.Product.category);
                }
            }

            return tb;

        }

        private void CategoryGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (Market.market.Categories.Count > 0)
            {
                selecttedCategorRow = Market.market.Categories.Count - 1;
            }
            else
            {
                selecttedCategorRow = -1;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Supplier sup = Market.market.Suppliers.Find(x => x.ID.ToString() == BillSupplierIdTxtBox.Text);
            Supplier_Bill Sbill = sup.bills[sup.bills.Count - 1];
            e.Graphics.DrawString("Happiness Market's Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(180, 20));
            e.Graphics.DrawString("Supplier Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(275, 50));
            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________", new Font("Snap ITC", 10, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("Date : " + Sbill.CreatedTime.ToString("MM/dd/yyyy h:mm tt"), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 130));
            e.Graphics.DrawString("Number of bill for Supllier : " + Sbill.BillId, new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 130));
            e.Graphics.DrawString("Supplier Name : " + sup.Name, new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("Manager : Admin", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 160));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 220));
            e.Graphics.DrawString("Product Name", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString("Amount", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(280, 240));
            e.Graphics.DrawString("Price For Sell", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(380, 240));
            e.Graphics.DrawString("Price For Buy", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(530, 240));
            e.Graphics.DrawString("Expired Date", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(680, 240));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 260));
            int i = 0; double PrintTotalPrice = 0;
            long TotalAmount = 0;
            for (; i < Sbill.Supplier_Product.Count; i++)
            {
                PrintTotalPrice += Sbill.Supplier_Product[i].AmountNeeded* Sbill.Supplier_Product[i].Product.PriceForSell;
                TotalAmount += Sbill.Supplier_Product[i].AmountNeeded;
                e.Graphics.DrawString(Sbill.Supplier_Product[i].Product.Name, new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 280 + (i * 20)));
                e.Graphics.DrawString(Sbill.Supplier_Product[i].AmountNeeded.ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(280, 280 + (i * 20)));
                e.Graphics.DrawString(Sbill.Supplier_Product[i].Product.PriceForSell.ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(380, 280 + (i * 20)));
                e.Graphics.DrawString(Sbill.Supplier_Product[i].Product.PriceForBuy.ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(530, 280 + (i * 20)));
                e.Graphics.DrawString(Sbill.Supplier_Product[i].Product.ExpireDate.ToString("MM/dd/yyyy"), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(680, 280 + (i * 20)));
            }
            int followUp = i;
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 280 + (followUp++ * 20)));
            e.Graphics.DrawString("Summary", new Font("Snap ITC", 18, FontStyle.Regular), Brushes.Black, new Point(650, 280 + (followUp++ * 20)));



            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total amount : " + TotalAmount, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total Price : " + PrintTotalPrice, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));
        }

        private void ReportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportTypeComboBox.Text == "Sales" || ReportTypeComboBox.Text == "Purchases")
            {
                ReportStartDateTimePicer.Enabled = true;
                ReportEndDateTimePicker.Enabled = true;
            }
        }

        private void ReportCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        int SelectedRowFromBill = -1;
        private void BiilEditProductBtn_Click(object sender, EventArgs e)
        {
            string SupplierID = BillSupplierIdTxtBox.Text;
            Supplier sup = null;
            foreach (Supplier item in Market.market.Suppliers)
            {
                if (item.ID.ToString() == SupplierID)
                {
                    sup = item;
                }
            }
            if (BillDataGridViews.DataSource != null && SelectedRowFromBill >= 0)
            {
                if (validation.IsValidPrice(BillPriceForBuyTxtBox.Text) && int.Parse(BillPriceForBuyTxtBox.Text) > int.Parse(BillPriceOfSellTxtBox.Text))
                {
                    ProductNeed RProduct = sup.bills[sup.bills.Count - 1].Supplier_Product.Find(x => x.Product.Name == BillProductNameComBox.Text);
                    RProduct.Product.Name = BillProductNameComBox.Text;
                    RProduct.AmountNeeded = (int)BillSupplierAmountNumeric.Value;
                    RProduct.Product.PriceForBuy = int.Parse(BillPriceForBuyTxtBox.Text);
                    RProduct.Product.PriceForSell = int.Parse(BillPriceOfSellTxtBox.Text);
                    RProduct.Product.ExpireDate = BillExpiredDateDateTimePicker.Value;
                }
                else
                {
                    MessageBox.Show("you enter invalid Price Buy Price must be more than sell price to make profit");
                }
                BillPriceForBuyTxtBox.Text = "";
                DataTable dt = new DataTable();
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Ammount", typeof(int));
                dt.Columns.Add("Price for Sell", typeof(int));
                dt.Columns.Add("Price fof Buy", typeof(string));
                dt.Columns.Add("Expired Date", typeof(DateTime));

                int lastBillIndex = sup.bills.Count - 1;
                // check of this product exist in supplier bill then add new amount
                foreach (ProductNeed item in sup.bills[lastBillIndex].Supplier_Product)
                {
                    dt.Rows.Add(new object[] { item.Product.Name, item.AmountNeeded, item.Product.PriceForSell, item.Product.PriceForBuy, item.Product.ExpireDate });
                }
                BillDataGridViews.DataSource = null;
                BillDataGridViews.DataSource = dt;
                BillTotalPricTxtBox.Text = sup.bills[lastBillIndex].TotalPrice.ToString();
                SelectedRowFromBill = -1;
            }
            else
            {
                MessageBox.Show("Please Select the row you want to edit !!!!");
            }
            
        }

        private void CashierEditButton_Click(object sender, EventArgs e)
        {
            
            if (CashierDataGridView.DataSource != null && SelectedCashierRow >= 0)
            {
               
                Cashier cashier = Market.market.Cashiers.Find(x => x.ID.ToString() == CashierIdTxtBox.Text);

                List<string> msg = new List<string>();
                if (!validation.IsValidPhone(CashierPhoneNumber.Text))
                {
                    msg.Add("Phone");
                }
                
                if (!validation.IsValidSalary(CashierSalaryTxtBox.Text))
                {
                    msg.Add("Salary");
                }
                if (!validation.IsName(CashierNameTxtBox.Text))
                {
                    msg.Add("Name");
                }
                if (CashierPwdTxtBox.Text == "")
                {
                    msg.Add("Password");
                }
                if (msg.Count == 0)
                {
                    
                    cashier.Name = CashierNameTxtBox.Text;
                    cashier.Phone = CashierPhoneNumber.Text;
                    cashier.Salary = int.Parse(CashierSalaryTxtBox.Text);
                    cashier.WorkingHours = int.Parse(CahshierWorkingHourNumeric.Value.ToString());
                    cashier.Username = CashierUsrNameTxtBox.Text;
                    cashier.Password = CashierPwdTxtBox.Text;
                    CashierDataGridView.DataSource = null;
                    CashierDataGridView.DataSource = Market.market.Cashiers;
                    
                }
                else
                {
                    AlertError(msg);
                }
                empty();
                CashierUsrNameTxtBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Not Valid Operation !!!");
            }
            SelectedCashierRow = -1;
        }

        private void BillDataGridViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowFromBill = e.RowIndex;
            if (BillDataGridViews.DataSource != null)
            {
                String name = (BillDataGridViews.Rows[e.RowIndex].Cells[0].Value.ToString());
                Supplier supplier = Market.market.Suppliers.Find(x => x.ID.ToString() == BillSupplierIdTxtBox.Text);
                Supplier_Bill supplier_bill = supplier.bills[supplier.bills.Count - 1];
                ProductNeed product = supplier_bill.Supplier_Product.Find(x => x.Product.Name == name);
                BillProductNameComBox.Text = product.Product.Name;
                BillPriceForBuyTxtBox.Text = product.Product.PriceForBuy.ToString();
                BillPriceOfSellTxtBox.Text = product.Product.PriceForSell.ToString();
                BillSupplierAmountNumeric.Value = product.AmountNeeded;
                BillExpiredDateDateTimePicker.Value = product.Product.ExpireDate;
            }
            else
            {
                MessageBox.Show("Your List is already empty !!");
            }
        }

        private void BillDeleteProductBtn_Click(object sender, EventArgs e)
        {
           
           
            if(BillDataGridViews.DataSource != null && SelectedRowFromBill >= 0)
            {
                int id = int.Parse(BillSupplierIdTxtBox.Text);
                Supplier supplier = Market.market.Suppliers.Find(x => x.ID == id);
                Supplier_Bill supplier_bil = supplier.bills[supplier.bills.Count - 1];
                ProductNeed product = supplier_bil.Supplier_Product.Find(x => x.Product.Name == BillDataGridViews.Rows[SelectedRowFromBill].Cells[0].Value.ToString());
                Manager.manager.RemoveSupplierProduct(supplier,product);
                SelectedRowFromBill = -1;
                BillPriceForBuyTxtBox.Text = "";
                DataTable dt = new DataTable();
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Ammount", typeof(int));
                dt.Columns.Add("Price for Sell", typeof(int));
                dt.Columns.Add("Price fof Buy", typeof(string));
                dt.Columns.Add("Expired Date", typeof(DateTime));

                int lastBillIndex = supplier.bills.Count - 1;
                // check of this product exist in supplier bill then add new amount
                foreach (ProductNeed item in supplier.bills[lastBillIndex].Supplier_Product)
                {
                    dt.Rows.Add(new object[] { item.Product.Name, item.AmountNeeded, item.Product.PriceForSell, item.Product.PriceForBuy, item.Product.ExpireDate });
                }
                BillDataGridViews.DataSource = null;
                BillDataGridViews.DataSource = dt;
                BillTotalPricTxtBox.Text = supplier.bills[lastBillIndex].TotalPrice.ToString();
            }
            else
            {
                MessageBox.Show("invalid data");
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataTable Tb = SalesReport();
            e.Graphics.DrawString("Happiness Market's Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(180, 20));
            e.Graphics.DrawString("Sales Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(275, 50));
            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________", new Font("Snap ITC", 10, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt"), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 130));
            e.Graphics.DrawString("Number of bill for Supllier : ", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 130));
            e.Graphics.DrawString("Supplier Name : ", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("Manager : Admin", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 160));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 220));
            e.Graphics.DrawString("Product Name", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString("Amount", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(150, 240));
            e.Graphics.DrawString("Selling Price", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(250, 240));
            e.Graphics.DrawString("Bought Price", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 240));
            e.Graphics.DrawString("Expired Date", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(590, 240));
            e.Graphics.DrawString("Category", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(720, 240));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 260));
            int i = 0; long PriceforAdmin = 0, TotalAmount = 0;
            foreach (DataRow r in Tb.Rows)
            {


                e.Graphics.DrawString(r[0].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 280 + (i * 20)));
                e.Graphics.DrawString(r[1].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(200, 280 + (i * 20)));
                e.Graphics.DrawString(r[2].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(300, 280 + (i * 20)));
                e.Graphics.DrawString(r[3].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 280 + (i * 20)));
                e.Graphics.DrawString(r[4].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(590, 280 + (i * 20)));
                e.Graphics.DrawString(r[5].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(720, 280 + (i * 20)));
                TotalAmount += int.Parse(r[1].ToString());
                PriceforAdmin += int.Parse(r[2].ToString()) * (int.Parse(r[1].ToString()));
                i++;



            }
            int followUp = i;
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 280 + (followUp++ * 20)));
            e.Graphics.DrawString("Summary", new Font("Snap ITC", 18, FontStyle.Regular), Brushes.Black, new Point(650, 280 + (followUp++ * 20)));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total amount : " + TotalAmount, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total Price : " + PriceforAdmin, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataTable Tb = PurchasesReport();
            e.Graphics.DrawString("Happiness Market's Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(180, 20));
            e.Graphics.DrawString("Sales Invoice", new Font("Snap ITC", 20, FontStyle.Bold), Brushes.Black, new Point(275, 50));
            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________", new Font("Snap ITC", 10, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt"), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 130));
            e.Graphics.DrawString("Number of bill for Supllier : ", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 130));
            e.Graphics.DrawString("Supplier Name : ", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("Manager : Admin", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 160));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 220));
            e.Graphics.DrawString("Product Name", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString("Amount", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(200, 240));
            e.Graphics.DrawString("Price For Buy", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(300, 240));
            e.Graphics.DrawString("Expired Date", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 240));
            e.Graphics.DrawString("Category", new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(600, 240));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 260));
            int i = 0; long TotalPrice = 0, TotalAmount = 0;
            foreach (DataRow r in Tb.Rows)
            {

                e.Graphics.DrawString(r[0].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(50, 280 + (i * 20)));
                e.Graphics.DrawString(r[1].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(200, 280 + (i * 20)));
                e.Graphics.DrawString(r[2].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(300, 280 + (i * 20)));
                e.Graphics.DrawString(r[3].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(450, 280 + (i * 20)));
                e.Graphics.DrawString(r[4].ToString(), new Font("Snap ITC", 11, FontStyle.Regular), Brushes.Black, new Point(600, 280 + (i * 20)));

                TotalAmount += int.Parse(r[1].ToString());
                TotalPrice += int.Parse(r[2].ToString()) * (int.Parse(r[1].ToString()));
                i++;



            }
            int followUp = i;
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(40, 280 + (followUp++ * 20)));
            e.Graphics.DrawString("Summary", new Font("Snap ITC", 18, FontStyle.Regular), Brushes.Black, new Point(650, 280 + (followUp++ * 20)));

            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total amount : " + TotalAmount, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("Total Price : " + TotalPrice, new Font("Snap ITC", 13, FontStyle.Regular), Brushes.Black, new Point(630, 290 + (followUp++ * 20)));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - -", new Font("Snap ITC", 10, FontStyle.Regular), Brushes.Black, new Point(620, 290 + (followUp++ * 20)));

        }

        private void ReportPrintBtn_Click(object sender, EventArgs e)
        {
            if (ReportTypeComboBox.Text == "Sales")
            {
                if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                {
                    printDocument2.Print();
                }
            }
            else if (ReportTypeComboBox.Text == "Purchases")
            {
                if (printPreviewDialog3.ShowDialog() == DialogResult.OK)
                {
                    printDocument3.Print();
                }
            }

        }

        private void ReportViewBtn_Click(object sender, EventArgs e)
        {
            ReportGridView.DataSource = null;
            if (ReportTypeComboBox.Text == "Sales")
            {

                ReportGridView.DataSource = SalesReport();
            }
            else if (ReportTypeComboBox.Text == "Purchases")
            {
                ReportGridView.DataSource = PurchasesReport();
            }

        }

        private void BillDataGridViews_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void BillDataGridViews_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void printPreviewDialog3_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void CashierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CashierUsrNameTxtBox.Enabled = false;
            SelectedCashierRow = e.RowIndex;
            if (CashierDataGridView.DataSource != null && SelectedCashierRow >= 0)
            {
              
                
               
                CashierUsrNameTxtBox.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["Username"].Value.ToString();
                CashierPwdTxtBox.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["Password"].Value.ToString();
                CashierIdTxtBox.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["ID"].Value.ToString();
                CahshierWorkingHourNumeric.Value = int.Parse(CashierDataGridView.Rows[SelectedCashierRow].Cells["WorkingHours"].Value.ToString());
                CashierPhoneNumber.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["Phone"].Value.ToString();
                CashierSalaryTxtBox.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["Salary"].Value.ToString();
                CashierNameTxtBox.Text = CashierDataGridView.Rows[SelectedCashierRow].Cells["Name"].Value.ToString();
            }
        }

        private void BilliDTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}

