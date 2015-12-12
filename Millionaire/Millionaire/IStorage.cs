using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    interface IStorage
    {
        List<string> Download();
        void SaveQuestion(string[] str);
        void RemoveQuestion(string question, Game g);
        void EditQuestion(string[] str, Game g);
    }
}
