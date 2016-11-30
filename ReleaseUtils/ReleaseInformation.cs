using System;
using System.Runtime.Serialization;

namespace ReleaseUtils
{
    [Serializable]
    public class ReleaseInformation
    {
        public Version Version { get; set; }
        public string FriendlyVersion { get; set; }
        public string ReleaseNotes { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
