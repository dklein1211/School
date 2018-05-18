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
        BindingSource myBinding;
        BindingSource myBindingTB;

        public Form1()
        {
            InitializeComponent();
            // create a new BindingSource object
            
        }

        private void buttonGetOrdDet_Click(object sender, EventArgs e)
        {
            // Q1 step, get the data source 
            DataClassesOrderDetailDataContext myOrderDetail = new DataClassesOrderDetailDataContext();

            // Q2 step, define the query expression
            var orders = from myOrders in myOrderDetail.Order_Details
                         where myOrders.Quantity > 79
                         orderby myOrders.Product.ProductName ascending
                         select new { myOrders.Product.ProductName, myOrders.Quantity, myOrders.ProductID };

            // create a new BindingSource object
            myBinding = new BindingSource();

            // bind the query to a Binding object 
            myBinding.DataSource = orders;
                        
            //attach the BindingSource to the DataGridView.
            dataGridViewResults.DataSource = myBinding;
         
        }

       
        private void buttonGetPrice_Click(object sender, EventArgs e)
        {
            // Q1 step, get the data source 
            DataClassesOrderDetailDataContext myOrderDetail2 = new DataClassesOrderDetailDataContext();

            int productID = (int)dataGridViewResults.CurrentCell.Value;

            var selectedProduct = (from myProducts in myOrderDetail2.Order_Details
                                   where myProducts.ProductID == productID
                                   select new { myProducts.UnitPrice });

            myBindingTB = new BindingSource();
            
            // bind the query to a Binding object 
            myBindingTB.DataSource = selectedProduct;

            //attach the BindingSource a textbox
            textBoxProduct.Clear();
            textBoxProduct.DataBindings.Clear();
            textBoxProduct.DataBindings.Add("Text", myBindingTB, "UnitPrice", true);
            //method props are: string property name, object data source, string dataMember, bool format (or don't format  false)

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myBinding.Position + 1 < myBinding.Count)
            {
                myBinding.MoveNext();
                textBoxProduct.Clear();
            } 

        }

    
    }
}
