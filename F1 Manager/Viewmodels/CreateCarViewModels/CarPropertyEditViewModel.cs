using F1_Manager.EditCarPartClasses;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Viewmodels.CreateCarViewModels
{
    public class CarPropertyEditViewModel : ViewModelBase
    {
		public List<PartProperty> PartProps { get;set; }
		
        public double PointsLeft { get; set; }
        public double TimeToChange { get; set; }
        
        public ICommand BackCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand DoneCommand { get; set; }
        public CarPropertyEditViewModel(ISharedService sharedService) 
        { 
            PartProps = new List<PartProperty>() {new PartProperty(), new PartProperty(), new PartProperty()};
        }
    }
}
