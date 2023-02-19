using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RomanNumbersCalculator.ViewModels;
using RomanNumbersCalculator.Views;

// Определяем класс App, который наследует от класса Application
namespace RomanNumbersCalculator
{
    public partial class App : Application
    {
        // Метод Initialize загружает файл XAML для приложения
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        // Метод OnFrameworkInitializationCompleted вызывается, когда инициализация фреймворка завершена
        public override void OnFrameworkInitializationCompleted()
        {
            // Если тип жизненного цикла приложения - классический рабочий стол, то создаем главное окно
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }
            // Вызываем базовый метод OnFrameworkInitializationCompleted
            base.OnFrameworkInitializationCompleted();
        }
    }
}
