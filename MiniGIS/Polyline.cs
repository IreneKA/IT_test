using System.Collections.Generic;
using System.Windows.Forms;
using ScreenPoint = System.Drawing.Point;

namespace MiniGIS
{
    public class Polyline : MapObject
    {
        protected List<Vertex> nodes = new List<Vertex>();
        public List<Vertex> Nodes { get { return nodes; } }
        private Bounds bounds;
        public Bounds Bounds
        {
            get
            {
                if (!bounds.Valid) GetBounds();
                return bounds;
            }
        }
        public Polyline()
        {
            objectType = MapObjectType.PolyLine;
        }
        public void AddNode(Vertex node)
        {
            nodes.Add(node);
        }
        /// <summary>
        /// Добавляет вершину
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        public void AddNode(double x, double y)
        {
            nodes.Add(new Vertex(x, y));
        }
        public void RemoveNode(int index)
        {
            nodes.RemoveAt(index);
        }
        public void RemoveNode(Vertex item)
        {
            nodes.Remove(item);
        }
        public void RemoveAllNode()
        {
            nodes.Clear();
        }
        internal override void Draw(PaintEventArgs e)
        {
            if (nodes.Count < 2) return;
            List<ScreenPoint> points = new List<ScreenPoint>();
            foreach (var node in nodes)
            {
                var point = Layers[0].Map.MapToScreen(node);
                points.Add(point);
            }
            e.Graphics.DrawLines(ChoosePen(), points.ToArray());
        }
        protected override Bounds GetBounds()
        {
            return bounds = CalcBounds();
        }

        public Bounds CalcBounds()
        {
            Bounds b1 = new Bounds();
            Bounds b2 = new Bounds();
            foreach (var node in nodes)
            {
                b1.SetBounds(node, node);
                b2 = b2.UnionBounds(b1);
            }
            return b2;
        }

        internal override bool IsIntersectsWithQuad(Vertex searchPoint, double d)
        {
            if (nodes.Count == 0) return false;
            if (nodes.Count == 1)
            {
                bool nodeIside = (nodes[0].X > searchPoint.X - d && nodes[0].Y > searchPoint.Y - d) && (nodes[0].X < searchPoint.X + d && nodes[0].Y < searchPoint.Y + d);
                if (nodeIside) return true;
                return false;
            }
            for (int i = 0; i<=nodes.Count-2; i++)
            {
                var begin = nodes[i];
                var end = nodes[i + 1];
                if (IsSegmentIntersectsWithQuad(begin, end, searchPoint, d)) return true;
            }
            return false;
        }

        internal override bool IsIntersectsWithPolyline(Polyline polyline)
        {
            return false;
        }
    }
}
