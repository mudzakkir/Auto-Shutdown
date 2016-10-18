using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Shutdown_4
{
    public partial class FormMain : Form
    {
        private double dTime;
        public FormMain()
        {
            InitializeComponent();
        }

		private void btnStart_Click(object sender, EventArgs e)
		{
            bool bIsInMinute = rbMinute.Checked;
			this.dTime = Convert.ToDouble(this.txtTime.Text) * ( bIsInMinute ? 60.0 : (60.0 * 60.0));
			this.timer1.Interval = 1000;
			this.timer1.Start();
		}

		public void Shutdown()
		{

            string cmdText = "shutdown -s -t 10";
            Version win8version = new Version(6, 2, 9200, 0);

            if (Environment.OSVersion.Platform == PlatformID.Win32NT &&
                Environment.OSVersion.Version >= win8version)
            {
                // its win8 or higher.
                cmdText = "start shutdown -s -t 10";
            }
			Process.Start("cmd", "/C " + cmdText);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.dTime -= 1.0;
			this.label3.Text = string.Concat(new object[]
			{
				"Elapsed time : ",
				string.Format("{0:F2}", this.dTime / 60.0),
				" in Minute(s) or ",
				this.dTime,
				" in Second"
			});
			if (this.dTime <= 0.0)
			{
				this.timer1.Stop();
				this.Shutdown();
			}
		}
    }
}
