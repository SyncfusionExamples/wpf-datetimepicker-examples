using Syncfusion.Windows.Shared;
using System;

namespace Data_Binding
{
    public class ViewModel : NotificationObject
    {
        private DateTime selectedDateTime =DateTime.Now;

        public DateTime SelectedDateTime
        {
            get
            {
                return selectedDateTime;
            }
            set
            {
                selectedDateTime = value;
                this.RaisePropertyChanged(nameof(SelectedDateTime));
            }
        }
        public ViewModel()
        {

        }
    }
}
