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
    class Crush
    {
        
        public static void draw(int left, int top)
        {
            Image crush = new Image();
            crush.Width = 30;
            crush.Height = 30;
            crush.Source = new BitmapImage(new Uri(@"img/egg_left_down_1.png", UriKind.RelativeOrAbsolute)); // вставить цыпу
            Canvas.SetLeft(crush, left);
            Canvas.SetTop(crush, top);
            MainWindow.canvas2.Children.Add(crush);
            MainWindow.life--;
           
        }
    }
}
