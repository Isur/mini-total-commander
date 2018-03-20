using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace mvp_mini_total_commander.Models
{
    public class ModelTC
    {
        #region Fields
        private List<string> drives;
        private List<string> items;
        private string path;

        #endregion
        #region Properties
        public List<string> Drives
        {
            get
            {
                return drives;
            }
            set
            {
                drives = value;
            }
        }
        public List<string> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        #endregion
        #region Constructors
        public ModelTC() { }

        #endregion
        #region Public
        public List<string> GetDrives()
        {
            updateDrives();
            return Drives;
        }

        public bool IsFolder(string path)
        {
            System.IO.FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }
        public bool OpenFile(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
        public List<string> GetItems(string path)
        {
            if (System.IO.Directory.Exists(path))
            {
                List<string> allItems = new List<string>();
                try
                {
                    string[] temp = System.IO.Directory.GetFileSystemEntries(path);
                    foreach (string it in temp)
                    {
                        string t = System.IO.Path.GetFileName(it);
                        if (File.GetAttributes(it).HasFlag(FileAttributes.Directory))
                            t += @"\";
                        allItems.Add(t);
                    }
                    Path = path;
                    Items = allItems;
                }
                catch (UnauthorizedAccessException)
                {

                }
            }
            else if(System.IO.File.Exists(path))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    System.Diagnostics.Process.Start(path);
                }).Start();
            }
            else
                throw new Exception(string.Format("No Folder at path: {0}", path));
            return Items;
        }
        public string UpdatePath()
        {
            return Path;
        }
        public string GetParent()
        {
            try
            {
                Path =  System.IO.Directory.GetParent(System.IO.Directory.GetParent(Path).ToString()).ToString();
                return Path;
            }
            catch (Exception)
            {
                return Path;
            }
        }

        #endregion
        #region Private
        private void updateDrives()
        {
            System.IO.DriveInfo[] allDrives = System.IO.DriveInfo.GetDrives();
            List<string> readyDrives = new List<string>();
            foreach (System.IO.DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    readyDrives.Add(drive.ToString());
                }
            }
            Drives = readyDrives;
        }
        #endregion
    }
}
