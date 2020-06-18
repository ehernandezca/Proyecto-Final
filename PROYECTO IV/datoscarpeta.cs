using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace PROYECTO_IV
{
    class datoscarpeta
    {
        public static void archivos(TreeView treeView1, ListView listView1)
        {
            string a;

            DirectoryInfo path;
            string ruta = treeView1.SelectedNode.FullPath;
            switch (ruta)
            {
                case "Escritorio":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Desktop");

                    foreach (DirectoryInfo carpetas in path.GetDirectories())
                    {
                        string direccion = carpetas.FullName;
                    }

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");

                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {


                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);
                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;
                                    }
                                    break;


                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;
                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;
                case "Imagenes":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Imágenes");

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");
                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {

                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);

                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;
                                    }
                                    break;


                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;
                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;
                case "Descargas":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Downloads");

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");
                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);
                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;
                                    }
                                    break;


                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;

                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;
                case "Documentos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\OneDrive\Documents");

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");
                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);
                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;
                                    }
                                    break;

                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;
                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;

                case "Musica":

                    path = new DirectoryInfo(@"C:\Users\Norbe\Music");

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");
                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);
                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;
                                    }
                                    break;


                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;
                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;
                case "Videos":
                    path = new DirectoryInfo(@"C:\Users\Norbe\Videos");

                    foreach (FileInfo archivoo in path.GetFiles())
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            ListViewItem listItem = listView1.SelectedItems[0];

                            a = listItem.Text;
                            string extension = "";
                            DirectoryInfo info = new DirectoryInfo(a);
                            extension = info.Extension.ToLower().Replace(".", "");
                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string nombre = archivoo.Name;
                                        nombre = archivoo.FullName.Replace(nombre, "");

                                        EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                        EqualizationDemoViewModel.carpetaaudio(nombre);
                                        return;

                                    }
                                    break;

                                case "doc":
                                case "docx":
                                    if (archivoo.Extension == archivoo.Extension)
                                    {
                                        string ru = archivoo.FullName;
                                        frmword word = new frmword();
                                        word.abrir(ru);
                                        word.Show();
                                        return;

                                    }
                                    break;


                                case "pdf":
                                    if (archivoo.Exists == archivoo.Exists)
                                    {
                                        string p = archivoo.FullName;
                                        frmpdf pdf = new frmpdf();
                                        pdf.abrir(p);
                                        pdf.Show();
                                        return;
                                    }
                                    break;
                            }

                            if (archivoo.FullName == path + "\\" + a)
                            {
                                string abrir = Path.GetFullPath(archivoo.FullName);
                                Process proceso = new Process();
                                proceso.StartInfo.FileName = abrir;
                                proceso.Start();
                            }
                        }
                    }
                    break;
            }
        }

        public static void cargardenuevo(TreeView treeView1, ListView listView1)
        {

            TreeNode seleccionado = treeView1.SelectedNode;
            listView1.Items.Clear();
            DirectoryInfo nododirectorio = (DirectoryInfo)seleccionado.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nododirectorio.GetDirectories())
            {
                bool sies = false;
                item = new ListViewItem(dir.Name, 0);

                subItems = new ListViewItem.ListViewSubItem[]
                            {new ListViewItem.ListViewSubItem(item, "Carpeta"),
                     new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nododirectorio.GetFiles())
            {
                bool sies = false;
                string extension;
                extension = file.Extension.ToLower().Replace(".", "");

                switch (extension)
                {
                    case "mp3":
                    case "wav":
                    case "aiff":
                    case "wma":
                    case "flac":
                    case "m4a":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 5);
                            subItems = new ListViewItem.ListViewSubItem[]
                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;

                    case "png":
                    case "jpg":
                    case "jpeg":
                    case "gif":
                    case "tiff":
                    case "tif":
                    case "raw":
                    case "cr2":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 2);
                            subItems = new ListViewItem.ListViewSubItem[]
                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;

                    case "doc":
                    case "docx":
                    case "docm":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 7);
                            subItems = new ListViewItem.ListViewSubItem[]
                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;

                    case "mp4":
                    case "wmv":
                    case "mov":
                    case "m4v":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 8);
                            subItems = new ListViewItem.ListViewSubItem[]
                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;

                    case "iso":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 9);
                            subItems = new ListViewItem.ListViewSubItem[]
                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;


                    case "pdf":
                        if (file.Exists)
                        {
                            item = new ListViewItem(file.Name, 10);
                            subItems = new ListViewItem.ListViewSubItem[]
                                        { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        sies = true;
                        break;
                }

                if (sies != true)
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public static void abrirarchivo(DirectoryInfo path, ListView listView1, TextBox txtruta)
        {
            
            string a;
            bool sies = false;

            foreach (DirectoryInfo carpeta in path.GetDirectories())
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = listView1.SelectedItems[0];
                    string extension = "";
                    a = listItem.Text;
                    if (carpeta.FullName == path + "\\" + a)
                    {
                        path = new DirectoryInfo(carpeta.FullName);
                        listView1.Items.Clear();
                        DirectoryInfo nododirectorio = new DirectoryInfo(carpeta.FullName);
                        ListViewItem.ListViewSubItem[] subItems;
                        ListViewItem item = null;

                        foreach (DirectoryInfo dir in nododirectorio.GetDirectories())
                        {
                            item = new ListViewItem(dir.Name, 0);

                            subItems = new ListViewItem.ListViewSubItem[]
                            {new ListViewItem.ListViewSubItem(item, "Carpeta"),
                     new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        foreach (FileInfo file in nododirectorio.GetFiles())
                        {
                            extension = file.Extension.ToLower().Replace(".", "");

                            switch (extension)
                            {
                                case "mp3":
                                case "wav":
                                case "aiff":
                                case "wma":
                                case "flac":
                                case "m4a":
                                    if (file.Exists)
                                    {
                                        item = new ListViewItem(file.Name, 5);
                                        subItems = new ListViewItem.ListViewSubItem[]
                                                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                                        item.SubItems.AddRange(subItems);
                                        listView1.Items.Add(item);
                                    }
                                    sies = true;
                                    break;

                                case "png":
                                case "jpg":
                                case "jpeg":
                                case "gif":
                                case "tiff":
                                case "tif":
                                case "raw":
                                case "cr2":
                                    if (file.Exists)
                                    {
                                        item = new ListViewItem(file.Name, 2);
                                        subItems = new ListViewItem.ListViewSubItem[]
                                                   { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                                        item.SubItems.AddRange(subItems);
                                        listView1.Items.Add(item);
                                    }
                                    sies = true;
                                    break;

                                case "doc":
                                case "docx":
                                case "docm":
                                    if (file.Exists)
                                    {
                                        item = new ListViewItem(file.Name, 7);
                                        subItems = new ListViewItem.ListViewSubItem[]
                                                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                                        item.SubItems.AddRange(subItems);
                                        listView1.Items.Add(item);
                                    }
                                    sies = true;
                                    break;

                                case "pdf":
                                    if (file.Exists)
                                    {
                                        item = new ListViewItem(file.Name, 10);
                                        subItems = new ListViewItem.ListViewSubItem[]
                                                    { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                                        item.SubItems.AddRange(subItems);
                                        listView1.Items.Add(item);
                                    }
                                    sies = true;
                                    break;
                            }

                            if (sies != true)
                            {
                                item = new ListViewItem(file.Name, 1);
                                subItems = new ListViewItem.ListViewSubItem[]
                                                                            { new ListViewItem.ListViewSubItem(item, "Archivo"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                                item.SubItems.AddRange(subItems);
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            foreach (FileInfo archivoo in path.GetFiles())
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = listView1.SelectedItems[0];
                    string extension = "";
                    a = listItem.Text;
                    //string extension = "";
                    if (archivoo.FullName == path + "\\" + a)
                    {
                        DirectoryInfo info = new DirectoryInfo(a);
                        extension = info.Extension.ToLower().Replace(".", "");
                        switch (extension)
                        {
                            case "mp3":
                            case "wav":
                            case "aiff":
                            case "wma":
                            case "flac":
                            case "m4a":
                                if (archivoo.Extension == archivoo.Extension)
                                {


                                    string nombre = archivoo.Name;
                                    nombre = archivoo.FullName.Replace(nombre, "");

                                    EqualizationDemoViewModel.audioarchivo(archivoo.FullName);
                                    EqualizationDemoViewModel.carpetaaudio(nombre);
                                    sies = true;
                                    return;

                                }
                                break;
                            case "txt":
                                if (archivoo.Extension == archivoo.Extension)
                                {
                                    frmnotas n = new frmnotas();
                                    notasbloc.abrir(archivoo.FullName, n.txtbloc);
                                    sies = true;
                                    n.Show();
                                }
                                break;
                            case "wmv":
                                if (archivoo.Extension == archivoo.Extension)
                                {
                                    frmvideo video = new frmvideo();

                                    video.label1.Text = txtruta.Text;
                                    video.Show();
                                    sies = true;
                                }
                                break;
                            case "doc":
                            case "docx":
                                if (archivoo.Extension == archivoo.Extension)
                                {
                                    string ru = archivoo.FullName;
                                    frmword word = new frmword();
                                    word.abrir(ru);
                                    word.Show();
                                    sies = true;

                                }
                                break;

                            case "pdf":
                                if (archivoo.Exists==archivoo.Exists)
                                {
                                    string p = archivoo.FullName;
                                    frmpdf pdf = new frmpdf();
                                    pdf.abrir(p);
                                    pdf.Show();
                                    sies = true;
                                }
                                break;
                        }
                    }
                    if (sies != true)
                    {
                        if (archivoo.FullName == path + "\\" + a)
                        {
                            string abrir = Path.GetFullPath(archivoo.FullName);
                            Process proceso = new Process();
                            proceso.StartInfo.FileName = abrir;
                            proceso.Start();
                        }
                    }
                }
            }
        }
    }
}