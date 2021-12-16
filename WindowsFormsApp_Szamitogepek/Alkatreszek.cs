using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Szamitogepek
{
    class Alkatreszek
    {
        readonly string megnevezes;
        readonly string gyarto;
        readonly int ar;
        int darab;

        public Alkatreszek(string megnevezes, string gyarto, int ar, int darab)
        {
            this.megnevezes = megnevezes;
            this.gyarto = gyarto;
            this.ar = ar;
            this.Darab = darab;
        }

        public string Megnevezes => megnevezes;

        public string Gyarto => gyarto;

        public int Ar => ar;

        public int Darab { get => darab; set => darab = value; }
    }
}
