using Notatki.Views;
using System.Windows.Input;

namespace Notatki.ViewModels
{
    public class NotesListPageViewModel : BaseViewModel
    {
        public NotesListPageViewModel()
        {
            Notes = new List<string>
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
        }

        private List<string> _notes;
        public List<string> Notes
        {
            get => _notes;
            set => SetProperty(ref _notes, value);
        }

        private ICommand _addNoteTapCommand;
        public ICommand AddNoteTapCommand => _addNoteTapCommand ??= new AsyncDelegateCommand(OnAddNoteTapCommand);


        private Task OnAddNoteTapCommand()
        {
            return Shell.Current.GoToAsync(nameof(NotePage));
        }
    }
}
