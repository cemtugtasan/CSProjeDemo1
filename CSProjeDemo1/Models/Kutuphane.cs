using CSProjeDemo1.Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Models
{
    public class Kutuphane
    {
        public List<Uye> Uyeler { get; set; }
        public List<Kitap>Kitaplar { get; set; }

        public void OduncVer(Kitap kitap,Uye uye)
        {
            if (kitap.KitapDurum == Enums.Durum.OduncAlabilir)
            {
                uye.KitapOduncAl(kitap);
            }
            else
            {
                Console.WriteLine($"{kitap} zaten ödünç alınmış...!");
            }
        }
        public void IadeAl(Kitap kitap,Uye uye)
        {
            uye.KitapIadeEt(kitap);
        }
    }
}
