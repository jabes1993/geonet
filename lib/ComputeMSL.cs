using geonet.helpers;

namespace geonet 
{
    public class ComputeMSL
    {
        /* GetMSLResult from the parameter as lat, lon, and gps elevation */
        [DllExport("GetMSLResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall)]
        public static double GetMSLResult(double lat, double lon, double gpsElevation) =>
            Helper.GetMSL(Helper.GetGeoID(lat, lon), gpsElevation);

        /* GetWSG84Result from the parameter gpsElevation and mslElevation */
        [DllExport("GetWSG84Result", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall)]
        public static double GetWSG84Result(double gpsElevation, double mslElevation) =>
            Helper.ConvertMSLToWSG84(gpsElevation, mslElevation);

         /* GetGeoID from lat and lon */
         [DllExport("GetGeoID", CallingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall)]
        public static double GetGeoID(double lat, double lon) => 
            Helper.GetGeoID(lat, lon);
    }
}
