﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IGameView
    {
        string Question { set; }
        string Answer_A { set; }
        string Answer_B { set; }
        string Answer_C {  set; }
        string Answer_D {  set; }
        string User_Answer { get; set; }
        string Right_Answer { get; set; }
        int Number_Question { get; set; }
        int Current_Question { get; set; }
        void GameOver(object sender);
        void NextQuestion();
        void TrueAnswer(object sender);
        void Win(int number_question);
        event EventHandler<EventArgs> Select_button;
        event EventHandler<EventArgs> Next_q;
    }
}
