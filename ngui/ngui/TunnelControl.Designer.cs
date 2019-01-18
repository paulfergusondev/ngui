namespace ngui
{
    partial class TunnelControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunnelControl));
            this.lblHostname = new System.Windows.Forms.Label();
            this.lblProto = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chkTunnel = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(114, 10);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(53, 13);
            this.lblHostname.TabIndex = 1;
            this.lblHostname.Text = "hostname";
            this.lblHostname.Click += new System.EventHandler(this.lblHostname_Click);
            // 
            // lblProto
            // 
            this.lblProto.AutoSize = true;
            this.lblProto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProto.Location = new System.Drawing.Point(387, 10);
            this.lblProto.Name = "lblProto";
            this.lblProto.Size = new System.Drawing.Size(36, 13);
            this.lblProto.TabIndex = 2;
            this.lblProto.Text = "proto";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(429, 10);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "iconfinder_music_square_stop_play_pause_1868960.png");
            this.imgList.Images.SetKeyName(1, "iconfinder_music_play_pause_control_go_arrow_1868967.png");
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(302, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Stopped.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::ngui.Properties.Resources.icons8_edit_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(476, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkTunnel
            // 
            this.chkTunnel.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTunnel.AutoEllipsis = true;
            this.chkTunnel.BackColor = System.Drawing.Color.DarkGreen;
            this.chkTunnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTunnel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTunnel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkTunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTunnel.ForeColor = System.Drawing.Color.White;
            this.chkTunnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTunnel.ImageIndex = 1;
            this.chkTunnel.ImageList = this.imgList;
            this.chkTunnel.Location = new System.Drawing.Point(4, 4);
            this.chkTunnel.Name = "chkTunnel";
            this.chkTunnel.Size = new System.Drawing.Size(104, 24);
            this.chkTunnel.TabIndex = 0;
            this.chkTunnel.Text = "Tunnel Name Here";
            this.chkTunnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTunnel.UseVisualStyleBackColor = false;
            this.chkTunnel.CheckedChanged += new System.EventHandler(this.chkTunnel_CheckedChanged);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(503, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TunnelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblProto);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.chkTunnel);
            this.Name = "TunnelControl";
            this.Size = new System.Drawing.Size(530, 30);
            this.Load += new System.EventHandler(this.TunnelControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTunnel;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblProto;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
