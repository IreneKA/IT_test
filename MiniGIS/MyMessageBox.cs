using System;
using System.Windows.Forms;

namespace MiniGIS
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetText(String str)
        {
            label1.Text = str;

        }
    }
}
