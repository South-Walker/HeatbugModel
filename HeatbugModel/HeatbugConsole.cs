using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatbugModel
{
    public partial class HeatbugConsole : Form
    {
        HeatWorld world = null;
        List<double> Unhappiness;
        List<double> darkSizeRate;
        int time = 0;
        public HeatbugConsole()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            HeatbugParm.worldHeight = Convert.ToInt32(tbWorldHeght.Text);
            HeatbugParm.worldWidth = Convert.ToInt32(tbWorldWidth.Text);
            HeatbugParm.Scale = Convert.ToInt32(tbScale.Text);
            HeatbugParm.displayFrequency = Convert.ToInt32(tbDisplayFrequency.Text);
            world = new HeatWorld();
            world.resetData();
            world.Show();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            HeatbugParm.displayFrequency = Convert.ToInt32(tbDisplayFrequency.Text);
            if (world != null)
            {
                for (int i = 0; i < HeatbugParm.displayFrequency; i++)
                {
                    if (darkSizeRate == null || Unhappiness == null) 
                    {
                        darkSizeRate = new List<double>();
                        Unhappiness = new List<double>();
                        Unhappiness.Add(world.getAllUnhappiness());
                        darkSizeRate.Add(world.getDarkSizeRate());
                    }
                    world.nextFrame(i == HeatbugParm.displayFrequency - 1);
                    time++;
                    Unhappiness.Add(world.getAllUnhappiness());
                    darkSizeRate.Add(world.getDarkSizeRate());
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                world.imgHeatWorld.Save(path + ".png");
                string unhappiness = "unhappiness=[";
                string darksizerate = "darksizerate=[";
                string time = "time=[";
                int timeNow = 0;
                bool isfirst = true;
                if (Unhappiness == null)
                    return;
                foreach (double unhappinessNow in Unhappiness)
                {
                    if (!isfirst)
                    {
                        unhappiness += ",";
                        time += ",";
                    }
                    isfirst = false;
                    unhappiness += unhappinessNow.ToString();
                    time += timeNow.ToString();
                    timeNow++;
                }
                time += "];";
                unhappiness += "];";
                isfirst = true;
                foreach (double darksizerateNow in darkSizeRate)
                {
                    if (!isfirst)
                    {
                        darksizerate += ",";
                    }
                    isfirst = false;
                    darksizerate += darksizerateNow.ToString();
                }
                darksizerate += "];";
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(unhappiness + darksizerate + time);
                    sw.Flush();
                }
            }
        }
        private void btRandom_Click(object sender, EventArgs e)
        {
            HeatbugParm.idealTemp = Convert.ToInt32(tbIdealTemp.Text);
            world.addRandomBug(Convert.ToInt32(tbNumBugs.Text));
        }

        private void btFromFile_Click(object sender, EventArgs e)
        {
            /*
            string[] paths = {
                @"C:\Users\Administrator\Desktop\accepttemp.txt",
                @"C:\Users\Administrator\Desktop\idealtemp.txt" };
            int idealtemp = 64;
            foreach (var item in paths)
            {
                HeatbugParm.idealTemp = idealtemp;
                idealtemp *= 2;
                using (FileStream fs = new FileStream(item, FileMode.Open, FileAccess.Read))
                {
                    world.addFileBug(fs);
                }
            }
            */
            HeatbugParm.idealTemp = Convert.ToInt32(tbIdealTemp.Text);
            string path = tbBugsPath.Text;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) 
            {
                world.addFileBug(fs);
            }
        }
        private void allTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}