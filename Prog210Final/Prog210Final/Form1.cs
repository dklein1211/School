using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog210Final
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Methods tables = new Methods();
            dataGridViewSports.DataSource = tables.RefreshGrids(1);
            dataGridViewHealth.DataSource = tables.RefreshGrids(2);
        }

        private void buttonToHealth_Click(object sender, EventArgs e)
        {
            Methods tables = new Methods();
            SportsAreUsEntities1 myData = new SportsAreUsEntities1();

            //Get selected row(can click anywhere in the row)
            var selected = dataGridViewSports.CurrentRow;
            int sportingItemID = (int)selected.Cells["SportingItemID"].Value;

            var selectedSportsItem =
                (from item in myData.SportingItems
                 where item.SportingItemID == sportingItemID //Use the ID to match.
                 select item).First(); //Must use unique value.

            HealthItem healthItem = new HealthItem
            {
                Name = selectedSportsItem.Name,
                Description = selectedSportsItem.Description,
                QuantityOnHand = selectedSportsItem.QuantityOnHand
            };

            myData.HealthItems.Add(healthItem);
            myData.SportingItems.Remove(selectedSportsItem);

            myData.SaveChanges();

            dataGridViewSports.DataSource = tables.RefreshGrids(1);
            dataGridViewHealth.DataSource = tables.RefreshGrids(2);
        }

        private void buttonToSport_Click(object sender, EventArgs e)
        {
            Methods tables = new Methods();
            SportsAreUsEntities1 myData = new SportsAreUsEntities1();

            //Get selected row(can click anywhere in the row)
            var selected = dataGridViewHealth.CurrentRow;
            int healthItemID = (int)selected.Cells["HealthItemID"].Value;

            var selectedHealthItem =
                (from item in myData.HealthItems
                 where item.HealthItemID == healthItemID //Use the ID to match.
                 select item).First(); //Must use unique value.

            SportingItem sportItem = new SportingItem
            {
                Name = selectedHealthItem.Name,
                Description = selectedHealthItem.Description,
                QuantityOnHand = selectedHealthItem.QuantityOnHand
            };

            myData.SportingItems.Add(sportItem);
            myData.HealthItems.Remove(selectedHealthItem);

            myData.SaveChanges();

            dataGridViewSports.DataSource = tables.RefreshGrids(1);
            dataGridViewHealth.DataSource = tables.RefreshGrids(2);
        }
    }    
}
