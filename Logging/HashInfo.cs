﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Logging
{
    public class HashInfo
    {
        public string Version { get; set; }
        public string Url { get; set; }

        public int APICalles { get; set; }

        public double TotalTimes { get; set; }
        public double Slowest { get; set; }
        public double Fastest { get; set; }

        public double Last60MinAPICalles { get; set; }
        public double Last60MinAPIAvgTime { get; set; }
        public string Expired { get; set; }
        public string MaskedAPIKey { get; internal set; }
    }
}
