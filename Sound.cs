using System;
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace CodeRunner
{
	public class Sound
	{
		public Sound()
		{
		}

		private static void PlaySound(string strSound, bool main = true)
		{
			strSound = Constants.APP_DIR + @"Resources\" + strSound;

            System.Windows.Media.MediaPlayer player = null;
            if (main)
                player = _mainPlayer;
            else
                player = _fallSoundPlayer;

            player.Open(new Uri(strSound));
            player.Play();
		}

        private static void StopSound()
        {

        }

		public static void PlayGetGold()
		{
			PlaySound("getGold.wav");
		}

		public static void PlayVictory()
		{
			PlaySound("victory.wav");
		}

		public static void PlayDig()
		{
			PlaySound("dig.wav");
		}

		public static void PlayDeath()
		{
			PlaySound("death.wav");
		}

		public static void PlayEscape()
		{
			PlaySound("goldFinish.wav");
		}

        public static void PlayTrap()
        {
            PlaySound("trap.wav");
        }


        public static void StartFallSound()
        {
            PlaySound("fall.wav", false);
        }

        public static void PlayLand()
        {
            PlaySound("land.wav", false);
        }


		public static void PlayStart()
		{
			//PlaySound("start.wav");
		}

        private static MediaPlayer _mainPlayer = new MediaPlayer();
        private static MediaPlayer _fallSoundPlayer = new MediaPlayer();
	}
}
