
using Syncfusion.Windows.Shared;

namespace Dropdown_Options
{
    class ViewModel : NotificationObject
    {
        private DropDownViews dropDownView= DropDownViews.Calendar;
        private TodayButtonAction todayButtonAction= TodayButtonAction.DateTime;
        private bool isEmptyDateEnabled= false;
        private bool isButtonPopUpEnabled = true;

        public DropDownViews DropDownView
        {
            get
            {
                return dropDownView;
            }
            set
            {
                dropDownView = value;
                this.RaisePropertyChanged(nameof(DropDownView));
            }
        }
        
        public TodayButtonAction TodayButtonAction
        {
            get
            {
                return todayButtonAction;
            }
            set
            {
                todayButtonAction = value;
                this.RaisePropertyChanged(nameof(TodayButtonAction));
            }
        }
        
        public bool IsEmptyDateEnabled
        {
            get
            {
                return isEmptyDateEnabled;
            }
            set
            {
                isEmptyDateEnabled = value;
                this.RaisePropertyChanged(nameof(IsEmptyDateEnabled));
            }
        }
        
        public bool IsButtonPopUpEnabled
        {
            get
            {
                return isButtonPopUpEnabled;
            }
            set
            {
                isButtonPopUpEnabled = value;
                this.RaisePropertyChanged(nameof(IsButtonPopUpEnabled));
            }
        }
    }
}
