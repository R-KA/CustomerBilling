using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;
using System.Globalization;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;

namespace CustomerBilling
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        String SqlConnection = "Data Source=.;Initial Catalog=Customer;Integrated Security=True";
        DataRow dr;
        public Form1()
        {
            InitializeComponent();
            fillCombo();

            dt.Columns.Add("Item_ID");
            dt.Columns.Add("Item_Name");
            dt.Columns.Add("Item_qty");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Disc");
            dt.Columns.Add("DiscType");
            dt.Columns.Add("FinalBillAmount");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewID();
            GetPOID();
            GridData();
            for (int i = 1; i <= 100; i++)
            {
                cmb_qty.Items.Add(i);
            }
            btn_SaveMultipleItems.Enabled = false;
            btnCLearItem.Visible = false;
            lblTodaysValue.Text = "Date:";
            lbldatetodays.Text = DateTime.Now.ToShortDateString();

        }


        public void NewID()
        {
            string query = "select max (Customer_ID)+1 as CutomerID from CustomerBilling";

            using (SqlConnection con = new SqlConnection(SqlConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    txtCustID.Text = cmd.ExecuteScalar().ToString();
                    txtCustID.Visible = true;
                    con.Close();
                }
            }
        }
        public void GetPOID()
        {
            string POID = "select concat('PO',([PurchaseOrder]) ,'" + txtCustID.Text + "')AS pp from PurchaseOrder";

            using (SqlConnection con = new SqlConnection(SqlConnection))
            {
                using (SqlCommand cmd = new SqlCommand(POID, con))
                {
                    con.Open();
                    txtPOID.Text = cmd.ExecuteScalar().ToString();

                    txtPOID.Visible = true;
                    con.Close();
                }
            }
        }
        public void fillCombo()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Customer;Integrated Security=True");
            string query = "select * from Item_Master";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sname = reader.GetString(1);
                    cmb_Item.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertButtonCode()
        {
            try
            {

                string customerName = txt_CustName.Text;
                string customerCellNumber = txt_CellNo.Text;
                DateTime billingDateTime = BillingDateTimePicker.Value;
                string itemsPurchased = cmb_Item.Text;
                string Category = cmb_Category.Text;
                int quantity;
                decimal rate;
                decimal discount;
                decimal billAmount = decimal.Parse(txtTotal.Text);
                decimal FinalBillAmount = decimal.Parse(txtFinalTotalAmount.Text);
                string DiscType = txtDiscType.Text;

                if (string.IsNullOrEmpty(customerName) || (string.IsNullOrEmpty(customerCellNumber) || (string.IsNullOrEmpty(itemsPurchased))))
                {
                    MessageBox.Show("Please Fill All the Required Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(cmb_qty.Text, out quantity))
                {
                    MessageBox.Show("Invalid Quntity!!...Please Enter the Valid Interger Quntity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txt_Rate.Text, out rate))
                {
                    MessageBox.Show("Invalid Rate..!! Only decimal Rates are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txt_Disc.Text, out discount))
                {
                    MessageBox.Show("Invalid Discount..! Only decimal Discount are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ////calculate total Amount
                //billAmount = quantity * rate * (1 - (discount / 100));
                string Query = "insert into CustomerBilling values(@Customer_Name, @Customer_CellNo, @Billing_Date, @FinalBillAmount,@PurchaseOrderID)";

                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, con))
                    {

                        cmd.Parameters.AddWithValue("@Customer_Name", txt_CustName.Text);
                        cmd.Parameters.AddWithValue("@Customer_CellNo", txt_CellNo.Text);
                        cmd.Parameters.AddWithValue("@Billing_Date", BillingDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@FinalBillAmount", FinalBillAmount);
                        cmd.Parameters.AddWithValue("@PurchaseOrderID", txtPOID.Text);
                        try
                        {
                            con.Open();
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                SaveMultipleItems();

                                MessageBox.Show("Record save successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GridData();
                                ClearData();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Record save failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ClearData();
                                return;
                            }
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Something went wrong, please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {
                            con.Close();
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { }

        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            InsertButtonCode();
        }

        private void cmb_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Item_Master where Item_Name = '" + cmb_Item.Text + "'";
            using (SqlConnection con = new SqlConnection(SqlConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string Category = (string)reader["Category"].ToString();
                            cmb_Category.Items.Add(Category);
                            cmb_Category.SelectedItem = Category;

                            string Rate = (string)reader["Rate"].ToString();
                            txt_Rate.Text = Rate;
                            string ItemID = (string)reader["Item_ID"].ToString();
                            txtItemId.Text = ItemID;
                            txtDiscType.Text = string.Empty;
                            txt_Disc.Text = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
        }

        public void CalculateQtyWisePrice()
        {
            decimal rate;
            decimal quantity;
            if (decimal.TryParse(txt_Rate.Text, out rate) && decimal.TryParse(cmb_qty.Text, out quantity))
            {
                txtTotal.Text = (Convert.ToDouble(cmb_qty.Text) * Convert.ToDouble(txt_Rate.Text)).ToString();
            }
        }

        private void cmb_qty_TextChanged_1(object sender, EventArgs e)
        {
            decimal rate;
            decimal quantity;
            decimal discount;
            string disc;

            if (decimal.TryParse(txt_Rate.Text, out rate) && decimal.TryParse(cmb_qty.Text, out quantity))
            {
                CalculateQtyWisePrice();
            }
            if (decimal.TryParse(txt_Rate.Text, out rate) && decimal.TryParse(cmb_qty.Text, out quantity) && decimal.TryParse(txt_Disc.Text, out discount) && !string.IsNullOrEmpty(txtDiscType.Text))

            {
                FinalBillAmount();
            }


        }

        public void FinalBillAmount()
        {
            try
            {

                decimal sum = 0;
                for (int i = 0; i < GridItemMaster.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(GridItemMaster.Rows[i].Cells[6].Value);
                }
                txtFinalTotalAmount.Text = sum.ToString();

                if (txtDiscType.SelectedIndex == 0)
                {
                    if (!string.IsNullOrEmpty(txtTotal.Text) && !string.IsNullOrEmpty(txt_Disc.Text))
                    {
                        txt_BillAmount.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txt_Disc.Text)).ToString();
                    }
                    else
                    { }
                }
                else
                {
                    if (txtDiscType.SelectedIndex == 1)
                    {
                        double qty, rate, discount, TotalAmount, FinalBillAmount;

                        qty = double.Parse(cmb_qty.Text);
                        rate = double.Parse(txt_Rate.Text);

                        TotalAmount = qty * rate;

                        discount = double.Parse(txt_Disc.Text);

                        FinalBillAmount = discount * TotalAmount / 100;
                        txt_BillAmount.Text = (TotalAmount - FinalBillAmount).ToString();
                    }



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ClearData()
        {
            txt_CustName.Text = string.Empty;
            txt_CellNo.Text = string.Empty;
            BillingDateTimePicker.Text = string.Empty;
            cmb_Item.SelectedItem = null;
            cmb_Category.SelectedItem = null;
            txt_Rate.Text = string.Empty;
            cmb_qty.SelectedItem = null;
            BillingDateTimePicker.CustomFormat = " ";
            BillingDateTimePicker.Format = DateTimePickerFormat.Custom;
            txtTotal.Text = string.Empty;
            txtDiscType.Text = string.Empty;
            txt_Disc.Text = string.Empty;
            txt_BillAmount.Text = string.Empty;
            txtCustID.Text = string.Empty;
        }
        public void GridData()
        {
            try
            {
                string Updateqry = "select c.Customer_ID AS ID,c.Customer_Name As Name,c.PurchaseOrderID As POrder,Cust_cellNo As CellNo, c.Billing_Date As BillingDate, FinalBillAmount from CustomerBilling c";
                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    using (SqlCommand cmd = new SqlCommand(Updateqry, con))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        GridCustomerBilling.DataSource = dt;
                        con.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        public void GridItemMasterData()
        {
            try
            {
                string qry = "select im.Item_Name As Item,im.Category As Category,po.rate As Rate,po.Item_qty as Quntity,po.DiscType As DiscType, po.Disc Discount, po.finaltotalAmount As FinalAmount from PurchaseOrder po left join Item_Master im on po.Item_ID= im.Item_ID where PurchaseOrderID ='" + txtPOID.Text + "' ";
                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);
                        GridItemMaster.DataSource = dt;

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        public void UpdateItems()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    string datecreate = BillingDateTimePicker.Text;
                    string dateupdate = DateTime.Now.ToString();
                    foreach (DataGridViewRow dr in GridItemMaster.Rows)
                    {
                        string qry = "update PurchaseOrder set Item_ID = @Item_ID,rate = @rate,Item_qty = @Item_qty,DiscType = @DiscType, Disc = @Disc, finaltotalAmount = @finaltotalAmount from PurchaseOrder where PurchaseOrderID = '" + txtPOID.Text + "' and Item_ID='" + txtItemId.Text + "'";

                        using (SqlCommand cmd = new SqlCommand(qry, con))
                        {
                            if (dr.IsNewRow) continue;
                            {
                                cmd.Parameters.AddWithValue("@Item_ID", txtItemId.Text);
                                cmd.Parameters.AddWithValue("@rate", txt_Rate.Text);
                                cmd.Parameters.AddWithValue("@Item_qty", cmb_qty.Text);
                                cmd.Parameters.AddWithValue("@DiscType", txtDiscType.Text);
                                cmd.Parameters.AddWithValue("Disc", txt_Disc.Text);
                                cmd.Parameters.AddWithValue("@finaltotalAmount", txt_BillAmount.Text);
                            }
                            con.Open();
                            int result = cmd.ExecuteNonQuery();
                            GridItemMasterData();
                            if (result > 0)
                            {
                                MessageBox.Show("Successfully Update Items", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                                return;
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { }


        }

        public void Btnupdatecode()
        {
            try
            {
                string updateQuery = "Update CustomerBilling Set Customer_Name=@Customer_Name, Cust_CellNo=@Cust_CellNo, Billing_Date=@Billing_Date, FinalBillAmount=@FinalBillAmount, PurchaseOrderID=@PurchaseOrderID where Customer_ID ='" + txtCustID.Text + "'";

                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        if (txt_CustName.Text != "" && txtPOID.Text != "" && BillingDateTimePicker.Text != "")
                        {

                            txtCustID.Visible = true;
                            cmd.Parameters.AddWithValue("@Customer_Name", txt_CustName.Text);
                            cmd.Parameters.AddWithValue("@Cust_CellNo", txt_CellNo.Text);
                            cmd.Parameters.AddWithValue("@Billing_Date", BillingDateTimePicker.Value.Date);
                            cmd.Parameters.AddWithValue("@FinalBillAmount", txt_BillAmount.Text);
                            cmd.Parameters.AddWithValue("@PurchaseOrderID", txtPOID.Text);
                            try
                            {
                                con.Open();
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    UpdateItems();
                                    MessageBox.Show("Record Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    GridData();
                                    ClearData();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Record Updated failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    ClearData();
                                    return;
                                }
                            }

                            catch (Exception)
                            {
                                MessageBox.Show("Something went wrong, please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("We can update Data in our Customer Billing....!", "ADDorNOT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateItems();
                Btnupdatecode();
            }
            else
            {
                ClearItem();
                ClearData();
            }


        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            GridData();
            GridItemMasterData();
        }

        private void GridCustomerBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;

                index = e.RowIndex;
                DataGridViewRow row = GridCustomerBilling.Rows[index];

                if (row != null)
                {
                    txtCustID.Text = row.Cells[0].Value.ToString();
                    txt_CustName.Text = row.Cells[1].Value.ToString();
                    txtPOID.Text = row.Cells[2].Value.ToString();
                    txt_CellNo.Text = row.Cells[3].Value.ToString();
                    DateTime dt;
                    DateTime.TryParseExact(row.Cells[4].Value.ToString().Trim().Substring(0, 10), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
                    BillingDateTimePicker.Value = dt.Date;
                    txtFinalTotalAmount.Text = row.Cells[5].Value.ToString();
                    ClearItem();
                    GridItemMasterData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    con.Open();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = GridCustomerBilling.DataSource;
                    bs.Filter = "Customer_Name like '%" + txtSearch.Text + "%'";
                    GridCustomerBilling.DataSource = bs;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txt_CustName.Text;
                string customerCellNumber = txt_CellNo.Text;
                DateTime billingDateTime = BillingDateTimePicker.Value;
                string itemsPurchased = cmb_Item.Text;
                string Category = cmb_Category.Text;
                int quantity;
                decimal rate;
                decimal discount;


                if (string.IsNullOrEmpty(customerName) || (string.IsNullOrEmpty(customerCellNumber) || (string.IsNullOrEmpty(itemsPurchased))))
                {
                    MessageBox.Show("Please Fill All the Required Filed (Customer Name,Cell No, Items)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtItemId.Text) || (string.IsNullOrEmpty(cmb_Item.Text) || (string.IsNullOrEmpty(txtDiscType.Text))))
                {
                    MessageBox.Show("All required fields have not been filled..! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_SaveMultipleItems.Enabled = false;
                    return;
                }
                if (!decimal.TryParse(txt_Rate.Text, out rate))
                {
                    MessageBox.Show("Invalid Rate..!!Only decimal Rates are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_SaveMultipleItems.Enabled = false;
                    return;

                }
                if (!int.TryParse(cmb_qty.Text, out quantity))
                {
                    MessageBox.Show("Invalid Quntity!!...Please Enter the Valid Interger Quntity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txt_Disc.Text, out discount))
                {
                    MessageBox.Show("Invalid Discount..! Only decimal Discount are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_SaveMultipleItems.Enabled = false;
                    return;
                }
                else
                {
                    dr = dt.NewRow();

                    dr["Item_ID"] = txtItemId.Text;
                    dr["Item_Name"] = cmb_Item.Text;
                    dr["Item_qty"] = cmb_qty.Text;
                    dr["Rate"] = txt_Rate.Text;
                    dr["Disc"] = txt_Disc.Text;
                    dr["DiscType"] = txtDiscType.Text;
                    dr["FinalBillAmount"] = txt_BillAmount.Text;
                    dt.Rows.Add(dr);
                    GridItemMaster.DataSource = dt;
                    decimal sum = 0;
                    for (int i = 0; i < GridItemMaster.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(GridItemMaster.Rows[i].Cells[6].Value);
                    }
                    txtFinalTotalAmount.Text = sum.ToString();

                    if (MessageBox.Show("You Want to Add some more items ...!!", "ADDorNOT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveMultipleItems();
                        ClearItem();
                        btnCLearItem.Visible = false;

                    }
                    else
                    {
                        if (MessageBox.Show("We can Insert Data in our Customer Billing....!", "ADDorNOT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            InsertButtonCode();
                        }
                        else
                        {
                            ClearItem();
                        }
                    }


                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }

        public void SaveMultipleItems()
        {
            if (string.IsNullOrEmpty(cmb_Item.Text) || string.IsNullOrEmpty(cmb_qty.Text) || string.IsNullOrEmpty(txt_Rate.Text) || string.IsNullOrEmpty(txt_Disc.Text))
            {
                MessageBox.Show("Please fill the requied Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                using (SqlConnection con = new SqlConnection(SqlConnection))
                {
                    foreach (DataGridViewRow dr in GridItemMaster.Rows)
                    {
                        string qry = "INSERT INTO [dbo].[PurchaseOrder]VALUES(@Customer_ID,@Item_ID,@Rate, @Item_qty,@Disc,@PO_Date,@PurchaseOrderID,@DiscType,@FinalBillAmount)";

                        using (SqlCommand cmd = new SqlCommand(qry, con))
                        {
                            if (dr.IsNewRow) continue;
                            {
                                cmd.Parameters.AddWithValue("@Customer_ID", txtCustID.Text);
                                cmd.Parameters.AddWithValue("@Item_ID", txtItemId.Text);
                                cmd.Parameters.AddWithValue("@Rate", dr.Cells["Rate"].Value ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Item_qty", dr.Cells["Item_qty"].Value ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Disc", dr.Cells["Disc"].Value ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@PO_Date", DateTime.Now);
                                cmd.Parameters.AddWithValue("@PurchaseOrderID", txtPOID.Text);
                                cmd.Parameters.AddWithValue("@DiscType", dr.Cells["DiscType"].Value ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@FinalBillAmount", dr.Cells["FinalBillAmount"].Value ?? DBNull.Value);
                            }
                            if (MessageBox.Show("We can Insert Data in our Customer Billing....!", "ADDorNOT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                InsertButtonCode();
                                con.Open();
                                cmd.ExecuteNonQuery();
                                GridItemMasterData();
                                MessageBox.Show("Successfully items Added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                                return;
                            }
                            else
                            {
                                ClearItem();
                            }



                        }
                    }
                }
            }
        }
        private void btn_SaveMultipleItems_Click(object sender, EventArgs e)
        {
            SaveMultipleItems();
        }
        public void ClearItem()
        {
            cmb_Item.SelectedItem = null;
            cmb_Category.SelectedItem = null;
            cmb_qty.SelectedItem = null;
            txtDiscType.SelectedItem = null;
            txt_Disc.Text = string.Empty;
            txt_Rate.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txt_BillAmount.Text = string.Empty;
            cmb_qty.Text = string.Empty;
            txtItemId.Text = string.Empty;
        }
        private void btnCLearItem_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void GridItemMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal sum = 0;
            if (MessageBox.Show("Are you sure For Edit Items", "Edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index;

                index = e.RowIndex;
                DataGridViewRow row = GridItemMaster.Rows[index];

                if (row != null)
                {
                    cmb_Item.Text = row.Cells[0].Value.ToString();
                    cmb_Category.Text = row.Cells[1].Value.ToString();
                    txt_Rate.Text = row.Cells[2].Value.ToString();
                    cmb_qty.Text = row.Cells[3].Value.ToString();

                    txtDiscType.Text = row.Cells[4].Value.ToString();
                    txt_Disc.Text = row.Cells[5].Value.ToString();
                    txt_BillAmount.Text = row.Cells[6].Value.ToString();


                    for (int i = 0; i < GridItemMaster.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(GridItemMaster.Rows[i].Cells[6].Value);
                    }
                    txtFinalTotalAmount.Text = sum.ToString();


                }
                else if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteItem();
                }
                else
                {

                }
            }
        }
        public void DeleteItem()
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string qry = "delete PurchaseOrder where item_ID = '" + txtItemId.Text + "' And PurchaseOrderID = '" + txtPOID.Text + "'";
                    using (SqlConnection con = new SqlConnection(SqlConnection))
                    {
                        using (SqlCommand cmd = new SqlCommand(qry, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Successfully deleted..");
                            GridItemMasterData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void txt_Disc_Leave(object sender, EventArgs e)
        {
            //FinalBillAmount();
        }

        private void txt_Disc_MouseLeave(object sender, EventArgs e)
        {
            FinalBillAmount();

        }

        private void txtDiscType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinalBillAmount();
        }

        private void txt_CellNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // e.Handled = true;
                // MessageBox.Show("Error, Aphone number cannot contain letters");
            }
        }

        private void txt_CellNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_CellNo.TextLength == 10)
            {
                txt_CellNo.ForeColor = Color.Black;
            }
            else
            {
                txt_CellNo.ForeColor = Color.Red;

            }
        }
    }
}