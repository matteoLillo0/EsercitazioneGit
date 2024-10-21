using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGit
{
    internal class Libro(string autore, string titolo, int anno, string editore, int nPagine)
    {   

        public string toString()
        {
            string finale = $"{autore}, {titolo}, {anno}, {editore}, {nPagine}";

            return finale;
        }

        public int readingTime()
        {
            if (nPagine < 100) return 2;

            if (nPagine > 100 && nPagine < 200) return 2;

            else return 3;  
             
        }
    }
}
