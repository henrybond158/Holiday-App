﻿/********************************************************************************
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
using System.Linq;
using System.Text;
using System.Net;

namespace Holiday_App
{
    class dateChanged 
    {
       

        public string calculateLength (string firstDate, string secondDate) // this method calcualtes the length of the two selected dates
        {

            string returnString; // declares string
            string[] firstDateSplit = (firstDate.Split(':')); // splits the string where there are :
            string firstDateFixer = firstDateSplit[2]; // selectes the one where the date is held
            string[] firstFixedString = firstDateFixer.Split(' '); // splits the string where there is a space so that the date is correct
            string[] secondDateSplit = (secondDate.Split(':')); // same as above but for second date
            string secondDateFixer = secondDateSplit[2];
            string[] secondFixedString = secondDateFixer.Split(' ');

           DateTime firstDateDT = Convert.ToDateTime(firstFixedString[1]); //declares to objects of class date time so that we can work out the difference using in built classes
           DateTime secondDateDT = Convert.ToDateTime(secondFixedString[1]);

           double numberofDays = (secondDateDT - firstDateDT).TotalDays; // using the TotalDays method of the datetime class, we calcualte the number of days
           if (numberofDays >= 0) // if the number  is greater or equal to zero, this is called
           {

               returnString = ("Number of Days: " + (numberofDays.ToString())); // returns the string of the calculate number of days

           }

           else
           {

               returnString = "The start date is after the return date"; // if the returned number is less than 0, then a negative number has been calculated, meaning the return date is before the outbound date

           }
           return returnString;

        }
        public bool isBeforeToday(string firstDate, string secondDate) // this method calcualtes whether the date selected is before todays date
        {
           
            string[] firstDateSplit = (firstDate.Split(':'));
            string firstDateFixer = firstDateSplit[2];
            string[] firstFixedString = firstDateFixer.Split(' ');
            string[] secondDateSplit = (secondDate.Split(':'));
            string secondDateFixer = secondDateSplit[2];
            string[] secondFixedString = secondDateFixer.Split(' '); 

            DateTime firstDateDT = Convert.ToDateTime(firstFixedString[1]);
            DateTime secondDateDT = Convert.ToDateTime(secondFixedString[1]); // same as above

            double numberofDays = (secondDateDT - firstDateDT).TotalDays;  // same calcualtion as above
            if (numberofDays < 0) // if less than 0, returns false
            {

                return false;
            }
            
            return true;
        }





    }
}
