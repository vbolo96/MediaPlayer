using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaProject
{
    public partial class Form1 : Form
    {
        string[] fileNames,filesPath;
        List<string> myList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            playToolStripMenuItem.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            fastForwardToolStripMenuItem.Enabled = false;
            rewindToolStripMenuItem.Enabled = false;
            replayToolStripMenuItem.Enabled = false;
            fullscreenToolStripMenuItem.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
            previousToolStripMenuItem.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            myList.Clear();
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer1.Ctlcontrols.stop();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"Media files (*.mp3, *.mp4, *.avi, *.gif,*.mkv) | *.mp3; *.mp4; *.avi; *.gif;*.mkv;
                |Video files(*.mp4,*.avi,*.mkv)|*.mp4;*.avi;*.mkv;
                |Audio files(*.mp3)|*.mp3;
                |GIFS(*.gif)|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WindowsMediaPlayer1.URL = ofd.FileName;
                string name = ofd.FileName;
                myList.Add(name);
                Playlist.Items.Add(ofd.SafeFileName);
            }
            if (myList.Count > 0)
            {
                playToolStripMenuItem.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                fastForwardToolStripMenuItem.Enabled = true;
                rewindToolStripMenuItem.Enabled = true;
                replayToolStripMenuItem.Enabled = true;
                fullscreenToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                previousToolStripMenuItem.Enabled = true;
            }
        }

        private void clearPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            myList.Clear();
            if(myList.Count==0)
            {
                playToolStripMenuItem.Enabled = false;
                pauseToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = false;
                fastForwardToolStripMenuItem.Enabled = false;
                rewindToolStripMenuItem.Enabled = false;
                replayToolStripMenuItem.Enabled = false;
                fullscreenToolStripMenuItem.Enabled = false;
                nextToolStripMenuItem.Enabled = false;
                previousToolStripMenuItem.Enabled = false;
            }
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(myList.Count>1)
                WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex];
            if (myList[Playlist.SelectedIndex].EndsWith(".mp4") || myList[Playlist.SelectedIndex].EndsWith(".avi")|| myList[Playlist.SelectedIndex].EndsWith(".mkv"))
            {
                fullscreenToolStripMenuItem.Enabled = true;
            }
            else
            {
                fullscreenToolStripMenuItem.Enabled = false;
            }

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void rewindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void fastForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer1.Ctlcontrols.stop();
                WindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void WindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    int index = Playlist.SelectedIndex;
                    if (index != myList.Count - 1)
                    {
                        WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex + 1];
                        WindowsMediaPlayer1.settings.autoStart = true;
                        Playlist.SelectedIndex = Playlist.SelectedIndex + 1;
                    }
                    else
                    {
                        WindowsMediaPlayer1.URL = myList[0];
                        WindowsMediaPlayer1.settings.autoStart = true;
                        Playlist.SelectedIndex = 0;
                    }
                }
            }
        }

        private void loadNewPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            myList.Clear();
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer1.Ctlcontrols.stop();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"Media files (*.mp3, *.mp4, *.avi, *.gif,*.mkv) | *.mp3; *.mp4; *.avi; *.gif;*.mkv;
                |Video files (*.mp4,*.avi,*.mkv)|*.mp4;*.avi;*.mkv;
                |Audio files (*.mp3)| *.mp3;
                |GIFS (*.gif)|*.gif";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNames = ofd.SafeFileNames;
                filesPath = ofd.FileNames;
                for (int i=0; i < filesPath.Length; i++)
                {
                    myList.Add(filesPath[i]);
                }
                for (int i = 0; i < fileNames.Length; i++)
                {
                    Playlist.Items.Add(fileNames[i]);
                }

            }
            if (myList.Count > 0)
            {
                playToolStripMenuItem.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                fastForwardToolStripMenuItem.Enabled = true;
                rewindToolStripMenuItem.Enabled = true;
                replayToolStripMenuItem.Enabled = true;
                fullscreenToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                previousToolStripMenuItem.Enabled = true;
            }
        }

        private void addItemsToCurrentPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"Media files (*.mp3, *.mp4, *.avi, *.gif,*.mkv) | *.mp3; *.mp4; *.avi; *.gif;*.mkv;
                |Video files(*.mp4,*.avi,*.mkv)|*.mp4;*.avi; *.mkv;
                |Audio files(*.mp3)|*.mp3;
                |GIFS(*.gif)|*.gif";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileNames = ofd.SafeFileNames;
                filesPath = ofd.FileNames;
               
                for(int i=0;i<filesPath.Length;i++)
                {
                    myList.Add(filesPath[i]);
                }
                for (int i = 0; i < fileNames.Length; i++)
                {
                    Playlist.Items.Add(fileNames[i]);
                }

            }
            if (myList.Count > 0)
            {
                playToolStripMenuItem.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                fastForwardToolStripMenuItem.Enabled = true;
                rewindToolStripMenuItem.Enabled = true;
                replayToolStripMenuItem.Enabled = true;
                fullscreenToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                previousToolStripMenuItem.Enabled = true;
            }

        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myList.Count > 0)
            {
                int index = Playlist.SelectedIndex;
                if (index != myList.Count - 1)
                {
                    WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex + 1];
                    Playlist.SelectedIndex = Playlist.SelectedIndex + 1;
                }
                else
                {
                    WindowsMediaPlayer1.URL = myList[0];
                    Playlist.SelectedIndex = 0;
                }
            }
            else
            {
                string message = "The Playlist is empty.Please load a new playlist!";
                string caption = "Attention!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myList.Count > 0)
            {
                int index = Playlist.SelectedIndex;
                if (index != 0)
                {
                    WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex - 1];
                    Playlist.SelectedIndex = Playlist.SelectedIndex - 1;
                }
                else
                {
                    WindowsMediaPlayer1.URL = myList[myList.Count - 1];
                    Playlist.SelectedIndex = myList.Count - 1;
                }
            }
            else
            {
                string message = "The Playlist is empty.Please load a new playlist!";
                string caption = "Attention!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            }

        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.settings.volume < 90)
            {
                WindowsMediaPlayer1.settings.volume = (WindowsMediaPlayer1.settings.volume + 10);
            }
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.settings.volume > 10)
            {
                WindowsMediaPlayer1.settings.volume = (WindowsMediaPlayer1.settings.volume - 10);
            }
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (muteToolStripMenuItem.Checked == false)
            {
                WindowsMediaPlayer1.settings.mute = true;
                muteToolStripMenuItem.Checked = true;
                unMuteToolStripMenuItem.Checked = false;
            }
            else {
                muteToolStripMenuItem.Checked = false;
            }
        }

        private void unMuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unMuteToolStripMenuItem.Checked == false)
            {
                WindowsMediaPlayer1.settings.mute = false;
                unMuteToolStripMenuItem.Checked = true;
                muteToolStripMenuItem.Checked = false;
            }
            else
            {
                muteToolStripMenuItem.Checked = false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (myList.Count > 0)
            {
                int index = Playlist.SelectedIndex;
                if (index != myList.Count - 1)
                {
                    WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex + 1];
                    Playlist.SelectedIndex = Playlist.SelectedIndex + 1;
                }
                else
                {
                    WindowsMediaPlayer1.URL = myList[0];
                    Playlist.SelectedIndex = 0;
                }
            }
            else
            {
                string message = "The Playlist is empty.Please load a new playlist!";
                string caption = "Attention!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (myList.Count > 0)
            {
                int index = Playlist.SelectedIndex;
                if (index != 0)
                {
                    WindowsMediaPlayer1.URL = myList[Playlist.SelectedIndex - 1];
                    Playlist.SelectedIndex = Playlist.SelectedIndex - 1;
                }
                else
                {
                    WindowsMediaPlayer1.URL = myList[myList.Count - 1];
                    Playlist.SelectedIndex = myList.Count - 1;
                }
            }
            else {
                string message = "The Playlist is empty.Please load a new playlist!";
                string caption = "Attention!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            }
            
        }

        private void openMediaDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
            myList.Clear();
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                WindowsMediaPlayer1.Ctlcontrols.stop();
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var list = Directory.EnumerateFiles(fbd.SelectedPath, "*.*");
                myList = list.Where(s => s.EndsWith(".mp3") || s.EndsWith(".mp4")|| s.EndsWith(".avi")|| s.EndsWith(".gif")||s.EndsWith(".mkv")).OrderBy(a => a).ToList();
                if (myList.Count > 0)
                {
                    foreach (string item in myList)
                        Playlist.Items.Add(Path.GetFileName(item));
                }
                else
                {
                    string message = "The selected directory does not contain media files." +
                        "          Please select another directory!";
                    string caption = "Attention!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                }
                
            }
            if (myList.Count > 0)
            {
                playToolStripMenuItem.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                fastForwardToolStripMenuItem.Enabled = true;
                rewindToolStripMenuItem.Enabled = true;
                replayToolStripMenuItem.Enabled = true;
                fullscreenToolStripMenuItem.Enabled = true;
                nextToolStripMenuItem.Enabled = true;
                previousToolStripMenuItem.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void WindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
