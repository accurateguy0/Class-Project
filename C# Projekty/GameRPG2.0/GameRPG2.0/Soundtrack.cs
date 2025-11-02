using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    public class Soundtrack
    {
        public SoundPlayer Sound;
        public IWavePlayer waveOutDevice;
        public AudioFileReader audioFile; 

        public void Run(string music) // Paczka Nu Get NAudio.Wave, pobrana w Project/Manage Nu Get Packages... pozwala na granie asynchroniczne dźwięku, czyli mogą grać np. 2 dźwięki naraz
        {
            
            try
            { 
               

                waveOutDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(music);

                waveOutDevice.Init(audioFile);
                waveOutDevice.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing MP3 with NAudio: {ex.Message}");
            }
        }
        public void syncStop()
        {
            if (OperatingSystem.IsWindows())
            {
                Sound.Stop();
            }
            
        }
        public void Stop()
        {
            
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                Console.WriteLine("NAudio playback stopped.");
            }
        }
        public void syncRun(string music) // Paczka Nu Get System.Windows.Extension, pobrana w Project/Manage Nu Get Packages... pozwala i wyłącznie na granie synchroniczne dźwięku, czyli może tylko grać jeden dźwięk
        {
            //if (operatingsystem.iswindows())
            //{
            //    sound = new soundplayer(music);
            //    sound.play();
            //}
            if (OperatingSystem.IsWindows())
            {
                Sound = new SoundPlayer(music);
                Sound.Load();
                Sound.PlayLooping();
            }

        }
        //nieudana proba wlaczenia dzwieku asynchronicznego








    }
}
