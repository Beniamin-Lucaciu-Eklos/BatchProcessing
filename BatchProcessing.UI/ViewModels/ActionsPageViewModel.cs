using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class SettingsPageViewModel : PageViewModel
    {
        public SettingsPageViewModel()
        {
            PageName = ApplicationPageName.Settings;
        }

        [ObservableProperty]
        private string _title = "Settings";
    }
    
}
