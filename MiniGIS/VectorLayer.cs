using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGIS
{
    public class VectorLayer: Layer
    {
        protected List<MapObject> objects = new List<MapObject>();
        public List<MapObject> Objects { get { return objects; } set { objects = value; } }
        public Pen Pen = new Pen(Color.Black);
        public Brush Brush = new SolidBrush(Color.Yellow);
        public Symbol Symbol = new Symbol();

        public override Bounds CalcBounds()
        {
            bounds = new Bounds();
            foreach (var obj in objects)
            {
                bounds = bounds.UnionBounds(obj.Bounds);
            }
            return bounds;
        }

        public void AddObject(MapObject obj)
        {
            objects.Add(obj);
            obj.Layers.Add(this);
        }
        public void RemoveObject(int index)
        {

            MapObject obj = objects[index];
            objects.RemoveAt(index);
            obj.Layers.Remove(this);
        }
        public void RemoveObject(MapObject item)
        {
            objects.Remove(item);
            item.Layers.Remove(this);
        }
        public void RemoveAllObject()
        {
            foreach (var obj in objects)
                obj.Layers.Remove(this);
            objects.Clear();
        }

        ~VectorLayer()
        {
            foreach (var obj in objects) obj.Layers.Remove(this);

        }
        internal override void Draw(PaintEventArgs e)
        {
            if (!Visible) return;
            foreach (var obj in objects)
            {
                obj.Draw(e);
            }
        }

        internal MapObject FindObject(Vertex searchPoint, double d)
        {
            if (Visible)
            {
                MapObject result = null;
                for (var i = objects.Count - 1; i >= 0; i--)
                {
                    var obj = objects[i];
                    if (obj.IsIntersectsWithQuad(searchPoint, d))
                    {
                        result = obj;
                        break;
                    }
                }
                return result;
            }
            return null;
        }

        internal void ClearSelection()
        {
            foreach (var obj in objects)
            {
                obj.Selected = false;
            }
        }

        internal void FindPolylines(MapObject polygon)
        {
            foreach (MapObject obj in Objects)
            {
                if (obj.ObjectType == MapObjectType.PolyLine)
                {
                    if (polygon.IsIntersectsWithPolyline((Polyline)obj))
                    {
                        obj.Selected = true;
                    }
                }

            }
        }
    }
}
