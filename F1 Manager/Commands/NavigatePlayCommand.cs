using F1_Manager.Stores;
using F1_Manager.Viewmodels;
using F1_Manager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Commands
{
	public class NavigatePlayCommand: CommandBase
	{
		private readonly NavigationStore _navigatedStore;

		public NavigatePlayCommand(NavigationStore navigatedStore)
		{
			_navigatedStore = navigatedStore;
		}
		public override void Execute(object parameter)
		{
			_navigatedStore.CurrentViewModel = new PlayViewModel(_navigatedStore);
		}
	}
}
