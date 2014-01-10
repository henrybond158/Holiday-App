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
using System.IO;

namespace Holiday_App
{
    public partial class staffView : Form
    {
        
        public staffView(double flights, int hotels, int extra, bool FC ,string[] namesArray)
        {
            InitializeComponent();
            
            lblFlights.Text = ("£" + flights.ToString());
            lblHotels.Text = ("£" + hotels.ToString());
            lblExtras.Text = ("£" + extra.ToString());
            double profit = (flights + hotels + extra) * 0.1;
            lblProfit.Text = ("£" + profit.ToString());
            if (!FC)
            {
                double total = (flights + hotels + extra + profit);
            }
            else
            {
                double total = ((flights + hotels + extra + profit) * 2);

            }
            createInvoice(flights,hotels,extra, namesArray);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe", "invoice.txt");
        }
        private void createInvoice(double flights, int hotels, int extra, string[]NamesArray)
        {
            
            StreamWriter textW = File.CreateText("invoice.txt");
            textW.WriteLine("Invoice for " + NamesArray[0] + " " + NamesArray[1]);
            textW.WriteLine("Passangers: ");
            int counter = 0;
            string[] temp = new string[3];
            foreach (string str in NamesArray)
            {
                temp[counter] = str;
                counter++;
                    
                if (counter == 3)
                {
                    textW.WriteLine(temp[0] + " " + temp[1] + " " + temp[2]);
                    counter = 0;
                }

            }

            textW.Close();

        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }
    }
}
