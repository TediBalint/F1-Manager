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
		// OnPropertyChanged

		private string _powerMessage;
		public	string PowerMessage
		{
			get => _powerMessage;
			set => SetProperty(ref _powerMessage, value);
		}
		private string _fuelMessage;
		public string FuelMessage
		{
			get => _fuelMessage;
			set => SetProperty(ref _fuelMessage, value);
		}
		private string _ersMessage;
		public string ErsMessage
		{
			get => _ersMessage;
			set => SetProperty(ref _ersMessage, value);
		}
		private string _weightMessage;
		public string WeightMessage
		{
			get => _weightMessage; 
			set => SetProperty(ref _weightMessage, value);
		}


		private double _iceMaxPercent;
		public double iceMaxPercent
		{
			get => _iceMaxPercent;
			set => SetProperty(ref _iceMaxPercent, value);
		}
		private double _mguhMaxPercent;
		public double mguhMaxPercent{
			get => _mguhMaxPercent;
			set => SetProperty(ref _mguhMaxPercent, value);
		}
		private double _mgukMaxPercent;
		public double mgukMaxPercent
		{
			get => _mguhMaxPercent; 
			set => SetProperty(ref _mgukMaxPercent, value);
		}
		private double _ceMaxPercent;
		public double ceMaxPercent
		{
			get => _ceMaxPercent;
			set => SetProperty(ref _ceMaxPercent, value);
		}
		private double _turboMaxPercent;
		public double turboMaxPercent
		{
			get => _turboMaxPercent;
			set => SetProperty(ref _turboMaxPercent, value);
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
			PowerMessage = $"{sharedService.createCarManager.thisEngine.GetPower()}/{sharedService.createCarManager.thisEngine.GetMaxPower()}";
			FuelMessage = $"{sharedService.createCarManager.thisEngine.GetConsumption()}/{sharedService.createCarManager.thisEngine.GetMinConsumption()}";
			ErsMessage = $"{sharedService.createCarManager.thisEngine.GetErsRecharge()}/{sharedService.createCarManager.thisEngine.GetMaxErsRecharge()}";
			WeightMessage = $"{sharedService.createCarManager.thisEngine.GetWeight()}/{sharedService.createCarManager.thisEngine.GetMinWeight()}";

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
