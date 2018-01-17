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
		static public GameParams gParamsA;
		static public Canvas canvas2 = new Canvas();
        static public Canvas canvas3 = new Canvas();
        static public Label score_label = new Label();
        static public int x = 710;
        static public int wolf_position = 1;
        static public int score = 0;
        static public int life = 3;

        
        public MainWindow()
        {
            InitializeComponent();
            canvas.Children.Add(canvas2);
            canvas.Children.Add(canvas3);
            canvas.Children.Add(score_label);
            start_setup();

        }
        private static void start_setup()
        {
            score_label.FontSize = 36;
            score_label.FontWeight = FontWeights.Bold;
            Canvas.SetLeft(score_label, 630);
            Canvas.SetTop(score_label, 140);
            Woolf.wolf_add(226, 339, @"img/wolf_left_top.png", 345, 209);
        }


        private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void BtnPlayA_Click(object sender, RoutedEventArgs e)
		{
			gParamsA = new GameParams(150);
			gParamsA.Start();
            score_label.Content = score;
            #region GameA
            //Задаем параметры игры А


            #endregion
        }

        private void BtnPlayB_Click(object sender, RoutedEventArgs e)
		{
			//Egg.storyboard.Pause();
        }

        private void BtnSound_Click(object sender, RoutedEventArgs e)
		{
            sound.SwitchSoundOnOff();
		}

        private void btnLeftTop_Click(object sender, RoutedEventArgs e)
        {
          
            Woolf.woolfImage(1);
           
        }

        private void btnLeftDown_Click(object sender, RoutedEventArgs e)
        {
            
            Woolf.woolfImage(2);
           
        }

        private void btnRightTop_Click(object sender, RoutedEventArgs e)
        {
           
            Woolf.woolfImage(3);
           

        }

        private void btnRightDown_Click(object sender, RoutedEventArgs e)
        {
            
            Woolf.woolfImage(4);
            
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                
                case Key.Q: Woolf.woolfImage(1); break;
                case Key.A: Woolf.woolfImage(2); break;
				case Key.P: Woolf.woolfImage(3); break;
				case Key.L: Woolf.woolfImage(4); break;
                default:
                    break;
            }
           
        }

        
    }
}