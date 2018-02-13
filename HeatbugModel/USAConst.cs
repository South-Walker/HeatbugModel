using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatbugModel
{
    class USAConst
    {
        /* LongitudeAndLatitude */
        int beginLongitude = -130;
        int endLongitude = -60;
        int beginLatitude = 50;
        int endLatitude = 30;
        /* img */
        int imgWidth = 2000;
        int imgHeight = 570;
        int distancePerPX = 2900;
        /* destination */
        int destinationnumFarWest = 483;
        int destinationnumRockyMountain = 107;
        int destinationnumPlains = 136;
        int destinationnumNewEngland = 1179;
        int destinationnumSouthWest = 369;
        int destinationnumSouthEast = 616;
        /* super */
        int supernumFarWest = 158;
        int supernumRockyMountain = 29;
        int supernumPlains = 40;
        int supernumNewEngland = 360;
        int supernumSouthWest = 100;
        int supernumSouthEast = 145;
        /* beginx */
        int beginxFarwest = 149;
        int beginxRockyMountain = 370;
        int beginxPlains = 741;
        int beginxNewEngland = 1017;
        int beginxSouthWest = 455;
        int beginxSouthEast = 1016;
        /* endx */
        int endxFarwest = 455;
        int endxRockyMountain = 798;
        int endxPlains = 1017;
        int endxNewEngland = 1799;
        int endxSouthWest = 1016;
        int endxSouthEast = 1558;
        /* beginy */
        int beginyFarwest = 20;
        int beginyRockyMountain = 20;
        int beginyPlains = 20;
        int beginyNewEngland = 20;
        int beginySouthWest = 247;
        int beginySouthEast = 257;
        /* endy */
        int endyFarwest = 347;
        int endyRockyMountain = 246;
        int endyPlains = 246;
        int endyNewEngland = 257;
        int endySouthWest = 456;
        int endySouthEast = 471;
        /* ruler */
        public Func<int, int, bool> isFarWest;
        public Func<int, int, bool> isRockyMountain;
        public Func<int, int, bool> isPlains;
        public Func<int, int, bool> isNewEngland;
        public Func<int, int, bool> isSouthWest;
        public Func<int, int, bool> isSouthEast;
        public USAConst()
        {
            isFarWest = (x, y) =>
            {
                if (x > 369 && y < 152)
                    return false;
                if (y > 0.886 * x + 44.8705) 
                    return false;
                return true;
            };
            isRockyMountain = (x, y) =>
            {
                if (x < 454 && y > 152)
                    return false;
                if (x > 741 && y < 168)
                    return false;
                return true;
            };
            isPlains = (x, y) =>
            {
                if (x < 798 && y > 168)
                    return false;
                return true;
            };
            isNewEngland = (x, y) =>
            {
                if (x < 1411 && y < 0.5155 * x - 574.376)
                    return false;
                if (x > 1411 && y < -0.3139 * x + 595.8972)
                    return false;
                if (y < 2.1481 * x - 3764.3704)
                    return false;
                if (y > -0.6667 * x + 1296.6667)
                    return false;
                return true;
            };
            isSouthWest = (x, y) =>
            {
                if (x < 671 && y > 348)
                    return false;
                if (x > 671 && y > 0.4113 * x + 70.5926)
                    return false;
                if (y > -0.8101 * x + 1215.0886)
                    return false;
                return true;
            };
            isSouthEast = (x, y) =>
            {
                if (x < 1339 && y > 391)
                    return false;
                if (x > 1339 && y > 1.0256 * x - 982.3333)
                    return false;
                if (x > 1417 && y > 339)
                    return false;
                if (x > 1417 && y > -0.5745 * x + 1153.0213)
                    return false;
                return true;
            };
        }
        public string getPoints()
        {
            string result = getSuperPoint() + getDestinationPoint();
            return result;
        }
        public string getSuperPoint()
        {
            string result = "";
            result += RandomPoint(beginxFarwest, beginyFarwest, endxFarwest, endyFarwest, supernumFarWest, isFarWest);
            result += RandomPoint(beginxNewEngland, beginyNewEngland, endxNewEngland, endyNewEngland, supernumNewEngland, isNewEngland);
            result += RandomPoint(beginxPlains, beginyPlains, endxPlains, endyPlains, supernumPlains, isPlains);
            result += RandomPoint(beginxRockyMountain, beginyRockyMountain, endxRockyMountain, endyRockyMountain, supernumRockyMountain, isRockyMountain);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, supernumSouthEast, isSouthEast);
            result += RandomPoint(beginxSouthWest, beginySouthWest, endxSouthWest, endySouthWest, supernumSouthWest, isSouthWest);
            return result;
        }
        public string getDestinationPoint()
        {
            string result = "";
            result += RandomPoint(beginxFarwest, beginyFarwest, endxFarwest, endyFarwest, destinationnumFarWest, isFarWest);
            result += RandomPoint(beginxNewEngland, beginyNewEngland, endxNewEngland, endyNewEngland, destinationnumNewEngland, isNewEngland);
            result += RandomPoint(beginxPlains, beginyPlains, endxPlains, endyPlains, destinationnumPlains, isPlains);
            result += RandomPoint(beginxRockyMountain, beginyRockyMountain, endxRockyMountain, endyRockyMountain, destinationnumRockyMountain, isRockyMountain);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, destinationnumSouthEast, isSouthEast);
            result += RandomPoint(beginxSouthWest, beginySouthWest, endxSouthWest, endySouthWest, destinationnumSouthWest, isSouthWest);
            return result;
        }
        private static string RandomPoint(int beginx, int beginy, int endx, int endy, int num, Func<int, int, bool> ruler)
        {
            int disx = endx - beginx;
            int disy = endy - beginy;
            int[] Array = new int[disx * disy];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i;
            }
            int minPointIndex = 0;
            Random m = new Random(DateTime.Now.Millisecond);
            int nowRandom, temp;
            for (int i = Array.Length - 1; i > minPointIndex; i--)
            {
                nowRandom = m.Next(0, i + 1);
                temp = Array[i];
                Array[i] = Array[nowRandom];
                Array[nowRandom] = temp;
            }
            string result = "";
            int index = 0;
            for (int i = 0; i < num; i++)
            {
                int xnow = Array[index] % disx + beginx;
                int ynow = Array[index] / disx + beginy;
                index++;
                while (!ruler(xnow, ynow)) 
                {
                    xnow = Array[index] % disx + beginx;
                    ynow = Array[index] / disx + beginy;
                    index++;
                }
                result += xnow.ToString() + "," + ynow.ToString();
                result += "\r\n";
            }
            return result;
        }
    }
}
