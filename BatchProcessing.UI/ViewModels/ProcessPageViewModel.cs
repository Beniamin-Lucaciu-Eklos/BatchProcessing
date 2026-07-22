using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class ProcessPageViewModel : PageViewModel
    {
        public ProcessPageViewModel()
        {
            PageName = ApplicationPageName.Process;
        }

        [ObservableProperty]
        private string _title = "ProcessPage";
    }
}
