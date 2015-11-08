using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class EditPresenter
    {
        private readonly Game _game = new Game();
        private readonly IEditView _editview;
        public EditPresenter(IEditView editview)
        {
            _editview = editview;
            // Презентер подписывается на уведомления о событиях Представления
            _editview.Edit += new EventHandler<EventArgs>(OnEdit);
            _editview.Update_v += new EventHandler<EventArgs>(UpdateView);
            _game.Current_Question = 0;
            _editview.MaxQuestions = _game.Count_Question-1;
            UpdateView();
        }

        private void OnEdit(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _game.Question = _editview.Question;
            _game.Answer_A = _editview.Answer_A;
            _game.Answer_B = _editview.Answer_B;
            _game.Answer_C = _editview.Answer_C;
            _game.Answer_D = _editview.Answer_D;
            _game.SaveQuestions();
        }

        private void UpdateView()
        {
            _editview.Question = _game.Question;
            _editview.Answer_A = _game.Answer_A;
            _editview.Answer_B = _game.Answer_B;
            _editview.Answer_C = _game.Answer_C;
            _editview.Answer_D = _game.Answer_D;
            _game.Current_Question = _editview.Current_Question;
        }
        private void UpdateView(object sender, EventArgs e)
        {
            _editview.Question = _game.Question;
            _editview.Answer_A = _game.Answer_A;
            _editview.Answer_B = _game.Answer_B;
            _editview.Answer_C = _game.Answer_C;
            _editview.Answer_D = _game.Answer_D;
            _game.Current_Question = _editview.Current_Question;

        }
    }
}
