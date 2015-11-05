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
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }
        public int Number_Question;

        public string Question { get { return question[Number_Question]; } }
        public string Answer_A { get { return answer[Number_Question][0]; } }
        public string Answer_B { get { return answer[Number_Question][1]; } }
        public string Answer_C { get { return answer[Number_Question][2]; } }
        public string Answer_D { get { return answer[Number_Question][3]; } }
        
        //private MainForm form;

        public Game()//MainForm f)
        {
            //form = f;
            Random rnd = new Random();
            Number_Question = rnd.Next(0, 28)*5;
            question = new List<string>();
            answer = new List<Answer>();
            Download();
            Number_Question = 0;
            OnStart();
        }

        private void OnStart()
        {
            /*int i = 0;
            {
                form.Question = question[i];
                form.Answer_A = answer[i][0];
                form.Answer_B = answer[i][1];
                form.Answer_C = answer[i][2];
                form.Answer_D = answer[i][3];
            }*/
        }
        private void Download()
        {
            using (StreamReader sr = new StreamReader("..\\..\\Resources\\question.txt", Encoding.Default))
            {
                for (int i = 0; i < Number_Question; i++)
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
        public bool IsAnswerRight()
        {
            return User_Answer == Right_Answer;
        }
    }
}
