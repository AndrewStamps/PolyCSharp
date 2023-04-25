using System.Data;
using System.Diagnostics;

namespace PolyPolyCSharp {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }//end constructor

        private void btnChooseFolder_Click(object sender, EventArgs e) {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            string directory;
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection";

            if (folderBrowser.ShowDialog() == DialogResult.OK) {
                directory = Path.GetDirectoryName(folderBrowser.FileName);

                if (Directory.Exists(directory)) {
                    txtPath.Text = directory;
                    btnGenerate.Enabled = true;
                    lsbData.Enabled = true;
                }//end if
            }//end if
        }//end event

        private void btnGenerate_Click(object sender, EventArgs e) {
            //DISABLE TEXTBOX
            txtPath.Enabled = false;

            //SETUP SCATTERPLOT
            Scatterplot scatterplot = new Scatterplot();
            scatterplot.SaveLocation = txtPath.Text;
            scatterplot.ShowHull = chkShowHull.Checked;
            scatterplot.HullColor = pnlHullColor.BackColor;
            scatterplot.PointColor = pnlPointColor.BackColor;
            scatterplot.PointSize = (int)numPointSize.Value;
            scatterplot.HullLineThickness = (int)numHullThickness.Value;
            scatterplot.ShowAxis = chkShowAxes.Checked;
            scatterplot.AxisOffset = (int)numAxisOffset.Value;
            scatterplot.AxisColor = pnlAxisColor.BackColor;

            scatterplot.SetListBox(lsbData);
            scatterplot.SetProgressBar(pgsPlots);

            //GRAB SETTINGS FROM FORM
            int intMinRadius = int.Parse(txtMinRadius.Text);
            int intMaxRadius = int.Parse(txtMaxRadius.Text);
            int intRadiusCount = int.Parse(txtPlotCount.Text);
            int intRadiusGrowthRate = int.Parse(txtGrowthRate.Text);
            int intPointsPerPlot = int.Parse(txtPointsPerPlot.Text);

            //CLEAR LISTBOX
            lsbData.Items.Clear();

            //CREATE PLOTS
            List<PlotData> pltData = scatterplot.MakeScatterplots(intMinRadius, intMaxRadius, intRadiusGrowthRate, intRadiusCount, intPointsPerPlot, false);

            //LAUNCH FOLDER IF SELECTED
            if (chkShowFiles.Checked) {
                //    Process.Start(txtPath.Text);
            }//end if

            //ACTIVATE TEXTBOX
            txtPath.Enabled = true;
        }//end event

        private bool IsNumeric(string value) {
            return double.TryParse(value, out double temp);
        }//end method

        private void LinkTextboxToTrackBar(TextBox txt, TrackBar trk) {
            if (IsNumeric(txt.Text)) {
                int textValue = (int)double.Parse(txt.Text);

                if (textValue > trk.Maximum) {
                    textValue = trk.Maximum;
                    txt.Text = textValue.ToString();
                }//end if

                if (textValue < trk.Minimum) {
                    textValue = trk.Minimum;
                    txt.Text = textValue.ToString();
                }//end if

                trk.Value = textValue;

                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            } else {
                txt.BackColor = Color.Goldenrod;
                txt.ForeColor = Color.IndianRed;
            }//end if
        }//end method

        private void txtMinRadius_TextChanged(object sender, EventArgs e) {
            LinkTextboxToTrackBar((TextBox)sender, trkMinRadius);
        }//end method

        private void trkMinRadius_Scroll(object sender, EventArgs e) {
            txtMinRadius.Text = trkMinRadius.Value.ToString();
        }//end method

        private void txtMaxRadius_TextChanged(object sender, EventArgs e) {
            LinkTextboxToTrackBar(txtMaxRadius, trkMaxRadius);
        }

        private void trkMaxRadius_Scroll(object sender, EventArgs e) {
            txtMaxRadius.Text = trkMaxRadius.Value.ToString();
        }

        private void txtGrowthRate_TextChanged(object sender, EventArgs e) {
            LinkTextboxToTrackBar(txtGrowthRate, trkGrowthRate);
        }

        private void trkGrowthRate_Scroll(object sender, EventArgs e) {
            txtGrowthRate.Text = trkGrowthRate.Value.ToString();
        }

        private void txtPlotCount_TextChanged(object sender, EventArgs e) {
            LinkTextboxToTrackBar(txtPlotCount, trkPltCount);
        }

        private void trkPltCount_Scroll(object sender, EventArgs e) {
            txtPlotCount.Text = trkPltCount.Value.ToString();
        }

        private void txtPointsPerPlot_TextChanged(object sender, EventArgs e) {
            LinkTextboxToTrackBar(txtPointsPerPlot, trkPointsPerPlot);
        }

        private void trkPointsPerPlot_Scroll(object sender, EventArgs e) {
            txtPointsPerPlot.Text = trkPointsPerPlot.Value.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e) {

        }

        private void txtPath_TextChanged(object sender, EventArgs e) {
            if (Directory.Exists(txtPath.Text)) {
                txtPath.BackColor = Color.White;
                txtPath.ForeColor = Color.Black;
                btnGenerate.Enabled = true;
            } else {
                txtPath.BackColor = Color.Goldenrod;
                txtPath.ForeColor = Color.IndianRed;
                btnGenerate.Enabled = false;
            }//end if
        }//end event

        private void pnlPointColor_Click(object sender, EventArgs e) {
            cdgChooser.Color = pnlPointColor.BackColor;

            if (cdgChooser.ShowDialog() == DialogResult.OK) {
                pnlPointColor.BackColor = cdgChooser.Color;
            }//end if
        }//end event

        private void pnlHullColor_Click(object sender, EventArgs e) {
            cdgChooser.Color = pnlPointColor.BackColor;

            if (cdgChooser.ShowDialog() == DialogResult.OK) {
                pnlHullColor.BackColor = cdgChooser.Color;
            }//end if
        }//end event


        private void pnlAxisColor_Click(object sender, EventArgs e) {
            cdgChooser.Color = pnlPointColor.BackColor;

            if (cdgChooser.ShowDialog() == DialogResult.OK) {
                pnlAxisColor.BackColor = cdgChooser.Color;
            }//end if
        }//end event

        private void chkShowAxes_CheckedChanged(object sender, EventArgs e) {
            lblAxisOffset.Enabled = chkShowAxes.Checked;
            numAxisOffset.Enabled = chkShowAxes.Checked;
            lblAxisColor.Enabled = chkShowAxes.Checked;
            pnlAxisColor.Enabled = chkShowAxes.Checked;
        }//end event

        private void chkShowHull_CheckedChanged(object sender, EventArgs e) {
            lblHullColor.Enabled = chkShowHull.Checked;
            pnlHullColor.Enabled = chkShowHull.Checked;
        }//end event

    }
}