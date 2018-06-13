using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Book_HW
{
    public partial class Form1 : Form
    {
        BSTclass myBST = new BSTclass();

        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int rating;
            int isbn;
            int year;

            if (textBoxISBN.Text != "") //Catches blank entires that would override the default name.
            {
                int.TryParse(textBoxISBN.Text, out isbn);
                int.TryParse(textBoxRating.Text, out rating);
                int.TryParse(textBoxYear.Text, out year);
                myBST.Add(isbn, new Book(textBoxTitle.Text, textBoxAuthor.Text, rating, year));
            }

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxRating.Clear();
            textBoxYear.Clear();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int isbn;
            int.TryParse(textBoxISBN.Text, out isbn);

            Book results;
                        
            results = myBST.Find(isbn);
            textBoxTitle.Text = results.title;
            textBoxAuthor.Text = results.author;
            textBoxRating.Text = Convert.ToString(results.rating);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int isbn;
            int.TryParse(textBoxISBN.Text, out isbn);

            myBST.Remove(isbn);

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxRating.Clear();
            textBoxYear.Clear();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            List<ISBNclass> data = myBST.GetISBN();

            dataGridView1.DataSource = data;

            //Here is my solution before I found out the internal value was the issue.
            //var dataTable = new DataTable("ISBNs");
            //dataTable.Columns.Add("ISBN");
            //foreach (var item in data)
            //{
            //    dataTable.Rows.Add(item.ISBN);            
            //}
             
            //bindingSource1.DataSource = dataTable;
            //dataGridView1.DataSource = bindingSource1;
        }
    }
}
