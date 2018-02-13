using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatbugModel
{
    class AustraliaConst
    {
        /* LongitudeAndLatitude */
        int beginLongitude = 110;
        int endLongitude = 160;
        int beginLatitude = -10;
        int endLatitude = -40;
        /* img */
        int imgWidth = 2000;
        int imgHeight = 1333;
        int distancePerPX = 2500;
        /* destination */
        int destinationnumWest = 16695;
        int destinationnumNorth = 1587;
        int destinationnumNorthEast = 30724;
        int destinationnumSouthEast = 90140;
        int destinationnumSouth = 10855;
        /* super */
        int supernumWest = 6241;
        int supernumNorth = 578;
        int supernumNorthEast = 7693;
        int supernumSouthEast = 23016;
        int supernumSouth = 2472;
        /* beginx */
        int beginxWest = 127;
        int beginxNorth = 757;
        int beginxNorthEast = 1121;
        int beginxSouthEast = 1243;
        int beginxSouth = 757;
        /* endx */
        int endxWest = 757;
        int endxNorth = 1121;
        int endxNorthEast = 1741;
        int endxSouthEast = 1741;
        int endxSouth = 1243;
        /* beginy */
        int beginyWest = 165;
        int beginyNorth = 49;
        int beginyNorthEast = 35;
        int beginySouthEast = 843;
        int beginySouth = 713;
        /* endy */
        int endyWest = 1111;
        int endyNorth = 713;
        int endyNorthEast = 841;
        int endySouthEast = 1283;
        int endySouth = 1255;
        /* ruler */
        public Func<int, int, bool> isWest;
        public Func<int, int, bool> isNorth;
        public Func<int, int, bool> isNorthEast;
        public Func<int, int, bool> isSouthEast;
        public Func<int, int, bool> isSouth;
        public AustraliaConst()
        {
            isWest = (x, y) =>
            {
                if (x < 485 && y < -0.5922 * x + 656.2067)
                    return false;
                if (x >= 485 && x < 679 && y < -1.0515 * x + 879)
                    return false;
                if (x >= 679 && y < 0.6 * x - 242.4)
                    return false;
                if (y > 581 && y < 1005 && x < 0.2547 * y - 20.9906)
                    return false;
                if (y >= 1005 && x < -0.4151 * y + 652.1698)
                    return false;
                if (y > -0.3426 * x + 1222.3426)
                    return false; 
                return true;
            };
            isNorth = (x, y) =>
            {
                if (y < -1.907 * x + 1660.3953)
                    return false;
                if (y < 211 && x > -0.1235 * y + 1049.0494)
                    return false;
                if (y >= 211 && y < 281 && x > 1.3714 * y + 733.6286)
                    return false;
                return true;
            };
            isNorthEast = (x, y) =>
            {
                if (y < 347 && x < 1213 && x > 1.3714 * y + 733.6286) 
                    return false;
                if (x >= 1213 && x < 1283 && y < -4.4286 * x + 5718.8571) 
                    return false;
                if (x >= 1283 && y < 1.6295 * x - 2053.6027)
                    return false;
                if (x < 1239 && y > 709)
                    return false;
                return true;
            };
            isSouthEast = (x, y) =>
            {
                if (y > -1.4029 * x + 3335.4101)
                    return false;
                return true;
            };
            isSouth = (x, y) =>
            {
                if (x < 945 && y > 0.0532 * x + 922.734)
                    return false;
                if (x >= 945 && x < 1037 && y > 1.4565 * x - 403.413)
                    return false;
                if (x >= 1037 && x < 1161 && y > 1107)
                    return false;
                if (x >= 1161 && y > 1.8049 * x - 988.4634)
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
            result += RandomPoint(beginxWest, beginyWest, endxWest, endyWest, supernumWest, isWest);
            result += RandomPoint(beginxNorth, beginyNorth, endxNorth, endyNorth, supernumNorth, isNorth);
            result += RandomPoint(beginxNorthEast, beginyNorthEast, endxNorthEast, endyNorthEast, supernumNorthEast, isNorthEast);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, supernumSouthEast, isSouthEast);
            result += RandomPoint(beginxSouth, beginySouth, endxSouth, endySouth, supernumSouth, isSouth);
            return result;
        }
        public string getDestinationPoint()
        {
            string result = "";
            result += RandomPoint(beginxWest, beginyWest, endxWest, endyWest, destinationnumWest, isWest);
            result += RandomPoint(beginxNorth, beginyNorth, endxNorth, endyNorth, destinationnumNorth, isNorth);
            result += RandomPoint(beginxNorthEast, beginyNorthEast, endxNorthEast, endyNorthEast, destinationnumNorthEast, isNorthEast);
            result += RandomPoint(beginxSouthEast, beginySouthEast, endxSouthEast, endySouthEast, destinationnumSouthEast, isSouthEast);
            result += RandomPoint(beginxSouth, beginySouth, endxSouth, endySouth, destinationnumSouth, isSouth);
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
