using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Explorador_de_archivos_proyecto
{
    public partial class frmSaturacion : Form
    {
        private SaturationCorrection filter = new SaturationCorrection();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview1.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }
        public frmSaturacion()
        {
            InitializeComponent();
            saturationBox.Text = filter.AdjustValue.ToString(CultureInfo.InvariantCulture);
            saturationTrackBar.Value = (int)(filter.AdjustValue * 1000);

            filterPreview1.Filter = filter;
        }

        private void saturationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                saturationBox.Text = ((double)saturationTrackBar.Value / 1000).ToString(CultureInfo.InvariantCulture);
        }

        private void saturationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.saturationBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filter.AdjustValue = double.Parse(saturationBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                saturationTrackBar.Value = (int)(filter.AdjustValue * 1000);
                updating = false;

                filterPreview1.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
