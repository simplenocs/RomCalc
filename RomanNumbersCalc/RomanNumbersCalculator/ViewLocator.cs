using Avalonia.Controls;
using Avalonia.Controls.Templates;
using RomanNumbersCalculator.ViewModels;
using System;

// ���������� ����� ViewLocator, ������� ��������� ��������� IDataTemplate
namespace RomanNumbersCalculator
{
    public class ViewLocator : IDataTemplate
    {
        // ����� Build ��������� ������ data � ������� ��������������� ������� ����������
        public IControl Build(object data)
        {
            // �������� ������ ��� ���� ������������� �� ������ �������������
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            // �������� ��� ������������� �� ��� �����
            var type = Type.GetType(name);
            // ���� ��� ������������� ������, �� ������� ��� ��������� � ����������
            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            // ���� ��� ������������� �� ������, �� ������� ��������� TextBlock � ���������� ��� � ���������� �� ������
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }
        // ����� Match ��������� ������ data � ���������, ������������� �� �� ������ �������������
        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
