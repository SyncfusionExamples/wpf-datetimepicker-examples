using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDayNames.ViewModel
{
    class ViewModel
    {
        private string[] newWeekDayNames = new string[7];

        public string[] NewWeekDayNames
        {
            get
            {
                return newWeekDayNames;
            }
            set
            {
                newWeekDayNames = value;
            }
        }
    }
}
