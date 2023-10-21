using F1_Manager.Commands;
using F1_Manager.Stores;
using F1_Manager.Viewmodels.CreateCarViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
	public class ChooseTrackViewModel : ViewModelBase
	{
		//private string imagePath = "..\\..\\..";
		public string currentTrack { get; set; }
		public ICommand NavigateHomeCommand { get; }
		public ICommand NavigateEngineCommand { get; }

		public ChooseTrackViewModel(NavigationStore navigationStore)
		{
			currentTrack = (AppDomain.CurrentDomain.BaseDirectory);
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
			NavigateEngineCommand = new NavigateCommand<CreateEngineViewModel>(navigationStore, () => new CreateEngineViewModel(navigationStore));
		}
	}
}
