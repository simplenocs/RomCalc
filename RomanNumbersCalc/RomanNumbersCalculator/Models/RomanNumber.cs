﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    // Класс RomanNumber реализует интерфейсы IComparable и ICloneable
    internal class RomanNumber : IComparable, ICloneable
    {
        private ushort number = 1; //Число, которое будет преобразовано в римскую систему

        private string romanNumber = ""; // Римское число
        // Конструктор RomanNumber принимает число в десятичной системе счисления и преобразует его в римскую систему
        public RomanNumber(ushort number)
        {
            // Если число находится вне допустимого диапазона, выбрасываем исключение
            if (number < 1 || number > 3999) throw new RomanNumberException("#ERROR");

            this.number = number;

            string roman = "";
            string[] thousand = { "", "M", "MM", "MMM" };
            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            // Разбиваем число на разряды и формируем римскую запись
            roman += thousand[(number / 1000) % 10];
            roman += hundred[(number / 100) % 10];
            roman += ten[(number / 10) % 10];
            roman += one[number % 10];

            romanNumber = roman;
        }
        // Конструктор RomanNumber принимает римское число в виде строки и преобразует его в десятичную систему счисления
        public RomanNumber(string number)
        {

            romanNumber = number;
            // Создаем словарь, в котором ключами являются символы римской системы счисления, а значениями - их эквиваленты в десятичной системе
            Dictionary<char, ushort> match = new Dictionary<char, ushort>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            if (number.Length == 1) this.number = match[number[0]];
            else
            {
                ushort result = 0, i = 0;
                while (i < number.Length - 1)
                {
                    // Если значение слева меньше значения справа, вычитаем левое значение из правого
                    if (match[number[i]] < match[number[i + 1]])
                    {
                        result += (ushort)(match[number[i + 1]] - match[number[i]]);
                        i += 2;
                    }
                    else
                    {
                        result += match[number[i]];
                        i++;
                        if (i == number.Length - 1)
                            result += match[number[i]];
                    }
                }
                this.number = result;
            }
            if (number != new RomanNumber(this.number).ToString()) throw new RomanNumberException("#ERROR");
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
        }

        public static RomanNumber Add(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number + RomanNumber2.number));
        }
        public static RomanNumber Sub(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number - RomanNumber2.number));
        }
        public static RomanNumber Mul(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number * RomanNumber2.number));
        }
        public static RomanNumber Div(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number / RomanNumber2.number));
            
        }

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber num) return number.CompareTo(num.number);
            else throw new ArgumentException("Can't compare this parametr");
        }

        public object Clone() => MemberwiseClone();

        public override string ToString() => romanNumber;

        public ushort ToUInt16() => number;

    }
}
