using System;
using System.Collections.Generic;
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

namespace MyLayouts
{
    /// <summary>
    /// StandardLayout.xaml 的交互逻辑
    /// </summary>
    public partial class StandardLayout : UserControl
    {
        public static readonly DependencyProperty ToolsAreaProperty = DependencyProperty.Register(
            "ToolsArea", typeof(object), typeof(StandardLayout), new PropertyMetadata(null));
        public static readonly DependencyProperty ContentAreaProperty = DependencyProperty.Register(
            "ContentArea", typeof(object), typeof(StandardLayout), new PropertyMetadata(null));

        public StandardLayout()
        {
            InitializeComponent();
        }

        public object ToolsArea
        {
            get { return GetValue(ToolsAreaProperty); }
            set { SetValue(ToolsAreaProperty, value); }
        }
        public object ContentArea
        {
            get { return GetValue(ContentAreaProperty); }
            set { SetValue(ContentAreaProperty, value); }
        }
    }
}
