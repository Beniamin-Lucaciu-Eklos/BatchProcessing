using Avalonia.Controls;
using BatchProcessing.UI.ViewModels;

namespace BatchProcessing.UI.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Image_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            if (e.ClickCount != 2)
                return;

            if (DataContext is MainViewModel viewModel)
            {
                viewModel.SideMenuResizeCommand.Execute(null);
            }
        }
    }
}