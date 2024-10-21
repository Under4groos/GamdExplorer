using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamdExplorer.Desktop.Model.TreeView
{
    public class TreeView_Directory : TreeViewItem_base
    {
        public List<TreeViewItem_base> Items { get; set; }
        public TreeView_Directory() 
        {
            Items = new List<TreeViewItem_base>();
        }
    }
}
