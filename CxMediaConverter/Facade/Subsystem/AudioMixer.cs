using CxMediaConverter.Models;
using System;
using System.IO;

namespace CxMediaConverter.Facade.Subsystem
{
    internal class AudioMixer
    {
        public FileInfo Fix(MediaFile file)
        {
            Console.WriteLine("AudioMixer: fixing audio");
            return new FileInfo(file.OriginalPath);
        }
    }
}
