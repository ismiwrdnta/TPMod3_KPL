// See https://aka.ms/new-console-template for more information

using System;

namespace tpmodul3_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            KodePos KP   = new KodePos();
            Console.WriteLine("Kelurahan" + "     " + "Kode Pos");
            Console.WriteLine("Batununggal" + "    " + KP.getKodePos("Batununggal"));
            Console.WriteLine("Kujangsari" + "     " + KP.getKodePos("Kujangsari"));
            Console.WriteLine("Mengger" + "        " + KP.getKodePos("Mengger"));
            Console.WriteLine("Wates" + "          " + KP.getKodePos("Wates"));
            Console.WriteLine("Cijaura" + "        " + KP.getKodePos("Cijaura"));
            Console.WriteLine("Jatisari" + "       " + KP.getKodePos("Jatisari"));
            Console.WriteLine("Margasari" + "      " + KP.getKodePos("Margasari"));
            Console.WriteLine("Sekejati" + "       " + KP.getKodePos("Sekejati"));
            Console.WriteLine("Kebonwaru" + "      " + KP.getKodePos("Kebonwaru"));
            Console.WriteLine("Maleer" + "         " + KP.getKodePos("Maleer"));
            Console.WriteLine("Samoja" + "         " + KP.getKodePos("Samoja"));

            DoorMachine status = new DoorMachine();
            Console.WriteLine("Pintu");

            int i;
            for (i = 0; i < 3; i++)
            {
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                while (command == "Terbuka" || command == "Terkunci")
                {

                    if (command == "Terbuka")
                    {
                        status.getDoor("Terbuka");
                        break;
                    }
                    else if (command == "Terkunci")
                    {
                        status.getDoor("Terkunci");
                    }
                    break;
                }
            }
        }
    }  
}
