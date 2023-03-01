using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    internal class sanaldatabase
    {
        List<Musteri> musteriler = new List<Musteri>();

        public List<Musteri> MusteriListesi()
        {
            for (int i = 1; i <=100; i++)
            {
                Musteri musteri = new Musteri();
                musteri.musteriNo = i;
                musteri.isim = FakeData.NameData.GetFirstName();
                musteri.soyisim = FakeData.NameData.GetSurname();
                musteri.DogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1980, 1, 1), new DateTime(2000,1,1));
                musteri.telefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
                musteri.emailAdres = $"{musteri.isim}.{musteri.soyisim}@{FakeData.NetworkData.GetDomain()}";
                musteri.Ulke = FakeData.PlaceData.GetCountry();
                musteri.Il = FakeData.PlaceData.GetCity();
                musteri.Ilce = FakeData.PlaceData.GetState();

                musteriler.Add(musteri);
            }

            foreach (var item in musteriler)
            {
                Console.WriteLine($"{item.isim} {item.soyisim} \t Email:{item.emailAdres} \t Il:{item.Il} \t Ilce:{item.Ilce} ");

            }
            return musteriler;
        }
    }
}
