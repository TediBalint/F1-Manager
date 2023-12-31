﻿using F1_Manager.Stores;
using F1_Manager.Viewmodels;
using F1_Manager.Viewmodels.CreateCarViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Commands
{
	public class NavigateCommand<TViewModel>: CommandBase	
		where TViewModel : ViewModelBase
	{	
		private readonly ISharedService _sharedService;
		private readonly Func<TViewModel> _createViewModel;

		public NavigateCommand(ISharedService sharedService, Func<TViewModel> createViewModel)
		{
			_sharedService = sharedService;
			_createViewModel = createViewModel;
		}
		public override void Execute(object parameter)
		{
			_sharedService.navigationStore.CurrentViewModel = _createViewModel();
		}
	}
}
