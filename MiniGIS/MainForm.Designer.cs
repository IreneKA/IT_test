namespace MiniGIS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSelect = new System.Windows.Forms.ToolStripButton();
            this.buttonPan = new System.Windows.Forms.ToolStripButton();
            this.buttonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.buttonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonZoomAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonFindPolylines = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelMapCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.map1 = new MiniGIS.Map();
            this.layersControl1 = new MiniGIS.LayersControl();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStrip1.Size = new System.Drawing.Size(575, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonSelect
            // 
            this.buttonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSelect.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelect.Image")));
            this.buttonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(23, 22);
            this.buttonSelect.Text = "buttonSelect";
            this.buttonSelect.ToolTipText = "Выбрать";
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonPan
            // 
            this.buttonPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPan.Image = ((System.Drawing.Image)(resources.GetObject("buttonPan.Image")));
            this.buttonPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPan.Name = "buttonPan";
            this.buttonPan.Size = new System.Drawing.Size(23, 22);
            this.buttonPan.Text = "toolStripButton2";
            this.buttonPan.ToolTipText = "Рука";
            this.buttonPan.Click += new System.EventHandler(this.buttonPan_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomIn.Image")));
            this.buttonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(23, 22);
            this.buttonZoomIn.Text = "toolStripButton3";
            this.buttonZoomIn.ToolTipText = "Увеличить";
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomOut.Image")));
            this.buttonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(23, 22);
            this.buttonZoomOut.Text = "toolStripButton4";
            this.buttonZoomOut.ToolTipText = "Уменьшить";
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonZoomAll
            // 
            this.buttonZoomAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonZoomAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomAll.Image")));
            this.buttonZoomAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomAll.Name = "buttonZoomAll";
            this.buttonZoomAll.Size = new System.Drawing.Size(57, 22);
            this.buttonZoomAll.Text = "ZoomAll";
            this.buttonZoomAll.Click += new System.EventHandler(this.buttonZoomAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonFindPolylines
            // 
            this.buttonFindPolylines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFindPolylines.Image = global::MiniGIS.Properties.Resources.search_512;
            this.buttonFindPolylines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFindPolylines.Name = "buttonFindPolylines";
            this.buttonFindPolylines.Size = new System.Drawing.Size(23, 22);
            this.buttonFindPolylines.Text = "toolStripButton1";
            this.buttonFindPolylines.ToolTipText = "Найти полилинии, пересекающие выбранный полигон";
            this.buttonFindPolylines.Click += new System.EventHandler(this.buttonFindPolylines_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMapCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(575, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMapCursorPosition
            // 
            this.labelMapCursorPosition.Name = "labelMapCursorPosition";
            this.labelMapCursorPosition.Size = new System.Drawing.Size(118, 17);
            this.labelMapCursorPosition.Text = "toolStripStatusLabel1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(126, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 403);
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
            this.map1.ActiveTool = MiniGIS.MapToolType.Select;
            this.map1.BackColor = System.Drawing.SystemColors.Window;
            this.map1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.Location = new System.Drawing.Point(129, 25);
            this.map1.MapScale = 1D;
            this.map1.Name = "map1";
            this.map1.SelectionColor = System.Drawing.Color.Blue;
            this.map1.Size = new System.Drawing.Size(446, 403);
            this.map1.TabIndex = 0;
            this.map1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map1_MouseMove);
            // 
            // layersControl1
            // 
            this.layersControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layersControl1.Location = new System.Drawing.Point(0, 25);
            this.layersControl1.Name = "layersControl1";
            this.layersControl1.Size = new System.Drawing.Size(126, 403);
            this.layersControl1.TabIndex = 5;
            this.layersControl1.Load += new System.EventHandler(this.layersControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.layersControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MiniGIS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map map1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonSelect;
        private System.Windows.Forms.ToolStripButton buttonPan;
        private System.Windows.Forms.ToolStripButton buttonZoomIn;
        private System.Windows.Forms.ToolStripButton buttonZoomOut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelMapCursorPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonZoomAll;
        private LayersControl layersControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonFindPolylines;
    }
}

