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
    public class StartViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Play";
        public ICommand NavigatePlayCommand { get; }

        public StartViewModel(NavigationStore navigationStore)
        {
            NavigatePlayCommand = new NavigateCommand<StartViewModel>(navigationStore, () => new StartViewModel(navigationStore));
        }
    }
}
