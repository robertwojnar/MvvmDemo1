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
        public ICommand ClickedCommand => new RelayCommand(Clicked);

        private void Loaded()
        {
            Debug.WriteLine("Loaded");
        }

        private void Clicked()
        {
            Debug.WriteLine("Clicked");
        }
    }
}
