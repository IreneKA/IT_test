using System.Windows.Forms;

namespace MiniGIS
{
    public abstract class Layer
    {
        public string Name;
        public bool Visible = true;
        internal Map map = null;
        public Map Map { get { return map; } }

        public bool Selected { get; set; } = false;

        protected Bounds bounds = new Bounds();
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

        public abstract Bounds CalcBounds();


        internal abstract void Draw(PaintEventArgs e);
    }
}
