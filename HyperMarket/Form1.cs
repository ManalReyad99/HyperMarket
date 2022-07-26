using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text.RegularExpressions;


namespace HyperMarket
{
    public partial class CashierForm : Form
    {
        Customer customer;
        Cashier casher;
        List<Customer_Bill> BillsList = new List<Customer_Bill>();
        
        

        public CashierForm(string CashierUsername)
        {
            InitializeComponent();
            casher = Market.market.GetCasher(CashierUsername);
            casher.BillCreated += this.AddDailyBills;
            casher.CustomerAdded += this.AddCustomerList;
            if (Market.market.Customers != null)
            {
                foreach (Customer customer in Market.market.Customers)
                {
                    CBForSearchCustmoer.Items.Add(customer.Name);       
                }
            }
            if (Market.market.Categories != null)
            {
                foreach (Category category in Market.market.Categories)
                {
                    CBForSearchCategory.Items.Add(category.Name);
                }
            }

        }
        private void AddCustomerList()
        {
            CBForSearchCustmoer.Items.Add(Market.market.Customers[Market.market.Customers.Count - 1].ToString());
        }

        private void AddDailyBills(Customer_Bill customerBill)
        {

            bool ISReapeated = false;
            foreach (Customer_Bill bill in BillsList)
            {
                if (customerBill.BillId == bill.BillId)
                {
                    ISReapeated = true;
                }
            }
            if (!ISReapeated)
            {
                BillsList.Add(customerBill);
                Bills.DataSource = null;
                Bills.DataSource = BillsList; double total = 0;
                foreach (Customer_Bill bill in BillsList)
                {
                    total += bill.TotalPrice;
                }
                TotalGainedmoney.Text = total.ToString();
                NoOfBiils.Text = BillsList.Count.ToString();
            }
            else
            {
                MessageBox.Show("Invalid,The Bill Already Created");
            }


        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomerPanel_Click(object sender, EventArgs e)
        {
            CreateBillPanelData.Visible = false;
            DailyBillsDataPanel.Visible = false;
            CustomerPanelData.Visible = true;
            CustomerPanelData.AutoSize = true;
            CustomerPanel.BaseColor = Color.FromArgb(190, 227, 219);
            CreateBillPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(137, 176, 174);
        }

        private void CustomerLabel_Click(object sender, EventArgs e)
        {
            CreateBillPanelData.Visible = false;
            DailyBillsDataPanel.Visible = false;
            CustomerPanelData.Visible = true;
            CustomerPanelData.AutoSize = true;
            CustomerPanel.BaseColor = Color.FromArgb(190, 227, 219);
            CreateBillPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(137, 176, 174);
        }

        private void CreateBillPanel_Click(object sender, EventArgs e)
        {
            CreateBillPanelData.Visible = true;
            CreateBillPanelData.AutoSize = true;
            DailyBillsDataPanel.Visible = false;
            CustomerPanelData.Visible = false;
            CreateBillPanel.BaseColor = Color.FromArgb(190, 227, 219);
            CustomerPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(137, 176, 174);


        }

        private void CreateBillLabel_Click(object sender, EventArgs e)
        {
            CreateBillPanelData.Visible = true;
            CreateBillPanelData.AutoSize = true;
            DailyBillsDataPanel.Visible = false;
            CustomerPanelData.Visible = false;
            CreateBillPanel.BaseColor = Color.FromArgb(190, 227, 219);
            CustomerPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(137, 176, 174);
        }

        private void DailyBillsPanel_Click(object sender, EventArgs e)
        {
            DailyBillsDataPanel.Visible = true;
            DailyBillsDataPanel.AutoSize = true;
            CreateBillPanelData.Visible = false;
            CustomerPanelData.Visible = false;
            CreateBillPanel.BaseColor = Color.FromArgb(137, 176, 174);
            CustomerPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(190, 227, 219);

        }

        private void DailyBillsLabel_Click(object sender, EventArgs e)
        {
            DailyBillsDataPanel.Visible = true;
            DailyBillsDataPanel.AutoSize = true;
            CreateBillPanelData.Visible = false;
            CustomerPanelData.Visible = false;
            CreateBillPanel.BaseColor = Color.FromArgb(137, 176, 174);
            CustomerPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(190, 227, 219);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            CreateBillPanelData.Visible = true;
            CreateBillPanelData.AutoSize = true;
            DailyBillsDataPanel.Visible = false;
            CustomerPanelData.Visible = false;
            CreateBillPanel.BaseColor = Color.FromArgb(190, 227, 219);
            CustomerPanel.BaseColor = Color.FromArgb(137, 176, 174);
            DailyBillsPanel.BaseColor = Color.FromArgb(137, 176, 174);
        }


        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Regex RePhone = new Regex("^(011|012|010)[0-9]{8}");
            bool IsValidPhone= RePhone.IsMatch(CustomerPhone.Text);
            if ((!String.IsNullOrEmpty(CustomerName.Text))&&(!String.IsNullOrEmpty(CustomerPhone.Text)) && IsValidPhone)
            {
                customer = new Customer();
                customer.Name = CustomerName.Text;
                customer.Phone = CustomerPhone.Text;
                customer.Points = 0;
                string[] customerData = new string[] { customer.ID.ToString(), customer.Name, customer.Phone};
                var row = new ListViewItem(customerData);
                AddedCustomerData.Items.Add(row);
                casher.AddCustomer(customer);
                CustomerName.Clear();
                CustomerPhone.Clear();
                MessageBox.Show("Customer Added Successfully");
            }
            else
            {
                MessageBox.Show("Enter Valid Data");
            }
        }

        private void ClearCustormer_Click(object sender, EventArgs e)
        {

            AddedCustomerData.Items.Clear();
        }



        private void CBForSearchCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            CBForSearchProduct.Items.Clear();

            Category categoryType = casher.retCat(CBForSearchCategory.SelectedItem.ToString());
            if (categoryType != null)
            {
                foreach(Product product in categoryType.Products)
                {
                    CBForSearchProduct.Items.Add(product.Name);
                }
            }
            else
            {
                MessageBox.Show("Not Valid Data");
            }

        }

        private void ButtonForAdd_Click(object sender, EventArgs e)
        {
  
            
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
                && (CBForSearchCategory.SelectedItem != null)
                && (CBForSearchProduct.SelectedItem != null) && (CBForSearchCustmoer.SelectedItem != null))
            {
                customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
                Category category = casher.retCat(CBForSearchCategory.SelectedItem.ToString());
                Product product = category.GetProduct(CBForSearchProduct.SelectedItem.ToString());
                ProductNeed productNeed = new ProductNeed();
                productNeed.Product = product;
                productNeed.AmountNeeded = int.Parse(QuantityTxtBox.Text);

               if(!casher.AddProduct(productNeed, customer))
                {
                    MessageBox.Show("Product Not Cover");
                }

                CustomerBillGrid.DataSource = null;
                CustomerBillGrid.DataSource = customer.bills[customer.bills.Count - 1].Customer_Product;
            }
            else
            {
                MessageBox.Show("Enter Correct Data");
            }
        }

        private void CBForSearchCustmoer_SelectedValueChanged(object sender, EventArgs e)
        {
            customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
            casher.CreateBill(customer);
            ValueOfPointlbl.Text = customer.Points.ToString();


        }

        private void ButtonForEdit_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
                && (CBForSearchCategory.SelectedItem != null)
                && (CBForSearchProduct.SelectedItem != null) && (CBForSearchCustmoer.SelectedItem != null))
            {
                customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
                Category category = casher.retCat(CBForSearchCategory.SelectedItem.ToString());
                Product product = category.GetProduct(CBForSearchProduct.SelectedItem.ToString());
                ProductNeed productNeed = new ProductNeed();
                productNeed.Product = product;
                productNeed.AmountNeeded = int.Parse(QuantityTxtBox.Text);
                if(!casher.EditProduct(productNeed, customer))
                {
                    MessageBox.Show("Product Not Exist");
                }
                
                CustomerBillGrid.DataSource = null;
                CustomerBillGrid.DataSource = customer.bills[customer.bills.Count - 1].Customer_Product;
            }
            else
            {
                MessageBox.Show("Enter Correct Data");
            }
        }

        private void ButtonForDelete_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
                && (CBForSearchCategory.SelectedItem != null)
                && (CBForSearchProduct.SelectedItem != null)&& (CBForSearchCustmoer.SelectedItem != null))
            {
                customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
                Category category = casher.retCat(CBForSearchCategory.SelectedItem.ToString());
                Product product = category.GetProduct(CBForSearchProduct.SelectedItem.ToString());
                ProductNeed productNeed = new ProductNeed();
                productNeed.Product = product;
                productNeed.AmountNeeded = int.Parse(QuantityTxtBox.Text);
      
                if (!casher.DeleteProduct(productNeed, customer))
                {
                    MessageBox.Show("Product Not Exist");
                }
                CustomerBillGrid.DataSource = null;
                CustomerBillGrid.DataSource = customer.bills[customer.bills.Count - 1].Customer_Product;
            }
            else
            {
                MessageBox.Show("Enter Correct Data");
            }
        }
        private void ButtonforPay_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
     && (CBForSearchCategory.SelectedItem != null)
     && (CBForSearchProduct.SelectedItem != null) && (CBForSearchCustmoer.SelectedItem != null))
            {
            customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
            casher.pay(customer);
            TotalPriceLabel.Text = customer.bills[customer.bills.Count - 1].TotalPrice.ToString();
            ValueOfPointlbl.Text = customer.Points.ToString();
        }
            else
            {
                MessageBox.Show("Please ,Enter valid Data!");
            }

}

        private void BtnforPayWithPoints_Click(object sender, EventArgs e)
        { 
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
                && (CBForSearchCategory.SelectedItem != null)
                && (CBForSearchProduct.SelectedItem != null) && (CBForSearchCustmoer.SelectedItem != null))
            {
            customer = Market.market.GetCustomer(CBForSearchCustmoer.SelectedItem.ToString());
            casher.PayWithPoints(customer);
            TotalPriceLabel.Text = customer.bills[customer.bills.Count - 1].TotalPrice.ToString();
            ValueOfPointlbl.Text = customer.Points.ToString();
           }
            else
            {
                MessageBox.Show("Please Enter Valid Data!");
            }

}
        private void BTNForPrint_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(QuantityTxtBox.Text))
               && (CBForSearchCategory.SelectedItem != null)
               && (CBForSearchProduct.SelectedItem != null) && (CBForSearchCustmoer.SelectedItem != null))
            { 
                Customer_Bill customer_Bill = customer.bills[customer.bills.Count - 1];
            
            
             
                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "Customer Bill.pdf";

                    bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to wride data in disk" + ex.Message);
                            }

                        }

                        if (!ErrorMessage)

                        {
                            try
                            {
                                Paragraph paragraph = new Paragraph();
                                paragraph.SpacingBefore = 10;
                                paragraph.SpacingAfter = 10;
                                paragraph.Alignment = Element.ALIGN_LEFT;
                                paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                                paragraph.Add("***********************************Customer Bill***********************************\n");
                                paragraph.Add("Bill ID: " + customer_Bill.BillId + '\n');
                                paragraph.Add("Customer Name: " + customer_Bill.CustomerName + '\n');
                                paragraph.Add("Customer ID: " + customer_Bill.CustomerId + '\n');
                                paragraph.Add("Casher Name: " + customer_Bill.CashierName + '\n');
                                paragraph.Add("Casher ID: " + customer_Bill.CashierId + '\n');
                                DateTime dateTime = DateTime.Now;
                                paragraph.Add("Created Time: " + dateTime + '\n');
                                foreach (ProductNeed productNeed in customer_Bill.Customer_Product)
                                {
                                    paragraph.Add("Product Name: " + productNeed.Product.Name + '\n');
                                    paragraph.Add("Product Amount: " + productNeed.AmountNeeded + '\n');

                                }
                                paragraph.Add("***********************************************\n");
                                paragraph.Add("Total Price: " + customer_Bill.TotalPrice + '\n');
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(paragraph);
                                    document.Close();
                                    fileStream.Close();
                                }

                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting Data" + ex.Message);
                            }
                        }
                    }
                
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }

                CustomerBillGrid.DataSource = null;
            }
            else
            {
                MessageBox.Show("Please ,Enter Valid Data!");
            }

            TotalPriceLabel.Text = "0";
            
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void CustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void QuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void AddedCustomerData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerPanelData_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void Bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void QuantityTxtBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
