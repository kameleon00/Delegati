using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        //=================================================================================================
        // delegat koji prihvata metodu sa dva double parametra i kao rezultat vraca double
        delegate double processDelegate(double param1, double param2);

        // metoda 1
        static double mnozenje(double param1, double param2)
        {
            return param1 * param2;
        }
        //metoda2
        static double deljenje(double param1, double param2)
        {
            return param1 / param2;
        }
        //=================================================================================================

        static void Main(string[] args)
        {
            /*Napisati konzolnu aplikaciju za kreiranje delegata sa dva paremetra i metoda za
              množenje i deljenje dva paramtera. U glavnom programu uneti dva broja razdvojena zarezom, a
             potom odrediti da li se želi izvršiti množenje ili deljenje zadata dva broja. */

            processDelegate process; // definisanje delegata

            Console.WriteLine("Uneti dva broja:");

            double param1 = Convert.ToDouble(Console.ReadLine());
            double param2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Uneti M za mnozenje ili D za deljenje:");
            string input = Console.ReadLine();

            if (input == "M")
                process = new processDelegate(mnozenje); //metoda 1
            else
                process = new processDelegate(deljenje); //metoda 2

            Console.WriteLine("Rezultat je : {0}", process(param1, param2));
            Console.ReadLine();
        }
    }
}
