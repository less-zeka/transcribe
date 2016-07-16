using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.Wave;

namespace Transkribieren
{
    public partial class Form1 : Form
    {

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private IWavePlayer _player;
        private WaveFileReader _waveFile;
        private string _soundLocation = @"C:\tmp\Interview.wav";
        private readonly BackgroundWorker _worker;


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            lblBackHelp.Text = "ctrl + shift + \u2190";
            lblForewardHelp.Text = "ctrl + shift + \u2192";
            SetupPlayer();

            _worker = new BackgroundWorker();
            _worker.DoWork += backgroundWorker_DoWork;
            _worker.WorkerSupportsCancellation = true;

            edtFocus.Focus();

            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, HotKeyPlayPause, 6, Keys.Space.GetHashCode());
            RegisterHotKey(this.Handle, HotKeyBack, 6, Keys.Left.GetHashCode());
            RegisterHotKey(this.Handle, HotKeyForeward, 6, Keys.Right.GetHashCode());
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (_player.PlaybackState == PlaybackState.Playing && !_worker.CancellationPending)
            {
                var postitionString = _waveFile.CurrentTime.ToString();
                lblPosition.Invoke((MethodInvoker)delegate {
                    lblPosition.Text = postitionString;
                });
            }
        }


        private void SetupPlayer()
        {
            var fileStream = File.OpenRead(_soundLocation);
            _waveFile = new WaveFileReader(fileStream);
            _player = new WaveOut();
            _player.Init(_waveFile);
        }

        private void play_Click(object sender, EventArgs e)
        {
           PlayOrPause();
        }

        private void PlayOrPause()
        {
            if (_player.PlaybackState == PlaybackState.Stopped)
            {
                btnPlay.Text = "Stop";
                _player.Play();
                _worker.RunWorkerAsync();
            }
                
            else if(_player.PlaybackState == PlaybackState.Paused)
            {
                int seconds;

                if (int.TryParse(edtBackTimePause.Text, out seconds))
                {
                    btnPlay.Text = "Stop";
                    GoBack(seconds);
                    _worker.RunWorkerAsync();

                }
            }
            else
            {
                btnPlay.Text = "Play";
                _player.Pause();
                _worker.CancelAsync();
            }
        } 

        private void GoBack(int seconds)
        {
            var timeSpan = new TimeSpan(0, 0, 0, seconds, 0);
            if (_waveFile.CurrentTime.Subtract(timeSpan) > TimeSpan.Zero)
            {
                _player.Pause();
                _waveFile.CurrentTime = _waveFile.CurrentTime.Subtract(timeSpan);
                _player.Play();
            }
        }

        private void GoForeward()
        {
            _player.Pause();
            int seconds;
            int.TryParse(edtForeward.Text, out seconds);
            _waveFile.CurrentTime = _waveFile.CurrentTime.Add(new TimeSpan(0, 0, 0, seconds, 0));
            _player.Play();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                PlayOrPause();
            }
            else if(e.KeyCode == Keys.Left)
            {
                int seconds;
                int.TryParse(edtBackTime.Text, out seconds);
                GoBack(seconds);
            }
            else if (e.KeyCode == Keys.Right)
            {
                GoForeward();
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                edtFile.Text = openFileDialog1.FileName;
                _soundLocation = openFileDialog1.FileName;
                SetupPlayer();
            }
        }

        const int HotKeyPlayPause = 1;
        const int HotKeyBack = 2;
        const int HotKeyForeward = 3;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HotKeyPlayPause)
            {
                PlayOrPause();
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HotKeyBack)
            {
                int seconds;
                int.TryParse(edtBackTime.Text, out seconds);
                GoBack(seconds);
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HotKeyForeward)
            {
                GoForeward();
            }
            base.WndProc(ref m);
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister hotkeys 
            UnregisterHotKey(this.Handle, HotKeyPlayPause);
            UnregisterHotKey(this.Handle, HotKeyBack);
            UnregisterHotKey(this.Handle, HotKeyForeward);

        }
    }
}
