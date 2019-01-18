using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
namespace ngrok.model
{
    public class Configuration
    {
        [JsonProperty("authtoken", Required = Required.AllowNull)]
        [YamlMember(Alias = "authtoken")]
        public string AuthorizationToken { get; set; }

        [JsonProperty("json_resolver_url", Required = Required.AllowNull)]
        [YamlMember(Alias = "json_resolver_url")]
        public string JsonResolverUrl { get; set; }

        [JsonProperty("dns_resolver_ips", Required = Required.AllowNull)]
        [YamlMember(Alias = "dns_resolver_ips")]
        public string[] DnsResolveIPs { get; set; }

        [JsonProperty("region", Required = Required.AllowNull)]
        [YamlMember(Alias = "region")]
        public string Region { get; set; }

        [JsonProperty("tunnels", Required = Required.AllowNull)]
        [YamlMember(Alias = "tunnels", SerializeAs = typeof(List<Tunnel>))]
        public List<Tunnel> Tunnels { get; set; }

    }
}
