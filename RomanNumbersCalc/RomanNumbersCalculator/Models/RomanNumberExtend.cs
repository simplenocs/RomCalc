using Avalonia.Controls;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberExtend : RomanNumber
    {
        // Конструктор, принимающий строку
        public RomanNumberExtend(string n) : base(n) { }
        // Конструктор, принимающий целое число
        public RomanNumberExtend(ushort n) : base(n) { }
        // Перегруженный оператор "+"
        public static RomanNumberExtend operator +(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2) => new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() + RomanNumber2.ToUInt16()));
        // Перегруженный оператор "-"
        public static RomanNumberExtend operator -(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2) => new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() - RomanNumber2.ToUInt16()));
        // Перегруженный оператор "*"
        public static RomanNumberExtend operator *(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2) => new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() * RomanNumber2.ToUInt16()));
        // Перегруженный оператор "/"
        public static RomanNumberExtend operator /(RomanNumberExtend RomanNumber1, RomanNumberExtend RomanNumber2) => new RomanNumberExtend((ushort)(RomanNumber1.ToUInt16() / RomanNumber2.ToUInt16()));
    }
}
