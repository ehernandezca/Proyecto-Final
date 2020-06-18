using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;
using NAudio.Wave;
using Prism.Commands;

namespace PROYECTO_IV
{
    class EqualizationDemoViewModel : ViewModelBase, IDisposable
    {
        public static AudioFileReader reader;
        public static WaveOut player;
        public static Ecualizador equalizer;
        public static string selectedFile;
        public static BandaDeEcualizador[] bands;
        public static bool play = false;
        public static bool carpeta = false;

        public ICommand OpenFileCommand { get; private set; }
        public ICommand PlayCommand { get; private set; }
        public ICommand PauseCommand { get; private set; }
        public ICommand StopCommand { get; private set; }

        public EqualizationDemoViewModel(TrackBar trackBar1, TrackBar trackBar2, TrackBar trackBar3,
            TrackBar trackBar4, TrackBar trackBar5, TrackBar trackBar6, TrackBar trackBar7, TrackBar trackBar8)
        {
            PlayCommand = new DelegateCommand(Play);
            OpenFileCommand = new DelegateCommand(OpenFile);
            StopCommand = new DelegateCommand(Stop);
            PauseCommand = new DelegateCommand(Pause);

            float volumen = trackBar1.Value / trackBar1.Maximum;
            float volumen1 = trackBar2.Value / trackBar2.Maximum;
            float volumen2 = trackBar3.Value / trackBar3.Maximum;
            float volumen3 = trackBar4.Value / trackBar4.Maximum;
            float volumen4 = trackBar5.Value / trackBar5.Maximum;
            float volumen5 = trackBar6.Value / trackBar6.Maximum;
            float volumen6 = trackBar7.Value / trackBar7.Maximum;
            float volumen7 = trackBar8.Value / trackBar8.Maximum;

            bands = new BandaDeEcualizador[]
                                    {
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen1, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen2, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen3, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen4, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen5, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen6, Ganancia = 0},
                        new BandaDeEcualizador {Bandaancha = 0.8F, Frecuencia = volumen7, Ganancia = 0}
                                    };
            this.PropertyChanged += OnPropertyChanged;

            if (play == true)
            {

                equalizer = new Ecualizador(reader, bands);

                player.Init(equalizer);
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (equalizer != null) equalizer.Update();
        }

        public float MinimumGain
        {
            get { return -30; }
        }

        public float MaximumGain
        {
            get { return 30; }
        }

        public float Band1
        {
            get { return bands[0].Ganancia; }
            set
            {
                if (bands[0].Ganancia != value)
                {
                    bands[0].Ganancia = value;
                    OnPropertyChanged("Band1");
                }
            }
        }

        public float Band2
        {
            get { return bands[1].Ganancia; }
            set
            {
                if (bands[1].Ganancia != value)
                {
                    bands[1].Ganancia = value;
                    OnPropertyChanged("Band2");
                }
            }
        }

        public float Band3
        {
            get { return bands[2].Ganancia; }
            set
            {
                if (bands[2].Ganancia != value)
                {
                    bands[2].Ganancia = value;
                    OnPropertyChanged("Band3");
                }
            }
        }

        public float Band4
        {
            get { return bands[3].Ganancia; }
            set
            {
                if (bands[3].Ganancia != value)
                {
                    bands[3].Ganancia = value;
                    OnPropertyChanged("Band4");
                }
            }
        }

        public float Band5
        {
            get { return bands[4].Ganancia; }
            set
            {
                if (bands[4].Ganancia != value)
                {
                    bands[4].Ganancia = value;
                    OnPropertyChanged("Band5");
                }
            }
        }

        public float Band6
        {
            get { return bands[5].Ganancia; }
            set
            {
                if (bands[5].Ganancia != value)
                {
                    bands[5].Ganancia = value;
                    OnPropertyChanged("Band6");
                }
            }
        }


        public float Band7
        {
            get { return bands[6].Ganancia; }
            set
            {
                if (bands[6].Ganancia != value)
                {
                    bands[6].Ganancia = value;
                    OnPropertyChanged("Band7");
                }
            }
        }

        public float Band8
        {
            get { return bands[7].Ganancia; }
            set
            {
                if (bands[7].Ganancia != value)
                {
                    bands[7].Ganancia = value;
                    OnPropertyChanged("Band7");
                }
            }
        }

        private void Pause()
        {
            if (player != null)
            {
                player.Pause();
            }
        }

        public static string rutaarchivio = "";

        public static void audioarchivo(string file)
        {
            //OpenFileDialog dialogo;
            //dialogo = new OpenFileDialog();
            //
            //dialogo.Filter = "All Supported Files (*.wav;*.mp3;*.aiff;*.wma;*.flac;*.m4a)|*.wav;*.mp3;*.aiff;*.wma;*.flac;*.m4a|All Files (*.*)|*.*";
            //if (dialogo.ShowDialog() == DialogResult.OK)
            //{
            //ReproductorDeMusica a = new ReproductorDeMusica();
            a.AgregarCancionLista(file);
          //  a.Show();
            // }
        }
       public static frmReproductorDeMusica a = new frmReproductorDeMusica();
        //  public static string Carpeta = "";
        public static void carpetaaudio(string file)
        {
           // DialogoCarpeta = new FolderBrowserDialog();
           

            //if (DialogoCarpeta.ShowDialog() == DialogResult.OK)
            //{


           
            
            a.CargarCarpeta(file);
            a.Show();



            //}
        }


        public static void cargararchivo()
        {
                        
        }

        public static void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Supported Files (*.wav;*.mp3)|*.wav;*.mp3|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog.FileName;
                reader = new AudioFileReader(selectedFile);
                equalizer = new Ecualizador(reader, bands);
                player = new WaveOut();
                player.Init(equalizer);
            }
        }

        public static void Play()
        {
            if (selectedFile == null)
            {
                OpenFile();
            }
            if (selectedFile != null)
            {
                player.Play();
            }
        }

        public static void Stop()
        {
            if (player != null)
            {
                player.Stop();
            }
        }

        public void Dispose()
        {
            if (player != null)
            {
                player.Dispose();
            }
            if (reader != null)
            {
                reader.Dispose();
            }

        }
    }
}