using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;

namespace WaitForIt
{
    class SoundModule
    {
        public bool SoundIsOn { get; set; }

        MediaPlayer sndEggMove;
        MediaPlayer sndEggBreak;
        MediaPlayer sndEggCatch;
        MediaPlayer sndGameOver;


        public SoundModule()
        {
            SoundIsOn = true;

            sndEggMove = new MediaPlayer();
            sndEggMove.Open(new Uri(@"../../Sound/eggMove.mp3", UriKind.Relative));

            sndEggBreak = new MediaPlayer();
            sndEggBreak.Open(new Uri(@"../../Sound/eggBreak.mp3", UriKind.Relative));

            sndEggCatch = new MediaPlayer();
            sndEggCatch.Open(new Uri(@"../../Sound/eggCatch.mp3", UriKind.Relative));

            sndGameOver = new MediaPlayer();
            sndGameOver.Open(new Uri(@"../../Sound/gameOver.mp3", UriKind.Relative));



        }


        public void SwitchSoundOnOff()
        {
            SoundIsOn = (SoundIsOn ? false: true);
        }

        public void EggMove()
        {
            if (SoundIsOn)
            {
                sndEggMove.Stop();
                sndEggMove.Play();
            }
        }

        public void EggBreak()
        {
            if (SoundIsOn)
            {
                sndEggBreak.Stop();
                sndEggBreak.Play();
            }
        }

        public void EggCatch()
        {
            if (SoundIsOn)
            {
                sndEggCatch.Stop();
                sndEggCatch.Play();
            }
        }

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
