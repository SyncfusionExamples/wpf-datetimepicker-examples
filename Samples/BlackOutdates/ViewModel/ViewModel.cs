
using Syncfusion.Windows.Shared;
using System;
using System.Windows.Input;

namespace BlackOutdates
{
    class ViewModel
    {
        private ICommand loadedCommand;

        public ICommand LoadedCommand
        {
            get
            {
                return loadedCommand;
            }
        }
        public ViewModel()
        {
            loadedCommand = new DelegateCommand<object>(loadedCommandChanged);
        }

        private void loadedCommandChanged(object obj)
        {
            DateTimeEdit dateTimeEdit = obj as DateTimeEdit;
            //Setting start and end range for blocking dates
            DateTime StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
            Syncfusion.Windows.Controls.CalendarDateRange blackOutDays = new Syncfusion.Windows.Controls.CalendarDateRange()
            {
                Start = StartDate,
                End = EndDate
            };
            Syncfusion.Windows.Controls.Calendar calendar = dateTimeEdit.DateTimeCalender as Syncfusion.Windows.Controls.Calendar;
            calendar.BlackoutDates.Add(blackOutDays);
        }
    }
}
