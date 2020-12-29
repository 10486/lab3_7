using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Circle : Ellipce
    {
        // Круг - эллипс с одинаковыми полуосями
        public Circle(int r, int borderWidth) : base(r, r, borderWidth)
        {
        }

        public Circle()
        {

        }
    }
}
