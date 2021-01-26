using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Model
{
    public class Point
    {
        public Guid UID { get; set; }

        public Guid RouteUID { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime? EarliesTime { get; set; }

        public DateTime? LatestTime { get; set; }
        public int? Priority { get; set; }
        public Guid? PreviousPointUID { get; set; }
    }
}
