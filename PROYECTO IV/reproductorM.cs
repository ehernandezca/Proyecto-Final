using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using TagLib;

namespace PROYECTO_IV
{
    class reproductorM
    {
        static WaveOutEvent wo;
        static AudioFileReader af;
        static bool aceptar = false;
        static bool reproductor = false;
        static string musica;
        public static void ruta(string ruta, Label label1, Label label2, Label label3, TrackBar trackbar, Button btnplay, Timer tiempo, Control a)
        {
           
            a.Show();
            musica = Path.GetFullPath(ruta);
            wo = new WaveOutEvent();
            af = new AudioFileReader(musica);
            trackbar.Maximum = (int)af.TotalTime.TotalSeconds;

            wo.Init(af);

            //btnplay.ImageIndex = 1;
            aceptar = true;
            reproducir(label1, label2, label3, btnplay, trackbar, tiempo);
            TagLib.File file = TagLib.File.Create(ruta);

            label1.Text = ("Titulo:  " + file.Tag.Title);
            label2.Text = ("Album:  " + file.Tag.Album);


            foreach (string artist in file.Tag.AlbumArtists)
                label3.Text = ("Artista: " + artist);



        }

        public static void reproducir(Label label1, Label label2, Label label3, Button btnplay, TrackBar trackbar, Timer tiempo)
        {
            if (wo == null)
            {
                wo = new WaveOutEvent();

            }
            if (af == null)
            {
                OpenFileDialog abrir = new OpenFileDialog();

                if (abrir.ShowDialog() == DialogResult.OK)
                {

                    string path = abrir.FileName;
                    af = new AudioFileReader(path);
                    wo.Init(af);
                    trackbar.Maximum = (int)af.TotalTime.TotalSeconds;

                    //trackbar.Value = 0;
                    aceptar = true;



                    TagLib.File file = TagLib.File.Create(path);

                    label1.Text = ("Titulo:  " + file.Tag.Title);
                    label2.Text = ("Album:  " + file.Tag.Album);


                    foreach (string artist in file.Tag.AlbumArtists)
                        label3.Text = ("Artista: " + artist);
                }

            }

            if (reproductor == false)
            {
                tiempo.Start();
                wo.Play();
                reproductor = true;
                btnplay.ImageIndex = 1;


            }
            else
            {
                wo.Stop();
                reproductor = false;
                btnplay.ImageIndex = 0;
                //btnplay.Text = "PLAY";
            }
        }

        public static void detener(Button btnplay, Label label1, Label label2, Label label3, Label tiemp, Label tiempo2)
        {
            // if (btnplay.Text == "PLAY")
            // {
            //     return;
            // }
            if (reproductor == true)
            {
                wo.Stop();
                wo.Dispose();
                wo = null;
                af.Dispose();
                af = null;
                // btnplay.Text = "PLAY";
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                tiemp.Text = "00:00";
                tiempo2.Text = "00:00";
                reproductor = false;
            }
            else
            {
                if (wo != null)
                {
                    wo.Stop();
                    wo.Dispose();
                    wo = null;
                    af.Dispose();
                    af = null;
                    // btnplay.Text = "PLAY";
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    tiemp.Text = "00:00";
                    tiempo2.Text = "00:00";
                    reproductor = false;
                }
                return;
            }


        }

        public static void volumen(TrackBar trackbar1, CheckBox mute)
        {
            trackbar1.Maximum = 100;
            trackbar1.Minimum = 0;
            ////trackBar1.Value = 100;
            ////Top = OnButtonPlay.Bottom;
            ////trackBar1= new TrackBar(){ Minimum = 0, Maximum = 100, Value = 100, Top = OnButtonPlay.Bottom, TickFrequency = 10 };
            trackbar1.TickFrequency = 10;
            //if (aceptar == true)
            //{
            //    wo.Volume = trackbar1.Value / 100f;
            //}
            if (af != null)
            {
                if (aceptar == true)
                {
                    af.Volume = ((float)trackbar1.Value / (float)trackbar1.Maximum);
                    if (mute.Checked)
                    {
                        mute.Checked = false;
                    }
                }

            }
        }

        public static void tiempo(Timer tiempo, TrackBar trackbar, Label tiemp, Label tiempo2, Button boton)
        {

            if (reproductor == true)
            {
                trackbar.Value = (int)af.CurrentTime.TotalSeconds;
                tiemp.Text = af.CurrentTime.ToString(@"mm\:ss");
                tiempo2.Text = af.TotalTime.ToString(@"mm\:ss");
            }
            else
            {
                if (wo != null)
                {
                    tiempo.Stop();
                    return;
                }
                tiempo.Stop();
                boton.ImageIndex = 0;

                return;
            }

        }

        public static void mute(CheckBox mute, TrackBar trackbar)
        {
            if (mute.Checked)
            {
                af.Volume = 0.0f;
            }
            else
            {
                af.Volume = ((float)trackbar.Value / (float)trackbar.Maximum);
            }
        }

        public static void trackbar2(TrackBar track)
        {
            if (af != null)
            {
                af.CurrentTime = TimeSpan.FromSeconds(track.Value);
            }
        }

        public static void trackbar1(TrackBar track)
        {
            if (af != null)
            {
                af.Volume = (float)track.Value / (float)track.Maximum;
            }
        }
    }
}