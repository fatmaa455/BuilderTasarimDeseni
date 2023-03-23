using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    class GoldPC : IBilgisayarToplayicisi
    {
        // concrete builder
        // Bu özellik istendiği zaman oluşturulan Bilgisayar ürününü istemciye vermektedir
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get { return mBilgisayar; }
        }

        public GoldPC()
        {
            mBilgisayar = new Bilgisayar("Gold-PC");
        }

        public void CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "52X GoldStar";
        }

        public void HDD_Olustur()
        {
            mBilgisayar["hdd"] = "60 GB Seagate";
        }

        public void Monitor_Olustur()
        {
            mBilgisayar["monitor"] = "17 ' Hyundai";
        }

        public void RAM_Olustur()
        {
            mBilgisayar["ram"] = "512 MB DDR Kingston";
        }
    }
}
