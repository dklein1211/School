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

            if(textBoxISBN.Text != "") //Catches blank entires that would override the default name.
            {
                int.TryParse(textBoxISBN.Text, out isbn);
                int.TryParse(textBoxRating.Text, out rating);
                myBST.Add(isbn, new Book(textBoxTitle.Text, textBoxAuthor.Text, rating));
            }

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxISBN.Clear();
            textBoxRating.Clear();
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
    }
}
