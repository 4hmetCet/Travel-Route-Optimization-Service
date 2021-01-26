using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TravelRouteOptimizationService.Model.Contracts
{
    public class SaveRouteRequest
    {
        public Guid UserUID { get; set; }
        public Guid UID { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Bounds { get; set; }
        public int TravelType { get; set; }
        public List<Point> PointList { get; set; }

    }
}
