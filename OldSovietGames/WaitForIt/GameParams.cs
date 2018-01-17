using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WaitForIt
{
    public class GameParams: DispatcherTimer
    {
		private static List<Egg> list = new List<Egg>();
		public GameParams(int timeKoef = 400)
		{
			// Первое яйцо создается сразу, без ожидания первого тика
			Egg egg = new Egg();
			List.Add(egg);

			Tick += timer_tick; // Подключаем к событию обработчик
			Interval = new TimeSpan(100000 * timeKoef); // задаем интервал таймера
		}

		internal static List<Egg> List { get => list; set => list = value; }

		// Обработчик события Tick таймера
		void timer_tick(object sender, EventArgs e)
		{
			Egg egg = new Egg();
			List.Add(egg);
		}
	}
}
