using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;


namespace WaitForIt
{
    class Woolf
    {
        public int position;
        public Woolf() { }
       
        static public void wolf_add(int width, int height, string sourse, int left, int top)
        {
            Image wolf = new Image();
            wolf.Width = width;
            wolf.Height = height;
            wolf.Source = new BitmapImage(new Uri(sourse, UriKind.RelativeOrAbsolute));
            Canvas.SetLeft(wolf, left);
            Canvas.SetTop(wolf, top);
            MainWindow.canvas3.Children.Add(wolf);
        }

        public static void woolfImage(short keyIndex)
        {
            MainWindow.canvas3.Children.Clear();
            var woolf = new Woolf();
            Image wolf = new Image();
            switch (keyIndex)
            {
                case 1:         //Нажатие левой верхней кнопки
                   //Вставляем изображение волка лево вверх
                    woolf.position = 1;
                    wolf_add(226, 339, @"img/wolf_left_top.png", 345, 209);
                    break;
                case 2:         //Нажатие левой нижней кнопки
                    wolf_add(226, 339, @"img/wolf_left_down.png", 345, 209);
                    woolf.position = 2;
                    break;
                case 3:         //Нажатие правой верхней кнопки
                    wolf_add(211, 336, @"img/wolf_right_top.png", 557, 212);
                    woolf.position = 3;
                    break;
                case 4:         //Нажатие правой нижней кнопки
                    wolf_add(211, 336, @"img/wolf_right_down.png", 557, 212);
                    woolf.position = 4;
                    break;
                default:
                    break;

            }
            MainWindow.canvas3.Children.Add(wolf);
        }
    }
}
