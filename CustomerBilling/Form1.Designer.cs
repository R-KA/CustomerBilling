namespace CustomerBilling
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldatetodays = new System.Windows.Forms.Label();
            this.lblTodaysValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFinalTotalAmount = new System.Windows.Forms.Label();
            this.txt_BillAmount = new System.Windows.Forms.TextBox();
            this.lbl_BillAmount = new System.Windows.Forms.Label();
            this.txtFinalTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.lblGetPO = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnCLearItem = new System.Windows.Forms.Button();
            this.txtItemId = new System.Windows.Forms.Label();
            this.btn_SaveMultipleItems = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txt_Disc = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txtDiscType = new System.Windows.Forms.ComboBox();
            this.lbl_DiscType = new System.Windows.Forms.Label();
            this.GridItemMaster = new System.Windows.Forms.DataGridView();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustemerID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_qty = new System.Windows.Forms.ComboBox();
            this.cmb_Item = new System.Windows.Forms.ComboBox();
            this.itemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new CustomerBilling.CustomerDataSet();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.BillingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_CellNo = new System.Windows.Forms.TextBox();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.lbl_Billingdt = new System.Windows.Forms.Label();
            this.lbl_Cust_cellno = new System.Windows.Forms.Label();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.lblCustid = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.item_MasterTableAdapter = new CustomerBilling.CustomerDataSetTableAdapters.Item_MasterTableAdapter();
            this.errorProvider_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_rate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridCustomerBilling = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItemMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomerBilling)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbldatetodays);
            this.groupBox1.Controls.Add(this.lblTodaysValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1119, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbldatetodays
            // 
            this.lbldatetodays.AutoSize = true;
            this.lbldatetodays.Location = new System.Drawing.Point(994, 20);
            this.lbldatetodays.Name = "lbldatetodays";
            this.lbldatetodays.Size = new System.Drawing.Size(51, 21);
            this.lbldatetodays.TabIndex = 40;
            this.lbldatetodays.Text = "today";
            // 
            // lblTodaysValue
            // 
            this.lblTodaysValue.AutoSize = true;
            this.lblTodaysValue.Location = new System.Drawing.Point(951, 21);
            this.lblTodaysValue.Name = "lblTodaysValue";
            this.lblTodaysValue.Size = new System.Drawing.Size(44, 21);
            this.lblTodaysValue.TabIndex = 1;
            this.lblTodaysValue.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Billing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFinalTotalAmount);
            this.groupBox2.Controls.Add(this.txt_BillAmount);
            this.groupBox2.Controls.Add(this.lbl_BillAmount);
            this.groupBox2.Controls.Add(this.txtFinalTotalAmount);
            this.groupBox2.Controls.Add(this.txtPOID);
            this.groupBox2.Controls.Add(this.lblGetPO);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnCLearItem);
            this.groupBox2.Controls.Add(this.txtItemId);
            this.groupBox2.Controls.Add(this.btn_SaveMultipleItems);
            this.groupBox2.Controls.Add(this.lblDiscount);
            this.groupBox2.Controls.Add(this.txt_Disc);
            this.groupBox2.Controls.Add(this.txt_Rate);
            this.groupBox2.Controls.Add(this.txtDiscType);
            this.groupBox2.Controls.Add(this.lbl_DiscType);
            this.groupBox2.Controls.Add(this.GridItemMaster);
            this.groupBox2.Controls.Add(this.txtCustID);
            this.groupBox2.Controls.Add(this.lblCustemerID);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_qty);
            this.groupBox2.Controls.Add(this.cmb_Item);
            this.groupBox2.Controls.Add(this.lbl_qty);
            this.groupBox2.Controls.Add(this.lbl_Item);
            this.groupBox2.Controls.Add(this.cmb_Category);
            this.groupBox2.Controls.Add(this.lbl_Category);
            this.groupBox2.Controls.Add(this.Btn_Update);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_View);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Controls.Add(this.BillingDateTimePicker);
            this.groupBox2.Controls.Add(this.txt_CellNo);
            this.groupBox2.Controls.Add(this.txt_CustName);
            this.groupBox2.Controls.Add(this.lbl_Billingdt);
            this.groupBox2.Controls.Add(this.lbl_Cust_cellno);
            this.groupBox2.Controls.Add(this.lbl_CustName);
            this.groupBox2.Location = new System.Drawing.Point(13, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(579, 644);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblFinalTotalAmount
            // 
            this.lblFinalTotalAmount.AutoSize = true;
            this.lblFinalTotalAmount.Location = new System.Drawing.Point(199, 602);
            this.lblFinalTotalAmount.Name = "lblFinalTotalAmount";
            this.lblFinalTotalAmount.Size = new System.Drawing.Size(146, 21);
            this.lblFinalTotalAmount.TabIndex = 54;
            this.lblFinalTotalAmount.Text = "Final Total Amount";
            // 
            // txt_BillAmount
            // 
            this.txt_BillAmount.Location = new System.Drawing.Point(141, 329);
            this.txt_BillAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_BillAmount.Name = "txt_BillAmount";
            this.txt_BillAmount.Size = new System.Drawing.Size(299, 28);
            this.txt_BillAmount.TabIndex = 53;
            // 
            // lbl_BillAmount
            // 
            this.lbl_BillAmount.AutoSize = true;
            this.lbl_BillAmount.Location = new System.Drawing.Point(38, 334);
            this.lbl_BillAmount.Name = "lbl_BillAmount";
            this.lbl_BillAmount.Size = new System.Drawing.Size(95, 21);
            this.lbl_BillAmount.TabIndex = 52;
            this.lbl_BillAmount.Text = "Bill Amount";
            // 
            // txtFinalTotalAmount
            // 
            this.txtFinalTotalAmount.Location = new System.Drawing.Point(346, 599);
            this.txtFinalTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinalTotalAmount.Name = "txtFinalTotalAmount";
            this.txtFinalTotalAmount.Size = new System.Drawing.Size(227, 28);
            this.txtFinalTotalAmount.TabIndex = 51;
            // 
            // txtPOID
            // 
            this.txtPOID.Location = new System.Drawing.Point(304, 21);
            this.txtPOID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(138, 28);
            this.txtPOID.TabIndex = 50;
            // 
            // lblGetPO
            // 
            this.lblGetPO.AutoSize = true;
            this.lblGetPO.Location = new System.Drawing.Point(247, 26);
            this.lblGetPO.Name = "lblGetPO";
            this.lblGetPO.Size = new System.Drawing.Size(51, 21);
            this.lblGetPO.TabIndex = 49;
            this.lblGetPO.Text = "PO ID";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(162, 357);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 32);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete Item";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnCLearItem
            // 
            this.btnCLearItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCLearItem.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLearItem.Location = new System.Drawing.Point(396, 357);
            this.btnCLearItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCLearItem.Name = "btnCLearItem";
            this.btnCLearItem.Size = new System.Drawing.Size(97, 32);
            this.btnCLearItem.TabIndex = 47;
            this.btnCLearItem.Text = "Clear Item";
            this.btnCLearItem.UseVisualStyleBackColor = false;
            this.btnCLearItem.Click += new System.EventHandler(this.btnCLearItem_Click);
            // 
            // txtItemId
            // 
            this.txtItemId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtItemId.Location = new System.Drawing.Point(493, 292);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(41, 28);
            this.txtItemId.TabIndex = 46;
            // 
            // btn_SaveMultipleItems
            // 
            this.btn_SaveMultipleItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SaveMultipleItems.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveMultipleItems.Location = new System.Drawing.Point(265, 357);
            this.btn_SaveMultipleItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveMultipleItems.Name = "btn_SaveMultipleItems";
            this.btn_SaveMultipleItems.Size = new System.Drawing.Size(125, 32);
            this.btn_SaveMultipleItems.TabIndex = 45;
            this.btn_SaveMultipleItems.Text = "Save Multiple Items";
            this.btn_SaveMultipleItems.UseVisualStyleBackColor = false;
            this.btn_SaveMultipleItems.Click += new System.EventHandler(this.btn_SaveMultipleItems_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(247, 299);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(74, 21);
            this.lblDiscount.TabIndex = 44;
            this.lblDiscount.Text = "Discount";
            // 
            // txt_Disc
            // 
            this.txt_Disc.Location = new System.Drawing.Point(327, 295);
            this.txt_Disc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Disc.Name = "txt_Disc";
            this.txt_Disc.Size = new System.Drawing.Size(113, 28);
            this.txt_Disc.TabIndex = 43;
            this.txt_Disc.Leave += new System.EventHandler(this.txt_Disc_Leave);
            this.txt_Disc.MouseLeave += new System.EventHandler(this.txt_Disc_MouseLeave);
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(141, 225);
            this.txt_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(118, 28);
            this.txt_Rate.TabIndex = 30;
            // 
            // txtDiscType
            // 
            this.txtDiscType.FormattingEnabled = true;
            this.txtDiscType.Items.AddRange(new object[] {
            "Rs",
            " %"});
            this.txtDiscType.Location = new System.Drawing.Point(141, 294);
            this.txtDiscType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscType.Name = "txtDiscType";
            this.txtDiscType.Size = new System.Drawing.Size(93, 29);
            this.txtDiscType.TabIndex = 42;
            this.txtDiscType.SelectedIndexChanged += new System.EventHandler(this.txtDiscType_SelectedIndexChanged);
            // 
            // lbl_DiscType
            // 
            this.lbl_DiscType.AutoSize = true;
            this.lbl_DiscType.Location = new System.Drawing.Point(22, 298);
            this.lbl_DiscType.Name = "lbl_DiscType";
            this.lbl_DiscType.Size = new System.Drawing.Size(113, 21);
            this.lbl_DiscType.TabIndex = 41;
            this.lbl_DiscType.Text = "Discount Type";
            // 
            // GridItemMaster
            // 
            this.GridItemMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItemMaster.Location = new System.Drawing.Point(6, 394);
            this.GridItemMaster.Name = "GridItemMaster";
            this.GridItemMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridItemMaster.RowHeadersWidth = 51;
            this.GridItemMaster.RowTemplate.Height = 24;
            this.GridItemMaster.Size = new System.Drawing.Size(567, 200);
            this.GridItemMaster.TabIndex = 0;
            this.GridItemMaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItemMaster_CellClick);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(141, 20);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(101, 28);
            this.txtCustID.TabIndex = 40;
            // 
            // lblCustemerID
            // 
            this.lblCustemerID.AutoSize = true;
            this.lblCustemerID.Location = new System.Drawing.Point(31, 26);
            this.lblCustemerID.Name = "lblCustemerID";
            this.lblCustemerID.Size = new System.Drawing.Size(101, 21);
            this.lblCustemerID.TabIndex = 39;
            this.lblCustemerID.Text = "Customer ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(63, 357);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add New Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(141, 260);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(299, 28);
            this.txtTotal.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Total";
            // 
            // cmb_qty
            // 
            this.cmb_qty.FormattingEnabled = true;
            this.cmb_qty.IntegralHeight = false;
            this.cmb_qty.Location = new System.Drawing.Point(346, 224);
            this.cmb_qty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_qty.Name = "cmb_qty";
            this.cmb_qty.Size = new System.Drawing.Size(94, 29);
            this.cmb_qty.TabIndex = 24;
            this.cmb_qty.TextChanged += new System.EventHandler(this.cmb_qty_TextChanged_1);
            // 
            // cmb_Item
            // 
            this.cmb_Item.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemMasterBindingSource, "Item_Name", true));
            this.cmb_Item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Item.FormattingEnabled = true;
            this.cmb_Item.IntegralHeight = false;
            this.cmb_Item.Location = new System.Drawing.Point(141, 156);
            this.cmb_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Item.Name = "cmb_Item";
            this.cmb_Item.Size = new System.Drawing.Size(302, 29);
            this.cmb_Item.TabIndex = 23;
            this.cmb_Item.SelectedIndexChanged += new System.EventHandler(this.cmb_Item_SelectedIndexChanged);
            // 
            // itemMasterBindingSource
            // 
            this.itemMasterBindingSource.DataMember = "Item_Master";
            this.itemMasterBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(271, 231);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(64, 21);
            this.lbl_qty.TabIndex = 22;
            this.lbl_qty.Text = "Quntity";
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Location = new System.Drawing.Point(88, 159);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(44, 21);
            this.lbl_Item.TabIndex = 21;
            this.lbl_Item.Text = "Item";
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(141, 190);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(302, 29);
            this.cmb_Category.TabIndex = 17;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(59, 194);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(76, 21);
            this.lbl_Category.TabIndex = 16;
            this.lbl_Category.Text = "Category";
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Update.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(465, 225);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(94, 59);
            this.Btn_Update.TabIndex = 15;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(465, 157);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 59);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_View.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(465, 91);
            this.btn_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(94, 59);
            this.btn_View.TabIndex = 13;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Insert.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Location = new System.Drawing.Point(465, 24);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 59);
            this.btn_Insert.TabIndex = 12;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // BillingDateTimePicker
            // 
            this.BillingDateTimePicker.AllowDrop = true;
            this.BillingDateTimePicker.Location = new System.Drawing.Point(141, 123);
            this.BillingDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BillingDateTimePicker.Name = "BillingDateTimePicker";
            this.BillingDateTimePicker.Size = new System.Drawing.Size(302, 28);
            this.BillingDateTimePicker.TabIndex = 9;
            // 
            // txt_CellNo
            // 
            this.txt_CellNo.Location = new System.Drawing.Point(141, 88);
            this.txt_CellNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CellNo.MaxLength = 10;
            this.txt_CellNo.Name = "txt_CellNo";
            this.txt_CellNo.Size = new System.Drawing.Size(302, 28);
            this.txt_CellNo.TabIndex = 7;
            this.txt_CellNo.TextChanged += new System.EventHandler(this.txt_CellNo_TextChanged);
            this.txt_CellNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CellNo_KeyPress);
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(141, 54);
            this.txt_CustName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(302, 28);
            this.txt_CustName.TabIndex = 6;
            // 
            // lbl_Billingdt
            // 
            this.lbl_Billingdt.AutoSize = true;
            this.lbl_Billingdt.Location = new System.Drawing.Point(45, 129);
            this.lbl_Billingdt.Name = "lbl_Billingdt";
            this.lbl_Billingdt.Size = new System.Drawing.Size(92, 21);
            this.lbl_Billingdt.TabIndex = 2;
            this.lbl_Billingdt.Text = "Billing Date";
            // 
            // lbl_Cust_cellno
            // 
            this.lbl_Cust_cellno.AutoSize = true;
            this.lbl_Cust_cellno.Location = new System.Drawing.Point(40, 92);
            this.lbl_Cust_cellno.Name = "lbl_Cust_cellno";
            this.lbl_Cust_cellno.Size = new System.Drawing.Size(99, 21);
            this.lbl_Cust_cellno.TabIndex = 1;
            this.lbl_Cust_cellno.Text = "Cell Number";
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Location = new System.Drawing.Point(12, 58);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.Size = new System.Drawing.Size(127, 21);
            this.lbl_CustName.TabIndex = 0;
            this.lbl_CustName.Text = "Customer Name";
            // 
            // lblCustid
            // 
            this.lblCustid.AutoSize = true;
            this.lblCustid.Location = new System.Drawing.Point(475, 25);
            this.lblCustid.Name = "lblCustid";
            this.lblCustid.Size = new System.Drawing.Size(0, 21);
            this.lblCustid.TabIndex = 38;
            // 
            // item_MasterTableAdapter
            // 
            this.item_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider_Customer
            // 
            this.errorProvider_Customer.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(96, 296);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(47, 21);
            this.lbl_rate.TabIndex = 29;
            this.lbl_rate.Text = "Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridCustomerBilling);
            this.groupBox3.Location = new System.Drawing.Point(596, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 596);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // GridCustomerBilling
            // 
            this.GridCustomerBilling.AllowUserToAddRows = false;
            this.GridCustomerBilling.AllowUserToDeleteRows = false;
            this.GridCustomerBilling.ColumnHeadersHeight = 29;
            this.GridCustomerBilling.Location = new System.Drawing.Point(7, 21);
            this.GridCustomerBilling.Name = "GridCustomerBilling";
            this.GridCustomerBilling.ReadOnly = true;
            this.GridCustomerBilling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GridCustomerBilling.RowHeadersWidth = 51;
            this.GridCustomerBilling.RowTemplate.Height = 24;
            this.GridCustomerBilling.Size = new System.Drawing.Size(530, 556);
            this.GridCustomerBilling.TabIndex = 0;
            this.GridCustomerBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCustomerBilling_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.lblSearch);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(596, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 51);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(407, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 28);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 21);
            this.lblSearch.TabIndex = 36;
            this.lblSearch.Text = "Customer Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(129, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 28);
            this.txtSearch.TabIndex = 9;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 724);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Billing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItemMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomerBilling)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_CellNo;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.Label lbl_Billingdt;
        private System.Windows.Forms.Label lbl_Cust_cellno;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DateTimePicker BillingDateTimePicker;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource itemMasterBindingSource;
        private CustomerDataSetTableAdapters.Item_MasterTableAdapter item_MasterTableAdapter;
        private System.Windows.Forms.ComboBox cmb_qty;
        private System.Windows.Forms.ComboBox cmb_Item;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.ErrorProvider errorProvider_Customer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCustid;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustemerID;
        private System.Windows.Forms.DataGridView GridCustomerBilling;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txt_Disc;
        private System.Windows.Forms.ComboBox txtDiscType;
        private System.Windows.Forms.Label lbl_DiscType;
        private System.Windows.Forms.DataGridView GridItemMaster;
        private System.Windows.Forms.Button btn_SaveMultipleItems;
        private System.Windows.Forms.Label txtItemId;
        private System.Windows.Forms.Button btnCLearItem;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label lblGetPO;
        private System.Windows.Forms.Label lblTodaysValue;
        private System.Windows.Forms.Label lbldatetodays;
        private System.Windows.Forms.TextBox txtFinalTotalAmount;
        private System.Windows.Forms.Label lblFinalTotalAmount;
        private System.Windows.Forms.TextBox txt_BillAmount;
        private System.Windows.Forms.Label lbl_BillAmount;
    }
}

