using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

class Scatterplot {
    #region PRIVATE FIELDS
        private Pen pen_main                  = new Pen(Color.Black);
        private Random rand                   = new Random();
        private List<object> scatterplot_data = new List<object>();
        private StringBuilder csv_data        = new StringBuilder();
        private List<PlotData> scatterplots   = new List<PlotData>();   

        private ListBox     listBox;     
        private ProgressBar progressBar; 
        
        private int plots_created = 0;
        private int id            = 0;  
        private int regenerations_value ;
        private int plot_time;
    #endregion

    #region ENUMS
        public enum Info {
            Points1 ,
            HullPoints1,
            Area1,
            Points2,
            HullPoints2,
            Area2,
            Bitmap,
            BitmapAxes,
            BitmapBox
        }//end enum

        public enum SizeMode {
            PlotsEqual,
            Plot1Bigger,
            Plot2Bigger
        }//end enum
    #endregion

    #region PROPERTIES
        public string SaveLocation {get; set;} = null;

        public SizeMode PlotSizeMode {get; set;} = SizeMode.PlotsEqual;

        public bool ShowHull{get; set;} = false;

        public int HullLineThickness{get; set;} = 2;

        public Color HullColor{get; set; } = System.Drawing.Color.CornflowerBlue;

        public int PointSize{get; set;} = 8;

        public Color PointColor{get; set;} = System.Drawing.Color.IndianRed;

        public bool ShowCentralPoint{get; set;} = false;

        public Color CentralPointColor{get; set;} = System.Drawing.Color.CornflowerBlue;

        public bool ShowAxis{get; set;} = true;

        public int AxisOffset{get; set;} = 16;

        public Color AxisColor{get; set;} = System.Drawing.Color.Black;

        public int AxisLineThickness{get; set;} = 4;

        public int ScatterplotSize{get; set;} = 512;

        public List<object> ScatterplotData { 
            get {
                return scatterplot_data;
            }//end Get

            private set {
                scatterplot_data = value;
            }//end set
        }//end property

        public int Regenerations {
            get {
                return regenerations_value;
            }//end get

            private set {
                regenerations_value = value;
            }// end Set
        }//end property

        public int PlotTime { 
            get {
                return plot_time;
            }//end Get

            private set {
                plot_time = value;
            }//end Set
        }//end property

    #endregion

    #region CONSTRUCTORS
        public Scatterplot() {
            //Use me if you need me
        }//end constructor

    #endregion

    #region PRIVATE METHODS
        private void Draw_Hull(List<Point> convex_hull_points , Graphics grp_temp ,int x_offset  , int y_offset) {
            pen_main.Color = HullColor;
            pen_main.Width = HullLineThickness;

            Point previous_point;
            Point current_point;

            for (int point_index = 1; point_index < convex_hull_points.Count ; point_index += 1){
                previous_point = convex_hull_points[point_index - 1];
                current_point = convex_hull_points[point_index];
                grp_temp.DrawLine(pen_main, previous_point.X + x_offset, previous_point.Y + y_offset, (current_point.X + x_offset), current_point.Y + y_offset);
            }//end for
        }//end function

        private void Draw_Points(List<Point> points, Graphics grp_temp, int x_offset, int y_offset) {
            pen_main.Color = PointColor;

            foreach (Point current_point in points){
                grp_temp.FillEllipse(pen_main.Brush, current_point.X - (PointSize / 2) + x_offset, (current_point.Y - PointSize / 2) + y_offset, PointSize, PointSize);
            }//end foreach

            if (ShowCentralPoint) {
                pen_main.Color = CentralPointColor;
                grp_temp.FillEllipse(new Pen(Color.CornflowerBlue).Brush, -(PointSize / 2) + x_offset, -PointSize / 2 + y_offset, PointSize, PointSize);
            }//end if
        }//end function

        private void Draw_Axes(Graphics grp_temp, int offset = 0) {
            pen_main.Color = AxisColor;
            pen_main.Width = AxisLineThickness;
        
            int width  = (int)grp_temp.VisibleClipBounds.Width;
            int height = (int)grp_temp.VisibleClipBounds.Height;
        
            grp_temp.DrawLine(pen_main, offset, offset, offset, height - offset);
            grp_temp.DrawLine(pen_main, offset, height - offset, width - offset, height - offset);
        }//end function
 
        private void Draw_Box(Graphics grp_temp){
            pen_main.Color = AxisColor;
            pen_main.Width = AxisLineThickness;
        
            int width  = (int)grp_temp.VisibleClipBounds.Width;
            int height = (int)grp_temp.VisibleClipBounds.Height;
        
            grp_temp.DrawRectangle(pen_main, 16, 16, width - 32, height - 32);
        }//end function  
    #endregion
    
    #region PUBLIC METHODS
        public void SetListBox(ListBox associatedListbox ){
            listBox = associatedListbox;
        }//end method
         
        public void SetProgressBar(ProgressBar associatedProgressBar ){
            progressBar = associatedProgressBar;
        }//end method

        public List<PlotData> MakeScatterplots(double startRadius, double endRadius , double radiusGrowthRate, int count , int pointCount, bool label = false){
            Bitmap   bmp_scatterplot;
            Graphics grp_scatterplot_canvas;
            Cluster  Cluster1                = new Cluster();
            Pen      text_pen                = new Pen(Color.Black);
            Font     text_font               = new Font("Brass Mono Cozy", 18, FontStyle.Bold, GraphicsUnit.Point);
            int      plot_size               = (int)Math.Ceiling(startRadius * 2);
            int      plot_position           = plot_size / 2;
            int      currentCount            = 0;
            int      total_generations       = 0;
            double   current_radius          = startRadius;
            bool     keep_going              = true;

 
            if (progressBar != null){
                progressBar.Value = 0;
                progressBar.Visible = true; 
                progressBar.Maximum = (int)(((endRadius - startRadius) * count) / radiusGrowthRate) + count;
            }//end if

            while (keep_going){
                //RESET RADIUS AND CLEAR PLOTS TO TRY AGAIN
                scatterplots.Clear();

                if ( listBox != null ) {
                    listBox.Items.Add("--- NEW RUN ---");
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }//end if

                while (current_radius <= endRadius){
                    Application.DoEvents();

                    while (currentCount < count) {
                    //UPDATE CONTROLS (IF NEEDED)
                        if (listBox != null) {
                            listBox.Items.Add("Building plot : " + currentCount.ToString());
                        }//end if
                       
                        if (progressBar != null){
                            progressBar.Value += 1;
                        }//end if

                    //SETUP CANVAS FOR SCATTERPLOT
                        plot_size = (int) Math.Ceiling(current_radius * 2);

                        if (ShowAxis) {
                            plot_size += (int) (AxisOffset * 1.75);
                        }//end if

                        plot_position = plot_size / 2;

                        bmp_scatterplot = new Bitmap(plot_size, plot_size);

                        grp_scatterplot_canvas = Graphics.FromImage(bmp_scatterplot);
                        grp_scatterplot_canvas.FillRegion(new Pen(Color.White).Brush, new Region(new Rectangle(0, 0, bmp_scatterplot.Width, bmp_scatterplot.Height)));
                        Cluster1.ClusterRadius = (int)current_radius;
                        Cluster1.ClusterPointCount = pointCount;
                        Cluster1.Build(ShowHull);

                        //DRAW SCATTERPLOT
                        if (ShowAxis) {
                            Draw_Axes(grp_scatterplot_canvas, AxisOffset);
                        }//end if

                        Draw_Points(Cluster1.Points, grp_scatterplot_canvas, plot_position, plot_position);

                        if (ShowHull) {
                            Draw_Hull(Cluster1.HullPoints, grp_scatterplot_canvas, plot_position, plot_position);
                        }//end if

                        if (label) {
                            grp_scatterplot_canvas.DrawString(Cluster1.Area.ToString(), text_font, text_pen.Brush, 0, 0);
                        }//end if

                        //ADD TO LIST
                        scatterplots.Add(new PlotData(bmp_scatterplot, Math.Floor(Cluster1.Area).ToString()));

                        currentCount += 1;
                    }//end while

                    currentCount = 0;
                    current_radius += radiusGrowthRate;
                }//end while

                if (listBox != null ) {
                    listBox.Items.Add("--- SAVING NEW RUN ---");
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }//end if

                //Application.DoEvents();

                keep_going = SaveScatterplots(SaveLocation);
            }//end while

            //RESET PROGRESS BAR
            if (progressBar != null) {
                progressBar.Visible = false;
                progressBar.Value = 0;
            }//end if

            return scatterplots;
        }//end method

        public bool SaveScatterplots(string directory_name) {
            Bitmap bitmap;
            DateTime dtmNow        = DateTime.Now; 
            string string_id;
            string filename;
            bool   added_new_plots = false;
            int    count           = 1;
            string timeString      = dtmNow.ToLongDateString() + " " + dtmNow.ToLongTimeString().Replace(":","-");
            int    plotnum         = 0;

            //SETUP DIRECTORY
                directory_name = directory_name + "\\" + timeString;
           
                if ( ! Directory.Exists(directory_name) ) {
                    Directory.CreateDirectory(directory_name);
                }//end if

            //SAVE PLOTS
                foreach (PlotData plt_data in scatterplots) {
                    bitmap = plt_data.PlotBitmap;

                    if (plt_data.PlotArea != "0") {
                        string_id = plt_data.PlotArea;
                    }else{
                        string_id = plotnum.ToString();
                        plotnum += 1;
                    }//end if

                    filename = directory_name + "\\" + string_id + ".png";

                    if (! File.Exists(filename)){
                        added_new_plots = true;

                        if (listBox != null){
                            listBox.Items.Add("Added : # " + count.ToString() + " --> " + string_id);
                        }//end if
                        count += 1;
                    
                        //Application.DoEvents()
                    
                        bitmap.Save(filename, ImageFormat.Png);
                    }//end if
                }//end foreach

            return added_new_plots;
        }//end method
   
        public void SaveCsv( string filename){
            StreamWriter out_file = new StreamWriter(filename);

            out_file.Write(csv_data.ToString());
            out_file.Close();
        }//end method

        public Bitmap Resize_Image(Image img, int width , int height) {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            Graphics grp_temp = Graphics.FromImage(destImage);

            grp_temp.CompositingMode = CompositingMode.SourceCopy;
            grp_temp.CompositingQuality = CompositingQuality.HighQuality;
            grp_temp.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grp_temp.SmoothingMode = SmoothingMode.HighQuality;
            grp_temp.PixelOffsetMode = PixelOffsetMode.HighQuality;

            ImageAttributes wrp_mode = new ImageAttributes();
            wrp_mode.SetWrapMode(WrapMode.TileFlipXY);
            grp_temp.DrawImage(img, destRect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrp_mode);
            
            return destImage;
        }//end function
    
    #endregion


}//end class

