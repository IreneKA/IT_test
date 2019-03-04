using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniGIS
{
    public abstract class MapObject
    {
        private List<Layer> layers = new List<Layer>();
        public bool UseOwnStyle = false;
        private Pen pen;

        private Pen SelectionPen = new Pen(Color.Blue, 2);

        private bool selected = false;
        public bool Selected { get { return selected; }
            set
            { if (value)
            {
                SelectionPen.Color = layers[0].map.SelectionColor;
                if (UseOwnStyle) SelectionPen.DashStyle = Pen.DashStyle;
                if (!layers[0].Map.SelectedObjects.Contains(this)) layers[0].Map.SelectedObjects.Add(this);
                }
            selected = value;
            }
        }
        public Bounds Bounds { get { return GetBounds(); } }

        protected abstract Bounds GetBounds();
        public Pen Pen {
            get
            {
                if (pen == null)
                {
                    pen = new Pen(Color.Black);
                }
                return pen;
            }
            set
            {
                pen = value;
            }
        }
        private Brush brush;
        public Brush Brush
        {
            get
            {
                if (brush == null)
                {
                    brush = new SolidBrush(Color.Yellow);
                }
                return brush;
            }
            set
            {
                brush = value;
            }
        }
        public List<Layer> Layers
        {
            get
            {
                return layers;
            }
            set { layers = value; }
        }
        private Symbol symbol;
        public Symbol Symbol
        {
            get
            {
                if (symbol == null)
                {
                    symbol = new Symbol();
                }
                return symbol;
            }
            set
            {
                symbol = value;
            }
        }

        internal Symbol ChooseSymbol()
        {
            Symbol symbol;
            if (UseOwnStyle) { symbol = Symbol; }
            else { symbol = Layers[0].Symbol; }
            return symbol;
        }

        internal Pen ChoosePen()
        {
            if (Selected) return SelectionPen;
            if (UseOwnStyle) return Pen;
            else return layers[0].Pen;
        }
        internal Brush ChooseBrush()
        {
            Brush brush;
            if (UseOwnStyle) { brush = Brush; }
            else { brush = Layers[0].Brush; }
            return brush;
        }

        protected MapObjectType objectType;
        public MapObjectType ObjectType => objectType;
        ~MapObject()
        {
            for (int i = 0; i < layers.Count; i++) { layers[i].RemoveObject(this); i--; }
        }
        /// <summary>
        /// Метод позволяет определить пересекаются ли отрезки.
        /// Идея алгоритма взята здесь: https://habr.com/post/267037/
        /// </summary>
        /// <param name="aBegin">Начальная точка первого отрезка</param>
        /// <param name="aEnd">Конечная точка первого отрезка</param>
        /// <param name="bBegin">Начальная точка второго отрезка</param>
        /// <param name="bEnd">Конечная точка второго отрезка</param>
        /// <returns></returns>
        public static bool IsSegmentsIntersect(Vertex aBegin, Vertex aEnd, Vertex bBegin, Vertex bEnd)
        {
            double v1 = (aEnd.X - aBegin.X) * (bBegin.Y - aBegin.Y) - (aEnd.Y - aBegin.Y) * (bBegin.X - aBegin.X);
            double v2 = (aEnd.X - aBegin.X) * (bEnd.Y - aBegin.Y) - (aEnd.Y - aBegin.Y) * (bEnd.X - aBegin.X);
            double v3 = (bEnd.X - bBegin.X) * (aBegin.Y - bBegin.Y) - (bEnd.Y - bBegin.Y) * (aBegin.X - bBegin.X);
            double v4 = (bEnd.X - bBegin.X) * (aEnd.Y - bBegin.Y) - (bEnd.Y - bBegin.Y) * (aEnd.X - bBegin.X);
            if (v1 * v2 < 0 && v3 * v4 < 0)
            {
                return true;
            }
            return false;
        }
        internal static bool IsSegmentIntersectsWithQuad(Vertex segmentBegin, Vertex segmentEnd, Vertex searchPoint, double d)
        {
            bool beginIside = (segmentBegin.X > searchPoint.X - d && segmentBegin.Y > searchPoint.Y - d)&& (segmentBegin.X < searchPoint.X + d && segmentBegin.Y < searchPoint.Y + d);
            bool endInside = (segmentEnd.X > searchPoint.X - d && segmentEnd.Y > searchPoint.Y - d)&& (segmentEnd.X < searchPoint.X + d && segmentEnd.Y < searchPoint.Y + d);
            if (beginIside || endInside) return true;
            Vertex point1 = new Vertex(searchPoint.X - d, searchPoint.Y + d);
            Vertex point2 = new Vertex(searchPoint.X + d, searchPoint.Y + d);
            if (IsSegmentsIntersect(segmentBegin, segmentEnd, point1, point2)) return true;
            Vertex point3 = new Vertex(searchPoint.X + d, searchPoint.Y - d);
            if (IsSegmentsIntersect(segmentBegin, segmentEnd, point2, point3)) return true;
            Vertex point4 = new Vertex(searchPoint.X - d, searchPoint.Y - d);
            if (IsSegmentsIntersect(segmentBegin, segmentEnd, point3, point4)) return true;
            if (IsSegmentsIntersect(segmentBegin, segmentEnd, point1, point4)) return true;
            return false;
        }
        internal abstract void Draw(PaintEventArgs e);

        internal abstract bool IsIntersectsWithQuad(Vertex searchPoint, double d);

        internal abstract bool IsIntersectsWithPolyline(Polyline polyline);
    }
}
