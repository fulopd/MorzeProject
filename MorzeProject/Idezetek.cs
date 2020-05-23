using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeProject
{
    class Idezetek
    {
        List<Idezet> idezetekLista;
        MorzeFordito mf;
        public Idezetek()
        {
            mf = new MorzeFordito();
            idezetekLista = new List<Idezet>();
            Beolvas();
        }

        private void Beolvas()
        {
            using (var sr = new StreamReader("forras/morze.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    idezetekLista.Add(new Idezet(
                                            sor[0],
                                            sor[1],
                                            mf.Morze2Szoveg(sor[0]),
                                            mf.Morze2Szoveg(sor[1])));
                }

            }
        }

        public string  ElsoIdezetSzerzo()
        {
            return idezetekLista[0].szerzo;
        }

        public Idezet LeghoszabbIdezet() 
        {
            int min = 0;
            Idezet legh = new Idezet();
            foreach (var item in idezetekLista)
            {
                if (item.idezet.Length > min)
                {
                    min = item.idezet.Length;
                    legh = item;
                }
            }
            return legh;
        }

        public List<Idezet> ArisztoteleszIdezetei() 
        {
            return idezetekLista.Where(x => x.szerzo.Contains("ARISZTOTELÉSZ")).ToList();
        }

        public void ForditasFile()
        {
            using (var sw = new StreamWriter("forditas.txt",false,Encoding.UTF8))
            {
                idezetekLista.ForEach(x => sw.WriteLine(x.szerzo + ":"+x.idezet));
            }
        }
    }
}
