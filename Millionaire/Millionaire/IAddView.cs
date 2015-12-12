using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IAddView
    {
        string Question { get; set; }
        string Answer_A { get; set; }
        string Answer_B { get; set; }
        string Answer_C { get; set; }
        string Answer_D { get; set; }
        event EventHandler<EventArgs> Add;

    }
}
