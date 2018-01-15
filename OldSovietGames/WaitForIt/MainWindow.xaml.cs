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
		static public int time = 1;
		static public Canvas canvas2 = new Canvas();
        
		public MainWindow()
		{
			InitializeComponent();
			canvas.Children.Add(canvas2);
		}

		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void BtnPlayA_Click(object sender, RoutedEventArgs e)
		{
            GameParams gParamsA = new GameParams();
			gParamsA.Start();
            #region GameA
            //Задаем параметры игры А


            #endregion
        }

        private void BtnPlayB_Click(object sender, RoutedEventArgs e)
		{

        }

        private void BtnSound_Click(object sender, RoutedEventArgs e)
		{
            sound.SwitchSoundOnOff();
		}

        private void btnLeftTop_Click(object sender, RoutedEventArgs e)
        {
            Woolf.woolfImage(1);
            wolf_ld.Visibility = Visibility.Collapsed;
            wolf_lt.Visibility = Visibility.Visible;
            wolf_rd.Visibility = Visibility.Collapsed;
            wolf_rt.Visibility = Visibility.Collapsed;
            
        }

        private void btnLeftDown_Click(object sender, RoutedEventArgs e)
        {
            Woolf.woolfImage(2);
            wolf_ld.Visibility = Visibility.Visible;
            wolf_lt.Visibility = Visibility.Collapsed;
            wolf_rd.Visibility = Visibility.Collapsed;
            wolf_rt.Visibility = Visibility.Collapsed;
        }

        private void btnRightTop_Click(object sender, RoutedEventArgs e)
        {
            Woolf.woolfImage(3);
            wolf_ld.Visibility = Visibility.Collapsed;
            wolf_lt.Visibility = Visibility.Collapsed;
            wolf_rd.Visibility = Visibility.Collapsed;
            wolf_rt.Visibility = Visibility.Visible;
        }

        private void btnRightDown_Click(object sender, RoutedEventArgs e)
        {
            Woolf.woolfImage(4);
            wolf_ld.Visibility = Visibility.Collapsed;
            wolf_lt.Visibility = Visibility.Collapsed;
            wolf_rd.Visibility = Visibility.Visible;
            wolf_rt.Visibility = Visibility.Collapsed;
        }
    }
}