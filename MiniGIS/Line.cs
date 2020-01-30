using System.Windows.Forms;

namespace MiniGIS
{
    public class Line : MapObject
    {
        private Vertex begin;
        private Vertex end;
        #region constructors
        public Line(Vertex begin, Vertex end)
        {
            this.begin = begin;
            this.end = end;
            objectType = MapObjectType.Line;
        }
        public Line(double beginX, double beginY, double endX, double endY)
        {
            begin = new Vertex(beginX, beginY);
            end = new Vertex(endX, endY);
            objectType = MapObjectType.PolyLine;
        }
        #endregion constructors
        #region properties
        public Vertex Begin
        {
            get
            {
                return begin;
            }
            set
            {
                begin = value;
            }
        }
        public Vertex End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }
        public double BeginX
        {
            get
            {
                return begin.X;
            }
            set
            {
                begin.X = value;
            }
        }
        public double EndX
        {
            get
            {
                return end.X;
            }
            set
            {
                end.X = value;
            }
        }
        public double BeginY
        {
            get
            {
                return begin.Y;
            }
            set
            {
                begin.Y = value;
            }
        }
        public double EndY
        {
            get
            {
                return end.Y;
            }
            set
            {
                end.Y = value;
            }
        }
        #endregion properties
        internal override void Draw(PaintEventArgs e)
        {
            var beginPoint = Layers[0].Map.MapToScreen(begin);
            var endPoint = Layers[0].Map.MapToScreen(end);
            e.Graphics.DrawLine(ChoosePen(), beginPoint,endPoint);
        }
        protected override Bounds GetBounds()
        {
            Bounds bounds = new Bounds();
            bounds.SetBounds(
                (begin.X < end.X) ? begin.X : end.X,
                (begin.Y > end.Y) ? begin.Y : end.Y,
                (begin.X > end.X) ? begin.X : end.X,
                (begin.Y < end.Y) ? begin.Y : end.Y
                );
            return bounds;
        }
        internal override bool IsIntersectsWithQuad(Vertex searchPoint, double d)
        {
            return IsSegmentIntersectsWithQuad(begin, end, searchPoint, d);
        }

        internal override bool IsIntersectsWithPolyline(Polyline polyline)
        {
            return false;
        }
    }
}
