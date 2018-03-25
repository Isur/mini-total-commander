using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp_mini_total_commander.Views
{
    public partial class PanelTC : UserControl
    {
        string temp;
        #region CONSTRUCTOR
        public PanelTC()
        {
            InitializeComponent();
        }
        #endregion
        #region PROPERTIES
        public List<string> Drives
        {
            get
            {
                List<string> drives = new List<string>();
                foreach(string item in comboBoxDrives.Items)
                {
                    drives.Add(item);
                }
                return drives;
            }
            set
            {
                comboBoxDrives.Items.Clear();
                foreach (string item in value)
                {
                    comboBoxDrives.Items.Add(item);
                }
            }
        }
        public List<string> Items
        {
            get
            {
                List<string> items = new List<string>();
                foreach(string item in listBoxItems.Items)
                {
                    items.Add(item);
                }
                return items;
            }
            set
            {
                listBoxItems.Items.Clear();
                foreach(string item in value)
                {
                    listBoxItems.Items.Add(item);
                }
            }
        }
        public string Path
        {
            get
            {
                return textBoxPath.Text;
            }
            set
            {
                textBoxPath.Text = value;
            }
        }
        #endregion
        #region PRIVATE
        #endregion

        #region EVENT HANDLER
        public event EventHandler ComboBoxChangeValue;
        public event EventHandler ListBoxDoubleClick;
        public event EventHandler ButtonBackClick;
        public event EventHandler UpdateDrives;
        private void ComboBoxDrives_ChangeValue(object sender, EventArgs e)
        {
            Path = comboBoxDrives.SelectedItem.ToString();
            if (this.ComboBoxChangeValue != null)
                this.ComboBoxChangeValue(this, e);
        }
        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListBoxDoubleClick != null)
            {
                temp = listBoxItems.SelectedItem.ToString();
                Path += temp;
                this.ListBoxDoubleClick(this, e);
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if(this.ButtonBackClick != null)
            {
                this.ButtonBackClick(this, e);
            }
        }
        private void ComboBox_Click(object sender, EventArgs e)
        {
            if(this.UpdateDrives != null)
            {
                this.UpdateDrives(this, e);
            }
        }

        #endregion
    }
}
