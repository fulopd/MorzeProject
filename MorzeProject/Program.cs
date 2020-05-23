using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            MorzeFordito fordito = new MorzeFordito();

            //3. feladat
            Console.WriteLine("3. feladat: A morze abc {0} db karakter kódját tartalmazza.",fordito.GetKarakterekszama());

            //4. feladat
            Console.Write("4. feladat: Kérek egy karaktert: ");
            string betu = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\tA {0} karakter morze kódja: {1}",betu,fordito.ForditKarakter(betu));

            //7. feladat
            Idezetek idezetek = new Idezetek();
            Console.WriteLine("7. feladat: Az első idézet szerzője: " + idezetek.ElsoIdezetSzerzo());

            //8.feladat
            Console.WriteLine("\tA leghosszabb idézet szerzője: {0}: {1}",idezetek.LeghoszabbIdezet().szerzo, idezetek.LeghoszabbIdezet().idezet);

            //9.feladat
            Console.WriteLine("9. feladat: Arisztotelész idézetei:");
            foreach (var item in idezetek.ArisztoteleszIdezetei())
            {
                Console.WriteLine("\t - " + item.idezet);
            }

            //10.feladat
            idezetek.ForditasFile();

            Console.ReadKey();
        }
    }
}
