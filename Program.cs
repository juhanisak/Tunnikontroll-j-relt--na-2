using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm, mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse -1.");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine();

            List<string> sõnad = new List<string>();

            bool tehing = true;
            
            while (tehing)
            {
                //Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Sisesta sõna: ");
                string sisend = Console.ReadLine();

                string sisend2 = sisend.ToString();



                if (sisend2 != "1")

                    sõnad.Add(sisend);
                    Console.WriteLine();



                if (sisend2 == "1")
                {
                    Console.WriteLine("------------------------------------------------------");
                    break;
                }


            }
            Console.WriteLine();
            Console.WriteLine("Sisestasid sõnad: ");
            sõnad.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Valin nendest välja suvalise: ");

            Random rnd = new Random();

            int indeks = rnd.Next(sõnad.Count);

            string suva_sõna = sõnad[indeks];
            
            Console.WriteLine(suva_sõna);


            Console.ReadLine();

            }
        }
    }
}
