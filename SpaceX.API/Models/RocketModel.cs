using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.API.Models
{
    public class RocketModel
    {
        public string Rocket_name { get; set; }
        public string Rocket_type { get; set; }
        public SecondStageModel Second_stage { get; set; }
    }
}
