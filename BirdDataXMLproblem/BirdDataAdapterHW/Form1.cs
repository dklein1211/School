using ClassLibraryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdDataAdapterHW
{
    public partial class Form1 : Form
    {
        DataSet birdsDataSet = new DataSet();
        XMLDataSet myXMLDataSet;


        public Form1()
        {
            InitializeComponent();
            myXMLDataSet = new XMLDataSet();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BirdData.SaveBirdInfo(birdsDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();  // a call to the refresh method.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();  // a call to the refresh method.
        }

        private void refresh()
        {
            try
            {
                birdsDataSet = BirdData.GetBirdInfo();
                DataGridViewBirds.DataSource = birdsDataSet;
                DataGridViewBirds.DataMember = "BirdInfo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonReadXML_Click(object sender, EventArgs e)
        {
            try
            {
                myXMLDataSet.ReadXml(@"C:\Users\dklei\Documents\Source\Repos\school\BirdDataXMLproblem\RemoteBirdClub.XML");
                dataGridViewXML.DataSource = myXMLDataSet.Tables["BirdCount"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdateFromXML_Click(object sender, EventArgs e)
        {
            foreach (XMLDataSet.BirdCountRow oneXMLrow in myXMLDataSet.BirdCount)
            {
                DataRow newDataRow = birdsDataSet.Tables["BirdInfo"].NewRow();                

                newDataRow["RegionID"] = oneXMLrow.RegionID;
                newDataRow["BirderID"] = oneXMLrow.BirderID;
                newDataRow["BirdID"] = oneXMLrow.BirdID;
                newDataRow["CountDate"] = oneXMLrow.CountDate;
                newDataRow["Count"] = oneXMLrow.Count;

                birdsDataSet.Tables["BirdInfo"].Rows.Add(newDataRow);
            }
            
            // Note this will load the sqlBirdsDataSet, which will change what the lower datagridview shows, 
            // but it is not in the SQL db until you click save and execute the save method.

            // But before you do that, you need to update the DataAdapter to enable it to do inserts.

            // Note, make sure your Region table, Bird table, and BirdID tables all have valid entries to 
            // match the values used in my XML file.  I used just 1's and 2's. If your tables don't have those
            // values, you can TRY to edit the XML file to set it to values that do match your tables.

        }
    }
}
