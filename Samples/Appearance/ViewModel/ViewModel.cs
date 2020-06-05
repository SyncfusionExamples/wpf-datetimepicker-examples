using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Media;

namespace Themes
{
    class ViewModel : NotificationObject
    {
        private FlowDirection flowDirection;
        private Brush background = Brushes.Yellow;
        private Brush selectionBrush = Brushes.Orange;
        private Brush foreground = Brushes.Red;

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaisePropertyChanged(nameof(Background));
            }
        }

        public Brush SelectionBrush
        {
            get { return selectionBrush; }
            set
            {
                selectionBrush = value;
                this.RaisePropertyChanged(nameof(SelectionBrush));
            }
        }

        public Brush Foreground
        {
            get { return foreground; }
            set
            {
                foreground = value;
                this.RaisePropertyChanged(nameof(Foreground));
            }
        }

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }

        public ViewModel()
        {

        }
    }
}