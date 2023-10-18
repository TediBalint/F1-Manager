using F1_Manager.Commands;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
    public class PlayViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Play";
        public ICommand NavigatePlayCommand { get; }

        public PlayViewModel(NavigationStore navigationStore)
        {
            NavigatePlayCommand = new NavigateCommand<PlayViewModel>(navigationStore, () => new PlayViewModel(navigationStore));
        }
    }
}
