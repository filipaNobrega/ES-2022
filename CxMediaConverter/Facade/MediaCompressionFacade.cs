using CxMediaConverter.Facade.Subsystem;
using CxMediaConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxMediaConverter.Facade
{
    internal class MediaCompressionFacade
    {
        private readonly BitrateReader _bitrateReader;
        private readonly AudioMixer _audioMixer;

        public MediaCompressionFacade(BitrateReader bitrateReader, AudioMixer audioMixer)
        {
            _bitrateReader = bitrateReader;
            _audioMixer = audioMixer;
        }

        public FileInfo Convert(string fileName, string format)
        {
            Console.WriteLine("MediaCompressionFacade: conversion started");

            MediaFile file = new MediaFile(fileName);

            ICodec sourceCodec = CodecFactory.Extract(file);
            ICodec destinationCodec;
            if (format == "mp3")
            {
                destinationCodec = new Mpg3CompressionCodec();
            } else
            {
                destinationCodec = new OggCompressionCodec();
            }

            MediaFile buffer = _bitrateReader.Read(file, sourceCodec);
            MediaFile tempBuffer = _bitrateReader.Convert(buffer, destinationCodec);

            FileInfo result = _audioMixer.Fix(tempBuffer);

            Console.WriteLine("MediaCompressionFacade: conversion finished");
            return result;
        }
    }
}
