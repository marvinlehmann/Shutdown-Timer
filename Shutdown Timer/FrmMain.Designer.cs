namespace Shutdown_Timer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblHours = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkForceClosing = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(147)))), ((int)(((byte)(208)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblCountdown);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(312, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(16, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Shutdown Timer";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCountdown.Location = new System.Drawing.Point(196, 7);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(106, 24);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "00:00:00";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(50, 23);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(20, 23);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "h";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.lblHours);
            this.grpTime.Controls.Add(this.lblMinutes);
            this.grpTime.Controls.Add(this.nudMinutes);
            this.grpTime.Controls.Add(this.lblSeconds);
            this.grpTime.Controls.Add(this.nudSeconds);
            this.grpTime.Controls.Add(this.nudHours);
            this.grpTime.Location = new System.Drawing.Point(10, 5);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(221, 61);
            this.grpTime.TabIndex = 1;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Set Timer";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(124, 23);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(25, 23);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "m";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.nudMinutes.Location = new System.Drawing.Point(75, 18);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(47, 30);
            this.nudMinutes.TabIndex = 3;
            this.nudMinutes.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(201, 23);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(18, 23);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "s";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.nudSeconds.Location = new System.Drawing.Point(153, 19);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(46, 30);
            this.nudSeconds.TabIndex = 4;
            this.nudSeconds.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // nudHours
            // 
            this.nudHours.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.nudHours.Location = new System.Drawing.Point(6, 19);
            this.nudHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(42, 30);
            this.nudHours.TabIndex = 2;
            this.nudHours.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(102, 19);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(59, 17);
            this.rbRestart.TabIndex = 7;
            this.rbRestart.TabStop = true;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(18, 19);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(73, 17);
            this.rbShutdown.TabIndex = 6;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(235, 10);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(67, 56);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rbRestart);
            this.grpOptions.Controls.Add(this.rbShutdown);
            this.grpOptions.Controls.Add(this.chkForceClosing);
            this.grpOptions.Location = new System.Drawing.Point(10, 72);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(292, 48);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkForceClosing
            // 
            this.chkForceClosing.AutoSize = true;
            this.chkForceClosing.Checked = true;
            this.chkForceClosing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForceClosing.Location = new System.Drawing.Point(190, 20);
            this.chkForceClosing.Name = "chkForceClosing";
            this.chkForceClosing.Size = new System.Drawing.Size(90, 17);
            this.chkForceClosing.TabIndex = 8;
            this.chkForceClosing.Text = "Force Closing";
            this.chkForceClosing.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.btnSet);
            this.pnlMain.Controls.Add(this.grpOptions);
            this.pnlMain.Controls.Add(this.grpTime);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 39);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(312, 132);
            this.pnlMain.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 171);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 210);
            this.MinimumSize = new System.Drawing.Size(328, 210);
            this.Name = "FrmMain";
            this.Text = "Shutdown Timer";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkForceClosing;
        private System.Windows.Forms.Panel pnlMain;
    }
}

