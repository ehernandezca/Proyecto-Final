using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PROYECTO_IV
{
    class notasbloc
    {
        public static void guardar(TextBox txtbloc,TextBox txtruta,TextBox txtnombre)
        {
            StreamWriter sw = new StreamWriter(txtruta.Text + "\\" + txtnombre.Text + ".txt");
            sw.WriteLine(txtbloc.Text);
            sw.Close();
           
        }

        public static string abrir(string ruta,TextBox txt)
        {
            string linea;
            StreamReader sr = new StreamReader(ruta);
            while ((linea = sr.ReadLine()) != null)
            {
                txt.Text += linea + Environment.NewLine;
            }
            sr.Close();
        
            return txt.Text;
        }

    }
}