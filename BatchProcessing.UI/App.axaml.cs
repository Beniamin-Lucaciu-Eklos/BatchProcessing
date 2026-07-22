using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BatchProcessing.UI.Data;
using BatchProcessing.UI.Factories;
using BatchProcessing.UI.ViewModels;
using BatchProcessing.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BatchProcessing.UI
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainViewModel>();
            services.AddTransient<HomePageViewModel>();
            services.AddTransient<ProcessPageViewModel>();
            services.AddTransient<ActionsPageViewModel>();
            services.AddTransient<MacrosPageViewModel>();
            services.AddTransient<ReporterPageViewModel>();
            services.AddTransient<HistoryPageViewModel>();
            services.AddTransient<SettingsPageViewModel>();

            services.AddSingleton<Func<ApplicationPageName, PageViewModel>>(
                x => name => name switch
                {
                    ApplicationPageName.Home => x.GetRequiredService<HomePageViewModel>(),
                    ApplicationPageName.Process => x.GetRequiredService<ProcessPageViewModel>(),
                    ApplicationPageName.Macros => x.GetRequiredService<MacrosPageViewModel>(),
                    ApplicationPageName.Actions => x.GetRequiredService<ActionsPageViewModel>(),
                    ApplicationPageName.Reporter => x.GetRequiredService<ReporterPageViewModel>(),
                    ApplicationPageName.History => x.GetRequiredService<HistoryPageViewModel>(),
                    ApplicationPageName.Settings => x.GetRequiredService<SettingsPageViewModel>(),
                    _ => throw new InvalidOperationException()

                });
            services.AddSingleton<PageFactory>();

            var serviceProvider = services.BuildServiceProvider();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainView
                {
                    DataContext = serviceProvider.GetRequiredService<MainViewModel>(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}