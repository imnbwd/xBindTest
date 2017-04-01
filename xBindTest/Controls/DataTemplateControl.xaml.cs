using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using xBindTest.Models;

namespace xBindTest.Controls
{
    public sealed partial class DataTemplateControl : UserControl
    {
        public DataTemplateControl()
        {
            this.InitializeComponent();
            this.Loaded += DataTemplateControl_Loaded;
            AllFriends = new ObservableCollection<Friend>();
        }

        private void DataTemplateControl_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            AllFriends.Add(new Friend { Name = "Jack", BirthDate = new DateTime(1980, 4, 1), Email = "jack@xxx.com" });
            AllFriends.Add(new Friend { Name = "Lily", BirthDate = new DateTime(1978, 12, 9), Email = "lily@xxx.com" });
            AllFriends.Add(new Friend { Name = "Frank", BirthDate = new DateTime(1983, 8, 17), Email = "frank@xxx.com" });
        }

        public ObservableCollection<Friend> AllFriends { get; set; }
    }
}