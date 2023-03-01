using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {         

            try
            {
                //standart yazdığım kodlar try da yer alır
                Console.WriteLine("Sayi:");
                double sayi = Convert.ToDouble(Console.ReadLine());
                int s = 0;
                //int bolum = 1 / s;

                if(sayi==1)
                {
                    throw new OzelHata();
                }

                if(sayi==2)
                {
                    throw new FormatException("Format hatası");
                }

            }
            catch(OzelHata ex)
            {
                Console.WriteLine("Özel hata yakalandı");
            }
            catch (FormatException fx) when (fx.Message=="Format hatası") 
            {
                Console.WriteLine(fx.Message);
            }
            catch (FormatException fx)
            {
                Console.WriteLine(fx.Message);
            }
            catch (DivideByZeroException ex)
            {
                //Hata alındığında çalışır
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //Hata alındığında çalışır
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program sonlandı");
            }

            //Örnek

            bool sonuc = true;

            try
            {
                //veritabanı bağlantısı sağlandı
                // kayıt işlemi yapıldı.
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                sonuc = false;
            }
            finally
            {
                //bağlantıyı kapat işlemi
                if(sonuc)
                   Console.WriteLine("işleminiz başarılı şekilde gerçekleşti");
                else
                    Console.WriteLine("işlem tamamlanamadı");
            }

            Console.ReadLine();
        }
    }
}
