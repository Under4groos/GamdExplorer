using GamdExplorer.Desktop.Model.TreeView;
using GamdExplorer.Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GamdExplorer.Desktop.View
{
    /// <summary>
    /// Логика взаимодействия для MainFrame.xaml
    /// </summary>
    public partial class MainFrame : UserControl
    {
        VM_BindingBase vM_BindingBase = new VM_BindingBase();
        public MainFrame()
        {
            InitializeComponent();
            string path_ = @"C:\Users\Owner\Downloads\asdasd";
            List<TreeViewItem_base> items = new List<TreeViewItem_base>();
            DirectoryInfo directoryInfo = new DirectoryInfo(path_);
            foreach (var item in directoryInfo.GetFiles())
            {
                vM_BindingBase.TreeView_Items.Add(new TreeView_File()
                {
                    Name = item.Name,
                    Path = item.FullName,
                });
            }
            foreach (var item in directoryInfo.GetDirectories())
            {
                vM_BindingBase.TreeView_Items.Add(new TreeView_File()
                {
                    Name = item.Name,
                    Path = item.FullName,
                });
            }
            vM_BindingBase.Env_NotifyPropertyChanged();
            this.DataContext = vM_BindingBase;
         
           
        }
    }
}
