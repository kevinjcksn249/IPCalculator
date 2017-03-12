//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		IP Calculator
//	File Name:		Form1.cs
//	Description:	Driver for the main form of the program
//	Course:			CSCI 3400-001 - Networking Fundamentals
//	Author:			Kevin Jackson, jacksonka1@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    Friday, February 2, 2016
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalcGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Calculate button event handler
        /// <summary>
        /// Handles the Click event of the btnCalculate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            string addr = txtIpIn.Text;
            if (IPFunctions.IsValidIP(txtIpIn.Text))
            {
                string cl = IPFunctions.FindClass(addr);
                int hostBits = IPFunctions.FindHostBits(cl);
                int networkBits = IPFunctions.FindNetworkBits(cl);
                string networkAddr = IPFunctions.FindNetworkAddress(addr, cl);
                string broadcastAddr = IPFunctions.FindBroadcastAddress(addr, cl);
                string networkSize = IPFunctions.FindNetworkSize(hostBits);
                string netMask = IPFunctions.FindMask(cl);

                lblClass.Text = cl;
                lblHostBits.Text = hostBits.ToString();
                lblNetworkBits.Text = networkBits.ToString();
                lblNetworkAddress.Text = networkAddr.ToString();
                lblBroadcastAddress.Text = broadcastAddr;
                lblNetworkSize.Text = networkSize;
                lblNetMask.Text = netMask;
            }
            else
                statusLabel.Text = "Not a valid ip address";
        } 
        #endregion
    }
}
