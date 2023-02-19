using Avalonia.Controls;
using Avalonia.Controls.Templates;
using RomanNumbersCalculator.ViewModels;
using System;

// Определяем класс ViewLocator, который реализует интерфейс IDataTemplate
namespace RomanNumbersCalculator
{
    public class ViewLocator : IDataTemplate
    {
        // Метод Build принимает объект data и создает соответствующий элемент управления
        public IControl Build(object data)
        {
            // Получаем полное имя типа представления из модели представления
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            // Получаем тип представления по его имени
            var type = Type.GetType(name);
            // Если тип представления найден, то создаем его экземпляр и возвращаем
            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            // Если тип представления не найден, то создаем экземпляр TextBlock и возвращаем его с сообщением об ошибке
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }
        // Метод Match принимает объект data и проверяет, соответствует ли он модели представления
        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
