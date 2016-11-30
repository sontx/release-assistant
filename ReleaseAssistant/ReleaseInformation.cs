using System;

namespace ReleaseAssistant
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
