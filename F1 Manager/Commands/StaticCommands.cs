using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Commands
{
	public class StaticCommands
	{
		private static void Quit()
		{
			App.Current.Shutdown();
		}
		public static ICommand QuitCommand()
		{
			return new RelayCommand(Quit);
		}
	}
}
