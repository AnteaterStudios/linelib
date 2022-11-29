using System.IO;

namespace AnteaterStudios.Linelib
{
    public static class ContentManager
    {
        public static T LoadContent<T>(string path, ContentLoader<T> contentLoader)
        {
            // Reads the file's binary data
            byte[] readData = File.ReadAllBytes(path);

            // Returns the content using the custom loader
            return contentLoader.LoadContent(readData);
        }
    }
}
