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
 *  that it will be useful, but WITHOUT ANY WARRANTY; without even the implied  *                                                *
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.             *
 * See the GNU General Public License for more details.                         *         *
 *                                                                              *
 * You should have received a copy of the GNU General Public License            *
 * along with  My Holiday planning coursework app.                              *
 * If not, see <http://www.gnu.org/licenses/>.                                  *
 *                                                                              *
 *******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Holiday_App
{
    class dateChanged 
    {
       

        public string calculateLength (string firstDate, string secondDate)
        {



            string returnString;
            string[] firstDateSplit = (firstDate.Split(':'));
            string firstDateFixer = firstDateSplit[2];
            string[] firstFixedString = firstDateFixer.Split(' ');
            string[] secondDateSplit = (secondDate.Split(':'));
            string secondDateFixer = secondDateSplit[2];
            string[] secondFixedString = secondDateFixer.Split(' ');

           DateTime firstDateDT = Convert.ToDateTime(firstFixedString[1]);
           DateTime secondDateDT = Convert.ToDateTime(secondFixedString[1]);

           double numberofDays = (secondDateDT - firstDateDT).TotalDays;
           if (numberofDays >= 0)
           {

               returnString = ("Number of Days: " + (numberofDays.ToString()));

           }

           else
           {

               returnString = "The start date is after the return date";

           }
           return returnString;

        }
        public bool isBeforeToday(string firstDate, string secondDate)
        {
           
            string[] firstDateSplit = (firstDate.Split(':'));
            string firstDateFixer = firstDateSplit[2];
            string[] firstFixedString = firstDateFixer.Split(' ');
            string[] secondDateSplit = (secondDate.Split(':'));
            string secondDateFixer = secondDateSplit[2];
            string[] secondFixedString = secondDateFixer.Split(' ');

            DateTime firstDateDT = Convert.ToDateTime(firstFixedString[1]);
            DateTime secondDateDT = Convert.ToDateTime(secondFixedString[1]);

            double numberofDays = (secondDateDT - firstDateDT).TotalDays;
            if (numberofDays < 0)
            {

                return false;
            }
            
            return true;
        }





    }
}
