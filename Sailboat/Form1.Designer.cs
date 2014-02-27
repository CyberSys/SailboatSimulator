namespace Sailboat
{
    partial class SailingSimulator
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
            this.lblHeadLongitude = new System.Windows.Forms.Label();
            this.gboxHeading = new System.Windows.Forms.GroupBox();
            this.pnlHeadDirection = new System.Windows.Forms.Panel();
            this.nudHeadDegrees = new System.Windows.Forms.NumericUpDown();
            this.lblHeadDegrees = new System.Windows.Forms.Label();
            this.pnlHeadCoordinates = new System.Windows.Forms.Panel();
            this.nudHeadLongitude = new System.Windows.Forms.NumericUpDown();
            this.lblHeadLattitude = new System.Windows.Forms.Label();
            this.nudHeadLattitude = new System.Windows.Forms.NumericUpDown();
            this.rbHeadDirection = new System.Windows.Forms.RadioButton();
            this.rbHeadCoordinates = new System.Windows.Forms.RadioButton();
            this.gboxStatsOrientation = new System.Windows.Forms.GroupBox();
            this.pnlStatsOrientation = new System.Windows.Forms.Panel();
            this.nudStatsDegrees = new System.Windows.Forms.NumericUpDown();
            this.lblStatsDegrees = new System.Windows.Forms.Label();
            this.gboxCurrentStats = new System.Windows.Forms.GroupBox();
            this.gboxStatsCoordinates = new System.Windows.Forms.GroupBox();
            this.pnlStatsCoordinates = new System.Windows.Forms.Panel();
            this.nudStatsLongitude = new System.Windows.Forms.NumericUpDown();
            this.lblStatsLongitude = new System.Windows.Forms.Label();
            this.lblStatsLattitude = new System.Windows.Forms.Label();
            this.nudStatsLattitude = new System.Windows.Forms.NumericUpDown();
            this.gBoxOpMode = new System.Windows.Forms.GroupBox();
            this.rbOpRun = new System.Windows.Forms.RadioButton();
            this.tbOpRun = new System.Windows.Forms.RadioButton();
            this.rbOpSetup = new System.Windows.Forms.RadioButton();
            this.pnlOpMode = new System.Windows.Forms.Panel();
            this.gboxWind = new System.Windows.Forms.GroupBox();
            this.pnlWind = new System.Windows.Forms.Panel();
            this.nudWindDirection = new System.Windows.Forms.NumericUpDown();
            this.nudWindMagnitude = new System.Windows.Forms.NumericUpDown();
            this.lblWindMagnitude = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.gboxSail = new System.Windows.Forms.GroupBox();
            this.pnlSail = new System.Windows.Forms.Panel();
            this.nudSailSub = new System.Windows.Forms.NumericUpDown();
            this.nudSailMain = new System.Windows.Forms.NumericUpDown();
            this.lblSailSub = new System.Windows.Forms.Label();
            this.lblSailMain = new System.Windows.Forms.Label();
            this.gboxRudder = new System.Windows.Forms.GroupBox();
            this.pnlBearing = new System.Windows.Forms.Panel();
            this.nudBearing = new System.Windows.Forms.NumericUpDown();
            this.lblBearing = new System.Windows.Forms.Label();
            this.pnlRudder = new System.Windows.Forms.Panel();
            this.nudRudderDirection = new System.Windows.Forms.NumericUpDown();
            this.lblRudderDirection = new System.Windows.Forms.Label();
            this.gboxVelocity = new System.Windows.Forms.GroupBox();
            this.pnlVelocity = new System.Windows.Forms.Panel();
            this.nudVelocityDirection = new System.Windows.Forms.NumericUpDown();
            this.nudVelocityMagnitude = new System.Windows.Forms.NumericUpDown();
            this.lblVelocityMagnitude = new System.Windows.Forms.Label();
            this.lblVelocityDirection = new System.Windows.Forms.Label();
            this.gboxAccelerometer = new System.Windows.Forms.GroupBox();
            this.lblAccelYaw = new System.Windows.Forms.Label();
            this.lblAccelPitch = new System.Windows.Forms.Label();
            this.tbarAccelPitch = new System.Windows.Forms.TrackBar();
            this.tbarAccelYaw = new System.Windows.Forms.TrackBar();
            this.Pulse = new System.Windows.Forms.Timer(this.components);
            this.pboxOcean = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.gboxHeading.SuspendLayout();
            this.pnlHeadDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadDegrees)).BeginInit();
            this.pnlHeadCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadLattitude)).BeginInit();
            this.gboxStatsOrientation.SuspendLayout();
            this.pnlStatsOrientation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsDegrees)).BeginInit();
            this.gboxCurrentStats.SuspendLayout();
            this.gboxStatsCoordinates.SuspendLayout();
            this.pnlStatsCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsLattitude)).BeginInit();
            this.gBoxOpMode.SuspendLayout();
            this.pnlOpMode.SuspendLayout();
            this.gboxWind.SuspendLayout();
            this.pnlWind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindMagnitude)).BeginInit();
            this.gboxSail.SuspendLayout();
            this.pnlSail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSailSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSailMain)).BeginInit();
            this.gboxRudder.SuspendLayout();
            this.pnlBearing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBearing)).BeginInit();
            this.pnlRudder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRudderDirection)).BeginInit();
            this.gboxVelocity.SuspendLayout();
            this.pnlVelocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocityDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocityMagnitude)).BeginInit();
            this.gboxAccelerometer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAccelPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAccelYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadLongitude
            // 
            this.lblHeadLongitude.AutoSize = true;
            this.lblHeadLongitude.Location = new System.Drawing.Point(3, 5);
            this.lblHeadLongitude.Name = "lblHeadLongitude";
            this.lblHeadLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblHeadLongitude.TabIndex = 1;
            this.lblHeadLongitude.Text = "Longitude:";
            // 
            // gboxHeading
            // 
            this.gboxHeading.Controls.Add(this.pnlHeadDirection);
            this.gboxHeading.Controls.Add(this.pnlHeadCoordinates);
            this.gboxHeading.Controls.Add(this.rbHeadDirection);
            this.gboxHeading.Controls.Add(this.rbHeadCoordinates);
            this.gboxHeading.Location = new System.Drawing.Point(176, 3);
            this.gboxHeading.Name = "gboxHeading";
            this.gboxHeading.Size = new System.Drawing.Size(169, 160);
            this.gboxHeading.TabIndex = 2;
            this.gboxHeading.TabStop = false;
            this.gboxHeading.Text = "Heading";
            // 
            // pnlHeadDirection
            // 
            this.pnlHeadDirection.Controls.Add(this.nudHeadDegrees);
            this.pnlHeadDirection.Controls.Add(this.lblHeadDegrees);
            this.pnlHeadDirection.Location = new System.Drawing.Point(43, 123);
            this.pnlHeadDirection.Name = "pnlHeadDirection";
            this.pnlHeadDirection.Size = new System.Drawing.Size(120, 26);
            this.pnlHeadDirection.TabIndex = 8;
            // 
            // nudHeadDegrees
            // 
            this.nudHeadDegrees.DecimalPlaces = 1;
            this.nudHeadDegrees.Location = new System.Drawing.Point(59, 3);
            this.nudHeadDegrees.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHeadDegrees.Name = "nudHeadDegrees";
            this.nudHeadDegrees.Size = new System.Drawing.Size(56, 20);
            this.nudHeadDegrees.TabIndex = 7;
            this.nudHeadDegrees.Value = new decimal(new int[] {
            1201,
            0,
            0,
            65536});
            this.nudHeadDegrees.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblHeadDegrees
            // 
            this.lblHeadDegrees.AutoSize = true;
            this.lblHeadDegrees.Location = new System.Drawing.Point(2, 5);
            this.lblHeadDegrees.Name = "lblHeadDegrees";
            this.lblHeadDegrees.Size = new System.Drawing.Size(50, 13);
            this.lblHeadDegrees.TabIndex = 6;
            this.lblHeadDegrees.Text = "Degrees:";
            // 
            // pnlHeadCoordinates
            // 
            this.pnlHeadCoordinates.Controls.Add(this.nudHeadLongitude);
            this.pnlHeadCoordinates.Controls.Add(this.lblHeadLongitude);
            this.pnlHeadCoordinates.Controls.Add(this.lblHeadLattitude);
            this.pnlHeadCoordinates.Controls.Add(this.nudHeadLattitude);
            this.pnlHeadCoordinates.Location = new System.Drawing.Point(43, 42);
            this.pnlHeadCoordinates.Name = "pnlHeadCoordinates";
            this.pnlHeadCoordinates.Size = new System.Drawing.Size(120, 52);
            this.pnlHeadCoordinates.TabIndex = 3;
            // 
            // nudHeadLongitude
            // 
            this.nudHeadLongitude.DecimalPlaces = 2;
            this.nudHeadLongitude.Location = new System.Drawing.Point(59, 3);
            this.nudHeadLongitude.Name = "nudHeadLongitude";
            this.nudHeadLongitude.Size = new System.Drawing.Size(56, 20);
            this.nudHeadLongitude.TabIndex = 3;
            this.nudHeadLongitude.Value = new decimal(new int[] {
            7525,
            0,
            0,
            131072});
            this.nudHeadLongitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblHeadLattitude
            // 
            this.lblHeadLattitude.AutoSize = true;
            this.lblHeadLattitude.Location = new System.Drawing.Point(3, 31);
            this.lblHeadLattitude.Name = "lblHeadLattitude";
            this.lblHeadLattitude.Size = new System.Drawing.Size(51, 13);
            this.lblHeadLattitude.TabIndex = 4;
            this.lblHeadLattitude.Text = "Lattitude:";
            // 
            // nudHeadLattitude
            // 
            this.nudHeadLattitude.DecimalPlaces = 2;
            this.nudHeadLattitude.Location = new System.Drawing.Point(59, 29);
            this.nudHeadLattitude.Name = "nudHeadLattitude";
            this.nudHeadLattitude.Size = new System.Drawing.Size(56, 20);
            this.nudHeadLattitude.TabIndex = 5;
            this.nudHeadLattitude.Value = new decimal(new int[] {
            7525,
            0,
            0,
            131072});
            this.nudHeadLattitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // rbHeadDirection
            // 
            this.rbHeadDirection.AutoSize = true;
            this.rbHeadDirection.Location = new System.Drawing.Point(9, 100);
            this.rbHeadDirection.Name = "rbHeadDirection";
            this.rbHeadDirection.Size = new System.Drawing.Size(67, 17);
            this.rbHeadDirection.TabIndex = 4;
            this.rbHeadDirection.TabStop = true;
            this.rbHeadDirection.Text = "Direction";
            this.rbHeadDirection.UseVisualStyleBackColor = true;
            this.rbHeadDirection.Click += new System.EventHandler(this.HeadingTypeChanged);
            // 
            // rbHeadCoordinates
            // 
            this.rbHeadCoordinates.AutoSize = true;
            this.rbHeadCoordinates.Location = new System.Drawing.Point(9, 19);
            this.rbHeadCoordinates.Name = "rbHeadCoordinates";
            this.rbHeadCoordinates.Size = new System.Drawing.Size(81, 17);
            this.rbHeadCoordinates.TabIndex = 3;
            this.rbHeadCoordinates.TabStop = true;
            this.rbHeadCoordinates.Text = "Coordinates";
            this.rbHeadCoordinates.UseVisualStyleBackColor = true;
            this.rbHeadCoordinates.Click += new System.EventHandler(this.HeadingTypeChanged);
            // 
            // gboxStatsOrientation
            // 
            this.gboxStatsOrientation.Controls.Add(this.pnlStatsOrientation);
            this.gboxStatsOrientation.Location = new System.Drawing.Point(6, 100);
            this.gboxStatsOrientation.Name = "gboxStatsOrientation";
            this.gboxStatsOrientation.Size = new System.Drawing.Size(157, 55);
            this.gboxStatsOrientation.TabIndex = 3;
            this.gboxStatsOrientation.TabStop = false;
            this.gboxStatsOrientation.Text = "Orientation";
            // 
            // pnlStatsOrientation
            // 
            this.pnlStatsOrientation.Controls.Add(this.nudStatsDegrees);
            this.pnlStatsOrientation.Controls.Add(this.lblStatsDegrees);
            this.pnlStatsOrientation.Location = new System.Drawing.Point(31, 23);
            this.pnlStatsOrientation.Name = "pnlStatsOrientation";
            this.pnlStatsOrientation.Size = new System.Drawing.Size(120, 26);
            this.pnlStatsOrientation.TabIndex = 9;
            // 
            // nudStatsDegrees
            // 
            this.nudStatsDegrees.DecimalPlaces = 1;
            this.nudStatsDegrees.Location = new System.Drawing.Point(59, 3);
            this.nudStatsDegrees.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudStatsDegrees.Name = "nudStatsDegrees";
            this.nudStatsDegrees.Size = new System.Drawing.Size(56, 20);
            this.nudStatsDegrees.TabIndex = 7;
            this.nudStatsDegrees.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudStatsDegrees.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblStatsDegrees
            // 
            this.lblStatsDegrees.AutoSize = true;
            this.lblStatsDegrees.Location = new System.Drawing.Point(2, 5);
            this.lblStatsDegrees.Name = "lblStatsDegrees";
            this.lblStatsDegrees.Size = new System.Drawing.Size(50, 13);
            this.lblStatsDegrees.TabIndex = 6;
            this.lblStatsDegrees.Text = "Degrees:";
            // 
            // gboxCurrentStats
            // 
            this.gboxCurrentStats.Controls.Add(this.gboxStatsCoordinates);
            this.gboxCurrentStats.Controls.Add(this.gboxStatsOrientation);
            this.gboxCurrentStats.Location = new System.Drawing.Point(3, 3);
            this.gboxCurrentStats.Name = "gboxCurrentStats";
            this.gboxCurrentStats.Size = new System.Drawing.Size(167, 160);
            this.gboxCurrentStats.TabIndex = 4;
            this.gboxCurrentStats.TabStop = false;
            this.gboxCurrentStats.Text = "CurrentStats";
            // 
            // gboxStatsCoordinates
            // 
            this.gboxStatsCoordinates.Controls.Add(this.pnlStatsCoordinates);
            this.gboxStatsCoordinates.Location = new System.Drawing.Point(6, 19);
            this.gboxStatsCoordinates.Name = "gboxStatsCoordinates";
            this.gboxStatsCoordinates.Size = new System.Drawing.Size(157, 80);
            this.gboxStatsCoordinates.TabIndex = 5;
            this.gboxStatsCoordinates.TabStop = false;
            this.gboxStatsCoordinates.Text = "Coordinates";
            // 
            // pnlStatsCoordinates
            // 
            this.pnlStatsCoordinates.Controls.Add(this.nudStatsLongitude);
            this.pnlStatsCoordinates.Controls.Add(this.lblStatsLongitude);
            this.pnlStatsCoordinates.Controls.Add(this.lblStatsLattitude);
            this.pnlStatsCoordinates.Controls.Add(this.nudStatsLattitude);
            this.pnlStatsCoordinates.Location = new System.Drawing.Point(31, 23);
            this.pnlStatsCoordinates.Name = "pnlStatsCoordinates";
            this.pnlStatsCoordinates.Size = new System.Drawing.Size(120, 52);
            this.pnlStatsCoordinates.TabIndex = 3;
            // 
            // nudStatsLongitude
            // 
            this.nudStatsLongitude.DecimalPlaces = 2;
            this.nudStatsLongitude.Location = new System.Drawing.Point(59, 3);
            this.nudStatsLongitude.Name = "nudStatsLongitude";
            this.nudStatsLongitude.Size = new System.Drawing.Size(56, 20);
            this.nudStatsLongitude.TabIndex = 3;
            this.nudStatsLongitude.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStatsLongitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblStatsLongitude
            // 
            this.lblStatsLongitude.AutoSize = true;
            this.lblStatsLongitude.Location = new System.Drawing.Point(3, 5);
            this.lblStatsLongitude.Name = "lblStatsLongitude";
            this.lblStatsLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblStatsLongitude.TabIndex = 1;
            this.lblStatsLongitude.Text = "Longitude:";
            // 
            // lblStatsLattitude
            // 
            this.lblStatsLattitude.AutoSize = true;
            this.lblStatsLattitude.Location = new System.Drawing.Point(3, 31);
            this.lblStatsLattitude.Name = "lblStatsLattitude";
            this.lblStatsLattitude.Size = new System.Drawing.Size(51, 13);
            this.lblStatsLattitude.TabIndex = 4;
            this.lblStatsLattitude.Text = "Lattitude:";
            // 
            // nudStatsLattitude
            // 
            this.nudStatsLattitude.DecimalPlaces = 2;
            this.nudStatsLattitude.Location = new System.Drawing.Point(59, 29);
            this.nudStatsLattitude.Name = "nudStatsLattitude";
            this.nudStatsLattitude.Size = new System.Drawing.Size(56, 20);
            this.nudStatsLattitude.TabIndex = 5;
            this.nudStatsLattitude.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStatsLattitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // gBoxOpMode
            // 
            this.gBoxOpMode.Controls.Add(this.rbOpRun);
            this.gBoxOpMode.Controls.Add(this.tbOpRun);
            this.gBoxOpMode.Controls.Add(this.rbOpSetup);
            this.gBoxOpMode.Location = new System.Drawing.Point(12, 15);
            this.gBoxOpMode.Name = "gBoxOpMode";
            this.gBoxOpMode.Size = new System.Drawing.Size(75, 160);
            this.gBoxOpMode.TabIndex = 5;
            this.gBoxOpMode.TabStop = false;
            this.gBoxOpMode.Text = "OpMode";
            // 
            // rbOpRun
            // 
            this.rbOpRun.AutoSize = true;
            this.rbOpRun.Location = new System.Drawing.Point(6, 65);
            this.rbOpRun.Name = "rbOpRun";
            this.rbOpRun.Size = new System.Drawing.Size(45, 17);
            this.rbOpRun.TabIndex = 8;
            this.rbOpRun.TabStop = true;
            this.rbOpRun.Text = "Run";
            this.rbOpRun.UseVisualStyleBackColor = true;
            // 
            // tbOpRun
            // 
            this.tbOpRun.AutoSize = true;
            this.tbOpRun.Location = new System.Drawing.Point(6, 42);
            this.tbOpRun.Name = "tbOpRun";
            this.tbOpRun.Size = new System.Drawing.Size(65, 17);
            this.tbOpRun.TabIndex = 7;
            this.tbOpRun.TabStop = true;
            this.tbOpRun.Text = "Simulate";
            this.tbOpRun.UseVisualStyleBackColor = true;
            this.tbOpRun.Click += new System.EventHandler(this.OpModeChanged);
            // 
            // rbOpSetup
            // 
            this.rbOpSetup.AutoSize = true;
            this.rbOpSetup.Location = new System.Drawing.Point(6, 19);
            this.rbOpSetup.Name = "rbOpSetup";
            this.rbOpSetup.Size = new System.Drawing.Size(53, 17);
            this.rbOpSetup.TabIndex = 6;
            this.rbOpSetup.TabStop = true;
            this.rbOpSetup.Text = "Setup";
            this.rbOpSetup.UseVisualStyleBackColor = true;
            this.rbOpSetup.Click += new System.EventHandler(this.OpModeChanged);
            // 
            // pnlOpMode
            // 
            this.pnlOpMode.Controls.Add(this.gboxWind);
            this.pnlOpMode.Controls.Add(this.gboxSail);
            this.pnlOpMode.Controls.Add(this.gboxRudder);
            this.pnlOpMode.Controls.Add(this.gboxVelocity);
            this.pnlOpMode.Controls.Add(this.gboxCurrentStats);
            this.pnlOpMode.Controls.Add(this.gboxHeading);
            this.pnlOpMode.Location = new System.Drawing.Point(93, 12);
            this.pnlOpMode.Name = "pnlOpMode";
            this.pnlOpMode.Size = new System.Drawing.Size(692, 166);
            this.pnlOpMode.TabIndex = 6;
            // 
            // gboxWind
            // 
            this.gboxWind.Controls.Add(this.pnlWind);
            this.gboxWind.Location = new System.Drawing.Point(525, 3);
            this.gboxWind.Name = "gboxWind";
            this.gboxWind.Size = new System.Drawing.Size(157, 80);
            this.gboxWind.TabIndex = 11;
            this.gboxWind.TabStop = false;
            this.gboxWind.Text = "Wind";
            // 
            // pnlWind
            // 
            this.pnlWind.Controls.Add(this.nudWindDirection);
            this.pnlWind.Controls.Add(this.nudWindMagnitude);
            this.pnlWind.Controls.Add(this.lblWindMagnitude);
            this.pnlWind.Controls.Add(this.lblWindDirection);
            this.pnlWind.Location = new System.Drawing.Point(31, 23);
            this.pnlWind.Name = "pnlWind";
            this.pnlWind.Size = new System.Drawing.Size(120, 52);
            this.pnlWind.TabIndex = 3;
            // 
            // nudWindDirection
            // 
            this.nudWindDirection.DecimalPlaces = 1;
            this.nudWindDirection.Location = new System.Drawing.Point(58, 29);
            this.nudWindDirection.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudWindDirection.Name = "nudWindDirection";
            this.nudWindDirection.Size = new System.Drawing.Size(56, 20);
            this.nudWindDirection.TabIndex = 8;
            this.nudWindDirection.Value = new decimal(new int[] {
            315,
            0,
            0,
            0});
            this.nudWindDirection.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // nudWindMagnitude
            // 
            this.nudWindMagnitude.DecimalPlaces = 2;
            this.nudWindMagnitude.Location = new System.Drawing.Point(59, 3);
            this.nudWindMagnitude.Name = "nudWindMagnitude";
            this.nudWindMagnitude.Size = new System.Drawing.Size(56, 20);
            this.nudWindMagnitude.TabIndex = 3;
            this.nudWindMagnitude.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWindMagnitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblWindMagnitude
            // 
            this.lblWindMagnitude.AutoSize = true;
            this.lblWindMagnitude.Location = new System.Drawing.Point(3, 5);
            this.lblWindMagnitude.Name = "lblWindMagnitude";
            this.lblWindMagnitude.Size = new System.Drawing.Size(60, 13);
            this.lblWindMagnitude.TabIndex = 1;
            this.lblWindMagnitude.Text = "Magnitude:";
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Location = new System.Drawing.Point(3, 31);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(49, 13);
            this.lblWindDirection.TabIndex = 4;
            this.lblWindDirection.Text = "Direction";
            // 
            // gboxSail
            // 
            this.gboxSail.Controls.Add(this.pnlSail);
            this.gboxSail.Location = new System.Drawing.Point(525, 84);
            this.gboxSail.Name = "gboxSail";
            this.gboxSail.Size = new System.Drawing.Size(157, 79);
            this.gboxSail.TabIndex = 10;
            this.gboxSail.TabStop = false;
            this.gboxSail.Text = "Sail";
            // 
            // pnlSail
            // 
            this.pnlSail.Controls.Add(this.nudSailSub);
            this.pnlSail.Controls.Add(this.nudSailMain);
            this.pnlSail.Controls.Add(this.lblSailSub);
            this.pnlSail.Controls.Add(this.lblSailMain);
            this.pnlSail.Location = new System.Drawing.Point(31, 10);
            this.pnlSail.Name = "pnlSail";
            this.pnlSail.Size = new System.Drawing.Size(120, 58);
            this.pnlSail.TabIndex = 9;
            // 
            // nudSailSub
            // 
            this.nudSailSub.DecimalPlaces = 1;
            this.nudSailSub.Location = new System.Drawing.Point(60, 35);
            this.nudSailSub.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudSailSub.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.nudSailSub.Name = "nudSailSub";
            this.nudSailSub.Size = new System.Drawing.Size(56, 20);
            this.nudSailSub.TabIndex = 11;
            this.nudSailSub.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // nudSailMain
            // 
            this.nudSailMain.DecimalPlaces = 1;
            this.nudSailMain.Location = new System.Drawing.Point(59, 3);
            this.nudSailMain.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudSailMain.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudSailMain.Name = "nudSailMain";
            this.nudSailMain.Size = new System.Drawing.Size(56, 20);
            this.nudSailMain.TabIndex = 7;
            this.nudSailMain.Value = new decimal(new int[] {
            45,
            0,
            0,
            -2147483648});
            this.nudSailMain.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblSailSub
            // 
            this.lblSailSub.AutoSize = true;
            this.lblSailSub.Location = new System.Drawing.Point(3, 37);
            this.lblSailSub.Name = "lblSailSub";
            this.lblSailSub.Size = new System.Drawing.Size(46, 13);
            this.lblSailSub.TabIndex = 10;
            this.lblSailSub.Text = "SubSail:";
            // 
            // lblSailMain
            // 
            this.lblSailMain.AutoSize = true;
            this.lblSailMain.Location = new System.Drawing.Point(2, 5);
            this.lblSailMain.Name = "lblSailMain";
            this.lblSailMain.Size = new System.Drawing.Size(50, 13);
            this.lblSailMain.TabIndex = 6;
            this.lblSailMain.Text = "MainSail:";
            // 
            // gboxRudder
            // 
            this.gboxRudder.Controls.Add(this.pnlBearing);
            this.gboxRudder.Controls.Add(this.pnlRudder);
            this.gboxRudder.Location = new System.Drawing.Point(351, 84);
            this.gboxRudder.Name = "gboxRudder";
            this.gboxRudder.Size = new System.Drawing.Size(157, 79);
            this.gboxRudder.TabIndex = 9;
            this.gboxRudder.TabStop = false;
            this.gboxRudder.Text = "Rudder";
            // 
            // pnlBearing
            // 
            this.pnlBearing.Controls.Add(this.nudBearing);
            this.pnlBearing.Controls.Add(this.lblBearing);
            this.pnlBearing.Location = new System.Drawing.Point(31, 42);
            this.pnlBearing.Name = "pnlBearing";
            this.pnlBearing.Size = new System.Drawing.Size(120, 26);
            this.pnlBearing.TabIndex = 10;
            // 
            // nudBearing
            // 
            this.nudBearing.DecimalPlaces = 1;
            this.nudBearing.Location = new System.Drawing.Point(59, 3);
            this.nudBearing.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBearing.Name = "nudBearing";
            this.nudBearing.Size = new System.Drawing.Size(56, 20);
            this.nudBearing.TabIndex = 7;
            // 
            // lblBearing
            // 
            this.lblBearing.AutoSize = true;
            this.lblBearing.Location = new System.Drawing.Point(2, 5);
            this.lblBearing.Name = "lblBearing";
            this.lblBearing.Size = new System.Drawing.Size(46, 13);
            this.lblBearing.TabIndex = 6;
            this.lblBearing.Text = "Bearing:";
            // 
            // pnlRudder
            // 
            this.pnlRudder.Controls.Add(this.nudRudderDirection);
            this.pnlRudder.Controls.Add(this.lblRudderDirection);
            this.pnlRudder.Location = new System.Drawing.Point(31, 19);
            this.pnlRudder.Name = "pnlRudder";
            this.pnlRudder.Size = new System.Drawing.Size(120, 26);
            this.pnlRudder.TabIndex = 9;
            // 
            // nudRudderDirection
            // 
            this.nudRudderDirection.DecimalPlaces = 1;
            this.nudRudderDirection.Location = new System.Drawing.Point(59, 3);
            this.nudRudderDirection.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudRudderDirection.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudRudderDirection.Name = "nudRudderDirection";
            this.nudRudderDirection.Size = new System.Drawing.Size(56, 20);
            this.nudRudderDirection.TabIndex = 7;
            this.nudRudderDirection.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblRudderDirection
            // 
            this.lblRudderDirection.AutoSize = true;
            this.lblRudderDirection.Location = new System.Drawing.Point(2, 5);
            this.lblRudderDirection.Name = "lblRudderDirection";
            this.lblRudderDirection.Size = new System.Drawing.Size(50, 13);
            this.lblRudderDirection.TabIndex = 6;
            this.lblRudderDirection.Text = "Degrees:";
            // 
            // gboxVelocity
            // 
            this.gboxVelocity.Controls.Add(this.pnlVelocity);
            this.gboxVelocity.Location = new System.Drawing.Point(351, 3);
            this.gboxVelocity.Name = "gboxVelocity";
            this.gboxVelocity.Size = new System.Drawing.Size(157, 80);
            this.gboxVelocity.TabIndex = 8;
            this.gboxVelocity.TabStop = false;
            this.gboxVelocity.Text = "Velocity";
            // 
            // pnlVelocity
            // 
            this.pnlVelocity.Controls.Add(this.nudVelocityDirection);
            this.pnlVelocity.Controls.Add(this.nudVelocityMagnitude);
            this.pnlVelocity.Controls.Add(this.lblVelocityMagnitude);
            this.pnlVelocity.Controls.Add(this.lblVelocityDirection);
            this.pnlVelocity.Location = new System.Drawing.Point(31, 23);
            this.pnlVelocity.Name = "pnlVelocity";
            this.pnlVelocity.Size = new System.Drawing.Size(120, 52);
            this.pnlVelocity.TabIndex = 3;
            // 
            // nudVelocityDirection
            // 
            this.nudVelocityDirection.DecimalPlaces = 1;
            this.nudVelocityDirection.Location = new System.Drawing.Point(58, 29);
            this.nudVelocityDirection.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudVelocityDirection.Name = "nudVelocityDirection";
            this.nudVelocityDirection.Size = new System.Drawing.Size(56, 20);
            this.nudVelocityDirection.TabIndex = 8;
            this.nudVelocityDirection.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudVelocityDirection.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // nudVelocityMagnitude
            // 
            this.nudVelocityMagnitude.DecimalPlaces = 2;
            this.nudVelocityMagnitude.Location = new System.Drawing.Point(59, 3);
            this.nudVelocityMagnitude.Name = "nudVelocityMagnitude";
            this.nudVelocityMagnitude.Size = new System.Drawing.Size(56, 20);
            this.nudVelocityMagnitude.TabIndex = 3;
            this.nudVelocityMagnitude.ValueChanged += new System.EventHandler(this.UpdateBoat);
            // 
            // lblVelocityMagnitude
            // 
            this.lblVelocityMagnitude.AutoSize = true;
            this.lblVelocityMagnitude.Location = new System.Drawing.Point(3, 5);
            this.lblVelocityMagnitude.Name = "lblVelocityMagnitude";
            this.lblVelocityMagnitude.Size = new System.Drawing.Size(60, 13);
            this.lblVelocityMagnitude.TabIndex = 1;
            this.lblVelocityMagnitude.Text = "Magnitude:";
            // 
            // lblVelocityDirection
            // 
            this.lblVelocityDirection.AutoSize = true;
            this.lblVelocityDirection.Location = new System.Drawing.Point(3, 31);
            this.lblVelocityDirection.Name = "lblVelocityDirection";
            this.lblVelocityDirection.Size = new System.Drawing.Size(49, 13);
            this.lblVelocityDirection.TabIndex = 4;
            this.lblVelocityDirection.Text = "Direction";
            // 
            // gboxAccelerometer
            // 
            this.gboxAccelerometer.Controls.Add(this.lblAccelYaw);
            this.gboxAccelerometer.Controls.Add(this.lblAccelPitch);
            this.gboxAccelerometer.Controls.Add(this.tbarAccelPitch);
            this.gboxAccelerometer.Controls.Add(this.tbarAccelYaw);
            this.gboxAccelerometer.Location = new System.Drawing.Point(618, 181);
            this.gboxAccelerometer.Name = "gboxAccelerometer";
            this.gboxAccelerometer.Size = new System.Drawing.Size(167, 160);
            this.gboxAccelerometer.TabIndex = 7;
            this.gboxAccelerometer.TabStop = false;
            this.gboxAccelerometer.Text = "Accelerometer";
            // 
            // lblAccelYaw
            // 
            this.lblAccelYaw.AutoSize = true;
            this.lblAccelYaw.Location = new System.Drawing.Point(67, 16);
            this.lblAccelYaw.Name = "lblAccelYaw";
            this.lblAccelYaw.Size = new System.Drawing.Size(28, 13);
            this.lblAccelYaw.TabIndex = 8;
            this.lblAccelYaw.Text = "Yaw";
            // 
            // lblAccelPitch
            // 
            this.lblAccelPitch.AutoSize = true;
            this.lblAccelPitch.Location = new System.Drawing.Point(65, 66);
            this.lblAccelPitch.Name = "lblAccelPitch";
            this.lblAccelPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAccelPitch.Size = new System.Drawing.Size(31, 13);
            this.lblAccelPitch.TabIndex = 9;
            this.lblAccelPitch.Text = "Pitch";
            // 
            // tbarAccelPitch
            // 
            this.tbarAccelPitch.LargeChange = 15;
            this.tbarAccelPitch.Location = new System.Drawing.Point(6, 58);
            this.tbarAccelPitch.Maximum = 180;
            this.tbarAccelPitch.Name = "tbarAccelPitch";
            this.tbarAccelPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarAccelPitch.Size = new System.Drawing.Size(45, 97);
            this.tbarAccelPitch.TabIndex = 9;
            this.tbarAccelPitch.TickFrequency = 45;
            this.tbarAccelPitch.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbarAccelYaw
            // 
            this.tbarAccelYaw.LargeChange = 15;
            this.tbarAccelYaw.Location = new System.Drawing.Point(6, 32);
            this.tbarAccelYaw.Maximum = 180;
            this.tbarAccelYaw.Name = "tbarAccelYaw";
            this.tbarAccelYaw.Size = new System.Drawing.Size(155, 45);
            this.tbarAccelYaw.TabIndex = 8;
            this.tbarAccelYaw.TickFrequency = 45;
            this.tbarAccelYaw.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Pulse
            // 
            this.Pulse.Tick += new System.EventHandler(this.Logic);
            // 
            // pboxOcean
            // 
            this.pboxOcean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxOcean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxOcean.Location = new System.Drawing.Point(12, 181);
            this.pboxOcean.Name = "pboxOcean";
            this.pboxOcean.Size = new System.Drawing.Size(600, 600);
            this.pboxOcean.TabIndex = 8;
            this.pboxOcean.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(618, 347);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(618, 373);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // SailingSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 789);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pboxOcean);
            this.Controls.Add(this.gboxAccelerometer);
            this.Controls.Add(this.pnlOpMode);
            this.Controls.Add(this.gBoxOpMode);
            this.Name = "SailingSimulator";
            this.Text = "Bearing:";
            this.Load += new System.EventHandler(this.UpdateBoat);
            this.gboxHeading.ResumeLayout(false);
            this.gboxHeading.PerformLayout();
            this.pnlHeadDirection.ResumeLayout(false);
            this.pnlHeadDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadDegrees)).EndInit();
            this.pnlHeadCoordinates.ResumeLayout(false);
            this.pnlHeadCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadLattitude)).EndInit();
            this.gboxStatsOrientation.ResumeLayout(false);
            this.pnlStatsOrientation.ResumeLayout(false);
            this.pnlStatsOrientation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsDegrees)).EndInit();
            this.gboxCurrentStats.ResumeLayout(false);
            this.gboxStatsCoordinates.ResumeLayout(false);
            this.pnlStatsCoordinates.ResumeLayout(false);
            this.pnlStatsCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStatsLattitude)).EndInit();
            this.gBoxOpMode.ResumeLayout(false);
            this.gBoxOpMode.PerformLayout();
            this.pnlOpMode.ResumeLayout(false);
            this.gboxWind.ResumeLayout(false);
            this.pnlWind.ResumeLayout(false);
            this.pnlWind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindMagnitude)).EndInit();
            this.gboxSail.ResumeLayout(false);
            this.pnlSail.ResumeLayout(false);
            this.pnlSail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSailSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSailMain)).EndInit();
            this.gboxRudder.ResumeLayout(false);
            this.pnlBearing.ResumeLayout(false);
            this.pnlBearing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBearing)).EndInit();
            this.pnlRudder.ResumeLayout(false);
            this.pnlRudder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRudderDirection)).EndInit();
            this.gboxVelocity.ResumeLayout(false);
            this.pnlVelocity.ResumeLayout(false);
            this.pnlVelocity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocityDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocityMagnitude)).EndInit();
            this.gboxAccelerometer.ResumeLayout(false);
            this.gboxAccelerometer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAccelPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAccelYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeadLongitude;
        private System.Windows.Forms.GroupBox gboxHeading;
        private System.Windows.Forms.NumericUpDown nudHeadDegrees;
        private System.Windows.Forms.Label lblHeadDegrees;
        private System.Windows.Forms.NumericUpDown nudHeadLattitude;
        private System.Windows.Forms.Label lblHeadLattitude;
        private System.Windows.Forms.NumericUpDown nudHeadLongitude;
        private System.Windows.Forms.RadioButton rbHeadDirection;
        private System.Windows.Forms.RadioButton rbHeadCoordinates;
        private System.Windows.Forms.Panel pnlHeadDirection;
        private System.Windows.Forms.Panel pnlHeadCoordinates;
        private System.Windows.Forms.GroupBox gboxStatsOrientation;
        private System.Windows.Forms.Panel pnlStatsOrientation;
        private System.Windows.Forms.NumericUpDown nudStatsDegrees;
        private System.Windows.Forms.Label lblStatsDegrees;
        private System.Windows.Forms.GroupBox gboxCurrentStats;
        private System.Windows.Forms.GroupBox gboxStatsCoordinates;
        private System.Windows.Forms.Panel pnlStatsCoordinates;
        private System.Windows.Forms.NumericUpDown nudStatsLongitude;
        private System.Windows.Forms.Label lblStatsLongitude;
        private System.Windows.Forms.Label lblStatsLattitude;
        private System.Windows.Forms.NumericUpDown nudStatsLattitude;
        private System.Windows.Forms.GroupBox gBoxOpMode;
        private System.Windows.Forms.RadioButton rbOpSetup;
        private System.Windows.Forms.RadioButton tbOpRun;
        private System.Windows.Forms.Panel pnlOpMode;
        private System.Windows.Forms.GroupBox gboxAccelerometer;
        private System.Windows.Forms.RadioButton rbOpRun;
        private System.Windows.Forms.GroupBox gboxVelocity;
        private System.Windows.Forms.Panel pnlVelocity;
        private System.Windows.Forms.NumericUpDown nudVelocityDirection;
        private System.Windows.Forms.NumericUpDown nudVelocityMagnitude;
        private System.Windows.Forms.Label lblVelocityMagnitude;
        private System.Windows.Forms.Label lblVelocityDirection;
        private System.Windows.Forms.Label lblAccelYaw;
        private System.Windows.Forms.Label lblAccelPitch;
        private System.Windows.Forms.TrackBar tbarAccelPitch;
        private System.Windows.Forms.TrackBar tbarAccelYaw;
        private System.Windows.Forms.Timer Pulse;
        private System.Windows.Forms.PictureBox pboxOcean;
        private System.Windows.Forms.GroupBox gboxRudder;
        private System.Windows.Forms.Panel pnlRudder;
        private System.Windows.Forms.NumericUpDown nudRudderDirection;
        private System.Windows.Forms.Label lblRudderDirection;
        private System.Windows.Forms.GroupBox gboxSail;
        private System.Windows.Forms.Panel pnlSail;
        private System.Windows.Forms.NumericUpDown nudSailSub;
        private System.Windows.Forms.NumericUpDown nudSailMain;
        private System.Windows.Forms.Label lblSailSub;
        private System.Windows.Forms.Label lblSailMain;
        private System.Windows.Forms.GroupBox gboxWind;
        private System.Windows.Forms.Panel pnlWind;
        private System.Windows.Forms.NumericUpDown nudWindDirection;
        private System.Windows.Forms.NumericUpDown nudWindMagnitude;
        private System.Windows.Forms.Label lblWindMagnitude;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Panel pnlBearing;
        private System.Windows.Forms.NumericUpDown nudBearing;
        private System.Windows.Forms.Label lblBearing;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

