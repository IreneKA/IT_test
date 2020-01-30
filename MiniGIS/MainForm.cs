using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MiniGIS.Properties;

namespace MiniGIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonSelect.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonSelect.Image = Resources._9_512;
            buttonPan.Image = Resources.hand_drag_512;
            buttonZoomIn.Image = Resources._12_zoom_in_512;
            buttonZoomOut.Image = Resources._2000px_Zoom_out_font_awesome_svg;
            Line line1 = new Line(new Vertex(50, 0), new Vertex(-50, 0))
            {
                UseOwnStyle = true, Pen = new Pen(Color.Red, 2) {DashStyle = DashStyle.Dash}
            };
            Line line2 = new Line(new Vertex(0, 50), new Vertex(0, -50))
            {
                UseOwnStyle = true, Pen = new Pen(Color.Red, 2) {DashStyle = DashStyle.Dash}
            };

            VectorLayer layer = new VectorLayer {Name = "Тест"};
            VectorLayer layer1 = new VectorLayer {Name = "Тест1"};
            VectorLayer layer2 = new VectorLayer {Name = "Тест2"};
            var layer3 = new VectorLayer {Name = "Тест3"};

            Polyline polyline = new Polyline();
            polyline.AddNode(0, 100);
            polyline.AddNode(100, 100);
            polyline.AddNode(200, 50);
            polyline.AddNode(500, 500);
            layer2.AddObject(polyline);

            Polyline polyline1 = new Polyline();
            polyline1.AddNode(150, 150);
            layer2.AddObject(polyline1);

            layer.AddObject(line1);
            layer.AddObject(line2);
            map1.AddLayer(layer);
            map1.AddLayer(layer1);
            map1.AddLayer(layer2);
            Point p = new Point(0, 0);
            Point p1 = new Point(200, 100);
            Point p2 = new Point(-200, -100);
            Point p3 = new Point(0, 500);
            layer.AddObject(p);
            layer1.AddObject(p1);
            layer2.AddObject(p2);

            layer2.AddObject(p3);
            int b = -349;
            for (int x = 0; x < 100; x++)
            {
                int a = -349;
                for (int y = 0; y < 100; y++)
                {
                    Polygon polygon = new Polygon();
                    polygon.AddNode(a, b);
                    polygon.AddNode(a + 5, b);
                    polygon.AddNode(a + 5, b + 5);
                    polygon.AddNode(a, b + 5);
                    polygon.UseOwnStyle = true;
                    polygon.Brush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Red, Color.Green);
                    layer.AddObject(polygon);
                    a += 7;
                }
                b += 7;
            }
            layersControl1.Map = map1;
            layersControl1.UpdateLayers();
            layersControl1.AddLayer += AddLayersFromFiles;
        }

        private void AddLayersFromFiles(object sender, EventArgs e)
        {
            openFileDialog.Filter = "MIF|*.mif";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePathName = openFileDialog.FileNames;
                string[] filename = openFileDialog.SafeFileNames;
                for (int i = 0; i < filePathName.Length; ++i)
                {
                    int extansIndex = filename[i].IndexOf(".");
                    string layerName = filename[i].Substring(0, extansIndex);
                    var layer = new VectorLayer {Name = layerName};
                    var parser = new Parser(filePathName[i]);
                    foreach (var mapObject in parser.Data)
                    {
                        layer.AddObject(mapObject);
                    }
                    map1.AddLayer(layer);
                    layersControl1.UpdateLayers();
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.Select;
            buttonSelect.Checked = true;
            buttonPan.Checked = false;
            buttonZoomIn.Checked = false;
            buttonZoomOut.Checked = false;
        }

        private void buttonPan_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.Pan;
            buttonSelect.Checked = false;
            buttonPan.Checked = true;
            buttonZoomIn.Checked = false;
            buttonZoomOut.Checked = false;
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.ZoomIn;
            buttonSelect.Checked = false;
            buttonPan.Checked = false;
            buttonZoomIn.Checked = true;
            buttonZoomOut.Checked = false;
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.ZoomOut;
            buttonSelect.Checked = false;
            buttonPan.Checked = false;
            buttonZoomIn.Checked = false;
            buttonZoomOut.Checked = true;
        }

        private void map1_MouseMove(object sender, MouseEventArgs e)
        {
            var mapCursorLocation = map1.ScreenToMap(e.Location);
            labelMapCursorPosition.Text = "x:" +mapCursorLocation.X + " y:" + mapCursorLocation.Y;
        }

        private void buttonZoomAll_Click(object sender, EventArgs e)
        {
            if (layersControl1.SelectedItemsCount != 0)
                map1.ZoomLayers(layersControl1.ReturnSelectedLayers());
            else
            map1.ZoomAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void layersControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFindPolylines_Click(object sender, EventArgs e)
        {
            MyMessageBox myMessageBox = new MyMessageBox();
            if (map1.SelectedObjects.Count > 1)
            {
                myMessageBox.SetText("Вы выбрали несколько объектов.\nВыберите один полигон.");
                myMessageBox.Show();
                return;
            }
            if (map1.SelectedObjects.Count == 0 || map1.SelectedObjects[0].ObjectType != MapObjectType.Polygon)
            {
                myMessageBox.SetText("Выберите полигон.");
                myMessageBox.Show();
                return;
            }
            map1.FindPolylines(map1.SelectedObjects[0]);
            
        }
    }
}
