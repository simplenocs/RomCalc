using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;


namespace RomanNumbersCalculator
{
    // ������� ���������� ����� Program
    internal class Program
    {
        // ������� STAThread ���������, ��� ���������� ���������� ������������ ������ COM
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // ����� BuildAvaloniaApp ������� � ������������� ����� ��������� ������ App
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect() // ������������� �������� ��������� � ���������
                .LogToTrace() // ������������ ���� ������� � ������� �������
                .UseReactiveUI(); // ���������� ReactiveUI ��� ����������� ���������� ������ �������������
    }
}
