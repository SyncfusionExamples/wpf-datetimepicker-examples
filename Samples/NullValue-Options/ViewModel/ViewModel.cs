using Syncfusion.Windows.Shared;

namespace NullValue_Options
{
    class ViewModel : NotificationObject
    {
        private string noneDateText = "Choose a date";

        public string NoneDateText
        {
            get { return noneDateText; }
            set
            {
                noneDateText = value;
                this.RaisePropertyChanged(nameof(NoneDateText));
            }
        }
    }
}
