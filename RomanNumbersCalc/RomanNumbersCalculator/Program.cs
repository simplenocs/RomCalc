using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;


namespace RomanNumbersCalculator
{
    // Создаем внутренний класс Program
    internal class Program
    {
        // Атрибут STAThread указывает, что приложение использует однопоточную модель COM
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Метод BuildAvaloniaApp создает и конфигурирует новый экземпляр класса App
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect() // Автоматически выбирает платформу и настройки
                .LogToTrace() // Регистрирует логи событий в консоли отладки
                .UseReactiveUI(); // Использует ReactiveUI для обеспечения реактивной модели представления
    }
}
