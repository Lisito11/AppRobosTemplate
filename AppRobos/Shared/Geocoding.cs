﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRobos.Shared {
    public class Geocoding {
        public class AddressComponent {
            [JsonProperty("long_name")]
            public string LongName { get; set; }

            [JsonProperty("short_name")]
            public string ShortName { get; set; }

            [JsonProperty("types")]
            public List<string> Types { get; set; }
        }

        public class Location {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }
        }


        public class Geometry {
            [JsonProperty("location")]
            public Location Location { get; set; }
        }

        public class Result {
            [JsonProperty("address_components")]
            public List<AddressComponent> AddressComponents { get; set; }

            [JsonProperty("formatted_address")]
            public string FormattedAddress { get; set; }

            [JsonProperty("geometry")]
            public Geometry Geometry { get; set; }

            [JsonProperty("place_id")]
            public string PlaceId { get; set; }

            [JsonProperty("types")]
            public List<string> Types { get; set; }
        }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
