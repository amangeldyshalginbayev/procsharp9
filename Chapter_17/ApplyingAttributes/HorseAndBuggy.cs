using System;
using System.Xml.Serialization;

namespace ApplyingAttributes
{
    [XmlRoot(Namespace = "https://www.MyCompany.com"), Obsolete("Use another vehicle!")]
    public class HorseAndBuggy
    {
        
    }
}