using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatbugModel
{
    class SouthKoreaConst
    {
        /* LongitudeAndLatitude */
        int beginLongitude = 125;
        int endLongitude = 130;
        int beginLatitude = 59;
        int endLatitude = 54;
        /* img */
        int imgWidth = 1104;
        int imgHeight = 2000;
        int distancePerPX = 278;
        /* destination */
        int destinationnumNorthWest = 40299;
        int destinationnumNorthEast = 2416;
        int destinationnumMidland = 23419;
        int destinationnumSouthEast = 13867;
        /* super */
        int supernumNorthWest = 10075;
        int supernumNorthEast = 604;
        int supernumMidland = 5855;
        int supernumSouthEast = 3467;
        /* beginx */
        int beginxNorthWest = 348;
        int beginxNorthEast = 637;
        int beginxMidland = 264;
        int beginxSouthEast = 737;
        /* endx */
        int endxNorthWest = 637;
        int endxNorthEast = 967;
        int endxMidland = 971;
        int endxSouthEast = 1010;
        /* beginy */
        int beginyNorthWest = 297;
        int beginyNorthEast = 129;
        int beginyMidland = 749;
        int beginySouthEast = 1201;
        /* endy */
        int endyNorthWest = 749;
        int endyNorthEast = 749;
        int endyMidland = 1868;
        int endySouthEast = 1714;
        /* ruler */
        public Func<int, int, bool> isNorthWest;
        public Func<int, int, bool> isNorthEast;
        public Func<int, int, bool> isMidland;
        public Func<int, int, bool> isSouthEast;
        public SouthKoreaConst()
        {
            isNorthWest = (x, y) =>
            {
                if (y < -1.6885 * x + 1090.6066) 
                    return false;
                if (y > 3.3818 * x - 613.8727)
                    return false;
                return true;
            };
            isNorthEast = (x, y) =>
            {
                if (y < -0.8125 * x + 832.5625)
                    return false;
                if (y < 2.6634 * x - 1826.4752)
                    return false;
                return true;
            };
            isMidland = (x, y) =>
            {
                if (x < -1.1301 * y + 1249.4309)
                    return false;
                if (x < 0.3261 * y - 20.3989 && y < 1243)
                    return false;
                if (x < -0.3746 * y + 850.644 && y > 1243) 
                    return false;
                if (x > 737 && y > 1201)
                    return false;
                if (y > -0.7816 * x + 2197.0728)
                    return false;
                return true;
            };
            isSouthEast = (x, y) =>
            {
                if (y > 0.4211 * x + 1371.6842)
                    return false;
                if (y > -13.1 * x + 12364.3 && x < 823) 
                    return false;
                if (x > 823 && x < 896 && y > 1583)
                    return false;
                if (x > 896 && y > -3.3509 * x + 4585.386)
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
            result += RandomPoint(beginxMidland, beginyMidland, endxMidland, endyMidland, supernumMidland, isMidland);
            result += RandomPoint(beginxNorthEast, beginyNorthEast, endxNorthEast, endyNorthEast, supernumNorthEast, isNorthEast);
            result += RandomPoint(beginxNorthWest, beginyNorthWest, endxNorthWest, endyNorthWest, supernumNorthWest, isNorthWest);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, supernumSouthEast, isSouthEast);
            return result;
        }
        public string getDestinationPoint()
        {
            string result = "";
            result += RandomPoint(beginxMidland, beginyMidland, endxMidland, endyMidland, destinationnumMidland, isMidland);
            result += RandomPoint(beginxNorthEast, beginyNorthEast, endxNorthEast, endyNorthEast, destinationnumNorthEast, isNorthEast);
            result += RandomPoint(beginxNorthWest, beginyNorthWest, endxNorthWest, endyNorthWest, destinationnumNorthWest, isNorthWest);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, destinationnumSouthEast, isSouthEast);
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
