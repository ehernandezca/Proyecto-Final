namespace PROYECTO_IV
{
    partial class frmvideo
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
            this.components = new System.ComponentModel.Container();
            this.btnVolume = new System.Windows.Forms.Button();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblVideoPosition = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tracktiempo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.pnlVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(488, 383);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(75, 23);
            this.btnVolume.TabIndex = 30;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(645, 373);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(153, 45);
            this.trackVolume.TabIndex = 29;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVolume.Visible = false;
            this.trackVolume.Scroll += new System.EventHandler(this.TrackVolume_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(238, 383);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 383);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // lblVideoPosition
            // 
            this.lblVideoPosition.AutoSize = true;
            this.lblVideoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoPosition.Location = new System.Drawing.Point(814, 390);
            this.lblVideoPosition.Name = "lblVideoPosition";
            this.lblVideoPosition.Size = new System.Drawing.Size(114, 16);
            this.lblVideoPosition.TabIndex = 26;
            this.lblVideoPosition.Text = "00:00:00 / 00:00:00";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(124, 383);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 25;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Location = new System.Drawing.Point(363, 383);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullscreen.TabIndex = 24;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.BtnFullscreen_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(120, 421);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(678, 65);
            this.lblVideo.TabIndex = 23;
            this.lblVideo.Text = "Video Name";
            this.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.Location = new System.Drawing.Point(696, 12);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(203, 472);
            this.lstVideos.TabIndex = 22;
            this.lstVideos.Visible = false;
            this.lstVideos.SelectedIndexChanged += new System.EventHandler(this.LstVideos_SelectedIndexChanged);
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.tracktiempo);
            this.pnlVideo.Location = new System.Drawing.Point(12, 12);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(916, 355);
            this.pnlVideo.TabIndex = 21;
            // 
            // tmrVideo
            // 
            this.tmrVideo.Tick += new System.EventHandler(this.TmrVideo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // tracktiempo
            // 
            this.tracktiempo.Location = new System.Drawing.Point(0, 310);
            this.tracktiempo.Name = "tracktiempo";
            this.tracktiempo.Size = new System.Drawing.Size(913, 45);
            this.tracktiempo.TabIndex = 32;
            this.tracktiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tracktiempo.Visible = false;
            this.tracktiempo.Scroll += new System.EventHandler(this.Tracktiempo_Scroll);
            // 
            // VIDEOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblVideoPosition);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnFullscreen);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.pnlVideo);
            this.Name = "VIDEOS";
            this.Text = "VIDEOS";
            this.Load += new System.EventHandler(this.VIDEOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VIDEOS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.pnlVideo.ResumeLayout(false);
            this.pnlVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracktiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblVideoPosition;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.Timer tmrVideo;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tracktiempo;
    }
}