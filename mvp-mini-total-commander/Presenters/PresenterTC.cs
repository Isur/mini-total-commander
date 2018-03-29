using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_mini_total_commander.Presenters
{
    public class PresenterTC
    {
        Models.ModelTC model;
        Views.IViewTC view;
        public PresenterTC(Models.ModelTC model, Views.IViewTC view)
        {
            this.model = model;
            this.view = view;
            view.GetDrives += getDrives;
            view.GetItems += getItems;
            view.GetPath += getPath;
            view.GetParent += getParent;
            view.Copy += copyFile;
            view.Delete += deleteFile;
            view.Move += moveFile;
        }

        private List<string> getDrives()
        {
            return model.GetDrives();
        }
        private List<string> getItems(string path)
        {
            return model.GetItems(path);
        }
        private string getPath()
        {
            return model.Path;
        }
        private string getParent(string path)
        {
            return model.GetParent(path);
        }
        private bool copyFile(string source, string target)
        {
            return model.Copy(source, target);
        }
        private bool moveFile(string source, string target)
        {
            return model.Move(source, target);
        }
        private bool deleteFile(string source)
        {
            return model.Delete(source);
        }
    }
}
