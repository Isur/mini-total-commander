﻿using System;
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
                    Items = GetItems(GetParent(path));
                }
            }
            else if(System.IO.File.Exists(path))
            {
                Console.WriteLine("test?");
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    System.Diagnostics.Process.Start(path);
                }).Start();
            }
            return Items;
        }
        public string GetParent(string path)
        {
            try
            {
                Path =  System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString() + @"\";
                if (Path.EndsWith(@"\\"))
                    Path = Path.Remove(Path.Length - 1);
                return Path;
            }
            catch (Exception)
            {
                return path;
            }
        }
  
        public bool Copy(string source, string target)
        {
            if (checkAccess(source))
                return copy(source, target);
            else
                return false;
        }
        private bool copy(string source, string target)
        {
            if (target.StartsWith(source)) { return false; }
                            
            if (source != target && !System.IO.File.Exists(target))
            {
                if (System.IO.Directory.Exists(source))
                {try
                    {
                        System.IO.Directory.CreateDirectory(target);
                        foreach (string dir in System.IO.Directory.GetFileSystemEntries(source))
                        {
                            if (System.IO.File.GetAttributes(dir).HasFlag(FileAttributes.Directory))
                            {
                                 System.IO.Directory.CreateDirectory(target + @"\" + System.IO.Path.GetFileName(dir));
                                copy(dir, target + @"\" + System.IO.Path.GetFileName(dir));
                            }
                            else
                            {
                                copy(dir, target + @"\" + System.IO.Path.GetFileName(dir));
                            }
                        }
                        return true;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        System.IO.Directory.Delete(target);
                        return false;
                    }
                }
                else if (System.IO.File.Exists(source))
                {
                    try
                    {
                        System.IO.File.Copy(source, target);
                    }
                    catch(UnauthorizedAccessException)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;

        }
        public bool Move(string source, string target)
        {
            if(!checkAccess(source)) { return false; }
            if (target.StartsWith(source)) { return false; }
            if (source != target && System.IO.File.Exists(source))
            {
                if (!copy(source, target))
                    return false;
                Delete(source);
                return true;
            }else if (source != target && System.IO.Directory.Exists(source))
            {
                if (!copy(source, target))
                    return false;
                Delete(source);
                return true;
            }
            return false;
        }
        public bool Delete(string source)
        {
            if (!checkAccess(source))
                return false;
            try
            {
                if (System.IO.File.Exists(source))
                {
                    System.IO.File.Delete(source);
                    return true;
                }
                else if (System.IO.Directory.Exists(source))
                {
                    foreach (string file in System.IO.Directory.GetFileSystemEntries(source))
                    {
                        if (!Delete(file))
                            return false;
                    }
                    System.IO.Directory.Delete(source);
                    return true;
                }
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
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
        private bool checkAccess(string source)
        {
            try
            {
                System.IO.File.GetAttributes(source);
                if (System.IO.Directory.Exists(source))
                {
                    foreach (string dir in System.IO.Directory.GetDirectories(source))
                    {
                        if (!checkAccess(dir))
                            return false;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
