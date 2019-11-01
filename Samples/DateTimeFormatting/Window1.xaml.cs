using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Syncfusion.Windows.Shared;

namespace DateTimeFormatting
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        #region Constructor

        public Window2()
        {
            InitializeComponent();

            this.Loaded += (sender, e) =>
            {
                foreach (DateTimeEdit dateTimeEdit in FindVisualChildren<DateTimeEdit>(this))
                {
                    dateTimeEdit.GotFocus += (s, args) =>
                    {
                        focusedDateTimeEdit = s as DateTimeEdit;

                        if (focusedDateTimeEdit == patternDT)
                            cmbopattern.IsEnabled = true;
                        else
                            cmbopattern.IsEnabled = false;

                        if (focusedDateTimeEdit == cultureDT)
                            comboculture.IsEnabled = true;
                        else
                            comboculture.IsEnabled = false;
                    };
                }
            };
        }

        DateTimeEdit focusedDateTimeEdit;

        #endregion

        #region Helper Methods

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        #endregion

    }
}
