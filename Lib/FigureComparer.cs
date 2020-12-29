using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class FigureComparer : IComparer<Figure>
    {
        public int Compare(Figure x, Figure y)
        {
            if (x.Sq().CompareTo(y.Sq()) == 0)
            {
                return x.BorderWidth.CompareTo(y.BorderWidth);
            }
            return x.Sq().CompareTo(y.Sq());
        }
    }
}
