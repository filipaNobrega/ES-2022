using System.IO;

namespace CxMediaConverter.Models
{
    internal class MediaFile
    {
        public string OriginalPath { get; }

        public string Name { get; }

        public string CodecType { get; }

        public MediaFile(string path)
        {
            OriginalPath = path;
            Name = Path.GetFileName(path);
            CodecType = Path.GetExtension(path);
        }
    }
}
