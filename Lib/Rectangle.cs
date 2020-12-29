using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Rectangle : Figure
    {
        [JsonProperty]
        public int Width { get; private set; }
        [JsonProperty]
        public int Height { get; private set; }

        // Вызываем конструктор базового класса, из нашего конструктора

        public Rectangle(int width, int heihgt, int borderWidth):base(borderWidth)
        {
            Width = width;
            Height = heihgt;
        }

        public Rectangle():base(1)
        {

        }

        public override double Sq()
        {
            return (Width + BorderWidth * 2) * (Height + BorderWidth * 2);
        }

        public override string ToString()
        {
            var tmp = new StringBuilder();

            for (int i = 0; i < BorderWidth; i++)
            {
                tmp.AppendLine(new string('*', Width + BorderWidth * 2));
            }

            for (int i = 0; i < Height; i++)
            {
                tmp.Append(new string('*', BorderWidth));
                tmp.Append(new string(' ', Width));
                tmp.Append(new string('*', BorderWidth));
                tmp.AppendLine();
            }

            for (int i = 0; i < BorderWidth; i++)
            {
                tmp.AppendLine(new string('*', Width + BorderWidth * 2));
            }

            return tmp.ToString();
        }
    }
}
