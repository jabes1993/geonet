using System;
using GeoidHeightsDotNet;
using geonet.interfaces;
using geonet.helpers;

namespace geonet.lib
{
    public class ComputeMSL : IComputeMSL
    {
        public ComputeMSL(){}

        /* GetMSLResult from the parameter as lat, lon, and gps elevation */
        public double GetMSLResult(double lat, double lon, double gpsElevation) =>
            Helper.GetMSL(Helper.GetGeoID(lat, lon), gpsElevation);

        /* GetWSG84Result from the parameter gpsElevation and mslElevation */
        public double GetWSG84Result(double gpsElevation, double mslElevation) =>
            Helper.ConvertMSLToWSG84(gpsElevation, mslElevation);

         /* GetGeoID from lat and lon */
        public double GetGeoID(double lat, double lon) => 
            Helper.GetGeoID(lat, lon);
    }
}
