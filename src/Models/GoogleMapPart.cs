﻿using OrchardCore.ContentManagement;

namespace ThisNetWorks.OrchardCore.GoogleMaps.Models
{
    public class GoogleMapPart : ContentPart
    {
        /// <summary>
        /// Location returned from google places, if places has been used to select location.
        /// </summary>
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}