using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleSerialize
{
    public class Radio
    {
        public bool HasTweeters { get; set; }
        public bool HasSubWoofers { get; set; }
        public List<double> StationPresets { get; set; }
        public string RadioId { get; set; } = "XF-552RR6";

        public override string ToString()
        {
            var presets = string.Join(",", StationPresets.Select(i => i.ToString(CultureInfo.InvariantCulture)).ToList());
            return $"HasTweeters: {HasTweeters} HasSubWoofers: {HasSubWoofers} Station Presets: {presets}";
        }
    }
}