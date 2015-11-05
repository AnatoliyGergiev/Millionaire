using System;
using System.Collections.Generic;
using System.Linq;
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
                _gameview.NextQuestion();
            else
                _gameview.GameOver();

            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            
            //UpdateView();
        }

        private void Next_Question(object sender, EventArgs e)
        {
            if (_gameview.Number_Question == 14)
                _gameview.GameOver();
            else
            {
                _gameview.Number_Question++;
                _game.Number_Question = _gameview.Number_Question;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            _gameview.Question = _game.Question;
            _gameview.Answer_A = _game.Answer_A;
            _gameview.Answer_B = _game.Answer_B;
            _gameview.Answer_C = _game.Answer_C;
            _gameview.Answer_D = _game.Answer_D;
            _gameview.Right_Answer = _game.Answer_A;
        }
    }
}


