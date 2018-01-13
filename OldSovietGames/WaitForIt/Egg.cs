using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WaitForIt
{
    class Egg: Image
    {
		public Egg()
		{
			// подключаем изображение
			Source = new BitmapImage( new Uri(@"img/egg_left_down_1.png", UriKind.RelativeOrAbsolute));
			// начальные координаты для левого верхнего положения
			Canvas.SetLeft(this, 195);
			Canvas.SetTop(this, 205);
		}
    }
}
