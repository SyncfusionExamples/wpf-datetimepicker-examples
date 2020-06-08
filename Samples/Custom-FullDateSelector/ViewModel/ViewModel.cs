
using Syncfusion.Windows.Shared;
using System;

namespace Custom_FullDateSelector
{
    class ViewModel : NotificationObject
    {
        private DateTime selectedDate = DateTime.Now;

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
    }
}
