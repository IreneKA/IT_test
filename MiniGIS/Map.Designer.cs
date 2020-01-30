using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGIS
{
    partial class Map
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
            this.SuspendLayout();
            // 
            // Map
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "Map";
            this.Paint += new PaintEventHandler(this.Map_Paint);
            this.MouseDown += new MouseEventHandler(this.Map_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Map_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Map_MouseUp);
            this.Resize += new EventHandler(this.Map_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
