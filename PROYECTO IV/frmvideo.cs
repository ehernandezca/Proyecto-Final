using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace PROYECTO_IV
{
    public partial class frmvideo : Form
    {
       
        public static Video video;
        //public static string[] videoPaths;
        
        public static int selectedIndex = 0;
        public static Size formSize;
        public static Size pnlSize;

        public frmvideo()
        {
            InitializeComponent();

        }
       

        private void VIDEOS_Load(object sender, EventArgs e)
        {
            string folderPath = label1.Text;
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);

            //string remplasar = folderPath.Replace(".wmv", "");
           //videoPaths = Directory.GetFiles(remplasar);
           
          // if (videoPaths != null)
          // {
          //     foreach (string path in videoPaths)
          //     {
          //         string vid = path.Replace(folderPath, string.Empty);
          //         vid = vid.Replace(".wmv", string.Empty);
          //        
          //     }
          // }
            lstVideos.Items.Add(folderPath);
            lstVideos.SelectedIndex = selectedIndex;
        }

        private void LstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch { }

            int index = lstVideos.SelectedIndex;
            selectedIndex = index;
            video = new Video(label1.Text, false);
            video.Owner = pnlVideo;
            pnlVideo.Size = pnlSize;
            video.Play();
            tmrVideo.Enabled = true;
            btnPlayPause.Text = "Pause";
            video.Ending += Video_Ending;
            lblVideo.Text = lstVideos.Text;
        }
        private void Video_Ending(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextVideo();
                    }));
                }
            });
        }
        private void NextVideo()
        {
            //int index = lstVideos.SelectedIndex;
            //index++;
            //if (index > videoPaths.Length - 1)
            //    index = 0;
            //selectedIndex = index;
            //lstVideos.SelectedIndex = index;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void PreviousVideo()
        {
           // int index = lstVideos.SelectedIndex;
           // index--;
           // if (index == -1)
           //     index = videoPaths.Length - 1;
           // selectedIndex = index;
           // lstVideos.SelectedIndex = index;
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
                tmrVideo.Enabled = true;
                btnPlayPause.Text = "Pause";
            }
            else if (video.Playing)
            {
                video.Pause();
                tmrVideo.Enabled = false;
                btnPlayPause.Text = "Play";
            }
        }

        private void BtnFullscreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            video.Owner = this;
        }

        private void VIDEOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //exit full screen when escape is pressed
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                this.Size = formSize;
                video.Owner = pnlVideo;
                pnlVideo.Size = pnlSize;
            }
        }

        private void TrackVolume_Scroll(object sender, EventArgs e)
        {
            trackVolume.Maximum = 100;
            video.Audio.Volume = trackVolume.Value/trackVolume.Maximum;
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            trackVolume.Visible = !trackVolume.Visible;
        }

        private void TmrVideo_Tick(object sender, EventArgs e)
        {
            
            int currentTime = Convert.ToInt32(video.CurrentPosition);
            //int maxTime = Convert.ToInt32(video.Duration);

            lblVideoPosition.Text = string.Format("{0:00}:{1:00}:{2:00}", currentTime / 3600, (currentTime / 60) % 60, currentTime % 60);
            //+" / " +
            //string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }

        private void Tracktiempo_Scroll(object sender, EventArgs e)
        {
    
        }
    }
}
