﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcSoftware.SourcingProviders.HomeAdvisor
{
    public class ProspectReview
    {
        public const int StarsRatingMax = 5;

        public Service Service { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string StreetAddress { get; set; }

        public string AddressLocality { get; set; }

        public string AddressRegion { get; set; }

        public string PostalCode { get; set; }

        public int ReviewCount { get; set; }

        public int StarsRating { get; set; }
    }
}
