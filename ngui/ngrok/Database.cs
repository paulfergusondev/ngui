using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ngrok.model;
using Newtonsoft.Json;

namespace data
{
    public class Database
    {
        public string SaveTunnels(List<Tunnel> tunnels, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(tunnels));
            return path;
        }
        public List<Tunnel> ReadTunnels(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Tunnel>();
            }
            return JsonConvert.DeserializeObject<List<Tunnel>>(File.ReadAllText(path));
        }
    }
}
