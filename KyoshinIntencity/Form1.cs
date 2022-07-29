using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using NAudio.Wave;

namespace KyoshinIntencity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public System.Drawing.Bitmap b;
        public DateTime d;
        
        private void GetPicel()
        {
            try
            {
                d = DateTime.Now.AddSeconds(-2);

                var d1 = d.ToString("yyyyMMdd");
                var d2 = d.ToString("yyyyMMddHHmmss");
                var w = new WebClient();
                var s = w.OpenRead($"http://www.kmoni.bosai.go.jp//data/map_img/RealTimeImg/jma_s/{d1}/{d2}.jma_s.gif");
                b = new Bitmap(s);
                w.Dispose();
                s.Close();
                Color c = b.GetPixel(Properties.Settings.Default.set_point_x, Properties.Settings.Default.set_point_y);
                panel1.BackColor = c;
                label1.Text = ChangeToShindo(c.R, c.G, c.B);
                
                GC.Collect();
            }
            catch(Exception ex) { label1.Text = ex.ToString(); }
        }
        private string ChangeToShindo(int R, int G, int B)
        {
            string s = "0.0";
            if((R==0)&(G==0)&(B==0))
            {
                s = "-.-";
            }
            else
            {
                s = "取得中";
            }
            //↓ここから↓色のやつ
            if ((R == 0) & (G == 0) & (B == 205))
            {
                s = "≦-3.0";
            }
            if ((R == 0) & (G == 7) & (B == 209))
            {
                s = "-2.9";
            }
            if ((R == 0) & (G == 14) & (B == 214))
            {
                s = "-2.8";
            }
            if ((R == 0) & (G == 21) & (B == 218))
            {
                s = "-2.7";
            }
            if ((R == 0) & (G == 28) & (B == 223))
            {
                s = "-2.6";
            }
            if ((R == 0) & (G == 36) & (B == 227))
            {
                s = "-2.5";
            }
            if ((R == 0) & (G == 43) & (B == 231))
            {
                s = "-2.4";
            }
            if ((R == 0) & (G == 50) & (B == 236))
            {
                s = "-2.3";
            }
            if ((R == 0) & (G == 57) & (B == 240))
            {
                s = "-2.2";
            }
            if ((R == 0) & (G == 64) & (B == 245))
            {
                s = "-2.1";
            }
            if ((R == 0) & (G == 72) & (B == 250))
            {
                s = "-2.0";
            }
            if ((R == 0) & (G == 85) & (B == 238))
            {
                s = "-1.9";
            }
            if ((R == 0) & (G == 99) & (B == 227))
            {
                s = "-1.8";
            }
            if ((R == 0) & (G == 112) & (B == 216))
            {
                s = "-1.7";
            }
            if ((R == 0) & (G == 126) & (B == 205))
            {
                s = "-1.6";
            }
            if ((R == 0) & (G == 140) & (B == 194))
            {
                s = "-1.5";
            }
            if ((R == 0) & (G == 153) & (B == 183))
            {
                s = "-1.4";
            }
            if ((R == 0) & (G == 167) & (B == 172))
            {
                s = "-1.3";
            }
            if ((R == 0) & (G == 180) & (B == 161))
            {
                s = "-1.2";
            }
            if ((R == 0) & (G == 194) & (B == 150))
            {
                s = "-1.1";
            }
            if ((R == 0) & (G == 208) & (B == 139))
            {
                s = "-1.0";
            }
            if ((R == 6) & (G == 212) & (B == 130))
            {
                s = "-0.9";
            }
            if ((R == 12) & (G == 216) & (B == 121))
            {
                s = "-0.8";
            }
            if ((R == 18) & (G == 220) & (B == 113))
            {
                s = "-0.7";
            }
            if ((R == 25) & (G == 224) & (B == 104))
            {
                s = "-0.6";
            }
            if ((R == 31) & (G == 228) & (B == 96))
            {
                s = "-0.5";
            }
            if ((R == 37) & (G == 233) & (B == 88))
            {
                s = "-0.4";
            }
            if ((R == 44) & (G == 237) & (B == 79))
            {
                s = "-0.3";
            }
            if ((R == 50) & (G == 241) & (B == 71))
            {
                s = "-0.2";
            }
            if ((R == 56) & (G == 245) & (B == 62))
            {
                s = "-0.1";
            }
            if ((R == 63) & (G == 250) & (B == 54))
            {
                s = "0.0";
            }
            if ((R == 75) & (G == 250) & (B == 49))
            {
                s = "0.1";
            }
            if ((R == 88) & (G == 250) & (B == 45))
            {
                s = "0.2";
            }
            if ((R == 100) & (G == 251) & (B == 41))
            {
                s = "0.3";
            }
            if ((R == 113) & (G == 251) & (B == 37))
            {
                s = "0.4";
            }
            if ((R == 125) & (G == 252) & (B == 33))
            {
                s = "0.5";
            }
            if ((R == 138) & (G == 252) & (B == 28))
            {
                s = "0.6";
            }
            if ((R == 151) & (G == 253) & (B == 24))
            {
                s = "0.7";
            }
            if ((R == 163) & (G == 253) & (B == 20))
            {
                s = "0.8";
            }
            if ((R == 176) & (G == 254) & (B == 16))
            {
                s = "0.9";
            }
            if ((R == 189) & (G == 255) & (B == 12))
            {
                s = "1.0";
            }
            if ((R == 195) & (G == 254) & (B == 10))
            {
                s = "1.1";
            }
            if ((R == 202) & (G == 254) & (B == 9))
            {
                s = "1.2";
            }
            if ((R == 208) & (G == 254) & (B == 8))
            {
                s = "1.3";
            }
            if ((R == 215) & (G == 254) & (B == 7))
            {
                s = "1.4";
            }
            if ((R == 222) & (G == 255) & (B == 5))
            {
                s = "1.5";
            }
            if ((R == 228) & (G == 254) & (B == 4))
            {
                s = "1.6";
            }
            if ((R == 235) & (G == 255) & (B == 3))
            {
                s = "1.7";
            }
            if ((R == 241) & (G == 254) & (B == 2))
            {
                s = "1.8";
            }
            if ((R == 248) & (G == 255) & (B == 1))
            {
                s = "1.9";
            }
            if ((R == 255) & (G == 255) & (B == 0))
            {
                s = "2.0";
            }
            if ((R == 254) & (G == 251) & (B == 0))
            {
                s = "2.1";
            }
            if ((R == 254) & (G == 248) & (B == 0))
            {
                s = "2.2";
            }
            if ((R == 254) & (G == 244) & (B == 0))
            {
                s = "2.3";
            }
            if ((R == 254) & (G == 241) & (B == 0))
            {
                s = "2.4";
            }
            if ((R == 255) & (G == 238) & (B == 0))
            {
                s = "2.5";
            }
            if ((R == 254) & (G == 234) & (B == 0))
            {
                s = "2.6";
            }
            if ((R == 255) & (G == 231) & (B == 0))
            {
                s = "2.7";
            }
            if ((R == 254) & (G == 227) & (B == 0))
            {
                s = "2.8";
            }
            if ((R == 255) & (G == 224) & (B == 0))
            {
                s = "2.9";
            }
            if ((R == 255) & (G == 221) & (B == 0))
            {
                s = "3.0";
            }
            if ((R == 254) & (G == 213) & (B == 0))
            {
                s = "3.1";
            }
            if ((R == 254) & (G == 205) & (B == 0))
            {
                s = "3.2";
            }
            if ((R == 254) & (G == 197) & (B == 0))
            {
                s = "3.3";
            }
            if ((R == 254) & (G == 190) & (B == 0))
            {
                s = "3.4";
            }
            if ((R == 255) & (G == 182) & (B == 0))
            {
                s = "3.5";
            }
            if ((R == 254) & (G == 174) & (B == 0))
            {
                s = "3.6";
            }
            if ((R == 255) & (G == 167) & (B == 0))
            {
                s = "3.7";
            }
            if ((R == 254) & (G == 159) & (B == 0))
            {
                s = "3.8";
            }
            if ((R == 255) & (G == 151) & (B == 0))
            {
                s = "3.9";
            }
            if ((R == 255) & (G == 144) & (B == 0))
            {
                s = "4.0";
            }
            if ((R == 254) & (G == 136) & (B == 0))
            {
                s = "4.1";
            }
            if ((R == 254) & (G == 128) & (B == 0))
            {
                s = "4.2";
            }
            if ((R == 254) & (G == 121) & (B == 0))
            {
                s = "4.3";
            }
            if ((R == 254) & (G == 113) & (B == 0))
            {
                s = "4.4";
            }
            if ((R == 255) & (G == 106) & (B == 0))
            {
                s = "4.5";
            }
            if ((R == 254) & (G == 98) & (B == 0))
            {
                s = "4.6";
            }
            if ((R == 255) & (G == 90) & (B == 0))
            {
                s = "4.7";
            }
            if ((R == 254) & (G == 83) & (B == 0))
            {
                s = "4.8";
            }
            if ((R == 255) & (G == 75) & (B == 0))
            {
                s = "4.9";
            }
            if ((R == 255) & (G == 68) & (B == 0))
            {
                s = "5.0";
            }
            if ((R == 254) & (G == 61) & (B == 0))
            {
                s = "5.1";
            }
            if ((R == 253) & (G == 54) & (B == 0))
            {
                s = "5.2";
            }
            if ((R == 252) & (G == 47) & (B == 0))
            {
                s = "5.3";
            }
            if ((R == 251) & (G == 40) & (B == 0))
            {
                s = "5.4";
            }
            if ((R == 250) & (G == 33) & (B == 0))
            {
                s = "5.5";
            }
            if ((R == 249) & (G == 27) & (B == 0))
            {
                s = "5.6";
            }
            if ((R == 248) & (G == 20) & (B == 0))
            {
                s = "5.7";
            }
            if ((R == 247) & (G == 13) & (B == 0))
            {
                s = "5.8";
            }
            if ((R == 246) & (G == 6) & (B == 0))
            {
                s = "5.9";
            }
            if ((R == 245) & (G == 0) & (B == 0))
            {
                s = "6.0";
            }
            if ((R == 238) & (G == 0) & (B == 0))
            {
                s = "6.1";
            }
            if ((R == 230) & (G == 0) & (B == 0))
            {
                s = "6.2";
            }
            if ((R == 223) & (G == 0) & (B == 0))
            {
                s = "6.3";
            }
            if ((R == 215) & (G == 0) & (B == 0))
            {
                s = "6.4";
            }
            if ((R == 208) & (G == 0) & (B == 0))
            {
                s = "6.5";
            }
            if ((R == 200) & (G == 0) & (B == 0))
            {
                s = "6.6";
            }
            if ((R == 192) & (G == 0) & (B == 0))
            {
                s = "6.7";
            }
            if ((R == 185) & (G == 0) & (B == 0))
            {
                s = "6.8";
            }
            if ((R == 177) & (G == 0) & (B == 0))
            {
                s = "6.9";
            }
            if ((R == 170) & (G == 0) & (B == 0))
            {
                s = "7.0≦";
            }
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPicel();
            GetPixel.Enabled = true;
            GetPixel.Interval = 1000;
            panel2.BackColor = Properties.Settings.Default.d_Color;
            label3.Text = Properties.Settings.Default.set_viewname;
        }

        private void GetPixel_Tick(object sender, EventArgs e)
        {
            GetPicel();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
