using Avalonia.Controls;
using RomanNumbersCalculator.ViewModels;
using System;

// Определяем пространство имен для класса MainWindow
namespace RomanNumbersCalculator.Views
{
    // Определяем класс MainWindow, который наследуется от класса Window
    public partial class MainWindow : Window
    {
        // Определяем конструктор класса MainWindow
        public MainWindow()
        {
            // Вызываем метод InitializeComponent() для загрузки разметки
            InitializeComponent();
        }
    }
}
