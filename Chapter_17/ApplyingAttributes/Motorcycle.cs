using System.Text.Json.Serialization;

namespace ApplyingAttributes
{
    public class Motorcycle
    {
        [JsonIgnore]
        public float weightOfCurrentPassengers;
        public bool hasRadioSystem;
        public bool hasHeadSet;
        public bool hasSissyBar;

    }
}