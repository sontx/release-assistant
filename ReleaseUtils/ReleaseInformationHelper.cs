using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ReleaseUtils
{
    public static class ReleaseInformationHelper
    {
        private static ReleaseInformation TryLoadReleaseMeta(string metaFile)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(ReleaseInformation));
                using (var fs = new FileStream(metaFile, FileMode.Open))
                {
                    using (var xmlReader = XmlReader.Create(fs))
                    {
                        if (!serializer.CanDeserialize(xmlReader))
                            return null;
                        return serializer.Deserialize(xmlReader) as ReleaseInformation;
                    }
                }
            }
            catch { }
            return null;
        }

        private static string GetStringFromReleaseMeta(ReleaseInformation releaseInformation)
        {
            var serializer = new XmlSerializer(typeof(ReleaseInformation));
            using (var writer = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(writer))
                {
                    serializer.Serialize(xmlWriter, releaseInformation);
                    return writer.ToString();
                }
            }
        }

        private static string TryGetAssemblyAttribute(string allContent, string assemblyAttribute)
        {
            int attributeIndex = allContent.IndexOf(assemblyAttribute);
            if (attributeIndex < 0)
                return null;
            int startTokenIndex = allContent.IndexOf("(\"", attributeIndex);
            int endTokenIndex = allContent.IndexOf("\")", startTokenIndex);
            return startTokenIndex < endTokenIndex ? allContent.Substring(startTokenIndex + 2, endTokenIndex - startTokenIndex - 2).Trim() : null;
        }

        private static ReleaseInformation TryLoadAssemblyInfo(string assemblyInfoFile)
        {
            try
            {
                var allContent = File.ReadAllText(assemblyInfoFile);
                string fileVersion = TryGetAssemblyAttribute(allContent, "AssemblyFileVersion");
                string informationVersion = TryGetAssemblyAttribute(allContent, "AssemblyInformationalVersion");
                if (!string.IsNullOrEmpty(fileVersion))
                {
                    ReleaseInformation releaseInformation = new ReleaseInformation();
                    releaseInformation.Version = new Version(fileVersion);
                    releaseInformation.FriendlyVersion = informationVersion;
                    return releaseInformation;
                }
            }
            catch { }
            return null;
        }

        private static void MergeFromAssembly(ReleaseInformation releaseInformation, ReleaseInformation releaseInformationAssembly)
        {
            releaseInformation.Version = releaseInformationAssembly.Version;
            releaseInformation.FriendlyVersion = releaseInformationAssembly.FriendlyVersion;
        }

        private static void MergeFromMeta(ReleaseInformation releaseInformation, ReleaseInformation releaseInformationMeta)
        {
            releaseInformation.Version = releaseInformationMeta.Version;
            releaseInformation.FriendlyVersion = releaseInformationMeta.FriendlyVersion;
        }

        public static ReleaseInformation Load(string metaFile, string assemblyInfoFile, Mege merge)
        {
            ReleaseInformation releaseInformationMeta = null;
            if (!string.IsNullOrEmpty(metaFile) && File.Exists(metaFile))
                releaseInformationMeta = TryLoadReleaseMeta(metaFile);

            ReleaseInformation releaseInformationAssembly = null;
            if (!string.IsNullOrEmpty(assemblyInfoFile) && File.Exists(assemblyInfoFile))
                releaseInformationAssembly = TryLoadAssemblyInfo(assemblyInfoFile);

            ReleaseInformation releaseInformation = new ReleaseInformation();
            if (releaseInformationAssembly != null && releaseInformationMeta != null)
            {
                if (merge == Mege.PreferAssembly)
                    MergeFromAssembly(releaseInformation, releaseInformationAssembly);
                else if (merge == Mege.PreferMetadata)
                    MergeFromMeta(releaseInformation, releaseInformationMeta);
            }
            else if (releaseInformationMeta != null)
            {
                MergeFromMeta(releaseInformation, releaseInformationMeta);
            }
            else if (releaseInformationAssembly != null)
            {
                MergeFromAssembly(releaseInformation, releaseInformationAssembly);
            }

            releaseInformation.ReleaseDate = DateTime.Now;
            releaseInformation.ReleaseNotes = releaseInformationMeta != null ? releaseInformationMeta.ReleaseNotes : "";
            if (releaseInformation.Version == null)
                releaseInformation.Version = new Version();

            return releaseInformation;
        }

        public static ReleaseInformation LoadFromMeta(string metaFile)
        {
            return Load(metaFile, null, Mege.None);
        }

        public static ReleaseInformation LoadFromAssembly(string assemblyInfoFile)
        {
            return Load(null, assemblyInfoFile, Mege.None);
        }

        public static void Save(ReleaseInformation releaseInformation, string metaFile)
        {
            File.WriteAllText(metaFile, GetStringFromReleaseMeta(releaseInformation));
        }
    }
}