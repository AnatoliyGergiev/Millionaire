using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    interface IEditView
    {
        string Question { get; set; }
        string Answer_A { get; set; }
        string Answer_B { get; set; }
        string Answer_C { get; set; }
        string Answer_D { get; set; }
        int Current_Question { get; }
        int MaxQuestions { set; }
        event EventHandler<EventArgs> Edit;
        event EventHandler<EventArgs> Update_v;

    }
}
