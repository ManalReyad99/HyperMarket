namespace HyperMarket
{
    partial class CashierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.CustomerPanelData = new System.Windows.Forms.Panel();
            this.SaveCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.AddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.AddedCustomerData = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.DailyBillsDataPanel = new System.Windows.Forms.Panel();
            this.TotalGainedLabel = new DevExpress.XtraEditors.LabelControl();
            this.NoOfBiillsLabel = new DevExpress.XtraEditors.LabelControl();
            this.NoOfBiils = new DevExpress.XtraEditors.LabelControl();
            this.Bills = new System.Windows.Forms.DataGridView();
            this.TotalGainedmoney = new DevExpress.XtraEditors.LabelControl();
            this.CreateBillPanelData = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnforPayWithPoints = new Guna.UI2.WinForms.Guna2Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBForSearchProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBForSearchCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.CBForSearchCustmoer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BTNForPrint = new Guna.UI2.WinForms.Guna2Button();
            this.ValueOfPointlbl = new System.Windows.Forms.Label();
            this.CustomerBillGrid = new System.Windows.Forms.DataGridView();
            this.QuantityTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonForDelete = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonForEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonforPay = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonForAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Pointlabel = new System.Windows.Forms.Label();
            this.CustomerPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.CustomerLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox4 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.CreateBillPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.CreateBillLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox5 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel8 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox7 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DailyBillsPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.DailyBillsLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.MainPanel.SuspendLayout();
            this.CustomerPanelData.SuspendLayout();
            this.DailyBillsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bills)).BeginInit();
            this.CreateBillPanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBillGrid)).BeginInit();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).BeginInit();
            this.CreateBillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox5)).BeginInit();
            this.gunaElipsePanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.DailyBillsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BaseColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.CustomerPanelData);
            this.MainPanel.Controls.Add(this.DailyBillsDataPanel);
            this.MainPanel.Controls.Add(this.CreateBillPanelData);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Radius = 25;
            // 
            // CustomerPanelData
            // 
            this.CustomerPanelData.Controls.Add(this.SaveCustomer);
            this.CustomerPanelData.Controls.Add(this.AddCustomer);
            this.CustomerPanelData.Controls.Add(this.AddedCustomerData);
            this.CustomerPanelData.Controls.Add(this.CustomerPhone);
            this.CustomerPanelData.Controls.Add(this.label2);
            this.CustomerPanelData.Controls.Add(this.label3);
            this.CustomerPanelData.Controls.Add(this.CustomerName);
            resources.ApplyResources(this.CustomerPanelData, "CustomerPanelData");
            this.CustomerPanelData.Name = "CustomerPanelData";
            this.CustomerPanelData.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomerPanelData_Paint);
            // 
            // SaveCustomer
            // 
            this.SaveCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.SaveCustomer.BorderRadius = 18;
            this.SaveCustomer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaveCustomer.BorderThickness = 5;
            this.SaveCustomer.CheckedState.Parent = this.SaveCustomer;
            this.SaveCustomer.CustomImages.Parent = this.SaveCustomer;
            this.SaveCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.SaveCustomer, "SaveCustomer");
            this.SaveCustomer.ForeColor = System.Drawing.Color.Black;
            this.SaveCustomer.HoverState.Parent = this.SaveCustomer;
            this.SaveCustomer.Name = "SaveCustomer";
            this.SaveCustomer.ShadowDecoration.Parent = this.SaveCustomer;
            this.SaveCustomer.Click += new System.EventHandler(this.ClearCustormer_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.AddCustomer.BorderRadius = 18;
            this.AddCustomer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddCustomer.BorderThickness = 5;
            this.AddCustomer.CheckedState.Parent = this.AddCustomer;
            this.AddCustomer.CustomImages.Parent = this.AddCustomer;
            this.AddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.AddCustomer, "AddCustomer");
            this.AddCustomer.ForeColor = System.Drawing.Color.Black;
            this.AddCustomer.HoverState.Parent = this.AddCustomer;
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.ShadowDecoration.Parent = this.AddCustomer;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // AddedCustomerData
            // 
            this.AddedCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.AddedCustomerData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.Phone});
            this.AddedCustomerData.HideSelection = false;
            resources.ApplyResources(this.AddedCustomerData, "AddedCustomerData");
            this.AddedCustomerData.Name = "AddedCustomerData";
            this.AddedCustomerData.UseCompatibleStateImageBehavior = false;
            this.AddedCustomerData.View = System.Windows.Forms.View.Details;
            this.AddedCustomerData.SelectedIndexChanged += new System.EventHandler(this.AddedCustomerData_SelectedIndexChanged);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            // 
            // Phone
            // 
            resources.ApplyResources(this.Phone, "Phone");
            // 
            // CustomerPhone
            // 
            resources.ApplyResources(this.CustomerPhone, "CustomerPhone");
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CustomerName
            // 
            resources.ApplyResources(this.CustomerName, "CustomerName");
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerName_KeyPress);
            // 
            // DailyBillsDataPanel
            // 
            this.DailyBillsDataPanel.Controls.Add(this.TotalGainedLabel);
            this.DailyBillsDataPanel.Controls.Add(this.NoOfBiillsLabel);
            this.DailyBillsDataPanel.Controls.Add(this.NoOfBiils);
            this.DailyBillsDataPanel.Controls.Add(this.Bills);
            this.DailyBillsDataPanel.Controls.Add(this.TotalGainedmoney);
            resources.ApplyResources(this.DailyBillsDataPanel, "DailyBillsDataPanel");
            this.DailyBillsDataPanel.Name = "DailyBillsDataPanel";
            // 
            // TotalGainedLabel
            // 
            this.TotalGainedLabel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TotalGainedLabel.Appearance.Font")));
            this.TotalGainedLabel.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.TotalGainedLabel, "TotalGainedLabel");
            this.TotalGainedLabel.Name = "TotalGainedLabel";
            // 
            // NoOfBiillsLabel
            // 
            this.NoOfBiillsLabel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("NoOfBiillsLabel.Appearance.Font")));
            this.NoOfBiillsLabel.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.NoOfBiillsLabel, "NoOfBiillsLabel");
            this.NoOfBiillsLabel.Name = "NoOfBiillsLabel";
            // 
            // NoOfBiils
            // 
            this.NoOfBiils.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("NoOfBiils.Appearance.Font")));
            this.NoOfBiils.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.NoOfBiils, "NoOfBiils");
            this.NoOfBiils.Name = "NoOfBiils";
            // 
            // Bills
            // 
            this.Bills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Bills, "Bills");
            this.Bills.Name = "Bills";
            this.Bills.RowTemplate.Height = 24;
            // 
            // TotalGainedmoney
            // 
            this.TotalGainedmoney.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TotalGainedmoney.Appearance.Font")));
            this.TotalGainedmoney.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.TotalGainedmoney, "TotalGainedmoney");
            this.TotalGainedmoney.Name = "TotalGainedmoney";
            // 
            // CreateBillPanelData
            // 
            this.CreateBillPanelData.BackColor = System.Drawing.Color.White;
            this.CreateBillPanelData.Controls.Add(this.BtnforPayWithPoints);
            this.CreateBillPanelData.Controls.Add(this.TotalPriceLabel);
            this.CreateBillPanelData.Controls.Add(this.labelTotalPrice);
            this.CreateBillPanelData.Controls.Add(this.Quantitylbl);
            this.CreateBillPanelData.Controls.Add(this.label5);
            this.CreateBillPanelData.Controls.Add(this.CBForSearchProduct);
            this.CreateBillPanelData.Controls.Add(this.label6);
            this.CreateBillPanelData.Controls.Add(this.CBForSearchCategory);
            this.CreateBillPanelData.Controls.Add(this.labelCustomer);
            this.CreateBillPanelData.Controls.Add(this.CBForSearchCustmoer);
            this.CreateBillPanelData.Controls.Add(this.BTNForPrint);
            this.CreateBillPanelData.Controls.Add(this.ValueOfPointlbl);
            this.CreateBillPanelData.Controls.Add(this.CustomerBillGrid);
            this.CreateBillPanelData.Controls.Add(this.QuantityTxtBox);
            this.CreateBillPanelData.Controls.Add(this.ButtonForDelete);
            this.CreateBillPanelData.Controls.Add(this.ButtonForEdit);
            this.CreateBillPanelData.Controls.Add(this.ButtonforPay);
            this.CreateBillPanelData.Controls.Add(this.ButtonForAdd);
            this.CreateBillPanelData.Controls.Add(this.Pointlabel);
            resources.ApplyResources(this.CreateBillPanelData, "CreateBillPanelData");
            this.CreateBillPanelData.Name = "CreateBillPanelData";
            this.CreateBillPanelData.ShadowDecoration.Parent = this.CreateBillPanelData;
            // 
            // BtnforPayWithPoints
            // 
            this.BtnforPayWithPoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.BtnforPayWithPoints.BorderRadius = 18;
            this.BtnforPayWithPoints.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BtnforPayWithPoints.BorderThickness = 5;
            this.BtnforPayWithPoints.CheckedState.Parent = this.BtnforPayWithPoints;
            this.BtnforPayWithPoints.CustomImages.Parent = this.BtnforPayWithPoints;
            this.BtnforPayWithPoints.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.BtnforPayWithPoints, "BtnforPayWithPoints");
            this.BtnforPayWithPoints.ForeColor = System.Drawing.Color.Black;
            this.BtnforPayWithPoints.HoverState.Parent = this.BtnforPayWithPoints;
            this.BtnforPayWithPoints.Name = "BtnforPayWithPoints";
            this.BtnforPayWithPoints.ShadowDecoration.Parent = this.BtnforPayWithPoints;
            this.BtnforPayWithPoints.Click += new System.EventHandler(this.BtnforPayWithPoints_Click);
            // 
            // TotalPriceLabel
            // 
            resources.ApplyResources(this.TotalPriceLabel, "TotalPriceLabel");
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            // 
            // labelTotalPrice
            // 
            resources.ApplyResources(this.labelTotalPrice, "labelTotalPrice");
            this.labelTotalPrice.Name = "labelTotalPrice";
            // 
            // Quantitylbl
            // 
            resources.ApplyResources(this.Quantitylbl, "Quantitylbl");
            this.Quantitylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quantitylbl.Name = "Quantitylbl";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Name = "label5";
            // 
            // CBForSearchProduct
            // 
            this.CBForSearchProduct.BackColor = System.Drawing.Color.Transparent;
            this.CBForSearchProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CBForSearchProduct.BorderRadius = 9;
            this.CBForSearchProduct.BorderThickness = 5;
            this.CBForSearchProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBForSearchProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForSearchProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.CBForSearchProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchProduct.FocusedState.Parent = this.CBForSearchProduct;
            resources.ApplyResources(this.CBForSearchProduct, "CBForSearchProduct");
            this.CBForSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBForSearchProduct.HoverState.Parent = this.CBForSearchProduct;
            this.CBForSearchProduct.ItemsAppearance.Parent = this.CBForSearchProduct;
            this.CBForSearchProduct.Name = "CBForSearchProduct";
            this.CBForSearchProduct.ShadowDecoration.Parent = this.CBForSearchProduct;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Name = "label6";
            // 
            // CBForSearchCategory
            // 
            this.CBForSearchCategory.BackColor = System.Drawing.Color.Transparent;
            this.CBForSearchCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CBForSearchCategory.BorderRadius = 9;
            this.CBForSearchCategory.BorderThickness = 5;
            this.CBForSearchCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBForSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForSearchCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.CBForSearchCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchCategory.FocusedState.Parent = this.CBForSearchCategory;
            resources.ApplyResources(this.CBForSearchCategory, "CBForSearchCategory");
            this.CBForSearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBForSearchCategory.HoverState.Parent = this.CBForSearchCategory;
            this.CBForSearchCategory.ItemsAppearance.Parent = this.CBForSearchCategory;
            this.CBForSearchCategory.Name = "CBForSearchCategory";
            this.CBForSearchCategory.ShadowDecoration.Parent = this.CBForSearchCategory;
            this.CBForSearchCategory.SelectedValueChanged += new System.EventHandler(this.CBForSearchCategory_SelectedValueChanged);
            // 
            // labelCustomer
            // 
            resources.ApplyResources(this.labelCustomer, "labelCustomer");
            this.labelCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCustomer.Name = "labelCustomer";
            // 
            // CBForSearchCustmoer
            // 
            this.CBForSearchCustmoer.BackColor = System.Drawing.Color.Transparent;
            this.CBForSearchCustmoer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CBForSearchCustmoer.BorderRadius = 9;
            this.CBForSearchCustmoer.BorderThickness = 5;
            this.CBForSearchCustmoer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBForSearchCustmoer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForSearchCustmoer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.CBForSearchCustmoer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchCustmoer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForSearchCustmoer.FocusedState.Parent = this.CBForSearchCustmoer;
            resources.ApplyResources(this.CBForSearchCustmoer, "CBForSearchCustmoer");
            this.CBForSearchCustmoer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBForSearchCustmoer.HoverState.Parent = this.CBForSearchCustmoer;
            this.CBForSearchCustmoer.ItemsAppearance.Parent = this.CBForSearchCustmoer;
            this.CBForSearchCustmoer.Name = "CBForSearchCustmoer";
            this.CBForSearchCustmoer.ShadowDecoration.Parent = this.CBForSearchCustmoer;
            this.CBForSearchCustmoer.SelectedValueChanged += new System.EventHandler(this.CBForSearchCustmoer_SelectedValueChanged);
            // 
            // BTNForPrint
            // 
            this.BTNForPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.BTNForPrint.BorderRadius = 18;
            this.BTNForPrint.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BTNForPrint.BorderThickness = 5;
            this.BTNForPrint.CheckedState.Parent = this.BTNForPrint;
            this.BTNForPrint.CustomImages.Parent = this.BTNForPrint;
            this.BTNForPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.BTNForPrint, "BTNForPrint");
            this.BTNForPrint.ForeColor = System.Drawing.Color.Black;
            this.BTNForPrint.HoverState.Parent = this.BTNForPrint;
            this.BTNForPrint.Name = "BTNForPrint";
            this.BTNForPrint.ShadowDecoration.Parent = this.BTNForPrint;
            this.BTNForPrint.Click += new System.EventHandler(this.BTNForPrint_Click);
            // 
            // ValueOfPointlbl
            // 
            resources.ApplyResources(this.ValueOfPointlbl, "ValueOfPointlbl");
            this.ValueOfPointlbl.Name = "ValueOfPointlbl";
            // 
            // CustomerBillGrid
            // 
            this.CustomerBillGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.CustomerBillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.CustomerBillGrid, "CustomerBillGrid");
            this.CustomerBillGrid.Name = "CustomerBillGrid";
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.QuantityTxtBox.BorderRadius = 17;
            this.QuantityTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTxtBox.DefaultText = "";
            this.QuantityTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTxtBox.DisabledState.Parent = this.QuantityTxtBox;
            this.QuantityTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTxtBox.FocusedState.Parent = this.QuantityTxtBox;
            resources.ApplyResources(this.QuantityTxtBox, "QuantityTxtBox");
            this.QuantityTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantityTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTxtBox.HoverState.Parent = this.QuantityTxtBox;
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.PasswordChar = '\0';
            this.QuantityTxtBox.PlaceholderText = "";
            this.QuantityTxtBox.SelectedText = "";
            this.QuantityTxtBox.ShadowDecoration.Parent = this.QuantityTxtBox;
            this.QuantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTxtBox_KeyPress);
            // 
            // ButtonForDelete
            // 
            this.ButtonForDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ButtonForDelete.BorderRadius = 18;
            this.ButtonForDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ButtonForDelete.BorderThickness = 5;
            this.ButtonForDelete.CheckedState.Parent = this.ButtonForDelete;
            this.ButtonForDelete.CustomImages.Parent = this.ButtonForDelete;
            this.ButtonForDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.ButtonForDelete, "ButtonForDelete");
            this.ButtonForDelete.ForeColor = System.Drawing.Color.Black;
            this.ButtonForDelete.HoverState.Parent = this.ButtonForDelete;
            this.ButtonForDelete.Name = "ButtonForDelete";
            this.ButtonForDelete.ShadowDecoration.Parent = this.ButtonForDelete;
            this.ButtonForDelete.Click += new System.EventHandler(this.ButtonForDelete_Click);
            // 
            // ButtonForEdit
            // 
            this.ButtonForEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ButtonForEdit.BorderRadius = 18;
            this.ButtonForEdit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ButtonForEdit.BorderThickness = 5;
            this.ButtonForEdit.CheckedState.Parent = this.ButtonForEdit;
            this.ButtonForEdit.CustomImages.Parent = this.ButtonForEdit;
            this.ButtonForEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.ButtonForEdit, "ButtonForEdit");
            this.ButtonForEdit.ForeColor = System.Drawing.Color.Black;
            this.ButtonForEdit.HoverState.Parent = this.ButtonForEdit;
            this.ButtonForEdit.Name = "ButtonForEdit";
            this.ButtonForEdit.ShadowDecoration.Parent = this.ButtonForEdit;
            this.ButtonForEdit.Click += new System.EventHandler(this.ButtonForEdit_Click);
            // 
            // ButtonforPay
            // 
            this.ButtonforPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ButtonforPay.BorderRadius = 18;
            this.ButtonforPay.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ButtonforPay.BorderThickness = 5;
            this.ButtonforPay.CheckedState.Parent = this.ButtonforPay;
            this.ButtonforPay.CustomImages.Parent = this.ButtonforPay;
            this.ButtonforPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.ButtonforPay, "ButtonforPay");
            this.ButtonforPay.ForeColor = System.Drawing.Color.Black;
            this.ButtonforPay.HoverState.Parent = this.ButtonforPay;
            this.ButtonforPay.Name = "ButtonforPay";
            this.ButtonforPay.ShadowDecoration.Parent = this.ButtonforPay;
            this.ButtonforPay.Click += new System.EventHandler(this.ButtonforPay_Click);
            // 
            // ButtonForAdd
            // 
            this.ButtonForAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ButtonForAdd.BorderRadius = 18;
            this.ButtonForAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ButtonForAdd.BorderThickness = 5;
            this.ButtonForAdd.CheckedState.Parent = this.ButtonForAdd;
            this.ButtonForAdd.CustomImages.Parent = this.ButtonForAdd;
            this.ButtonForAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.ButtonForAdd, "ButtonForAdd");
            this.ButtonForAdd.ForeColor = System.Drawing.Color.Black;
            this.ButtonForAdd.HoverState.Parent = this.ButtonForAdd;
            this.ButtonForAdd.Name = "ButtonForAdd";
            this.ButtonForAdd.ShadowDecoration.Parent = this.ButtonForAdd;
            this.ButtonForAdd.Click += new System.EventHandler(this.ButtonForAdd_Click);
            // 
            // Pointlabel
            // 
            resources.ApplyResources(this.Pointlabel, "Pointlabel");
            this.Pointlabel.Name = "Pointlabel";
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CustomerPanel.Controls.Add(this.CustomerLabel);
            this.CustomerPanel.Controls.Add(this.gunaCirclePictureBox4);
            resources.ApplyResources(this.CustomerPanel, "CustomerPanel");
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Radius = 10;
            this.CustomerPanel.Click += new System.EventHandler(this.CustomerPanel_Click);
            // 
            // CustomerLabel
            // 
            resources.ApplyResources(this.CustomerLabel, "CustomerLabel");
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Click += new System.EventHandler(this.CustomerLabel_Click);
            // 
            // gunaCirclePictureBox4
            // 
            this.gunaCirclePictureBox4.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaCirclePictureBox4, "gunaCirclePictureBox4");
            this.gunaCirclePictureBox4.Name = "gunaCirclePictureBox4";
            this.gunaCirclePictureBox4.TabStop = false;
            this.gunaCirclePictureBox4.UseTransfarantBackground = false;
            // 
            // CreateBillPanel
            // 
            this.CreateBillPanel.BackColor = System.Drawing.Color.Transparent;
            this.CreateBillPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CreateBillPanel.Controls.Add(this.CreateBillLabel);
            this.CreateBillPanel.Controls.Add(this.gunaCirclePictureBox5);
            resources.ApplyResources(this.CreateBillPanel, "CreateBillPanel");
            this.CreateBillPanel.Name = "CreateBillPanel";
            this.CreateBillPanel.Radius = 10;
            this.CreateBillPanel.Click += new System.EventHandler(this.CreateBillPanel_Click);
            // 
            // CreateBillLabel
            // 
            resources.ApplyResources(this.CreateBillLabel, "CreateBillLabel");
            this.CreateBillLabel.Name = "CreateBillLabel";
            this.CreateBillLabel.Click += new System.EventHandler(this.CreateBillLabel_Click);
            // 
            // gunaCirclePictureBox5
            // 
            this.gunaCirclePictureBox5.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaCirclePictureBox5, "gunaCirclePictureBox5");
            this.gunaCirclePictureBox5.Name = "gunaCirclePictureBox5";
            this.gunaCirclePictureBox5.TabStop = false;
            this.gunaCirclePictureBox5.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel8
            // 
            this.gunaElipsePanel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.gunaElipsePanel8.Controls.Add(this.gunaLabel7);
            this.gunaElipsePanel8.Controls.Add(this.gunaCirclePictureBox7);
            resources.ApplyResources(this.gunaElipsePanel8, "gunaElipsePanel8");
            this.gunaElipsePanel8.Name = "gunaElipsePanel8";
            this.gunaElipsePanel8.Radius = 10;
            // 
            // gunaLabel7
            // 
            resources.ApplyResources(this.gunaLabel7, "gunaLabel7");
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Click += new System.EventHandler(this.gunaLabel7_Click);
            // 
            // gunaCirclePictureBox7
            // 
            this.gunaCirclePictureBox7.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaCirclePictureBox7, "gunaCirclePictureBox7");
            this.gunaCirclePictureBox7.Name = "gunaCirclePictureBox7";
            this.gunaCirclePictureBox7.TabStop = false;
            this.gunaCirclePictureBox7.UseTransfarantBackground = false;
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DailyBillsPanel
            // 
            this.DailyBillsPanel.BackColor = System.Drawing.Color.Transparent;
            this.DailyBillsPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.DailyBillsPanel.Controls.Add(this.DailyBillsLabel);
            this.DailyBillsPanel.Controls.Add(this.gunaCirclePictureBox1);
            resources.ApplyResources(this.DailyBillsPanel, "DailyBillsPanel");
            this.DailyBillsPanel.Name = "DailyBillsPanel";
            this.DailyBillsPanel.Radius = 10;
            this.DailyBillsPanel.Click += new System.EventHandler(this.DailyBillsPanel_Click);
            // 
            // DailyBillsLabel
            // 
            resources.ApplyResources(this.DailyBillsLabel, "DailyBillsLabel");
            this.DailyBillsLabel.Name = "DailyBillsLabel";
            this.DailyBillsLabel.Click += new System.EventHandler(this.DailyBillsLabel_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaCirclePictureBox1, "gunaCirclePictureBox1");
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // CashierForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.Controls.Add(this.DailyBillsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaElipsePanel8);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CreateBillPanel);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.CustomerPanelData.ResumeLayout(false);
            this.CustomerPanelData.PerformLayout();
            this.DailyBillsDataPanel.ResumeLayout(false);
            this.DailyBillsDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bills)).EndInit();
            this.CreateBillPanelData.ResumeLayout(false);
            this.CreateBillPanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBillGrid)).EndInit();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).EndInit();
            this.CreateBillPanel.ResumeLayout(false);
            this.CreateBillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox5)).EndInit();
            this.gunaElipsePanel8.ResumeLayout(false);
            this.gunaElipsePanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.DailyBillsPanel.ResumeLayout(false);
            this.DailyBillsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaElipsePanel MainPanel;
        private Guna.UI.WinForms.GunaElipsePanel CreateBillPanel;
        private Guna.UI.WinForms.GunaLabel CreateBillLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox5;
        private Guna.UI.WinForms.GunaElipsePanel CustomerPanel;
        private Guna.UI.WinForms.GunaLabel CustomerLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox7;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipsePanel DailyBillsPanel;
        private Guna.UI.WinForms.GunaLabel DailyBillsLabel;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private System.Windows.Forms.Panel DailyBillsDataPanel;
        private DevExpress.XtraEditors.LabelControl TotalGainedLabel;
        private DevExpress.XtraEditors.LabelControl NoOfBiillsLabel;
        private DevExpress.XtraEditors.LabelControl NoOfBiils;
        private System.Windows.Forms.DataGridView Bills;
        private DevExpress.XtraEditors.LabelControl TotalGainedmoney;
        private System.Windows.Forms.Panel CustomerPanelData;
        private Guna.UI2.WinForms.Guna2Button SaveCustomer;
        private Guna.UI2.WinForms.Guna2Button AddCustomer;
        private System.Windows.Forms.ListView AddedCustomerData;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerName;
        private Guna.UI2.WinForms.Guna2Panel CreateBillPanelData;
        private Guna.UI2.WinForms.Guna2Button BtnforPayWithPoints;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox CBForSearchProduct;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CBForSearchCategory;
        private System.Windows.Forms.Label labelCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox CBForSearchCustmoer;
        private Guna.UI2.WinForms.Guna2Button BTNForPrint;
        private System.Windows.Forms.Label ValueOfPointlbl;
        private System.Windows.Forms.DataGridView CustomerBillGrid;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTxtBox;
        private Guna.UI2.WinForms.Guna2Button ButtonForDelete;
        private Guna.UI2.WinForms.Guna2Button ButtonForEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonforPay;
        private Guna.UI2.WinForms.Guna2Button ButtonForAdd;
        private System.Windows.Forms.Label Pointlabel;
    }
}

