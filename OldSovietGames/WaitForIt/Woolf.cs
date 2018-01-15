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
       
    public static void woolfImage(short keyIndex)
        {
            var woolf = new Woolf();
            
            switch (keyIndex)
            {
                case 1:         //Нажатие левой верхней кнопки
                   //Вставляем изображение волка лево вверх
                    woolf.position = 1;
                    
                    break;
                case 2:         //Нажатие левой нижней кнопки
                   
                    woolf.position = 2;
                    break;
                case 3:         //Нажатие правой верхней кнопки
                    
                    woolf.position = 3;
                    break;
                case 4:         //Нажатие правой нижней кнопки
                    
                    woolf.position = 4;
                    break;
                default:
                    break;

            }
        }
    }
}
