using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class GraphicEditor
    {
        public List<Figure> Figures { get; private set; } = new List<Figure>();
        private double totalSquare;
        /// <summary>
        /// Считаем среднюю площадь
        /// </summary>
        public double MeanSquare { get
            {
                return totalSquare / Figures.Count;
            } 
        }
        /// <summary>
        /// Добавить одну фигуру
        /// </summary>
        /// <param name="figure">Фигура</param>
        public void AddFigure(Figure figure)
        {
            totalSquare += figure.Sq();
            Figures.Add(figure);
        }

        /// <summary>
        /// Добавить несколько фигур
        /// </summary>
        /// <param name="figures">Перечисление фигур</param>
        public void AddFigures(IEnumerable<Figure> figures)
        {
            foreach (var item in figures)
            {
                AddFigure(item);
            }
        }

        /// <summary>
        /// Сортировка 
        /// </summary>
        /// <param name="comparer">Объект класса для сравнения</param>
        public void Sort(IComparer<Figure> comparer = null)
        {
            if(comparer is null)
            {
                comparer = new FigureComparer();
            }
            Figures.Sort(comparer);
        }
        public override string ToString()
        {
            var tmp = new StringBuilder();
            foreach (var item in Figures)
            {
                tmp.AppendLine(item.ToString());
            }
            return tmp.ToString();
        }
    }
}
