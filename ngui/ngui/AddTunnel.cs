using ngrok.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngui
{
    public partial class AddTunnel : Form
    {
        public Tunnel Tunnel;
        public bool IsEdit = false;
        private main _main;
        public AddTunnel(main mainForm, Tunnel model = null)
        {
            InitializeComponent();
            _main = mainForm;
            Tunnel = model ?? new Tunnel();
            pGrid.SelectedObject = Tunnel;
            Text = model == null ? "Add Tunnel" : "Edit Tunnel";
            IsEdit = model != null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                _main.EditTunnel(Tunnel);
            }
            else
            {
                _main.AddTunnel(Tunnel);
            }
       
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
