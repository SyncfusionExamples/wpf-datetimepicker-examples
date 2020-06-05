using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEdit_sample
{
    class ViewModel : NotificationObject
    {
        private DateTime selectedDate= DateTime.Now;
        private DateTime selectedTime = DateTime.Now;

        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value;
                this.RaisePropertyChanged(nameof(SelectedDate));
            }
        }

        public DateTime SelectedTime
        {
            get
            {
                return selectedTime;
            }
            set
            {
                selectedTime = value;
                this.RaisePropertyChanged(nameof(SelectedTime));
            }
        }
    }
}
