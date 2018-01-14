using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;

namespace WaitForIt
{
    class SoundModule
    {
        public bool SoundIsOn { get; set; }//звук вкл/вкл.

        MediaPlayer sndEggMove;//по одному медиаплееру на каждый файл
        MediaPlayer sndEggBreak;
        MediaPlayer sndEggCatch;
        MediaPlayer sndGameOver;

        /// <summary>
        /// при создании объекта SoundModule звук устанавливается вкл, открываются все нужные звуковые файлы
        /// </summary>
        public SoundModule()
        {
            SoundIsOn = true;

            sndEggMove = new MediaPlayer();
            sndEggMove.Open(new Uri(@"../../Sound/eggMove.mp3", UriKind.Relative));
            //Долго долбался с URI. Это ВРЕМЕННОЕ решение, потому что здесь стоит относительный путь, отсчитывающийся от местоположения экзешника.
            //Т.е. "выйти на две папки наверх и там найти папку Sound". После финальной сборки приложения папку надо будет перенести в другое место. Скорее всего будет что-то вида new Uri(@"Sound/eggMove.mp3", UriKind.Relative)

            sndEggBreak = new MediaPlayer();
            sndEggBreak.Open(new Uri(@"../../Sound/eggBreak.mp3", UriKind.Relative));

            sndEggCatch = new MediaPlayer();
            sndEggCatch.Open(new Uri(@"../../Sound/eggCatch.mp3", UriKind.Relative));

            sndGameOver = new MediaPlayer();
            sndGameOver.Open(new Uri(@"../../Sound/gameOver.mp3", UriKind.Relative));            
        }

        /// <summary>
        /// включает / выключает звук
        /// </summary>
        public void SwitchSoundOnOff()
        {
            SoundIsOn = (SoundIsOn ? false: true);

        }

        /// <summary>
        /// Звук "яйцо переместилось". Он же в оригинале играет при появлении нового яйца.
        /// </summary>
        public void EggMove()
        {
            if (SoundIsOn)
            {
                sndEggMove.Stop();
                sndEggMove.Play();
            }
        }

        /// <summary>
        /// Звук "яйцо разбилось"
        /// </summary>
        public void EggBreak()
        {
            if (SoundIsOn)
            {
                sndEggBreak.Stop();
                sndEggBreak.Play();
            }
        }

        /// <summary>
        /// Звук "яйцо поймано"
        /// </summary>
        public void EggCatch()
        {
            if (SoundIsOn)
            {
                sndEggCatch.Stop();
                sndEggCatch.Play();
            }
        }

        /// <summary>
        /// Звук "Игра окончена"
        /// </summary>
        public void GameOver()
        {
            if (SoundIsOn)
            {
                sndGameOver.Stop();
                sndGameOver.Play();
            }
        }
    }
}
