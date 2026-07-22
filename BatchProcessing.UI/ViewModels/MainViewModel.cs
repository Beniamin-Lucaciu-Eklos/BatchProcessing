using BatchProcessing.UI.Data;
using BatchProcessing.UI.Factories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcessing.UI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly PageFactory _pageFactory;

        public MainViewModel(PageFactory pageFactory)
        {
            _pageFactory = pageFactory;

            GoToHomePage();
        }

        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia!";

        [ObservableProperty]
        private bool _sideMenuExpanded;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HomeButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(ProcessButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(ActionsButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(MacrosButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(ReporterButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(HistoryButtonIsActive))]
        [NotifyPropertyChangedFor(nameof(SettingsButtonIsActive))]
        private PageViewModel _currentPage;

        public bool HomeButtonIsActive => _currentPage.PageName == ApplicationPageName.Home;
        public bool ProcessButtonIsActive => _currentPage.PageName == ApplicationPageName.Process;
        public bool ActionsButtonIsActive => _currentPage.PageName == ApplicationPageName.Actions;
        public bool MacrosButtonIsActive => _currentPage.PageName == ApplicationPageName.Macros;
        public bool ReporterButtonIsActive => _currentPage.PageName == ApplicationPageName.Reporter;
        public bool HistoryButtonIsActive => _currentPage.PageName == ApplicationPageName.History;
        public bool SettingsButtonIsActive => _currentPage.PageName == ApplicationPageName.Settings;

        [RelayCommand]
        private void SideMenuResize()
        {
            SideMenuExpanded = !SideMenuExpanded;
        }

        [RelayCommand]
        private void GoToHomePage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Home);

        [RelayCommand]
        private void GoToProcessPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Process);

        [RelayCommand]
        private void GoToActionsPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Actions);

        [RelayCommand]
        private void GoToMacrosPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Macros);

        [RelayCommand]
        private void GoToReporterPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Reporter);

        [RelayCommand]
        private void GoToHistoryPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.History);

        [RelayCommand]
        private void GoToSettingsPage() => CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageName.Settings);
    }
}
