using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample
{
    class Program
    {
        static void Main()
        {
            Araba araba; /*Nesne yaratıldı ama instance olusturulmadıgından 
                           stack üzerinde oluşturuldu ama heapte bir memory alanı oluşturulmadı*/
            araba = new Araba(); //Bir instance oluşturuyoruz ve heap üzerinde memory ayrıldı.
            araba.Renk = "Kırmızı";
            Console.WriteLine("Kırmızı renkli bir araba yaratıldı.");

            araba.BenzinSeviyesi = 100;
            Console.WriteLine("Arabaya benzin alındı");

            araba.MotorCalisiyormu = true;
            Console.WriteLine("Motor calıştırıldı.");

            Console.ReadLine();
        }
    }

    public class Araba
    {
        public string Renk{ get; set; }


        public int BenzinSeviyesi
        {
            get; set;
        }

        public bool MotorCalisiyormu
        {
            get; set;
        }
    }
}
