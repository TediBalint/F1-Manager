using F1_Manager.Commands;
using F1_Manager.Images.TrackImages;
using F1_Manager.Managers;
using F1_Manager.Stores;
using F1_Manager.Viewmodels.CreateCarViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
	public class ChooseTrackViewModel : ViewModelBase
	{
		//private string imagePath = "..\\..\\..";


		// OnpropertyChanged
		private string _currentTrackPath;
		public string CurrentTrackPath
		{
			get { return _currentTrackPath; }
			set
			{
				if (_currentTrackPath != value)
				{
					_currentTrackPath = value;
					OnPropertyChanged(nameof(CurrentTrackPath));
				}
			}
		}

		private string _currentTrackName;
		public string CurrentTrackName
		{
			get { return _currentTrackName; }
			set
			{
				if (_currentTrackName != value)
				{
					_currentTrackName = value;
					OnPropertyChanged(nameof(CurrentTrackName));
				}
			}
		}
		private readonly TrackManager _trackManager;
		private TrackImage currentTrack;
		public ICommand NavigateHomeCommand { get; }
		public ICommand NavigateCreateCarCommand { get; }
		public ICommand navNext { get; }
		public ICommand navPrevious { get; }
		public ChooseTrackViewModel(ISharedService sharedService)
		{
			_trackManager = sharedService.trackManager;
			currentTrack = _trackManager.currentTrack;
			updateCurrentTrack();

			// Command declaration
			navPrevious = new RelayCommand(navPreviousTrack);
			navNext = new RelayCommand(navNextTrack);
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(sharedService, () => new HomeViewModel(sharedService));
			NavigateCreateCarCommand = new NavigateCommand<CreateCarViewModel>(sharedService, () => new CreateCarViewModel(sharedService));
		}
		private void updateCurrentTrack()
		{
			CurrentTrackPath = currentTrack.ImageRelativePath;
			CurrentTrackName = currentTrack.TrackName;
		}
		public void navNextTrack()
		{
			currentTrack = _trackManager.getNextTrack();
			updateCurrentTrack();
		}
		public void navPreviousTrack()
		{
			currentTrack = _trackManager.getPreviousTrack();
			updateCurrentTrack();
		}
	}
}
