using F1_Manager.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace F1_Manager.EditCarPartClasses
{
    public class PartProperty:INotifyPropertyChanged
    {
        public string Name { get; set; }
		private double val;
		public double Val
		{
			get { return val; }
			set
			{
				if (val != value)
				{
					val = value;
					RaisePropertyChanged("Val");
				}
			}
		}
        public ICommand increase { get; }
        public ICommand decrease { get; }
        public PartProperty() 
        {
            increase = new RelayCommand(Inc);
			decrease = new RelayCommand(Dec);
			Name = "PropertyName";
		}
		private void Inc()
		{
            Val ++;
		}
		private void Dec()
		{
            Val --;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void RaisePropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
    
}
