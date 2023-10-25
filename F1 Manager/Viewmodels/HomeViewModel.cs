using F1_Manager.Commands;
using F1_Manager.Stores;
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

		public HomeViewModel(ISharedService sharedService)
        {
            NavigateCarCommand = new NavigateCommand<CarViewModel>(sharedService, () => new CarViewModel(sharedService));
            NavigatePlayCommand = new NavigateCommand<StartViewModel>(sharedService, () => new StartViewModel(sharedService));
            NavigateCreateCarCommand = new NavigateCommand<CreateCarViewModel>(sharedService, () => new CreateCarViewModel(sharedService));
			NavigateChooseTrackCommand = new NavigateCommand<ChooseTrackViewModel>(sharedService, () => new ChooseTrackViewModel(sharedService));
		}
    }
}
