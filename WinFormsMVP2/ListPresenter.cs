using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP2
{
    public class ListPresent
    {
        private readonly IModel _model;
        private readonly IListView _view;

        // Принцип инверсии зависимостей
        public ListPresent(IModel model, IListView view)
        {
            _model = model;
            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.AddRemove += new EventHandler<EventArgs>(AddBook);
            _view.AddRemove += new EventHandler<EventArgs>(RemoveBook);

            UpdateView();
        }

        private void AddBook(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _model.BookName = _view.BookName;
            _model.Author = _view.Author;
            _model.Genr = _view.Genr;
            _model.Year = _view.Year;
            _model.Data = _view.Data;

            _model.Save();
            

            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }
        private void RemoveBook(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _model.BookName = _view.BookName;
            _model.Author = _view.Author;
            _model.Genr = _view.Genr;
            _model.Year = _view.Year;
            _model.Data = _view.Data;

            _model.Delete();


            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }

        private void UpdateView()
        {
            _view.BookName = _model.BookName;
            _view.Author = _model.Author;
            _view.Genr = _model.Genr;
            _view.Year = _model.Year;
            _view.Data = _model.Load();
        }
    }
}
