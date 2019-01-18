using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ngrok.model.enums;
using System.ComponentModel;
using YamlDotNet.Serialization;

namespace ngrok.model
{
    public class Tunnel
    {
        [JsonProperty("name", Required = Required.Always)]
        [YamlIgnore]
        [Browsable(true)]
        [Category("Required")]
        [Description("name of the tunnel - REQUIRED")]
        public string Name { get; set; }

        [JsonProperty("proto", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        [YamlMember(Alias = "proto", SerializeAs = typeof(ProtocolEnum))]
        [Browsable(true)]
        [Category("Required")]
        [Description("tunnel protocol name, one of http, tcp, tls - REQUIRED")]
        public ProtocolEnum Protocol { get; set; }

        [JsonProperty("addr", Required = Required.Always)]
        [YamlMember(Alias = "addr", SerializeAs = typeof(int))]
        [Browsable(true)]
        [Category("Required")]
        [Description("forward traffic to this local port number or network address - REQUIRED")]
        public int Address { get; set; }

        [JsonProperty("inspect", Required = Required.AllowNull)]
        [YamlMember(Alias = "inspect", SerializeAs = typeof(bool?))]
        [Browsable(true)]
        [Category("All")]
        [Description("enable http request inspection")]
        public bool? Inspect { get; set; }

        [JsonProperty("auth", Required = Required.AllowNull)]
        [YamlMember(Alias = "auth")]
        [Browsable(true)]
        [Category("HTTP")]
        [Description("HTTP basic authentication credentials to enforce on tunneled requests")]
        public string Authorization { get; set; }

        [JsonProperty("host-header", Required = Required.AllowNull)]
        [YamlMember(Alias = "host-header")]
        [Browsable(true)]
        [Category("HTTP")]
        [Description("Rewrite the HTTP Host header to this value or preserve to leave it unchanged")]
        public string HostHeader { get; set; }

        [JsonProperty("bind_tls", Required = Required.AllowNull)]
        [YamlMember(Alias = "bind_tls", SerializeAs = typeof(bool?))]
        [Browsable(true)]
        [Category("HTTP")]
        [Description("bind an HTTPS or HTTP endpoint or both true, false, or both")]
        public bool? BindTls { get; set; }

        [JsonProperty("subdomain", Required = Required.AllowNull)]
        [YamlMember(Alias = "subdomain")]
        [Browsable(true)]
        [Category("HTTP/TLS")]
        [Description("subdomain name to request. If unspecified, uses the tunnel name")]
        public string Subdomain { get; set; }

        [JsonProperty("hostname", Required = Required.AllowNull)]
        [YamlMember(Alias = "hostname")]
        [Browsable(true)]
        [Category("HTTP/TLS")]
        [Description("hostname to request (requires reserved name and DNS CNAME)")]
        public string Hostname { get; set; }

        [JsonProperty("crt", Required = Required.AllowNull)]
        [YamlMember(Alias = "crt")]
        [Browsable(true)]
        [Category("TLS")]
        [Description("PEM TLS certificate at this path to terminate TLS traffic before forwarding locally")]
        public string Certificate { get; set; }

        [JsonProperty("key", Required = Required.AllowNull)]
        [YamlMember(Alias = "key")]
        [Browsable(true)]
        [Category("TLS")]
        [Description("PEM TLS private key at this path to terminate TLS traffic before forwarding locally")]
        public string Key { get; set; }

        [JsonProperty("client_cas", Required = Required.AllowNull)]
        [YamlMember(Alias = "client_cas")]
        [Browsable(true)]
        [Category("TLS")]
        [Description("PEM TLS certificate authority at this path will verify incoming TLS client conneciton certificates")]
        public string ClientCas { get; set; }

        [JsonProperty("remote_addr", Required = Required.AllowNull)]
        [YamlMember(Alias = "remote_addr")]
        [Browsable(true)]
        [Category("TCP")]
        [Description("bind the remote TCP port on the given address")]
        public string RemoteAddress { get; set; }
    }
}