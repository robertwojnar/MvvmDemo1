using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo1.WPF
{
    public class ReceivedEventArgs : EventArgs
    {
        public int Data { get; set; }
    }
}
