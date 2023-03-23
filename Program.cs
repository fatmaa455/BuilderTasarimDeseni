using System;

namespace Builder1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builder örnek 1
            TeknikServis teknikServis = new TeknikServis();

            IBilgisayarToplayicisi BT1 = new GoldPC();
            IBilgisayarToplayicisi BT2 = new SilverPC();

            teknikServis.BilgisayarTopla(BT1);
            teknikServis.BilgisayarTopla(BT2);

            BT1.Bilgisayar.BilgisayariGoster();
            Console.WriteLine("-------------");
            BT2.Bilgisayar.BilgisayariGoster();
        }
    }
}
