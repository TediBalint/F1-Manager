using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Stores
{
	public interface ISharedService
	{
		string SharedProperty { get; set; }
		void SharedMethod();
	}

	public class SharedService : ISharedService
	{
		public string SharedProperty { get; set; }

		public void SharedMethod()
		{
			// Your shared functionality
		}
	}
}
