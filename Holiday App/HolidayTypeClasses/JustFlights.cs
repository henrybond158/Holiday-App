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
using System.Linq;
using System.Text;

namespace Holiday_App.HolidayTypeClasses
{
   class JustFlights : BaseHolidayClass
   {

      
      
       public JustFlights() 
       {

       }

       public string[] initForm() // function for setting the text in the options
       {


           initFormReturn[0] = "You have selected Just Flights";
           initFormReturn[1] = "You have selected Just Flights";
           initFormReturn[2] = "You have selected Just Flights";
           initFormReturn[3] = "You have selected Just Flights";
           initFormReturn[4] = "You have selected Just Flights";
           initFormReturn[5] = "You have selected Just Flights";
           return initFormReturn;
       }


    }
}
