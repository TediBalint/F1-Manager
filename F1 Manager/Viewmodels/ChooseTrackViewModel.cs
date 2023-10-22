﻿using F1_Manager.Commands;
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
		public TrackImage currentTrack;

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
		//public TrackManager trackManager { get; set; }
		private TrackManager _trackManager;

		public ICommand NavigateHomeCommand { get; }
		public ICommand NavigateEngineCommand { get; }
		public ICommand navNext { get; private set; }
		public ICommand navPrevious { get; private set; }


		public ChooseTrackViewModel(NavigationStore navigationStore)
		{
			_trackManager = new TrackManager();
			currentTrack = _trackManager.currentTrack;
			updateCurrentTrack();
			// Command declaration

			navPrevious = new RelayCommand(navPreviousTrack);
			navNext = new RelayCommand(navNextTrack);
			NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
			NavigateEngineCommand = new NavigateCommand<CreateEngineViewModel>(navigationStore, () => new CreateEngineViewModel(navigationStore));
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
