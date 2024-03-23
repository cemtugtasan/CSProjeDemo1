using CSProjeDemo1.Classlar;
using CSProjeDemo1.Interfaces;

namespace CSProjeDemo1.Models
{
    public class Uye : IUye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public void KitapOduncAl(Kitap kitap)
        {
            OduncKitaplar.Add(kitap);
            kitap.KitapDurum = Enums.Durum.OduncVerildi;
            Console.WriteLine($"{kitap} odunç alındı.");
        }

        public void KitapIadeEt(Kitap kitap)
        {
            OduncKitaplar.Remove(kitap);
            kitap.KitapDurum = Enums.Durum.OduncAlabilir;
            Console.WriteLine($"{kitap} iade edildi.");
        }
    }
}
