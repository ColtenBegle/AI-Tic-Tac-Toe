using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Music
{
    public class Sound
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        private string soundName;
        
        public Sound(UnmanagedMemoryStream resource, string name)
        {
            soundPlayer.Stream = resource;
            soundName = name;
        }

        public void PlaySound()
        {
            soundPlayer.PlayLooping();
        }

        public void StopSound()
        {
            soundPlayer.Stop();
        }

        public string SoundName
        {
            get { return soundName; }
            set { soundName = value; }
        }
    }
}
