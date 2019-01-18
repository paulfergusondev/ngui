using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConEmu.WinForms;
using System.Reflection;
using System.Diagnostics;
using WindowsInput.Native;
using WindowsInput;
using ngrok;
using ngrok.model;
using ngrok.model.enums;

namespace ngui
{
    public partial class main : Form
    {
        private const string _conEmuPath = @"C:\Program Files\ConEmu\ConEmu64.exe";
        private const string _ngrokPath = @"C:\Program Files\ngrok\ngrok.exe";
        private ConEmuControl _control;
        private ConEmuSession _session;
        private InputSimulator sim = new InputSimulator();
        private ngrok.ngrok _ngrok = new ngrok.ngrok();
        public List<Tunnel> _tunnels = new List<Tunnel>();
        public main(List<Tunnel> tunnels = null)
        {
            InitializeComponent();
            setupConEmu();
            Load += Form1_Load;
            _tunnels = tunnels ?? _tunnels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tunnel tunnel = new Tunnel
            //{
            //    Name = "pmc",
            //    Hostname = "pferguson-pmc.pfl.solutions",
            //    Protocol = ProtocolEnum.tls,
            //    Address = 44300,
            //    Inspect = false,
            //    BindTls = true,
            //    HostHeader = "localhost:44300"
            //};
            //TunnelControl tControl = new TunnelControl(tunnel);
            //tControl.Dock = DockStyle.Top;
            //pnlTunnels.Controls.Add(tControl);

            //Tunnel elqTunnel= new Tunnel
            //{
            //    Name = "pmc-eloqua",
            //    Subdomain = "eloqua-koala",
            //    Protocol = ProtocolEnum.http,
            //    Address = 60524,
            //    Inspect = false,
            //    HostHeader = "rewrite",
            //    BindTls = true
            //};
            //TunnelControl t2Control = new TunnelControl(elqTunnel);
            //t2Control.Dock = DockStyle.Top;
            //pnlTunnels.Controls.Add(t2Control);
            foreach(Tunnel t in _tunnels)
            {
                TunnelControl tControl = new TunnelControl(t);
                tControl.Dock = DockStyle.Top;
                pnlTunnels.Controls.Add(tControl);
            }
        }


        private void setupConEmu()
        {
            ConEmuStartInfo startInfo = new ConEmuStartInfo();
            startInfo.ConEmuExecutablePath = @"C:\Program Files\ConEmu\ConEmu64.exe";
            startInfo.GreetingText = $"ConEmu version [{FileVersionInfo.GetVersionInfo(_conEmuPath).ProductVersion}]";
            startInfo.GreetingText += $"ngrok version [{FileVersionInfo.GetVersionInfo(_ngrokPath).ProductVersion}";
            startInfo.ConsoleProcessCommandLine = _ngrokPath + " start --none";
            _control = new ConEmuControl();
            _session = _control.Start(startInfo);
            pnlBottom.Controls.Add(_control);
            _control.Dock = DockStyle.Fill;
            _control.Enabled = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about _about = new about();
            _about.ShowDialog();
        }

        private void btnAddTunnel_Click(object sender, EventArgs e)
        {
            new AddTunnel(this).ShowDialog();
        }

        public void RemoveTunnel(Tunnel tunnel)
        {
            foreach(Control tControl in pnlTunnels.Controls)
            {
                try
                {
                    TunnelControl t = (TunnelControl)tControl;
                    if (t._tunnel.Name == tunnel.Name)
                    {
                        pnlTunnels.Controls.Remove(tControl);
                    }
                    _tunnels.Remove(tunnel);
                }
                catch
                {
                    continue;
                }
            }
        }

        public void AddTunnel(Tunnel tunnel)
        {
            TunnelControl tControl = new TunnelControl(tunnel);
            tControl.Dock = DockStyle.Top;
            pnlTunnels.Controls.Add(tControl);
            _tunnels.Add(tunnel);
        }

        public void EditTunnel(Tunnel tunnel)
        {
            Tunnel t = _tunnels.FirstOrDefault(a => a.Name == tunnel.Name);
            if (t != null)
            {
                t = tunnel;
            }
        }
    }
}
