using MvvmDemo1.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MvvmDemo1.WPF.Views
{
    /// <summary>
    /// Interaction logic for FooUserControl.xaml
    /// </summary>
    public partial class FooUserControl : UserControl
    {
        public FooUserControl()
        {
            InitializeComponent();
            this.DataContextChanged += FooUserControl_DataContextChanged;
        }

        private void FooUserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ((MainWindowViewModel)DataContext).OnSomethingReceived += FooUserControl_OnSomethingReceived;
        }

        private void FooUserControl_OnSomethingReceived(object sender, ReceivedEventArgs e)
        {
            Debug.WriteLine("Received: " + e.Data);
        }

        public event EventHandler<BarEventArgs> BarClick;
        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            double x = e.GetPosition(this).X;
            double y = e.GetPosition(this).Y;
            string value_to_pass = "[" + x + "," + y + "]";

            BarEventArgs bar = new BarEventArgs() { Bar = 2, Foo = value_to_pass };
            BarClick?.Invoke(sender, bar);
        }
    }
}
