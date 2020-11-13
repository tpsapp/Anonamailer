using System;
using System.Windows.Forms;

namespace Anonamailer
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            tbSMTPServer.Text = Properties.Settings.Default.SMTPServer;
            nudSMTPPort.Value = Properties.Settings.Default.SMTPPort;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbSMTPServer.Text != "")
            {
                Properties.Settings.Default.SMTPServer = tbSMTPServer.Text;
            }
            Properties.Settings.Default.SMTPPort = (int)nudSMTPPort.Value;
            Properties.Settings.Default.Save();
        }
    }
}
