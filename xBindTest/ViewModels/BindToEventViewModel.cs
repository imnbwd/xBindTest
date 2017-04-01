using Windows.UI.Xaml;

namespace xBindTest.ViewModels
{
    public class BindToEventViewModel : BindableBase
    {
        private string _info;

        /// <summary>
        /// Get or set Info value
        /// </summary>
        public string Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }

        public void ShowInfoTest1()
        {
            Info = "Update Info in method: ShowInfoTest1()";
        }

        public void ShowInfoTest2(object sender, RoutedEventArgs e)
        {
            Info = $"Update Info in method: ShowInfoTest2(object sender, RoutedEventArgs e)";
        }

        public void ShowInfoTest3(object sender, object e)
        {
            Info = $"Update Info in method: ShowInfoTest3(object sender, object e)";
        }
    }
}