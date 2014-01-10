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
        populateOutBoundAirport pop = new populateOutBoundAirport();

        public adminForm()
        {
            InitializeComponent();
            string[] array = pop.initLists();

            foreach (string str in array)
            {
                lslAirRemove.Items.Add(str);
                listBoxAirAdd.Items.Add(str);
            }
            lslAirRemove.Items.Remove(" ");
            listBoxAirAdd.Items.Remove(" ");
            
           
        }
        static string ConvertStringArrayToString(string[] array)
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

            String[] filleary = new String[listBoxAirAdd.SelectedItems.Count];

            for (int index = 0; index < listBoxAirAdd.SelectedItems.Count; index++)
            {
                filleary[index] = Convert.ToString(listBoxAirAdd.SelectedItems[index]);
            }

            string outAirports = ConvertStringArrayToString(filleary);
            
                string path = "XMLFile1.xml";
                string test;
            StringWriter stringWriter = new StringWriter();
                XmlTextWriter writer = new XmlTextWriter(stringWriter);
                writer.WriteStartElement(txtBoxAirport.Text);
                writer.WriteString("," + outAirports);
                writer.WriteEndElement();
                string[] myArray = File.ReadAllLines(path);
                test = stringWriter.ToString();
                int index0 = myArray.GetLength(0);
                myArray[index0 - 1] = test;
                File.WriteAllLines(path, myArray);
                File.AppendAllText(path, "</Airports>");
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
