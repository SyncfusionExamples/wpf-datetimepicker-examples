using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateTimeEdit_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ToggleButton todayButton;
        public MainWindow()
        {
            InitializeComponent();
            dateTimeEdit.IsDropDownOpenChanged += DateTimeEdit_IsDropDownOpenChanged;
        }

        private void DateTimeEdit_IsDropDownOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (dateTimeEdit.IsDropDownOpen)
            {
                todayButton = dateTimeEdit.Template.FindName("Button_Today_Classic", dateTimeEdit) as ToggleButton;
                if (todayButton != null)
                {
                    todayButton.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
