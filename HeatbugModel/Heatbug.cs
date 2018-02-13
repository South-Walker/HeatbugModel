using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace HeatbugModel
{
    public class Heatbug
    {
        public double idealTemp = 1;
        public Point Position;
        public static Random rdForAnnealing;
        public static int AnnealingTemperature = 32768;
        public static int[,] pointHeat;
        public int maxOutputHeat = 7;
        public int stepOutputHeat = 1;
        public int minOutputHeat = 0;
        public double Unhappiness
        {
            get
            {
                return getUnhappiness();
            }
        }
        public int maxStep
        {
            get
            {
                return (maxOutputHeat - minOutputHeat) / stepOutputHeat;
            }
        }
        public int HeatTo(int x,int y)
        {
            int distance = Math.Abs(this.Position.X - x) + Math.Abs(this.Position.Y - y);
            int heat = maxOutputHeat - distance * stepOutputHeat;
            return (heat < minOutputHeat) ? 0 : heat;
        }
        public Heatbug(int x, int y, double idealtemp = 1)
        {
            Position = new Point(x, y);
            idealTemp = idealtemp;
        }
        public Heatbug(Point position,double idealtemp = 1)
        {
            Position = position;
            idealTemp = idealtemp;
        }
        public double getUnhappiness()
        {
            return getUnhappiness(this.Position.X, this.Position.Y);
        }
        public double getUnhappiness(int x, int y)
        {
            double result = (HeatbugParm.idealTemp - pointHeat[x, y] + this.HeatTo(x, y)) / idealTemp;
            return result * result;
        }
        public double getUnhappiness(Point point)
        {
            return getUnhappiness(point.X, point.Y);
        }
        public void Move()
        {
            Func<double, double, bool> couldNewUnhappinessAcceptable = (newUnhappiness, oldUnhappiness) =>
           {
               if (newUnhappiness < oldUnhappiness)
               {
                   return true;
               }
               else
               {
                   double random = rdForAnnealing.NextDouble();
                   double diffUnhappiness = newUnhappiness - oldUnhappiness;
                   diffUnhappiness *= -1;
                   return Math.Exp(diffUnhappiness / AnnealingTemperature) > random;
               }
           };
            int offsetX = 0; int offsetY = 0; double nowUnhappiness = getUnhappiness();
            if (this.Position.X - 1 >= 0)
            {
                double newUnhappiness = getUnhappiness(new Point(this.Position.X - 1, this.Position.Y));
                if (couldNewUnhappinessAcceptable(newUnhappiness, nowUnhappiness)) 
                {
                    nowUnhappiness = newUnhappiness;
                    offsetX -= 1;
                }
            }
            if (this.Position.X + 1 < HeatbugParm.worldWidth)
            {
                double newUnhappiness = getUnhappiness(new Point(this.Position.X + 1, this.Position.Y));
                if (couldNewUnhappinessAcceptable(newUnhappiness, nowUnhappiness))
                {
                    offsetX += 1;
                }
            }
            if (this.Position.Y - 1 >= 0)
            {
                double newUnhappiness = getUnhappiness(new Point(this.Position.X, this.Position.Y - 1));
                if (couldNewUnhappinessAcceptable(newUnhappiness, nowUnhappiness))
                {
                    nowUnhappiness = newUnhappiness;
                    offsetY -= 1;
                }
            }
            if (this.Position.Y + 1 < HeatbugParm.worldHeight)
            {
                double newUnhappiness = getUnhappiness(new Point(this.Position.X, this.Position.Y + 1));
                if (couldNewUnhappinessAcceptable(newUnhappiness, nowUnhappiness))
                {
                    nowUnhappiness = newUnhappiness;
                    offsetY += 1;
                }
            }
            this.Position.Offset(offsetX, offsetY);
        }
        public static implicit operator Point(Heatbug bug)
        {
            return bug.Position;
        }
        public static void refreshHeat(IEnumerable<Heatbug> Bugs)
        {
            pointHeat = new int[HeatbugParm.worldWidth, HeatbugParm.worldHeight];
            foreach (var bug in Bugs)
            {
                getHeater(bug.Position, bug);
            }
        }
        public static double getAllUnhappiness(IEnumerable<Heatbug> Bugs)
        {
            double result = 0;
            foreach (var bug in Bugs)
            {
                result += bug.Unhappiness;
            }
            return result;
        }
        private static void getHeater(Point now, Heatbug bug)
        {
            int distance = Math.Abs(now.X - bug.Position.X) + Math.Abs(now.Y - bug.Position.Y);
            if (distance >= bug.maxStep)
                return;
            if (now.X < 0 || now.Y < 0 || now.X >= Heatbug.pointHeat.GetLength(0) || now.Y >= Heatbug.pointHeat.GetLength(1))
                return;
            Heatbug.pointHeat[now.X, now.Y] += 10 - distance * bug.stepOutputHeat;
            if (bug.Position.Y == now.Y)
            {
                if (bug.Position.X == now.X)
                {
                    getHeater(new Point(now.X - 1, now.Y), bug);
                    getHeater(new Point(now.X + 1, now.Y), bug);
                }
                if (bug.Position.X > now.X)
                {
                    getHeater(new Point(now.X - 1, now.Y), bug);
                }
                if (bug.Position.X < now.X)
                {
                    getHeater(new Point(now.X + 1, now.Y), bug);
                }
            }
            if (bug.Position.Y >= now.Y)
            {
                getHeater(new Point(now.X, now.Y - 1), bug);
            }
            if (bug.Position.Y <= now.Y)
            {
                getHeater(new Point(now.X, now.Y + 1), bug);
            }
        }
    }
}
