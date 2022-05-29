using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;


namespace SimpleSerialize
{
    public class Person
    {
        public bool IsAlive { get; set; } = true;
        private int PersonAge { get; set; } = 21;
        private string _fName { get; set; } = string.Empty;

        [JsonPropertyName("socialSecurityNumber")]
        public string SSN  = "911012350583";

        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public override string ToString() => $"IsAlive: {IsAlive} FirstName: {FirstName} Age: {PersonAge} ";
    }
}