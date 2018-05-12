using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQhomework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BirdsDataClassDataContext myDataContext = new BirdsDataClassDataContext();

            var birdCountData =
                from countBirds in myDataContext.BirdCounts
                join nameBirds in myDataContext.Birds
                on countBirds.BirdID
                equals nameBirds.BirdID
                where countBirds.BirdID > 0
                orderby countBirds.CountDate ascending
                select new { countBirds.BirdID, nameBirds.Name, countBirds.Count, countBirds.CountDate };     

            dataGridViewBirdCount.DataSource = birdCountData;
        }
    }
}
