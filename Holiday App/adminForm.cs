using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace Holiday_App
{
    public partial class adminForm : Form
    {
        populateOutBoundAirport pop = new populateOutBoundAirport(); // creates object of class populateOutBoundAirport

        public adminForm() // the constrctur
        {
            InitializeComponent();
            constructList();
            
        }
        private void constructList()
        {
            string[] array = pop.initLists(); // creates an array from the method initLists in class populate... which creates an array of all the airports

            foreach (string str in array)
            {
                
                listBoxAirAdd.Items.Add(str);
            }
           
            listBoxAirAdd.Items.Remove(" ");
            
        }
        static string ConvertStringArrayToString(string[] array) // this is a function which changes an array to a string
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (i == (array.Length - 1))
                {
                    builder.Append(array[i]);
                }
                else
                {
                    builder.Append(array[i]);
                    builder.Append(',');
                }
                
            }
            return builder.ToString();
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {

            String[] filleary = new String[listBoxAirAdd.SelectedItems.Count]; // creates string array as long as their are many in the listbox

            for (int index = 0; index < listBoxAirAdd.SelectedItems.Count; index++) //adds items to the array
            {
                filleary[index] = Convert.ToString(listBoxAirAdd.SelectedItems[index]);
            }

            string outAirports = ConvertStringArrayToString(filleary); // converts the array of strings to a single array
            
                string path = "XMLFile1.xml"; // sets up the path
                string test;
            StringWriter stringWriter = new StringWriter(); // creates object of class string writer
                XmlTextWriter writer = new XmlTextWriter(stringWriter); // and of xmltextwriter
                writer.WriteStartElement(txtBoxAirport.Text); // generates the new xml node
                writer.WriteString("," + outAirports);
                writer.WriteEndElement();
                string[] myArray = File.ReadAllLines(path); // reads all lines into the array
                test = stringWriter.ToString(); // passes the new xml from the xmltextwriter to a string
                int index0 = myArray.GetLength(0); // creates an int with the length of the array

                string[] splitString = myArray[1].Split('<'); // splits the string so we can add it to the master list of airports
                string allports =  "<" + splitString[1] + "," + txtBoxAirport.Text + "" + " </AllAirport>"; // reconstructs the master list
                myArray[index0 - 1] = test; // sets the last but one in the array to be the newly built xml tag
                myArray[1] = allports; // sets the master list location to the new master list
                File.WriteAllLines(path, myArray); //writes that to the file
                File.AppendAllText(path, "</Airports>"); // appends the text with the closing tag

                constructList();
        }

      

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void adminForm_Deactivate(object sender, EventArgs e)
        {
            MainSelectionPage main = new MainSelectionPage();
            main.Show();
        }
       
    }
}
