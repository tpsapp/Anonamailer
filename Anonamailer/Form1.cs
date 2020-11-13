using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml;

namespace Anonamailer
{
    public partial class frmMain : Form
    {
        private String sUpdateURL = "http://code.sappsworld.com/update.xml";
        private String sDownloadURL = "http://code.sappsworld.com/Anonamailer.exe";
        private Version vUpdate = null;
        private Version vCurrent = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        public frmMain()
        {
            InitializeComponent();
            ofdMain.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            sfdMain.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            ofdAttach.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                StreamReader srFile = new StreamReader(ofdMain.FileName);
                tbFrom.Text = srFile.ReadLine();
                tbTo.Text = srFile.ReadLine();
                tbCC.Text = srFile.ReadLine();
                tbBCC.Text = srFile.ReadLine();
                tbSubject.Text = srFile.ReadLine();
                tbAttachment.Text = srFile.ReadLine();
                String sTemp = srFile.ReadLine();
                if (sTemp == "True")
                {
                    cbHTML.Checked = true;
                }
                else
                {
                    cbHTML.Checked = false;
                }
                rtbMessage.Text = srFile.ReadToEnd();
                srFile.Close();
                sfdMain.FileName = ofdMain.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdMain.ShowDialog() == DialogResult.OK)
            {
                StreamWriter swFile = new StreamWriter(sfdMain.FileName);
                swFile.WriteLine(tbFrom.Text);
                swFile.WriteLine(tbTo.Text);
                swFile.WriteLine(tbCC.Text);
                swFile.WriteLine(tbBCC.Text);
                swFile.WriteLine(tbSubject.Text);
                swFile.WriteLine(tbAttachment.Text);
                swFile.WriteLine(cbHTML.Checked);
                swFile.WriteLine(rtbMessage.Text);
                swFile.Close();
                ofdMain.FileName = sfdMain.FileName;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (ofdAttach.ShowDialog() == DialogResult.OK)
            {
                tbAttachment.Text = ofdAttach.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mmMessage = new MailMessage();
                if (tbAttachment.Text != "")
                {
                    Attachment data = new Attachment(tbAttachment.Text);
                    mmMessage.Attachments.Add(data);
                }
                if (tbBCC.Text != "")
                {
                    mmMessage.Bcc.Add(tbBCC.Text);
                }
                mmMessage.Body = rtbMessage.Text;
                if (tbCC.Text != "")
                {
                    mmMessage.CC.Add(tbCC.Text);
                }
                if (tbFrom.Text != "")
                {
                    mmMessage.From = new MailAddress(tbFrom.Text);
                }
                mmMessage.IsBodyHtml = cbHTML.Checked;
                mmMessage.Subject = tbSubject.Text;
                if (tbTo.Text != "")
                {
                    mmMessage.To.Add(tbTo.Text);
                }

                SmtpClient scClient = new SmtpClient();
                scClient.Host = Properties.Settings.Default.SMTPServer;
                scClient.Port = Properties.Settings.Default.SMTPPort;
                scClient.Send(mmMessage);
                MessageBox.Show("Your message has been sent.", "Message Away", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your message cannot be sent.\nError: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void sMTPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions fOptions = new frmOptions();
            fOptions.ShowDialog(this);
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHowTo fHowTo = new frmHowTo();
            fHowTo.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fAbout = new frmAbout();
            fAbout.ShowDialog(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbFrom.Clear();
            tbTo.Clear();
            tbCC.Clear();
            tbBCC.Clear();
            tbSubject.Clear();
            rtbMessage.Clear();
            tbAttachment.Clear();
            ofdAttach.FileName = "";
            ofdMain.FileName = "";
            sfdMain.FileName = "";
        }

        private void CheckForUpdate()
        {
            try
            {
                XmlTextReader xtrUpdateXML = new XmlTextReader(sUpdateURL);
                String sElement = "";

                xtrUpdateXML.MoveToContent();

                if ((xtrUpdateXML.NodeType == XmlNodeType.Element) && (xtrUpdateXML.Name == "anonamailer"))
                {
                    while (xtrUpdateXML.Read())
                    {
                        if ((xtrUpdateXML.NodeType == XmlNodeType.Element))
                        {
                            sElement = xtrUpdateXML.Name;
                        }
                        else
                        {
                            if ((xtrUpdateXML.NodeType == XmlNodeType.Text) && (xtrUpdateXML.HasValue))
                            {
                                switch (sElement)
                                {
                                    case "version":
                                        {
                                            vUpdate = new Version(xtrUpdateXML.Value);
                                        }
                                        break;
                                    case "url":
                                        {
                                            sDownloadURL = xtrUpdateXML.Value;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }

                if (xtrUpdateXML != null)
                {
                    xtrUpdateXML.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error checking for updates.\nDeatil: " + e.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (vCurrent.CompareTo(vUpdate) < 0)
            {
                if (MessageBox.Show("Version " + vUpdate.ToString() + " is available.  Would you like to download it now?", "New version available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DownloadUpdates();
                }
            }
        }

        private void DownloadUpdates()
        {
            try
            {
                WebClient wcDownload = new WebClient();
                OpenFileDialog ofdDownload = new OpenFileDialog();
                ofdDownload.ShowDialog();
                if (ofdDownload.FileName != "")
                {
                    wcDownload.DownloadFile(sDownloadURL, ofdDownload.FileName);
                    MessageBox.Show("Download Completed", "Download Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Please restart application to check for new updates or visit http://code.sappsworld.com/anonamailer.html to download the latest version.", "Download aborted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Please restart application to check for new updates or visit http://code.sappsworld.com/anonamailer.html to download the latest version.\nDetail: " + e.Message, "Download aborted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckForUpdate();
            this.Text += " " + vCurrent.Major + "." + vCurrent.Minor + "." + vCurrent.Build;
        }
    }
}
