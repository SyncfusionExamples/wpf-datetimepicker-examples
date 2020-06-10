
using Syncfusion.Windows.Shared;
using System.Windows.Media;

namespace Dropdown_Options
{
    class ViewModel : NotificationObject
    {
        private DropDownViews dropDownView= DropDownViews.Calendar;
        private TodayButtonAction todayButtonAction= TodayButtonAction.DateTime;
        private bool isEmptyDateEnabled= false;
        private bool isButtonPopUpEnabled = true;
        private bool canEdit;
        private bool enableMouseWheelEdit = true;
        private bool isVisibleRepeatButton= true;
        private bool isEnabledRepeatButton = true;
        private bool enableAlphaKeyNavigation = true;
        private bool enableDeleteKey= true;
        private bool enableBackspaceKey= true;
        private OnFocusBehavior onFocusBehavior= OnFocusBehavior.CursorAtEnd;
        private Brush repeatButtonBackground= Brushes.Red;

        #region Popup DateTime Selector
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
        #endregion


        #region DateTime Editing

        public bool CanEdit
        {
            get
            {
                return canEdit;
            }
            set
            {
                canEdit = value;
                this.RaisePropertyChanged(nameof(CanEdit));
            }
        }
        public bool EnableMouseWheelEdit
        {
            get
            {
                return enableMouseWheelEdit;
            }
            set
            {
                enableMouseWheelEdit = value;
                this.RaisePropertyChanged(nameof(EnableMouseWheelEdit));
            }
        }
         public bool IsVisibleRepeatButton
        {
            get
            {
                return isVisibleRepeatButton;
            }
            set
            {
                isVisibleRepeatButton = value;
                this.RaisePropertyChanged(nameof(IsVisibleRepeatButton));
            }
        }
         public bool IsEnabledRepeatButton
        {
            get
            {
                return isEnabledRepeatButton;
            }
            set
            {
                isEnabledRepeatButton = value;
                this.RaisePropertyChanged(nameof(IsEnabledRepeatButton));
            }
        }
        public bool EnableAlphaKeyNavigation
        {
            get
            {
                return enableAlphaKeyNavigation;
            }
            set
            {
                enableAlphaKeyNavigation = value;
                this.RaisePropertyChanged(nameof(EnableAlphaKeyNavigation));
            }
        }
        
        public bool EnableDeleteKey
        {
            get
            {
                return enableDeleteKey;
            }
            set
            {
                enableDeleteKey = value;
                this.RaisePropertyChanged(nameof(EnableDeleteKey));
            }
        }
        
        public bool EnableBackspaceKey
        {
            get
            {
                return enableBackspaceKey;
            }
            set
            {
                enableBackspaceKey = value;
                this.RaisePropertyChanged(nameof(EnableBackspaceKey));
            }
        } 
        
        public OnFocusBehavior OnFocusBehavior
        {
            get
            {
                return onFocusBehavior;
            }
            set
            {
                onFocusBehavior = value;
                this.RaisePropertyChanged(nameof(OnFocusBehavior));
            }
        }

        public Brush RepeatButtonBackground
        {
            get { return repeatButtonBackground; }
            set
            {
                repeatButtonBackground = value;
                this.RaisePropertyChanged(nameof(RepeatButtonBackground));
            }
        }

        #endregion
    }
}
