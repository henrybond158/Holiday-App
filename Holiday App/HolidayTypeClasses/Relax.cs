using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holiday_App.HolidayTypeClasses
{
    class Relax : BaseHolidayClass
    {

        
           public Relax(int numberOfPassangers, bool firstClass) 
       {
           numberOfCustomers = numberOfPassangers;
           hotelRequired = true;
           extrasIncluded = 1;
            

       }
    }
}
