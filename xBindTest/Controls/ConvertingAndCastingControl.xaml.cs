using System;
using System.ComponentModel;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace xBindTest.Controls
{
    public sealed partial class ConvertingAndCastingControl : UserControl, INotifyPropertyChanged
    {
        private bool _isPass;
        public double Number { get; set; }

        public ConvertingAndCastingControl()
        {
            this.InitializeComponent();
            Number = 123.65;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsPass
        {
            get { return _isPass; }
            set
            {
                if (_isPass != value)
                {
                    _isPass = value;
                    RaisePropertyChanged("IsPass");
                }
            }
        }

        public Brush GetBrush(bool isPass)
        {
            return isPass ? new SolidColorBrush(Colors.LimeGreen) : new SolidColorBrush(Colors.Crimson);
        }

        // both public and private work well
        private ImageSource GetImage(bool isPass)
        {
            return isPass ? new BitmapImage(new Uri("ms-appx:///Assets/Happy.png")) : new BitmapImage(new Uri("ms-appx:///Assets/Sad.png"));
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}