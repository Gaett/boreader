using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boreader
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            
            f.Width = Screen.PrimaryScreen.Bounds.Width;
            f.KeyPreview = true;
            f.Top = 0;
            f.textBox1.Left = (f.Width / 2) - (f.textBox1.Width/2);
            f.flowLayoutPanel1.Left = (f.Width / 2) - (f.flowLayoutPanel1.Width / 2);
            f.textBox1.Text = "ALT + F1 : Lock/Unlock buttons \r\n";
            f.textBox1.Text += "ALT + F2 : Hide/Show Windows Tool Bar";
            Application.Run(f);
        }
    }

    public class Reader
    {

    }
}
