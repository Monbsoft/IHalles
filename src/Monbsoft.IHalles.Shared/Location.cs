namespace Monbsoft.IHalles.Shared
{
    public class Location
    {
        public Location()
        {
        }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public static Location Interpolate(Location start, Location end, double proportion)
        {
            // The Earth is flat, right? So no need for spherical interpolation.
            return new Location(
                start.Latitude + (end.Latitude - start.Latitude) * proportion,
                start.Longitude + (end.Longitude - start.Longitude) * proportion);
        }
    }
}