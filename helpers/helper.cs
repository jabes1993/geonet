using System;
using GeoidHeightsDotNet;

namespace geonet.helpers
{
    public class Helper
    {
        /* Get the geoID from undulation lat and lon */
        public static double GetGeoID(double lat, double lon) =>
            GeoidHeights.undulation(lat, lon);

        /* Get the msl (mean seal level) elevation from geoID and gps elevation */
        public static double GetMSL(double geoID, double gpsElevation) =>
           gpsElevation - geoID;
        
        /* Convert msl to wsg84 */
        public static double ConvertMSLToWSG84(double gpsElevation, double mslElevation) =>
            gpsElevation + mslElevation;
    }
}