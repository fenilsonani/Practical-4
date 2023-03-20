using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_4
{
    public partial class Form5 : Form
    {
        //Create an application to display the basic details of employees like Employee ID, First
        //Name, Last Name, City, Contact No., Date of Joining and Salary using ListView. Display
        //the selected row values in a message box on button click event
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //add some items to a listview
            listView1.Columns.Add("Emp Id",150);
            listView1.Columns.Add("First Name",150);
            listView1.Columns.Add("Last Name",150);
            listView1.Columns.Add("City",150);
            listView1.Columns.Add("Contact No.",150);
            listView1.Columns.Add("Date of Joining",150);
            listView1.Columns.Add("Salary",150);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Items.Add(new ListViewItem(new string[] { "1", "Fenil", "Sonani", "Austin,TX", "1234567890", "01/01/2010", "110000$" }));
            listView1.Items.Add(new ListViewItem(new string[] { "2", "Priyank", "Sutariya", "Surat,Gj", "8320550560", "01/01/2010", "89000$" }));
            listView1.Items.Add(new ListViewItem(new string[] { "3", "parth", "Sangani", "Toronto,OH", "1234567890", "01/01/2010", "60000$" }));
            listView1.Items.Add(new ListViewItem(new string[] { "4", "Darshan", "Sabhaya", "Vancouver,BC", "1234567890", "01/01/2010", "60000$" }));
            listView1.Items.Add(new ListViewItem(new string[] { "5", "Sahil", "Devani", "Mumbai,MH", "1234567890", "01/01/2010", "10000$" }));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when user select a row, display the values in a message box

            if (listView1.SelectedItems.Count > 0)
            {
                string msg = "";
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    msg += "Emp Id: " + item.SubItems[0].Text;
                    msg += "\nEmp First Name: " + item.SubItems[1].Text;
                    msg += "\nEmp Last Name: " + item.SubItems[2].Text;
                    msg += "\nEmp City: " + item.SubItems[3].Text;
                    msg += "\nEmp Contact No.: " + item.SubItems[4].Text;   
                    msg += "\nEmp Date of Joining: " + item.SubItems[5].Text;
                    msg += "\nEmp Salary: " + item.SubItems[6].Text;
                }
                MessageBox.Show(msg);
            }

        }
    }
}
