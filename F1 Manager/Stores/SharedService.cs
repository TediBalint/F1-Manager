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
		string SharedProperty { get; set; }
		void SharedMethod();

	}

	public class SharedService : ISharedService
	{
		public string SharedProperty { get; set; }
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
