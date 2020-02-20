using System;

namespace MediaProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToCurrentPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMediaDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unMuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.LoadPlaylistToolStripMenuItem,
            this.openMediaDirectoryToolStripMenuItem,
            this.clearPlaylistToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MediaProject.Properties.Resources.open_file;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openToolStripMenuItem.Text = "Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // LoadPlaylistToolStripMenuItem
            // 
            this.LoadPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNewPlaylistToolStripMenuItem,
            this.addItemsToCurrentPlaylistToolStripMenuItem});
            this.LoadPlaylistToolStripMenuItem.Image = global::MediaProject.Properties.Resources.openmediadir;
            this.LoadPlaylistToolStripMenuItem.Name = "LoadPlaylistToolStripMenuItem";
            this.LoadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.LoadPlaylistToolStripMenuItem.Text = "Load Playlist";
            this.LoadPlaylistToolStripMenuItem.Click += new System.EventHandler(this.LoadPlaylistToolStripMenuItem_Click);
            // 
            // loadNewPlaylistToolStripMenuItem
            // 
            this.loadNewPlaylistToolStripMenuItem.Image = global::MediaProject.Properties.Resources.newplaylist;
            this.loadNewPlaylistToolStripMenuItem.Name = "loadNewPlaylistToolStripMenuItem";
            this.loadNewPlaylistToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.loadNewPlaylistToolStripMenuItem.Text = "Load New Playlist";
            this.loadNewPlaylistToolStripMenuItem.Click += new System.EventHandler(this.loadNewPlaylistToolStripMenuItem_Click);
            // 
            // addItemsToCurrentPlaylistToolStripMenuItem
            // 
            this.addItemsToCurrentPlaylistToolStripMenuItem.Image = global::MediaProject.Properties.Resources.additems;
            this.addItemsToCurrentPlaylistToolStripMenuItem.Name = "addItemsToCurrentPlaylistToolStripMenuItem";
            this.addItemsToCurrentPlaylistToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addItemsToCurrentPlaylistToolStripMenuItem.Text = "Add Items to current Playlist";
            this.addItemsToCurrentPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addItemsToCurrentPlaylistToolStripMenuItem_Click);
            // 
            // openMediaDirectoryToolStripMenuItem
            // 
            this.openMediaDirectoryToolStripMenuItem.Image = global::MediaProject.Properties.Resources.opndir;
            this.openMediaDirectoryToolStripMenuItem.Name = "openMediaDirectoryToolStripMenuItem";
            this.openMediaDirectoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openMediaDirectoryToolStripMenuItem.Text = "Open Media Directory";
            this.openMediaDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openMediaDirectoryToolStripMenuItem_Click);
            // 
            // clearPlaylistToolStripMenuItem
            // 
            this.clearPlaylistToolStripMenuItem.Image = global::MediaProject.Properties.Resources.clear;
            this.clearPlaylistToolStripMenuItem.Name = "clearPlaylistToolStripMenuItem";
            this.clearPlaylistToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.clearPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clearPlaylistToolStripMenuItem.Text = "Clear Playlist";
            this.clearPlaylistToolStripMenuItem.Click += new System.EventHandler(this.clearPlaylistToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::MediaProject.Properties.Resources.exit;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.rewindToolStripMenuItem,
            this.fastForwardToolStripMenuItem,
            this.fullscreenToolStripMenuItem,
            this.replayToolStripMenuItem,
            this.volumeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::MediaProject.Properties.Resources.play;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::MediaProject.Properties.Resources.pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::MediaProject.Properties.Resources.stop;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::MediaProject.Properties.Resources.next;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Image = global::MediaProject.Properties.Resources.previous;
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // rewindToolStripMenuItem
            // 
            this.rewindToolStripMenuItem.Image = global::MediaProject.Properties.Resources.rewind;
            this.rewindToolStripMenuItem.Name = "rewindToolStripMenuItem";
            this.rewindToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.rewindToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.rewindToolStripMenuItem.Text = "Rewind";
            this.rewindToolStripMenuItem.Click += new System.EventHandler(this.rewindToolStripMenuItem_Click);
            // 
            // fastForwardToolStripMenuItem
            // 
            this.fastForwardToolStripMenuItem.Image = global::MediaProject.Properties.Resources.fastforward;
            this.fastForwardToolStripMenuItem.Name = "fastForwardToolStripMenuItem";
            this.fastForwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.fastForwardToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.fastForwardToolStripMenuItem.Text = "Fast Forward";
            this.fastForwardToolStripMenuItem.Click += new System.EventHandler(this.fastForwardToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Image = global::MediaProject.Properties.Resources.fullscreen;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.Image = global::MediaProject.Properties.Resources.replay;
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.replayToolStripMenuItem.Text = "Replay";
            this.replayToolStripMenuItem.Click += new System.EventHandler(this.replayToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.muteToolStripMenuItem,
            this.unMuteToolStripMenuItem});
            this.volumeToolStripMenuItem.Image = global::MediaProject.Properties.Resources.volume;
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.volumeToolStripMenuItem.Text = "Volume";
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Image = global::MediaProject.Properties.Resources.vup;
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.upToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Image = global::MediaProject.Properties.Resources.vdown;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.downToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Image = global::MediaProject.Properties.Resources.mute;
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // unMuteToolStripMenuItem
            // 
            this.unMuteToolStripMenuItem.Image = global::MediaProject.Properties.Resources.unmute;
            this.unMuteToolStripMenuItem.Name = "unMuteToolStripMenuItem";
            this.unMuteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.unMuteToolStripMenuItem.Text = "UnMute";
            this.unMuteToolStripMenuItem.Click += new System.EventHandler(this.unMuteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(12, 37);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(322, 324);
            this.WindowsMediaPlayer1.TabIndex = 1;
            this.WindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.WindowsMediaPlayer1_EndOfStream);
            this.WindowsMediaPlayer1.Enter += new System.EventHandler(this.WindowsMediaPlayer1_Enter);
            // 
            // Playlist
            // 
            this.Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist.BackColor = System.Drawing.Color.Black;
            this.Playlist.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.ForeColor = System.Drawing.Color.Lime;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.HorizontalScrollbar = true;
            this.Playlist.ItemHeight = 20;
            this.Playlist.Location = new System.Drawing.Point(356, 71);
            this.Playlist.MaximumSize = new System.Drawing.Size(207, 458);
            this.Playlist.MinimumSize = new System.Drawing.Size(207, 290);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(207, 284);
            this.Playlist.TabIndex = 5;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.Lime;
            this.nextBtn.Location = new System.Drawing.Point(459, 40);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(104, 31);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.Color.Lime;
            this.prevBtn.Location = new System.Drawing.Point(356, 40);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(104, 31);
            this.prevBtn.TabIndex = 7;
            this.prevBtn.Text = "<<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.WindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(600, 410);
            this.Name = "Form1";
            this.Text = "Media Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.ToolStripMenuItem clearPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNewPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemsToCurrentPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMuteToolStripMenuItem;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ToolStripMenuItem openMediaDirectoryToolStripMenuItem;
    }
}

