using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("Kırmızı");
            //Console.WriteLine(araba.Renk + "renkli bir araba yaratıldı.");

            araba.ArabayaBenzinAl(50);
            Console.WriteLine(araba.ToString());
            araba.MotoruCalistir();
            Console.WriteLine(araba.ToString());
            araba.MotoruDurdur();
            Console.WriteLine(araba.ToString());

        }
    }

    public class Araba
    {
        public Araba(string renk)
        {
            Renk = renk;
        }

        public Araba(string renk, int benzinSeviyesi)
        {
            Renk = renk;
            BenzinSeviyesi = benzinSeviyesi;
        }

        public string Renk
        {
            get; set;
        }


        public int BenzinSeviyesi
        {
            get; private set; //bu property private yapıldı ve ArabayaBenzinAl 
                              //methodu üzerinden erişim yapılıyor.
                              // Encapsulation içinde Data hiding 
        }

        public bool MotorCalisiyormu
        {
            get; private set;
        }

        public void ArabayaBenzinAl()
        {
            if (BenzinSeviyesi < 100)
            {
                BenzinSeviyesi = 100;
                Console.WriteLine("Arabaya benzin alındı. 100");
            }

        }

        public void ArabayaBenzinAl(int yeniSeviye)
        {
            if (BenzinSeviyesi < 100 && yeniSeviye <= 100 &&
                yeniSeviye > BenzinSeviyesi && yeniSeviye > 0)
            {
                BenzinSeviyesi = yeniSeviye;
                Console.WriteLine("Arabaya benzin alındı. ?");
            }
        }

        public void MotoruCalistir()
        {
            //if (!MotorCalisiyormu && BenzinSeviyesi > 0)
            if (BenzinSeviyesi <= 0)
            {
                //throw new Exception("Arabada yakıt yok.");
                throw new MotorZatenCalismiyorHatasi("Motor zaten çalışmıyor.");
            }

            if (MotorCalisiyormu)
            {
                // throw new Exception("Motor zaten çalışıyor.");
                throw new MotorZatenCalisiyorHatasi("Motor zaten çalışıyor.");
            }
           
                MotorCalisiyormu = true;
                Console.WriteLine("Motor çalıştırıldı.");
            
        }

        public void MotoruDurdur()
        {
            if (MotorCalisiyormu)
            {
                MotorCalisiyormu = false;
                Console.WriteLine("Motor durduruldu.");
            }
        }

        public override string ToString()
        {
            return Renk + "renkli arabanın motoru" +
                (MotorCalisiyormu ? "çalışıyor" : "çalışmıyor") +
                "Benzin seviyesi:" + BenzinSeviyesi;
        }

        public class BenzinYokException : Exception
        {
            public BenzinYokException(string message) : base(message)
            {
            }
        }

        public class MotorZatenCalisiyorHatasi : Exception
        {
            public MotorZatenCalisiyorHatasi(string message) : base(message)
            {
            }
        }

        public class MotorZatenCalismiyorHatasi : Exception
        {
            public MotorZatenCalismiyorHatasi(string message) : base(message)
            {
            }
        }
    }
}
