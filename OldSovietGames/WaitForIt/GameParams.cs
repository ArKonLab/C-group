using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WaitForIt
{
    class GameParams
    {
        public Int32 t = 0;
        DispatcherTimer timer = new DispatcherTimer();
        
        public GameParams()                                     //Пустой конструктор можно задать параметры игры А или игры В
        {

        }
        public void Timer(int timeKoef=100)                     //Метод в котором запускаем таймер. по умолчанию timeKoef = 100
        {

            timer.Tick += new EventHandler(timer_tick);         //С каждым периодом таймера у нас запускается приватный метод timer_tick
            timer.Interval = new TimeSpan(100000 * timeKoef);   //Задали интервал таймера 10 000 000 тиков, что соответствует 1 секунде
            timer.Start();                                      //Запуск таймера. Чтобы увеличить частоту обновлений нужно уменьшить период тиков
                                                                //timerKoef можно менять, если его уменьшать то будет уменьшаться период и расти частота обновления
        }
        private void timer_tick(object sender, EventArgs e)     //С каждым периодом выполняется содержимое данного метода
        {
            #region Tick                            
            //Внутрь регулярного выражения нужно внести что мы должны выполнить при каждом тике: 
            //обновить картинку, обновить положения яиц, сменить позицию руки волка
            t += 1;
            



            #endregion
        }
    }
}
