using BatchProcessing.UI.Data;
using BatchProcessing.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchProcessing.UI.Factories
{
    public class PageFactory
    {
        private readonly Func<ApplicationPageName, PageViewModel> _factory;

        public PageFactory(Func<ApplicationPageName, PageViewModel> factory)
        {
            _factory = factory;
        }

        public PageViewModel GetPageViewModel(ApplicationPageName pageName)
            => _factory(pageName);
    }
}
