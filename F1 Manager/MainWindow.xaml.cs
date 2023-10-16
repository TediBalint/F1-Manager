using System.Diagnostics;
using System.Windows;

namespace F1_Manager
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			onLoad();
		}
		private void onLoad()
		{
			this.WindowState = WindowState.Maximized;
			this.WindowStyle = WindowStyle.None;
			this.AllowsTransparency = true;
		}

	}
}
