using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniGIS
{
    /// <summary>
    /// Класс для работы с точечными объектами
    /// </summary>
    public class Point : MapObject
    {
        private Vertex position;
        #region constructors
        public Point(double x, double y)
        {
            position = new Vertex(x, y);
            objectType = MapObjectType.Point;
        }
        public Point(Vertex vertex)
        {
            position = vertex;
            objectType = MapObjectType.Point;
        }
        
        #endregion constructors
        #region properties
        public double X
        {
            get
            {
                return position.X;
            }
            set
            {
                position.X = value;
            }
        }
        public double Y
        {
            get
            {
                return position.Y;
            }
            set
            {
                position.Y = value;
            }
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
            e.Graphics.DrawString(c.ToString(), Symbol.Font, Brush, Layers[0].Map.MapToScreen(position), stringFormat);
        }

        protected override Bounds GetBounds()
        {
            Bounds bounds = new Bounds();
            bounds.SetBounds(position, position);
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
