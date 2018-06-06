using Prog260_Heap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeapHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Heap myHeap;
        private void Form1_Load(object sender, EventArgs e)
        {
            myHeap = new Heap(20);
        }

        private void buttonAddReser_Click(object sender, EventArgs e)
        {
            myHeap.Insert(new Person(Convert.ToInt32(textBoxResNoInput.Text), textBoxFirstNameInput.Text, textBoxLastNameInput.Text));
            textBoxResNoInput.Clear();
            textBoxFirstNameInput.Clear();
            textBoxLastNameInput.Clear();
        }

        private void buttonGetReser_Click(object sender, EventArgs e)
        {
            if (myHeap.IsEmpty == true)
            {
                textBoxResNoOutput.Text = "No More Reservations";
            }
            else
            {
                Person theRoot = myHeap.RemoveMaxNode();

                textBoxResNoOutput.Text = Convert.ToString(theRoot.ReservationNumber);
                textBoxFirstNameOutput.Text = theRoot.FirstName;
                textBoxLastNameOutput.Text = theRoot.LastName;
            }
            
        }
     
    }
}
