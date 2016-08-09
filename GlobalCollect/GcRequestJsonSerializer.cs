using Newtonsoft.Json;
using RestSharp.Serializers;

namespace GlobalCollect
{
    internal class GcRequestJsonSerializer : ISerializer
    {
        public GcRequestJsonSerializer()
        {
            ContentType = "application/json";
        }

        public string Serialize(object obj)
        {
            var s = obj as string;
            s = s ?? JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return s;
        }

        public string RootElement { get; set; }

        public string Namespace { get; set; }

        public string DateFormat { get; set; }

        public string ContentType { get; set; }
    }
}