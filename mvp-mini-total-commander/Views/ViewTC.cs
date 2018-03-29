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
        private bool activePanel; // TRUE - left is active, FALSE - right is active
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
        public event Func<string, string> GetParent;
        public event Func<string> GetPath;
        public event Func<string,string,bool> Copy;
        public event Func<string, string, bool> Move;
        public event Func<string, bool> Delete;
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
            ((PanelTC)sender).Items = GetItems(((PanelTC)sender).Path);
            ((PanelTC)sender).Path = GetPath();
        }
        private void PanelTC_ButtonBackClick(object sender, EventArgs e)
        {
            Console.WriteLine(((PanelTC)sender).Path);
            ((PanelTC)sender).Path = GetParent(((PanelTC)sender).Path);
            ((PanelTC)sender).Items = GetItems(((PanelTC)sender).Path);
            Console.WriteLine(((PanelTC)sender).Path);
        }
        private void PanelTC_UpdateDrives(object sender, EventArgs e)
        {
            ((PanelTC)sender).Drives = GetDrives();
        }
        #endregion

        private void panelTCLeft_Click(object sender, EventArgs e)
        {
            activePanel = true;
            panelTCLeft.BackColor = Color.Gray;
            panelTCRight.BackColor = Color.DimGray;
        }

        private void panelTCRight_Click(object sender, EventArgs e)
        {
            activePanel = false;
            panelTCLeft.BackColor = Color.DimGray;
            panelTCRight.BackColor = Color.Gray;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (activePanel)
            {
                Console.WriteLine(Copy(LeftPath + panelTCLeft.SelectedItem, RightPath + panelTCLeft.SelectedItem));
                RightItems = GetItems(RightPath);
            }
            else
            {
                Console.WriteLine(Copy(RightPath + panelTCRight.SelectedItem,LeftPath + panelTCRight.SelectedItem));
                LeftItems = GetItems(LeftPath);
            }

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (activePanel)
            {
                Console.WriteLine(Move(LeftPath + panelTCLeft.SelectedItem, RightPath + panelTCLeft.SelectedItem));
            }
            else
            {
                Console.WriteLine(Move(RightPath + panelTCRight.SelectedItem, LeftPath + panelTCRight.SelectedItem));
            }
            RightItems = GetItems(RightPath);
            LeftItems = GetItems(LeftPath);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (activePanel)
            {
                Console.WriteLine(Delete(LeftPath + panelTCLeft.SelectedItem));
                LeftItems = GetItems(LeftPath);
            }
            else
            {
                Console.WriteLine(Delete(RightPath + panelTCRight.SelectedItem));
                RightItems = GetItems(RightPath);
            }
        }
    }
}
