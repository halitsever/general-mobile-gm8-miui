using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing.Drawing2D;


namespace miui
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public int onay1;
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            onay1 = 2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("murat100, cıyanogen,erdil sualp, yey59, barishirece, reloaded2023, erdi, resul, çağan, neqative/romRunner, kaan mert,  mutlu, utkui, enesfb, samed, m.can, abdullah, barış gök, kucuk yigit");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gm8miui.glitch.me/bagis.html");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            if (checkBox1.Checked)
            {
                onay1 = 1;
                Console.WriteLine(onay1);
            }
            this.Hide();

        }
    }
}
