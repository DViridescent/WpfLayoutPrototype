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

namespace MyControls
{
    /// <summary>
    /// MyButtonWithText.xaml 的交互逻辑
    /// </summary>
    public partial class MyButtonWithText : UserControl
    {
        public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register(
            "ButtonCommand", typeof(ICommand), typeof(MyButtonWithText), new PropertyMetadata(null));

        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register(
            "ButtonText", typeof(string), typeof(MyButtonWithText), new PropertyMetadata(null));

        public static readonly DependencyProperty DescriptionTextProperty = DependencyProperty.Register(
            "DescriptionText", typeof(string), typeof(MyButtonWithText), new PropertyMetadata(null));


        public MyButtonWithText()
        {
            InitializeComponent();
        }

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public string DescriptionText
        {
            get { return (string)GetValue(DescriptionTextProperty); }
            set { SetValue(DescriptionTextProperty, value); }
        }
    }
}
