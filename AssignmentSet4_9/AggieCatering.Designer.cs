
namespace AssignmentSet4_9
{
    partial class AggieCatering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggieCatering));
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpButtonsTop = new System.Windows.Forms.GroupBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnModifyEvent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpButtonsBottom = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.nudNumOfGuests = new System.Windows.Forms.NumericUpDown();
            this.lblEntreSelection = new System.Windows.Forms.Label();
            this.rabSteak = new System.Windows.Forms.RadioButton();
            this.rabChicken = new System.Windows.Forms.RadioButton();
            this.rabLasagna = new System.Windows.Forms.RadioButton();
            this.lblDrinkOptions = new System.Windows.Forms.Label();
            this.chbOpenBar = new System.Windows.Forms.CheckBox();
            this.chbWine = new System.Windows.Forms.CheckBox();
            this.lblDrinkInfo = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpButtonsTop.SuspendLayout();
            this.grpButtonsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblDrinkInfo);
            this.grpInputs.Controls.Add(this.chbWine);
            this.grpInputs.Controls.Add(this.chbOpenBar);
            this.grpInputs.Controls.Add(this.lblDrinkOptions);
            this.grpInputs.Controls.Add(this.rabLasagna);
            this.grpInputs.Controls.Add(this.rabChicken);
            this.grpInputs.Controls.Add(this.rabSteak);
            this.grpInputs.Controls.Add(this.lblEntreSelection);
            this.grpInputs.Controls.Add(this.nudNumOfGuests);
            this.grpInputs.Controls.Add(this.txtEventName);
            this.grpInputs.Controls.Add(this.lblNumOfGuests);
            this.grpInputs.Controls.Add(this.lblEventName);
            this.grpInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputs.Location = new System.Drawing.Point(12, 32);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(362, 233);
            this.grpInputs.TabIndex = 0;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Event Information";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(218, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(188, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Aggie Catering Events";
            // 
            // grpButtonsTop
            // 
            this.grpButtonsTop.Controls.Add(this.btnModifyEvent);
            this.grpButtonsTop.Controls.Add(this.btnCreateEvent);
            this.grpButtonsTop.Location = new System.Drawing.Point(380, 32);
            this.grpButtonsTop.Name = "grpButtonsTop";
            this.grpButtonsTop.Size = new System.Drawing.Size(222, 94);
            this.grpButtonsTop.TabIndex = 2;
            this.grpButtonsTop.TabStop = false;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(6, 19);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(210, 23);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create New Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnModifyEvent
            // 
            this.btnModifyEvent.Location = new System.Drawing.Point(6, 55);
            this.btnModifyEvent.Name = "btnModifyEvent";
            this.btnModifyEvent.Size = new System.Drawing.Size(210, 23);
            this.btnModifyEvent.TabIndex = 4;
            this.btnModifyEvent.Text = "Modify Event";
            this.btnModifyEvent.UseVisualStyleBackColor = true;
            this.btnModifyEvent.Click += new System.EventHandler(this.btnModifyEvent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(30, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpButtonsBottom
            // 
            this.grpButtonsBottom.Controls.Add(this.btnExit);
            this.grpButtonsBottom.Controls.Add(this.btnReset);
            this.grpButtonsBottom.Location = new System.Drawing.Point(380, 225);
            this.grpButtonsBottom.Name = "grpButtonsBottom";
            this.grpButtonsBottom.Size = new System.Drawing.Size(222, 40);
            this.grpButtonsBottom.TabIndex = 7;
            this.grpButtonsBottom.TabStop = false;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(6, 29);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(80, 13);
            this.lblEventName.TabIndex = 8;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuests.Location = new System.Drawing.Point(6, 55);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(112, 13);
            this.lblNumOfGuests.TabIndex = 9;
            this.lblNumOfGuests.Text = "Number of Guests:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(123, 26);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(219, 20);
            this.txtEventName.TabIndex = 10;
            // 
            // nudNumOfGuests
            // 
            this.nudNumOfGuests.Location = new System.Drawing.Point(123, 53);
            this.nudNumOfGuests.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudNumOfGuests.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumOfGuests.Name = "nudNumOfGuests";
            this.nudNumOfGuests.Size = new System.Drawing.Size(120, 20);
            this.nudNumOfGuests.TabIndex = 11;
            this.nudNumOfGuests.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblEntreSelection
            // 
            this.lblEntreSelection.AutoSize = true;
            this.lblEntreSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreSelection.Location = new System.Drawing.Point(6, 100);
            this.lblEntreSelection.Name = "lblEntreSelection";
            this.lblEntreSelection.Size = new System.Drawing.Size(94, 13);
            this.lblEntreSelection.TabIndex = 12;
            this.lblEntreSelection.Text = "Entre Selection";
            // 
            // rabSteak
            // 
            this.rabSteak.AutoSize = true;
            this.rabSteak.Checked = true;
            this.rabSteak.Location = new System.Drawing.Point(9, 116);
            this.rabSteak.Name = "rabSteak";
            this.rabSteak.Size = new System.Drawing.Size(93, 17);
            this.rabSteak.TabIndex = 13;
            this.rabSteak.TabStop = true;
            this.rabSteak.Text = "Rib Eye Steak";
            this.rabSteak.UseVisualStyleBackColor = true;
            // 
            // rabChicken
            // 
            this.rabChicken.AutoSize = true;
            this.rabChicken.Location = new System.Drawing.Point(123, 116);
            this.rabChicken.Name = "rabChicken";
            this.rabChicken.Size = new System.Drawing.Size(96, 17);
            this.rabChicken.TabIndex = 14;
            this.rabChicken.Text = "Grilled Chicken";
            this.rabChicken.UseVisualStyleBackColor = true;
            // 
            // rabLasagna
            // 
            this.rabLasagna.AutoSize = true;
            this.rabLasagna.Location = new System.Drawing.Point(238, 116);
            this.rabLasagna.Name = "rabLasagna";
            this.rabLasagna.Size = new System.Drawing.Size(104, 17);
            this.rabLasagna.TabIndex = 15;
            this.rabLasagna.Text = "Garden Lasagna";
            this.rabLasagna.UseVisualStyleBackColor = true;
            // 
            // lblDrinkOptions
            // 
            this.lblDrinkOptions.AutoSize = true;
            this.lblDrinkOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkOptions.Location = new System.Drawing.Point(6, 163);
            this.lblDrinkOptions.Name = "lblDrinkOptions";
            this.lblDrinkOptions.Size = new System.Drawing.Size(84, 13);
            this.lblDrinkOptions.TabIndex = 8;
            this.lblDrinkOptions.Text = "Drink Options";
            // 
            // chbOpenBar
            // 
            this.chbOpenBar.AutoSize = true;
            this.chbOpenBar.Location = new System.Drawing.Point(175, 179);
            this.chbOpenBar.Name = "chbOpenBar";
            this.chbOpenBar.Size = new System.Drawing.Size(71, 17);
            this.chbOpenBar.TabIndex = 16;
            this.chbOpenBar.Text = "Open Bar";
            this.chbOpenBar.UseVisualStyleBackColor = true;
            // 
            // chbWine
            // 
            this.chbWine.AutoSize = true;
            this.chbWine.Location = new System.Drawing.Point(175, 202);
            this.chbWine.Name = "chbWine";
            this.chbWine.Size = new System.Drawing.Size(107, 17);
            this.chbWine.TabIndex = 17;
            this.chbWine.Text = "Wine with Dinner";
            this.chbWine.UseVisualStyleBackColor = true;
            // 
            // lblDrinkInfo
            // 
            this.lblDrinkInfo.AutoSize = true;
            this.lblDrinkInfo.Location = new System.Drawing.Point(6, 179);
            this.lblDrinkInfo.Name = "lblDrinkInfo";
            this.lblDrinkInfo.Size = new System.Drawing.Size(163, 13);
            this.lblDrinkInfo.TabIndex = 19;
            this.lblDrinkInfo.Text = "Please select one, both, or none:\r\n";
            this.lblDrinkInfo.Click += new System.EventHandler(this.lblDrinkInfo_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(380, 132);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(222, 90);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AggieCatering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 286);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.grpButtonsTop);
            this.Controls.Add(this.grpButtonsBottom);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AggieCatering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggie Catering";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpButtonsTop.ResumeLayout(false);
            this.grpButtonsBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpButtonsTop;
        private System.Windows.Forms.Button btnModifyEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpButtonsBottom;
        private System.Windows.Forms.RadioButton rabLasagna;
        private System.Windows.Forms.RadioButton rabChicken;
        private System.Windows.Forms.RadioButton rabSteak;
        private System.Windows.Forms.Label lblEntreSelection;
        private System.Windows.Forms.NumericUpDown nudNumOfGuests;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.CheckBox chbWine;
        private System.Windows.Forms.CheckBox chbOpenBar;
        private System.Windows.Forms.Label lblDrinkOptions;
        private System.Windows.Forms.Label lblDrinkInfo;
        private System.Windows.Forms.Label lblDisplay;
    }
}

