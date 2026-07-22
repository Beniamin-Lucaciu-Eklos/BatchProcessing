using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class ReporterPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "Reporter Page";
    }
}
