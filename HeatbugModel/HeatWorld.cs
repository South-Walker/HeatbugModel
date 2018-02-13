using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HeatbugModel
{
    public partial class HeatWorld : Form
    {
        public List<Heatbug> Bugs = new List<Heatbug>();
        public Bitmap imgHeatWorld;
        int size;
        Graphics g;
        public HeatWorld()
        {
            InitializeComponent();
        }

        private void HeatWorld_Load(object sender, EventArgs e)
        {
            resetData();
        }
        public void resetData()
        {
            Heatbug.pointHeat = new int[HeatbugParm.worldWidth, HeatbugParm.worldHeight];
            pbHeatWorld.Width = HeatbugParm.worldWidth * HeatbugParm.Scale;
            pbHeatWorld.Height = HeatbugParm.worldHeight * HeatbugParm.Scale;
            size = HeatbugParm.worldWidth * HeatbugParm.worldHeight;
            this.Width = pbHeatWorld.Width + 18;
            this.Height = pbHeatWorld.Height + 45;
            imgHeatWorld = new Bitmap(pbHeatWorld.Width, pbHeatWorld.Height);
            g = Graphics.FromImage(imgHeatWorld);
            drawHeatWorld();
        }
        public void addRandomBug(int num)
        {
            Bugs.addRandomBugs(num);
            drawHeatWorld();
        }
        public void addFileBug(FileStream fs)
        {
            Bugs.addFileBugs(fs);
            drawHeatWorld();
        }
        public void nextFrame(bool isdraw = true)
        {
            moveBugs();
            drawHeatWorld(isdraw);
        }
        public void drawHeatWorld(bool isdraw = true)
        {
            refreshHeat();
            if (isdraw)
            {
                g.Clear(Color.Black);
                g.DrawHeat(Heatbug.pointHeat, HeatbugParm.Scale);
                g.DrawBugs(Bugs, HeatbugParm.Scale);
                pbHeatWorld.Image = imgHeatWorld;
            }
        }
        private void moveBugs()
        {
            if (Heatbug.AnnealingTemperature != 1)
            {
                Heatbug.AnnealingTemperature = Heatbug.AnnealingTemperature >> 1;
            }
            Heatbug.rdForAnnealing = new Random(DateTime.Now.Millisecond);
            foreach (var bug in Bugs)
            {
                bug.Move();
            }
        }
        public void refreshHeat()
        {
            Heatbug.refreshHeat(Bugs);
        }
        public double getAllUnhappiness()
        {
            return Heatbug.getAllUnhappiness(Bugs);
        }
        public double getDarkSizeRate()
        {
            double allSize = Heatbug.pointHeat.GetLength(0) * Heatbug.pointHeat.GetLength(1);
            double darknum = 0;
            for (int x = 0; x < Heatbug.pointHeat.GetLength(0); x++) 
            {
                for (int y = 0; y < Heatbug.pointHeat.GetLength(1); y++)
                {
                    if (Heatbug.pointHeat[x, y] == 0)
                        darknum++;
                }
            }
            return darknum / allSize;
        }
    }
    public static class ExpandGraphics
    {
        public static void DrawBug(this Graphics g, Heatbug Bug,int scale)
        {
            Point point = new Point(Bug.Position.X * scale, Bug.Position.Y * scale);
            g.FillRectangle(Brushes.Green, new Rectangle(point, new Size(scale, scale)));
        }
        public static void DrawBugs(this Graphics g, IEnumerable<Heatbug> Bugs, int scale)
        {
            foreach (var Bug in Bugs)
            {
                g.DrawBug(Bug, scale);
            }
        }
        public static void DrawHeat(this Graphics g, int[,] pointHeat, int scale)
        {
            for (int x = 0; x < pointHeat.GetLength(0); x++)
            {
                for (int y = 0; y < pointHeat.GetLength(1); y++)
                {
                    Point point = new Point(x * scale, y * scale);
                    int red = 10 * pointHeat[x, y];
                    red = (red > 256) ? 255 : red;
                    g.FillRectangle(new SolidBrush((Color.FromArgb(red, 0, 0))), new Rectangle(point, new Size(scale, scale)));
                }
            }
        }
    }
}
