namespace PolyPolyCSharp {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnGenerate = new Button();
            txtPath = new TextBox();
            pgsPlots = new ProgressBar();
            btnChooseFolder = new Button();
            lsbData = new ListBox();
            chkShowHull = new CheckBox();
            trkMinRadius = new TrackBar();
            txtMinRadius = new TextBox();
            lblMinRadius = new Label();
            lblMaxRadius = new Label();
            txtMaxRadius = new TextBox();
            trkMaxRadius = new TrackBar();
            lblPlotCount = new Label();
            txtPlotCount = new TextBox();
            trkPltCount = new TrackBar();
            lblGrowthRate = new Label();
            txtGrowthRate = new TextBox();
            trkGrowthRate = new TrackBar();
            lblPointsPerPlot = new Label();
            txtPointsPerPlot = new TextBox();
            trkPointsPerPlot = new TrackBar();
            lblLog = new Label();
            label1 = new Label();
            lblPointColor = new Label();
            pnlPointColor = new Panel();
            pnlHullColor = new Panel();
            lblHullColor = new Label();
            cdgChooser = new ColorDialog();
            numPointSize = new NumericUpDown();
            lblPointSize = new Label();
            lblHullLineThickness = new Label();
            numHullThickness = new NumericUpDown();
            chkShowAxes = new CheckBox();
            numAxisOffset = new NumericUpDown();
            lblAxisOffset = new Label();
            pnlAxisColor = new Panel();
            lblAxisColor = new Label();
            chkShowFiles = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trkMinRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkMaxRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPltCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkGrowthRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkPointsPerPlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPointSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHullThickness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAxisOffset).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(373, 828);
            btnGenerate.Margin = new Padding(4, 3, 4, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(187, 92);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(52, 71);
            txtPath.Margin = new Padding(4, 3, 4, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(830, 35);
            txtPath.TabIndex = 2;
            txtPath.TextChanged += txtPath_TextChanged;
            // 
            // pgsPlots
            // 
            pgsPlots.BackColor = Color.IndianRed;
            pgsPlots.ForeColor = Color.Gold;
            pgsPlots.Location = new Point(52, 931);
            pgsPlots.Margin = new Padding(4, 3, 4, 3);
            pgsPlots.Name = "pgsPlots";
            pgsPlots.Size = new Size(831, 38);
            pgsPlots.TabIndex = 3;
            pgsPlots.Visible = false;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(695, 137);
            btnChooseFolder.Margin = new Padding(4, 3, 4, 3);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(187, 92);
            btnChooseFolder.TabIndex = 4;
            btnChooseFolder.Text = "Choose Folder";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // lsbData
            // 
            lsbData.Enabled = false;
            lsbData.FormattingEnabled = true;
            lsbData.ItemHeight = 28;
            lsbData.Location = new Point(939, 124);
            lsbData.Margin = new Padding(4, 3, 4, 3);
            lsbData.Name = "lsbData";
            lsbData.Size = new Size(534, 844);
            lsbData.TabIndex = 5;
            // 
            // chkShowHull
            // 
            chkShowHull.AutoSize = true;
            chkShowHull.Location = new Point(52, 234);
            chkShowHull.Margin = new Padding(4, 3, 4, 3);
            chkShowHull.Name = "chkShowHull";
            chkShowHull.Size = new Size(155, 32);
            chkShowHull.TabIndex = 6;
            chkShowHull.Text = "Show Hull";
            chkShowHull.UseVisualStyleBackColor = true;
            chkShowHull.CheckedChanged += chkShowHull_CheckedChanged;
            // 
            // trkMinRadius
            // 
            trkMinRadius.Location = new Point(202, 343);
            trkMinRadius.Margin = new Padding(4, 3, 4, 3);
            trkMinRadius.Maximum = 4096;
            trkMinRadius.Minimum = 1;
            trkMinRadius.Name = "trkMinRadius";
            trkMinRadius.Size = new Size(358, 69);
            trkMinRadius.TabIndex = 2;
            trkMinRadius.TickStyle = TickStyle.None;
            trkMinRadius.Value = 64;
            trkMinRadius.Scroll += trkMinRadius_Scroll;
            // 
            // txtMinRadius
            // 
            txtMinRadius.Location = new Point(52, 343);
            txtMinRadius.Margin = new Padding(4, 3, 4, 3);
            txtMinRadius.Name = "txtMinRadius";
            txtMinRadius.Size = new Size(109, 35);
            txtMinRadius.TabIndex = 8;
            txtMinRadius.Text = "64";
            txtMinRadius.TextChanged += txtMinRadius_TextChanged;
            // 
            // lblMinRadius
            // 
            lblMinRadius.AutoSize = true;
            lblMinRadius.Location = new Point(52, 308);
            lblMinRadius.Margin = new Padding(4, 0, 4, 0);
            lblMinRadius.Name = "lblMinRadius";
            lblMinRadius.Size = new Size(233, 28);
            lblMinRadius.TabIndex = 9;
            lblMinRadius.Text = "Minimum Radius Px";
            // 
            // lblMaxRadius
            // 
            lblMaxRadius.AutoSize = true;
            lblMaxRadius.Location = new Point(52, 410);
            lblMaxRadius.Margin = new Padding(4, 0, 4, 0);
            lblMaxRadius.Name = "lblMaxRadius";
            lblMaxRadius.Size = new Size(233, 28);
            lblMaxRadius.TabIndex = 12;
            lblMaxRadius.Text = "Maximum Radius Px";
            // 
            // txtMaxRadius
            // 
            txtMaxRadius.Location = new Point(52, 445);
            txtMaxRadius.Margin = new Padding(4, 3, 4, 3);
            txtMaxRadius.Name = "txtMaxRadius";
            txtMaxRadius.Size = new Size(109, 35);
            txtMaxRadius.TabIndex = 11;
            txtMaxRadius.Text = "128";
            txtMaxRadius.TextChanged += txtMaxRadius_TextChanged;
            // 
            // trkMaxRadius
            // 
            trkMaxRadius.Location = new Point(202, 445);
            trkMaxRadius.Margin = new Padding(4, 3, 4, 3);
            trkMaxRadius.Maximum = 4096;
            trkMaxRadius.Minimum = 1;
            trkMaxRadius.Name = "trkMaxRadius";
            trkMaxRadius.Size = new Size(358, 69);
            trkMaxRadius.TabIndex = 10;
            trkMaxRadius.TickStyle = TickStyle.None;
            trkMaxRadius.Value = 128;
            trkMaxRadius.Scroll += trkMaxRadius_Scroll;
            // 
            // lblPlotCount
            // 
            lblPlotCount.AutoSize = true;
            lblPlotCount.Location = new Point(52, 613);
            lblPlotCount.Margin = new Padding(4, 0, 4, 0);
            lblPlotCount.Name = "lblPlotCount";
            lblPlotCount.Size = new Size(207, 28);
            lblPlotCount.TabIndex = 15;
            lblPlotCount.Text = "Plots Per Radii";
            // 
            // txtPlotCount
            // 
            txtPlotCount.Location = new Point(52, 648);
            txtPlotCount.Margin = new Padding(4, 3, 4, 3);
            txtPlotCount.Name = "txtPlotCount";
            txtPlotCount.Size = new Size(109, 35);
            txtPlotCount.TabIndex = 14;
            txtPlotCount.Text = "4";
            txtPlotCount.TextChanged += txtPlotCount_TextChanged;
            // 
            // trkPltCount
            // 
            trkPltCount.Location = new Point(202, 648);
            trkPltCount.Margin = new Padding(4, 3, 4, 3);
            trkPltCount.Maximum = 64;
            trkPltCount.Minimum = 1;
            trkPltCount.Name = "trkPltCount";
            trkPltCount.Size = new Size(358, 69);
            trkPltCount.TabIndex = 13;
            trkPltCount.Value = 4;
            trkPltCount.Scroll += trkPltCount_Scroll;
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Location = new Point(52, 515);
            lblGrowthRate.Margin = new Padding(4, 0, 4, 0);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Size = new Size(285, 28);
            lblGrowthRate.TabIndex = 18;
            lblGrowthRate.Text = "Radius Growth Rate Px";
            // 
            // txtGrowthRate
            // 
            txtGrowthRate.Location = new Point(52, 550);
            txtGrowthRate.Margin = new Padding(4, 3, 4, 3);
            txtGrowthRate.Name = "txtGrowthRate";
            txtGrowthRate.Size = new Size(109, 35);
            txtGrowthRate.TabIndex = 17;
            txtGrowthRate.Text = "32";
            txtGrowthRate.TextChanged += txtGrowthRate_TextChanged;
            // 
            // trkGrowthRate
            // 
            trkGrowthRate.Location = new Point(202, 550);
            trkGrowthRate.Margin = new Padding(4, 3, 4, 3);
            trkGrowthRate.Maximum = 64;
            trkGrowthRate.Minimum = 1;
            trkGrowthRate.Name = "trkGrowthRate";
            trkGrowthRate.Size = new Size(358, 69);
            trkGrowthRate.TabIndex = 16;
            trkGrowthRate.Value = 32;
            trkGrowthRate.Scroll += trkGrowthRate_Scroll;
            // 
            // lblPointsPerPlot
            // 
            lblPointsPerPlot.AutoSize = true;
            lblPointsPerPlot.Location = new Point(52, 717);
            lblPointsPerPlot.Margin = new Padding(4, 0, 4, 0);
            lblPointsPerPlot.Name = "lblPointsPerPlot";
            lblPointsPerPlot.Size = new Size(207, 28);
            lblPointsPerPlot.TabIndex = 21;
            lblPointsPerPlot.Text = "Points Per Plot";
            // 
            // txtPointsPerPlot
            // 
            txtPointsPerPlot.Location = new Point(52, 752);
            txtPointsPerPlot.Margin = new Padding(4, 3, 4, 3);
            txtPointsPerPlot.Name = "txtPointsPerPlot";
            txtPointsPerPlot.Size = new Size(109, 35);
            txtPointsPerPlot.TabIndex = 20;
            txtPointsPerPlot.Text = "256";
            txtPointsPerPlot.TextChanged += txtPointsPerPlot_TextChanged;
            // 
            // trkPointsPerPlot
            // 
            trkPointsPerPlot.Location = new Point(202, 752);
            trkPointsPerPlot.Margin = new Padding(4, 3, 4, 3);
            trkPointsPerPlot.Maximum = 32768;
            trkPointsPerPlot.Minimum = 1;
            trkPointsPerPlot.Name = "trkPointsPerPlot";
            trkPointsPerPlot.Size = new Size(358, 69);
            trkPointsPerPlot.TabIndex = 19;
            trkPointsPerPlot.TickStyle = TickStyle.None;
            trkPointsPerPlot.Value = 256;
            trkPointsPerPlot.Scroll += trkPointsPerPlot_Scroll;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(940, 78);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(116, 28);
            lblLog.TabIndex = 22;
            lblLog.Text = "Data Log";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 40);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 23;
            label1.Text = "Save Location";
            // 
            // lblPointColor
            // 
            lblPointColor.AutoSize = true;
            lblPointColor.Location = new Point(593, 308);
            lblPointColor.Name = "lblPointColor";
            lblPointColor.Size = new Size(155, 28);
            lblPointColor.TabIndex = 25;
            lblPointColor.Text = "Point Color";
            // 
            // pnlPointColor
            // 
            pnlPointColor.BackColor = Color.IndianRed;
            pnlPointColor.BorderStyle = BorderStyle.FixedSingle;
            pnlPointColor.Location = new Point(599, 343);
            pnlPointColor.Name = "pnlPointColor";
            pnlPointColor.Size = new Size(290, 35);
            pnlPointColor.TabIndex = 26;
            pnlPointColor.Click += pnlPointColor_Click;
            // 
            // pnlHullColor
            // 
            pnlHullColor.BackColor = Color.CornflowerBlue;
            pnlHullColor.BorderStyle = BorderStyle.FixedSingle;
            pnlHullColor.Enabled = false;
            pnlHullColor.Location = new Point(599, 445);
            pnlHullColor.Name = "pnlHullColor";
            pnlHullColor.Size = new Size(290, 35);
            pnlHullColor.TabIndex = 28;
            pnlHullColor.Click += pnlHullColor_Click;
            // 
            // lblHullColor
            // 
            lblHullColor.AutoSize = true;
            lblHullColor.Enabled = false;
            lblHullColor.Location = new Point(593, 410);
            lblHullColor.Name = "lblHullColor";
            lblHullColor.Size = new Size(142, 28);
            lblHullColor.TabIndex = 27;
            lblHullColor.Text = "Hull Color";
            // 
            // numPointSize
            // 
            numPointSize.Location = new Point(597, 644);
            numPointSize.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numPointSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPointSize.Name = "numPointSize";
            numPointSize.Size = new Size(180, 35);
            numPointSize.TabIndex = 29;
            numPointSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblPointSize
            // 
            lblPointSize.AutoSize = true;
            lblPointSize.Location = new Point(591, 613);
            lblPointSize.Name = "lblPointSize";
            lblPointSize.Size = new Size(181, 28);
            lblPointSize.TabIndex = 30;
            lblPointSize.Text = "Point Size Px";
            // 
            // lblHullLineThickness
            // 
            lblHullLineThickness.AutoSize = true;
            lblHullLineThickness.Location = new Point(591, 711);
            lblHullLineThickness.Name = "lblHullLineThickness";
            lblHullLineThickness.Size = new Size(298, 28);
            lblHullLineThickness.TabIndex = 32;
            lblHullLineThickness.Text = "Hull Line Thickness px";
            // 
            // numHullThickness
            // 
            numHullThickness.Location = new Point(597, 742);
            numHullThickness.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numHullThickness.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHullThickness.Name = "numHullThickness";
            numHullThickness.Size = new Size(180, 35);
            numHullThickness.TabIndex = 31;
            numHullThickness.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // chkShowAxes
            // 
            chkShowAxes.AutoSize = true;
            chkShowAxes.Location = new Point(241, 234);
            chkShowAxes.Margin = new Padding(4, 3, 4, 3);
            chkShowAxes.Name = "chkShowAxes";
            chkShowAxes.Size = new Size(155, 32);
            chkShowAxes.TabIndex = 33;
            chkShowAxes.Text = "Show Axes";
            chkShowAxes.UseVisualStyleBackColor = true;
            chkShowAxes.CheckedChanged += chkShowAxes_CheckedChanged;
            // 
            // numAxisOffset
            // 
            numAxisOffset.Enabled = false;
            numAxisOffset.Location = new Point(420, 234);
            numAxisOffset.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numAxisOffset.Name = "numAxisOffset";
            numAxisOffset.Size = new Size(180, 35);
            numAxisOffset.TabIndex = 34;
            numAxisOffset.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // lblAxisOffset
            // 
            lblAxisOffset.AutoSize = true;
            lblAxisOffset.Enabled = false;
            lblAxisOffset.Location = new Point(420, 201);
            lblAxisOffset.Name = "lblAxisOffset";
            lblAxisOffset.Size = new Size(155, 28);
            lblAxisOffset.TabIndex = 35;
            lblAxisOffset.Text = "Axis Offset";
            // 
            // pnlAxisColor
            // 
            pnlAxisColor.BackColor = Color.Black;
            pnlAxisColor.BorderStyle = BorderStyle.FixedSingle;
            pnlAxisColor.Enabled = false;
            pnlAxisColor.Location = new Point(599, 547);
            pnlAxisColor.Name = "pnlAxisColor";
            pnlAxisColor.Size = new Size(290, 35);
            pnlAxisColor.TabIndex = 29;
            pnlAxisColor.Click += pnlAxisColor_Click;
            // 
            // lblAxisColor
            // 
            lblAxisColor.AutoSize = true;
            lblAxisColor.Enabled = false;
            lblAxisColor.Location = new Point(597, 508);
            lblAxisColor.Name = "lblAxisColor";
            lblAxisColor.Size = new Size(142, 28);
            lblAxisColor.TabIndex = 36;
            lblAxisColor.Text = "Axis Color";
            // 
            // chkShowFiles
            // 
            chkShowFiles.AutoSize = true;
            chkShowFiles.Enabled = false;
            chkShowFiles.Location = new Point(52, 159);
            chkShowFiles.Margin = new Padding(4, 3, 4, 3);
            chkShowFiles.Name = "chkShowFiles";
            chkShowFiles.Size = new Size(402, 32);
            chkShowFiles.TabIndex = 24;
            chkShowFiles.Text = "Open Directory When Complete";
            chkShowFiles.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 1008);
            Controls.Add(lblAxisColor);
            Controls.Add(pnlAxisColor);
            Controls.Add(lblAxisOffset);
            Controls.Add(numAxisOffset);
            Controls.Add(chkShowAxes);
            Controls.Add(lblHullLineThickness);
            Controls.Add(numHullThickness);
            Controls.Add(lblPointSize);
            Controls.Add(numPointSize);
            Controls.Add(pnlHullColor);
            Controls.Add(lblHullColor);
            Controls.Add(pnlPointColor);
            Controls.Add(lblPointColor);
            Controls.Add(chkShowFiles);
            Controls.Add(label1);
            Controls.Add(lblLog);
            Controls.Add(lblPointsPerPlot);
            Controls.Add(txtPointsPerPlot);
            Controls.Add(trkPointsPerPlot);
            Controls.Add(lblGrowthRate);
            Controls.Add(txtGrowthRate);
            Controls.Add(trkGrowthRate);
            Controls.Add(lblPlotCount);
            Controls.Add(txtPlotCount);
            Controls.Add(trkPltCount);
            Controls.Add(lblMaxRadius);
            Controls.Add(txtMaxRadius);
            Controls.Add(trkMaxRadius);
            Controls.Add(lblMinRadius);
            Controls.Add(txtMinRadius);
            Controls.Add(trkMinRadius);
            Controls.Add(chkShowHull);
            Controls.Add(lsbData);
            Controls.Add(btnChooseFolder);
            Controls.Add(pgsPlots);
            Controls.Add(txtPath);
            Controls.Add(btnGenerate);
            Font = new Font("Brass Mono Cozy", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            ShowIcon = false;
            Text = "Poly Poly";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)trkMinRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkMaxRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPltCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkGrowthRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkPointsPerPlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPointSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHullThickness).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAxisOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGenerate;
        private TextBox txtPath;
        private ProgressBar pgsPlots;
        private Button btnChooseFolder;
        private ListBox lsbData;
        private CheckBox chkShowHull;
        private TrackBar trkMinRadius;
        private TextBox txtMinRadius;
        private Label lblMinRadius;
        private Label lblMaxRadius;
        private TextBox txtMaxRadius;
        private TrackBar trkMaxRadius;
        private Label lblPlotCount;
        private TextBox txtPlotCount;
        private TrackBar trkPltCount;
        private Label lblGrowthRate;
        private TextBox txtGrowthRate;
        private TrackBar trkGrowthRate;
        private Label lblPointsPerPlot;
        private TextBox txtPointsPerPlot;
        private TrackBar trkPointsPerPlot;
        private Label lblLog;
        private Label label1;
        private Label lblPointColor;
        private Panel pnlPointColor;
        private Panel pnlHullColor;
        private Label lblHullColor;
        private ColorDialog cdgChooser;
        private NumericUpDown numPointSize;
        private Label lblPointSize;
        private Label lblHullLineThickness;
        private NumericUpDown numHullThickness;
        private CheckBox chkShowAxes;
        private NumericUpDown numAxisOffset;
        private Label lblAxisOffset;
        private Panel pnlAxisColor;
        private Label lblAxisColor;
        private CheckBox chkShowFiles;
    }
}