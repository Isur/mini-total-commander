using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_mini_total_commander.Views
{
    public interface IViewTC
    {
        event Func<List<string>> GetDrives;
        event Func<string, List<string>> GetItems;
        event Func<string> GetPath;
        event Func<string> GetParent;
        List<string> Drives { get; set; }
        List<string> LeftItems { get; set; }
        List<string> RightItems { get; set; }
        string LeftPath { get; set; }
        string RightPath { get; set; }

    }
}
