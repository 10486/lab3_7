using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Square : Rectangle
    {
        public Square()
        {
                
        }
        // Квадрат - прямоугольник с одинаковыми сторонами
        public Square(int size, int borderWidth) : base(size, size, borderWidth)
        {
        }
    }
}
