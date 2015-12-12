using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class DeletePresenter
    {
        private readonly Game _game = new Game(new DBStorage());
        private readonly IDeleteView _deleteview;
        public DeletePresenter(IDeleteView deleteview)
        {
            _deleteview = deleteview;
            // Презентер подписывается на уведомления о событиях Представления
            _deleteview.Delete_q += new EventHandler<EventArgs>(OnDelete);
            _deleteview.Update_v += new EventHandler<EventArgs>(UpdateView);
            _game.Current_Question = 0;
            _deleteview.MaxQuestions = _game.Count_Question-1;
            UpdateView(this, null);
        }

        private void OnDelete(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _game.Remove_Question(_game.Current_Question);
            _game.Question = _deleteview.Question;
            //_game.SaveQuestions();
        }

        private void UpdateView(object sender, EventArgs e)
        {
            _game.Current_Question = _deleteview.Current_Question;
            _deleteview.Question = _game.Question;
        }
    }
}
