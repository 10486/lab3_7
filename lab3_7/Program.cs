using Lib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab3_7
{
    class Program
    {
        // Фигуры расстянуты по У из-за не квадратного размера "пикселей"
        static void Main(string[] args)
        {

            var figures = new List<Figure>
            {
                new Square(4, 2),
                new Circle(4, 2),
                new Rectangle(4, 6, 2),
                new Ellipce(4, 5, 3)
            };
            var editor1 = new GraphicEditor();
            editor1.Sort();
            editor1.AddFigures(figures);

            WriteInFile("file.json",editor1);
            var editor2 = ReadFromFile("file.json");

            Console.WriteLine(editor2);
        }

        static GraphicEditor ReadFromFile(string filename)
        {
            try
            {
                var serializer = new JsonSerializer
                {
                    NullValueHandling = NullValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };

                List<Figure> tmp;

                using (var sr = new JsonTextReader(new StreamReader(filename)))
                {
                    tmp = serializer.Deserialize<List<Figure>>(sr);
                }

                var editor = new GraphicEditor();
                editor.AddFigures(tmp);
                return editor;
            }
            catch (Exception)
            {

                throw new Exception("Неверный формат файла");
            }
        }

        static void WriteInFile(string filename, GraphicEditor editor)
        {
            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };
            using (StreamWriter sw = new StreamWriter(filename))
            {
                serializer.Serialize(sw, editor.Figures);
            }
        }
    }
}
