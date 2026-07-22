using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class ReporterPageViewModel : PageViewModel
    {
        public ReporterPageViewModel()
        {
            PageName = ApplicationPageName.Reporter;
        }

        [ObservableProperty]
        private string _title = "Reporter Page";       
    }
}
