using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp_mini_total_commander.Views
{
    public partial class ViewTC : Form, Views.IViewTC
    {
        public ViewTC()
        {
            InitializeComponent();
            panelTCLeft.ComboBoxChangeValue += new EventHandler(PanelTC_ComboBoxChangeValue);
            panelTCRight.ComboBoxChangeValue += new EventHandler(PanelTC_ComboBoxChangeValue);

            panelTCLeft.ListBoxDoubleClick += new EventHandler(PanelTC_ListBoxDoubleClick);
            panelTCRight.ListBoxDoubleClick += new EventHandler(PanelTC_ListBoxDoubleClick);

            panelTCLeft.ButtonBackClick += new EventHandler(PanelTC_ButtonBackClick);
            panelTCRight.ButtonBackClick += new EventHandler(PanelTC_ButtonBackClick);

            panelTCLeft.UpdateDrives += new EventHandler(PanelTC_UpdateDrives);
            panelTCRight.UpdateDrives += new EventHandler(PanelTC_UpdateDrives);
        }
        #region INTERFACE
        public List<string> Drives
        {
            get
            {
                return panelTCLeft.Drives;
            }

            set
            {
                panelTCLeft.Drives = value;
                panelTCRight.Drives = value;
            }
        }

        public List<string> LeftItems
        {
            get
            {
                return panelTCLeft.Items;
            }

            set
            {
                panelTCLeft.Items = value;
            }
        }

        public string LeftPath
        {
            get
            {
                return panelTCLeft.Path;
            }

            set
            {
                panelTCLeft.Path = value;
            }
        }

        public List<string> RightItems
        {
            get
            {
                return panelTCRight.Items;
            }

            set
            {
                panelTCRight.Items = value;
            }
        }

        public string RightPath
        {
            get
            {
                return panelTCRight.Path;
            }

            set
            {
                panelTCRight.Path = value;
            }
        }

        public event Func<List<string>> GetDrives;
        public event Func<string, List<string>> GetItems;
        public event Func<string> GetParent;
        public event Func<string> GetPath;
        #endregion
        #region PRIVATE
        private void onLoad(object sender, EventArgs e)
        {
            Drives = GetDrives();
        }
        #endregion
        #region PANEL EVENTS
        private void PanelTC_ComboBoxChangeValue(object sender, EventArgs e)
        {
            ((PanelTC)sender).Items = GetItems(((PanelTC)sender).Path);
        }

        private void PanelTC_ListBoxDoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            ((PanelTC)sender).Items = GetItems(((PanelTC)sender).Path);
            ((PanelTC)sender).Path = GetPath();
        }
        private void PanelTC_ButtonBackClick(object sender, EventArgs e)
        {
            ((PanelTC)sender).Path = GetParent();
            ((PanelTC)sender).Items = GetItems(((PanelTC)sender).Path);
        }
        private void PanelTC_UpdateDrives(object sender, EventArgs e)
        {
            ((PanelTC)sender).Drives = GetDrives();
        }
        #endregion
    }
}
