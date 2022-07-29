using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyoshinIntencity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private static Form2 _form2Instance;
        public static Form2 Form2Instans
        {
            get
            {
                return _form2Instance;
            }
            set
            {
                _form2Instance = value;
            }
        }
        public string TextBoxText1
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string TextBoxText2
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2.Form2Instans = this;
            textBox1.Text = Properties.Settings.Default.set_point_x.ToString();
            textBox2.Text = Properties.Settings.Default.set_point_y.ToString();
            textBox3.Text = Properties.Settings.Default.set_viewname;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.set_viewname = textBox3.Text;
            Properties.Settings.Default.Save();
            this.Close();
            await Task.Delay(1000);
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = Properties.Settings.Default.d_Color;
            color.AllowFullOpen = true;
            color.SolidColorOnly = false;
            if(color.ShowDialog()==DialogResult.OK)
            {
                Properties.Settings.Default.d_Color = color.Color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
