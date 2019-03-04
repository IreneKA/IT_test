using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniGIS
{
    public class Bounds
    {
        private bool valid = false;
        public bool Valid { get { return valid; } }
        private Vertex topLeft = new Vertex(0, 0);
        private Vertex bottomRight = new Vertex(0, 0);
        public double Xmin { get { return topLeft.X; } }
        public double Ymax { get { return topLeft.Y; } }
        public double Xmax { get { return bottomRight.X; } }
        public double Ymin { get { return bottomRight.Y; } }

        public void SetBounds(double _Xmin, double _Ymax, double _Xmax, double _Ymin)
        {
            topLeft.X = _Xmin;
            topLeft.Y = _Ymax;
            bottomRight.X = _Xmax;
            bottomRight.Y = _Ymin;
            valid = true;
        }

        public void SetBounds(Vertex _topLeft, Vertex _bottomRight)
        {
            topLeft = _topLeft;
            bottomRight = _bottomRight;
            valid = true;
        }

        public Bounds UnionBounds(Bounds addBounds)
        {
            Bounds bounds = new Bounds();
            if (Valid == true && addBounds.Valid == true)
            {
                bounds.SetBounds(
                (Xmin < addBounds.Xmin) ? Xmin : addBounds.Xmin,
                (Ymax > addBounds.Ymax) ? Ymax : addBounds.Ymax,
                (Xmax > addBounds.Xmax) ? Xmax : addBounds.Xmax,
                (Ymin < addBounds.Ymin) ? Ymin : addBounds.Ymin
                );
            }
            if (Valid == true && addBounds.Valid == false)
                bounds = this;
            if (Valid == false && addBounds.Valid == true)
                bounds = addBounds;
            return bounds;
        }


    }
}
