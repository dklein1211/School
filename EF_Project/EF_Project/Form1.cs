using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Form1 : Form
    {
        BirdsEntities2 thisData = new BirdsEntities2();

        public Form1()
        {
            InitializeComponent();

            var query =
                from eachBird in thisData.BirdCounts
                orderby eachBird.Count ascending
                select new { eachBird.BirderID, eachBird.Count,eachBird.CountID, eachBird.Bird.Name };

            dataGridViewBirds.DataSource = query.ToList();
        }

        private void dataGridViewBirds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            int countVal;

            if (int.TryParse(textBoxCount.Text, out countVal))
            {
                var selected = dataGridViewBirds.CurrentRow;
                int countID = (int)selected.Cells["CountID"].Value;

                var selectedCount =
                    (from bird in thisData.BirdCounts
                     where bird.CountID == countID
                     select bird).Single();

                selectedCount.Count = countVal;
                thisData.SaveChanges();
                refreshDataGridView();
            }
        }
        private void refreshDataGridView()
        {
            // Using the LINQtoSQL association, for every count event get the name of the Bird
            // starting in BirdCounts table and looking thru back to Bird table

            var query = from items in thisData.BirdCounts
                        orderby items.Count ascending                        
                        select new
                        {
                            items.BirderID,
                            items.Count,
                            items.CountID,
                            items.Bird.Name
                        };
            //Bind to gridView
            dataGridViewBirds.DataSource = query.ToList();
        }
    }
}
