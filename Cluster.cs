class Cluster {
    #region BACKING FIELDS
        private List<Point> _clusterPoints     = new List<Point>();
        private List<Point> _clusterHullPoints = new List<Point>();
        private double      _clusterArea       = 0.0;
    #endregion

    #region PROPERTIES
        public double ClosePercent      {get;} //% of points that are close to center of cluster
        public double CloseThreshold    {get;} //threshold of what is considered close to center of cluster
        public int    ClusterPointCount {get; set;}  
        public int    ClusterRadius     {get; set;}      

        public List<Point> Points { 
            get{return _clusterPoints;}
            private set{ _clusterPoints = value;}
        }//end propeerty
        
        public List<Point> HullPoints { 
            get{return _clusterHullPoints;}
            private set{ _clusterHullPoints = value;}
        }//end propeerty

        public double Area { 
            get{return _clusterArea;}
            private set{_clusterArea = value;}
        }//end propeerty      
    #endregion

    #region PUBLIC METHODS
        public void Build(bool buildHull = false) {
            Points     = GenerateScatterplot(ClosePercent, CloseThreshold, ClusterPointCount, ClusterRadius);
            
            if (buildHull) {
                HullPoints = GenerateConvexHull(Points);
                Area       = CalculateClusterArea(HullPoints);
            }//end if
        }//end method       
    #endregion

    #region PRIVATE METHODS
        private List<Point> GenerateScatterplot(double closePercent,double closeThreshold,int pointCount ,int radius ) {
            //LOCAL VARIABLES
                int px                  = 0;
                int py                  = 0;
                double alpha            = 0.0;
                double length           = 0.0;
                List<Point> plot_points = new List<Point>();
                int closeCount          = 0;
                double scaledRandom     = 0.0;
                Random rnd              = new Random();

            //PERCENT THAT ARE CLOSE TO CENTER
                closePercent = Math.Min(closePercent, 1.0);
                closePercent = Math.Max(closePercent, 0.0);

            //HOW TIGHTLY CLOSE POINTS ARE PACKED
                closeThreshold = Math.Min(closeThreshold, 1.0);
                closeThreshold = Math.Max(closeThreshold, 0.0);

            //HOW MANY POINTS SHPULD BE CLOSE TO CENTER
                closeCount = (int)(pointCount * closePercent);

            //SUBTRACT CLOSE POINTS FROM TOTAL
                pointCount = pointCount - closeCount;

            while (pointCount > 0 || closeCount > 0) {
                //CALCULATE RANDOM POSITION AROUND A CIRCLE
                    alpha = rnd.NextDouble() * (2 * Math.PI);

                    scaledRandom = rnd.NextDouble() * closeThreshold;

                    if (closeCount > 0) {//then
                        //PLOT CLOSE POINTS
                            length = scaledRandom * radius;
                            px = (int) (+Math.Cos(alpha) * length);
                            py = (int) (-Math.Sin(alpha) * length);
                            plot_points.Add(new Point(px, py));
                            closeCount = closeCount - 1;
                    }else if (pointCount > 0) {//then
                        //PLOT OTHER POINTS
                            length = (closeThreshold + rnd.NextDouble() * (1 - closeThreshold)) * radius;
                            px = (int) (+Math.Cos(alpha) * length);
                            py = (int) (-Math.Sin(alpha) * length);
                            plot_points.Add(new Point(px, py));
                            pointCount = pointCount - 1;
                    }// End If
            }//end while

            return plot_points;
        }//end Function

        private List<Point> GenerateConvexHull(List<Point> pointList){
            int PointCompareX(Point pnt) {return pnt.X;};
            int PointCompareY(Point pnt) {return pnt.Y;};

            Point pointOnHull        = pointList.OrderBy(PointCompareX).ThenBy(PointCompareY).ToList().First(); //leftmost point is guaranteed to be part of the convex hull
            Point startPoint         = pointOnHull;
            Point endpoint           = new Point();
            List< Point> hullPoints  = new List< Point>();
            bool hullPoint           = false;
            bool onLeft              = false;

            do {
                hullPoints.Add(pointOnHull);
                endpoint = pointList[0];      //initial endpoint for a candidate edge on the hull

                for (int pointIndex = 0; pointIndex < pointList.Count ; pointIndex += 1) {
                    hullPoint = endpoint == pointOnHull;
                    onLeft = CounterClockwise(pointOnHull, endpoint, pointList[pointIndex]) == -1;

                    if (hullPoint || onLeft) {//then
                        endpoint = pointList[pointIndex];   //found greater left turn, update endpoint
                    }//end If
                }//next pointIndex

                pointOnHull = endpoint;
            }while( endpoint != hullPoints[0]); //Wrap around to first hull point

            hullPoints.Add(startPoint);

            return hullPoints;
    }//end Function
    
        int CounterClockwise(Point point1 , Point point2, Point point3) {
            int orientation = (point2.X - point1.X) * (point3.Y - point1.Y) - (point3.X - point1.X) * (point2.Y - point1.Y);
            return Math.Sign(-orientation);
        }//end Function

        double CalculateClusterArea(List<Point> pointList) {
            int area = 0;                                    // Accumulates area In the Loop
            int previousPointIndex = pointList.Count - 1; // The last vertex Is the 'previous' one to the first

            for (int pointIndex = 0; pointIndex < pointList.Count - 1; pointIndex += 1) {
                area = area + (pointList[previousPointIndex].X + pointList[pointIndex].X) * (pointList[previousPointIndex].Y - pointList[pointIndex].Y);
                previousPointIndex = pointIndex;
            }//next

            return area / 2.0;
        }//end function
    #endregion

}//end class

