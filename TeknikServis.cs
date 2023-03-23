using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    class TeknikServis
    {
        // Directory sınıfı
        //  Bilgisayar nesnesinin parçalarını kendisi oluşturmaktadır.

        public void BilgisayarTopla(IBilgisayarToplayicisi bilgisayarToplayicisi)
        {
            bilgisayarToplayicisi.CDROM_Olustur();
            bilgisayarToplayicisi.HDD_Olustur();
            bilgisayarToplayicisi.Monitor_Olustur();
            bilgisayarToplayicisi.RAM_Olustur();
        }
    }
}
