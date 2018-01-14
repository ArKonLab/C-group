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
		public Egg(Canvas canvas, int position)
		{
			// подключаем изображение
			Source = new BitmapImage( new Uri(@"img/egg_left_down_1.png", UriKind.RelativeOrAbsolute));

			switch (position)
			{
				case 1:
					// начальные координаты для левого верхнего положения
					Canvas.SetLeft(this, 195);
					Canvas.SetTop(this, 205);
					break;

				case 2:
					// начальные координаты для левого нижнего положения
					Canvas.SetLeft(this, 195);
					Canvas.SetTop(this, 327);
					break;

				case 3:
					// начальные координаты для правого верхнего положения
					Canvas.SetLeft(this, 896);
					Canvas.SetTop(this, 205);
					break;

				case 4:
					// начальные координаты для правого нижнего положения
					Canvas.SetLeft(this, 896);
					Canvas.SetTop(this, 327);
					break;

				default:
					break;
			}
			 
			canvas.Children.Add(this);
		}
    }
}
