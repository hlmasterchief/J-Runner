﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace JRunner.Panels
{
    public partial class NandTools : UserControl
    {
        public NandTools()
        {
            InitializeComponent();
        }

        public NandTools(string lptport)
        {
            txtLPTPort.Text = lptport;
        }

        public NandTools(int iterations)
        {
            numericIterations.Value = iterations;
        }

        public NandTools(string lptport, int iterations)
        {
            numericIterations.Value = iterations;
            txtLPTPort.Text = lptport;
        }

        public int getNumericIterations()
        {
            return (int)numericIterations.Value;
        }
        public void setNumericIterations(decimal value)
        {
            numericIterations.Value = value;
        }
        public string getLptPort()
        {
            return txtLPTPort.Text;
        }
        public void setLptPort(string port)
        {
            txtLPTPort.Text = port;
        }
        public bool getRbtnUSB()
        {
            return rbtnUSB.Checked;
        }
        public bool getRbtnLPT()
        {
            return rbtnLPT.Checked;
        }

        public void setbtnCreateECCEnabled(bool b)
        {
            btnCreateECC.Enabled = b;
        }
        public void setbtnCreateECC(string text)
        {
            btnCreateECC.Text = text;
        }
        public string getbtnCreateECC()
        {
            return btnCreateECC.Text;
        }
        public void setbtnWriteECC(string text)
        {
            btnWriteECC.Text = text;
        }
        public string getbtnWriteECC()
        {
            return btnWriteECC.Text;
        }

        public void setImage(Image m)
        {
            pBoxDevice.Image = m;
            
        }
        
        public delegate void ClickedRead();
        public event ClickedRead ReadClick;
        public delegate void ClickedCreateECC();
        public event ClickedCreateECC CreateEccClick;
        public delegate void ClickedWriteECC();
        public event ClickedWriteECC WriteEccClick;
        public delegate void ClickedXeBuild();
        public event ClickedXeBuild XeBuildClick;
        public delegate void ClickedWrite();
        public event ClickedWrite WriteClick;
        public delegate void ClickedProgramCR();
        public event ClickedProgramCR ProgramCRClick;
        public delegate void ClickedCPUDB();
        public event ClickedCPUDB CPUDBClick;
        public delegate void ChangedIter(int iter);
        public event ChangedIter IterChange;
        //public delegate void CheckedChanged();
        //public event CheckedChanged ChangedChecked;
        //public delegate void PortChanged();
        //public event PortChanged ChangedPort;

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadClick();
        }

        private void btnCreateECC_Click(object sender, EventArgs e)
        {
            CreateEccClick();
        }

        private void btnWriteECC_Click(object sender, EventArgs e)
        {
            WriteEccClick();
        }

        private void btnXeBuild_Click(object sender, EventArgs e)
        {
            XeBuildClick();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteClick();
        }

        private void btnProgramCR_Click(object sender, EventArgs e)
        {
            ProgramCRClick();
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            //ChangedChecked();
            txtLPTPort.Visible = (rbtnLPT.Checked);
            lblLPTPort.Visible = txtLPTPort.Visible;
        }

        private void numericIterations_ValueChanged(object sender, EventArgs e)
        {
            IterChange((int)numericIterations.Value);
        }

        private void btnCPUDB_Click(object sender, EventArgs e)
        {
            CPUDBClick();
        }

        private void txtLPTPort_TextChanged(object sender, EventArgs e)
        {
            //ChangedPort();
        }

        private void pBoxBitCoin_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("bitcoin:1PZCNMx5Ji5FMdJtvHXVfmmp3dsYjnVW5d?label=JR%20Donation");
            }
            catch (Exception) { }
        }

        private void pBoxBitCoin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxBitCoin_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxBitCoin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = DefaultCursor;
        }

        private void pBoxBitCoin_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxFlattr_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://flattr.com/submit/auto?user_id=JRunner&url=http%3A%2F%2Fwww.j-runner.net");
            }
            catch (Exception) { }
        }

        private void pBoxFlattr_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxFlattr_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxFlattr_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = DefaultCursor;
        }

        private void pBoxFlattr_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxPayPal_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=YBB35GNNH9KXS&lc=GB&item_name=JRunner&no_note=1&no_shipping=1&currency_code=GBP&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted");
            }
            catch (Exception) { }
        }

        private void pBoxPayPal_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxPayPal_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pBoxPayPal_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = DefaultCursor;
        }

        private void pBoxPayPal_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
       
    }
}
