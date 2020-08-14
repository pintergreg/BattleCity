using System.Resources;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BattleCity.Models;
using BattleCity.ViewModels;
using BattleCity.Views;
using BattleCity.Infrastructure;

using Avalonia.Media.Imaging;
using System.Reflection;

namespace BattleCity
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var field = new GameField();
                var game = new Game(field);
                game.Start();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(field),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}