using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;


namespace SimpleSerialize
{
    public class Car
    {
        public Radio TheRadio { get; set; } = new Radio();
        public bool IsHatchBack { get; set; }

        public override string ToString() => $"IsHatchback: {IsHatchBack} Radio: {TheRadio}";
    }
}