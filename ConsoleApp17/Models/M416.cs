namespace M416.Models
{
    public class Atis
    {
        public int GunCount = 60;
        private object consoleKey;

        public void AtisTekTek()
        {
            int Sarsor = 60;
                GunCount--;
            Console.WriteLine("Atis zamani gulle azalir 1 eded {GunCount} /{Sarsor}");


            if (GunCount == 0)
            {
                Console.WriteLine("Gulle sayi azalir..");
                YenidenDoldurma();
                return;
            }
        }
        public void YenidenDoldurma()
        {
            if (GunCount == 60)
            {
                Console.WriteLine("Doludur..");
                return;
            }
            GunCount = 60;
        }
        public void Atis33()
        {
            int Sarsor = 60;
            GunCount = GunCount - 3;
            Console.WriteLine("Uc-uc azalir {GunCount} /{Sarsor}");

            if (GunCount == 0)
            {
                Console.WriteLine("Daraqdaki gulle sayi azalir..");
                YenidenDoldurma();
                return;
            }
        }
        public void Metod()
        {
            while (true)
            {
                ConsoleKeyInfo Metodinfo = Console.ReadKey();
                switch (Metodinfo.Key)
                {
                    case ConsoleKey.A:
                        AtisTekTek();
                        break;
                    case ConsoleKey.B:
                        Atis33();
                        break;
                    case ConsoleKey.C:
                        YenidenDoldurma();
                        break;
                }
            }
        }
        public void SilahiCagirmaq()
        {
            Metod();
        }
    }
}
