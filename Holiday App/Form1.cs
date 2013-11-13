using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Holiday_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populateOutBoundAirport popList = new populateOutBoundAirport();
            
           cmbOutAirport.Items.AddRange(popList.initLists());
           cmbDestPorts.Items.AddRange(popList.initLists());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPassangers_TextChanged(object sender, EventArgs e)
        {
            
            switch(int.Parse(cmbPassangers.Text))
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
                    txtLN7.Enabled = false;cmbAge0.Enabled = false;
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
            
            MessageBox.Show("Box was changed");
        }

        private void startCal_DateChanged(object sender, DateRangeEventArgs e)
        {
          //  Console.WriteLine(startCal.DateSelected);
            
            dateChanged dtc = new dateChanged();
            lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
            
        }

        private void endCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateChanged dtc = new dateChanged();
            lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
        }

        private void endCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateChanged dtc = new dateChanged();
            lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
        }

        private void startCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateChanged dtc = new dateChanged();
            lblNumOfDays.Text = (dtc.calculateLength(startCal.ToString(), endCal.ToString()));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getWeatherClass gwc = new getWeatherClass();
            gwc.getWeatherJSON(cmbOutAirport.Text);
            populateOutBoundAirport popLists = new populateOutBoundAirport();
            string [] inBoundList = (popLists.updateLists(cmbOutAirport.Text));
            cmbDestPorts.Items.AddRange(inBoundList);
        }

        private void cmbDestPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
