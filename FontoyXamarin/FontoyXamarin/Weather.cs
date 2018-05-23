﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FontoyXamarin
{
    public class Weather
    {
        // Because labels bind to these values, set them to an empty string to
        // ensure that the label appears on all platforms by default.
        public string Title { get; set; } = " ";
        public string Temperature { get; set; } = " ";

        public string TemperatureNow { get; set; } = " ";
        public string PressionNow { get; set; } = " ";
        public string PluieNow { get; set; } = " ";
        public string VentVitesseNow { get; set; } = " ";
        public string VentDirectionNow { get; set; } = " ";
        public string RisqueNeigeNow { get; set; } = " ";
        public string NebulositeNow { get; set; } = " ";

        public string TemperatureH6 { get; set; } = " ";
        public string PressionH6 { get; set; } = " ";
        public string PluieH6 { get; set; } = " ";
        public string VentVitesseH6 { get; set; } = " ";
        public string VentDirectionH6 { get; set; } = " ";
        public string RisqueNeigeH6 { get; set; } = " ";
        public string NebulositeH6 { get; set; } = " ";

        public string TemperatureH12 { get; set; } = " ";
        public string PressionH12 { get; set; } = " ";
        public string PluieH12 { get; set; } = " ";
        public string VentVitesseH12 { get; set; } = " ";
        public string VentDirectionH12 { get; set; } = " ";
        public string RisqueNeigeH12 { get; set; } = " ";
        public string NebulositeH12 { get; set; } = " ";


    }
}
