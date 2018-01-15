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
		private int position;

		public Egg()
		{
			// подключаем изображение
			Source = new BitmapImage( new Uri(@"img/egg_left_down_1.png", UriKind.RelativeOrAbsolute));

			Random random = new Random();
			//position = random.Next(1, 5);
			position = random.Next(1, 3);

			switch (position)
			{
				case 1:
					// начальные координаты для левого верхнего положения
					Canvas.SetLeft(this, 225);
					Canvas.SetTop(this, 207);
					AnimationLTT animationLTT = new AnimationLTT(this);
					this.BeginAnimation(Canvas.TopProperty, animationLTT);
					AnimationLTL animationLTL = new AnimationLTL(this);
					this.BeginAnimation(Canvas.LeftProperty, animationLTL);
					break;

				case 2:
					// начальные координаты для левого нижнего положения
					Canvas.SetLeft(this, 225);
					Canvas.SetTop(this, 330);
                    animationLTT = new AnimationLTT(this);
					this.BeginAnimation(Canvas.TopProperty, animationLTT);
					animationLTL = new AnimationLTL(this);
					this.BeginAnimation(Canvas.LeftProperty, animationLTL);
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
			 
			MainWindow.canvas2.Children.Add(this);
		}

		public int GetPosition()
		{
			return position;
		}
    }
}
