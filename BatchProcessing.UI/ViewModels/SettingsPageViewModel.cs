using BatchProcessing.UI.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class ActionsPageViewModel : PageViewModel
    {
        public ActionsPageViewModel()
        {
            PageName = ApplicationPageName.Actions;
        }

        [ObservableProperty]
        private string _title = "ActionsPage";
    }
    
}
