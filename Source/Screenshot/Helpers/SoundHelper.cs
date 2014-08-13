using System.IO;
using System.Media;

namespace Screenshot.Helpers
{
    public static class SoundHelper
    {
        public static void PlaySound(Stream soundStream)
        {
            using (var soundPlayer = new SoundPlayer(soundStream))
                soundPlayer.Play();
        }
    }
}