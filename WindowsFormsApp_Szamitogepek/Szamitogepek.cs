using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Szamitogepek
{
    enum Op_rendszerek { Windows, Linux, MacOS };
    class Szamitogepek
    {
        readonly string konfig;
        Op_rendszerek op_rendszer;
        string tulajdonos;
        bool gamer_konfig;

        public string Konfig => konfig;

        public string Tulajdonos { get => tulajdonos; set => tulajdonos = value; }
        public bool Gamer_konfig { get => gamer_konfig; set => gamer_konfig = value; }
        internal Op_rendszerek Op_rendszer { get => op_rendszer; set => op_rendszer = value; }

        public Szamitogepek(string konfig, Op_rendszerek op_rendszer, string tulajdonos, bool gamer_konfig)
        {
            this.konfig = konfig;
            this.Op_rendszer = op_rendszer;
            this.Tulajdonos = tulajdonos;
            this.Gamer_konfig = gamer_konfig;
        }

       
    }
}
