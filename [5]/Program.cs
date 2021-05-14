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

            double R;



            Console.Write("Oluşturmak İstediğiniz Kürenin R Yarıçapını Giriniz:");
            R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            int[] kordinatlar = new int[6];

            Console.Write("küreyi oluşturmak istediğiniz x kordinatını giriniz:");
            kordinatlar[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("küreyi oluşturmak istediğiniz y kordinatını giriniz:");
            kordinatlar[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("küreyi oluşturmak istediğiniz z kordinatını giriniz:");
            kordinatlar[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("denemek istediğiniz x kordinatını giriniz:");
            kordinatlar[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("denemek istediğiniz y kordinatını giriniz:");
            kordinatlar[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("denemek istediğiniz z kordinatını giriniz:");
            kordinatlar[5] = Convert.ToInt32(Console.ReadLine());






            if (R < 0)
            {
                Console.Write("Yarıçap pozitif olmalıdır");

            }
            if (kordinatlar[0] - R <= kordinatlar[3] && kordinatlar[0] + R >= kordinatlar[3] && kordinatlar[1] - R <= kordinatlar[4] && kordinatlar[1] + R >= kordinatlar[4] && kordinatlar[2] - R <= kordinatlar[5] && kordinatlar[2] + R >= kordinatlar[5])
            {
                Console.Write("Nokta Kürenin içinde");
            }

            else
            {
                Console.Write("Nokta Kürenin Dışında");

            }

            Console.Read();

        }
    }
}
