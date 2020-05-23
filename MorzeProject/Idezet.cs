using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeProject
{
    class Idezet
    {
        public string szerzoMorze { get; set; }
        public string idezetMorze { get; set; }
        public string szerzo { get; set; }
        public string idezet { get; set; }

        public Idezet()
        {

        }
        public Idezet(string szerzoMorze, string idezetMorze, string szerzo, string idezet)
        {
            this.szerzoMorze = szerzoMorze;
            this.idezetMorze = idezetMorze;
            this.szerzo = szerzo;
            this.idezet = idezet;
        }

        
    }

}
