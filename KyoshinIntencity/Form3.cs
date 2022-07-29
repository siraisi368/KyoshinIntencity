using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace KyoshinIntencity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private readonly WebClient wc1 = new WebClient();
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            System.Drawing.Point cp = this.PointToClient(sp);
            int x = cp.X;
            int y = cp.Y;
            label5.Text = x.ToString();
            label6.Text = y.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xzahyou;
            int yzahyou;
            int.TryParse(label5.Text, out xzahyou);
            int.TryParse(label6.Text, out yzahyou);
            Properties.Settings.Default.set_point_x = xzahyou;
            Properties.Settings.Default.set_point_y = yzahyou;
            Form2.Form2Instans.TextBoxText1 = xzahyou.ToString();
            Form2.Form2Instans.TextBoxText2 = yzahyou.ToString();
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            var dt = dt1.AddSeconds(-2);
            var url1 = $"http://www.kmoni.bosai.go.jp//data/map_img/RealTimeImg/jma_s/{dt.ToString("yyyyMMdd")}/{dt.ToString("yyyyMMddHHmmss")}.jma_s.gif";
            Stream stream1 = wc1.OpenRead(url1);
            Bitmap bitmap1 = new Bitmap(stream1);
            stream1.Close();
            bitmap1.MakeTransparent();
            pictureBox1.Image = bitmap1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
