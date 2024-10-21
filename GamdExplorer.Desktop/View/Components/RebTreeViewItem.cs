using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GamdExplorer.Desktop.View.Components
{
    public class RebTreeViewItem : TreeViewItem
    {

        public static readonly DependencyProperty NameItemProperty;
        public static readonly DependencyProperty PathProperty;

        private DirectoryInfo _Directory;
        private FileInfo _FileInfo;
        static RebTreeViewItem()
        {
            NameItemProperty = DependencyProperty.Register("NameItem", typeof(string), typeof(RebTreeViewItem));



            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            PathProperty = DependencyProperty.Register("Path", typeof(string), typeof(RebTreeViewItem) , metadata, default );
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            if(d is RebTreeViewItem item && (baseValue.ToString()) is string str_data)
            {
                if (Directory.Exists(str_data))
                {
                    new DirectoryInfo(str_data);
                }
                else if (File.Exists(str_data))
                {

                }
                Debug.WriteLine($"{item} {baseValue.ToString()}");
            }


           
            return null;
        }

        public string NameItem
        {
            get { return (string)GetValue(NameItemProperty); }
            set { SetValue(NameItemProperty, value); }
        }
        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }





        protected override void OnExpanded(RoutedEventArgs e)
        {
            Debug.WriteLine($"2 {this.IsExpanded}");



            base.OnExpanded(e);
        }
        protected override void OnCollapsed(RoutedEventArgs e)
        {
            Debug.WriteLine($"1 {this.IsExpanded}");



            base.OnCollapsed(e);
        }


        protected override void AddChild(object value)
        {
            base.AddChild(value);

        }
    }
}
