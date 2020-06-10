using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNames
{
    class ViewModel
    {
        private string[] newMonthNames = new string[12];

        public string[] NewMonthNames
        {
            get
            {
                return newMonthNames;
            }
            set
            {
                newMonthNames = value;
            }
        }
    }
}
