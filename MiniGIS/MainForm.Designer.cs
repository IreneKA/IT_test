using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MiniGIS.Properties;

namespace MiniGIS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new ToolStrip();
            this.buttonSelect = new ToolStripButton();
            this.buttonPan = new ToolStripButton();
            this.buttonZoomIn = new ToolStripButton();
            this.buttonZoomOut = new ToolStripButton();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.buttonZoomAll = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.buttonFindPolylines = new ToolStripButton();
            this.statusStrip1 = new StatusStrip();
            this.labelMapCursorPosition = new ToolStripStatusLabel();
            this.splitter1 = new Splitter();
            this.openFileDialog = new OpenFileDialog();
            this.map1 = new Map();
            this.layersControl1 = new LayersControl();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.buttonSelect,
            this.buttonPan,
            this.buttonZoomIn,
            this.buttonZoomOut,
            this.toolStripSeparator1,
            this.buttonZoomAll,
            this.toolStripSeparator2,
            this.buttonFindPolylines});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(575, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSelect
            // 
            this.buttonSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonSelect.Image = ((Image)(resources.GetObject("buttonSelect.Image")));
            this.buttonSelect.ImageTransparentColor = Color.Magenta;
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new Size(23, 22);
            this.buttonSelect.Text = "buttonSelect";
            this.buttonSelect.ToolTipText = "Выбрать";
            this.buttonSelect.Click += new EventHandler(this.buttonSelect_Click);
            // 
            // buttonPan
            // 
            this.buttonPan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonPan.Image = ((Image)(resources.GetObject("buttonPan.Image")));
            this.buttonPan.ImageTransparentColor = Color.Magenta;
            this.buttonPan.Name = "buttonPan";
            this.buttonPan.Size = new Size(23, 22);
            this.buttonPan.Text = "toolStripButton2";
            this.buttonPan.ToolTipText = "Рука";
            this.buttonPan.Click += new EventHandler(this.buttonPan_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonZoomIn.Image = ((Image)(resources.GetObject("buttonZoomIn.Image")));
            this.buttonZoomIn.ImageTransparentColor = Color.Magenta;
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new Size(23, 22);
            this.buttonZoomIn.Text = "toolStripButton3";
            this.buttonZoomIn.ToolTipText = "Увеличить";
            this.buttonZoomIn.Click += new EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonZoomOut.Image = ((Image)(resources.GetObject("buttonZoomOut.Image")));
            this.buttonZoomOut.ImageTransparentColor = Color.Magenta;
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new Size(23, 22);
            this.buttonZoomOut.Text = "toolStripButton4";
            this.buttonZoomOut.ToolTipText = "Уменьшить";
            this.buttonZoomOut.Click += new EventHandler(this.buttonZoomOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(6, 25);
            // 
            // buttonZoomAll
            // 
            this.buttonZoomAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.buttonZoomAll.Image = ((Image)(resources.GetObject("buttonZoomAll.Image")));
            this.buttonZoomAll.ImageTransparentColor = Color.Magenta;
            this.buttonZoomAll.Name = "buttonZoomAll";
            this.buttonZoomAll.Size = new Size(57, 22);
            this.buttonZoomAll.Text = "ZoomAll";
            this.buttonZoomAll.Click += new EventHandler(this.buttonZoomAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 25);
            // 
            // buttonFindPolylines
            // 
            this.buttonFindPolylines.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonFindPolylines.Image = Resources.search_512;
            this.buttonFindPolylines.ImageTransparentColor = Color.Magenta;
            this.buttonFindPolylines.Name = "buttonFindPolylines";
            this.buttonFindPolylines.Size = new Size(23, 22);
            this.buttonFindPolylines.Text = "toolStripButton1";
            this.buttonFindPolylines.ToolTipText = "Найти полилинии, пересекающие выбранный полигон";
            this.buttonFindPolylines.Click += new EventHandler(this.buttonFindPolylines_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
            this.labelMapCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(575, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMapCursorPosition
            // 
            this.labelMapCursorPosition.Name = "labelMapCursorPosition";
            this.labelMapCursorPosition.Size = new Size(118, 17);
            this.labelMapCursorPosition.Text = "toolStripStatusLabel1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(126, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 403);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            this.openFileDialog.Title = "Добавить слои";
            // 
            // map1
            // 
            this.map1.ActiveTool = MapToolType.Select;
            this.map1.BackColor = SystemColors.Window;
            this.map1.Cursor = Cursors.Arrow;
            this.map1.Dock = DockStyle.Fill;
            this.map1.Location = new System.Drawing.Point(129, 25);
            this.map1.MapScale = 1D;
            this.map1.Name = "map1";
            this.map1.SelectionColor = Color.Blue;
            this.map1.Size = new Size(446, 403);
            this.map1.TabIndex = 0;
            this.map1.MouseMove += new MouseEventHandler(this.map1_MouseMove);
            // 
            // layersControl1
            // 
            this.layersControl1.Dock = DockStyle.Left;
            this.layersControl1.Location = new System.Drawing.Point(0, 25);
            this.layersControl1.Name = "layersControl1";
            this.layersControl1.Size = new Size(126, 403);
            this.layersControl1.TabIndex = 5;
            this.layersControl1.Load += new EventHandler(this.layersControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(575, 450);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.layersControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MiniGIS";
            this.Load += new EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map map1;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonSelect;
        private ToolStripButton buttonPan;
        private ToolStripButton buttonZoomIn;
        private ToolStripButton buttonZoomOut;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelMapCursorPosition;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton buttonZoomAll;
        private LayersControl layersControl1;
        private Splitter splitter1;
        private OpenFileDialog openFileDialog;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton buttonFindPolylines;
    }
}

