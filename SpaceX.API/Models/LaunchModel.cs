using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.API.Models
{
    public class LaunchModel
    {
        public int Flight_number { get; set; }

        public DateTime Launch_date_utc { get; set; }

        public DateTime Launch_date_central
        {
            get
            {
                TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                return TimeZoneInfo.ConvertTimeFromUtc(Launch_date_utc, tz);
            }
        }

        public RocketModel Rocket { get; set; }

        public bool Launch_success { get; set; }

        public LinksModel Links { get; set; }

    }
}
