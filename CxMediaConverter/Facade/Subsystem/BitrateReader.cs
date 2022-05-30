using CxMediaConverter.Models;
using System;

namespace CxMediaConverter.Facade.Subsystem
{
    internal class BitrateReader
    {
        public MediaFile Read(MediaFile file, ICodec codec)
        {
            Console.WriteLine("BitrateReader: reading file");
            return file;
        }

        public MediaFile Convert(MediaFile buffer, ICodec codec)
        {
            Console.WriteLine("BitrateReader: writing file");
            return buffer;
        }
    }
}
