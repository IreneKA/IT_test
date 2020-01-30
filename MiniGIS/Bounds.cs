namespace MiniGIS
{
    public class Bounds
    {
        public bool Valid { get; private set; }
        private Vertex _topLeft = new Vertex(0, 0);
        private Vertex _bottomRight = new Vertex(0, 0);
        public double XMin => _topLeft.X;
        public double YMax => _topLeft.Y;
        public double XMax => _bottomRight.X;
        public double YMin => _bottomRight.Y;

        public void SetBounds(double xMin, double yMax, double xMax, double yMin)
        {
            _topLeft.X = xMin;
            _topLeft.Y = yMax;
            _bottomRight.X = xMax;
            _bottomRight.Y = yMin;
            Valid = true;
        }

        public void SetBounds(Vertex topLeft, Vertex bottomRight)
        {
            this._topLeft = topLeft;
            this._bottomRight = bottomRight;
            Valid = true;
        }

        public Bounds UnionBounds(Bounds addBounds)
        {
            Bounds bounds = new Bounds();
            if (Valid && addBounds.Valid)
            {
                bounds.SetBounds(
                (XMin < addBounds.XMin) ? XMin : addBounds.XMin,
                (YMax > addBounds.YMax) ? YMax : addBounds.YMax,
                (XMax > addBounds.XMax) ? XMax : addBounds.XMax,
                (YMin < addBounds.YMin) ? YMin : addBounds.YMin
                );
            }
            if (Valid && addBounds.Valid == false)
                bounds = this;
            if (Valid == false && addBounds.Valid)
                bounds = addBounds;
            return bounds;
        }


    }
}
