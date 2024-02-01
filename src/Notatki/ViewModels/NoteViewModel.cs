using System.Windows.Input;

namespace Notatki.ViewModels
{
    public class NoteViewModel : BaseViewModel
    {
        private ICommand _saveNoteTapCommand;
        public ICommand SaveNoteTapCommand => _saveNoteTapCommand ??= new AsyncDelegateCommand(OnSaveNoteTapCommand);

        private Task OnSaveNoteTapCommand()
        {
            return Shell.Current.GoToAsync("..");
        }
    }
}
