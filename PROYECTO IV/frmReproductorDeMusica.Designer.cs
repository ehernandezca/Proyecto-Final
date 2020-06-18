namespace PROYECTO_IV
{
    partial class frmReproductorDeMusica
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
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblCancion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstReproduccion = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.trkcancion = new System.Windows.Forms.TrackBar();
            this.trkVolumen = new System.Windows.Forms.TrackBar();
            this.tmrReproduccion = new System.Windows.Forms.Timer(this.components);
            this.picCover = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkcancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(346, 23);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(13, 20);
            this.lblArtista.TabIndex = 71;
            this.lblArtista.Text = ".";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(652, 23);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(13, 20);
            this.lblAlbum.TabIndex = 70;
            this.lblAlbum.Text = ".";
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.Location = new System.Drawing.Point(0, 23);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 20);
            this.lblCancion.TabIndex = 69;
            this.lblCancion.Text = ".";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.carpetaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.ArchivoToolStripMenuItem_Click);
            // 
            // carpetaToolStripMenuItem
            // 
            this.carpetaToolStripMenuItem.Name = "carpetaToolStripMenuItem";
            this.carpetaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.carpetaToolStripMenuItem.Text = "Carpeta";
            this.carpetaToolStripMenuItem.Click += new System.EventHandler(this.CarpetaToolStripMenuItem_Click);
            // 
            // lstReproduccion
            // 
            this.lstReproduccion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstReproduccion.HideSelection = false;
            this.lstReproduccion.Location = new System.Drawing.Point(988, 58);
            this.lstReproduccion.Name = "lstReproduccion";
            this.lstReproduccion.Size = new System.Drawing.Size(370, 405);
            this.lstReproduccion.TabIndex = 73;
            this.lstReproduccion.UseCompatibleStateImageBehavior = false;
            this.lstReproduccion.View = System.Windows.Forms.View.Details;
            this.lstReproduccion.DoubleClick += new System.EventHandler(this.LstReproduccion_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1071, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "ECUALIZADOR";
            // 
            // trackBar7
            // 
            this.trackBar7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar7.Location = new System.Drawing.Point(1248, 520);
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar7.Size = new System.Drawing.Size(45, 175);
            this.trackBar7.TabIndex = 93;
            this.trackBar7.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar8
            // 
            this.trackBar8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar8.Location = new System.Drawing.Point(1299, 520);
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(45, 175);
            this.trackBar8.TabIndex = 92;
            this.trackBar8.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar4.Location = new System.Drawing.Point(1095, 520);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 175);
            this.trackBar4.TabIndex = 91;
            this.trackBar4.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar5.Location = new System.Drawing.Point(1146, 520);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 175);
            this.trackBar5.TabIndex = 90;
            this.trackBar5.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar6.Location = new System.Drawing.Point(1197, 520);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(45, 175);
            this.trackBar6.TabIndex = 89;
            this.trackBar6.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.Location = new System.Drawing.Point(1044, 520);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 175);
            this.trackBar3.TabIndex = 88;
            this.trackBar3.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(993, 520);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 175);
            this.trackBar2.TabIndex = 87;
            this.trackBar2.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(942, 520);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 175);
            this.trackBar1.TabIndex = 86;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(819, 614);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(72, 13);
            this.lblTiempo.TabIndex = 102;
            this.lblTiempo.Text = "00:00 / 00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "VOLUMEN";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Location = new System.Drawing.Point(499, 688);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(47, 40);
            this.btnPlay.TabIndex = 95;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.Location = new System.Drawing.Point(451, 688);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(42, 40);
            this.btnAnterior.TabIndex = 100;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.Location = new System.Drawing.Point(552, 688);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(45, 40);
            this.btnSiguiente.TabIndex = 99;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandom.BackColor = System.Drawing.Color.Green;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Location = new System.Drawing.Point(820, 688);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(71, 40);
            this.btnRandom.TabIndex = 98;
            this.btnRandom.Text = "Bucle";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // trkcancion
            // 
            this.trkcancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkcancion.Location = new System.Drawing.Point(0, 630);
            this.trkcancion.Name = "trkcancion";
            this.trkcancion.Size = new System.Drawing.Size(891, 45);
            this.trkcancion.TabIndex = 97;
            this.trkcancion.Scroll += new System.EventHandler(this.Trkcancion_Scroll);
            // 
            // trkVolumen
            // 
            this.trkVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trkVolumen.Location = new System.Drawing.Point(0, 662);
            this.trkVolumen.Name = "trkVolumen";
            this.trkVolumen.Size = new System.Drawing.Size(350, 45);
            this.trkVolumen.TabIndex = 96;
            this.trkVolumen.Scroll += new System.EventHandler(this.TrkVolumen_Scroll);
            // 
            // tmrReproduccion
            // 
            this.tmrReproduccion.Interval = 1000;
            this.tmrReproduccion.Tick += new System.EventHandler(this.TmrReproduccion_Tick);
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(96, 71);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(686, 486);
            this.picCover.TabIndex = 68;
            this.picCover.TabStop = false;
            // 
            // ReproductorDeMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 749);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.trkcancion);
            this.Controls.Add(this.trkVolumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lstReproduccion);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReproductorDeMusica";
            this.Text = "ReproductorDeMusica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkcancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpetaToolStripMenuItem;
        public System.Windows.Forms.ListView lstReproduccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TrackBar trkcancion;
        private System.Windows.Forms.TrackBar trkVolumen;
        private System.Windows.Forms.Timer tmrReproduccion;
    }
}