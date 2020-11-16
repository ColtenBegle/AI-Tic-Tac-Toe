using System;
using System.Collections.Generic;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Properties;
using System.Globalization;
using System.Collections;
using System.IO;

namespace TicTacToe.Music
{
    public class BackgroundMusic
    {
        private List<Sound> sounds = new List<Sound>();

        public BackgroundMusic()
        {
            sounds = GetSoundsFromResources();
        }

        public List<Sound> Sounds
        {
            get { return sounds; }
            set { sounds = value;}
        }

        public Sound GetSound(string soundName)
        {
            foreach (Sound sound in sounds)
            {
                if (sound.SoundName == soundName)
                {
                    return sound;
                }
            }
            return sounds.FirstOrDefault();
        }

        private List<Sound> GetSoundsFromResources()
        {
            List<Sound> tempSounds = new List<Sound>();
            ResourceManager MyResourceClass =
                new ResourceManager(typeof(Resources));

            ResourceSet resourceSet =
                MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                object resource = entry.Value;
                Type type = resource.GetType();
                if (type.Name == "UnmanagedMemoryStream")
                {
                    Sound sound = new Sound((UnmanagedMemoryStream)resource, resourceKey);
                    tempSounds.Add(sound);
                }
            }

            return tempSounds;
        }
    }
}
