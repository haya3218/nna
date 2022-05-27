using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYourFault
{
    class Manifest
    {
        public string AppName;
        public string Description;
        public dynamic License;
        public string ManifestName;
        public string status;
        public string status2;

        public Manifest(string an = "null", string de = "null", dynamic li = null, string man = "main")
        {
            AppName = an;
            Description = de;
            License = li;
            ManifestName = man;
            switch (Directory.Exists(AllYourFault.userprof + "\\scoop\\apps\\" + an))
            {
                case true:
                    status = "Update";
                    status2 = "Remove";
                    break;
                case false:
                    status = "Install";
                    status2 = "Install";
                    break;
            }
        }
    }

    class ScoopManifest
    {
        public string description;
        public dynamic license;

        public ScoopManifest()
        {
        }

        public Manifest ReturnValidManifest(string name, string bucket)
        {
            if (license is Newtonsoft.Json.Linq.JObject)
            {
                Manifest mp = new Manifest(name, description, "Proprietary", bucket);
                return mp;
            }
            Manifest m = new Manifest(name, description, license, bucket);
            return m;
        }
    }
}
