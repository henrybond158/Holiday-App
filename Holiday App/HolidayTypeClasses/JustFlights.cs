using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holiday_App.HolidayTypeClasses
{
   class JustFlights : BaseHolidayClass
   {

      
       public JustFlights(int numberOfPassangers, bool firstClass) 
       {
           numberOfCustomers = numberOfPassangers;
           hotelRequired = false;
           extrasIncluded = 0;
            

       }

       public string[] returnData()
       {

           return null;
       }


    }
}
