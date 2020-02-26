using System;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      PlayAudio();
    }

    private static void PlayAudio()
    {
      // first step
      // AudioPlayer ap = new AudioPlayer();
      // Console.WriteLine(ap);

      // middle step
      // AudioPlayer.Play();

      var ap = AudioPlayer.GetInstance();
      var ap2 = AudioPlayer.Instance;
    }
  }
}
