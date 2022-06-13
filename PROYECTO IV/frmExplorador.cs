using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Reflection;
using ZTn.Json.Editor.Forms;

namespace Explorador_de_archivos_proyecto
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        string[] combinado { get; set; }
        
        private void PopulateTreeView()
        {
            TreeNode nodoRaiz;
            DirectoryInfo carpeta = new DirectoryInfo(@"C:\");
            if (carpeta.Exists)
            {
                nodoRaiz = new TreeNode(carpeta.Name);
                nodoRaiz.Tag = carpeta;
                treeView1.Nodes.Add(nodoRaiz);
            }
            TreeNode nodoRaiz2;
            DirectoryInfo carpeta2 = new DirectoryInfo(@"C:\Users\0\Downloads");
            if (carpeta2.Exists)
            {
                nodoRaiz2 = new TreeNode(carpeta2.Name);
                nodoRaiz2.Tag = carpeta2;
                treeView1.Nodes.Add(nodoRaiz2);
            }
            TreeNode nodoRaiz3;
            DirectoryInfo carpeta3 = new DirectoryInfo(@"C:\Users\0\Documents");
            if (carpeta3.Exists)
            {
                nodoRaiz3 = new TreeNode(carpeta3.Name);
                nodoRaiz3.Tag = carpeta3;        
                treeView1.Nodes.Add(nodoRaiz3);
            }
            TreeNode nodoRaiz4;
            DirectoryInfo carpeta4 = new DirectoryInfo(@"C:\Users\0\Desktop");
            if (carpeta4.Exists)
            {
                nodoRaiz4 = new TreeNode(carpeta4.Name);
                nodoRaiz4.Tag = carpeta4;
                treeView1.Nodes.Add(nodoRaiz4);
            }
            TreeNode nodoRaiz5;
            DirectoryInfo carpeta5 = new DirectoryInfo(@"C:\Users\0\Pictures");
            if (carpeta4.Exists)
            {
                nodoRaiz5 = new TreeNode(carpeta5.Name);
                nodoRaiz5.Tag = carpeta5;
                treeView1.Nodes.Add(nodoRaiz5);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            txtRutaActual.Text = nodeDirInfo.FullName;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            string[] archivos = Directory.GetFiles(newSelected.Tag.ToString(), "*", SearchOption.TopDirectoryOnly);
            string[] carpetas = Directory.GetDirectories(newSelected.Tag.ToString(), "*", SearchOption.TopDirectoryOnly);
            combinado = carpetas.Concat(archivos).ToArray();

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name,0);
                subItems = new ListViewItem.ListViewSubItem[]{ new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name,1);
                subItems = new ListViewItem.ListViewSubItem[]{ new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.BackColor = Color.White;
                e.Item.BackColor = Color.Red;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmMenuContextual.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmEditorDeImagen EditorImagen = new frmEditorDeImagen();
            EditorImagen.Show();
        }
        public static void Copiar(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopiarTodo(diSource, diTarget);
        }
        // Eliminar archivo o carpeta
        public static void CopiarTodo(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopiarTodo(diSourceSubDir, nextTargetSubDir);
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar esto permanentemente", "Eliminar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                FileAttributes attr = File.GetAttributes(combinado[listView1.FocusedItem.Index]);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    Directory.Delete(combinado[listView1.FocusedItem.Index], true);
                    MessageBox.Show("Carpeta Eliminada con exito");
                }
                else
                {
                    File.Delete(combinado[listView1.FocusedItem.Index]);
                    MessageBox.Show("Archivo eliminado con exito");
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string ruta = combinado[listView1.FocusedItem.Index];
            txtRutaActual.Text = ruta;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = new DirectoryInfo(ruta);
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            string[] archivos = Directory.GetFiles(ruta, "*", SearchOption.TopDirectoryOnly);
            string[] carpetas = Directory.GetDirectories(ruta, "*", SearchOption.TopDirectoryOnly);
            combinado = carpetas.Concat(archivos).ToArray();

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        ///////Copiar archivo o carpeta
        string sourcePath = "";
        string fileName = "";
        string rutaOrigenArchvio = "";
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FileAttributes attr = File.GetAttributes(combinado[listView1.FocusedItem.Index]);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                string ruta = combinado[listView1.FocusedItem.Index];
                DirectoryInfo Archivo = new DirectoryInfo(ruta);
                fileName = Archivo.Name;
                sourcePath = txtRutaActual.Text +"/"+fileName;
                MessageBox.Show("Carpeta");
                MessageBox.Show(sourcePath);
            }
            else
            {
                string ruta = combinado[listView1.FocusedItem.Index];
                FileInfo Archivo = new FileInfo(ruta);
                fileName = Archivo.Name;
                rutaOrigenArchvio = txtRutaActual.Text;
                sourcePath = Archivo.FullName; 
                MessageBox.Show("Archvio");
                MessageBox.Show(Archivo.FullName);
            }
        }

        ///////Pegar archivo o carpeta
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FileAttributes attr = File.GetAttributes(sourcePath);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                string sourceDirectory = sourcePath;
                string targetDirectory = txtRutaActual.Text;
                DirectoryInfo dir = new DirectoryInfo(sourceDirectory);
                DirectoryInfo dir2 = new DirectoryInfo(targetDirectory);
                dir2.CreateSubdirectory(dir.Name);
                Copiar(sourceDirectory, targetDirectory + "/" + dir.Name);
                MessageBox.Show(dir2.Name);
                MessageBox.Show("Carpeta");
                MessageBox.Show(sourcePath);
            }
            else
            {
                string targetPath = txtRutaActual.Text;
                // Use Path class to manipulate file and directory paths.
                string sourceFile = Path.Combine(rutaOrigenArchvio, fileName);
                string destFile = Path.Combine(targetPath, fileName);
                File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Archivo");
                MessageBox.Show(sourcePath);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
                    
        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmMenuContextual.Show(Cursor.Position);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nuevaCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtRutaActual.Text);
            DirectoryInfo dir = new DirectoryInfo(txtRutaActual.Text + "/" + toolStripTextBox1.Text);
            if (dir.Exists)
            {
                MessageBox.Show("La carpeta ya existe, elije otro nombre");
                return;
            }
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("Debes darle un nombre a la carpeta");
                return;
            }
            else
            {
                directory.CreateSubdirectory(toolStripTextBox1.Text);
                MessageBox.Show("Nueva carpeta creada");
            }

        }

        private void editorJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonEditorMainForm d = new JsonEditorMainForm();
            d.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
    }
}
