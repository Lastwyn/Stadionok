using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Stadionok
{
    internal class stadion_adat
    {
        int id;
        string stadion;
        int ferohely;
        string varos;
        int epult;

        public int Id { get => id; set => id = value; }
        public string Stadion { get => stadion; set => stadion = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public string Varos { get => varos; set => varos = value; }
        public int Epult { get => epult; set => epult = value; }

        public stadion_adat(int id, string stadion, int ferohely, string varos, int epult)
        {
            Id = id;
            Stadion = stadion;
            Ferohely = ferohely;
            Varos = varos;
            Epult = epult;
        }
        public override string ToString()
        {
            return $"{stadion} - {ferohely}/fő - {varos} - {epult}-(ban/ben) épült.";
        }
    }
}
