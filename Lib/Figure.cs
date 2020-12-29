using Newtonsoft.Json;
using System;

namespace Lib
{
    public abstract class Figure
    {
        [JsonProperty]

        public int BorderWidth { get; protected set; }

        /// <summary>
        /// protected конструктор нельзя явно вызвать, можно вызвать только из конструктора наследника
        /// </summary>
        /// <param name="borderWidth">Ширина границы</param>
        protected Figure(int borderWidth)
        {
            BorderWidth = borderWidth;
        }

        public abstract double Sq();
    }
}
