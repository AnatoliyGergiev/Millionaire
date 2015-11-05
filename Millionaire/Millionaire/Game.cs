using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    class Game
    {
        private readonly List<string> question;
        private readonly List<Answer> answer;
        public string UserAnswer{ get; set; }
        private int number_question;
        
        private MainForm form;

        public Game(MainForm f)
        {
            form = f;
            Random rnd = new Random();
            number_question = rnd.Next(0, 28)*5;
            question = new List<string>();
            answer = new List<Answer>();
            Download();
            OnStart();
        }

        private void OnStart()
        {
            int i = 0;
            {
                form.TextBox_Question = question[i];
                form.Button_A = answer[i][0];
                form.Button_B = answer[i][1];
                form.Button_C = answer[i][2];
                form.Button_D = answer[i][3];
            }
        }
        private void Download()
        {
            using (StreamReader sr = new StreamReader("..\\..\\Resources\\question.txt", Encoding.Default))
            {
                for (int i = 0; i < number_question; i++)
                    sr.ReadLine();
                for (int i = 0; i < 15; i++)
                {
                    question.Add(sr.ReadLine());
                    for (int j = 0; j < 4; j++)
                    {
                        answer.Add(new Answer());
                        answer[i][j] = sr.ReadLine();
                    }
                }
            }
        }
    }
}
