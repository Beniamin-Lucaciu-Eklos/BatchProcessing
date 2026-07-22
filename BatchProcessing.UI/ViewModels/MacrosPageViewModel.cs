using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class MacrosPageViewModel : PageViewModel
    {
        public MacrosPageViewModel()
        {
            PageName = ApplicationPageName.Macros;
        }

        [ObservableProperty]
        private string _title = "Macros";
    }

}
