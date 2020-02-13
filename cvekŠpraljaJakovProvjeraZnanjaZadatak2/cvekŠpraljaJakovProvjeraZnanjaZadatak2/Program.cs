using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tri dvoznamenkasta broja odvojena zarezom.");
            string unos =Console.ReadLine();
            int prviBroj = Convert.ToInt32(unos.Substring(0, 2));
            int drugiBroj = Convert.ToInt32(unos.Substring(3, 2));
            int treciBroj = Convert.ToInt32(unos.Substring(6, 2));
            int najveci= 0;
            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                najveci = prviBroj;
            }
            else if (drugiBroj > prviBroj && drugiBroj > treciBroj)
            {
                najveci = drugiBroj;
            }
            else if (treciBroj>prviBroj && treciBroj>prviBroj) 
            {
                najveci = treciBroj;
            }
            Console.WriteLine("Najveci broj je: " + najveci);
            //substring
            Console.ReadKey();
        }
    }
}
