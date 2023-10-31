using F1_Manager.Car.EngineModules;
using F1_Manager.Commands;
using F1_Manager.Managers;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace F1_Manager.Viewmodels.CreateCarViewModels
{
	public class CreateEngineViewModel : ViewModelBase
	{
		public string PowerMessage { get; set; }
		public string FuelMessage { get; set; }
		public string ErsMessage { get; set; }
		public string WeightMessage { get; set; }

		private double _iceMaxPercent;
		public double iceMaxPercent
		{
			get { return _iceMaxPercent; }
			set
			{
				if (_iceMaxPercent != value)
				{
					_iceMaxPercent = value;
					OnPropertyChanged(nameof(iceMaxPercent));
				}
			}
		}
		//private string _currentTrackPath;
		//public string CurrentTrackPath
		//{
		//	get { return _currentTrackPath; }
		//	set
		//	{
		//		if (_currentTrackPath != value)
		//		{
		//			_currentTrackPath = value;
		//			OnPropertyChanged(nameof(CurrentTrackPath));
		//		}
		//	}
		//}
		public ICommand NavigateBackCommand { get; }

		public ICommand NavigateIceCommand { get; }
		public ICommand NavigateMGUHCommand { get; }
		public ICommand NavigateMGUKCommand { get; }
		public ICommand NavigateCECommand { get; }
		public ICommand NavigateTurboCommand { get; }

		public CreateEngineViewModel(ISharedService sharedService)
		{
			// may need onpropertyChanged for these
			double power = sharedService.createCarManager.thisEngine.GetPower();
			double maxPower = sharedService.createCarManager.thisEngine.GetMaxPower();

			double ersRecharge = sharedService.createCarManager.thisEngine.GetErsRecharge();
			double maxErsRecharge = sharedService.createCarManager.thisEngine.GetMaxErsRecharge();

			double fuelCons = sharedService.createCarManager.thisEngine.GetConsumption();
			double minFuelCons = sharedService.createCarManager.thisEngine.GetMinConsumption();

			double weight = sharedService.createCarManager.thisEngine.GetWeight();
			double minWeight = sharedService.createCarManager.thisEngine.GetMinWeight();

			PowerMessage = $"{power}/{maxPower}";
			FuelMessage = $"{fuelCons}/{minFuelCons}";
			ErsMessage = $"{ersRecharge}/{maxErsRecharge}";
			WeightMessage = $"{weight}/{minWeight}";

			// Commands
			NavigateBackCommand = new NavigateCommand<CreateCarViewModel>(sharedService, () => new CreateCarViewModel(sharedService));

			NavigateIceCommand = new NavigateCommand<CarPropertyEditViewModel>(sharedService, () => new CarPropertyEditViewModel(sharedService, sharedService.createCarManager.thisEngine.ice));
			NavigateMGUHCommand = new NavigateCommand<CarPropertyEditViewModel>(sharedService, () => new CarPropertyEditViewModel(sharedService, sharedService.createCarManager.thisEngine.mguh));
			NavigateMGUKCommand = new NavigateCommand<CarPropertyEditViewModel>(sharedService, () => new CarPropertyEditViewModel(sharedService, sharedService.createCarManager.thisEngine.mguk));
			NavigateCECommand = new NavigateCommand<CarPropertyEditViewModel>(sharedService, () => new CarPropertyEditViewModel(sharedService, sharedService.createCarManager.thisEngine.controlElectronics));
			NavigateTurboCommand = new NavigateCommand<CarPropertyEditViewModel>(sharedService, () => new CarPropertyEditViewModel(sharedService, sharedService.createCarManager.thisEngine.turbo));
		}
		
	}
}
