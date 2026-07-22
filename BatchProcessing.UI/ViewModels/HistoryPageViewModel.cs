using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class HistoryPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "HistoryPage";
    }
}
