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
		public ICommand NavigateCarViewCommand { get; }
        public HomeViewModel(Stores.NavigationStore navigationStore)
        {
            NavigateCarViewCommand = new NavigateCarViewCommand(navigationStore);
        }
    }
}
