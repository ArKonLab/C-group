using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WaitForIt
{
    class GameParams: DispatcherTimer
    {
		public GameParams(int timeKoef = 400)
		{
			// Первое яйцо создается сразу, без ожидания первого тика
			Egg egg = new Egg();

			Tick += timer_tick; // Подключаем к событию обработчик
			Interval = new TimeSpan(100000 * timeKoef); // задаем интервал таймера
		}

		// Обработчик события Tick таймера
		void timer_tick(object sender, EventArgs e)
		{
			Egg egg = new Egg();
		}
	}
}
