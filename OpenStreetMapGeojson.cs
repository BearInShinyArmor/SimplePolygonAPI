﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SimplePolygonAPI
{
    public class OpenStreetMapGeojson 
    { 
        public int place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public long osm_id { get; set; }
        public string[] boundingbox { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
        public string _class { get; set; }
        public string type { get; set; }
        public float importance { get; set; }
        public string icon { get; set; }
        public Geojson geojson { get; set; }
    }

    public class Geojson
    {
        public string type { get; set; }
        public object[] coordinates { get; set; }
    }


}
