using CxMediaConverter.Models;
using System;
using System.IO;

namespace CxMediaConverter.Builder
{
    internal class MediaBuilder
    {
        private MediaFile _sourceFile = null;
        private MediaFile _destinationFile = null;
        private AudioCodec _codec;
        private int _bitrate;

        public MediaBuilder FromFileInput(string path)
        {
            _sourceFile = new MediaFile(path);
            return this;
        }

        public MediaBuilder OutputToFile(string path, bool checkExists)
        {
            _destinationFile = new MediaFile(path);
            return this;
        }

        public MediaBuilder WithAudioCodec(AudioCodec codec)
        {
            _codec = codec;
            return this;
        }

        public MediaBuilder WithAudioBitrate(int bitrate)
        {
            _bitrate = bitrate;
            return this;
        }

        public FileInfo GetResult()
        {
            Console.WriteLine("MediaBuilder: conversion finished");
            return new FileInfo(_destinationFile.OriginalPath);
        } 
    }
}
