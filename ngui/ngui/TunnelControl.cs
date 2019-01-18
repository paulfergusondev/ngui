using ngrok.model;
using ngrok.model.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngui
{
    public partial class TunnelControl : UserControl
    {
        public Tunnel _tunnel;
        private ngrok.ngrok _ngrok = new ngrok.ngrok();
        public TunnelControl(Tunnel model)
        {
            _tunnel = model;
            InitializeComponent();
            _tunnel = model;
            loadTunnelData();
        }

        private void loadTunnelData()
        {
            chkTunnel.Text = _tunnel.Name;
            lblHostname.Text = _tunnel.Hostname ?? _tunnel.Subdomain ?? _tunnel.Name;
            lblProto.Text = Enum.GetName(typeof(ProtocolEnum), _tunnel.Protocol);
            lblPort.Text = _tunnel.Address.ToString();
        }

        private void TunnelControl_Load(object sender, EventArgs e)
        {

        }

        private void chkTunnel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTunnel.Checked)
            {
                _ngrok.StartTunnel(_tunnel);
                chkTunnel.ImageIndex = 0;
                lblStatus.Text = "Running...";
                lblStatus.Font = new Font(lblStatus.Font, FontStyle.Italic);
            }
            else
            {
                _ngrok.StopTunnel(_tunnel.Name);
                chkTunnel.ImageIndex = 1;
                lblStatus.Text = "Stopped.";
                lblStatus.Font = new Font(lblStatus.Font, FontStyle.Regular);
            }
        }

        private void lblHostname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTunnel _tunnelForm = new AddTunnel((main)Parent.Parent.Parent.Parent,  _tunnel);
            if (_tunnelForm.ShowDialog() == DialogResult.OK)
            {
                _tunnel = _tunnelForm.Tunnel;
                main mainForm = (main)Parent.Parent.Parent.Parent;
                if (_tunnelForm.IsEdit)
                {
                    mainForm.EditTunnel(_tunnel);
                    loadTunnelData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main mainForm = (main)Parent.Parent.Parent.Parent;
            mainForm.RemoveTunnel(_tunnel);
        }
    }
}
