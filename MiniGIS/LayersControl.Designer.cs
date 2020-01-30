using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MiniGIS.Properties;

namespace MiniGIS
{
    partial class LayersControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Города");
            ListViewItem listViewItem2 = new ListViewItem("Реки");
            ListViewItem listViewItem3 = new ListViewItem("Леса");
            this.listView = new ListView();
            this.toolStrip1 = new ToolStrip();
            this.buttonAdd = new ToolStripButton();
            this.buttonRemove = new ToolStripButton();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.buttonUp = new ToolStripButton();
            this.buttonDown = new ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.CheckBoxes = true;
            this.listView.Dock = DockStyle.Fill;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            this.listView.Items.AddRange(new ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new Size(419, 327);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = View.List;
            this.listView.ItemChecked += new ItemCheckedEventHandler(this.listView_ItemChecked);
            this.listView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.listView.SelectedIndexChanged += new EventHandler(this.listView_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.buttonAdd,
            this.buttonRemove,
            this.toolStripSeparator1,
            this.buttonUp,
            this.buttonDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 302);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(419, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonAdd.Image = Resources._37770;
            this.buttonAdd.ImageTransparentColor = Color.Magenta;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(23, 22);
            this.buttonAdd.Text = "toolStripButton1";
            this.buttonAdd.ToolTipText = "Добавить слой";
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Image = Resources._5005_512;
            this.buttonRemove.ImageTransparentColor = Color.Magenta;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new Size(23, 22);
            this.buttonRemove.Text = "toolStripButton2";
            this.buttonRemove.ToolTipText = "Удалить слой";
            this.buttonRemove.Click += new EventHandler(this.buttonRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(6, 25);
            // 
            // buttonUp
            // 
            this.buttonUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonUp.Enabled = false;
            this.buttonUp.Image = Resources._512px_Arrow_up_font_awesome_svg;
            this.buttonUp.ImageTransparentColor = Color.Magenta;
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new Size(23, 22);
            this.buttonUp.Text = "toolStripButton3";
            this.buttonUp.ToolTipText = "Переместить вверх";
            this.buttonUp.Click += new EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.buttonDown.Enabled = false;
            this.buttonDown.Image = Resources.down_arrow_8_458425;
            this.buttonDown.ImageTransparentColor = Color.Magenta;
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new Size(23, 22);
            this.buttonDown.Text = "toolStripButton4";
            this.buttonDown.ToolTipText = "Переместить вниз";
            this.buttonDown.Click += new EventHandler(this.buttonDown_Click);
            // 
            // LayersControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView);
            this.Name = "LayersControl";
            this.Size = new Size(419, 327);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonAdd;
        private ToolStripButton buttonRemove;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton buttonUp;
        private ToolStripButton buttonDown;
    }
}
