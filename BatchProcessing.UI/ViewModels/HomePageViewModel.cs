using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchProcessing.UI.ViewModels
{
    public partial class HomePageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _title = "HomePage";
    }
}
