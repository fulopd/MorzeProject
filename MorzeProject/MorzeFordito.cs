using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeProject
{
    class MorzeFordito
    {
        List<MorzeABC> betuLista;

        public MorzeFordito()
        {
            betuLista = new List<MorzeABC>();
            readFile();
        }

        private void readFile()
        {
            using (var sr = new StreamReader("forras/morzeabc.txt"))
            {
                string sep = "\t";
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(sep.ToCharArray());
                    betuLista.Add(new MorzeABC(sor[0], sor[1]));
                }
            }
        }

        public int GetKarakterekszama()
        {
            return betuLista.Count();
        }

        public string ForditKarakter(string betu)
        {
            betu = betu.ToUpper();
            var karakter = betuLista.Find(x => x.betu.Equals(betu));
            if (karakter != null)
            {
                return karakter.morzejel;
            }
            else
            {
                return "Nem található a kódtárban ilyen karakter!";
            }
            
        }

        public string ForditMorzeKarakter(string morzeJel)
        {
            var karakter = betuLista.Find(x => x.morzejel.Equals(morzeJel));
            if (karakter != null)
            {
                return karakter.betu;
            }
            else
            {
                return "";
            }
        }

        public string Morze2Szoveg(string morze)
        {
            string szoveg = "";
            
            var morzeSzavak = morze.Split(new string[] { "       " }, StringSplitOptions.None);
            foreach (var item in morzeSzavak)
            {
                if (item != "")
                {
                    var morzeJelek = item.Split(new string[] { "   " }, StringSplitOptions.None);
                    foreach (var morzeJel in morzeJelek)
                    {
                        szoveg += ForditMorzeKarakter(morzeJel);
                    }

                    szoveg += " ";
                }
            }
            szoveg = szoveg.Substring(0, szoveg.Length - 1);
            return szoveg;
        }
    }
}
