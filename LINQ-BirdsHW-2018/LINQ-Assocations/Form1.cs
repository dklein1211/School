using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Assocations
{
    public partial class Form1 : Form
    {
        //Get dataContext
        Prod_Cat_DataClassDataContext myData = new Prod_Cat_DataClassDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Style dataGridView
            dataGridViewBirds.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;
            dataGridViewBirds.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewBirds.AutoResizeColumns();

            //Style form
            this.BackColor = Color.AntiqueWhite;
        }

        private void refreshDataGridView()
        {
            // Using the LINQtoSQL association, for every count event get the name of the Bird
            // starting in BirdCounts table and looking thru back to Bird table

            var query = from items in myData.Products
                        orderby items.Category.CategoryName ascending
                        where items.UnitPrice > 40
                        select new
                        {
                            items.Category.CategoryName,
                            items.Category.Description,
                            items.ProductName,
                            items.UnitPrice,
                            items.ProductID
                        };
            //Bind to gridView
            dataGridViewBirds.DataSource = query;
        }

        private void buttonGetBirds_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void buttonUpdateCount_Click(object sender, EventArgs e)
        {

            decimal counted;  //Variable to hold textBox input

            if (decimal.TryParse(textBoxNewCount.Text, out counted))
            {
                if (counted > 40)
                {
                    //Get selected row(can click anywhere in the row)
                    var selected = dataGridViewBirds.CurrentRow;
                    int productID = (int)selected.Cells["ProductID"].Value;

                    //Get row from dataContext
                    var selectedUnitPrice =
                        (from item in myData.Products
                         where item.ProductID == productID
                         select item).Single();

                    selectedUnitPrice.UnitPrice = counted;   //Edit dataContext
                    myData.SubmitChanges();            //Submit Changes
                    refreshDataGridView();                 //Refresh the display
                }
                else
                {
                    MessageBox.Show("Updated prices must be above 40 please try again");
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer number.");
            }
            textBoxNewCount.Text = "";  //Clear textBox in either case

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ////Retrieve selected row and id
            //var selectedRow = dataGridViewBirds.CurrentRow;
            //int selectedID = (int)selectedRow.Cells["CountID"].Value;

            ////Retrieve row to delete from dataContext
            //var rowToDelete =
            //    (from bird in myData.BirdCounts
            //     where bird.CountID == selectedID
            //     select bird).Single();

            ////Mark for deletion
            //myData.BirdCounts.DeleteOnSubmit(rowToDelete);

            ////Try to submit changes
            //try
            //{
            //    myData.SubmitChanges();  // LINQ to SQL does all the work for us
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error deleting item: " + ex.Message);
            //}

            ////refresh gridView
            //refreshDataGridView();
        }
    }
}
