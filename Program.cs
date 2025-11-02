using System.Threading;
namespace Dice_Game
{
    class Program
    {

        public static void Main()
        {

            Console.Clear();
            Random rand = new Random();
            int oyuncu_zar = 0;
            int bilgisayar_zar = 0;
            int oyuncu_score = 0;
            int bilgisayar_score = 0;
            int counter = 10;
            int i = 0;

            while (i <= counter)
            {
                Console.WriteLine("zar atmak için herhangi bir tuşa basınız.");
                Console.ReadKey();
                oyuncu_zar = rand.Next(7);
                bilgisayar_zar = rand.Next(7);

                if (oyuncu_zar > bilgisayar_zar)
                {
                    Console.WriteLine($"Puan oyuncuya-->{oyuncu_zar}");
                    oyuncu_score += oyuncu_zar;
                }

                else
                {
                    Console.WriteLine($"Puan bilgisayara-->{oyuncu_zar}");
                    bilgisayar_score += bilgisayar_zar;
                }
                i++;
                Console.WriteLine();
                Thread.Sleep(1000);

            }
            oyuncu_score *= 100;
            if (oyuncu_score > bilgisayar_score) { Console.WriteLine($"Oyuncu yendi! PUAN-->{oyuncu_score}"); } else { Console.WriteLine($"Bilgisayar yendi.. PUAN-->{oyuncu_score}"); }

        }

    }
}
