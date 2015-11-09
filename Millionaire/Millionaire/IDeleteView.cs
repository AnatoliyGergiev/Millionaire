using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    interface IDeleteView
    {
        string Question { get; set; }
        int Current_Question { get; }
        int MaxQuestions { set; }
        event EventHandler<EventArgs> Delete_q;
        event EventHandler<EventArgs> Update_v;
    }
}
