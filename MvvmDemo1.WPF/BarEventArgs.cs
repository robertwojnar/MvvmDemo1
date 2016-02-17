using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo1.WPF
{
    public class BarEventArgs : EventArgs
    {
        public int Bar { get; set; }
        public string Foo { get; set; }
    }
}
