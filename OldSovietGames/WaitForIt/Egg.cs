using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Data;

namespace WaitForIt
{
    class Egg: Image 
    {
		public int position;
       

		public Egg()
		{
			// подключаем изображение
			Source = new BitmapImage( new Uri(@"img/egg_left_down_1.png", UriKind.RelativeOrAbsolute));

			AnimationLTT animationLTT;
			AnimationLTL animationLTL;

			Random random = new Random();
			position = random.Next(1, 5);
			

			switch (position)
			{
				case 1:
					// начальные координаты для левого верхнего положения
					Canvas.SetLeft(this, 225);
					Canvas.SetTop(this, 207);
					animationLTT = new AnimationLTT(this);
					animationLTT.Completed += Animation_Completed;
					this.BeginAnimation(Canvas.TopProperty, animationLTT);
					animationLTL = new AnimationLTL(this);
					this.BeginAnimation(Canvas.LeftProperty, animationLTL);
                    this.position = 1;
					break;

				case 2:
					// начальные координаты для левого нижнего положения
					Canvas.SetLeft(this, 225);
					Canvas.SetTop(this, 330);
                    animationLTT = new AnimationLTT(this);
					animationLTT.Completed += Animation_Completed;
					this.BeginAnimation(Canvas.TopProperty, animationLTT);
					animationLTL = new AnimationLTL(this);
					this.BeginAnimation(Canvas.LeftProperty, animationLTL);
                    this.position = 2;
					break;

				case 3:
					// начальные координаты для правого верхнего положения
					Canvas.SetLeft(this, 875);
					Canvas.SetTop(this, 205);
                    AnimationRT animationRT = new AnimationRT(this);
					animationRT.Completed += Animation_Completed;
                    this.BeginAnimation(Canvas.TopProperty, animationRT);
                    AnimationRL animationRL = new AnimationRL(this);
                    this.BeginAnimation(Canvas.LeftProperty, animationRL);
                    this.position = 3;
                    break;

				case 4:
					// начальные координаты для правого нижнего положения
					Canvas.SetLeft(this, 875);
					Canvas.SetTop(this, 327);
                    animationRT = new AnimationRT(this);
					animationRT.Completed += Animation_Completed;
					this.BeginAnimation(Canvas.TopProperty, animationRT);
                    animationRL = new AnimationRL(this);
                    this.BeginAnimation(Canvas.LeftProperty, animationRL);
                    this.position = 4;
                    break;

				default:
					Canvas.SetLeft(this, 225);
					Canvas.SetTop(this, 207);
					animationLTT = new AnimationLTT(this);
					this.BeginAnimation(Canvas.TopProperty, animationLTT);
					animationLTL = new AnimationLTL(this);
					this.BeginAnimation(Canvas.LeftProperty, animationLTL);
                    this.position = 1;
                    break;
			}
			 
			MainWindow.canvas2.Children.Add(this);
		}

		private void Animation_Completed(object sender, EventArgs e)
		{
			MainWindow.canvas2.Children.Remove(this);
            
            if (MainWindow.wolf_position == this.position)
            {
                MainWindow.score++;
                MainWindow.score_label.Content = MainWindow.score;
            }
            else
            {
               Crush.draw();
                
            }
            if(MainWindow.life == 0)
            {
                Canvas.SetLeft(MainWindow.score_label, 450);
                Canvas.SetTop(MainWindow.score_label, 100);
                MainWindow.score_label.Content = "game over!\nВаш счет - "+ MainWindow.score;
               
            }
		}

		public int GetPosition()
		{
			return position;
		}
    }
}
