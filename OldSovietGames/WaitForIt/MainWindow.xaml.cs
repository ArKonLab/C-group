using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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
        Int32 t = 0;
        DispatcherTimer timer = new DispatcherTimer();
        

        public MainWindow()
		{
			InitializeComponent();
            
        }

        private void timer_tick(object sender, EventArgs e)
        {
            #region Tick                            
            //Внутрь регулярного выражения нужно внести что мы должны выполнить при каждом тике: 
            //обновить картинку, обновить положения яиц, сменить позицию руки волка
            t += 1;
            Label1.Content = t.ToString();                      //Выводим переменную t, Которая инкрементируется с каждым периодом таймера




            #endregion
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void BtnPlayA_Click(object sender, RoutedEventArgs e)   //Игра A
		{
            Timer(100);                                        //инициализируем и запускаем таймер
            #region GameA
            //Задаем параметры игры А


            #endregion
        }
        
		private void BtnPlayB_Click(object sender, RoutedEventArgs e)   //Игра B
		{
            Timer(100);                                        //инициализируем и запускаем таймер
            #region GameB
            //Задаем параметры игры B


            #endregion
        }
        private void Timer(int timeKoef)                                //Метод в котором запускаем таймер
        {
            
            timer.Tick += new EventHandler(timer_tick);     //С каждым периодом таймера у нас запускается приватный метод timer_tick
            timer.Interval = new TimeSpan(100000*timeKoef); //Задали интервал таймера 10 000 000 тиков, что соотвнетствует 1 секунде
            timer.Start();                                  //Запуск таймера. Чтобы увеличить частоту обновлений нужно уменьшить период тиков
                                                            //timerKoef
        }                       

		private void BtnSound_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}