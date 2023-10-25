using F1_Manager.Images.TrackImages;
using F1_Manager.Managers;
using F1_Manager.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Stores
{
	public interface ISharedService
	{
		NavigationStore navigationStore { get; set; }
		TrackManager trackManager { get; set; }
		void SharedMethod();

	}
	public class SharedService : ISharedService
	{
		
		public TrackManager trackManager { get; set; } = new TrackManager();
		public NavigationStore navigationStore { get; set; }
		public SharedService()
		{
			NavigationStore navigationStore = new NavigationStore();
			navigationStore.CurrentViewModel = new HomeViewModel(this);
		}

		public void SharedMethod()
		{
			// Your shared functionality
		}
	}
}
