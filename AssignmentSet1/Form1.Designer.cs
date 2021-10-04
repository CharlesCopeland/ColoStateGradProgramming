
namespace AssignmentSet1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHobby = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.lblFavorites = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(220, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Copeland\'s Favorites";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHobby
            // 
            this.btnHobby.Location = new System.Drawing.Point(100, 120);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(150, 46);
            this.btnHobby.TabIndex = 1;
            this.btnHobby.Text = "Hobby";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // btnSport
            // 
            this.btnSport.Location = new System.Drawing.Point(300, 120);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(150, 46);
            this.btnSport.TabIndex = 2;
            this.btnSport.Text = "Sport";
            this.btnSport.UseVisualStyleBackColor = true;
            this.btnSport.Click += new System.EventHandler(this.btnSport_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(500, 120);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(150, 46);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // lblFavorites
            // 
            this.lblFavorites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFavorites.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFavorites.Location = new System.Drawing.Point(130, 200);
            this.lblFavorites.Name = "lblFavorites";
            this.lblFavorites.Size = new System.Drawing.Size(500, 80);
            this.lblFavorites.TabIndex = 4;
            this.lblFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(210, 388);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(333, 32);
            this.lblDeveloper.TabIndex = 6;
            this.lblDeveloper.Text = "Developed By: Copeland Felts";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFavorites);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnSport);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 1 | Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHobby;
        private System.Windows.Forms.Button btnSport;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label lblFavorites;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeveloper;
    }
}

