using F1_Manager.Commands;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Viewmodels
{
    public class StartViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public StartViewModel(ISharedService sharedService)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(sharedService, () => new HomeViewModel(sharedService));
        }
    }
}
