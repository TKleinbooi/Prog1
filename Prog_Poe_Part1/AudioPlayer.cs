using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_POE
{
    internal class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Audio failed to play. Make sure 'greeting.wav' is in the project folder.");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
