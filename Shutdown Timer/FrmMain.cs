using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    public partial class FrmMain : Form
    {
        private bool _isSet;
        private DateTime _shutdownTime;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!_isSet && (nudHours.Value != 0 || nudMinutes.Value != 0 || nudSeconds.Value != 0))
            {
                _isSet = true;
                _shutdownTime = DateTime.Now.Add(new TimeSpan((int)nudHours.Value, (int)nudMinutes.Value, (int)nudSeconds.Value));
                btnSet.Text = "CANCEL";
                lblCountdown.Text = (_shutdownTime - DateTime.Now).ToString(@"hh\:mm\:ss");
                tmrTime.Start();
            }
            else
            {
                _isSet = false;
                tmrTime.Stop();
                btnSet.Text = "SET";
                lblCountdown.Text = "00:00:00";
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (_shutdownTime < DateTime.Now)
            {
                tmrTime.Stop();
                Shutdown();
            }
            else
            {
                UpdateCountdown();
            }
        }

        private void UpdateCountdown()
        {
            var timeToShutdown = _shutdownTime - DateTime.Now;
            lblCountdown.Invoke((MethodInvoker)delegate { lblCountdown.Text = timeToShutdown.ToString(@"hh\:mm\:ss"); });
        }

        private void Shutdown()
        {
            string parameters = null;

            if (rbShutdown.Checked) parameters += "/s ";
            else if (rbRestart.Checked) parameters += "/r ";
            if (chkForceClosing.Checked) parameters += "/f ";
            parameters += "/t 0";

            Process.Start("shutdown", parameters);
        }
    }
}