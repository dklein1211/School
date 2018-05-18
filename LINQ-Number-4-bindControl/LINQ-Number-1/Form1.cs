using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Number_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonGetOrdDet_Click(object sender, EventArgs e)
        {
            // Q1 step, get the data source 
            DataClassesOrderDetailDataContext myOrderDetail = new DataClassesOrderDetailDataContext();


            // bind a combobox to an entity collection
            // its like binding a combobox to a table in a DataSet. our DataContext has the whole table in it
            // so we can bind it. Note this is ALL items, not the ones > 79, and note is in no order
            comboBoxResults.DataSource = myOrderDetail.Products;
            comboBoxResults.DisplayMember = "ProductName";  // as with all combo boxes or drop downs, you pick the "column" to show
            comboBoxResults.ValueMember = "ProductID";   // and the hidden column which is usually a primary key

            // Q2 step, define the query expression, since we don't want all the table, we want to subset it with a query
            var orders = from myOrders in myOrderDetail.Order_Details
                         where myOrders.Quantity > 79
                         orderby myOrders.Product.ProductName ascending
                         select new { myOrders.Product.ProductName, myOrders.Quantity, myOrders.ProductID }; // these 3 fields are now available to us
            // notice how Product name is again using the Association that LINQ build from the pre-existing SQL relationship

            // bind a combobox to display our query results 
            comboBoxResults2.DataSource = orders;
            comboBoxResults2.DisplayMember = "ProductName";
            comboBoxResults2.ValueMember = "ProductID";

            // bind same query results to dataGridView, but the dataGridView will show all the fields
            dataGridViewResults.DataSource = orders;
            dataGridViewResults.AutoResizeColumns();
            dataGridViewResults.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;

        }

       
        private void buttonGetPrice_Click(object sender, EventArgs e)
        {
            // Q1 step, get the data source 
            DataClassesOrderDetailDataContext myOrderDetail2 = new DataClassesOrderDetailDataContext();

            // Q2 step, define the query expression
            int productID = (int)comboBoxResults2.SelectedValue;

            var selectedProduct = (from myProducts in myOrderDetail2.Order_Details
                                   where myProducts.ProductID == productID
                                   select myProducts.UnitPrice).Max();  
            // not a unique value, so need to force to just one value, I used Max

            textBoxProduct.Text = selectedProduct.ToString();
        }
    }
}
