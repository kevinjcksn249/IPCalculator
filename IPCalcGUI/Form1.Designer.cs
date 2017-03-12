namespace IPCalcGUI
{
    partial class MainForm
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
            this.txtIpIn = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNetMask = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHostBits = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNetworkBits = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNetworkAddress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBroadcastAddress = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNetworkSize = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIpIn
            // 
            this.txtIpIn.Location = new System.Drawing.Point(13, 47);
            this.txtIpIn.Name = "txtIpIn";
            this.txtIpIn.Size = new System.Drawing.Size(100, 20);
            this.txtIpIn.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(120, 44);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter an ip address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class:";
            // 
            // lblClass
            // 
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClass.Location = new System.Drawing.Point(120, 83);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(156, 23);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "# Host bits:";
            // 
            // lblNetMask
            // 
            this.lblNetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetMask.Location = new System.Drawing.Point(120, 115);
            this.lblNetMask.Name = "lblNetMask";
            this.lblNetMask.Size = new System.Drawing.Size(156, 23);
            this.lblNetMask.TabIndex = 7;
            this.lblNetMask.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "# Network bits:";
            // 
            // lblHostBits
            // 
            this.lblHostBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHostBits.Location = new System.Drawing.Point(120, 147);
            this.lblHostBits.Name = "lblHostBits";
            this.lblHostBits.Size = new System.Drawing.Size(156, 23);
            this.lblHostBits.TabIndex = 9;
            this.lblHostBits.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Network Address:";
            // 
            // lblNetworkBits
            // 
            this.lblNetworkBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkBits.Location = new System.Drawing.Point(120, 179);
            this.lblNetworkBits.Name = "lblNetworkBits";
            this.lblNetworkBits.Size = new System.Drawing.Size(156, 23);
            this.lblNetworkBits.TabIndex = 11;
            this.lblNetworkBits.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Broadcast Address:";
            // 
            // lblNetworkAddress
            // 
            this.lblNetworkAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkAddress.Location = new System.Drawing.Point(120, 211);
            this.lblNetworkAddress.Name = "lblNetworkAddress";
            this.lblNetworkAddress.Size = new System.Drawing.Size(156, 23);
            this.lblNetworkAddress.TabIndex = 13;
            this.lblNetworkAddress.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Network Size:";
            // 
            // lblBroadcastAddress
            // 
            this.lblBroadcastAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBroadcastAddress.Location = new System.Drawing.Point(120, 243);
            this.lblBroadcastAddress.Name = "lblBroadcastAddress";
            this.lblBroadcastAddress.Size = new System.Drawing.Size(156, 23);
            this.lblBroadcastAddress.TabIndex = 15;
            this.lblBroadcastAddress.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Default subnet mask:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNetworkSize
            // 
            this.lblNetworkSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkSize.Location = new System.Drawing.Point(120, 275);
            this.lblNetworkSize.Name = "lblNetworkSize";
            this.lblNetworkSize.Size = new System.Drawing.Size(156, 23);
            this.lblNetworkSize.TabIndex = 17;
            this.lblNetworkSize.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(289, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 334);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblNetworkSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblBroadcastAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblNetworkAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNetworkBits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHostBits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNetMask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIpIn);
            this.Name = "MainForm";
            this.Text = "IP Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNetworkSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBroadcastAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNetworkAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNetworkBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHostBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIpIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label lblNetMask;
    }
}

