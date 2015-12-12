using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class AddPresenter
    {
        private readonly Game _game = new Game(new DBStorage());
        private readonly IAddView _addview;
        public AddPresenter(IAddView addview)
        {
            _addview = addview;
            // Презентер подписывается на уведомления о событиях Представления
            _addview.Add += new EventHandler<EventArgs>(OnAdd);
        }

        private void OnAdd(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _game.Current_Question = _game.Count_Question;
            _game.Question = _addview.Question;
            _game.Answer_A = _addview.Answer_A;
            _game.Answer_B = _addview.Answer_B;
            _game.Answer_C = _addview.Answer_C;
            _game.Answer_D = _addview.Answer_D;
            _game.SaveQuestion();
        }

        private void UpdateView()
        {
            _addview.Question = _game.Question;
            _addview.Answer_A = _game.Answer_A;
            _addview.Answer_B = _game.Answer_B;
            _addview.Answer_C = _game.Answer_C;
            _addview.Answer_D = _game.Answer_D;
        }
    }
}
