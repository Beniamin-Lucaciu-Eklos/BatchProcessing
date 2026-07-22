using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class MacrosPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "Macros";
    }

}
