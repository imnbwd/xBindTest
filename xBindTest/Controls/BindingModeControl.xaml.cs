using System.ComponentModel;
using Windows.UI.Xaml.Controls;

namespace xBindTest.Controls
{
    public sealed partial class BindingModeControl : UserControl, INotifyPropertyChanged
    {
        private string _infoB;
        private string _infoC;

        public BindingModeControl()
        {
            this.InitializeComponent();

            InfoA = "InfoA: Value for x:Bind (Mode=One Time)";
            InfoB = "InfoB: Value for x:Bind (Mode=One Way)";
            InfoC = "InfoC: Value for x:Bind (Mode=One Time)";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// OneTime (Cannot be updated)
        /// </summary>
        public string InfoA { get; set; }

        /// <summary>
        /// OneWay (Updated by invoking PropertyChanged)
        /// </summary>
        public string InfoB
        {
            get { return _infoB; }
            set
            {
                if (_infoB != value)
                {
                    _infoB = value;
                    RaisePropertyChanged("InfoB");
                }
            }
        }

        /// <summary>
        /// OneTime (Updated by Bindings.Update())
        /// </summary>
        public string InfoC
        {
            get { return _infoC; }
            set
            {
                if (_infoC != value)
                {
                    _infoC = value;
                    RaisePropertyChanged("InfoC");
                }
            }
        }

        private void btnUpdateValueForOneTime_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            InfoC = "InfoC: Value updated by this.Bindings.Update() method";
            this.Bindings.Update();
        }

        private void btnUpdateValueForOneWay_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            InfoB = "InfoB: Value Updated";
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}