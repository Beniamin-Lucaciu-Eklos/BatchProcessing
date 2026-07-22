using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BatchProcessing.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchProcessing.UI
{
    public class ViewLocator : IDataTemplate
    {
        private const string ViewModel = nameof(ViewModel);
        private const string View = nameof(View);

        public Control? Build(object? data)
        {
            if (data is null)
                return null;

            var name = data.GetType().FullName.Replace(ViewModel, View, StringComparison.InvariantCulture);
            var type= Type.GetType(name);

            if (type is null)
                return null;

            var control = (Control)Activator.CreateInstance(type);
            control.DataContext = data;
            return control;
        }

        public bool Match(object? data) => data is ViewModelBase;
    }
}
