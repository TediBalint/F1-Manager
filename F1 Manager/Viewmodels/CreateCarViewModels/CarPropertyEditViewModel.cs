using F1_Manager.EditCarPartClasses;
using F1_Manager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.Viewmodels.CreateCarViewModels
{
    public class CarPropertyEditViewModel : ViewModelBase
    {
		public List<PartProperty> PartProps { get;set; }
        public string Name;
        public double PointsLeft { get; set; }
        public double TimeToChange { get; set; }
        
        public ICommand BackCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand DoneCommand { get; set; }
        public CarPropertyEditViewModel(ISharedService sharedService, object CarPart) 
        {
            Name = CarPart.GetType().Name;
            PartProps = new List<PartProperty>();
            fillPartProps(CarPart);
        }
        private List<object> getProps(object obj)
        {
            List<object> props = new List<object>();
            foreach (PropertyInfo propInfo in obj.GetType().GetProperties())
            {  
                props.Add(propInfo.GetValue(obj));
            }
            return props;
        }
        private void fillPartProps(object CarPart)
        {
			foreach (object partClass in getProps(CarPart))
			{
				List<object> insideProps = getProps(partClass);
				for (int propIndex = 0; propIndex < insideProps.Count; propIndex++)
				{
					PartProperty partProperty = new PartProperty();
					partProperty.Val = (double)insideProps[propIndex];
					partProperty.Name = partClass.GetType().GetProperties()[propIndex].Name;
					PartProps.Add(partProperty);
				}
			}
		}
        
    }
}
