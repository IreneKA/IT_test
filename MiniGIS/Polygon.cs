using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ScreenPoint = System.Drawing.Point;

namespace MiniGIS
{
    public class Polygon:Polyline
    {
        public Polygon()
        {
            objectType = MapObjectType.Polygon;
        }
        internal override void Draw(PaintEventArgs e)
        {
            if (nodes.Count() < 2) return;
            List<ScreenPoint> points = new List<ScreenPoint>();
            
            foreach (var node in nodes)
            {
                var point = Layers[0].Map.MapToScreen(node);
                points.Add(point);
            }
            e.Graphics.FillPolygon(ChooseBrush(), points.ToArray());
            e.Graphics.DrawPolygon(ChoosePen(), points.ToArray());

        }

        private bool IsContainPoint(Vertex point)
        {
            bool c = false;
            for (int i = 0, j = nodes.Count - 1; i < nodes.Count; j = i++)
            {
                if ((((nodes[i].Y <= point.Y) && (point.Y < nodes[j].Y)) || ((nodes[j].Y <= point.Y) && (point.Y < nodes[i].Y))) &&
                  (point.X > (nodes[j].X - nodes[i].X) * (point.Y - nodes[i].Y) / (nodes[j].Y - nodes[i].Y) + nodes[i].X))
                    c = !c;
            }
            return c;
        }
        internal override bool IsIntersectsWithQuad(Vertex searchPoint, double d)
        {
            if (IsContainPoint(searchPoint)) return true;
            if(base.IsIntersectsWithQuad(searchPoint,d)) return true;
            if (IsSegmentIntersectsWithQuad(nodes[0], nodes.Last(), searchPoint, d)) return true;
            return false;
        }

        internal override bool IsIntersectsWithPolyline(Polyline polyline)
        {
            foreach (var node in polyline.Nodes)
            {
                if (IsContainPoint(node)) return true;
            }
            for (int i = 0; i < polyline.Nodes.Count -1; i++)
            {
                for (int j = 0; j < Nodes.Count - 1; j++)
                {
                    if (IsSegmentsIntersect(polyline.Nodes[i], polyline.Nodes[i+1],Nodes[j],Nodes[j+1])) return true;
                }
                if (IsSegmentsIntersect(polyline.Nodes[i], polyline.Nodes[i + 1], Nodes[Nodes.Count-1], Nodes[0])) return true;
            } 
            return false;
        }
        
    }
}
