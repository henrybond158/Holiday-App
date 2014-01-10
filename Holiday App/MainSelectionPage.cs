/********************************************************************************
 * This file is part of My Holiday planning coursework app.                     *
 *                                                                              *
 *  My Holiday planning coursework app is free software:                        *
 *  you can redistribute it and/or modify                                       *
 *  it under the terms of the GNU General Public License as published by        *
 *  the Free Software Foundation, either version 3 of the License, or           *
 *  (at your option) any later version.                                         *
 *                                                                              *
 *  My Holiday planning coursework app is distributed in the hope               *
 *  that it will be useful, but WITHOUT ANY WARRANTY; without even the implied  *                                                
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.             *
 * See the GNU General Public License for more details.                         *         
 *                                                                              *
 * You should have received a copy of the GNU General Public License            *
 * along with  My Holiday planning coursework app.                              *
 * If not, see <http://www.gnu.org/licenses/>.                                  *
 *                                                                              *
 *******************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Holiday_App
{
    public partial class MainSelectionPage : Form
    {
        string weatherString = ""; // declares a string for use in deciding what weather icon is to be used
        // declares an object to populate the airport selection lists
        populateOutBoundAirport popList = new populateOutBoundAirport();
        public MainSelectionPage()
        {
            InitializeComponent();

            try
            {
                cmbOutAirport.Items.AddRange(popList.initLists()); // calls the function  which populates the list of outbound airports
                cmbDestPorts.Items.AddRange(popList.initLists()); // calls the function which populates the list of inbound airports
            }
            catch(FileNotFoundException e) // if the file is not found, this expection is thrown and calls this
            {
                if (File.Exists("error.log")) // checks to see if an error.log file already exists
                {
                    File.AppendAllText("error.log",e.ToString()); // if it does, it appends the file, adding the exception that is thrown and sends a message saying to contact admin
                    MessageBox.Show("File not found, error log has been created, please contact system administrator");
                    Environment.Exit(0); // and quits the program
                }
                else // if it is not found, it creates it then adds the data to the file
                {
                    File.Create("error.log");
                    File.AppendAllText("error.log", e.ToString());
                    MessageBox.Show("File not found, error log has been created, nor has an error log, error log created, please now contact system administrator");
                    Environment.Exit(0); // and quits the program
                }
               
            }
            this.ControlBox = false; // this removes the close button as hitting the close button causes conflicts with other parts of the program
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPassangers_TextChanged(object sender, EventArgs e)
        {
            // this switch statement changes the enabled text boxes based on the number of passangers selected

            switch (int.Parse(cmbPassangers.Text))
            {
                case 0:
                    txtFN0.Enabled = false;
                    txtFN1.Enabled = false;
                    txtFN2.Enabled = false;
                    txtFN3.Enabled = false;
                    txtFN4.Enabled = false;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = false;
                    txtLN1.Enabled = false;
                    txtLN2.Enabled = false;
                    txtLN3.Enabled = false;
                    txtLN4.Enabled = false;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = false;
                    cmbAge1.Enabled = false;
                    cmbAge2.Enabled = false;
                    cmbAge3.Enabled = false;
                    cmbAge4.Enabled = false;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 1:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = false;
                    txtFN2.Enabled = false;
                    txtFN3.Enabled = false;
                    txtFN4.Enabled = false;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = false;
                    txtLN2.Enabled = false;
                    txtLN3.Enabled = false;
                    txtLN4.Enabled = false;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = false;
                    cmbAge2.Enabled = false;
                    cmbAge3.Enabled = false;
                    cmbAge4.Enabled = false;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 2:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = false;
                    txtFN3.Enabled = false;
                    txtFN4.Enabled = false;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = false;
                    txtLN3.Enabled = false;
                    txtLN4.Enabled = false;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = false;
                    cmbAge3.Enabled = false;
                    cmbAge4.Enabled = false;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 3:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = false;
                    txtFN4.Enabled = false;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = false;
                    txtLN4.Enabled = false;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = false;
                    cmbAge4.Enabled = false;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 4:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = true;
                    txtFN4.Enabled = false;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = true;
                    txtLN4.Enabled = false;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = true;
                    cmbAge4.Enabled = false;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 5:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = true;
                    txtFN4.Enabled = true;
                    txtFN5.Enabled = false;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = true;
                    txtLN4.Enabled = true;
                    txtLN5.Enabled = false;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false; 
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = true;
                    cmbAge4.Enabled = true;
                    cmbAge5.Enabled = false;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 6:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = true;
                    txtFN4.Enabled = true;
                    txtFN5.Enabled = true;
                    txtFN6.Enabled = false;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = true;
                    txtLN4.Enabled = true;
                    txtLN5.Enabled = true;
                    txtLN6.Enabled = false;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = true;
                    cmbAge4.Enabled = true;
                    cmbAge5.Enabled = true;
                    cmbAge6.Enabled = false;
                    cmbAge7.Enabled = false;
                    break;
                case 7:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = true;
                    txtFN4.Enabled = true;
                    txtFN5.Enabled = true;
                    txtFN6.Enabled = true;
                    txtFN7.Enabled = false;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = true;
                    txtLN4.Enabled = true;
                    txtLN5.Enabled = true;
                    txtLN6.Enabled = true;
                    txtLN7.Enabled = false;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = true;
                    cmbAge4.Enabled = true;
                    cmbAge5.Enabled = true;
                    cmbAge6.Enabled = true;
                    cmbAge7.Enabled = false;
                    break;
                case 8:
                    txtFN0.Enabled = true;
                    txtFN1.Enabled = true;
                    txtFN2.Enabled = true;
                    txtFN3.Enabled = true;
                    txtFN4.Enabled = true;
                    txtFN5.Enabled = true;
                    txtFN6.Enabled = true;
                    txtFN7.Enabled = true;
                    txtLN0.Enabled = true;
                    txtLN1.Enabled = true;
                    txtLN2.Enabled = true;
                    txtLN3.Enabled = true;
                    txtLN4.Enabled = true;
                    txtLN5.Enabled = true;
                    txtLN6.Enabled = true;
                    txtLN7.Enabled = true;
                    cmbAge0.Enabled = true;
                    cmbAge1.Enabled = true;
                    cmbAge2.Enabled = true;
                    cmbAge3.Enabled = true;
                    cmbAge4.Enabled = true;
                    cmbAge5.Enabled = true;
                    cmbAge6.Enabled = true;
                    cmbAge7.Enabled = true;
                    break;
                default:
                    break;

            } 
        }

        private void startCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            // this checks the dates selected is valid and calcualtes the number of days the stay is for

            dateChanged dtc = new dateChanged(); // declares an object of class data changed
            if (dtc.isBeforeToday(currentDate.ToString(), startCal.ToString())) // calls function isBeforeToday which returns to see if the date is before today
            {
                lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
            }
            else
            {
                lblNumOfDays.Text = ("Out date is before this day");


            }
        }

        private void endCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            // this checks the dates selected is valid and calcualtes the number of days the stay is for

            dateChanged dtc = new dateChanged();
            if (dtc.isBeforeToday(currentDate.ToString(), endCal.ToString()))
            {


                lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
            }
            else
            {

                lblNumOfDays.Text = ("Return date is before this day");

            }
        }

        private void endCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            // dateChanged dtc = new dateChanged();
            // lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
        }

        private void startCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            //dateChanged dtc = new dateChanged();
            // lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  this changes the inbound airport list depending on what is selected

            if (cmbOutAirport.Text != "") // if the select airport is not blank this block is selected
            {
                // checks to see if there any spaces in the name, and removes them
                string testString = cmbOutAirport.Text;
                string[] testingString = cmbOutAirport.Text.Split(' ');

                if (testingString.Length > 1)
                {
                    testString = cmbOutAirport.Text.Replace(" ", "");
                }

                // populates the outbound airport with the contents of the xml node releating to what was entered
                string[] inBoundList = (popList.updateLists(testString));
                cmbDestPorts.Items.Clear();
                cmbDestPorts.Items.AddRange(inBoundList);
            }
            else // if the selected outbound airport was a blank field,  both inbound and outbound will be populated with the full list of airport
            {
                cmbOutAirport.Items.Clear();
                cmbDestPorts.Items.Clear();
                cmbOutAirport.Items.AddRange(popList.initLists());
                cmbDestPorts.Items.AddRange(popList.initLists());
            }
        }

        private void cmbDestPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestPorts.Text != "") // the same as above but with an extra function to get the weather at the destintation airport
            {
                string inputStr = cmbDestPorts.Text;
                Thread t = new Thread(() => startHTTPWorker(inputStr)); // this starts a new thread to stop any program holds which gets the weather data for the destination airport
                t.Start(); // this starts the new thread exectuing

                string[] testingString = cmbDestPorts.Text.Split(' '); // same as the above function

                if (testingString.Length > 1)
                {
                    inputStr = cmbDestPorts.Text.Replace(" ", "");
                }


                string[] inBoundList = (popList.updateLists(inputStr));
                cmbOutAirport.Items.Clear();
                cmbOutAirport.Items.AddRange(inBoundList);
            }
            else if (cmbDestPorts.Text == "")
            {
                cmbOutAirport.Items.Clear();
                cmbDestPorts.Items.Clear();
                cmbOutAirport.Items.AddRange(popList.initLists());
                cmbDestPorts.Items.AddRange(popList.initLists());

            }
        }

        private void startHTTPWorker(string input) // this is the function which is started by the new thread
        {
            HTTPIO gwc = new HTTPIO(); // creates object of class HTTPIO which handles all internet operations
            changeWeatherIcon((gwc.getWeatherJSON(input)), input); // starts the function selectWeatherIcon with the returned data of of the HTTPIO class

        }

       private void changeWeatherIcon(string weather, string cityName) // this class changes the weather icon depending on the returned string from the HTTPIO class
        {


            MessageBox.Show(weather);


            if (weather == "Clouds")
            {
                weatherString = "Assets/WeatherIcons/Clouds.png";

            }
            else if (weather == "Drizzle")
            {



            }
            else if (weather == "Rain")
            {

                weatherString = "Assets/WeatherIcons/drizzleDay.png";

            }
            else if (weather == "Few Clouds")
            {


            }
            else if (weather == "Sky Is Clear")
            {


            }

        }
        private string[] createNameList() // this method bundles the data correctly for sending to the Quote Page so that an invoice can be created 
        {

            switch (int.Parse(cmbPassangers.Text)) // the case be selected depending on number of passangers selected
            {

                case 0:

                    break;
                case 1:

                    string[] names1 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text}; // delcares an array with the contents of the required firstname, last name and age boxes
                    Quote form1 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names1); // creates an object of the new form, passing the constructor the required data

                    form1.Show(); // calls the method which displays the new form object on the screen
                    

                    break;
                case 2: // and so on
                    string[] names2 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text};
                     Quote form2 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names2);

                    form2.Show();
                    break;
                case 3:
                    string[] names3 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text };
                     Quote form3 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names3);

                    form3.Show();

                    break;
                case 4:
                    string[] names4 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text, txtFN3.Text, txtLN3.Text, cmbAge3.Text };
                     Quote form4 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names4);

                    form4.Show();

                    break;
                case 5:
                    string[] names5 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text, txtFN3.Text, txtLN3.Text, cmbAge3.Text, txtFN4.Text, txtLN4.Text, cmbAge4.Text };
                     Quote form5 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names5);

                    form5.Show();

                    break;
                case 6:
                    string[] names6 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text, txtFN3.Text,txtLN3.Text,cmbAge3.Text, txtFN4.Text, txtLN4.Text, cmbAge4.Text, 
                                            txtFN5.Text, txtLN5.Text, cmbAge5.Text};
                     Quote form6 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names6);

                    form6.Show();


                    break;
                case 7:
                    string[] names7 = { txtFN0.Text, txtLN0.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text, txtFN3.Text,txtLN3.Text,cmbAge3.Text, txtFN4.Text, txtLN4.Text, cmbAge4.Text, 
                                            txtFN5.Text, txtLN5.Text, cmbAge5.Text, txtFN6.Text, txtLN6.Text, cmbAge6.Text};
                     Quote form7 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names7);

                    form7.Show();

                  break;
                case 8:
                  string[] names8 = { txtFN0.Text, txtLN1.Text, cmbAge0.Text, txtFN1.Text, txtLN1.Text, cmbAge1.Text, txtFN2.Text, txtLN2.Text, cmbAge2.Text, txtFN3.Text, txtLN3.Text, cmbAge3.Text, txtFN4.Text, txtLN4.Text, cmbAge4.Text, 
                                            txtFN5.Text, txtLN5.Text, cmbAge5.Text, txtFN6.Text, txtLN6.Text, cmbAge6.Text, txtFN7.Text, txtLN7.Text, cmbAge7.Text};

                  Quote form8 = new Quote(cmbHolTYpe.Text, cmbPassangers.Text, cmbOutAirport.Text, cmbDestPorts.Text, chkFC.Checked, names8);

                    form8.Show();

                    break;
                default:
                    break;
            }

            return null;
        }
        private void btnGetPrices_Click(object sender, EventArgs e) // this method is called when the button to get prices is clicked
        {
            if (cmbDestPorts.Text == "" || cmbOutAirport.Text == "") // checks that two airports are selected
            {

                MessageBox.Show("You've not select two airports "); // displays message to user if they are not

            }
            else if (cmbHolTYpe.Text == "Select from Type...") // if there was not a type of holiday selected, this will be called
            {

                MessageBox.Show("You have not select type of holiday"); // display message to user



            }
            else if (cmbHolTYpe.Text != "Select from Type...") // if all is correct
            {
                createNameList(); // calls the function which bundles the name data for sending to the quotes page

            }   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherForecast wfFrm = new WeatherForecast(startCal.ToString(), endCal.ToString(), cmbDestPorts.Text); // creates a weather forecast class passing data to it's constructor, to open full weather forecast
          
        }

        private void tmrIsCompleted_Tick(object sender, EventArgs e) // timer checks weather the thread has completed to change the contents of the picutre box to the weather icon
        {
            if (weatherString != "")
            {
                tmrISCompleted.Enabled = false;

                pictureBox1.ImageLocation = weatherString;
            }
        }

        private void cmbHolTYpe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // opens up the administration form and hides the current one
        {
            adminForm frm = new adminForm();

            frm.Show();
            this.Hide();
        }

        private void cmbPassangers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e) // closes the form if the exit button is clicked
        {
            Environment.Exit(0);
        }


    }
}
