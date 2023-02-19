using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RomanNumbersCalculator.ViewModels;
using RomanNumbersCalculator.Views;

// ���������� ����� App, ������� ��������� �� ������ Application
namespace RomanNumbersCalculator
{
    public partial class App : Application
    {
        // ����� Initialize ��������� ���� XAML ��� ����������
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        // ����� OnFrameworkInitializationCompleted ����������, ����� ������������� ���������� ���������
        public override void OnFrameworkInitializationCompleted()
        {
            // ���� ��� ���������� ����� ���������� - ������������ ������� ����, �� ������� ������� ����
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }
            // �������� ������� ����� OnFrameworkInitializationCompleted
            base.OnFrameworkInitializationCompleted();
        }
    }
}
