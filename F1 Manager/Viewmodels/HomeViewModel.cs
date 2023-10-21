using F1_Manager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
	public class HomeViewModel : ViewModelBase
	{
		public string welcomeMessage => "Welcome to my applciation";
		public ICommand NavigateCarCommand { get; }
        public ICommand NavigatePlayCommand { get; }
		public ICommand NavigateCreateCarCommand { get; }
		public ICommand NavigateChooseTrackCommand { get; }

		public HomeViewModel(Stores.NavigationStore navigationStore)
        {
            NavigateCarCommand = new NavigateCommand<CarViewModel>(navigationStore, () => new CarViewModel(navigationStore));
            NavigatePlayCommand = new NavigateCommand<PlayViewModel>(navigationStore, () => new PlayViewModel(navigationStore));
            NavigateCreateCarCommand = new NavigateCommand<CreateCarViewModel>(navigationStore, () => new CreateCarViewModel(navigationStore));
			NavigateChooseTrackCommand = new NavigateCommand<ChooseTrackViewModel>(navigationStore, () => new ChooseTrackViewModel(navigationStore));
		}
    }
}
