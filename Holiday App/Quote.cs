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
using System.Net;
using System.IO;
using System.Threading;

namespace Holiday_App
{
    public partial class Quote : Form
    {

        bool isFinnished = false;
        double distance;
        double price;
        int numberOfPassangers;
        public Quote(string holidayType, string testString, string inputAirport, string DestAirport)
        {
            InitializeComponent();

            callClass(holidayType);
            lblResults.Text = testString;
            numberOfPassangers = int.Parse(testString);
            Thread t = new Thread(() => getPrice(inputAirport, DestAirport));
            t.Start();
       
            
        }
        private void callClass(string holType)
        {


            switch (holType)
            {

                case "Just Flights":
                    HolidayTypeClasses.JustFlights holiday = new HolidayTypeClasses.JustFlights(numberOfPassangers,false);
                    break;
                case "Relax":
                    MessageBox.Show("relax");
                    break;
                case "Adventure":
                    MessageBox.Show("Adventure");
                    break;
                case "Cultural":
                    MessageBox.Show("Cultraul");
                    break;

                default:
                    MessageBox.Show("something went wrong");
                    break;
                // Just Flights
                //Relax
                //Cultural
                //Adventure
            }

        }
        private void Quote_Load(object sender, EventArgs e)
        {

        }
       

        private void getPrice(string inputAirport, string destAirport)
        {
            HTTPIO httpIO = new HTTPIO();

            distance = httpIO.getDistance(inputAirport, destAirport);
            distance = distance * 0.001;
            
            if (distance == 0)
            {

                MessageBox.Show("Something went wrong");

            }
            else if (distance > 0 && distance < 99)
            {
                MessageBox.Show("between 0 and 99");
                price = distance / 2;


            }
            else if (distance > 100 && distance < 500)
            {

                MessageBox.Show("Between 100 and 500");
                price = distance / 10;

            }
            else if (distance > 500 && distance < 750)
            {

                MessageBox.Show("between 500 & 750");
                price = distance / 9;

            }
            else if (distance > 750 && distance < 1250)
            {

                MessageBox.Show("between 750 & 1250");
                price = distance / 3;
            }
            else if (distance > 1250)
            {
                price = distance / 5;


            }
            

           
            isFinnished = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isFinnished == true)
            {

                lblBasePrice.Text = ("£" + (price * numberOfPassangers).ToString() );
                timer1.Enabled = false;

            }
        }

        
    }
}
