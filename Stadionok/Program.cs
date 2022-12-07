using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadionok
{
    internal static class Program
    {
        static public ujstadion Ujstadion = new ujstadion();
        static public modositstadion Modositstadion = new modositstadion();
        static public stadiontorlese Stadiontorlese = new stadiontorlese();
        static public Stadionok stadionok = new Stadionok();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(stadionok);

        }
    }
}
