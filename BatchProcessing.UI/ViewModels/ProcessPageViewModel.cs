using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcessing.UI.ViewModels
{
    public partial class ProcessPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "ProcessPage";
    }
}
