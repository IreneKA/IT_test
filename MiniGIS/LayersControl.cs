using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGIS
{
    public partial class LayersControl : UserControl
    {
        public event EventHandler AddLayer;
        public Map Map;

        public int SelectedItemsCount { get { return listView.SelectedItems.Count; } }
        public LayersControl()
        {
            InitializeComponent();
        }
        public void UpdateLayers()
        {
            if (Map == null) return;
            listView.Items.Clear();
            foreach (var layer in Map.Layers)
            {
                var listViewItem = new ListViewItem();
                listViewItem.Text = layer.Name;
                listViewItem.Checked = layer.Visible;
                listViewItem.Selected = layer.Selected;
                listViewItem.Tag = layer;
                listView.Items.Insert(0, listViewItem);
                var tmplayer = (Layer)listViewItem.Tag;
                tmplayer.Visible = listViewItem.Checked;
            }
            CheckButtons();
        }

        private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var listViewItem = e.Item;
            Layer layer = (Layer)listViewItem.Tag;
            if (layer == null) return;
            layer.Visible = !layer.Visible;
            Map.Invalidate();
        }

        private void RemoveSelectedLayers()
        {
            if (Map == null) return;
            if (listView.SelectedItems.Count == 0) return;
            foreach (ListViewItem item in listView.SelectedItems)
            {
                Layer layer = (Layer)item.Tag;
                if (layer != null)
                {
                    Map.RemoveLayer(layer);
                }
            }
            UpdateLayers();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedLayers();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveSelectedLayersUp();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveSelectedLayersDown();

        }
        

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void CheckButtons()
        {
            buttonRemove.Enabled = listView.SelectedItems.Count > 0;
            buttonUp.Enabled = listView.SelectedItems.Count == 1 && listView.SelectedItems[0].Index > 0;
            buttonDown.Enabled = listView.SelectedItems.Count == 1 && listView.SelectedItems[0].Index < listView.Items.Count - 1;
        }

        public List<Layer> ReturnSelectedLayers()
        {
            List<Layer> layers = new List<Layer>();
            foreach (ListViewItem item in listView.SelectedItems)
            {
                Layer layer = (Layer)item.Tag;
                if (layer != null)
                {
                    layers.Add(layer);
                }
            }
            return layers;
        }
        private void MoveSelectedLayersUp()
        {
            if (Map == null) return;
            if (listView.SelectedItems.Count != 1) return;
            Layer layer = (Layer)listView.SelectedItems[0].Tag;
            if (layer == null) return;
            Map.MoveLayerUp(layer);
            UpdateLayers();
        }
        private void MoveSelectedLayersDown()
        {
            if (Map == null) return;
            if (listView.SelectedItems.Count != 1) return;
            Layer layer = (Layer)listView.SelectedItems[0].Tag;
            if (layer == null) return;
            Map.MoveLayerDown(layer);
            UpdateLayers();
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Layer layer = (Layer)e.Item.Tag;
            layer.Selected = e.IsSelected;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddLayer == null) return;
            AddLayer(sender, e);
        }
    }
}
