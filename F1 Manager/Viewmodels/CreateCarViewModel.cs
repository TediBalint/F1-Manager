using F1_Manager.Commands;
using F1_Manager.Stores;
using F1_Manager.Views.CreateCarViews;
using F1_Manager.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using F1_Manager.Viewmodels.CreateCarViewModels;

namespace F1_Manager.Viewmodels
{
	public class CreateCarViewModel : ViewModelBase
	{
		public ICommand NavigateHomeCommand { get; }
		public ICommand NavigateEngineCommand { get; }
		public ICommand NavigatePlayCommand { get; }

		public CreateCarViewModel(ISharedService sharedService)
		{
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(sharedService, () => new HomeViewModel(sharedService));
			NavigateEngineCommand = new NavigateCommand<CreateEngineViewModel>(sharedService, () => new CreateEngineViewModel(sharedService));
			NavigatePlayCommand = new NavigateCommand<StartViewModel>(sharedService, () => new StartViewModel(sharedService));
		}
	}
}
