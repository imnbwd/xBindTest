using Windows.UI.Xaml.Controls;
using xBindTest.ViewModels;

namespace xBindTest.Controls
{
    public sealed partial class BindToEventControl : UserControl
    {
        public BindToEventControl()
        {
            this.InitializeComponent();
            ViewModel = new BindToEventViewModel();
        }

        public BindToEventViewModel ViewModel { get; set; }
    }
}