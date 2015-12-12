using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class FileStorage:IStorage
    {
        public List<string> Download()
        {
            List<string> str = new List<string>();
            using (StreamReader sr = new StreamReader("..\\..\\Resources\\question.txt", Encoding.Default))
            {
                int i = -1;
                do
                {
                    i++;
                    str.Add(sr.ReadLine());
                } while (str[i] != null);
                str.RemoveAt(i);
            }
            return str;
        }
        public void SaveQuestion(string[] str)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\Resources\\question.txt", true, Encoding.Default))
            {
                for (int i = 0; i < 5; i++)
                    sw.WriteLine(str[i]);
            }
        }
        public void RemoveQuestion(string question, Game g)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\Resources\\question.txt", false, Encoding.Default))
            {
                for (int n = 0; n < g.Count_Question; n++)
                {
                    g.Current_Question = n;
                    sw.WriteLine(g.Question);
                    sw.WriteLine(g.Answer_A);
                    sw.WriteLine(g.Answer_B);
                    sw.WriteLine(g.Answer_C);
                    sw.WriteLine(g.Answer_D);
                }
            }
        }
        public void EditQuestion(string[] str, Game g)
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\Resources\\question.txt", false, Encoding.Default))
            {
                for (int n = 0; n < g.Count_Question; n++)
                {
                    g.Current_Question = n;
                    sw.WriteLine(g.Question);
                    sw.WriteLine(g.Answer_A);
                    sw.WriteLine(g.Answer_B);
                    sw.WriteLine(g.Answer_C);
                    sw.WriteLine(g.Answer_D);
                }
            }
        }
    }
}

