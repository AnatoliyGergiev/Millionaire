using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class Presenter
    {
        private readonly Game _game = new Game();
        private readonly IGameView _gameview;
        public Presenter(IGameView gameview)
        {
            _gameview = gameview;
            // Презентер подписывается на уведомления о событиях Представления
            _gameview.Select_button += new EventHandler<EventArgs>(OnSelect);
            _gameview.Next_q += new EventHandler<EventArgs>(Next_Question);
            UpdateView();
        }

        private void OnSelect(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _game.User_Answer = _gameview.User_Answer;
            _game.Right_Answer = _gameview.Right_Answer;
            if (_game.IsAnswerRight())
            {
                _gameview.TrueAnswer(sender);
                //_gameview.NextQuestion();
            }
            else
            {
                SoundPlayer player = new SoundPlayer("../../resources/sound/false.wav");
                player.Play();
                _gameview.GameOver(sender);
            }

            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            
            //UpdateView();
        }

        private void Next_Question(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (_gameview.Number_Question == 14)
                _gameview.Win();
            else
            {
                _gameview.Number_Question++;
                _game.Number_Question = _gameview.Number_Question;
                _gameview.Current_Question = rnd.Next(0,_game.Count_Question-1);
                _game.Current_Question = _gameview.Current_Question;
                _game.Remove_Question(_game.Current_Question);
                UpdateView();
            }
        }

        private void UpdateView()
        {
            _gameview.Question = _game.Question;
            Random rnd = new Random();
            List<string> ans = new List<string>();
            ans.Add(_game.Answer_A);
            ans.Add(_game.Answer_B);
            ans.Add(_game.Answer_C);
            ans.Add(_game.Answer_D );
            int i=rnd.Next(0, 3);
            _gameview.Answer_A = ans[i];
            ans.RemoveAt(i);
            i = rnd.Next(0, 2);
            _gameview.Answer_B = ans[i];
            ans.RemoveAt(i);
            i = rnd.Next(0, 1);
            _gameview.Answer_C = ans[i];
            ans.RemoveAt(i);
            _gameview.Answer_D = ans[0];
            _gameview.Right_Answer = _game.Right_Answer;
        }
    }
}


