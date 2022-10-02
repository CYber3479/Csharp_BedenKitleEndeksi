using System;

namespace BedenKitleEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            beden kitle endeksi = kilo / boy*boy
            beden kitle endeksi 18'e eşit veya düşükse zayıf
            18 ile 25 arasındaysa normal
            25'ten büyükse obez yazdıran program parçasını kodlayınız.
            */
           
            Console.WriteLine("Kilonuzu giriniz.");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz.");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);
        
            if (bke<18)
            {
                Console.WriteLine("Zayıf");
                Console.ReadLine();
            }
            else if (18<bke&&bke<25)
            {
                Console.WriteLine("Normal");
                Console.ReadLine();
            }
            else if (bke>25)
            {
                Console.WriteLine("Obez");
                Console.ReadLine();
            }
        }           
    }
}
