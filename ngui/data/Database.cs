using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProtoBuf;
using ngrok.model;

namespace data
{
    public class Database
    {
        public string SaveTunnels(List<Tunnel> tunnels, string path)
        {
            using (var file = File.OpenWrite(path))
            {
                Serializer.Serialize(file, tunnels);
            }
            return path;
        }
        public List<Tunnel> ReadTunnels(string path)
        {
            using (var file = File.OpenRead(path))
            {
                return Serializer.Deserialize<List<Tunnel>>(file);
            }
        }
    }
}
