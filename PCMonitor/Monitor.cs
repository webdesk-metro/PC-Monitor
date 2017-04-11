using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Animation;
using MetroFramework.Forms;

namespace PCMonitor
{
    public partial class Monitor : MetroForm
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            if(!timer.Enabled)
            {
                timer.Enabled = true;
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressbar_cpu.Value = (int)pCPU.NextValue(); //Processor...
            progressbar_ram.Value = (int)pRAM.NextValue(); //Memory...

            lbl_percentualCPU.Text = string.Format("{0:0.00}%", progressbar_cpu.Value);
            lbl_percentualRAM.Text = string.Format("{0:0.00}%", progressbar_ram.Value);

            chart.Series["CPU"].Points.AddY((int)pCPU.NextValue());
            chart.Series["RAM"].Points.AddY((int)pRAM.NextValue());
        }
    }
}
