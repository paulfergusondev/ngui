using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using data;
using Newtonsoft.Json;
using ngrok.model;
using YamlDotNet.Serialization;

namespace ngrok
{
    public class ngrok
    {
        private const string apiEndpoint = "http://127.0.0.1:4040/api";
        private string tunnelSavePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\ngrokTunnels.json";
        private string configPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\.ngrok2\ngrok.yml";
        public bool StartTunnel(Tunnel tunnelToStart)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(tunnelToStart);
                    StringContent jsonPayload = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = client.PostAsync($"{apiEndpoint}/tunnels", jsonPayload).Result;
                    return true;
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public bool StopTunnel(string tunnelName)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var result = client.DeleteAsync($"{apiEndpoint}/tunnels/{tunnelName}").Result;
                    return true;
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public Configuration LoadConfiguration(string path = "")
        {
            path = path == "" ? configPath : path;
            Deserializer yamlDeserializer = new Deserializer();
            Configuration config = yamlDeserializer.Deserialize<Configuration>(File.ReadAllText(path));
            return config;
        }

        public List<Tunnel> GetSavedTunnels()
        {
            return new Database().ReadTunnels(tunnelSavePath);
        }
        public string SaveTunnels(List<Tunnel> tunnels)
        {
            return new Database().SaveTunnels(tunnels, tunnelSavePath);  
        }
    }
}
