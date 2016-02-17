using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MvvmDemo1.WPF.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public string Title => "Main window";
        
        public ICommand LoadedCommand => new RelayCommand(Loaded);
        private void Loaded()
        {
            Debug.WriteLine("Loaded");
        }

        public ICommand ClickedCommand => new RelayCommand<BarEventArgs>(o => Clicked(o.Foo));
        private void Clicked(string a)
        {
            Debug.WriteLine("Clicked " + a);
        }
    }
}
