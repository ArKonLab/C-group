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
        public Int32 t = 0;
        
        public GameParams(Canvas canvas, int timeKoef = 600)
        {
			Tick += timer_tick;
			Interval = new TimeSpan(100000 * timeKoef);
			Start();

			void timer_tick(object sender, EventArgs e)
			{
				Egg egg = new Egg(canvas);
			}
		}

		
    }
}
