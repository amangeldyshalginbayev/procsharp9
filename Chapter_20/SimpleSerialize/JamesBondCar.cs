using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;


namespace SimpleSerialize
{
    [Serializable, XmlRoot(Namespace = "https://www.amansdev.com")]
    public class JamesBondCar : Car
    {
        //[XmlAttribute]
        public bool CanFly { get; set; }
        //[XmlAttribute]
        public bool CanSubmerge { get; set; }

        public override string ToString() => $"CanFly: {CanFly}, CanSubmerge: {CanSubmerge} {base.ToString()}";
    }
}