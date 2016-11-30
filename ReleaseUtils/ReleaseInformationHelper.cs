using Newtonsoft.Json;
using System;
using System.IO;

namespace ReleaseUtils
{
    public static class ReleaseInformationHelper
    {
        private static ReleaseInformation TryLoadReleaseMeta(string metaFile)
        {
            try
            {
                string allContent = File.ReadAllText(metaFile);
                return JsonConvert.DeserializeObject<ReleaseInformation>(allContent);
            }
            catch { }
            return null;
        }

        private static string GetStringFromReleaseMeta(ReleaseInformation releaseInformation)
        {
            return JsonConvert.SerializeObject(releaseInformation);
        }

        public static ReleaseInformation Load(string metaFile)
        {
            ReleaseInformation releaseInformation = null;
            if (File.Exists(metaFile))
                releaseInformation = TryLoadReleaseMeta(metaFile);
            if (releaseInformation == null)
            {
                releaseInformation = new ReleaseInformation();
                releaseInformation.Version = new Version("0.0.0.0");
                releaseInformation.ReleaseNotes = "";
                releaseInformation.FriendlyVersion = releaseInformation.Version.ToString();
            }
            releaseInformation.ReleaseDate = DateTime.Now;
            return releaseInformation;
        }

        public static void Save(ReleaseInformation releaseInformation, string metaFile)
        {
            string json = GetStringFromReleaseMeta(releaseInformation);
            File.WriteAllText(metaFile, json);
        }
    }
}