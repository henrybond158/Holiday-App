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
