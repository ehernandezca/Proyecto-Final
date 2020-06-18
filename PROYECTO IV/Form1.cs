using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;


namespace PROYECTO_IV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carpetas();
            textBox2.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            btncancelar.Visible = false;
            txtcambiarnombre.Visible = false;
            label3.Visible = false;
            btncambiar.Visible = false;
            btncann.Visible = false;
        }
        private void carpetas()
        {
            TreeNode nodoE, nodoI, nodoD, nododoc, nodomusica, nodovideos;

            DirectoryInfo escritorio = new DirectoryInfo(@"C:\Users\Norbe\Desktop");
            DirectoryInfo imagenes = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Imágenes");
            DirectoryInfo descargas = new DirectoryInfo(@"C:\Users\Norbe\Downloads");
            DirectoryInfo documentos = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Documents");
            DirectoryInfo musica = new DirectoryInfo(@"C:\Users\Norbe\Music");
            DirectoryInfo videos = new DirectoryInfo(@"C:\Users\Norbe\Videos");


            if (escritorio.Exists)
            {
                nodoE = new TreeNode("Escritorio");
                nodoE.Tag = escritorio;
                nodoE.ImageIndex = 0;
                nodoE.SelectedImageIndex = 0;
                mascarpetas(escritorio.GetDirectories(), nodoE);
                treeView1.Nodes.Add(nodoE);
            }
            if (imagenes.Exists)
            {
                nodoI = new TreeNode("Imagenes");
                nodoI.Tag = imagenes;
                nodoI.ImageIndex = 2;
                nodoI.SelectedImageIndex = 2;
                mascarpetas(imagenes.GetDirectories(), nodoI);
                treeView1.Nodes.Add(nodoI);
            }
            if (descargas.Exists)
            {
                nodoD = new TreeNode("Descargas");
                nodoD.Tag = descargas;
                nodoD.SelectedImageIndex = 3;
                nodoD.ImageIndex = 3;
                mascarpetas(descargas.GetDirectories(), nodoD);
                treeView1.Nodes.Add(nodoD);
            }
            if (documentos.Exists)
            {
                nododoc = new TreeNode("Documentos");
                nododoc.Tag = documentos;
                nododoc.SelectedImageIndex = 4;
                nododoc.ImageIndex = 4;
                mascarpetas(documentos.GetDirectories(), nododoc);
                treeView1.Nodes.Add(nododoc);

            }
            if (musica.Exists)
            {
                nodomusica = new TreeNode("Musica");
                nodomusica.Tag = musica;
                nodomusica.SelectedImageIndex = 5;
                nodomusica.ImageIndex = 5;
                mascarpetas(musica.GetDirectories(), nodomusica);
                treeView1.Nodes.Add(nodomusica);
            }
            if (videos.Exists)
            {
                nodovideos = new TreeNode("Videos");
                nodovideos.Tag = videos;
                nodovideos.SelectedImageIndex = 8;
                nodovideos.ImageIndex = 8;
                mascarpetas(videos.GetDirectories(), nodovideos);
                treeView1.Nodes.Add(nodovideos);
            }

        }

        public void subcarpeta(DirectoryInfo[] subcar, TreeNode nodo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subcar)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                // aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    mascarpetas(subSubDirs, aNode);
                }
                nodo.Nodes.Add(aNode);
            }
        }

        private void mascarpetas(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    mascarpetas(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            datoscarpeta.cargardenuevo(treeView1, listView1);
        }
        
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DirectoryInfo path;
            string ruta = treeView1.SelectedNode.FullPath;
            switch (ruta)
            {
                case "Escritorio":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Desktop");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;

                case "Imagenes":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Imágenes");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;

                case "Descargas":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Downloads");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;

                case "Documentos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Documents");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;

                case "Musica":

                    path = new DirectoryInfo(@"C:\Users\Norbe\Music");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;

                case "Videos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Videos");
                    datoscarpeta.abrirarchivo(path, listView1, txtruta);
                    break;
            }

        }

        private void NUEVOEXPLORADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void CERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CARPETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListViewItem a = new ListViewItem();
            a = listView1.FindItemWithText(textBox1.Text);
            a.ForeColor = Color.Red;
            a.EnsureVisible();
        }

        private void ListView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.BackColor = Color.White;
            }
            e.Item.BackColor = Color.LightBlue;
        }

        private void REPRODUCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReproductorDeMusica a = new frmReproductorDeMusica();
            a.Show();
            //REPRODUCTOR musica = new REPRODUCTOR();
            //musica.Show();
        }
       // List<string> listaderuta = new List<string>();
             
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a;
          //  listaderuta.Add("");

            DirectoryInfo path;
            string ruta = treeView1.SelectedNode.FullPath;
         
            switch (ruta)
            {
                case "Escritorio":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Desktop");
                    txtruta.Text = path.FullName;

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text=path+"\\"+a;
                       // if (!listaderuta.Contains("\\" + listItem.Text))
                        //{
                        //    listaderuta.Add("\\" + listItem.Text);
                        //}
                        //else
                        //{
                        //    return;
                        //}
                       //
                       // string concatenar = "";
                       // foreach (var item in listaderuta)
                       // {
                       //     if (item == path.Name)
                       //     {
                       //         item.Replace(path.Name, "");
                       //     }
                       //     concatenar += item;
                       //     txtruta.Text = path + concatenar;
                       //
                       // }
                    }
                    break;

                case "Imagenes":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Imágenes");

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text = path + "\\" + a;
                    }
                    break;

                case "Descargas":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Downloads");

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text = path + "\\" + a;
                    }
                    break;

                case "Documentos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Documents");

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text = path + "\\" + a;
                    }
                    break;

                case "Musica":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Music");

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text = path + "\\" + a;
                    }
                    break;

                case "Videos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Videos");

                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem listItem = listView1.SelectedItems[0];

                        a = listItem.Text;
                        txtruta.Text = path + "\\" + a;
                    }
                    break;
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string a;
            DirectoryInfo path;
            string ruta = treeView1.SelectedNode.FullPath;

            switch (ruta)
            {
                case "Escritorio":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Desktop");
                    txtruta.Text = path.FullName;
                    break;

                case "Imagenes":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Imágenes");
                    txtruta.Text = path.FullName;
                    break;

                case "Descargas":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Downloads");
                    txtruta.Text = path.FullName;
                    break;

                case "Documentos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Documents");
                    txtruta.Text = path.FullName;
                    break;

                case "Musica":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Music");
                    txtruta.Text = path.FullName;
                    break;

                case "Videos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Videos");
                    txtruta.Text = path.FullName;
                    break;
            }
        }

        private void WORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotas w = new frmnotas();
            w.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtruta.Text))
            {
                Directory.CreateDirectory(txtruta.Text + "\\" + textBox2.Text);
                textBox2.Visible = false;
                button1.Visible = false;
                label2.Visible = false;
                btncancelar.Visible = false;
            }

            datoscarpeta.cargardenuevo(treeView1, listView1);


        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult dr = MessageBox.Show("¿Desea eliminar el archivo seleccionado?", "ELIMINAR", MessageBoxButtons.OKCancel);
            DialogResult seguro = MessageBox.Show("¿Estas seguro?", "ELIMINAR", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (seguro == DialogResult.OK)
                {

                    if (listView1.SelectedItems.Count > 0)
                    {
                        eliminarToolStripMenuItem.Enabled = true;
                        if (File.Exists(txtruta.Text))
                        {
                            FileInfo info = new FileInfo(txtruta.Text);
                            info.Attributes = FileAttributes.Normal;
                            File.Delete(txtruta.Text);
                        }

                        if (Directory.Exists(txtruta.Text))
                        {
                            DirectoryInfo info = new DirectoryInfo(txtruta.Text);
                            info.Attributes = FileAttributes.Normal;
                            info.Delete(true);
                        }

                    }
                }
            }
           
            else
            {
                return;
            }

            datoscarpeta.cargardenuevo(treeView1, listView1);

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            btncancelar.Visible = false;
        }

        private void BlocDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotas n = new frmnotas();
            n.txtruta.Text = txtruta.Text;
            n.Show();

        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                eliminarToolStripMenuItem.Enabled = true;
                crearCarpetaToolStripMenuItem.Enabled = true;
                tamañoToolStripMenuItem.Enabled = true;
                acomodarDatosPorCarpetaToolStripMenuItem.Enabled = false;
                cambiarNombreToolStripMenuItem.Enabled = true;
            }
            else
            {
                eliminarToolStripMenuItem.Enabled = false;
                crearCarpetaToolStripMenuItem.Enabled = false;
                tamañoToolStripMenuItem.Enabled = false;
                acomodarDatosPorCarpetaToolStripMenuItem.Enabled = true;
                cambiarNombreToolStripMenuItem.Enabled = false;
            }
        }

        private void CarpetaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button1.Visible = true;
            label2.Visible = true;
            btncancelar.Visible = true;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void CrearCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpetas = new FolderBrowserDialog();
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listView1.SelectedItems[0];
                string a = listItem.Text;

                if (File.Exists(txtruta.Text))
                {
                    FileInfo info = new FileInfo(txtruta.Text);
                    info.Attributes = FileAttributes.Normal;


                    MessageBox.Show("SELECCIONA LA CARPETA DONDE DESEA COPIAR EL ARCHIVO");

                    if (carpetas.ShowDialog() == DialogResult.OK)
                    {
                        info.CopyTo(carpetas.SelectedPath + "\\" + a);
                    }
                }
            }

            datoscarpeta.cargardenuevo(treeView1, listView1);
        }

        private void TamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(txtruta.Text);
            DirectoryInfo infodir = new DirectoryInfo(txtruta.Text);

            if (info.Exists)
            {
                double bytes = info.Length;
                double kb = bytes * 1 / 1025;
                double mb = kb / 1024;
                double gb = mb / 1024;
                if (info.Length < 1024)
                {
                    MessageBox.Show("Tamaño: " + bytes + " bytes (" + bytes + " bytes)");
                    return;
                }

                if (info.Length <= 1048576)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(kb, 2) + " KB (" + bytes + " bytes)");
                    return;
                }
                if (info.Length <= 1073741824)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(mb) + " MB (" + bytes + " bytes)");
                    return;
                }
                if (info.Length <= 1099511627776)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(gb, 2) + " GB (" + bytes + " bytes)");
                    return;
                }
            }
            else if (infodir.Exists)
            {
                double suma = 0;
                foreach (FileInfo item in infodir.GetFiles())
                {
                    double bytes = item.Length;
                    suma += bytes;
                }

                double kb = suma * 1 / 1025;
                double mb = kb / 1024;
                double gb = mb / 1024;

                if (suma < 1024)
                {
                    MessageBox.Show("Tamaño: " + suma + " bytes (" + suma + " bytes)");
                    return;
                }

                if (suma <= 1048576)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(kb, 2) + " KB (" + suma + " bytes)");
                    return;
                }
                if (suma <= 1073741824)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(mb) + " MB (" + suma + " bytes)");
                    return;
                }
                if (suma <= 1099511627776)
                {
                    MessageBox.Show("Tamaño: " + Math.Round(gb, 2) + " GB (" + suma + " bytes)");
                    return;
                }
            }
        }

        private void AcomodarDatosPorCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea acomodar los archivos por carpeta?", "ACOMODAR ARCHIVOS", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                AcomodarDatos.acomodar(txtruta.Text);
            }
            else
            {
                return;
            }
            datoscarpeta.cargardenuevo(treeView1, listView1);
        }

        private void CambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtcambiarnombre.Visible = true;
            label3.Visible = true;
            btncambiar.Visible = true;
            btncann.Visible = true;
            txtcambiarnombre.Focus();
        }

        private void Btncambiar_Click(object sender, EventArgs e)
        {
            FileInfo archivo = new FileInfo(txtruta.Text);
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listView1.SelectedItems[0];
                string a = listItem.Text;
                string extension = archivo.Extension;
                string cambiar = archivo.ToString().Replace(archivo.Name, "");

                archivo.MoveTo(cambiar + "\\" + txtcambiarnombre.Text+extension);
                txtruta.Text = cambiar;
            }
            txtcambiarnombre.Visible = false;
            label3.Visible = false;
            btncambiar.Visible = false;
            btncann.Visible = false;
            txtcambiarnombre.Text = "";
            datoscarpeta.cargardenuevo(treeView1, listView1);
        }

        private void Btncann_Click(object sender, EventArgs e)
        {
            txtcambiarnombre.Visible = false;
            label3.Visible = false;
            btncambiar.Visible = false;
            btncann.Visible = false;
            txtcambiarnombre.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReproductorDeMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReproductorDeMusica a = new frmReproductorDeMusica();
            a.Show();
        }

        private void WordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmword a = new frmword();
            a.Show();
        }
    }
}