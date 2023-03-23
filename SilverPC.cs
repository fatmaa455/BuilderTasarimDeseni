using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    class SilverPC:IBilgisayarToplayicisi
    {
        // concrete builder
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get { return mBilgisayar; }
        }

        public SilverPC()
        {
            mBilgisayar = new Bilgisayar("Silver-PC");
        }

        public void CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "48X Creative";
        }

        public void HDD_Olustur()
        {
            mBilgisayar["hdd"] = "30 GB Maxtor";
        }

        public void Monitor_Olustur()
        {
            mBilgisayar["monitor"] = "15 ' Vestel";
        }

        public void RAM_Olustur()
        {
            mBilgisayar["ram"] = "256 MB SD Kingston";
        }
    }
}

