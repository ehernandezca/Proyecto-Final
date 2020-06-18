using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace PROYECTO_IV
{
    public partial class frmword : Form
    {
        int i = 16;
        Microsoft.Office.Interop.Word.Application objword;
        Paragraph objpara;
        System.Drawing.Font fuentediseño;
        bool cursiva = false;
        bool subraydo = false;
        bool negrita = false;

        public frmword()
        {
            InitializeComponent();
            textBox1.Text = i + "";
            txtdocumento.Focus();
        }

        private void Btnmenos_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                return;
            }
            i -= 2;
            textBox1.Text = i + "";
            fuentediseño = new System.Drawing.Font("Arial", i);
            txtdocumento.Font = fuentediseño;
        }

        private void Btnmas_Click(object sender, EventArgs e)
        {
            i += 2;
            textBox1.Text = i + "";
            fuentediseño = new System.Drawing.Font("Arial", i);
            txtdocumento.Font = fuentediseño;
        }

        private void Btnnegrita_Click(object sender, EventArgs e)
        {
            if (negrita == false)
            {
                btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                if (subraydo == true)
                {
                    if (cursiva == true)
                    {
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        negrita = true;
                    }
                    else
                    {
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold);
                        negrita = true;
                    }
                }
                else
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic);
                        negrita = true;
                    }
                    else
                    {
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold);
                        negrita = true;
                    }
                }
            }
            else
            {
                btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                if (subraydo == true)
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Italic);
                        negrita = false;
                    }
                    else
                    {
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        negrita = false;
                    }
                }
                else
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        negrita = false;
                    }
                    else
                    {
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Regular);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Regular);
                        negrita = false;
                    }
                }
            }
        }

        private void Btnsubrayado_Click(object sender, EventArgs e)
        {
            if (subraydo == false)
            {
                btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                if (negrita == true)
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        subraydo = true;
                    }
                    else
                    {
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Bold);
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        subraydo = true;
                    }
                }
                else
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline | FontStyle.Italic);
                        subraydo = true;
                    }
                    else
                    {
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        subraydo = true;
                    }
                }
            }
            else
            {
                btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                if (negrita == true)
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);

                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);

                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);

                        subraydo = false;
                        return;
                    }
                    else
                    {
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Regular | FontStyle.Bold);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Regular | FontStyle.Bold);
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        subraydo = false;
                    }
                }
                else
                {
                    if (cursiva == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        subraydo = false;
                    }
                    else
                    {
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Regular);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Regular);
                        subraydo = false;
                    }
                }
            }
        }

        private void Btncursiva_Click(object sender, EventArgs e)
        {
            if (cursiva == false)
            {
                btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Italic);
                if (negrita == true)
                {
                    if (subraydo == true)
                    {
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        cursiva = true;
                    }
                    else
                    {
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Italic);
                        cursiva = true;
                    }
                }
                else
                {
                    if (subraydo == true)
                    {
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Italic | FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Italic | FontStyle.Underline);
                        cursiva = true;
                    }
                    else
                    {
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Italic);
                        cursiva = true;
                    }
                }
            }
            else
            {
                btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                if (negrita == true)
                {
                    if (subraydo == true)
                    {
                        btncursiva.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);

                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold | FontStyle.Underline);
                        cursiva = false;
                    }
                    else
                    {
                        btnnegrita.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Bold);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Bold);
                        cursiva = false;
                    }
                }
                else
                {
                    if (subraydo == true)
                    {
                        btnsubrayado.Font = new System.Drawing.Font(Font, FontStyle.Underline);
                        fuentediseño = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i, FontStyle.Underline);
                        cursiva = false;
                    }
                    else
                    {
                        fuentediseño = new System.Drawing.Font("Arial", i);
                        txtdocumento.Font = new System.Drawing.Font("Arial", i);
                        cursiva = false;
                    }
                }
            }
        }

        private void GuardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtdocumento.Text = "";
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Documento de Word|*.docx";
            if (abrir.ShowDialog() == DialogResult.OK)
            {

                object missing = Type.Missing;
                object visible = true;
                object readOnly = false;
                object save = false;
                object filename = abrir.FileName;
                object newTemplate = false;
                object docType = 0;

                Document document;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                document = application.Documents.Open(abrir.FileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                document.ActiveWindow.Selection.WholeStory();
                document.ActiveWindow.Selection.Copy();
                IDataObject dataObject = Clipboard.GetDataObject();
                txtdocumento.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                application.Quit(ref missing, ref missing, ref missing);
            }
        }
        public void abrir(string abrir)
        {
            txtdocumento.Text = "";
            object missing = Type.Missing;
            object visible = true;
            object readOnly = false;
            object save = false;
            object filename = abrir;
            object newTemplate = false;
            object docType = 0;

            Document document;
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            document = application.Documents.Open(abrir, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            txtdocumento.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            application.Quit(ref missing, ref missing, ref missing);

        }
        private void AbrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de Word|*.docx";
            guardar.DefaultExt = "docx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {

                //crear aplicacion
                objword = new Microsoft.Office.Interop.Word.Application();
                objword.Visible = true;
                objword.WindowState = WdWindowState.wdWindowStateNormal;

                //crear documento
                Document doc = objword.Documents.Add();

                //agregar

                if (negrita == true)
                {
                    objword.Selection.Font.Bold = 1;
                }

                if (subraydo == true)
                {
                    objword.Selection.Font.Underline = WdUnderline.wdUnderlineSingle;
                }

                if (cursiva == true)
                {
                    objword.Selection.Font.Italic = 1;
                }

                //COLOR DE LETRA
                // objword.Selection.Font.Color = fuente.Color;

                //TAMAÑO
                objword.Selection.Font.Size = i;

                //objword.Selection.Font.Color = WdColor.wdColorRed;
                objpara = doc.Paragraphs.Add();
                objpara.Range.Text = txtdocumento.Text;

                //            objword.Selection.Font = Microsoft.Office.Interop.Word.
                doc.SaveAs2(guardar.FileName);
                doc.Close();
                objword.Quit();
                txtdocumento.Text = "";
                txtdocumento.Focus();

            }
        }
    }
}
