using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class Answer
    {
        public string[] name;
        public static int Number { get; set; }
        public Answer()
        {
            name = new string[4];
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < name.Length)
                {
                    return name[index];
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 0 && index < name.Length)
                {
                    name[index] = value;
                }
                else
                {
                    throw new Exception("Некорректный индекс! " + index);
                }
            }
        }
    }
}
