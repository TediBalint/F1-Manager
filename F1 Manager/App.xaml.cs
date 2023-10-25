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
			sharedService.navigationStore = new NavigationStore();
			sharedService.navigationStore.CurrentViewModel = new HomeViewModel(sharedService);
			//MainWindow = new MainWindow()
			MainWindow = new MainWindow()
			{
				DataContext = new MainViewModel(sharedService)
			};
			MainWindow.Show();
			base.OnStartup(e);
		}
	}
}
