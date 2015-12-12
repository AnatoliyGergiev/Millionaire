using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private readonly IStorage storage;
        public int Count_Question { get; set; }
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }
        public int Number_Question {get; set;}
        public int Current_Question { get; set; }
        public void Remove_Question(int index)
        {
            storage.RemoveQuestion(question[index], this);
            question.RemoveAt(index);
            answer.RemoveAt(index);
            Count_Question--;
        }
        public string Question 
        { 
            get { return question[Current_Question]; }
            set { 
                if (Current_Question == Count_Question) 
                    question.Add(value);
                else 
                    question[Current_Question] = value; }
        }
        public string Answer_A 
        { 
            get { Right_Answer = answer[Current_Question][0]; return answer[Current_Question][0]; }
            set
            {
                if (Current_Question == Count_Question) 
                { 
                    answer.Add(new Answer()); 
                    answer[Current_Question][0] = value; 
                }
                else 
                    answer[Current_Question][0] = value;
            }
        }
        public string Answer_B 
        { 
            get { return answer[Current_Question][1]; }
            set { answer[Current_Question][1] = value; }
        }
        public string Answer_C 
        { 
            get { return answer[Current_Question][2]; }
            set { answer[Current_Question][2] = value; }
        }
        public string Answer_D 
        { 
            get { return answer[Current_Question][3]; }
            set { answer[Current_Question][3] = value; }
        }
        
        public void SaveQuestion()
        {
            string[] str = new string[5];
            str[0] = question[Count_Question];
            for (int i = 0; i < 4; i++)
                str[i+1] = answer[Count_Question][i];
            storage.SaveQuestion(str);
        }

        public void EditQuestion(string[] str)
        {
            storage.EditQuestion(str, this);
        }

        public Game(IStorage storage)
        {
            this.storage = storage;
            Random rnd = new Random();
            question = new List<string>();
            answer = new List<Answer>();
            if (Download() == 0)
                Current_Question = 0;
            else
            {
                Number_Question = 0;
                Current_Question = rnd.Next(0, Count_Question - 1);
            }
        }

        private int Download()
        {
            List<string> str = new List<string>(storage.Download());
            Count_Question = str.Count/5;
            for (int i = 0; i < str.Count; i+=5)
            {
                question.Add(str[i]);
                answer.Add(new Answer());
                for (int j = 0; j < 4; j++)
                    answer[question.Count-1][j] = str[i+j+1];
            }


                //Rewriting of data to DB from file
                //using (StreamReader sr = new StreamReader("..\\..\\Resources\\question.txt", Encoding.Default))
                //{
                //    int i = -1;
                //    do
                //    {
                //        i++;
                //        question.Add(sr.ReadLine());
                //        answer.Add(new Answer());
                //        for (int j = 0; j < 4; j++)
                //        {
                //            answer[i][j] = sr.ReadLine();
                //        }
                //    } while (question[i] != null);
                //    question.RemoveAt(i);
                //    answer.RemoveAt(i);
                //    Count_Question = i;
                //}


                //SqlConnection connect = new SqlConnection();
                //SqlCommand cmd = null;
                //SqlTransaction trans = null;
                //try
                //{
                //    connect.ConnectionString = @"Initial Catalog=Millionaire;Data Source=(local);Integrated Security=SSPI";
                //    connect.Open();
                //    trans = connect.BeginTransaction();
                //    cmd = connect.CreateCommand();

                //    cmd.Connection = connect;
                //    cmd.Transaction = trans;

                //    for (int i = 0; i < Count_Question; i++)
                //    {
                //        cmd.CommandText = "insert into Millionaire_table (question, answer1, answer2, answer3, answer4) values ('" + question[i] + "', '" + answer[i][0] + "', '" + answer[i][1] + "', '" + answer[i][2] + "', '" + answer[i][3] + "')";
                //        cmd.ExecuteNonQuery();
                //    }

                //    trans.Commit();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //    trans.Rollback();
                //}
                //finally
                //{
                //    cmd.Dispose();
                //    connect.Close();
                //}

                return Count_Question;
        }
        public bool IsAnswerRight()
        {
            return User_Answer == Right_Answer;
        }
    }
}
