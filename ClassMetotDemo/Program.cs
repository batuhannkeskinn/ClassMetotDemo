using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Musteri = new string[] { };

                     SayinMusterilerimiz Musteri1 = new SayinMusterilerimiz ();
            Musteri1.Ad = "Mustafa";
            Musteri1.SoyAd = "Keser";
            Musteri1.ID = 4321;
            Musteri1.TC = 999999991;

            SayinMusterilerimiz Musteri2 = new SayinMusterilerimiz();

            Musteri2.Ad = "Fatih";
            Musteri2.SoyAd = "Terzi";
            Musteri2.ID = 1234;
            Musteri2.TC = 999999992;

            SayinMusterilerimiz[] sayinMusterilerimiz = new SayinMusterilerimiz[] { Musteri1,Musteri2 };


            foreach ( var musteri in sayinMusterilerimiz )
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.SoyAd);
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.TC);
                Console.WriteLine("----------------------");

                

                
                

                





            }

            MusteriManager block = new MusteriManager();

            block.Block(Musteri1);
            block.Block(Musteri2);





        }

    }
}
