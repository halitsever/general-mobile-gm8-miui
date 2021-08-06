using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM8_MIUI
{
    public partial class Form1 : MaterialForm
    {
        private Process Process = new Process();
        private ProcessStartInfo Input = new ProcessStartInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void runProcess(string processInput, string Mode)
        {

            string mode = (Mode == "fastboot") ? "fastboot" : "adb";
            Input.FileName = mode + ".exe";
            Input.Arguments = processInput;
            Process.Start();
        }

        private void installMIUI(Boolean isDual)
        {
            string dualorsingle = (isDual == true) ? "dual" : "single";
            string[] Command = {
            "erase userdata",
            "flash userdata " + dualorsingle + "/userdata.img",
            "flash system_a sistem/system.img",
            "flash system_b sistem/system.img",
            "flash boot_a " + dualorsingle + "/boot.img",
            "flash boot_b " + dualorsingle + "/boot.img",
            "flash vendor_a " + dualorsingle + "/vendor.img",
            "flash vendor_b " + dualorsingle + "/vendor.img",
            "flash splash " + dualorsingle + "/splash.img"
            };
            for (int i = 0; Command.Length > i; i++)
            {
                runProcess(Command[i], "fastboot");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (singleDeviceRadioButton.Checked == true) installMIUI(false);
            else installMIUI(true);
        }

    }
}