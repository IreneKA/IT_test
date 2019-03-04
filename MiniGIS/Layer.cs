using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGIS
{
    public class Layer
    {
        protected List<MapObject> objects = new List<MapObject>();
        public List<MapObject> Objects { get { return objects; } set { objects = value; } }
        public string Name;
        public bool Visible = true;
        public Pen Pen = new Pen(Color.Black);
        public Brush Brush = new SolidBrush(Color.Yellow);
        public Symbol Symbol = new Symbol();
        internal Map map = null;
        public Map Map { get { return map; } }

        public bool Selected { get; set; } = false;

        private Bounds bounds = new Bounds();//
        public Bounds Bounds
        {
            get
            {
                if (!bounds.Valid) UpdateBounds();
                return bounds;
            }
        }
        protected Bounds UpdateBounds()
        {
            return bounds = CalcBounds();
        }

        public Bounds CalcBounds()
        {
            bounds = new Bounds();
            foreach (var obj in objects)
            {
                bounds = bounds.UnionBounds(obj.Bounds);
            }
            return bounds;
        }
        public Layer()
        {

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

        ~Layer()
        {
            foreach (var obj in this.objects) obj.Layers.Remove(this);

        }
        internal void Draw(PaintEventArgs e)
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
