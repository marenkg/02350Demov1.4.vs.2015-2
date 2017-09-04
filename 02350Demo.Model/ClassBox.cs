using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace _02350Demo.Model
{
    // The Shape class descripes a shape with a position (X and Y), and a size (Width and Height).
    //[Serializable]
    public class ClassBox
    {
 
        private static int counter = 0;

        public int Number { get; }
        private double _x = 200;
        public double X {get { return _x; } set { _x = value; UpdateConnectionPoints(); }}

        private double _y = 200; 
        public double Y { get { return _y; } set { _y = value; UpdateConnectionPoints(); } }

        private double _width = 100;
        public double Width { get { return _width; } set { _width = value; UpdateConnectionPoints(); } }

        private double _height = 100;
        public double Height { get { return _height; } set { _height = value; UpdateConnectionPoints(); } }

        public String ContentClass { get; set; }
        public String ContentFields { get; set; }

        public String ContentMethods { get; set; }

        // South West Nort EASt

        public Point South { get; set; }
        public Point North { get; set; }
        public Point East { get; set; }
        public Point West { get; set; }

        // Used every time the X or Y coordinate is set
        public void UpdateConnectionPoints()
        {
            South = new Point(X + Width / 2, Y);
            North = new Point(X + Width / 2, Y + Height);
            East = new Point(X + Width , Y + Height / 2);
            West = new Point(X, Y + Height / 2);
        }


        public double CanvasCenterX
        {
            get { return X + Width / 2; }
        }
 
        public double CanvasCenterY
        {
            get { return Y + Height / 2; }
        }

        public Brush Color { get; set; }

        public ClassBox()
        {
            Number = ++counter;
            UpdateConnectionPoints();
        }

        public override string ToString() => Number.ToString();

        public Object Serialize()
        {
            // Please find a better way of doing this ...
            Dictionary<string, double> o = new Dictionary<string, double>(4);
            o.Add("x", X);
            o.Add("y", Y);
            o.Add("width", Width);
            o.Add("height", Height);
            return o;
        }

        public void LoadSerializedData(Object o)
        {
            try {
                var obj = (Dictionary<string, double>)o;
                double x;
                double y;
                double width;
                double height;
                obj.TryGetValue("x", out x);
                obj.TryGetValue("y", out y);
                obj.TryGetValue("width", out width);
                obj.TryGetValue("height", out height);
                X = x;
                Y = y;
                Width = width;
                Height = Height;
            } finally
            {
                // tja
            }
        }
    }
}
