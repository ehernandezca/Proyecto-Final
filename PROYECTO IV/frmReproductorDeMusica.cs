using NAudio.Wave;
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

namespace PROYECTO_IV
{
    public partial class frmReproductorDeMusica : Form
    {
        TagLib.File Archivo;
        int currentTrack;
        int[] arreglo;


        public frmReproductorDeMusica()
        {
            InitializeComponent();
            picCover.SizeMode = PictureBoxSizeMode.StretchImage;
            lstReproduccion.View = View.Details;
            lstReproduccion.FullRowSelect = true;
            lstReproduccion.HideSelection = false;
            lstReproduccion.Columns.Add("Titulo");
            lstReproduccion.Columns.Add("Artista");
            lstReproduccion.Columns.Add("Album");
            lstReproduccion.Columns.Add("Duración");
            lstReproduccion.Columns[0].Width = 100;
            lstReproduccion.Columns[1].Width = 100;
            lstReproduccion.Columns[2].Width = 100;
            lstReproduccion.Columns[3].Width = 75;
            trkVolumen.Minimum = 0;
            trkVolumen.Maximum = 100;
            trkVolumen.LargeChange = 10;
            trkVolumen.SmallChange = 1;
            trkVolumen.Value = 50;
            trkcancion.LargeChange = 10;
            trkcancion.SmallChange = 1;
            trkcancion.Minimum = 0;
            trkcancion.Maximum = 200;
            currentTrack = 0;
            trackBar1.Maximum = 100;
            trackBar2.Maximum = 200;
            trackBar3.Maximum = 400;
            trackBar4.Maximum = 800;
            trackBar5.Maximum = 1200;
            trackBar6.Maximum = 2400;
            trackBar7.Maximum = 4800;
            trackBar8.Minimum = 9600;
            trackBar1.Minimum = 0;
            trackBar2.Minimum = 0;
            trackBar3.Minimum = 0;
            trackBar4.Minimum = 0;
            trackBar5.Minimum = 0;
            trackBar6.Minimum = 0;
            trackBar7.Minimum = 0;
            trackBar8.Minimum = 0;
            trackBar1.Value = 50;
            trackBar2.Value = 100;
            trackBar3.Value = 200;
            trackBar4.Value = 400;
            trackBar5.Value = 600;
            trackBar6.Value = 1200;
            trackBar7.Value = 2400;
            trackBar8.Value = 4800;
        }
        bool cancionencurso = false;

        public void AgregarCancionLista(string NombreArchivo)
        {
          
            Archivo = TagLib.File.Create(NombreArchivo);
            ListViewItem renglon = new ListViewItem(Archivo.Tag.Title);
            renglon.SubItems.Add(Archivo.Tag.FirstAlbumArtist);
            renglon.SubItems.Add(Archivo.Tag.Album);
            renglon.SubItems.Add(Archivo.Properties.Duration.ToString());
            renglon.SubItems.Add(NombreArchivo);
            lstReproduccion.Items.Add(renglon);
            ConstruirArreglo(lstReproduccion.Items.Count);
        }

        private void CloseWaveOut()
        {
            tmrReproduccion.Stop();
            trkcancion.Value = 0;
            if (EqualizationDemoViewModel.player != null)
            {
                EqualizationDemoViewModel.player.Pause();

            }
            if (EqualizationDemoViewModel.player != null)
            {
                EqualizationDemoViewModel.player.Dispose();
                EqualizationDemoViewModel.player = null;
            }
        }

        private void reproducir()
        {


            CloseWaveOut();
            EqualizationDemoViewModel.player = new WaveOut();
            if (lstReproduccion.Items.Count == 0)
            {
                return;
            }
            EqualizationDemoViewModel.reader = new AudioFileReader(lstReproduccion.Items[arreglo[currentTrack]].SubItems[4].Text);
            try
            {
                Archivo = TagLib.File.Create(lstReproduccion.Items[arreglo[currentTrack]].SubItems[4].Text);
                byte[] lol = (byte[])Archivo.Tag.Pictures[0].Data.Data;
                picCover.Image = Image.FromStream(new MemoryStream(lol)).GetThumbnailImage(300, 300, null, System.IntPtr.Zero);

            }
            catch (Exception)
            {
                picCover.Image = Image.FromFile(@"C:\Users\Norbe\OneDrive\Escritorio\proyecto\ondas.jpg");
            }
            finally
            {

                EqualizationDemoViewModel.equalizer = new Ecualizador(EqualizationDemoViewModel.reader, EqualizationDemoViewModel.bands);
                EqualizationDemoViewModel.player.Init(EqualizationDemoViewModel.reader);
                EqualizationDemoViewModel.player.Volume = trkVolumen.Value / 100F;
                trkcancion.Maximum = (int)EqualizationDemoViewModel.reader.TotalTime.TotalSeconds;
                trkcancion.Value = trkcancion.Minimum;
                lblCancion.Text = Archivo.Tag.Title;
                lblAlbum.Text = "Album: " + Archivo.Tag.Album;
                if (lblAlbum.Text == "Album: ")
                {
                    lblAlbum.Text = "Album desconocido ";
                }

                lblArtista.Text = "Artista: " + Archivo.Tag.FirstAlbumArtist;
                if (lblArtista.Text == "Artista: ")
                {
                    lblArtista.Text = "Artista desconocido";
                }


                lstReproduccion.Items[arreglo[currentTrack]].Selected = true;
                lstReproduccion.Focus();
                EqualizationDemoViewModel.player.Play();
                tmrReproduccion.Start();
                btnPlay.Text = "STOP";
                cancionencurso = true;
            }
        }

        public void CargarCarpeta(string NombreCarpeta)
        {
           
            DirectoryInfo Folder = new DirectoryInfo(NombreCarpeta);
            if (Folder.GetDirectories() != null)
            {
                foreach (DirectoryInfo Dir in Folder.GetDirectories())
                {
                    CargarCarpeta(Dir.FullName);
                }

                foreach (FileInfo file in Folder.GetFiles())
                {
                    if (file.Extension == ".mp3")
                    {
                        Archivo = TagLib.File.Create(file.FullName);
                        ListViewItem renglon = new ListViewItem(Archivo.Tag.Title);
                        renglon.SubItems.Add(Archivo.Tag.FirstAlbumArtist);
                        renglon.SubItems.Add(Archivo.Tag.Album);
                        renglon.SubItems.Add(Archivo.Properties.Duration.ToString());
                        renglon.SubItems.Add(file.FullName);
                        lstReproduccion.Items.Add(renglon);

                    }

                }
            }

            ConstruirArreglo(lstReproduccion.Items.Count);
            boton();
        }

        private void InicializarArreglo()
        {
            if (lstReproduccion.Items.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = i;
                }
            }
        }

        private void ConstruirArreglo(int n)
        {
            arreglo = new int[n];
            InicializarArreglo();
        }

        private void DesordenarArreglo()
        {
            if (lstReproduccion.Items.Count == 0)
            {
                return;
            }
            else
            {
                Random aleatorio = new Random();
                int a = 0;
                for (int i = arreglo.Length - 1; i > 0; i--)
                {
                    int x = aleatorio.Next(i - 1);
                    a = arreglo[i];
                    arreglo[i] = arreglo[x];
                    arreglo[x] = a;

                }
            }
        }

        private void TmrReproduccion_Tick(object sender, EventArgs e)
        {
            try
            {
                trkcancion.Value += 1;
                lblTiempo.Text = EqualizationDemoViewModel.reader.CurrentTime.ToString("mm\\:ss") + " / " + EqualizationDemoViewModel.reader.TotalTime.ToString("mm\\:ss");
            }
            catch (ArgumentOutOfRangeException)
            {
                tmrReproduccion.Stop();
                lstReproduccion.Items[arreglo[currentTrack]].Selected = false;
                if (currentTrack < lstReproduccion.Items.Count - 1)
                {
                    currentTrack++;
                }
                else
                {
                    currentTrack = 0;
                }
                reproducir();
            }
        }

        private void boton()
        {
            if (lstReproduccion.Items.Count > 0)
            {

                if (cancionencurso == false)
                {
                    EqualizationDemoViewModel ecualizar = new EqualizationDemoViewModel(trackBar1, trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7, trackBar8);
                    reproducir();

                }
                else
                {
                    EqualizationDemoViewModel.player.Stop();
                    tmrReproduccion.Stop();
                    trkcancion.Value = 0;
                    cancionencurso = false;
                    btnPlay.Text = "PLAY";

                }
            }
        }


        protected void BtnPlay_Click(object sender, EventArgs e)
        {
           
            if (lstReproduccion.Items.Count > 0)
            {

                if (cancionencurso == false)
                {
                    EqualizationDemoViewModel ecualizar = new EqualizationDemoViewModel(trackBar1, trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7, trackBar8);
                    reproducir();

                }
                else
                {
                    EqualizationDemoViewModel.player.Stop();
                    tmrReproduccion.Stop();
                    trkcancion.Value = 0;
                    cancionencurso = false;
                    btnPlay.Text = "PLAY";

                }
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (lstReproduccion.Items.Count > 0)
            {
                lstReproduccion.Items[arreglo[currentTrack]].Selected = false;

                if (currentTrack == 0)
                {
                    currentTrack = lstReproduccion.Items.Count - 1;
                }
                else
                {
                    currentTrack--;
                }
                reproducir();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (lstReproduccion.Items.Count > 0)
            {


                lstReproduccion.Items[arreglo[currentTrack]].Selected = false;
                if (currentTrack == lstReproduccion.Items.Count - 1)
                {
                    currentTrack = 0;
                }
                else
                {
                    currentTrack++;
                }
                reproducir();
            }
        }

        private void Trkcancion_Scroll(object sender, EventArgs e)
        {
            EqualizationDemoViewModel.reader.CurrentTime = TimeSpan.FromSeconds(trkcancion.Value);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            if (btnRandom.Text == "Bucle")
            {
                btnRandom.Text = "Aleatorio";
                btnRandom.BackColor = Color.Green;
                DesordenarArreglo();

            }
            else
            {
                btnRandom.Text = "Bucle";
                btnRandom.BackColor = Color.Green;
                InicializarArreglo();
            }
        }

        private void LstReproduccion_DoubleClick(object sender, EventArgs e)
        {
            if (lstReproduccion.SelectedItems.Count != 0)
            {
                currentTrack = lstReproduccion.SelectedIndices[0];
                reproducir();
            }
        }

        private void TrkVolumen_Scroll(object sender, EventArgs e)
        {
            try
            {
                EqualizationDemoViewModel.player.Volume = trkVolumen.Value / 100F;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }


       


        private void ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCancionLista(EqualizationDemoViewModel.rutaarchivio);
            ConstruirArreglo(lstReproduccion.Items.Count);
        }

        private void CarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CargarCarpeta(EqualizationDemoViewModel.Carpeta);
            ConstruirArreglo(lstReproduccion.Items.Count);
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            EqualizationDemoViewModel ecualizar = new EqualizationDemoViewModel(trackBar1, trackBar2, trackBar3, trackBar4, trackBar5, trackBar6, trackBar7, trackBar8);
        }
    }
}
