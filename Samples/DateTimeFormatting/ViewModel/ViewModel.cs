using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DateTimeFormatting
{
    class ViewModel : NotificationObject
    {

        private ObservableCollection<string> eventLogsCollection;

        public ObservableCollection<string> EventLogsCollection
        {
            get { return eventLogsCollection; }
            set
            {
                eventLogsCollection = value;
                this.RaisePropertyChanged(() => this.EventLogsCollection);
            }
        }
        ObservableCollection<string> coll = new ObservableCollection<string>();

        private ICommand patternChangedCommand;
        public ICommand PatternChangedCommand
        {
            get
            {
                if (patternChangedCommand == null)
                {
                    patternChangedCommand = new DelegateCommand<object>(PatternChanged);
                }
                return patternChangedCommand;
            }


        }

        private DateTimePattern pattern = DateTimePattern.LongDate;
        public DateTimePattern Pattern
        {
            get
            {
                return pattern;
            }
            set
            {
                pattern = value;
                RaisePropertyChanged(() => this.Pattern);
            }

        }

        public void PatternChanged(object param)
        {
            
                AddLog("Pattern changed: " + Pattern.ToString());

        }
       
        private void AddLog(string eventlog)
        {
            coll.Add(eventlog);
            EventLogsCollection = coll;
        }

    }
}
