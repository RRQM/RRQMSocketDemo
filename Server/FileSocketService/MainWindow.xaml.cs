using System.Windows;
using FileSocketServiceDemo.ViewModels;
using RRQMSkin.Windows;

namespace FileSocketServiceDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : RRQMWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Window = this;
            RRQMMVVM.SimpleIoc.Default.Register(this, new MainViewModel());
        }

        public static Window Window;
    }
}