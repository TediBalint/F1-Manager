using F1_Manager.Stores;
using F1_Manager.Viewmodels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace F1_Manager
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public ISharedService sharedService;
		
		protected override void OnStartup(StartupEventArgs e)
		{
			sharedService = new SharedService();
			NavigationStore navigationStore = new NavigationStore();
			//MainWindow = new MainWindow()
			navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
			MainWindow = new MainWindow()
			{
				DataContext = new MainViewModel(navigationStore)
			};
			MainWindow.Show();

			base.OnStartup(e);
		}
	}
}
