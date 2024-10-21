using GamdExplorer.Desktop.Model.TreeView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamdExplorer.Desktop.ViewModel
{
    public class VM_BindingBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void Env_NotifyPropertyChanged(string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private ObservableCollection<TreeViewItem_base> _TreeView_Items;
         
        public ObservableCollection<TreeViewItem_base> TreeView_Items
        {
            get
            {
                if(_TreeView_Items == null)
                    _TreeView_Items = new ObservableCollection<TreeViewItem_base>();
                return _TreeView_Items;
            }
            set
            {
                _TreeView_Items = value;
                this.Env_NotifyPropertyChanged();
            }
        }

    }
}
