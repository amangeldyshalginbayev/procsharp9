using System.Collections;

namespace ForEachWithExtensionMethods
{
    public static class GarageExtensions
    {
        public static IEnumerator GetEnumerator(this Garage garage) => garage.CarsInGarage.GetEnumerator();
    }
}