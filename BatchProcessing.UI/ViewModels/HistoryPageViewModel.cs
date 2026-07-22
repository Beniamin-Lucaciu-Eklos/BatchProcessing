using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class HistoryPageViewModel : PageViewModel
    {
        public HistoryPageViewModel()
        {
            PageName = ApplicationPageName.History;
        }

        [ObservableProperty]
        private string _title = "HistoryPage";
    }
}
