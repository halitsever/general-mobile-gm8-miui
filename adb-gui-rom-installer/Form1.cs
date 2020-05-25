using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace miui
{


    public partial class Form1 : Form
    {
        private Process process = new Process();
        private ProcessStartInfo info = new ProcessStartInfo();



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



        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox3;
            pictureBox1.BackColor = Color.Transparent;
            this.IsMdiContainer = true;

            pictureBox2.Parent = pictureBox3;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox4.Parent = pictureBox3;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox5.Parent = pictureBox3;
            pictureBox5.BackColor = Color.Transparent;

            pictureBox6.Parent = pictureBox3;
            pictureBox6.BackColor = Color.Transparent;
        }



        private void button1_Click(object sender, EventArgs e)
        {


            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            info.FileName = "adb.exe";
            info.Arguments = "reboot bootloader";
            process.StartInfo = info;

            process.Start();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                info.FileName = "adb.exe";
                info.Arguments = "devices";
                process.StartInfo = info;

                process.Start();

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            info.FileName = "d.bat";
            process.StartInfo = info;

            process.Start();
           

        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            info.FileName = "d.bat";
            process.StartInfo = info;

            process.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            
            if (form.onay1 == 1) { 
            info.FileName = "t_s.bat";
            process.StartInfo = info;

            process.Start();
            }
           else
            {
                info.FileName = "s.bat";
                process.StartInfo = info;

                process.Start();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            if (form.onay1 == 1)
            {
                info.FileName = "t_d.bat";
                process.StartInfo = info;

                process.Start();
            }
            else
            {
                info.FileName = "d.bat";
                process.StartInfo = info;

                process.Start();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
