using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Directory
    {
        /// <summary>
        /// List of entries in the directory
        /// </summary>
        [JsonProperty("entries")]
        public DirectoryEntry[] Entries { get; set; }
    }
}