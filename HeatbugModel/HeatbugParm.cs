using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HeatbugModel
{
    static class HeatbugParm
    {
        public static int displayFrequency = 1;
        public static int worldWidth = 80;
        public static int worldHeight = 80;
        public static int Scale = 9;
        public static double idealTemp = 0;
        public static void addRandomBugs(this List<Heatbug> bugs, int num)
        {
            int[] allPoint = getRandomArray(worldWidth * worldHeight, num);
            int nowIndex = allPoint.Length - 1;
            for (int i = 0; i < num; i++) 
            {
                int now = allPoint[nowIndex];
                nowIndex--;
                int x = (now % worldWidth);
                int y = (now / worldWidth);
                bugs.Add(new Heatbug(x, y, idealTemp));
            }
        }
        public static void addFileBugs(this List<Heatbug> bugs, FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            string line;
            while (!string.IsNullOrEmpty(line = sr.ReadLine()))  
            {
                string[]subline = line.Split(',');
                int x = Convert.ToInt32(subline[0]);
                int y = Convert.ToInt32(subline[1]);
                bugs.Add(new Heatbug(x, y, idealTemp));
            }
        }
        private static int[] getRandomArray(int Length, int RandomNum)
        {
            int[] Array = new int[Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i;
            }
            int minPointIndex = Array.Length - 1 - RandomNum;
            Random m = new Random(DateTime.Now.Millisecond);
            int nowRandom, temp;
            for (int i = Array.Length - 1; i > minPointIndex; i--)
            {
                nowRandom = m.Next(0, i + 1);
                temp = Array[i];
                Array[i] = Array[nowRandom];
                Array[nowRandom] = temp;
            }
            return Array;
        }
    }
}
