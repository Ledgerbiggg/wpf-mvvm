using System;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Vm.Vm _vm = new Vm.Vm();
        public MainWindow()
        {
            InitializeComponent();
            _vm = new Vm.Vm();
            DataContext = _vm;
        }


    }
}