using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WaitForIt
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        SoundModule sound = new SoundModule();
        
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void BtnPlayA_Click(object sender, RoutedEventArgs e)
		{
		}

		private void BtnPlayB_Click(object sender, RoutedEventArgs e)
		{
		}

		private void BtnSound_Click(object sender, RoutedEventArgs e)
		{
            sound.SwitchSoundOnOff();
		}
	}
}