
using System;
using System.Windows.Forms;

namespace AssignmentSet2
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
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.rbtnBlack = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.gbxShowHide = new System.Windows.Forms.GroupBox();
            this.cbxDeveloper = new System.Windows.Forms.CheckBox();
            this.cbxLogo = new System.Windows.Forms.CheckBox();
            this.cbxTagline = new System.Windows.Forms.CheckBox();
            this.cbxName = new System.Windows.Forms.CheckBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTipLogo = new System.Windows.Forms.ToolTip(this.components);
            this.gbxColor.SuspendLayout();
            this.gbxShowHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.rbtnBlack);
            this.gbxColor.Controls.Add(this.rbtnRed);
            this.gbxColor.Controls.Add(this.rbtnGreen);
            this.gbxColor.Controls.Add(this.rbtnBlue);
            this.gbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxColor.Location = new System.Drawing.Point(23, 91);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(117, 127);
            this.gbxColor.TabIndex = 0;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Select Color";
            // 
            // rbtnBlack
            // 
            this.rbtnBlack.AutoSize = true;
            this.rbtnBlack.Checked = true;
            this.rbtnBlack.Location = new System.Drawing.Point(7, 92);
            this.rbtnBlack.Name = "rbtnBlack";
            this.rbtnBlack.Size = new System.Drawing.Size(57, 17);
            this.rbtnBlack.TabIndex = 3;
            this.rbtnBlack.TabStop = true;
            this.rbtnBlack.Text = "Blac&k";
            this.rbtnBlack.UseVisualStyleBackColor = true;
            this.rbtnBlack.CheckedChanged += new System.EventHandler(this.rbtnBlack_CheckedChanged);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(7, 68);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(48, 17);
            this.rbtnRed.TabIndex = 2;
            this.rbtnRed.Text = "&Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.rbtnRed_CheckedChanged);
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(7, 45);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(59, 17);
            this.rbtnGreen.TabIndex = 1;
            this.rbtnGreen.Text = "&Green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.rbtnGreen_CheckedChanged);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(7, 20);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(50, 17);
            this.rbtnBlue.TabIndex = 0;
            this.rbtnBlue.Text = "&Blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.rbtnBlue_CheckedChanged);
            // 
            // gbxShowHide
            // 
            this.gbxShowHide.Controls.Add(this.cbxDeveloper);
            this.gbxShowHide.Controls.Add(this.cbxLogo);
            this.gbxShowHide.Controls.Add(this.cbxTagline);
            this.gbxShowHide.Controls.Add(this.cbxName);
            this.gbxShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShowHide.Location = new System.Drawing.Point(654, 91);
            this.gbxShowHide.Name = "gbxShowHide";
            this.gbxShowHide.Size = new System.Drawing.Size(117, 127);
            this.gbxShowHide.TabIndex = 1;
            this.gbxShowHide.TabStop = false;
            this.gbxShowHide.Text = "Show/Hide";
            // 
            // cbxDeveloper
            // 
            this.cbxDeveloper.AutoSize = true;
            this.cbxDeveloper.Checked = true;
            this.cbxDeveloper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDeveloper.Location = new System.Drawing.Point(7, 92);
            this.cbxDeveloper.Name = "cbxDeveloper";
            this.cbxDeveloper.Size = new System.Drawing.Size(84, 17);
            this.cbxDeveloper.TabIndex = 3;
            this.cbxDeveloper.Text = "&Developer";
            this.cbxDeveloper.UseVisualStyleBackColor = true;
            this.cbxDeveloper.CheckedChanged += new System.EventHandler(this.cbxDeveloper_CheckedChanged);
            // 
            // cbxLogo
            // 
            this.cbxLogo.AutoSize = true;
            this.cbxLogo.Checked = true;
            this.cbxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLogo.Location = new System.Drawing.Point(7, 68);
            this.cbxLogo.Name = "cbxLogo";
            this.cbxLogo.Size = new System.Drawing.Size(54, 17);
            this.cbxLogo.TabIndex = 2;
            this.cbxLogo.Text = "&Logo";
            this.cbxLogo.UseVisualStyleBackColor = true;
            this.cbxLogo.CheckedChanged += new System.EventHandler(this.cbxLogo_CheckedChanged);
            // 
            // cbxTagline
            // 
            this.cbxTagline.AutoSize = true;
            this.cbxTagline.Checked = true;
            this.cbxTagline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTagline.Location = new System.Drawing.Point(7, 44);
            this.cbxTagline.Name = "cbxTagline";
            this.cbxTagline.Size = new System.Drawing.Size(68, 17);
            this.cbxTagline.TabIndex = 1;
            this.cbxTagline.Text = "&Tagline";
            this.cbxTagline.UseVisualStyleBackColor = true;
            this.cbxTagline.CheckedChanged += new System.EventHandler(this.cbxTagline_CheckedChanged);
            // 
            // cbxName
            // 
            this.cbxName.AutoSize = true;
            this.cbxName.Checked = true;
            this.cbxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxName.Location = new System.Drawing.Point(7, 20);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(58, 17);
            this.cbxName.TabIndex = 0;
            this.cbxName.Text = "&Name";
            this.cbxName.UseVisualStyleBackColor = true;
            this.cbxName.CheckedChanged += new System.EventHandler(this.cbxName_CheckedChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(308, 347);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(178, 13);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Developed By: Copeland Felts";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(725, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(249, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(303, 37);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Unmanned Visuals";
            this.toolTipLogo.SetToolTip(this.lblName, "This is my company\'s logo!");
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.Location = new System.Drawing.Point(52, 292);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(687, 36);
            this.lblTagline.TabIndex = 5;
            this.lblTagline.Text = "Cost Effective, Innovative, and On-Demand Professional Aerial Drone Services Tail" +
    "ored to Your Needs. \r\nLet Us Take Your Projects to New Heights!";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(182, 49);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(431, 229);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(654, 337);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolTipLogo
            // 
            this.toolTipLogo.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipLogo_Popup);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(796, 368);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.gbxShowHide);
            this.Controls.Add(this.gbxColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unmanned Visuals Promotional";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxColor.ResumeLayout(false);
            this.gbxColor.PerformLayout();
            this.gbxShowHide.ResumeLayout(false);
            this.gbxShowHide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolTipLogo_Popup(object sender, PopupEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.GroupBox gbxShowHide;
        private System.Windows.Forms.RadioButton rbtnBlack;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.CheckBox cbxDeveloper;
        private System.Windows.Forms.CheckBox cbxLogo;
        private System.Windows.Forms.CheckBox cbxTagline;
        private System.Windows.Forms.CheckBox cbxName;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTipLogo;
    }
}

