using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace nna_net3.src.objects
{
    class LicenseObject
    {
        [JsonProperty("identifier")]
        public string Identifier;
        [JsonProperty("url")]
        public dynamic Url;
    }

    class Manifest
    {
        public string ManifestName;
        [JsonProperty("description")]
        public string ManifestDesc;
        [JsonProperty("license")]
        public dynamic ManifestLicense;

        private List<string> ConcurrentStatus;
        public string Status1;
        public string Status2;

        public Manifest(string Name, string Description, dynamic License)
        {
            
            ConcurrentStatus = new List<string>();

            ManifestName = Name;
            ManifestDesc = Description;
            if (License is JObject j)
            {
                LicenseObject obj = j.ToObject<LicenseObject>();
                ManifestLicense = obj.Identifier;
            }
            else
                ManifestLicense = (string)License;

            switch (Directory.Exists(StaticUtils.ScoopDir + "\\apps\\" + Name))
            {
                case true:
                    string[] a = { "Update", "Remove" };
                    ConcurrentStatus.AddRange(a);
                    Status1 = a[0];
                    Status2 = a[0];
                    break;
                case false:
                    string[] b = { "Install", "Install" };
                    ConcurrentStatus.AddRange(b);
                    Status1 = Status2 = "Install";
                    break;
            }
        }
    }
}
