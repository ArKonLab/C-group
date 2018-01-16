﻿using System;
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
        static public Canvas canvas3 = new Canvas();

        public MainWindow()
        {
            InitializeComponent();
            canvas.Children.Add(canvas2);
            canvas.Children.Add(canvas3);
            Woolf wolf = new Woolf();
			wolf.wolf_add(226, 339, @"img/wolf_left_top.png", 345, 209);
           

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
            Woolf wolf = new Woolf();
            wolf.woolfImage(1);
           
            
        }

        private void btnLeftDown_Click(object sender, RoutedEventArgs e)
        {
            Woolf wolf = new Woolf();
            wolf.woolfImage(2);

        }

        private void btnRightTop_Click(object sender, RoutedEventArgs e)
        {
            Woolf wolf = new Woolf();
            wolf.woolfImage(3);

        }

        private void btnRightDown_Click(object sender, RoutedEventArgs e)
        {
            Woolf wolf = new Woolf();
            wolf.woolfImage(4);

        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Woolf wolf = new Woolf();
            switch (e.Key)
            {
                case Key.D: wolf.woolfImage(3); break;
                case Key.A: wolf.woolfImage(1); break;
                case Key.W: wolf.woolfImage(2); break;
                case Key.S: wolf.woolfImage(4); break;
                case Key.R: wolf.woolfImage(1); break;
                case Key.F: wolf.woolfImage(2); break;
                case Key.O: wolf.woolfImage(3); break;
                case Key.K: wolf.woolfImage(4); break;
                default:
                    break;
            }
        }
    }
}