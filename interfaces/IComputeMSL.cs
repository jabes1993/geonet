using System.Runtime.InteropServices;
using RGiesecke.DllExport;
using geonet.helpers;

namespace geonet.interfaces
{
    public interface IComputeMSL
    {
        // DLL Export from msl result
        [DllExport(HelperStr.GetMSLDLL, CallingConvention.Cdecl)]
        double GetMSLResult(double lat, double lon, double gpsElevation);
        // DLL Export from WSG84
        [DllExport(HelperStr.GetWSG84DLL, CallingConvention.Cdecl)]
        double GetWSG84Result(double gpsElevation, double mslElevation);
        // GetGeoID returns the geoID
        [DllExport(HelperStr.GetGeoIDDLL, CallingConvention.Cdecl)]
        double GetGeoID(double lat, double lon);
    }
}