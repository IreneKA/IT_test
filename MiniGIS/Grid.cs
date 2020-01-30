using System;
using System.Windows.Forms;

namespace MiniGIS
{
    public class Grid : Layer
    {
        public Grid(Geometry geometry, double[,] matrix)
        {
            Geometry = geometry;
            Matrix = matrix;
        }

        public double[,] Matrix { get; }

        public Geometry Geometry { get; }
        public override Bounds CalcBounds()
        {
            var bound = new Bounds();
            bound.SetBounds(Geometry.XMin, Geometry.YMax, Geometry.XMax, Geometry.YMin);
            return bound;
        }

        internal override void Draw(PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public class Geometry
    {
        public Geometry(double xMin, double xMax, double yMin, double yMax, double step)
        {
            XMin = xMin;
            XMax = xMax;
            YMin = yMin;
            YMax = yMax;
            Step = step;
        }

        public Geometry(double xMin, int width, double yMin, int height, double step)
        {
            XMin = xMin;
            XMax = xMin + width * step;
            YMin = yMin;
            YMax = yMin + height * step;
            Step = step;
        }

        public double XMin { get; }
        public double YMin { get; }
        public double XMax { get; }
        public double YMax { get; }
        public double Step { get; }
    }
}
