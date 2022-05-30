using CSAudioConverter;
using CxMediaConverter.Builder;
using CxMediaConverter.Facade;
using Options.Core;
using System;
using System.IO;

namespace CxMediaConverter
{
    internal class Program
    {
        private const string FileName = @"your_file_name.mp3";

        static void Main(string[] args)
        {
            var builder = new MediaBuilder();
            var result = builder
                .FromFileInput(FileName)
                .OutputToFile(@"your_file_name.ogg", false)
                .WithAudioCodec(AudioCodec.OGG)
                .WithAudioBitrate(98)
                .GetResult();
            Console.WriteLine(result);

            //var facade = new MediaCompressionFacade(new Facade.Subsystem.BitrateReader(), new Facade.Subsystem.AudioMixer());
            //var result = facade.Convert(FileName, "ogg");
            //Console.WriteLine(result);
 
            //AudioConverter audioConverter = new AudioConverter();
            //var mediaFile = new SourceFile(FileName);
            //audioConverter.SourceFiles.Add(mediaFile);
            //audioConverter.DestinatioFile = @"C:\Users\Filipa\Music\file_example_OGG.ogg";
            //audioConverter.Format = Format.OGG;
            //audioConverter.Convert();
            //audioConverter.ConvertError += AudioConverter_ConvertError;
            //audioConverter.ConvertDone += AudioConverter_ConvertDone;
            //Console.WriteLine("Waiting...");
            //Console.ReadKey();
            //audioConverter.ConvertError -= AudioConverter_ConvertError;
            //audioConverter.ConvertDone -= AudioConverter_ConvertDone;
        }

        private static void AudioConverter_ConvertDone(object sender, EventArgs e)
        {            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AudioConverte: Success");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Press any key to exit...");
        }

        private static void AudioConverter_ConvertError(object sender, MessageArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AudioConverte: Failure");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Press any key to exit...");
        }
    }
}
