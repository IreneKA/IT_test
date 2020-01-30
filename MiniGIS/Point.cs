using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGIS
{
    /// <summary>
    /// Класс для работы с точечными объектами.
    /// </summary>
    public class Point : MapObject
    {
        private readonly Vertex _position;
        #region constructors
        public Point(double x, double y)
        {
            _position = new Vertex(x, y);
            objectType = MapObjectType.Point;
        }
        public Point(Vertex vertex)
        {
            _position = vertex;
            objectType = MapObjectType.Point;
        }
        
        #endregion constructors
        #region properties
        public double X
        {
            get => _position.X;
            set => _position.X = value;
        }
        public double Y
        {
            get => _position.Y;
            set => _position.Y = value;
        }
        #endregion properties
        internal override void Draw(PaintEventArgs e)
        {
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Char c = (Char)ChooseSymbol().Number;
            e.Graphics.DrawString(c.ToString(), Symbol.Font, Brush, Layers[0].Map.MapToScreen(_position), stringFormat);
        }

        protected override Bounds GetBounds()
        {
            Bounds bounds = new Bounds();
            bounds.SetBounds(_position, _position);
            return bounds;
        }

        internal override bool IsIntersectsWithQuad(Vertex searchPoint, double d)
        {
            return false;
        }

        internal override bool IsIntersectsWithPolyline(Polyline polyline)
        {
            return false;
        }
    }
}
