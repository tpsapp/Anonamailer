using System.Windows.Forms;

namespace Anonamailer
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void llHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llHomepage.LinkVisited = true;
            System.Diagnostics.Process.Start("http://code.sappsworld.com/anonamailer.html");
        }
    }
}
