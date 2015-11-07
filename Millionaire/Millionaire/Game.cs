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
        public int Count_Question { get; set; }
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }
        public int Number_Question {get; set;}
        public int Current_Question { get; set; }
        public void Remove_Question(int index)
        {
            question.RemoveAt(index);
            answer.RemoveAt(index);
            Count_Question--;
        }
        public string Question 
        { 
            get { return question[Current_Question]; }
            set { question.Add(value); }
        }
        public string Answer_A 
        { 
            get { Right_Answer = answer[Current_Question][0]; return answer[Current_Question][0]; }
            set { answer.Add(new Answer()); answer[Count_Question++][0] = value; }
        }
        public string Answer_B 
        { 
            get { return answer[Current_Question][1]; }
            set { answer[Count_Question-1][1] = value; }
        }
        public string Answer_C 
        { 
            get { return answer[Current_Question][2]; }
            set { answer[Count_Question-1][2] = value; }
        }
        public string Answer_D 
        { 
            get { return answer[Current_Question][3]; }
            set { answer[Count_Question-1][3] = value; }
        }
        
        public void SaveQuestion()
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\Resources\\question.txt", true))
            {
                sw.WriteLine(question[Count_Question-1]);
                for (int i = 0; i < 4; i++)
                    sw.WriteLine(answer[Count_Question-1][i]);
            }
        }
        public void SaveQuestions()
        {
            using (StreamWriter sw = new StreamWriter("..\\..\\Resources\\question.txt", false))
            {
                for (int n = 0; n < Count_Question; n++)
                {
                    sw.WriteLine(question[n]);
                    for (int i = 0; i < 4; i++)
                        sw.WriteLine(answer[n][i]);
                }
            }
        }

        public Game()//MainForm f)
        {
            //form = f;
            Random rnd = new Random();
            question = new List<string>();
            answer = new List<Answer>();
            //int n;
            //do
            //{
            //    n = rnd.Next(0, 28) * 5;
            //} while (n <= 14);
            Download(0);
            Number_Question = 0;
            Current_Question = rnd.Next(0, Count_Question-1);
            //OnStart();
        }

        /*private void OnStart()
        {
            int i = 0;
            {
                form.Question = question[i];
                form.Answer_A = answer[i][0];
                form.Answer_B = answer[i][1];
                form.Answer_C = answer[i][2];
                form.Answer_D = answer[i][3];
            }
        }*/
        private void Download(int n)
        {
            using (StreamReader sr = new StreamReader("..\\..\\Resources\\question.txt", Encoding.Default))
            {
                //for (int i = 0; i < n; i++)
                //    sr.ReadLine();
                //for (int i = 0; i < 15; i++)
                //{
                //    question.Add(sr.ReadLine());
                //    for (int j = 0; j < 4; j++)
                //    {
                //        answer.Add(new Answer());
                //        answer[i][j] = sr.ReadLine();
                //    }
                //}
                int i=-1;
                do
                {
                    i++;
                    question.Add(sr.ReadLine());
                    answer.Add(new Answer());
                    for (int j = 0; j < 4; j++)
                    {
                        answer[i][j] = sr.ReadLine();
                    }
                } while (question[i] != null);
                question.RemoveAt(i);
                answer.RemoveAt(i);
                Count_Question = i;
            }
        }
        public bool IsAnswerRight()
        {
            return User_Answer == Right_Answer;
        }
    }
}
