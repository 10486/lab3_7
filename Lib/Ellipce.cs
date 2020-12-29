using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Ellipce : Figure
    {
        [JsonProperty]
        public int A { get; private set; }
        [JsonProperty]
        public int B { get; private set; }

        // Вызываем конструктор базового класса, из нашего конструктора

        public Ellipce(int a, int b, int borderWidth) : base(borderWidth)
        {
            A = a;
            B = b;
        }

        public Ellipce():base(1)
        {

        }

        public override double Sq()
        {
            return A * B * Math.PI;
        }
        public override string ToString()
        {
            var tmp = new StringBuilder();
            double x;
            for (double i = -B; i <= B; i++)
            {
                x = A * Math.Sqrt(1 - i * i / (B * B));
                tmp.Append(new string(' ', (int)Math.Round(A - x)));
                tmp.Append(new string('*', BorderWidth));
                if (2 * (int)Math.Round(x) - 1 >= 0)
                {
                    tmp.Append(new string(' ', 2 * (int)Math.Round(x) - 1));
                }
                if(Math.Round(x) > 0)
                {
                    tmp.Append(new string('*', BorderWidth));
                }
                tmp.Append(new string(' ', (int)Math.Round(A - x)));
                tmp.AppendLine();
            }
            return tmp.ToString();
        }
    }
}
