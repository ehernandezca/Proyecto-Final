using System;
using System.Windows.Forms;

namespace PROYECTO_IV
{
    public partial class frmpdf : Form
    {
        public frmpdf()
        {
            InitializeComponent();
        }
        private int _zoom = 100;

        private void Btnabrir_Click(object sender, EventArgs e)
        {
            pdfDocumentViewer1.Text = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF document (*.pdf)|*.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string pdfFile = dialog.FileName;
                    this.pdfDocumentViewer1.LoadFromFile(pdfFile);
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnZoomIn.Enabled = true;
            btnZoomOut.Enabled = true;
            btnHandTool.Enabled = true;
            comBox.Enabled = true;
            combZoom.Enabled = true;
        }

        public void abrir(string pdfFile)
        {
            pdfDocumentViewer1.Text = "";
            pdfDocumentViewer1.LoadFromFile(pdfFile);
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnZoomIn.Enabled = true;
            btnZoomOut.Enabled = true;
            btnHandTool.Enabled = true;
            comBox.Enabled = true;
            combZoom.Enabled = true;
        }

        private void Apppdf_Load(object sender, EventArgs e)
        {
            int[] intZooms = new Int32[] { 25, 50, 75, 100, 125, 150 };
            foreach (int zoom in intZooms)
            {
                this.combZoom.Items.Add(zoom.ToString());
            }
            this.combZoom.SelectedIndex = 3;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                this.pdfDocumentViewer1.PrintDoc();
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                if (currentPage != 1)
                {
                    this.pdfDocumentViewer1.GoToFirstPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the first!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {

                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;

                if (currentPage > 1)
                {
                    this.pdfDocumentViewer1.GoToPreviousPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the first!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                int totalPage = this.pdfDocumentViewer1.PageCount;
                if (currentPage < totalPage)
                {
                    this.pdfDocumentViewer1.GoToNextPage();

                }
                else
                {
                    MessageBox.Show("Current page is already the last!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int currentPage = this.pdfDocumentViewer1.CurrentPageNumber;
                int totalPage = this.pdfDocumentViewer1.PageCount;
                if (currentPage != totalPage)
                {
                    this.pdfDocumentViewer1.GoToLastPage();
                }
                else
                {
                    MessageBox.Show("Current page is already the last!", "Spire.PdfViewer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PdfDocumentViewer1_PageNumberChanged(object sender, EventArgs args)
        {
            if (this.comBox.Items.Count <= 0)
                return;
            if (this.pdfDocumentViewer1.CurrentPageNumber != this.comBox.SelectedIndex + 1)
            {
                this.comBox.SelectedIndex = this.pdfDocumentViewer1.CurrentPageNumber - 1;
            }
        }

        private void ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucePage = this.pdfDocumentViewer1.CurrentPageNumber;
            int targetPage = this.comBox.SelectedIndex + 1;
            if (soucePage != targetPage)
            {
                this.pdfDocumentViewer1.GoToPage(targetPage);
            }
        }

        private void PdfDocumentViewer1_PdfLoaded(object sender, EventArgs args)
        {
            this.comBox.Items.Clear();
            int totalPage = this.pdfDocumentViewer1.PageCount;

            for (int i = 1; i <= totalPage; i++)
            {
                this.comBox.Items.Add(i.ToString());
            }

            this.comBox.SelectedIndex = 0;
        }

        private void BtnHandTool_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.IsDocumentLoaded)
            {
                this.pdfDocumentViewer1.EnableHandTool();
            }
            button2.Visible = true;
            btnHandTool.Visible = false;
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int delta = 10;
                this._zoom += delta;
                this.pdfDocumentViewer1.ZoomTo(this._zoom);
            }
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int delta = 5;
                this._zoom -= delta;
                if (this._zoom < 0)
                    this._zoom = 0;
                this.pdfDocumentViewer1.ZoomTo(this._zoom);
            }
        }

        private void CombZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.pdfDocumentViewer1.PageCount > 0)
            {
                int zoomValue = Int32.Parse(this.combZoom.SelectedItem.ToString());
                this.pdfDocumentViewer1.ZoomTo(zoomValue);
            }
        }
    }
}
