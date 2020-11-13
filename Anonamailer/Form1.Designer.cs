namespace Anonamailer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMTPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbBCC = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pBody = new System.Windows.Forms.Panel();
            this.cbHTML = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.ofdAttach = new System.Windows.Forms.OpenFileDialog();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.msMain.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(399, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem2.Text = "New";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "O&pen...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMTPServerToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // sMTPServerToolStripMenuItem
            // 
            this.sMTPServerToolStripMenuItem.Name = "sMTPServerToolStripMenuItem";
            this.sMTPServerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sMTPServerToolStripMenuItem.Text = "&SMTP Settings";
            this.sMTPServerToolStripMenuItem.Click += new System.EventHandler(this.sMTPServerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.howToToolStripMenuItem.Text = "H&ow to...";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 585);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(399, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "ssMain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BCC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Message Body:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(50, 17);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(335, 20);
            this.tbFrom.TabIndex = 8;
            this.ttMain.SetToolTip(this.tbFrom, "Email address to send message from.");
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(50, 43);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(335, 20);
            this.tbTo.TabIndex = 9;
            this.ttMain.SetToolTip(this.tbTo, "Email addresses to send message to.\r\nSeperate multiple addresses with a comma.");
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(50, 69);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(335, 20);
            this.tbCC.TabIndex = 10;
            this.ttMain.SetToolTip(this.tbCC, "Email addresses to Carbon Copy.\r\nSeperate multiple addresses with a comma.");
            // 
            // tbBCC
            // 
            this.tbBCC.Location = new System.Drawing.Point(50, 95);
            this.tbBCC.Name = "tbBCC";
            this.tbBCC.Size = new System.Drawing.Size(335, 20);
            this.tbBCC.TabIndex = 11;
            this.ttMain.SetToolTip(this.tbBCC, "Email addresses to Blind Carbon Copy.\r\nSeperate multiple addresses with a comma.");
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(64, 11);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(322, 20);
            this.tbSubject.TabIndex = 12;
            this.ttMain.SetToolTip(this.tbSubject, "Subject line for the message.");
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 50);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(374, 307);
            this.rtbMessage.TabIndex = 13;
            this.rtbMessage.Text = "";
            this.ttMain.SetToolTip(this.rtbMessage, "Main body of the email.");
            // 
            // pHeader
            // 
            this.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHeader.Controls.Add(this.label1);
            this.pHeader.Controls.Add(this.tbFrom);
            this.pHeader.Controls.Add(this.tbTo);
            this.pHeader.Controls.Add(this.tbBCC);
            this.pHeader.Controls.Add(this.label2);
            this.pHeader.Controls.Add(this.label4);
            this.pHeader.Controls.Add(this.tbCC);
            this.pHeader.Controls.Add(this.label3);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 24);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(399, 135);
            this.pHeader.TabIndex = 14;
            // 
            // pBody
            // 
            this.pBody.Controls.Add(this.cbHTML);
            this.pBody.Controls.Add(this.btnExit);
            this.pBody.Controls.Add(this.btnSend);
            this.pBody.Controls.Add(this.tbAttachment);
            this.pBody.Controls.Add(this.btnAttach);
            this.pBody.Controls.Add(this.label5);
            this.pBody.Controls.Add(this.tbSubject);
            this.pBody.Controls.Add(this.rtbMessage);
            this.pBody.Controls.Add(this.label6);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(0, 159);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(399, 426);
            this.pBody.TabIndex = 15;
            // 
            // cbHTML
            // 
            this.cbHTML.AutoSize = true;
            this.cbHTML.Location = new System.Drawing.Point(12, 395);
            this.cbHTML.Name = "cbHTML";
            this.cbHTML.Size = new System.Drawing.Size(98, 17);
            this.cbHTML.TabIndex = 18;
            this.cbHTML.Text = "Send as HTML";
            this.ttMain.SetToolTip(this.cbHTML, "Check this box if your message contains any HTML");
            this.cbHTML.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(311, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(230, 391);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbAttachment
            // 
            this.tbAttachment.Location = new System.Drawing.Point(93, 365);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.ReadOnly = true;
            this.tbAttachment.Size = new System.Drawing.Size(293, 20);
            this.tbAttachment.TabIndex = 15;
            this.ttMain.SetToolTip(this.tbAttachment, "Path to the attached file, if any.");
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(12, 363);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 14;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // ofdMain
            // 
            this.ofdMain.DefaultExt = "aem";
            this.ofdMain.Filter = "Anonamailer Files|*.aem";
            // 
            // sfdMain
            // 
            this.sfdMain.DefaultExt = "aem";
            this.sfdMain.Filter = "Anonamailer Files|*.aem";
            // 
            // ofdAttach
            // 
            this.ofdAttach.Filter = "All Files|*.*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(399, 607);
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Anonymous Emailer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pBody.ResumeLayout(false);
            this.pBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMTPServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbBCC;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.CheckBox cbHTML;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.OpenFileDialog ofdAttach;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

