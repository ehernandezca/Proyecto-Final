using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROYECTO_IV
{
    class AcomodarDatos
    {
        public static void acomodar(string ruta)
        {
            DirectoryInfo carpeta = new DirectoryInfo(ruta);
            string extension;
            foreach (DirectoryInfo directorio in carpeta.GetDirectories())
            {
                string direccion = directorio.FullName;
                acomodar(direccion);
            }

            foreach (FileInfo archivos in carpeta.GetFiles())
            {
                extension = archivos.Extension.ToLower().Replace(".", "");
                switch (extension)
                {
                    //AUDIO
                    case "mp3":
                    case "wav":
                    case "aiff":
                    case "wma":
                    case "flac":
                    case "m4a":
                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Audio");
                        }
                        File.Move(archivos.FullName, ruta + @"\Audio\" + archivos.Name);
                        break;

                    //VIDEO
                    case "mp4":
                    case "wmv":
                    case "mov":
                    case "m4v":
                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Videos");
                        }
                        File.Move(archivos.FullName, ruta + @"\Videos\" + archivos.Name);
                        break;

                    //IMAGENES
                    case "png":
                    case "jpg":
                    case "jpeg":
                    case "gif":
                    case "tiff":
                    case "tif":
                    case "raw":
                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Imagenes");
                        }
                        File.Move(archivos.FullName, ruta + @"\Imagenes\" + archivos.Name);
                        break;

                    //DOCUMENTOS 
                    case "txt":
                    case "pdf":
                    case "doc":
                    case "docx":
                    case "docm":
                    case "dotx":
                    case "dotm":
                    case "xlsx":
                    case "xlsm":
                    case "xltx":
                    case "xltm":
                    case "xlsb":
                    case "xlam":
                    case "pptx":
                    case "pptm":
                    case "potx":
                    case "potm":
                    case "ppam":
                    case "ppsx":
                    case "ppsm":
                    case "sldx":
                    case "sldm":
                    case "thmx":
                    case "xml":
                    case "html":
                    case "csv":
                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Documentos");
                        }
                        File.Move(archivos.FullName, ruta + @"\Documentos\" + archivos.Name);
                        break;

                    //OTROS
                    case "zip":
                    case "7z":
                    case "rar":

                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Archivos Comprimidos");
                        }
                        File.Move(archivos.FullName, ruta + @"\Archivos Comprimidos\" + archivos.Name);
                        break;

                    case "iso":
                        if (ruta + "" == ruta + "")
                        {
                            Directory.CreateDirectory(ruta + @"\Iso");
                        }
                        File.Move(archivos.FullName, ruta + @"\Iso\" + archivos.Name);
                        break;
                }
            }
        }
    }
}