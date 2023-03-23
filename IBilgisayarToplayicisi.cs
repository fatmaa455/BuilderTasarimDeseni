using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    interface IBilgisayarToplayicisi
    {
        // product
        Bilgisayar Bilgisayar { get; }
        void CDROM_Olustur();
        void HDD_Olustur();
        void Monitor_Olustur();
        void RAM_Olustur();
    }
}
