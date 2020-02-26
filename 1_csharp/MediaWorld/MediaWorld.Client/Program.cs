using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;

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

      // final-ish step
      // var ap = AudioPlayer.GetInstance();

      // the csharp way
      var ap = AudioPlayer.Instance;
      var ac = new AudioCollection();
      
      if (ac.Playlist() != null)
      {
        foreach (var item in ac.Playlist())
        {
            ap.Play(item);
        }
      }
    }
  }
}
