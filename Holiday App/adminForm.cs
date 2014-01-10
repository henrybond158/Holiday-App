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
            string[] array = pop.initLists(); // creates an array from the method initLists in class populate... which creates an array of all the airports

            foreach (string str in array)
            {
                lslAirRemove.Items.Add(str);
                listBoxAirAdd.Items.Add(str);
            }
            lslAirRemove.Items.Remove(" ");
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
                myArray[index0 - 1] = test; // sets the last but one in the array to be the newly built xml tag
                File.WriteAllLines(path, myArray); //writes that to the file
                File.AppendAllText(path, "</Airports>"); // appends the text with the closing tag
                /*StreamWriter str = new StreamWriter(path);
                str.WriteLine("</Airports>");
            str.app
                str.Close();
                  
                  */
           
        }

        private void btnRmPort_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(("XMLFile1.xml"));
            string test1 = lslAirRemove.SelectedItem.ToString();

            string[] test0 = test1.Split(' ');

            if (test0.Length > 1)
            {
                test1 = test1.Replace(" ", "");
            }
            XmlNodeList removeNode = xml.SelectNodes("//" + test1);
            foreach (XmlNode node in removeNode)
            {
                node.ParentNode.RemoveChild(node);

            }
           // removeNode.RemoveAll();
            
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
