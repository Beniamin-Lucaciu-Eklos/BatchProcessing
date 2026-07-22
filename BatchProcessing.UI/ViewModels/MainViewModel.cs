using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcessing.UI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly string ButtonActive = "active";

        public MainViewModel()
        {
            CurrentPage = _homePage;
        }

        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia!";

        [ObservableProperty]
        private bool _sideMenuExpanded;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HomeButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(ProcessButtonIsActive))]
        private ViewModelBase _currentPage;

        public bool HomeButtonIsActive => _currentPage == _homePage;
        public bool ProcessButtonIsActive => _currentPage == _processPage;
        public bool ActionsButtonIsActive => _currentPage == _actionsPage;  
        public bool MacrosButtonIsActive => _currentPage == _macrosPage;
        public bool ReporterButtonIsActive => _currentPage == _reporterPage;
        public bool HistoryButtonIsActive => _currentPage == _historyPage;

        private readonly HomePageViewModel _homePage = new();
        private readonly ProcessPageViewModel _processPage = new();
        private readonly ActionsPageViewModel _actionsPage = new();
        private readonly MacrosPageViewModel _macrosPage = new();
        private readonly ReporterPageViewModel _reporterPage = new();
        private readonly HistoryPageViewModel _historyPage = new();

        [RelayCommand]
        private void SideMenuResize()
        {
            SideMenuExpanded = !SideMenuExpanded;
        }

        [RelayCommand]
        private void GoToHomePage() => CurrentPage = _homePage;


        [RelayCommand]
        private void GoToProcessPage() => CurrentPage = _processPage;

        [RelayCommand]
        private void GoToActionsPage() => CurrentPage = _actionsPage;

        [RelayCommand]
        private void GoToMacrosPage() => CurrentPage = _macrosPage;

        [RelayCommand]
        private void GoToReporterPage() => CurrentPage = _reporterPage;

        [RelayCommand]
        private void GoToHistoryPage() => CurrentPage = _historyPage;


    }
}
