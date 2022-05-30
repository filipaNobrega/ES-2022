using CxMediaConverter.Models;
using System;

namespace CxMediaConverter.Facade.Subsystem
{
    internal class CodecFactory
    {
        public static ICodec Extract(MediaFile file)
        {
            switch(file.CodecType)
            {
                case ".mp3":
                    Console.WriteLine("CodecFactory: extracting MP3 codec");
                    return new Mpg3CompressionCodec();
                case ".ogg":
                    Console.WriteLine("CodecFactory: extracting Ogg codec");
                    return new OggCompressionCodec();
                default: return null;
            }
        }
    }
}
